using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using ArchiveB1;
using b1.ECS;
using b1.Plugins.AsyncLoadingScreen;
using CommB1;
using Diana.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GSE.GSSdk;
using GSE.OnlineBase;
using GurGsPersistent;
using OssB1;
using ResB1;
using UnrealEngine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_GameArchiveMgr")]
public class BGW_GameArchiveMgr : GameInstanceSystemBaseUObj
{
	public enum ArchiveNotReadyReason
	{
		None,
		InvalidArchiveId,
		GameStoped,
		LevelDataNotReady,
		GSGGameplayerNotReady,
		WaitDelayFrame,
		WaitArchiveLockRelease
	}

	public class CheckArchiveReadyResult
	{
		public ArchiveNotReadyReason Reason;

		public int Param;

		public string Message = "";
	}

	private static readonly int ARCHIVE_CONST_ARCHIVE_COUNT_MAX;

	private static readonly int ARCHIVE_CONST_DELAY_SAVE_SNAPSHOT_FRAME_CONST;

	private static readonly int ARCHIVE_CONST_SAVE_ARCHIVE_SNAPSHOT_TIMEOUT;

	private static readonly int ARCHIVE_CONST_SEQ_PLAY_LOCK_TIMEOUT;

	private static readonly int ARCHIVE_CONST_SAVE_ROLEDATA_CD;

	private static readonly byte[] ARCHIVE_XOR_ENCRYPT_MATIC_KEY_LONG;

	private static readonly bool ARCHIVE_CHECK_MD5_FLAG;

	private static readonly bool ARCHIVE_CHECK_REVISION_FLAG;

	public static readonly string ARCHIVE_MD5_MAGIC_SALT;

	private ArchiveMgrRunningState RunningState;

	public BGW_ArchiveReadWriteWorker ArchiveWorker;

	private ArchiveSlot[] _ArchiveSlotArray;

	private bool IsArchiveSummaryDataInit;

	private int _CurrentArchiveId = -1;

	private string _CurrentArchiveUid = "";

	private string _CurrentShareArchiveUid = "";

	private int NextArchiveTransactionId;

	private int LastRequestTransactionId;

	public Del_FetchRoleData FetchGSGRoleDataHandler;

	public Del_CheckIsPlayerReadySave GSGCheckPlayerReadySaveHandler;

	private GameArchiveContext _CurrentContext = new GameArchiveContext();

	private float LogArchiveTickPauseDeltaTime;

	public static byte[] s_md5_calc_buff;

	public FetchRoleDataResult FetchRoleDataResult = new FetchRoleDataResult();

	private CheckIsPlayerReadySaveResult CheckIsPlayerReadySaveResult = new CheckIsPlayerReadySaveResult();

	public const int IGNORE_LOCK_TRANSACTION_ID = -9999;

	private static float LogArchiveDelaySaveDeltaTime;

	public override bool bTickEnabled => true;

	private GameArchiveContext CurrentGameArchiveContext => _CurrentContext;

	private bool HasPendingSaveRequest => CurrentGameArchiveContext.PendingSaveArchiveRequest.Count > 0;

	private ArchiveSlot[] ArchiveSlot
	{
		get
		{
			if (_ArchiveSlotArray == null)
			{
				InitArchiveSlotInfo();
			}
			return _ArchiveSlotArray;
		}
	}

	public int CurrentArchiveId => _CurrentArchiveId;

	public string CurrentArchiveUid => _CurrentArchiveUid;

	public string SharedArchiveUid
	{
		get
		{
			CheckInitShareArchiveUid();
			return _CurrentShareArchiveUid;
		}
	}

	public override void OnInit()
	{
		ArchiveWorker = new BGW_ArchiveReadWriteWorker(this, ARCHIVE_CONST_ARCHIVE_COUNT_MAX);
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		if (SharedRuntimeState.CurrentRuntime == EDotNetRuntime.CoreCLR)
		{
			GSGCheckPlayerReadySaveHandler = null;
			FetchGSGRoleDataHandler = null;
		}
	}

