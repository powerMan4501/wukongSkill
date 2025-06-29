using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using b1.BGW;
using b1.GSFile;
using BtlShare;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_820DemoPlayTimeMgr")]
public class BGW_820DemoPlayTimeMgr : GameInstanceSystemBaseUObj
{
	private bool IsSetPausedByException;

	private bool IsSetPausedTimeout;

	private float GamePlayTime;

	private GSBindProp<bool> CanTickTime = new GSBindProp<bool>();

	private float SaveFileDelay;

	public float GamePlayTimeMax;

	private float BossDelayGamePlayTimeMax;

	private float GamePlayTimeTips;

	private float GamePlayTimeSmallTips;

	private List<float> GamePlayTimeTipsList;

	private UCurveFloat PassLevelCurve;

	private float CurveTimeMax;

	private float TimeDilationMax;

	private float TimeDilation;

	private float CurTimeDilationSpd = 1f;

	private float SingleLevelTime;

	private bool TickSingleLevelTime;

	private int CurLevelIdx;

	private string HasReportEmail;

	private bool OSSEndPlayReport;

	private bool NeedCheckPSOFinish;

	private bool NeedShowBox;

	private bool HasStartInit;

	private int DemoPlayerCount;

	private IBGC_MovieData MovieData;

	public GSBindProp<bool> IsTimeOutWarn = new GSBindProp<bool>();

	public GSBindProp<bool> IsTimeOut = new GSBindProp<bool>();

	public GSBindProp<bool> IsTimeWarnFinish = new GSBindProp<bool>();

	public GSBindProp<bool> IsTimeDelay = new GSBindProp<bool>();

	public GSBindProp<bool> IsTimeWarnSmall = new GSBindProp<bool>();

	private List<int> PassLevelList = new List<int>();

	private List<int> AwardLevelList = new List<int>();

	private List<int> PassLevelStateList = new List<int>();

	private Dictionary<int, float> LevelPlayTimeDict = new Dictionary<int, float>();

	private string DemoGameConfig = Path.Combine(FPaths.ProjectPersistentDownloadDir, "DemoGameConfig.sav");

	private string DemoSettingConfig = Path.Combine(FPaths.ProjectPersistentDownloadDir, "DemoSettingConfig.sav");

	private string PlayerArchiveBackup = Path.Combine(FPaths.ProjectPersistentDownloadDir, "PlayerArchiveBackup");

	private string SavedGamePath = Path.Combine(FPaths.ProjectSavedDir, "SaveGames");

	private string ConfigPath = Path.Combine(FPaths.ProjectSavedDir, "Config");

	public override bool bTickEnabled => true;

