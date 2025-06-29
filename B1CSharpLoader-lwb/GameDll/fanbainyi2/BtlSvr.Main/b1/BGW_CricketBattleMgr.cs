using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using b1.BGW;
using b1.GSFile;
using b1.Plugins.AkAudio;
using BtlShare;
using LitJson;
using ResB1;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_CricketBattleMgr")]
public class BGW_CricketBattleMgr : GameInstanceSystemBaseUObj
{
	private static List<int> DeadUnitIdList;

	private static Dictionary<int, int> ParticipateUnitDict;

	public static string GameTipsString;

	public static List<int> ZbbCricketUnitList;

	public static ServerCricketData ServerCricketData;

	public static CricketBattleMode CricketBattleMode;

	public static int CameraIndex;

	public static float CameraBlendTime;

	public static int CameraIndexMax;

	public static float BeginUIAmTime;

	public static bool BattleReady;

	public static bool PreEnterLevel;

	public static float BattleReadyCheckTime;

	public static int CurRankId;

	public static float DelayShowName;

	public static List<CricketBattleInfoData> CricketBattleInfoDataList;

	public static string TestJson;

	public static int DPSTotal;

	public static float DPSTestTime;

	public static int DPSTestExtendId;

	public static float DelaySpawnTime;

	public static CricketAwardBattleResultReq AwardBattleResultReq;

	public static List<int> DPSUnitList;

	public static bool CmdStart;

	public static string DPSAutoStr;

	public static bool NeedSwitchCamera;

	public static bool IsPressStartGame;

	public static UAkAudioEvent SeqAkAudioEvent;

	public static UAkAudioEvent PlayAkAudioEvent;

	public static UAkAudioEvent StopAkAudioEvent;

	public float DelaySeqTime;

	public bool BlackActiveState = true;

	public bool ServerBattleStart;

	public float CheckBattleStartTime;

	public float CheckBlackTime;

	public bool IsPressBlack;

	public string DebugServerStr;

	public bool NeedRandomResult;

	public float RandomResultTime;

	public float DPSTime;

	public float ReportTime;

	public bool NeedServerReport;

	public override bool bTickEnabled => true;