	public static BGW_GameArchiveMgr Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_GameArchiveMgr>(Context);
	}

	public static BGW_GameArchiveMgr Get(Entity Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_GameArchiveMgr>(Context);
	}

	public override int GetTickGroupMask()
	{
		return 2048;
	}

	private void SwitchArchiveState(ArchiveMgrRunningState ToState)
	{
		SysLogUtil.ARCHIVE.LogInfo($"SwitchArchiveState:{RunningState}->{ToState}");
		RunningState = ToState;
	}

	private void ResetCurrentArchiveContext()
	{
		SysLogUtil.ARCHIVE.LogInfo("Reset Archive Context");
		_CurrentContext = new GameArchiveContext();
	}

	private void InitArchiveSlotInfo()
	{
		_ArchiveSlotArray = new ArchiveSlot[ARCHIVE_CONST_ARCHIVE_COUNT_MAX];
		for (int i = 0; i < _ArchiveSlotArray.Length; i++)
		{
			_ArchiveSlotArray[i] = new ArchiveSlot(i + 1);
			bool isInUse = ArchiveWorker.QueryIsArchiveSlotInUse(_ArchiveSlotArray[i].ArchiveId);
			_ArchiveSlotArray[i].MarkInUse(isInUse);
		}
	}

	private ArchiveSlot GetNextAvaiableSlot()
	{
		ArchiveSlot[] archiveSlot = ArchiveSlot;
		foreach (ArchiveSlot archiveSlot2 in archiveSlot)
		{
			if (archiveSlot2.IsEmpty)
			{
				return archiveSlot2;
			}
		}
		return null;
	}

	private ArchiveSlot GetArchiveSlot(int ArchiveId)
	{
		int num = ArchiveId - 1;
		if (num >= 0 && num < ArchiveSlot.Length)
		{
			return ArchiveSlot[num];
		}
		return null;
	}

	private void RecycleArchiveSlot(int ArchiveId)
	{
		GetArchiveSlot(ArchiveId)?.Reset();
	}

	public bool IsArchiveSlotFull()
	{
		return GetNextAvaiableSlot() == null;
	}

	public bool HasArchiveFile()
	{
		ArchiveSlot[] archiveSlot = ArchiveSlot;
		for (int i = 0; i < archiveSlot.Length; i++)
		{
			if (archiveSlot[i].IsInUse)
			{
				return true;
			}
		}
		return false;
	}

	public bool NoArchiveFile()
	{
		return !HasArchiveFile();
	}

	private bool IsNeedTickArchiveLogic(out string Message)
	{
		if (IsGameStoped())
		{
			Message = "GameStop";
			return false;
		}
		if (IsCurrentArchiveIdInvalid(out Message))
		{
			return false;
		}
		if (IsGameLogicPause())
		{
			Message = "GameLogicPause";
			return false;
		}
		if (IsLoadingScreenOpen(out Message))
		{
			return false;
		}
		Message = "";
		return true;
	}

	private void LogArchiveTickStatus(float DeltaTime, string Message)
	{
		if (LogArchiveTickPauseDeltaTime >= 5f)
		{
			SysLogUtil.ARCHIVE.LogInfo("Archive Tick Pause, Reason:" + Message);
			LogArchiveTickPauseDeltaTime = 0f;
		}
		else
		{
			LogArchiveTickPauseDeltaTime += DeltaTime;
		}
	}

	private void TickSaveRoleDataArchiveCD(float DeltaTime)
	{
		if (CurrentGameArchiveContext.SaveRoleDataArchiveCD != 0f)
		{
			if (CurrentGameArchiveContext.SaveRoleDataArchiveCD > DeltaTime)
			{
				CurrentGameArchiveContext.SaveRoleDataArchiveCD -= DeltaTime;
			}
			else
			{
				CurrentGameArchiveContext.SaveRoleDataArchiveCD = 0f;
			}
		}
	}

	private void TickArchiveLogic(float DeltaTime)
	{
		if (!IsNeedTickArchiveLogic(out var Message))
		{
			LogArchiveTickStatus(DeltaTime, Message);
			return;
		}
		TickDelaySaveFrame();
		TickSaveRoleDataArchiveCD(DeltaTime);
		TickSaveArchiveSnapshot(DeltaTime);
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (TickGroup == 2048)
		{
			DeltaTime = Math.Min(DeltaTime, 0.125f);
			TickArchiveLogic(DeltaTime);
			TickArchiveMgrStop(DeltaTime);
			ArchiveWorker.Tick(DeltaTime);
		}
	}

	public void GameStart()
	{
		SwitchArchiveState(ArchiveMgrRunningState.Running);
		BUS_BattleInfoComp.QAAddArchiveInfo(EBattleInfoType.ArchiveInfo, "<effectnum>系统信息</><action>BGW_GameArchivedMgr is Running</>", 0);
	}

	private string _ReadArchiveUidFromFile()
	{
		ShareArchiveFile shareArchiveFile = ArchiveWorker.LoadShareArchiveFile(WaitAsyncTask: false);
		if (shareArchiveFile != null && shareArchiveFile.ArchiveInfo != null)
		{
			return shareArchiveFile.ArchiveInfo.ShareArchiveUid;
		}
		return "";
	}

	private void CheckInitShareArchiveUid()
	{
		if (_CurrentShareArchiveUid == "")
		{
			string text = _ReadArchiveUidFromFile();
			if (text != "")
			{
				SetCurrentShareArchiveUid(text);
				return;
			}
			string currentShareArchiveUid = GenShareArchiveUID();
			SetCurrentShareArchiveUid(currentShareArchiveUid);
			GSSDKReport.MonitorAdd(MonEvtCatogray.ARCHIVE, "GenNewShareArchiveUID", 1L, null);
		}
	}

	private void GameStop()
	{
		if (!IsGameStoped())
		{
			CurrentGameArchiveContext.OnStopSaveArchiveFinish?.Invoke();
			CurrentGameArchiveContext.OnStopSaveArchiveFinish = null;
			ResetCurrentArchiveContext();
			SwitchArchiveState(ArchiveMgrRunningState.Stopped);
			SetCurrentArchiveId(-1, "");
			SysLogUtil.ARCHIVE.LogInfo("ArchiveMgr is Stoped!");
			BUS_BattleInfoComp.QAAddArchiveInfo(EBattleInfoType.ArchiveInfo, "<effectnum>系统信息</><action>BGW_GameArchivedMgr is Stoped</>", 0);
		}
	}

	private void SetCurrentArchiveId(int ArchiveId, string ArchiveUid)
	{
		SysLogUtil.ARCHIVE.LogInfo($"SetCurrentArchiveId:{ArchiveId}, Uid:{ArchiveUid}");
		_CurrentArchiveId = ArchiveId;
		_CurrentArchiveUid = ArchiveUid;
	}

	private void SetCurrentShareArchiveUid(string ShareArchiveUid)
	{
		SysLogUtil.ARCHIVE.LogInfo("SetCurrentShareArchiveUid:" + ShareArchiveUid);
		_CurrentShareArchiveUid = ShareArchiveUid;
	}

	private static bool IsNeedEncryptArchive()
	{
		return DebugConfig.EnableEncrypt;
	}

	private ArchiveInfo GenNewArchiveInfo()
	{
		return new ArchiveInfo
		{
			CreateBuildRevision = GSVersionUtil.GetBuildRevision(),
			CreateTime = UBGWFunctionLibraryCS.GetUTCTimeStamp(),
			ArchiveVersion = 0,
			ProtocolTag = ProtocolTag.LatestVersionTag,
			ArchiveUid = GenArchiveUID(),
			EnableEncrypt = IsNeedEncryptArchive(),
			SdkUid = BGW_GSSdkMgr.GetLoginUserId(this, "InvalidSdkUid"),
			SharedArchiveUid = SharedArchiveUid
		};
	}

	private ArchiveInfo GenArchiveInfoForUpdate(int ArchiveId)
	{
		ArchiveInfo obj = GetCachedArchiveFileInfo(ArchiveId) ?? throw new Exception("GetCachedArchiveFileInfo is null!");
		obj.SaveBuildRevision = GSVersionUtil.GetBuildRevision();
		obj.ArchiveVersion++;
		obj.LastSaveTime = UBGWFunctionLibraryCS.GetUTCTimeStamp();
		obj.ProtocolTag = ProtocolTag.LatestVersionTag;
		obj.EnableEncrypt = IsNeedEncryptArchive();
		return obj;
	}

	private void CacheArchiveFileInfo(int ArchiveId, ArchiveInfo ArchiveInfo)
	{
		GetArchiveSlot(ArchiveId).CacheArchiveFileInfo(ArchiveInfo);
	}

	private ArchiveInfo GetCachedArchiveFileInfo(int ArchiveId)
	{
		return GetArchiveSlot(ArchiveId)?.ArchiveFileInfoClone;
	}

	public bool IsSeqPlaying()
	{
		foreach (ArchiveLock @lock in CurrentGameArchiveContext.LockList)
		{
			if (@lock.Source == EArchiveDelaySaveSource.SequencePlaying)
			{
				return true;
			}
		}
		return false;
	}

	public bool IsLoadingScreenOpen(out string Message)
	{
		Message = $"LoadingScreenState:{BGWGameInstanceCS.Get(this).GetCurLoadingScreenState()}";
		return BGWGameInstanceCS.Get(this).GetCurLoadingScreenState() != EGSLoadingScreenState.Idle;
	}

	public int CreateNewArchive(CreateArchiveSource Source)
	{
		ArchiveSlot nextAvaiableSlot = GetNextAvaiableSlot();
		if (nextAvaiableSlot == null)
		{
			GSSDKReport.MonitorAdd(MonEvtCatogray.ARCHIVE, "ArchiveSlotNotEnough", 1L, null);
			throw new Exception("Archive slot not enough!");
		}
		int archiveId = nextAvaiableSlot.ArchiveId;
		SysLogUtil.ARCHIVE.LogInfo($"CreateNewArchive:{archiveId}, Source:{Source}");
		BUS_BattleInfoComp.QAAddArchiveInfo(EBattleInfoType.ArchiveInfo, $"<effectnum>系统信息</><action>建立了存档槽位{archiveId}</>", 0);
		ArchiveInfo archiveInfo = GenNewArchiveInfo();
		CacheArchiveFileInfo(archiveId, archiveInfo);
		SetCurrentArchiveId(archiveId, archiveInfo.ArchiveUid);
		ArchiveOSS.ReportCreateArchive(this);
		return archiveId;
	}

	public static byte[] allocate_md5_buff(int NeedSize)
	{
		if (s_md5_calc_buff.Length < NeedSize)
		{
			int num;
			for (num = s_md5_calc_buff.Length; num < NeedSize; num *= 2)
			{
			}
			s_md5_calc_buff = new byte[num];
		}
		return s_md5_calc_buff;
	}

	public static string CalcByteArrayMD5(byte[] data, string salt)
	{
		try
		{
			MD5 mD = MD5.Create();
			byte[] bytes = Encoding.UTF8.GetBytes(salt);
			int num = data.Length + bytes.Length;
			byte[] array = allocate_md5_buff(num);
			data.CopyTo(array, 0);
			bytes.CopyTo(array, data.Length);
			byte[] array2 = mD.ComputeHash(array, 0, num);
			StringBuilder stringBuilder = new StringBuilder(array2.Length * 2);
			byte[] array3 = array2;
			foreach (byte b in array3)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
			return stringBuilder.ToString();
		}
		catch (Exception ex)
		{
			SysLogUtil.ARCHIVE.LogError("GetMd5Str Exception:" + ex.Message);
			return "";
		}
	}

	private static string GenArchiveUID()
	{
		return Guid.NewGuid().ToString();
	}

	private static string GenShareArchiveUID()
	{
		return Guid.NewGuid().ToString();
	}

	public ReadArchiveResult LoadUserSetting(out UISettingArchiveData SettingData)
	{
		return ArchiveWorker.LoadArchiveSettingFileSync(out SettingData);
	}

	public static byte[] SerializeArchiveDataToBytes(bool EnableEncrypt, IMessage Message)
	{
		byte[] array = new byte[Message.CalculateSize()];
		CodedOutputStream output = new CodedOutputStream(array);
		Message.WriteTo(output);
		if (EnableEncrypt)
		{
			Cipher.XorEncrypt(array, ARCHIVE_XOR_ENCRYPT_MATIC_KEY_LONG);
		}
		return array;
	}

	public static T DeserializeArchiveDataFromBytes<T>(bool EnableEncrypt, byte[] ArchiveDataBytes) where T : IMessage, new()
	{
		if (EnableEncrypt)
		{
			Cipher.XorDecrypt(ArchiveDataBytes, ARCHIVE_XOR_ENCRYPT_MATIC_KEY_LONG);
		}
		try
		{
			T val = new T();
			val.MergeFrom(ArchiveDataBytes);
			return val;
		}
		catch (Exception ex)
		{
			SysLogUtil.ARCHIVE.LogError("Parse FUStBEDArchivesData Failed, ex:" + ex.Message);
			return default(T);
		}
	}

	public static bool IsValidArchiveResult(ReadArchiveResult Result)
	{
		if (Result != ReadArchiveResult.Success)
		{
			if (DebugConfig.SkipRoleDataCheck)
			{
				return Result == ReadArchiveResult.RoleDataInvalid;
			}
			return false;
		}
		return true;
	}

	private void MergeShareArchiveData(FUStBEDArchivesData GameArchiveData, ShareArchiveFile ShareArchiveFile)
	{
		RoleMuseum roleMuseum = null;
		if (ShareArchiveFile != null)
		{
			if (UnpackShareArchiveFile(ShareArchiveFile, out var ShareArchiveFileUnpacked) == ReadArchiveResult.Success)
			{
				roleMuseum = ShareArchiveFileUnpacked.SharedRoleData.Clone();
			}
			else
			{
				SysLogUtil.ARCHIVE.LogError("UnpackShareArchiveFile Faiil!");
			}
		}
		if (roleMuseum == null)
		{
			if (RoleDataValidCheck.CheckRoleMeseumValid(GameArchiveData.RoleData.RoleCs.Museum, out var errMsgs))
			{
				roleMuseum = GameArchiveData.RoleData.RoleCs.Museum.Clone();
			}
			else
			{
				RoleDataValidCheck.NotifyArchiveDataVerifyInvalid("GameArchiveData.RoleData.RoleCs.Museum", errMsgs);
			}
		}
		if (roleMuseum == null)
		{
			SysLogUtil.ARCHIVE.LogError("ShareArchiveData Invalid, Reset to Empty!");
			GSSDKReport.MonitorAdd(MonEvtCatogray.ARCHIVE, "ShareArchiveInvalidReset", 1L, null);
			roleMuseum = new RoleMuseum();
		}
		GameArchiveData.RoleData.RoleCs.Museum = roleMuseum;
	}

	public ReadArchiveResult ReadArchiveData(int ArchiveId, out ArchiveFileUnpacked GameArchiveData)
	{
		GameArchiveData = new ArchiveFileUnpacked();
		GSArchiveFileContainer ReadArchiveDataContainer;
		ReadArchiveResult readArchiveResult = ArchiveWorker.LoadArchiveFileSync(ArchiveId, out ReadArchiveDataContainer);
		if (readArchiveResult != ReadArchiveResult.Success)
		{
			SysLogUtil.ARCHIVE.LogError($"ArchiveWorker.LoadArchive Failed, ArchiveId:{ArchiveId}, Result:{readArchiveResult}");
			return readArchiveResult;
		}
		ArchiveFile gameArchiveFile = ReadArchiveDataContainer.GameArchiveFile;
		GameArchiveData.ArchiveInfo = gameArchiveFile.ArchiveInfo;
		if (ARCHIVE_CHECK_REVISION_FLAG && GSVersionUtil.GetBuildRevision() < GameArchiveData.ArchiveInfo.SaveBuildRevision)
		{
			BGW_LogUtil.LogError($"AppRevision:{GSVersionUtil.GetBuildRevision()} less than ArchiveRevision:{GameArchiveData.ArchiveInfo.SaveBuildRevision}");
			return ReadArchiveResult.AppRevisionTooLow;
		}
		byte[] array = gameArchiveFile.GameArchivesDataBytes.ToByteArray();
		if (ARCHIVE_CHECK_MD5_FLAG)
		{
			string text = CalcByteArrayMD5(array, ARCHIVE_MD5_MAGIC_SALT);
			if (GameArchiveData.ArchiveInfo.Md5Str != text)
			{
				SysLogUtil.ARCHIVE.LogError("Check Archive Md5 fail, ArchiveInfo.Md5:" + GameArchiveData.ArchiveInfo.Md5Str + ", ArchiveBytesMd5:" + text);
				return ReadArchiveResult.CheckMd5Failed;
			}
		}
		FUStBEDArchivesData fUStBEDArchivesData = DeserializeArchiveDataFromBytes<FUStBEDArchivesData>(GameArchiveData.ArchiveInfo.EnableEncrypt, array);
		if (fUStBEDArchivesData == null)
		{
			SysLogUtil.ARCHIVE.LogError("Deserialize Archive Failed, ArchiveInfo:" + PbEncoding.ToString(GameArchiveData.ArchiveInfo));
			return ReadArchiveResult.DeserializeArchiveFailed;
		}
		if (ArchiveProtoVersionCheck.CheckFixArchiveData(GameArchiveData.ArchiveInfo.ProtocolTag, fUStBEDArchivesData))
		{
			GameArchiveData.ArchiveInfo.ProtocolTag = ProtocolTag.LatestVersionTag;
			SysLogUtil.ARCHIVE.LogInfo($"CheckFixArchiveData ArchiveID : {ArchiveId}, ArchiveInfo CreateTime: {GameArchiveData.ArchiveInfo.CreateTime}");
		}
		MergeShareArchiveData(fUStBEDArchivesData, ReadArchiveDataContainer.ShareArchiveFile);
		List<string> errMsgs;
		bool num = RoleDataValidCheck.CheckRoleDataValid(fUStBEDArchivesData.RoleData.RoleCs, out errMsgs);
		if (!num)
		{
			RoleDataValidCheck.NotifyArchiveDataVerifyInvalid(GSE_SaveGameUtil.GetArchiveSlotName(SaveFileType.Archive, ArchiveId), errMsgs);
		}
		if (!num && !DebugConfig.SkipRoleDataCheck)
		{
			return ReadArchiveResult.RoleDataInvalid;
		}
		GameArchiveData.GameArchiveData = fUStBEDArchivesData;
		return readArchiveResult;
	}

	private ReadArchiveResult _LoadArchive(int ArchiveId, LoadArchiveSource Source, out FUStBEDArchivesData OutArchiveData)
	{
		SysLogUtil.ARCHIVE.LogInfo($"BeginLoadArchive:{ArchiveId}");
		OutArchiveData = null;
		ArchiveFileUnpacked GameArchiveData;
		ReadArchiveResult readArchiveResult = ReadArchiveData(ArchiveId, out GameArchiveData);
		if (readArchiveResult != ReadArchiveResult.Success)
		{
			SysLogUtil.ARCHIVE.LogError($"ReadArchiveData Failed, Result:{readArchiveResult}");
			return readArchiveResult;
		}
		OutArchiveData = GameArchiveData.GameArchiveData;
		ArchiveInfo archiveInfo = GameArchiveData.ArchiveInfo;
		CacheArchiveFileInfo(ArchiveId, archiveInfo);
		SetCurrentArchiveId(ArchiveId, archiveInfo.ArchiveUid);
		SysLogUtil.ARCHIVE.LogInfo($"LoadArchive For Game Success, ArchiveInfo:{PbEncoding.ToString(archiveInfo)}, Source:{Source}");
		BUS_BattleInfoComp.QAAddArchiveInfo(EBattleInfoType.ArchiveInfo, $"<effectnum>系统信息</><action>读取了存档槽位{ArchiveId}</>", 0);
		if (DebugConfig.DevArchiveSizeCheck && !B1Global.GIsGameReleased && OutArchiveData.CalculateSize() > DebugConfig.DevArchiveSizeMax)
		{
			FMessage.OpenDialog("当前存档大小过大！请将存档发给程序进行检查", "");
		}
		return readArchiveResult;
	}

	public ReadArchiveResult LoadArchive(int ArchiveId, LoadArchiveSource Source, out FUStBEDArchivesData OutArchiveData)
	{
		ReadArchiveResult readArchiveResult = _LoadArchive(ArchiveId, Source, out OutArchiveData);
		if (readArchiveResult != ReadArchiveResult.Success)
		{
			SysLogUtil.ARCHIVE.LogError($"LoadArchive Failed, ArchiveId:{ArchiveId}, Source:{Source}, Error:{readArchiveResult}");
			GSSDKReport.MonitorAdd(MonEvtCatogray.ARCHIVE, "LoadArchiveError", 1L, $"Error={readArchiveResult},source={Source}");
		}
		return readArchiveResult;
	}

	public static ShareArchiveFile PackShareArchiveFile(RoleMuseum MuseumData, string ShareArchiveUid)
	{
		ShareArchiveInfo shareArchiveInfo = new ShareArchiveInfo
		{
			ShareArchiveUid = ShareArchiveUid,
			EnableEncrypt = IsNeedEncryptArchive()
		};
		byte[] array = SerializeArchiveDataToBytes(shareArchiveInfo.EnableEncrypt, MuseumData);
		shareArchiveInfo.Md5Str = CalcByteArrayMD5(array, ARCHIVE_MD5_MAGIC_SALT);
		return new ShareArchiveFile
		{
			ArchiveInfo = shareArchiveInfo,
			ShareArchiveDataBytes = ByteString.CopyFrom(array)
		};
	}

	private ReadArchiveResult UnpackShareArchiveFile(ShareArchiveFile ShareArchiveFile, out ShareArchiveFileUnpacked ShareArchiveFileUnpacked)
	{
		ShareArchiveFileUnpacked = null;
		ShareArchiveInfo archiveInfo = ShareArchiveFile.ArchiveInfo;
		if (archiveInfo == null)
		{
			SysLogUtil.ARCHIVE.LogError("ShareArchiveFile.ArchiveInfo is null!");
			return ReadArchiveResult.DeserializeArchiveFailed;
		}
		byte[] array = ShareArchiveFile.ShareArchiveDataBytes.ToByteArray();
		if (ARCHIVE_CHECK_MD5_FLAG)
		{
			string text = CalcByteArrayMD5(array, ARCHIVE_MD5_MAGIC_SALT);
			if (archiveInfo.Md5Str != text)
			{
				SysLogUtil.ARCHIVE.LogError("Check ShareArchive Md5 fail, ArchiveInfo.Md5:" + archiveInfo.Md5Str + ", ArchiveBytesMd5:" + text);
				return ReadArchiveResult.CheckMd5Failed;
			}
		}
		RoleMuseum roleMuseum = DeserializeArchiveDataFromBytes<RoleMuseum>(archiveInfo.EnableEncrypt, array);
		if (roleMuseum == null)
		{
			SysLogUtil.ARCHIVE.LogError("Parse RoleMuseum Failed!");
			return ReadArchiveResult.DeserializeArchiveFailed;
		}
		if (!RoleDataValidCheck.CheckRoleMeseumValid(roleMuseum, out var errMsgs))
		{
			RoleDataValidCheck.NotifyArchiveDataVerifyInvalid(GSE_SaveGameUtil.GetArchiveSlotName(SaveFileType.SharedArchive), errMsgs);
			return ReadArchiveResult.RoleDataInvalid;
		}
		ShareArchiveFileUnpacked = new ShareArchiveFileUnpacked
		{
			ArchiveInfo = archiveInfo,
			SharedRoleData = roleMuseum
		};
		return ReadArchiveResult.Success;
	}

	public ShareArchiveFileUnpacked LoadShareDataOnly()
	{
		ShareArchiveFile shareArchiveFile = ArchiveWorker.LoadShareArchiveFile(WaitAsyncTask: true);
		if (shareArchiveFile != null)
		{
			ShareArchiveFileUnpacked ShareArchiveFileUnpacked;
			ReadArchiveResult readArchiveResult = UnpackShareArchiveFile(shareArchiveFile, out ShareArchiveFileUnpacked);
			if (readArchiveResult == ReadArchiveResult.Success)
			{
				return ShareArchiveFileUnpacked;
			}
			SysLogUtil.ARCHIVE.LogError($"UnpackShareArchiveFile Fail:{readArchiveResult}");
		}
		return null;
	}

	public bool WriteSharedArchiveFileOnly(ShareArchiveFile shareArchiveFile)
	{
		return ArchiveWorker.SaveShareArchiveFileSync(shareArchiveFile);
	}

	private static ArchiveSummaryData GenArchiveSummaryData(int ArchiveId, ReadArchiveResult ReadResult, ArchiveInfo ArchiveInfo, FUStBEDArchivesData GameArchivesDataDoNotModify)
	{
		ArchiveSummaryData archiveSummaryData = new ArchiveSummaryData
		{
			ArchiveId = ArchiveId,
			ReadArchiveResult = ReadResult
		};
		if (ArchiveInfo != null)
		{
			archiveSummaryData.CreateTime = ArchiveInfo.CreateTime;
			archiveSummaryData.LastGameTime = ArchiveInfo.LastSaveTime;
			archiveSummaryData.ArchiveUid = ArchiveInfo.ArchiveUid;
			archiveSummaryData.SdkUid = ArchiveInfo.SdkUid;
			archiveSummaryData.SharedArchiveUid = ArchiveInfo.SharedArchiveUid;
		}
		if (GameArchivesDataDoNotModify != null)
		{
			GurGsPersistent.BPC_PlayerRoleData bPC_PlayerRoleData = GameArchivesDataDoNotModify.PersistentECSData?.BPCData?.BPCPlayerRoleData;
			RoleDataCS roleCs = GameArchivesDataDoNotModify.RoleData.RoleCs;
			RoleStaticsData staticsData = GameArchivesDataDoNotModify.RoleData.RoleClient.StaticsData;
			archiveSummaryData.MapId = bPC_PlayerRoleData?.MapId ?? 0;
			archiveSummaryData.RoleLevel = roleCs.Base.Level;
			archiveSummaryData.GameTotalTime = (uint)staticsData.SummaryStatics.GameTotalTime;
			archiveSummaryData.NewGameplusReady = roleCs.Chapter.GameCompelete == YesNoType.Yes;
			archiveSummaryData.MapAreaId = bPC_PlayerRoleData?.MapAreaId ?? 0;
			archiveSummaryData.NewGameplusCount = roleCs.Actor.NewGamePlusCount;
			archiveSummaryData.ChapterId = roleCs.Chapter.CurChapter;
			foreach (DictDeltaMsgInt_Int item in GameArchivesDataDoNotModify.PersistentECSData?.BPCData?.BPCRebirthPointData?.CurrentRebirthPointIDMap)
			{
				if (item.Key == archiveSummaryData.MapId)
				{
					archiveSummaryData.RebirthPointId = item.Value;
				}
			}
			foreach (ChapterData chapter in roleCs.Chapter.ChapterList)
			{
				if (chapter.Id != roleCs.Chapter.CurChapter)
				{
					continue;
				}
				foreach (int surprise in chapter.SurpriseList)
				{
					archiveSummaryData.SurpriseIdList.Add(surprise);
				}
				break;
			}
			archiveSummaryData.DataSize = GameArchivesDataDoNotModify.CalculateSize();
		}
		return archiveSummaryData.Clone();
	}

	private bool IsMapIdOutOfPlayGoPackage(int TravelMapId)
	{
		if (TravelMapId == BGUFuncLibMap.GetPrologueLevelId(this))
		{
			return false;
		}
		return true;
	}

	private bool IsGameCountOutOfPlayGoPackage(int GameCount)
	{
		return GameCount > 1;
	}

	public bool IsArchiveOutOfPlayGoPackage(ArchiveSummaryData ArchiveSummaryInfo)
	{
		if (!IsGameCountOutOfPlayGoPackage(ArchiveSummaryInfo.NewGameplusCount))
		{
			return IsMapIdOutOfPlayGoPackage(ArchiveSummaryInfo.MapId);
		}
		return true;
	}

	private void CheckLoadArchiveSummaryInfo()
	{
		if (IsArchiveSummaryDataInit)
		{
			return;
		}
		ArchiveSlot[] archiveSlot = ArchiveSlot;
		foreach (ArchiveSlot archiveSlot2 in archiveSlot)
		{
			if (archiveSlot2.IsInUse && archiveSlot2.SummaryData == null)
			{
				ArchiveFileUnpacked GameArchiveData;
				ReadArchiveResult readArchiveResult = ReadArchiveData(archiveSlot2.ArchiveId, out GameArchiveData);
				if (readArchiveResult != ReadArchiveResult.Success)
				{
					GSSDKReport.MonitorAdd(MonEvtCatogray.ARCHIVE, "LoadArchiveListError", 1L, $"Error={readArchiveResult}");
				}
				ArchiveSummaryData summaryData = GenArchiveSummaryData(archiveSlot2.ArchiveId, readArchiveResult, GameArchiveData.ArchiveInfo, GameArchiveData.GameArchiveData);
				archiveSlot2.CacheSummaryData(summaryData);
			}
		}
		IsArchiveSummaryDataInit = true;
	}

	private List<ArchiveSummaryData> _GetArchiveInfoList()
	{
		CheckLoadArchiveSummaryInfo();
		List<ArchiveSummaryData> list = new List<ArchiveSummaryData>();
		ArchiveSlot[] archiveSlot = ArchiveSlot;
		foreach (ArchiveSlot archiveSlot2 in archiveSlot)
		{
			if (archiveSlot2.IsInUse)
			{
				list.Add(archiveSlot2.SummaryData);
			}
		}
		return list;
	}

	public List<ArchiveSummaryData> LoadArchiveInfoList()
	{
		List<ArchiveSummaryData> list = new List<ArchiveSummaryData>();
		foreach (ArchiveSummaryData item in _GetArchiveInfoList())
		{
			list.Add(item.Clone());
		}
		return list;
	}

	public void FillAllArchiveInfoForOss(RepeatedField<RecLen> OssArchiveInfoList)
	{
		List<ArchiveSummaryData> list = _GetArchiveInfoList();
		foreach (ArchiveSummaryData item in list)
		{
			OssArchiveInfoList.Add(RoleDataHelper.GenOssArchiveInfo(item));
		}
		if (!list.Any((ArchiveSummaryData SummaryInfo) => SummaryInfo.ArchiveUid == CurrentArchiveUid))
		{
			OssArchiveInfoList.Add(RoleDataHelper.GenOssArchiveInfo(0, CurrentArchiveUid, 0, "New Create Archive"));
		}
	}

	public ArchiveSummaryData GetArchiveSummaryInfo(int ArchiveId, bool CloneData = true)
	{
		foreach (ArchiveSummaryData item in _GetArchiveInfoList())
		{
			if (item.ArchiveId == ArchiveId)
			{
				if (CloneData)
				{
					return item.Clone();
				}
				return item;
			}
		}
		return null;
	}

	public ArchiveSummaryData GetLatestArchive()
	{
		ArchiveSummaryData archiveSummaryData = null;
		List<ArchiveSummaryData> list = _GetArchiveInfoList();
		for (int i = 0; i < list.Count; i++)
		{
			if (archiveSummaryData == null || list[i].LastGameTime > archiveSummaryData.LastGameTime)
			{
				archiveSummaryData = list[i];
			}
		}
		return archiveSummaryData?.Clone();
	}

	public bool IsNewGameplusReady()
	{
		return GetLatestArchive()?.NewGameplusReady ?? false;
	}

	public bool IsArchiveNewGameplusReady(int ArchiveId)
	{
		return GetArchiveSummaryInfo(ArchiveId, CloneData: false)?.NewGameplusReady ?? false;
	}

	public bool LatestArchiveNewGameplus()
	{
		return GetLatestArchive()?.NewGameplusReady ?? false;
	}

	private RoleData FetchGSGRoleData()
	{
		FetchRoleDataResult.Reset();
		FetchGSGRoleDataHandler?.Invoke();
		return FetchRoleDataResult.RoleData;
	}

	private FUStBEDArchivesData FetchGameplayLevelData()
	{
		if (GSEUtil.IsBossRushMode())
		{
			ArchiveFileUnpacked GameArchiveData;
			ReadArchiveResult readArchiveResult = ReadArchiveData(CurrentArchiveId, out GameArchiveData);
			if (readArchiveResult != ReadArchiveResult.Success)
			{
				throw new Exception($"ReadArchiveData Fail On Fetch Archive Snapshot:{readArchiveResult}");
			}
			return GameArchiveData.GameArchiveData;
		}
		LevelArchiveData levelArchiveData = DataReorganizationMgr.FetchReadOnlyLevelData(this);
		WorldTaskArchiveData taskArchiveData = DataReorganizationMgr.FetchReadOnlyTaskData(this);
		StateMachineArchiveData stateMachineArchiveData = DataReorganizationMgr.FetchReadOnlyStateMachineData(this);
		List<int> values = DataReorganizationMgr.FetchReadOnlyMovieData(this);
		PersistentECSData persistentECSData = DataReorganizationMgr.FetchAllPersistentECSData(this);
		return new FUStBEDArchivesData
		{
			LevelArchiveData = levelArchiveData,
			TaskArchiveData = taskArchiveData,
			StateMachineArchiveData = stateMachineArchiveData,
			NeverPlaySequences = { (IEnumerable<int>)values },
			PersistentECSData = persistentECSData
		};
	}

	private FUStBEDArchivesData FetchArchiveSnapshot()
	{
		RoleData roleData = FetchGSGRoleData();
		FUStBEDArchivesData fUStBEDArchivesData = FetchGameplayLevelData();
		fUStBEDArchivesData.RoleData = roleData;
		return fUStBEDArchivesData;
	}

	public FUStBEDArchivesData GMExportArchiveSnapshot()
	{
		return FetchArchiveSnapshot().Clone();
	}

	public void GMExportCurrentSnapshotToFile(string SavePath)
	{
		GSE_ProtobufHelper.WriteMessageToFile(PackArchiveFileData().GameArchiveFile, SavePath);
	}

	public static bool IsNetClient(UObject Owner)
	{
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(Owner);
		if (worldFromObj != null && UGSE_EngineFuncLib.IsClient(worldFromObj))
		{
			return true;
		}
		return false;
	}

	private GSArchiveFileContainer PackArchiveFileData()
	{
		FUStBEDArchivesData fUStBEDArchivesData = FetchArchiveSnapshot();
		if (CurrentArchiveId <= 0)
		{
			throw new Exception($"Invalid ArchiveId:{CurrentArchiveId}");
		}
		ArchiveInfo archiveInfo = GenArchiveInfoForUpdate(CurrentArchiveId);
		byte[] array = SerializeArchiveDataToBytes(archiveInfo.EnableEncrypt, fUStBEDArchivesData);
		archiveInfo.Md5Str = CalcByteArrayMD5(array, ARCHIVE_MD5_MAGIC_SALT);
		CacheArchiveFileInfo(CurrentArchiveId, archiveInfo);
		ArchiveFile archiveFile = new ArchiveFile
		{
			ArchiveInfo = archiveInfo,
			GameArchivesDataBytes = ByteString.CopyFrom(array)
		};
		ShareArchiveFile shareArchiveFile = PackShareArchiveFile(fUStBEDArchivesData.RoleData.RoleCs.Museum, SharedArchiveUid);
		ArchiveSummaryData archiveSummaryDataForUpdate = GenArchiveSummaryData(CurrentArchiveId, ReadArchiveResult.Success, archiveInfo, fUStBEDArchivesData);
		ArchiveOSS.MonitorArchiveSize("ArchiveRoleDataSize", fUStBEDArchivesData.RoleData.CalculateSize());
		ArchiveOSS.MonitorArchiveSize("ArchiveFileSize", archiveFile.CalculateSize());
		return new GSArchiveFileContainer
		{
			GameArchiveFile = archiveFile,
			ShareArchiveFile = shareArchiveFile,
			ArchiveSummaryDataForUpdate = archiveSummaryDataForUpdate
		};
	}

	public bool DeleteArchive(int ArchiveId, string DeleteReason)
	{
		SysLogUtil.ARCHIVE.LogInfo($"Begin Delete Archive:{ArchiveId}, Reason:{DeleteReason}");
		ArchiveSummaryData archiveSummaryInfo = GetArchiveSummaryInfo(ArchiveId);
		RecycleArchiveSlot(ArchiveId);
		bool flag = ArchiveWorker.DeleteArchive(ArchiveId);
		SysLogUtil.ARCHIVE.LogInfo($"Delete Archive:{ArchiveId} Finish, IsSuccess:{flag}");
		ArchiveOSS.ReportDeleteArchive(this, SaveFileType.Archive, archiveSummaryInfo, DeleteReason);
		return flag;
	}

	public bool DeleteShareArchive(string DeleteReason)
	{
		SysLogUtil.ARCHIVE.LogInfo("Begin ShareArchive, Reason:" + DeleteReason);
		bool flag = ArchiveWorker.DeleteShareArchive();
		SysLogUtil.ARCHIVE.LogInfo($"Delete ShareArchiveFinish, IsSuccess:{flag}");
		ArchiveOSS.ReportDeleteArchive(this, SaveFileType.SharedArchive, null, DeleteReason);
		return flag;
	}

	public void GMClearAllArchive(string Reason)
	{
		SysLogUtil.ARCHIVE.LogInfo("GMClearAllArchive Reason:" + Reason);
		ArchiveSlot[] archiveSlot = ArchiveSlot;
		foreach (ArchiveSlot archiveSlot2 in archiveSlot)
		{
			if (archiveSlot2.IsInUse)
			{
				DeleteArchive(archiveSlot2.ArchiveId, Reason);
			}
		}
		DeleteShareArchive(Reason);
	}

	private bool IsGameInRunning()
	{
		return RunningState == ArchiveMgrRunningState.Running;
	}

	private bool IsGameStoped()
	{
		return RunningState == ArchiveMgrRunningState.Stopped;
	}

	public bool IsCurrentArchiveIdInvalid(out string Message)
	{
		Message = "";
		if (ArchiveFileUtil.IsTeleportArchive(CurrentArchiveId))
		{
			Message = "GMMonsterTeleportArchive not need save";
			return true;
		}
		if (CurrentArchiveId <= 0)
		{
			Message = $"Current ArchiveId:{CurrentArchiveId} invalid!";
			return true;
		}
		return false;
	}

	public void GSGUpdateGamePlayerReadySave(bool CanSave, string Message)
	{
		CheckIsPlayerReadySaveResult.GamePlayerReady = CanSave;
		CheckIsPlayerReadySaveResult.Message = Message;
	}

	public bool IsGSGGamePlayerReadySave(out string ExtraMessage)
	{
		CheckIsPlayerReadySaveResult.Reset();
		GSGCheckPlayerReadySaveHandler?.Invoke();
		ExtraMessage = CheckIsPlayerReadySaveResult.Message;
		return CheckIsPlayerReadySaveResult.GamePlayerReady;
	}

	private bool IsGameLogicPause()
	{
		return BGW_PauseGameMgr.Get(this).IsBattlePaused;
	}

	public bool IsArchiveReadySave(out CheckArchiveReadyResult Result)
	{
		Result = new CheckArchiveReadyResult();
		if (IsCurrentArchiveIdInvalid(out var Message))
		{
			Result.Reason = ArchiveNotReadyReason.InvalidArchiveId;
			Result.Message = Message;
			return false;
		}
		if (IsGameStoped())
		{
			Result.Reason = ArchiveNotReadyReason.GameStoped;
			Result.Message = "Game is Stop!";
			return false;
		}
		if (!IsLevelDataReady(out Message))
		{
			Result.Reason = ArchiveNotReadyReason.LevelDataNotReady;
			Result.Message = "LevelData Not Ready, Reason:" + Message;
			return false;
		}
		if (!IsGSGGamePlayerReadySave(out Message))
		{
			Result.Reason = ArchiveNotReadyReason.GSGGameplayerNotReady;
			Result.Message = Message;
			return false;
		}
		if (CurrentGameArchiveContext.DelaySaveFrameCount > 0)
		{
			Result.Reason = ArchiveNotReadyReason.WaitDelayFrame;
			Result.Message = $"Wait DelaySaveFrameCount:{CurrentGameArchiveContext.DelaySaveFrameCount}, LastDelayReason:{CurrentGameArchiveContext.LastDelaySource}, LastDelayExtraMessage:{CurrentGameArchiveContext.LastDelayExMessage}";
			return false;
		}
		if (CurrentGameArchiveContext.LockList.Count > 0)
		{
			Result.Reason = ArchiveNotReadyReason.WaitArchiveLockRelease;
			ArchiveLock archiveLock = CurrentGameArchiveContext.LockList[0];
			Result.Message = $"Wait ArchiveLock release, LastLock, Source:{archiveLock.Source}, ExtraMessage:{archiveLock.ExtraParam}, TransactionId:{archiveLock.TransactionId}";
			Result.Param = (int)archiveLock.Source;
			return false;
		}
		return true;
	}

	private bool IsLevelDataReady(out string Reason)
	{
		Reason = "";
		BGW_DebugMgr bGW_DebugMgr = BGW_DebugMgr.Get(this);
		if (bGW_DebugMgr == null)
		{
			Reason = "Debug Mgr is null";
			return false;
		}
		if (bGW_DebugMgr.IsFatalExceptionHandle)
		{
			Reason = "Fatal Exception Handle";
			return false;
		}
		SGI_Global globalFSMInstanceCurState = BGW_GameLifeTimeMgr.Get(this).GlobalFSMInstanceCurState;
		if (globalFSMInstanceCurState != SGI_Global.InBattleStandAlone && globalFSMInstanceCurState != SGI_Global.AsClientInGame && globalFSMInstanceCurState != SGI_Global.AsListenServerInGame && globalFSMInstanceCurState != SGI_Global.SubG_GI_Loading_TravelLevel)
		{
			Reason = $"CurFSMInstanceState:{globalFSMInstanceCurState}";
			return false;
		}
		return true;
	}

	private void OnSaveArchiveTransactionBegin(int TransactionId)
	{
		if (LastRequestTransactionId == 0)
		{
			BGW_UIEventCollection.Get(this).Evt_ShowSaveArchiveUI();
		}
		LastRequestTransactionId = TransactionId;
	}

	public void OnSaveArchiveTransactionFinish(int TransactionId, bool IsWriteSuccess)
	{
		if (TransactionId == LastRequestTransactionId && IsWriteSuccess)
		{
			BGW_UIEventCollection.Get(this).Evt_HideSaveArchiveUI();
			LastRequestTransactionId = 0;
		}
	}

	public void OnSaveArchiveWriteIOFinish(int ArchiveId, GSArchiveFileContainer WriteSaveGameData, bool IsWriteSuccess)
	{
		if (!IsWriteSuccess)
		{
			SysLogUtil.ARCHIVE.LogError($"SaveArchiveWriteIOFinish Fail, ArchiveId:{ArchiveId}");
			GSSDKReport.MonitorAdd(MonEvtCatogray.ARCHIVE, "ArchiveWriteIOFail", 1L, null);
			ulong uTCTimeStamp = UBGWFunctionLibraryCS.GetUTCTimeStamp();
			if (uTCTimeStamp >= CurrentGameArchiveContext.LastShowIOExcepitonMsgTime + 30)
			{
				BGW_ExceptionUIMgr.Get(this).ForceShowCommonErrorTips(10007, ECommonErrorType.Server, "ArchiveWriteIOFail");
				CurrentGameArchiveContext.LastShowIOExcepitonMsgTime = uTCTimeStamp;
			}
		}
		ArchiveSlot archiveSlot = GetArchiveSlot(ArchiveId);
		if (archiveSlot != null && IsWriteSuccess)
		{
			archiveSlot.CacheSummaryData(WriteSaveGameData.ArchiveSummaryDataForUpdate);
			archiveSlot.MarkInUse(IsInUse: true);
		}
	}

	private int GenTransactionId()
	{
		return ++NextArchiveTransactionId;
	}

	private int GenLockTransaction()
	{
		return ++CurrentGameArchiveContext.LockTransactionId;
	}

	public void MarkSaveArchive(EArchiveSaveSource Source, string ExtraMessage = "")
	{
		SysLogUtil.ARCHIVE.LogInfo($"MarkSaveArchive Source:{Source}, Message:{ExtraMessage}");
		if (IsCurrentArchiveIdInvalid(out var Message))
		{
			SysLogUtil.ARCHIVE.LogWarning("Skip Save Archive For:" + Message);
			return;
		}
		if (IsGameStoped())
		{
			SysLogUtil.ARCHIVE.LogWarning($"ArchiveMgr State is {RunningState}, Skip save archive");
			return;
		}
		if (Source == EArchiveSaveSource.RoleDataMerge && IsSaveRoleDataArchiveInCooling())
		{
			SysLogUtil.ARCHIVE.LogWarning($"SaveRoleDataArchive is in cooling:{CurrentGameArchiveContext.SaveRoleDataArchiveCD}, skip save archive");
			return;
		}
		if (GSEUtil.IsInBossRushBattleStage())
		{
			SysLogUtil.ARCHIVE.LogWarning("In BossRush Disable Write Stage, Skip save archive.");
			return;
		}
		BUS_BattleInfoComp.QAAddArchiveInfo(EBattleInfoType.ArchiveInfo, $"<character>Request事件</><action>发起来源:{Source}, 额外信息:{ExtraMessage}</>", 0);
		CurrentGameArchiveContext.PendingSaveArchiveRequest.Add(new ArchiveSaveRequestOne
		{
			TransactionId = GenTransactionId(),
			Source = Source,
			Info = ExtraMessage
		});
		SysLogUtil.ARCHIVE.LogInfo($"Save archive begin, ArchiveId:{CurrentArchiveId} TransactionId:{NextArchiveTransactionId} Source：{Source}, ExtraMessage:{ExtraMessage}");
		OnSaveArchiveTransactionBegin(NextArchiveTransactionId);
	}

	public void MarkDelaySaveArchive(EArchiveDelaySaveSource Source, string ExtraMessage = "")
	{
		if (HasPendingSaveRequest)
		{
			BUS_BattleInfoComp.QAAddArchiveInfo(EBattleInfoType.ArchiveInfo, $"<damage>Delay事件</><action>发起来源:{Source}, 额外信息:{ExtraMessage}</>", 0);
		}
		SysLogUtil.ARCHIVE.LogInfo($"Delay SaveArchive Reason:{Source}, Info:{ExtraMessage}, CurrentTrySaveTime:{CurrentGameArchiveContext.TrySaveSnapshotTime}");
		CurrentGameArchiveContext.DelaySaveFrameCount = ARCHIVE_CONST_DELAY_SAVE_SNAPSHOT_FRAME_CONST;
		CurrentGameArchiveContext.LastDelaySource = Source;
		CurrentGameArchiveContext.LastDelayExMessage = ExtraMessage;
	}

	private void TickDelaySaveFrame()
	{
		if (CurrentGameArchiveContext.DelaySaveFrameCount > 0)
		{
			CurrentGameArchiveContext.DelaySaveFrameCount--;
			SysLogUtil.ARCHIVE.LogInfo($"DelayCount:{CurrentGameArchiveContext.DelaySaveFrameCount}, BlockTime:{CurrentGameArchiveContext.TrySaveSnapshotTime}");
		}
	}

	public int LockSaveArchive(EArchiveDelaySaveSource Source, string ExtraMessage = "")
	{
		SysLogUtil.ARCHIVE.LogInfo($"Begin LockSaveArchive, Source:{Source}, Message:{ExtraMessage}");
		if (!IsGameInRunning())
		{
			SysLogUtil.ARCHIVE.LogInfo("Game is not in running state, skip lock!");
			return -9999;
		}
		int transactionId = GenLockTransaction();
		ArchiveLock archiveLock = new ArchiveLock
		{
			TransactionId = transactionId,
			Source = Source,
			ExtraParam = ExtraMessage
		};
		CurrentGameArchiveContext.LockList.Add(archiveLock);
		SysLogUtil.ARCHIVE.LogInfo($"LockSaveArchive Finish, TransactionId:{archiveLock.TransactionId}, Source:{Source}, Message:{ExtraMessage}");
		return archiveLock.TransactionId;
	}

	public void ReleaseSaveLock(int TransactionId)
	{
		if (TransactionId == -9999)
		{
			return;
		}
		foreach (ArchiveLock @lock in CurrentGameArchiveContext.LockList)
		{
			if (@lock.TransactionId == TransactionId)
			{
				if (@lock.Source == EArchiveDelaySaveSource.SequencePlaying)
				{
					ResetSaveArchiveTimeout();
				}
				CurrentGameArchiveContext.LockList.Remove(@lock);
				SysLogUtil.ARCHIVE.LogInfo($"ReleaseSaveLock TransactionId:{@lock.TransactionId}, Source:{@lock.Source}");
				return;
			}
		}
		if (IsGameInRunning())
		{
			SysLogUtil.ARCHIVE.LogError($"ReleaseLock TransactionId:{TransactionId} not found!");
		}
	}

	public bool HaveArchiveLock()
	{
		return CurrentGameArchiveContext.LockList.Count > 0;
	}

	public void MarkSaveSetting(UISettingArchiveData UISettingArchiveData)
	{
		ArchiveWorker.AppendSettingSaveRequest(UISettingArchiveData);
	}

	private int GetArchiveSaveTimeout()
	{
		if (IsSeqPlaying())
		{
			return ARCHIVE_CONST_SEQ_PLAY_LOCK_TIMEOUT;
		}
		return ARCHIVE_CONST_SAVE_ARCHIVE_SNAPSHOT_TIMEOUT;
	}

	private void ResetSaveArchiveTimeout()
	{
		SysLogUtil.ARCHIVE.LogInfo("Reset Save Archive Timeout.");
		CurrentGameArchiveContext.TrySaveSnapshotTime = 0f;
	}

	private void SetSaveRoleDataArchiveCD()
	{
		CurrentGameArchiveContext.SaveRoleDataArchiveCD = ARCHIVE_CONST_SAVE_ROLEDATA_CD;
	}

	private bool IsSaveRoleDataArchiveInCooling()
	{
		return CurrentGameArchiveContext.SaveRoleDataArchiveCD > 0f;
	}

	private void LogArchiveDelaySave(float DeltaTime, string Message)
	{
		if (LogArchiveDelaySaveDeltaTime >= 5f)
		{
			SysLogUtil.ARCHIVE.LogInfo("Archive Not Ready, Message:" + Message);
			LogArchiveDelaySaveDeltaTime = 0f;
		}
		else
		{
			LogArchiveDelaySaveDeltaTime += DeltaTime;
		}
	}

	private void TickSaveArchiveSnapshot(float DeltaTime)
	{
		if (!HasPendingSaveRequest)
		{
			return;
		}
		CurrentGameArchiveContext.TrySaveSnapshotTime += DeltaTime;
		if (!IsArchiveReadySave(out var Result))
		{
			LogArchiveDelaySave(DeltaTime, Result.Message);
			if (CurrentGameArchiveContext.TrySaveSnapshotTime >= (float)GetArchiveSaveTimeout())
			{
				GSSDKReport.MonitorAdd(MonEvtCatogray.ARCHIVE, "SaveArchiveTimeout", 1L, $"reason={Result.Reason},param={Result.Param}");
				throw new Exception($"Save Archive Timeout, BlockTime:{CurrentGameArchiveContext.TrySaveSnapshotTime}, Timeout:{GetArchiveSaveTimeout()}, LastBlockMessage:{Result.Message}");
			}
		}
		else
		{
			GSArchiveFileContainer archiveWriteContainer = PackArchiveFileData();
			ArchiveWorker.AppendArchiveSaveRequest(CurrentArchiveId, archiveWriteContainer, CurrentGameArchiveContext.PendingSaveArchiveRequest);
			CurrentGameArchiveContext.PendingSaveArchiveRequest.Clear();
			SysLogUtil.ARCHIVE.LogInfo("Append Archive Save Request To Worker.");
			ResetSaveArchiveTimeout();
			SetSaveRoleDataArchiveCD();
		}
	}

	public bool IsArchiveBusy(out string Reason)
	{
		if (HasPendingSaveRequest)
		{
			IsArchiveReadySave(out var Result);
			Reason = "Archive Busy, Wait SaveArchiveSnapshot:" + Result.Message;
			return true;
		}
		if (!ArchiveWorker.IsAllTaskFinish())
		{
			Reason = "Archive Busy, Wait Worker Write To Disk Finish";
			return true;
		}
		Reason = "";
		return false;
	}

	private bool IsArchiveMgrCanStopNow(out string Reason)
	{
		return !IsArchiveBusy(out Reason);
	}

	public void WaitArchiveMgrStop(Del_OnStopSaveArchiveFinish FinishCallback, bool ForceStop = false)
	{
		SysLogUtil.ARCHIVE.LogInfo($"ArchiveMgr Begin Stop, ForceStop:{ForceStop}");
		CurrentGameArchiveContext.TryStopSaveArchiveTime = 0f;
		CurrentGameArchiveContext.OnStopSaveArchiveFinish = FinishCallback;
		CurrentGameArchiveContext.ForceStopFlag = ForceStop;
		SwitchArchiveState(ArchiveMgrRunningState.Stopping);
	}

	private void TickArchiveMgrStop(float DeltaTime)
	{
		if (RunningState == ArchiveMgrRunningState.Stopping)
		{
			CurrentGameArchiveContext.TryStopSaveArchiveTime += DeltaTime;
			if (CurrentGameArchiveContext.ForceStopFlag || IsArchiveMgrCanStopNow(out var Reason))
			{
				GameStop();
			}
			else if (CurrentGameArchiveContext.TryStopSaveArchiveTime >= 10f)
			{
				GSSDKReport.MonitorAdd(MonEvtCatogray.ARCHIVE, "ArchiveStopTimeout", 1L, null);
				throw new Exception("Try Stop ArchiveMgr Timeout, Reason:" + Reason);
			}
		}
	}

	public void OnGameInstanceStart(EStartGameInstanceTypeForCS StartType)
	{
	}

	static BGW_GameArchiveMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_GameArchiveMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_GameArchiveMgr));
		ARCHIVE_CONST_ARCHIVE_COUNT_MAX = 10;
		ARCHIVE_CONST_DELAY_SAVE_SNAPSHOT_FRAME_CONST = 30;
		ARCHIVE_CONST_SAVE_ARCHIVE_SNAPSHOT_TIMEOUT = 60;
		ARCHIVE_CONST_SEQ_PLAY_LOCK_TIMEOUT = 1800;
		ARCHIVE_CONST_SAVE_ROLEDATA_CD = 30;
		ARCHIVE_XOR_ENCRYPT_MATIC_KEY_LONG = BitConverter.GetBytes(4024806562674138235L);
		ARCHIVE_CHECK_MD5_FLAG = true;
		ARCHIVE_CHECK_REVISION_FLAG = true;
		ARCHIVE_MD5_MAGIC_SALT = "lhx2tkh6lj1wj8jmrgs3k1xb2brusehx";
		s_md5_calc_buff = new byte[65536];
		LogArchiveDelaySaveDeltaTime = 0f;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_GameArchiveMgr");
	}
}