	public static BGW_820DemoPlayTimeMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_820DemoPlayTimeMgr>(WorldContext);
	}

	public void ForceSet820DemoPauseByException()
	{
		if (DebugConfig.Demo820ExceptionUI)
		{
			IsSetPausedByException = true;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (IsSetPausedByException)
		{
			return;
		}
		float num = TickGlobalTime(DeltaTime);
		if (CanTickTime.Value)
		{
			bool flag = false;
			if (GamePlayTimeMax - GamePlayTime >= GamePlayTimeTips)
			{
				flag = true;
			}
			GamePlayTime += num;
			CheckSaveFile(num);
			CheckTimeOut();
			CheckSingleLevelTime(num);
			if (flag)
			{
				ShowWarningUI();
			}
			CheckTimeTip();
			CheckSmallTimeTip();
		}
		CheckPSOFinish(DeltaTime);
	}

	public override void OnInit()
	{
		IsSetPausedByException = false;
		IsSetPausedTimeout = false;
		HasStartInit = false;
	}

	public void OnDataInit()
	{
		GamePlayTime = 0f;
		CanTickTime.SetValue(EChangeReason.Init, value: false);
		SaveFileDelay = 0f;
		TickSingleLevelTime = false;
		IsTimeOutWarn.SetValue(EChangeReason.Init, value: false);
		IsTimeOut.SetValue(EChangeReason.Init, value: false);
		IsTimeWarnSmall.SetValue(EChangeReason.Init, value: false);
		IsTimeWarnFinish.SetValue(EChangeReason.Init, value: false);
		IsTimeDelay.SetValue(EChangeReason.Init, value: false);
		GamePlayTimeTipsList = new List<float>();
		PassLevelCurve = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.PassLevelCurve;
		CurveTimeMax = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.CurveTimeMax;
		PassLevelList = new List<int>();
		AwardLevelList = new List<int>();
		PassLevelStateList = new List<int>();
		LevelPlayTimeDict = new Dictionary<int, float>();
		HasReportEmail = "";
		OSSEndPlayReport = false;
		SetTimeInfo();
	}

	private void CheckSingleLevelTime(float DeltaTime)
	{
		if (TickSingleLevelTime)
		{
			SingleLevelTime += DeltaTime;
		}
	}

	private float TickGlobalTime(float DeltaTime)
	{
		if (TimeDilation > 0f)
		{
			if (CurTimeDilationSpd > 0f)
			{
				TimeDilation -= DeltaTime / CurTimeDilationSpd;
			}
			else
			{
				TimeDilation -= DeltaTime;
			}
			if (PassLevelCurve != null)
			{
				CurTimeDilationSpd = PassLevelCurve.GetFloatValue(TimeDilationMax - TimeDilation);
			}
			if (TimeDilation <= 0f)
			{
				CurTimeDilationSpd = 1f;
			}
			UGameplayStatics.SetGlobalTimeDilation(this, CurTimeDilationSpd);
			if (CurTimeDilationSpd > 0f)
			{
				return DeltaTime / CurTimeDilationSpd;
			}
		}
		return DeltaTime;
	}

	private void CheckSaveFile(float DeltaTime)
	{
		if (SaveFileDelay >= 0f)
		{
			SaveFileDelay -= DeltaTime;
			if (SaveFileDelay < 0f)
			{
				SaveFileDelay = 10f;
				SaveGamePlayTimeToFile(IsTick: true);
			}
		}
	}

	private void CheckTimeOut()
	{
		if (IsSetPausedTimeout)
		{
			return;
		}
		if (MovieData == null)
		{
			AGameStateBase gameState = UGameplayStatics.GetGameState(this);
			MovieData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(gameState);
		}
		if ((MovieData == null || !MovieData.IsPlaying()) && !BGW_GameArchiveMgr.Get(this).IsSeqPlaying() && GamePlayTime > GamePlayTimeMax)
		{
			if (GamePlayTimeMax < BossDelayGamePlayTimeMax && CheckBossHP())
			{
				IsTimeDelay.SetValue(EChangeReason.ManualSet, value: true);
				GamePlayTimeMax = BossDelayGamePlayTimeMax;
			}
			else
			{
				IsTimeOut.SetValue(EChangeReason.ManualSet, value: true);
				CanTickTime.SetValue(EChangeReason.ManualSet, value: false);
				DoTimeOutLogic();
			}
		}
	}

	private void DoTimeOutLogic()
	{
		if (!BGW_PauseGameMgr.Get(this).IsInPauseEvent(EPauseEvent.OpenUI))
		{
			BGW_EventCollection.Get(this).Evt_SetGamePause(EPauseEvent.OpenUI, bPause: true);
		}
		OSSEndLevel(GetCurLevelIdx(), 3);
		OSSEndPlay();
		SaveGamePlayTimeToFile();
		if (!DebugConfig.Demo820IgnoreAllOverlap)
		{
			BGW_EventCollection.Get(this)?.Evt_IgnoreAllOverlapEvent(P1: true);
		}
	}

	private void CheckTimeTip()
	{
		foreach (float gamePlayTimeTips in GamePlayTimeTipsList)
		{
			if (GamePlayTimeMax - GamePlayTime < gamePlayTimeTips)
			{
				GamePlayTimeTipsList.Remove(gamePlayTimeTips);
				ShowTimeTipsUI();
				break;
			}
		}
	}

	private void CheckSmallTimeTip()
	{
		if (GamePlayTimeMax - GamePlayTime < GamePlayTimeSmallTips)
		{
			IsTimeWarnSmall.SetValue(EChangeReason.ManualSet, value: true);
		}
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
	}

	public float GetGamePlayTime()
	{
		return GamePlayTime;
	}

	public float GetRemainGamePlayTime()
	{
		if (!(GamePlayTimeMax - GamePlayTime > 0f))
		{
			return 0f;
		}
		return GamePlayTimeMax - GamePlayTime;
	}

	public string GetRemainGamePlayTimeStr()
	{
		return TimeSpan.FromSeconds(GetRemainGamePlayTime()).ToString("mm\\:ss");
	}

	public void BeginTickGamePlayTime()
	{
		CanTickTime.SetValue(EChangeReason.ManualSet, value: true);
	}

	public void StopTickGamePlayTime()
	{
		CanTickTime.SetValue(EChangeReason.ManualSet, value: false);
		GamePlayTime = 0f;
	}

	public GSBindProp<bool> GetCanTickTime()
	{
		return CanTickTime;
	}

	private void SaveGamePlayTimeToFile(bool IsTick = false)
	{
		if (!File.Exists(DemoGameConfig))
		{
			File.Create(DemoGameConfig).Close();
			OssNewPlayer();
		}
		Demo820GameSave demo820GameSave = new Demo820GameSave();
		demo820GameSave.GamePlayTime = GamePlayTime;
		demo820GameSave.HasEmailReport = HasReportEmail;
		demo820GameSave.OssEndPlayReport = OSSEndPlayReport;
		for (int i = 0; i < PassLevelList.Count; i++)
		{
			demo820GameSave.LevelPassList.Add(PassLevelList[i]);
		}
		for (int j = 0; j < PassLevelStateList.Count; j++)
		{
			demo820GameSave.LevelPassStateList.Add(PassLevelStateList[j]);
		}
		for (int k = 0; k < AwardLevelList.Count; k++)
		{
			demo820GameSave.LevelAwardList.Add(AwardLevelList[k]);
		}
		if (!LevelPlayTimeDict.ContainsKey(CurLevelIdx) && CurLevelIdx > 0)
		{
			LevelPlayTimeDict.Add(CurLevelIdx, SingleLevelTime);
		}
		foreach (KeyValuePair<int, float> item in LevelPlayTimeDict)
		{
			Demo820LevelPlaytime demo820LevelPlaytime = new Demo820LevelPlaytime();
			demo820LevelPlaytime.LevelIndex = item.Key;
			demo820LevelPlaytime.PlayTime = (int)item.Value;
			demo820GameSave.LevelPlayTimeList.Add(demo820LevelPlaytime);
		}
		GSEFileUtil.SafeWriteBytesToFile(DemoGameConfig, demo820GameSave.ToByteArray());
		if (IsTick)
		{
			return;
		}
		foreach (int levelPassState in demo820GameSave.LevelPassStateList)
		{
			_ = levelPassState;
		}
		foreach (int levelPass in demo820GameSave.LevelPassList)
		{
			_ = levelPass;
		}
		foreach (int levelAward in demo820GameSave.LevelAwardList)
		{
			_ = levelAward;
		}
		foreach (Demo820LevelPlaytime levelPlayTime in demo820GameSave.LevelPlayTimeList)
		{
			_ = levelPlayTime;
		}
	}

	private void TryReadSaveGame()
	{
		if (!File.Exists(DemoGameConfig))
		{
			return;
		}
		Demo820GameSave demo820GameSave = new Demo820GameSave();
		using (FileStream input = File.Open(DemoGameConfig, FileMode.Open, FileAccess.Read))
		{
			demo820GameSave.MergeFrom(input);
		}
		GamePlayTime = demo820GameSave.GamePlayTime;
		HasReportEmail = demo820GameSave.HasEmailReport;
		OSSEndPlayReport = demo820GameSave.OssEndPlayReport;
		foreach (int levelPass in demo820GameSave.LevelPassList)
		{
			if (levelPass > 0)
			{
				PassLevelList.Add(levelPass);
			}
		}
		foreach (int levelPassState in demo820GameSave.LevelPassStateList)
		{
			if (levelPassState > 0)
			{
				PassLevelStateList.Add(levelPassState);
			}
		}
		foreach (int levelAward in demo820GameSave.LevelAwardList)
		{
			if (levelAward > 0)
			{
				AwardLevelList.Add(levelAward);
			}
		}
		foreach (Demo820LevelPlaytime levelPlayTime in demo820GameSave.LevelPlayTimeList)
		{
			LevelPlayTimeDict.Add(levelPlayTime.LevelIndex, levelPlayTime.PlayTime);
		}
	}

	public bool GetIsInWarning()
	{
		return GamePlayTimeMax - GamePlayTime < GamePlayTimeTips;
	}

	private void ShowWarningUI()
	{
		if (GamePlayTimeMax - GamePlayTime < GamePlayTimeTips)
		{
			IsTimeOutWarn.SetValue(EChangeReason.ManualSet, value: true);
		}
	}

	private void ShowTimeTipsUI()
	{
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
		if (!(bGW_UIEventCollection == null))
		{
			bGW_UIEventCollection.Evt_UI_820TimeWarn();
			IsTimeWarnFinish.SetValue(EChangeReason.ManualSet, GamePlayTimeTipsList.Count == 0);
		}
	}

	public bool IsInPlaying()
	{
		if (File.Exists(DemoGameConfig))
		{
			return true;
		}
		return false;
	}

	public bool IsAllLevelPass()
	{
		TArrayReadWrite<FDemo820LevelInfo> tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OpenLevelInfo;
		if (DebugConfig.Demo820OverSeaVersion)
		{
			tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OverSeaOpenLevelInfo;
		}
		foreach (FDemo820LevelInfo item in tArrayReadWrite)
		{
			if (!PassLevelList.Contains(item.LevelIndex))
			{
				return false;
			}
		}
		return true;
	}

	public bool IsLevelPass(int LevelIndex)
	{
		if (PassLevelList.Contains(LevelIndex))
		{
			return true;
		}
		return false;
	}

	public bool GetLevelCurPassState(int LevelIndex)
	{
		if (PassLevelStateList.Contains(LevelIndex))
		{
			return true;
		}
		return false;
	}

	public bool IsLevelAward(int LevelIndex)
	{
		if (AwardLevelList.Contains(LevelIndex))
		{
			return true;
		}
		return false;
	}

	public void LevelAward()
	{
		int curLevelIdx = GetCurLevelIdx();
		if (!AwardLevelList.Contains(curLevelIdx))
		{
			AwardLevelList.Add(curLevelIdx);
		}
	}

	public void GMPassAllLevel()
	{
		TArrayReadWrite<FDemo820LevelInfo> tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OpenLevelInfo;
		if (DebugConfig.Demo820OverSeaVersion)
		{
			tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OverSeaOpenLevelInfo;
		}
		foreach (FDemo820LevelInfo item in tArrayReadWrite)
		{
			if (!PassLevelList.Contains(item.LevelIndex))
			{
				PassLevelList.Add(item.LevelIndex);
			}
		}
		foreach (FDemo820LevelInfo item2 in tArrayReadWrite)
		{
			if (!PassLevelStateList.Contains(item2.LevelIndex))
			{
				PassLevelStateList.Add(item2.LevelIndex);
			}
		}
		LevelPass();
	}

	public void LevelPass()
	{
		int curLevelIdx = GetCurLevelIdx();
		if (!PassLevelList.Contains(curLevelIdx))
		{
			PassLevelList.Add(curLevelIdx);
		}
		if (!PassLevelStateList.Contains(curLevelIdx))
		{
			PassLevelStateList.Add(curLevelIdx);
		}
		if (!AwardLevelList.Contains(curLevelIdx))
		{
			AwardLevelList.Add(curLevelIdx);
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController != null)
		{
			APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
			if (controlledPawn != null)
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.ImmueDamage, IsRemove: false);
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.ImmueStiff, IsRemove: false);
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.ImmueImmobilizing, IsRemove: false);
			}
		}
		TimeDilationMax = CurveTimeMax;
		TimeDilation = CurveTimeMax;
		OSSEndLevel(curLevelIdx, 2);
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
		if (!(bGW_UIEventCollection == null))
		{
			int bossIDByLevelIndex = GetBossIDByLevelIndex(curLevelIdx);
			bGW_UIEventCollection.Evt_UI_820LevelPass(bossIDByLevelIndex);
		}
	}

	private void OSSEndLevel(int LevelId, int EndType)
	{
		if (IsInBattleLevel())
		{
			TickSingleLevelTime = false;
			if (!LevelPlayTimeDict.ContainsKey(CurLevelIdx) && CurLevelIdx > 0)
			{
				LevelPlayTimeDict.Add(CurLevelIdx, SingleLevelTime);
			}
			LevelPlayTimeDict[CurLevelIdx] += SingleLevelTime;
			SingleLevelTime = 0f;
			SaveGamePlayTimeToFile();
			BGS_GSEventCollection.Get(this)?.Evt_BGS_Demo820OSSEndLevel.Invoke();
		}
	}

	private void OSSEndPlay()
	{
		if (!OSSEndPlayReport)
		{
			SaveGamePlayTimeToFile();
		}
	}

	public void OSSEmail(string EmailAddress)
	{
		HasReportEmail = EmailAddress;
		SaveGamePlayTimeToFile();
	}

	public void OssNewPlayer()
	{
	}

	public void Demo820BackToSelectLevel()
	{
		OSSEndLevel(GetCurLevelIdx(), 1);
		CurLevelIdx = 0;
	}

	private int GetBossIDByLevelIndex(int LevelIndex)
	{
		if (DebugConfig.Demo820OverSeaVersion)
		{
			foreach (FDemo820LevelInfo item in BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OverSeaOpenLevelInfo)
			{
				if (item.LevelIndex == LevelIndex)
				{
					return item.BossID;
				}
			}
		}
		else
		{
			foreach (FDemo820LevelInfo item2 in BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OpenLevelInfo)
			{
				if (item2.LevelIndex == LevelIndex)
				{
					return item2.BossID;
				}
			}
		}
		return -1;
	}

	public void GMEndTime()
	{
		GamePlayTime = GamePlayTimeMax;
	}

	public void GMEndTips()
	{
		GamePlayTime = GamePlayTimeMax - GamePlayTimeTips;
	}

	public void GMPassTime(int Time)
	{
		GamePlayTime += Time;
	}

	public void GMTest()
	{
		TimeDilationMax = CurveTimeMax;
		TimeDilation = CurveTimeMax;
	}

	public void ReSetDataFile(Action OnPlayerResetedFinish)
	{
		OSSEndPlay();
	}

	public void Delect820GameConfig()
	{
		try
		{
			if (!Directory.Exists(PlayerArchiveBackup))
			{
				Directory.CreateDirectory(PlayerArchiveBackup);
			}
			string text = Path.Combine(PlayerArchiveBackup, $"{Directory.GetDirectories(PlayerArchiveBackup).Length}");
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			if (File.Exists(DemoGameConfig))
			{
				File.Move(DemoGameConfig, Path.Combine(text, "DemoGameConfig.sav"));
			}
		}
		catch (Exception)
		{
			BGW_LogUtil.LogError("Delete DemoGameConfig  Failed !!!");
		}
	}

	public void CheckMaxPlayCount()
	{
		if (DebugConfig.Demo820PlayCountMax > 0 && FPlatformProperties.GetPlatform() == EPlatform.Windows)
		{
			DemoPlayerCount++;
			if (DemoPlayerCount >= DebugConfig.Demo820PlayCountMax)
			{
				UGSE_EngineFuncLib.QuitGame(this);
			}
		}
	}

	public void SelectLevel(int Idx)
	{
		CurLevelIdx = Idx;
		int levelIdByIdx = GetLevelIdByIdx(Idx);
		if (Check820DemoArchive(CurLevelIdx, out var ArchiveId))
		{
			BGW_EventCollection.Get(this).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.LoadArchive, new FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel
			{
				ArchiveId = ArchiveId
			});
		}
		else
		{
			BGW_EventCollection.Get(this).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.StartNewGame, new FSMInputData_GI_Global_SubG_GI_Loading_StartNewGame
			{
				NewGameLevelId = levelIdByIdx
			});
		}
	}

	private bool Check820DemoArchive(int CurLevelIdx, out int ArchiveId)
	{
		ArchiveId = 0;
		return false;
	}

	public bool IsInBossLevel()
	{
		int curLevelIdx = GetCurLevelIdx();
		TArrayReadWrite<FDemo820LevelInfo> tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OpenLevelInfo;
		if (DebugConfig.Demo820OverSeaVersion)
		{
			tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OverSeaOpenLevelInfo;
		}
		foreach (FDemo820LevelInfo item in tArrayReadWrite)
		{
			if (item.LevelIndex == curLevelIdx)
			{
				return item.BossID > 0;
			}
		}
		return true;
	}

	public bool IsInBattleLevel()
	{
		TArrayReadWrite<FDemo820LevelInfo> tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OpenLevelInfo;
		if (DebugConfig.Demo820OverSeaVersion)
		{
			tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OverSeaOpenLevelInfo;
		}
		foreach (FDemo820LevelInfo item in tArrayReadWrite)
		{
			if (item.LevelIndex == GetCurLevelIdx())
			{
				return true;
			}
		}
		return false;
	}

	public FDemo820LevelInfo GetCurLevelInfo()
	{
		TArrayReadWrite<FDemo820LevelInfo> tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OpenLevelInfo;
		if (DebugConfig.Demo820OverSeaVersion)
		{
			tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OverSeaOpenLevelInfo;
		}
		foreach (FDemo820LevelInfo item in tArrayReadWrite)
		{
			if (item.LevelIndex == CurLevelIdx)
			{
				return item;
			}
		}
		return default(FDemo820LevelInfo);
	}

	public int GetCurLevelCurRebirthPoint()
	{
		TArrayReadWrite<FDemo820LevelInfo> tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OpenLevelInfo;
		if (DebugConfig.Demo820OverSeaVersion)
		{
			tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OverSeaOpenLevelInfo;
		}
		foreach (FDemo820LevelInfo item in tArrayReadWrite)
		{
			if (item.LevelIndex == CurLevelIdx)
			{
				return item.RebrithPoint;
			}
		}
		return 0;
	}

	public int GetCurLevelIdx()
	{
		return CurLevelIdx;
	}

	public void EnterLevel()
	{
		if (IsInBattleLevel())
		{
			SingleLevelTime = 0f;
			TickSingleLevelTime = true;
			BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(this));
			if (readOnlyData != null)
			{
				readOnlyData.Demo820MapIdx = CurLevelIdx;
			}
		}
	}

	public int GetLevelIdByIdx(int Idx)
	{
		TArrayReadWrite<FDemo820LevelInfo> tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OpenLevelInfo;
		if (DebugConfig.Demo820OverSeaVersion)
		{
			tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OverSeaOpenLevelInfo;
		}
		foreach (FDemo820LevelInfo item in tArrayReadWrite)
		{
			if (item.LevelIndex == Idx)
			{
				return item.LevelID;
			}
		}
		return 0;
	}

	public FDemo820LevelInfo GetLevelInfoByIdx(int Idx)
	{
		TArrayReadWrite<FDemo820LevelInfo> tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OpenLevelInfo;
		if (DebugConfig.Demo820OverSeaVersion)
		{
			tArrayReadWrite = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OverSeaOpenLevelInfo;
		}
		foreach (FDemo820LevelInfo item in tArrayReadWrite)
		{
			if (item.LevelIndex == Idx)
			{
				return item;
			}
		}
		return default(FDemo820LevelInfo);
	}

	public int GetLevelImgIdx(UObject WorldContext, int LevelIdx)
	{
		BGWDemo820ConfigDataAsset bGWDemo820ConfigDataAsset = BGW_PreloadAssetMgr.Get(WorldContext)?.Demo820ConfigDataAsset;
		if (DebugConfig.Demo820OverSeaVersion)
		{
			foreach (FDemo820LevelInfo item in bGWDemo820ConfigDataAsset.OverSeaOpenLevelInfo)
			{
				if (LevelIdx == item.LevelIndex)
				{
					return item.LevelImageIndex;
				}
			}
		}
		else
		{
			using TArrayBase<FDemo820LevelInfo>.Enumerator enumerator = bGWDemo820ConfigDataAsset.OpenLevelInfo.GetEnumerator();
			if (enumerator.MoveNext())
			{
				return enumerator.Current.LevelImageIndex;
			}
		}
		return 0;
	}

	public string GetReportEmail()
	{
		return HasReportEmail;
	}

	public bool OnSettingInit()
	{
		return File.Exists(DemoSettingConfig);
	}

	public bool IsDemo820TimeOut()
	{
		return GamePlayTime > GamePlayTimeMax;
	}

	public bool IsInStartLevel()
	{
		string text = BGWGameInstanceCS.Get(this).GetWorldForCS().PathName.Split('.').Last();
		if (!text.Contains("SelectLevel"))
		{
			return text.Contains("Startup");
		}
		return true;
	}

	public void GMReSetData()
	{
		BGW_EventCollection.Get(this).Evt_SetGamePause(EPauseEvent.OpenUI, bPause: false);
		BGW_GameArchiveMgr bGW_GameArchiveMgr = BGW_GameArchiveMgr.Get(this);
		if (IsInBattleLevel())
		{
			bGW_GameArchiveMgr.MarkSaveArchive(EArchiveSaveSource.ReSet820Data);
			bGW_GameArchiveMgr.WaitArchiveMgrStop(Demo820ReSetData);
		}
		else
		{
			Demo820ReSetData();
		}
	}

	private void Demo820ReSetData()
	{
		BGW_EventCollection.Get(this).Evt_SetGamePause(EPauseEvent.LoadingScreen, bPause: true);
		BGW_EventCollection.Get(this).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.Demo820ReSetData);
	}

	private bool CheckBossHP()
	{
		ABGUCharacter[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ABGUCharacter>(this);
		if (allActorsOfClass != null)
		{
			float bossHpPercent = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.BossHpPercent;
			ABGUCharacter[] array = allActorsOfClass;
			for (int i = 0; i < array.Length; i++)
			{
				BGUCharacterCS bGUCharacterCS = array[i] as BGUCharacterCS;
				if (!CheckBossResID(bGUCharacterCS))
				{
					continue;
				}
				BUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(bGUCharacterCS);
				if (readOnlyData != null)
				{
					float floatValue = readOnlyData.GetFloatValue(EBGUAttrFloat.Hp);
					float floatValue2 = readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax);
					if (floatValue2 > 0f)
					{
						return bossHpPercent > floatValue / floatValue2 * 100f;
					}
				}
			}
		}
		return false;
	}

	private bool CheckBossResID(BGUCharacterCS BGUCharacter)
	{
		if (BGUCharacter.IsNullOrDestroyed())
		{
			return false;
		}
		if (BGUCharacter.GetResID() == 4706)
		{
			BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(BGUCharacter);
			if (readOnlyData != null && readOnlyData.HasBuff(470606))
			{
				return true;
			}
			return false;
		}
		foreach (int delayTimeBoss in BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.DelayTimeBossList)
		{
			if (BGUCharacter.GetResID() == delayTimeBoss)
			{
				return true;
			}
		}
		return false;
	}

	public void BeginWaitPSOFinish(bool bNeedShowBox)
	{
		NeedCheckPSOFinish = true;
		NeedShowBox = bNeedShowBox;
	}

	public void CheckPSOFinish(float DeltaTime)
	{
		if (NeedCheckPSOFinish && UGSE_EngineFuncLib.GetRemainingPsoPrecompileNum() <= 0)
		{
			OnDemo820SettingInitFinishLogic(NeedShowBox);
			NeedCheckPSOFinish = false;
		}
	}

	public void OnDemo820SettingInitFinishLogic(bool bNeedShowBox)
	{
		NeedShowBox = bNeedShowBox;
		string path = Path.Combine(FPaths.ProjectPersistentDownloadDir, "DemoSettingConfig.sav");
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		BGW_UIEventCollection.Get(this)?.Evt_UI_820HideInitTips();
		if (NeedShowBox)
		{
			UGSE_EngineFuncLib.GetDeviceInfo(out var Cpu, out var Gpu, out var _);
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			string text = "";
			text = text + "DeviceInfo：" + Cpu + "  , " + Gpu + "\n";
			text += $"ScreenResolution：{gameUserSettings.GetScreenResolution().X} * {gameUserSettings.GetScreenResolution().Y}\n";
			gameUserSettings.GetResolutionScaleInformationEx(out var _, out var CurrentScaleValue, out var _, out var _);
			text += $"ResolutionScale：{CurrentScaleValue}\n";
			text += $"ScreenMode：{gameUserSettings.GetFullscreenMode()}\n";
			text += $"VSync：{gameUserSettings.IsVSyncEnabled()}\n";
			text += $"Quality：{gameUserSettings.GetOverallScalabilityLevel()}\n";
			FMessage.OpenDialog("Init Finish：\n" + text);
		}
	}

	public bool GetHasStartInit()
	{
		return HasStartInit;
	}

	public void SetHasStartInit(bool sHasStartInit)
	{
		if (!HasStartInit)
		{
			InitTipsUI();
		}
		HasStartInit = sHasStartInit;
	}

	public void GMChangeMaxTime(int GMGamePlayTimeMax)
	{
		GamePlayTimeMax = GMGamePlayTimeMax;
		BossDelayGamePlayTimeMax = (float)GMGamePlayTimeMax + BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.BossDelayTime;
	}

	public void GMPauseTick()
	{
		IsSetPausedTimeout = true;
	}

	public void InitTipsUI()
	{
		ShowWarningUI();
		IsTimeWarnFinish.SetValue(EChangeReason.ManualSet, GamePlayTimeTipsList.Count == 0);
		if (GamePlayTime > GamePlayTimeMax && !IsSetPausedTimeout)
		{
			IsTimeOut.SetValue(EChangeReason.ManualSet, value: true);
		}
		CheckSmallTimeTip();
	}

	public void RefreshDataInfo()
	{
		OnDataInit();
		try
		{
			TryReadSaveGame();
		}
		catch (Exception arg)
		{
			BGW_LogUtil.LogError($"TryReadSaveGame Fail : {arg}");
		}
	}

	public void SetTimeInfo()
	{
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("b.GMSetTimeInfo");
		if (consoleVariable != null && consoleVariable.GetInt() > 0)
		{
			return;
		}
		FDemo820TimeInfo fDemo820TimeInfo = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.TimeInfo;
		if (DebugConfig.Demo820OverSeaVersion)
		{
			fDemo820TimeInfo = BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.OverSeaTimeInfo;
		}
		GamePlayTimeMax = fDemo820TimeInfo.GameplayTimeMax;
		GamePlayTimeTips = fDemo820TimeInfo.TipsTimeDur;
		GamePlayTimeSmallTips = fDemo820TimeInfo.SmallTipsTimeDur;
		BossDelayGamePlayTimeMax = fDemo820TimeInfo.GameplayTimeMax + BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.BossDelayTime;
		GamePlayTimeTipsList = new List<float>();
		foreach (int item in fDemo820TimeInfo.TipsTime)
		{
			GamePlayTimeTipsList.Add(item);
		}
	}

	public void SetTimeInfoByGM(int GMGameplayTimeMax, int GMTipsTimeDur, int GMSmallTipsTimeDur, int GMTipsTime1, int GMTipsTime2, int GMTipsTime3, int GMTipsTime4)
	{
		GamePlayTimeMax = GMGameplayTimeMax;
		GamePlayTimeTips = GMTipsTimeDur;
		GamePlayTimeSmallTips = GMSmallTipsTimeDur;
		BossDelayGamePlayTimeMax = (float)GMGameplayTimeMax + BGW_PreloadAssetMgr.Get(this).Demo820ConfigDataAsset.BossDelayTime;
		GamePlayTimeTipsList = new List<float>();
		GamePlayTimeTipsList.Add(GMTipsTime1);
		GamePlayTimeTipsList.Add(GMTipsTime2);
		GamePlayTimeTipsList.Add(GMTipsTime3);
		GamePlayTimeTipsList.Add(GMTipsTime4);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_820DemoPlayTimeMgr");
	}

	static BGW_820DemoPlayTimeMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_820DemoPlayTimeMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_820DemoPlayTimeMgr));
	}
}