	public static BGW_CricketBattleMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_CricketBattleMgr>(WorldContext);
	}

	public override void OnInit()
	{
		base.OnInit();
		USystemLibrary.ExecuteConsoleCommand(this, "a.URO.Enable 0", null);
	}

	public void InitStaticData()
	{
		CricketBattleMode = (CricketBattleMode)DebugConfig.CricketBattleModeType;
		ParticipateUnitDict.Clear();
		DeadUnitIdList.Clear();
		GameTipsString = "";
		ZbbCricketUnitList.Clear();
		CameraIndex = 0;
		BattleReady = false;
		CricketBattleInfoDataList.Clear();
		PreEnterLevel = false;
		BattleReadyCheckTime = 2f;
		DelayShowName = 0f;
		DelaySpawnTime = 0f;
		CameraBlendTime = 0.1f;
		DelaySeqTime = 0f;
		NeedSwitchCamera = false;
		IsPressStartGame = false;
		switch (CricketBattleMode)
		{
		case CricketBattleMode.Local:
		case CricketBattleMode.ZBB:
			InitZbbUnitList();
			break;
		case CricketBattleMode.Server:
		{
			string awardBattleInfoFromServer = GetAwardBattleInfoFromServer();
			awardBattleInfoFromServer = awardBattleInfoFromServer.Replace("\"group_id\"", "\"GroupId\"");
			awardBattleInfoFromServer = awardBattleInfoFromServer.Replace("\"monster\"", "\"Monster\"");
			awardBattleInfoFromServer = awardBattleInfoFromServer.Replace("\"id\"", "\"Id\"");
			awardBattleInfoFromServer = awardBattleInfoFromServer.Replace("\"name\"", "\"Name\"");
			awardBattleInfoFromServer = awardBattleInfoFromServer.Replace("\"username\"", "\"Username\"");
			awardBattleInfoFromServer = awardBattleInfoFromServer.Replace("\"account\"", "\"Account\"");
			InitServerInfo(awardBattleInfoFromServer);
			break;
		}
		}
	}

	public int SpawnActor(UObject WorldContext)
	{
		CurRankId = 4;
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		switch (CricketBattleMode)
		{
		case CricketBattleMode.ZBB:
			dictionary = GetZbbUnitList();
			break;
		case CricketBattleMode.Local:
			dictionary = GetZbbUnitList();
			break;
		case CricketBattleMode.Server:
			dictionary = GetServerUnitList();
			break;
		case CricketBattleMode.DPSTest:
			dictionary = GetZbbDPSTestList();
			break;
		}
		if (dictionary != null)
		{
			BGWCricketMgrLogic.SpawnCricketActor(this, dictionary);
		}
		PreEnterLevel = true;
		DeadUnitIdList.Clear();
		DPSTotal = 0;
		DPSTime = 0f;
		return 0;
	}

	private void SwitchYuReCamera()
	{
		if (CameraIndex == CameraIndexMax)
		{
			SwitchCamera(this, 1);
			BGW_UIEventCollection.Get(this).Evt_CricketBattleStart();
			BeginUIAmTime = 3.5f;
			CameraIndex = -1;
			NeedSwitchCamera = false;
			return;
		}
		CricketBattleUnitDesc cricketBattleUnitDescByExtendId = GameDBRuntime.GetCricketBattleUnitDescByExtendId(CricketBattleInfoDataList[CameraIndex].ExtendId);
		if (cricketBattleUnitDescByExtendId == null)
		{
			return;
		}
		AActor battleUnit = CricketBattleInfoDataList[CameraIndex].BattleUnit;
		if (battleUnit != null && (battleUnit as ABGUCharacter).Mesh.GetAnimInstance() != null)
		{
			UAnimMontage montage = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UAnimMontage>(cricketBattleUnitDescByExtendId.ShowAMPath, ELoadResourceType.SyncLoadAndCache);
			BGUFuncLibAnim.BGUActorTryPlayMontage(battleUnit, montage, FName.None);
		}
		if (CameraIndex == 0)
		{
			if (cricketBattleUnitDescByExtendId != null)
			{
				string ownerName = CricketBattleInfoDataList[CameraIndex].OwnerName;
				BGW_UIEventCollection.Get(this)?.Evt_UI_ActiveCricketName?.Invoke(B1: true, cricketBattleUnitDescByExtendId.NameId, ownerName, BGW_PreloadAssetMgr.Get(this).CricketBattleDataAsset.NameShowTime);
			}
		}
		else
		{
			DelayShowName = BGW_PreloadAssetMgr.Get(this).CricketBattleDataAsset.DelayShowName;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
		if (CricketBattleInfoDataList == null || CricketBattleInfoDataList.Count <= CameraIndex)
		{
			return;
		}
		AActor battleTamer = CricketBattleInfoDataList[CameraIndex].BattleTamer;
		if (battleTamer != null)
		{
			UCineCameraComponent uCineCameraComponent = battleTamer.GetComponentsByClass(UClass.GetClass<UCineCameraComponent>())[0] as UCineCameraComponent;
			AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(firstLocalPlayerController.World, new FName("YuRe_Scence_" + CameraIndex));
			aActor.SetActorTransform(uCineCameraComponent.GetWorldTransform(), bSweep: false, out var _, bTeleport: true);
			if (aActor != null)
			{
				float blendTime = ((CameraIndex == 0) ? 0f : BGW_PreloadAssetMgr.Get(this).CricketBattleDataAsset.CameraBlendTime);
				firstLocalPlayerController.SetViewTargetWithBlend(aActor, blendTime, EViewTargetBlendFunction.VTBlend_EaseInOut, 7.3f);
				BUS_EventCollectionCS.Get(controlledPawn)?.Evt_DetachCameraFromPlayer.Invoke();
				CameraIndex++;
			}
		}
	}

	private void SetBattleUnitHiddenInGame(int ShowIndex)
	{
		if (CricketBattleInfoDataList == null)
		{
			return;
		}
		int num = 1;
		foreach (CricketBattleInfoData cricketBattleInfoData in CricketBattleInfoDataList)
		{
			if (cricketBattleInfoData.BattleUnit != null)
			{
				cricketBattleInfoData.BattleUnit.SetActorHiddenInGame(ShowIndex != 0 && ShowIndex != num);
			}
			num++;
		}
	}

	private Dictionary<int, string> RandomExtendIdList()
	{
		int num = ParticipateUnitDict.Count / 4 + 1;
		GameTipsString = $"本地随机模式:16进4赛(第{num}/4轮)";
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		TBCricketBattleUnitDesc tBCricketBattleUnitDesc = GameDBRuntime.GetTBCricketBattleUnitDesc();
		int count = tBCricketBattleUnitDesc.List.Count;
		bool flag = false;
		if (ParticipateUnitDict.Count == 16)
		{
			ParticipateUnitDict.Clear();
			GameTipsString = "本地随机模式: 四强赛";
			flag = true;
		}
		for (int i = 0; i < 4; i++)
		{
			int num2 = FMath.RandRange(0, count - 1);
			while (ParticipateUnitDict.ContainsKey(num2))
			{
				num2++;
				if (num2 >= count)
				{
					num2 = 0;
				}
			}
			if (!ParticipateUnitDict.ContainsKey(num2))
			{
				CricketBattleUnitDesc cricketBattleUnitDesc = tBCricketBattleUnitDesc.List[num2];
				ParticipateUnitDict.Add(num2, cricketBattleUnitDesc.ExtentBattleId);
				dictionary.Add(cricketBattleUnitDesc.ExtentBattleId, cricketBattleUnitDesc.TamerPath);
			}
		}
		if (flag)
		{
			ParticipateUnitDict.Clear();
		}
		return dictionary;
	}

	public void SetPlayerState(UObject WorldContext)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		if (firstLocalPlayerController != null)
		{
			APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
			controlledPawn.SetActorHiddenInGame(bNewHidden: true);
			controlledPawn.SetActorEnableCollision(bNewActorEnableCollision: false);
			uint uniqueID = GetUniqueID();
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(controlledPawn);
			bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.ImmueDamage);
			bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantBeBaseTarget);
			bUS_GSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_GravityScale, 0f, 0u, uniqueID);
			bUS_GSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Capsule_EnableGravity, Value: false, 0u, uniqueID);
			bUS_GSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_EnableGravity, Value: false, 0u, uniqueID);
			BGW_EventCollection.Get(WorldContext).Evt_SetGamePause(EPauseEvent.BattleInput, bPause: true);
		}
	}

	private void UpdateRank(int BattleExtendId)
	{
		foreach (CricketBattleInfoData cricketBattleInfoData in CricketBattleInfoDataList)
		{
			if (cricketBattleInfoData.ExtendId == BattleExtendId)
			{
				cricketBattleInfoData.Rank = CurRankId;
				CurRankId--;
				break;
			}
		}
	}

	public void OnBattleUnitDead(UObject WorldContext, int BattleExtendId)
	{
		if (CricketBattleMode == CricketBattleMode.Server || CricketBattleMode == CricketBattleMode.ZBB || CricketBattleMode == CricketBattleMode.Local)
		{
			UpdateRank(BattleExtendId);
			BGW_UIEventCollection.Get(this).Evt_UpdateCricketBattleUI();
		}
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, UClass.GetClass<BGUCharacterCS>());
		int num = 0;
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		AActor[] array = allActorsOfClass;
		for (int i = 0; i < array.Length; i++)
		{
			BGUCharacterCS bGUCharacterCS = array[i] as BGUCharacterCS;
			if (bGUCharacterCS.IsPlayerCharacterCS())
			{
				continue;
			}
			IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(bGUCharacterCS);
			if (readOnlyData != null && !readOnlyData.HasState(EBGUUnitState.Dead) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.PendingDeathInAnimationSyncing))
			{
				num++;
				int teamIDInCS = bGUCharacterCS.GetTeamIDInCS();
				if (!dictionary.ContainsKey(teamIDInCS))
				{
					dictionary.Add(teamIDInCS, teamIDInCS);
				}
			}
		}
		if (dictionary.Count == 1)
		{
			ReportBattleResult();
			_ = CricketBattleMode;
			_ = 1;
			if (CricketBattleMode == CricketBattleMode.DPSTest && DPSUnitList.Count > 0)
			{
				DPSTestTime = 0.1f;
			}
		}
	}

	public void BattleFinishShow()
	{
		if (CricketBattleMode == CricketBattleMode.Server || CricketBattleMode == CricketBattleMode.ZBB || CricketBattleMode == CricketBattleMode.Local)
		{
			BGW_UIEventCollection.Get(this).Evt_CricketBattleEnd();
		}
	}

	private void ReportBattleResult()
	{
		if (CricketBattleInfoDataList != null)
		{
			foreach (CricketBattleInfoData cricketBattleInfoData in CricketBattleInfoDataList)
			{
				if (cricketBattleInfoData != null && cricketBattleInfoData.Rank == 0)
				{
					cricketBattleInfoData.Rank = 1;
					break;
				}
			}
		}
		if (CricketBattleMode == CricketBattleMode.Server || CricketBattleMode == CricketBattleMode.ZBB)
		{
			DelaySeqTime = 3f;
		}
		if (CricketBattleMode != CricketBattleMode.Server || !DebugConfig.CricketReportServer)
		{
			return;
		}
		foreach (CricketBattleInfoData cricketBattleInfoData2 in CricketBattleInfoDataList)
		{
			foreach (CricketAwardBattleResultItem item in AwardBattleResultReq.result)
			{
				if (GameDBRuntime.GetCricketBattleUnitDescByExtendId(cricketBattleInfoData2.ExtendId).Id == item.monster_id)
				{
					item.idx = cricketBattleInfoData2.Rank - 1;
				}
			}
		}
	}

	private void TryReportBattleResult()
	{
		string text = "http://awards2024.gamesci.com.cn:18532/award/battle_result";
		try
		{
			HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(text);
			obj.KeepAlive = false;
			obj.Method = "Post";
			obj.Headers = new WebHeaderCollection();
			obj.ContentType = "application/json";
			string s = JsonMapper.ToJson(AwardBattleResultReq);
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			obj.GetRequestStream().Write(bytes, 0, bytes.Length);
			if ((obj.GetResponse() as HttpWebResponse).StatusCode != HttpStatusCode.OK)
			{
				ReportTime = 2f;
			}
		}
		catch (Exception ex)
		{
			GameTipsString = $"发起了服务器请求，但获取信息失败：{ex}";
			BGW_LogUtil.LogError($"Request:{text} Fail, Ex:{ex}");
		}
	}

	private void KillAllMonster()
	{
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(this, UClass.GetClass<BGUCharacterCS>());
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			BGUCharacterCS bGUCharacterCS = allActorsOfClass[i] as BGUCharacterCS;
			if (!bGUCharacterCS.IsPlayerCharacterCS())
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_UnitDead.Invoke(bGUCharacterCS, EDeadReason.OnlyDestroyUnit);
				}
			}
		}
	}

	private void PlayWinnerSeq()
	{
		foreach (CricketBattleInfoData cricketBattleInfoData in CricketBattleInfoDataList)
		{
			if (cricketBattleInfoData.Rank == 1)
			{
				HideAllMonster();
				CricketBattleUnitDesc cricketBattleUnitDescByExtendId = GameDBRuntime.GetCricketBattleUnitDescByExtendId(cricketBattleInfoData.ExtendId);
				BGWCricketMgrLogic.PlayCricketSeq(this, cricketBattleUnitDescByExtendId.WinnerSeqId);
				UAkGameplayStatics.PostEventAtLocation(StopAkAudioEvent, FVector.ZeroVector, FRotator.ZeroRotator, "EVT_music_nianhui_stop", this);
				break;
			}
		}
	}

	private void HideAllMonster()
	{
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(this, UClass.GetClass<BGUCharacterCS>());
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			allActorsOfClass[i].SetActorHiddenInGame(bNewHidden: true);
		}
		allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(this, UClass.GetClass<BGUWeaponBase>());
		foreach (AActor aActor in allActorsOfClass)
		{
			if (!aActor.ActorHasTag(B1GlobalFNames.LSPWeapon))
			{
				aActor.SetActorHiddenInGame(bNewHidden: true);
			}
		}
	}

	private Dictionary<int, string> GetZbbUnitList()
	{
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		TBCricketBattleUnitDesc tBCricketBattleUnitDesc = GameDBRuntime.GetTBCricketBattleUnitDesc();
		foreach (int zbbCricketUnit in ZbbCricketUnitList)
		{
			foreach (CricketBattleUnitDesc item in tBCricketBattleUnitDesc.List)
			{
				if (item.ExtentBattleId == zbbCricketUnit)
				{
					dictionary.Add(item.ExtentBattleId, item.TamerPath);
					break;
				}
			}
		}
		return dictionary;
	}

	private Dictionary<int, string> GetZbbDPSTestList()
	{
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		List<int> list = FillDpsUnit();
		TBCricketBattleUnitDesc tBCricketBattleUnitDesc = GameDBRuntime.GetTBCricketBattleUnitDesc();
		foreach (int item in list)
		{
			foreach (CricketBattleUnitDesc item2 in tBCricketBattleUnitDesc.List)
			{
				if (item2.ExtentBattleId == item)
				{
					dictionary.Add(item2.ExtentBattleId, item2.TamerPath);
					break;
				}
			}
		}
		return dictionary;
	}

	private List<int> FillDpsUnit()
	{
		List<int> list = new List<int>();
		if (DPSUnitList != null && DPSUnitList.Count > 0)
		{
			return DPSUnitList;
		}
		CricketBattleUnitDesc cricketBattleUnitDescByExtendId = GameDBRuntime.GetCricketBattleUnitDescByExtendId(DPSTestExtendId);
		if (cricketBattleUnitDescByExtendId == null)
		{
			return list;
		}
		list.Add(DPSTestExtendId);
		if (cricketBattleUnitDescByExtendId.Id > 3)
		{
			for (int i = 1; i < 4; i++)
			{
				CricketBattleUnitDesc cricketBattleUnitDesc = GameDBRuntime.GetCricketBattleUnitDesc(i);
				list.Add(cricketBattleUnitDesc.ExtentBattleId);
			}
		}
		else
		{
			for (int j = 1; j < 4; j++)
			{
				CricketBattleUnitDesc cricketBattleUnitDesc2 = GameDBRuntime.GetCricketBattleUnitDesc(j + 3);
				list.Add(cricketBattleUnitDesc2.ExtentBattleId);
			}
		}
		return list;
	}

	private void InitZbbUnitList()
	{
		GameTipsString = "本局为本地ZBB模式：出场怪物如下";
		foreach (int cricketUnitIndex in BGW_PreloadAssetMgr.Get(this).CricketBattleDataAsset.CricketUnitIndexList)
		{
			ZbbCricketUnitList.Add(cricketUnitIndex);
			GameTipsString = GameTipsString + cricketUnitIndex + "\n";
		}
	}

	private void InitServerInfo(string ServerInfoStr)
	{
		bool flag = false;
		if (ServerInfoStr == "")
		{
			string path = Path.Combine(GSEFileUtil.ProjectPersistentDownloadDir, "ZbbCricketBattle.json");
			ServerInfoStr = TestJson;
			if (File.Exists(path))
			{
				ServerInfoStr = File.ReadAllText(path);
			}
			flag = true;
		}
		ServerCricketData = JsonMapper.ToObject<ServerCricketData>(ServerInfoStr);
		if (flag)
		{
			BuildDebugData();
		}
		AwardBattleResultReq = new CricketAwardBattleResultReq();
		AwardBattleResultReq.secret_key = "awards2024";
		AwardBattleResultReq.group_id = ServerCricketData.GroupId;
		AwardBattleResultReq.result = new List<CricketAwardBattleResultItem>();
		foreach (CricketAwardBattleMonster item in ServerCricketData.Monster)
		{
			CricketAwardBattleResultItem cricketAwardBattleResultItem = new CricketAwardBattleResultItem();
			cricketAwardBattleResultItem.monster_id = item.Id;
			AwardBattleResultReq.result.Add(cricketAwardBattleResultItem);
		}
	}

	private void BuildDebugData()
	{
		TArrayReadWrite<int> cricketUnitIndexList = BGW_PreloadAssetMgr.Get(this).CricketBattleDataAsset.CricketUnitIndexList;
		if (cricketUnitIndexList.Count < 4)
		{
			return;
		}
		int num = 0;
		foreach (CricketAwardBattleMonster item in ServerCricketData.Monster)
		{
			CricketBattleUnitDesc cricketBattleUnitDescByExtendId = GameDBRuntime.GetCricketBattleUnitDescByExtendId(cricketUnitIndexList[num]);
			item.Id = cricketBattleUnitDescByExtendId.Id;
			num++;
		}
	}

	private Dictionary<int, string> GetServerUnitList()
	{
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		foreach (CricketAwardBattleMonster item in ServerCricketData.Monster)
		{
			CricketBattleUnitDesc cricketBattleUnitDesc = GameDBRuntime.GetCricketBattleUnitDesc(item.Id);
			if (cricketBattleUnitDesc != null)
			{
				int extentBattleId = cricketBattleUnitDesc.ExtentBattleId;
				string tamerPath = cricketBattleUnitDesc.TamerPath;
				dictionary.Add(extentBattleId, tamerPath);
			}
		}
		return dictionary;
	}

	public int StartBattle()
	{
		ReadStartBattle();
		return 0;
	}

	public void SeqFinished()
	{
		NeedSwitchCamera = true;
		SetPlayerState(this);
	}

	private void ReadStartBattle()
	{
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(this, UClass.GetClass<BGUCharacterCS>());
		BGWCricketMgrLogic.SetTeamIndex(this);
		AActor[] array = allActorsOfClass;
		for (int i = 0; i < array.Length; i++)
		{
			BGUCharacterCS bGUCharacterCS = array[i] as BGUCharacterCS;
			if (!bGUCharacterCS.IsPlayerCharacterCS())
			{
				BGUFuncLibAICS.SearchTargetSP(bGUCharacterCS);
			}
		}
		if ((CricketBattleMode == CricketBattleMode.DPSTest || CricketBattleMode == CricketBattleMode.ZBB) && (DPSUnitList == null || DPSUnitList.Count == 0))
		{
			DPSPauseAI();
		}
		DPSTime = 0.01f;
		BGW_UIEventCollection.Get(this).Evt_ShowCricketBattleUI();
		UAkGameplayStatics.PostEventAtLocation(PlayAkAudioEvent, FVector.ZeroVector, FRotator.ZeroRotator, "EVT_music_nianhui_play", this);
		if (NeedRandomResult)
		{
			RandomResultTime = BGW_PreloadAssetMgr.Get(this).CricketBattleDataAsset.BaodiKillTime;
			DPSTestExtendId = 0;
			DPSPauseAI();
		}
		else if (CricketBattleMode == CricketBattleMode.Server)
		{
			BGWCricketMgrLogic.PauseAllActorAI(this, IsPauseAI: false);
		}
	}

	private void DPSPauseAI()
	{
		if (CricketBattleMode == CricketBattleMode.ZBB && BGW_PreloadAssetMgr.Get(this).CricketBattleDataAsset.CricketUnitIndexList.Count > 0)
		{
			DPSTestExtendId = BGW_PreloadAssetMgr.Get(this).CricketBattleDataAsset.CricketUnitIndexList[0];
		}
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(this, UClass.GetClass<BGUCharacterCS>());
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			BGUCharacterCS bGUCharacterCS = allActorsOfClass[i] as BGUCharacterCS;
			if (!bGUCharacterCS.IsPlayerCharacterCS())
			{
				BUTamerActor bUTamerActor = bGUCharacterCS.GetTamerOwner() as BUTamerActor;
				int resID = bUTamerActor.ConfigInfoComp.UnitCDesc.ResID;
				int overrideID = bUTamerActor.ConfigInfoComp.UnitCDesc.OverrideID;
				FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(resID);
				if (((overrideID > 0) ? overrideID : unitCommDesc.DefaultBattleInfoExtendID) != DPSTestExtendId)
				{
					bUTamerActor.ConfigInfoComp.UnitBehaviorTree = null;
					BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_AIPauseBT.Invoke(P1: true);
				}
			}
		}
	}

	public int SwitchCamera(UObject WorldContext, int CameraIndex)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
		AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(this, new FName("QuquCamera_" + CameraIndex));
		if (aActor != null)
		{
			firstLocalPlayerController.SetViewTargetWithBlend(aActor, 0f, EViewTargetBlendFunction.VTBlend_EaseOut, 1f);
			BUS_EventCollectionCS.Get(controlledPawn)?.Evt_DetachCameraFromPlayer.Invoke();
		}
		return 0;
	}

	public void KillAllActorAndReStartGame(UObject WorldContext)
	{
		KillAllMonster();
		SpawnActor(WorldContext);
	}

	public static string GetAwardBattleInfoFromServer()
	{
		if (!DebugConfig.CricketReportServer)
		{
			return "";
		}
		string text = "http://awards2024.gamesci.com.cn:18532/award/battle_info?secret_key=awards2024";
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = false;
			httpWebRequest.Method = "GET";
			httpWebRequest.Headers = new WebHeaderCollection();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			responseStream.Close();
			httpWebResponse?.Close();
			httpWebRequest?.Abort();
			return result;
		}
		catch (Exception ex)
		{
			GameTipsString = $"发起了服务器请求，但获取信息失败：{ex}";
			BGW_LogUtil.LogError($"Request:{text} Fail, Ex:{ex}");
		}
		return "";
	}

	private void FillCricketBattleInfoList(List<BGUCharacterCS> TargetCricketList)
	{
		foreach (BGUCharacterCS TargetCricket in TargetCricketList)
		{
			BUTamerActor obj = TargetCricket.GetTamerOwner() as BUTamerActor;
			int resID = obj.ConfigInfoComp.UnitCDesc.ResID;
			int overrideID = obj.ConfigInfoComp.UnitCDesc.OverrideID;
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(resID);
			int num = ((overrideID > 0) ? overrideID : unitCommDesc.DefaultBattleInfoExtendID);
			CricketAwardBattleMonster cricketAwardBattleMonster = new CricketAwardBattleMonster();
			if (ServerCricketData.Monster != null)
			{
				foreach (CricketAwardBattleMonster item in ServerCricketData.Monster)
				{
					CricketBattleUnitDesc cricketBattleUnitDesc = GameDBRuntime.GetCricketBattleUnitDesc(item.Id);
					if (cricketBattleUnitDesc != null && cricketBattleUnitDesc.ExtentBattleId == num)
					{
						cricketAwardBattleMonster = item;
						break;
					}
				}
			}
			foreach (CricketBattleInfoData cricketBattleInfoData in CricketBattleInfoDataList)
			{
				if (cricketBattleInfoData.ExtendId == num)
				{
					cricketBattleInfoData.BattleUnit = TargetCricket;
					cricketBattleInfoData.ExtendId = num;
					cricketBattleInfoData.OwnerName = cricketAwardBattleMonster.Username;
					cricketBattleInfoData.Rank = 0;
					cricketBattleInfoData.BossName = cricketAwardBattleMonster.Name;
				}
			}
		}
		foreach (CricketBattleInfoData cricketBattleInfoData2 in CricketBattleInfoDataList)
		{
			DebugServerStr = DebugServerStr + cricketBattleInfoData2.OwnerName + ":" + cricketBattleInfoData2.BossName + "\n";
		}
	}

	public CricketBattleInfoData GetCricketBattleInfoData(int Index)
	{
		return CricketBattleInfoDataList[Index];
	}

	public string GetWinerName()
	{
		foreach (CricketBattleInfoData cricketBattleInfoData in CricketBattleInfoDataList)
		{
			if (cricketBattleInfoData.Rank == 0 || cricketBattleInfoData.Rank == 1)
			{
				return cricketBattleInfoData.OwnerName;
			}
		}
		return "";
	}

	public void IncDPS(AActor Attacker, int FinDamag)
	{
		if (DebugConfig.CricketBattleModeType != 3 && DebugConfig.CricketBattleModeType != 1)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Attacker as BGUCharacterCS;
		if (!(bGUCharacterCS != null) || bGUCharacterCS.GetFinalBattleInfoExtendID() == DPSTestExtendId)
		{
			if (FinDamag < 0)
			{
				FinDamag = -FinDamag;
			}
			DPSTotal += FinDamag;
		}
	}

	public void ReqDPSUnitAndSpawn(int TargetID, float TestTime, List<int> UnitList)
	{
		if (CricketBattleMode == CricketBattleMode.DPSTest)
		{
			if (TestTime == 0f)
			{
				BGW_LogUtil.LogError("服务器未设置ZBB超时保护，本地设置3分钟超时保护");
				TestTime = 180f;
			}
			DPSTestExtendId = TargetID;
			DPSUnitList = UnitList;
			DPSTestTime = TestTime;
			DelaySpawnTime = 1f;
			BGWCricketMgrLogic.AddStartBattleStr(TargetID, TestTime, UnitList);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		CheckSwitchYuReCamera(DeltaTime);
		if (BeginUIAmTime > 0f)
		{
			BeginUIAmTime -= DeltaTime;
			if (BeginUIAmTime <= 0f)
			{
				ReadStartBattle();
			}
		}
		CheckBattleReady(DeltaTime);
		CheckShowNameUI(DeltaTime);
		CheckDPSTestTime(DeltaTime);
		CheckDelaySpawnTime(DeltaTime);
		CheckPlayWinnerSeq(DeltaTime);
		CheckPlayStartSeq(DeltaTime);
		CheckBlackActive(DeltaTime);
		CheckRandomKillOneTeam(DeltaTime);
		CheckDpsTime(DeltaTime);
	}

	private void CheckDpsTime(float DeltaTime)
	{
		if (DPSTime > 0f)
		{
			DPSTime += DeltaTime;
		}
	}

	private void CheckSwitchYuReCamera(float DeltaTime)
	{
		if (NeedSwitchCamera && CameraIndex >= 0 && CameraIndex <= CameraIndexMax && CameraBlendTime > 0f)
		{
			CameraBlendTime -= DeltaTime;
			if (CameraBlendTime <= 0f)
			{
				CameraBlendTime = BGW_PreloadAssetMgr.Get(this).CricketBattleDataAsset.CameraWaitTime + BGW_PreloadAssetMgr.Get(this).CricketBattleDataAsset.CameraBlendTime;
				SwitchYuReCamera();
			}
		}
	}

	private void CheckShowNameUI(float DeltaTime)
	{
		if (!(DelayShowName > 0f))
		{
			return;
		}
		DelayShowName -= DeltaTime;
		if (!(DelayShowName <= 0f))
		{
			return;
		}
		CricketBattleInfoData cricketBattleInfoData = CricketBattleInfoDataList[CameraIndex - 1];
		if (cricketBattleInfoData != null)
		{
			CricketBattleUnitDesc cricketBattleUnitDescByExtendId = GameDBRuntime.GetCricketBattleUnitDescByExtendId(cricketBattleInfoData.ExtendId);
			if (cricketBattleUnitDescByExtendId != null)
			{
				BGW_UIEventCollection.Get(this)?.Evt_UI_ActiveCricketName?.Invoke(B1: true, cricketBattleUnitDescByExtendId.NameId, cricketBattleInfoData.OwnerName, BGW_PreloadAssetMgr.Get(this).CricketBattleDataAsset.NameShowTime);
			}
		}
	}

	private void CheckBattleReady(float DeltaTime)
	{
		if (BattleReady || !PreEnterLevel || !(BattleReadyCheckTime > 0f))
		{
			return;
		}
		BattleReadyCheckTime -= DeltaTime;
		if (!(BattleReadyCheckTime < 0f))
		{
			return;
		}
		List<BGUCharacterCS> list = new List<BGUCharacterCS>();
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(this, UClass.GetClass<ABGUCharacter>());
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			BGUCharacterCS bGUCharacterCS = allActorsOfClass[i] as BGUCharacterCS;
			if (!bGUCharacterCS.IsPlayerCharacterCS())
			{
				BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(bGUCharacterCS);
				BUC_AttrContainer readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(bGUCharacterCS);
				if (readOnlyData != null && readOnlyData2 != null && !readOnlyData.HasState(EBGUUnitState.Dead) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.PendingDeathInAnimationSyncing) && readOnlyData2.GetFloatValue(EBGUAttrFloat.HpMax) > 0f)
				{
					list.Add(bGUCharacterCS);
				}
			}
		}
		if (list.Count == 4)
		{
			FillCricketBattleInfoList(list);
			BattleReady = true;
			PreEnterLevel = false;
			BGWCricketMgrLogic.AddRandomBuff(this);
			BGW_UIEventCollection.Get(this).Evt_UpdateCricketBattleUI();
			if (CricketBattleMode == CricketBattleMode.Server)
			{
				BGWCricketMgrLogic.PauseAllActorAI(this, IsPauseAI: true);
			}
			if (CricketBattleMode == CricketBattleMode.DPSTest)
			{
				ReadStartBattle();
			}
		}
		else
		{
			BattleReadyCheckTime = 2f;
		}
	}

	private void CheckDPSTestTime(float DeltaTime)
	{
		if (DPSTestTime > 0f)
		{
			DPSTestTime -= DeltaTime;
			if (DPSTestTime <= 0f)
			{
				KillAllMonster();
				BattleReady = false;
				BattleReadyCheckTime = 2f;
				BGW_UIEventCollection.Get(this)?.Evt_UI_DPSTestReportAndReStart?.Invoke();
			}
		}
	}

	private void CheckDelaySpawnTime(float DeltaTime)
	{
		if (DelaySpawnTime > 0f)
		{
			DelaySpawnTime -= DeltaTime;
			if (DelaySpawnTime <= 0f)
			{
				SpawnActor(this);
			}
		}
	}

	private void CheckPlayWinnerSeq(float DeltaTime)
	{
		if (DelaySeqTime > 0f)
		{
			DelaySeqTime -= DeltaTime;
			if (DelaySeqTime <= 0f)
			{
				PlayWinnerSeq();
			}
		}
	}

	private void CheckPlayStartSeq(float DeltaTime)
	{
		if (!ServerBattleStart && CheckBattleStartTime > 0f)
		{
			CheckBattleStartTime -= DeltaTime;
			if (CheckBattleStartTime <= 0f)
			{
				PlayStartSeq();
				ServerBattleStart = true;
			}
		}
	}

	private void CheckBlackActive(float DeltaTime)
	{
		if (IsPressBlack && CheckBlackTime > 0f)
		{
			CheckBlackTime -= DeltaTime;
			if (CheckBlackTime <= 0f)
			{
				BlackActiveState = !BlackActiveState;
				IsPressBlack = false;
				BGW_UIEventCollection.Get(this)?.Evt_UI_BlackActiveState();
			}
		}
	}

	public void CheckRandomKillOneTeam(float DeltaTime)
	{
		if (NeedRandomResult && RandomResultTime > 0f)
		{
			RandomResultTime -= DeltaTime;
			if (RandomResultTime <= 0f)
			{
				BGWCricketMgrLogic.RandomKillOneTeam(this);
			}
		}
	}

	public void CheckServerReport(float DeltaTime)
	{
		if (NeedServerReport && ReportTime > 0f)
		{
			ReportTime -= DeltaTime;
			if (ReportTime < 0f)
			{
				TryReportBattleResult();
			}
		}
	}

	public bool AllUnitDead()
	{
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(this, UClass.GetClass<ABGUCharacter>());
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			if (!(allActorsOfClass[i] as BGUCharacterCS).IsPlayerCharacterCS())
			{
				return false;
			}
		}
		return true;
	}

	public void PlayStartSeq()
	{
		if (CricketBattleMode == CricketBattleMode.Server)
		{
			BGW_UIEventCollection.Get(this)?.Evt_UI_PlayStartSeq();
			UAkGameplayStatics.PostEventAtLocation(SeqAkAudioEvent, FVector.ZeroVector, FRotator.ZeroRotator, "EVT_music_nianhui_seq", this);
			BGWCricketMgrLogic.PlayCricketSeq(this, 990400023);
		}
	}

	public void PlayStartPress()
	{
		CheckBattleStartTime = BGW_PreloadAssetMgr.Get(this).CricketBattleDataAsset.PressStartGameTime;
		IsPressStartGame = true;
	}

	public void PlayStartComplete()
	{
		IsPressStartGame = false;
		CheckBattleStartTime = 0f;
	}

	public void CricketBattleBlackPress()
	{
		IsPressBlack = true;
		CheckBlackTime = BGW_PreloadAssetMgr.Get(this).CricketBattleDataAsset.PressBlackTime;
	}

	public void CricketBattleBlackCompleted()
	{
		IsPressBlack = false;
		CheckBlackTime = 0f;
	}

	static BGW_CricketBattleMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_CricketBattleMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_CricketBattleMgr));
		DeadUnitIdList = new List<int>();
		ParticipateUnitDict = new Dictionary<int, int>();
		ZbbCricketUnitList = new List<int>();
		ServerCricketData = new ServerCricketData();
		CameraIndex = 0;
		CameraIndexMax = 4;
		BeginUIAmTime = 0f;
		BattleReady = false;
		PreEnterLevel = false;
		BattleReadyCheckTime = 2f;
		DelayShowName = 0f;
		CricketBattleInfoDataList = new List<CricketBattleInfoData>();
		TestJson = "{\r\n    \"GroupId\": 1,\r\n    \"Monster\": [\r\n        {\"Id\": 1, \"Name\": \"虎先锋\", \"Account\": \"guansi\", \"Username\": \"黄冠斯\"},\r\n        {\"Id\": 2, \"Name\": \"毒敌大王\", \"Account\": \"ellen\", \"Username\": \"彭笔戎\"},\r\n        {\"Id\": 9, \"Name\": \"蚰蜒精\", \"Account\": \"shepherd\", \"Username\": \"吴方维\"},\r\n        {\"Id\": 11, \"Name\": \"锤龙\", \"Account\": \"joshli\", \"Username\": \"黎仲琰\"}\r\n    ]\r\n}";
		DPSUnitList = new List<int>();
		CmdStart = false;
		DPSAutoStr = "";
		NeedSwitchCamera = false;
		IsPressStartGame = false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_CricketBattleMgr");
	}
}
