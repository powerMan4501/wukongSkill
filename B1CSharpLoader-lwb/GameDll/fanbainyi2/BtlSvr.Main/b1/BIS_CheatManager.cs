using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using b1.AutoQA;
using b1.BGW;
using b1.CppExport;
using b1.EventDelDefine;
using b1.GSFile;
using b1.Localization;
using b1.Plugins.CustomLightSystem;
using BtlB1;
using BtlShare;
using CommB1;
using Diana.Common;
using Diana.Server.Common;
using GurGsPersistent;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BIS_CheatManager : GameInstanceSystemBase
{
	private class FPassiveSkillInfoConstructor : IDisposable
	{
		public int TableID { get; set; }

		public string TableName { get; set; }

		public List<FNetStruct_PassiveSkillInfo> PassiveSkills { get; } = new List<FNetStruct_PassiveSkillInfo>();

		public void TryAddPassiveSkillElement<T>(string ElementName, T CurrentValue, T OriginValue)
		{
			if (CurrentValue is float num && OriginValue is float num2)
			{
				if (Math.Abs(num - num2) > 1E-08f)
				{
					FNetStruct_PassiveSkillInfo item = new FNetStruct_PassiveSkillInfo
					{
						TableID = TableID,
						TableName = TableName,
						ElementName = ElementName,
						CurrentValue = num.ToString("F2"),
						OriginValue = num2.ToString("F2")
					};
					PassiveSkills.Add(item);
				}
				return;
			}
			if (CurrentValue is int num3 && OriginValue is int num4)
			{
				if (num3 != num4)
				{
					FNetStruct_PassiveSkillInfo item2 = new FNetStruct_PassiveSkillInfo
					{
						TableID = TableID,
						TableName = TableName,
						ElementName = ElementName,
						CurrentValue = num3.ToString("D"),
						OriginValue = num4.ToString("D")
					};
					PassiveSkills.Add(item2);
				}
				return;
			}
			if (CurrentValue is string text && OriginValue is string text2)
			{
				if (text != text2)
				{
					FNetStruct_PassiveSkillInfo item3 = new FNetStruct_PassiveSkillInfo
					{
						TableID = TableID,
						TableName = TableName,
						ElementName = ElementName,
						CurrentValue = text,
						OriginValue = text2
					};
					PassiveSkills.Add(item3);
				}
				return;
			}
			if (CurrentValue is IList list && OriginValue is IList list2)
			{
				int count = list.Count;
				int count2 = list2.Count;
				if (count == count2)
				{
					for (int i = 0; i < count; i++)
					{
						TryAddPassiveSkillElement($"{ElementName}[{i}]", list[i], list2[i]);
					}
				}
				return;
			}
			object obj = OriginValue;
			if (!CurrentValue.Equals(obj))
			{
				FNetStruct_PassiveSkillInfo item4 = new FNetStruct_PassiveSkillInfo
				{
					TableID = TableID,
					TableName = TableName,
					ElementName = ElementName,
					CurrentValue = CurrentValue.ToString(),
					OriginValue = OriginValue.ToString()
				};
				PassiveSkills.Add(item4);
			}
		}

		public void Dispose()
		{
			PassiveSkills.Clear();
		}
	}

	private bool DisabledInMono;

	private float PreloadInfo_TickerTimer;

	private float VideoMemory_TickerTimer;

	private static List<string> VideoMemoryStateNames = new List<string>
	{
		"STAT_RenderTargetMemory2D", "STAT_RenderTargetMemory3D", "STAT_RenderTargetMemoryCube", "STAT_TextureMemory2D", "STAT_TextureMemory3D", "STAT_TextureMemoryCube", "STAT_UniformBufferMemory", "STAT_IndexBufferMemory", "STAT_VertexBufferMemory", "STAT_RTAccelerationStructureMemory",
		"STAT_StructuredBufferMemory", "STAT_PixelBufferMemory", "STAT_DLSSVideoMemory"
	};

	private static List<string> SumMemoryStateNames = new List<string> { "STAT_PeakUsedPhysical", "STAT_UsedPhysical", "STAT_D3D12UsedVideoMemory", "STAT_D3D12UsedSystemMemory", "STAT_D3D12AvailableVideoMemory", "STAT_D3D12DemotedVideoMemory", "STAT_D3D12TotalVideoMemory" };

	private static List<string> OtherMemoryStateNames = new List<string> { "STAT_NavigationMemory", "STAT_WwiseMemoryMedia", "STAT_AsyncFileMemory", "STAT_SkeletalMeshIndexMemory", "STAT_SkeletalMeshVertexMemory", "STAT_StaticMeshTotalMemory2", "STAT_StreamingOverview01_StreamableRenderAssets", "STAT_StreamingOverview05_UnstreamableRenderAssets", "STAT_TEXTUREGROUP_Terrain_Weightmap", "STAT_TEXTUREGROUP_Terrain_Heightmap" };

	private static List<string> AllMemoryStateNames = new List<string>
	{
		"STAT_RenderTargetMemory2D", "STAT_RenderTargetMemory3D", "STAT_RenderTargetMemoryCube", "STAT_TextureMemory2D", "STAT_TextureMemory3D", "STAT_TextureMemoryCube", "STAT_UniformBufferMemory", "STAT_IndexBufferMemory", "STAT_VertexBufferMemory", "STAT_RTAccelerationStructureMemory",
		"STAT_StructuredBufferMemory", "STAT_PixelBufferMemory", "STAT_DLSSVideoMemory", "STAT_PeakUsedPhysical", "STAT_UsedPhysical", "STAT_D3D12UsedVideoMemory", "STAT_D3D12UsedSystemMemory", "STAT_D3D12AvailableVideoMemory", "STAT_D3D12DemotedVideoMemory", "STAT_D3D12TotalVideoMemory",
		"STAT_NavigationMemory", "STAT_WwiseMemoryMedia", "STAT_AsyncFileMemory", "STAT_SkeletalMeshIndexMemory", "STAT_SkeletalMeshVertexMemory", "STAT_StaticMeshTotalMemory2", "STAT_StreamingOverview01_StreamableRenderAssets", "STAT_StreamingOverview05_UnstreamableRenderAssets", "STAT_TEXTUREGROUP_Terrain_Weightmap", "STAT_TEXTUREGROUP_Terrain_Heightmap"
	};

	private List<FNetStruct_MemoryStateInfo> VideoMemoryStateInfos = new List<FNetStruct_MemoryStateInfo>();

	private List<FNetStruct_MemoryStateInfo> SumMemoryStateInfos = new List<FNetStruct_MemoryStateInfo>();

	private List<FNetStruct_MemoryStateInfo> OtherMemoryStateInfos = new List<FNetStruct_MemoryStateInfo>();

	private List<FNetStruct_UnitPreloadInfo> UnitPreloadInfos = new List<FNetStruct_UnitPreloadInfo>();

	private List<FNetStruct_PreloadResourceInfo> PreloadResourceInfos = new List<FNetStruct_PreloadResourceInfo>();

	private List<FNetStruct_PreloadResourceDetailInfo> ResourceDetailInfoArray = new List<FNetStruct_PreloadResourceDetailInfo>();

	public override bool bTickEnabled => true;

	private BIC_CheatData CheatData { get; set; }

	private IBIC_StateMachineData StateMachineData { get; set; }

	private IBIC_TaskData TaskData { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	public override void OnAttach()
	{
		CheatData = RequireWritableGameInstanceData<BIC_CheatData>();
		StateMachineData = RequireReadonlyGameInstanceData<IBIC_StateMachineData, BIC_StateMachineData>();
		TaskData = RequireReadonlyGameInstanceData<IBIC_TaskData, BIC_TaskData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_RefreshLevelInfo = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_RefreshLevelInfo, new Del_Void(OnRefreshLevelInfo));
			bGW_EventCollection.Evt_RefreshActorInfo = (Del_Void_String)Delegate.Combine(bGW_EventCollection.Evt_RefreshActorInfo, new Del_Void_String(OnRefreshActorInfo));
			bGW_EventCollection.Evt_MarkActorInfoRealTime = (Del_Void_StringBool)Delegate.Combine(bGW_EventCollection.Evt_MarkActorInfoRealTime, new Del_Void_StringBool(MarkActorInfoRealTime));
			bGW_EventCollection.Evt_RefreshActorInfoOnce = (Del_Void_String)Delegate.Combine(bGW_EventCollection.Evt_RefreshActorInfoOnce, new Del_Void_String(OnRefreshActorInfoOnce));
			bGW_EventCollection.Evt_PlayerDelayBeginPlayFinished = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PlayerDelayBeginPlayFinished, new Del_Void(OnPlayerDelayBeginPlayFinished));
			bGW_EventCollection.Evt_LockAllMonsterHP = (Del_Void_Bool)Delegate.Combine(bGW_EventCollection.Evt_LockAllMonsterHP, new Del_Void_Bool(OnLockAllMonsterHP));
			bGW_EventCollection.Evt_CancelAllMonsterSkillCD = (Del_Void_Bool)Delegate.Combine(bGW_EventCollection.Evt_CancelAllMonsterSkillCD, new Del_Void_Bool(OnCancelAllMonsterSkillCD));
			bGW_EventCollection.Evt_PauseAllMonsterAI = (Del_Void_Bool)Delegate.Combine(bGW_EventCollection.Evt_PauseAllMonsterAI, new Del_Void_Bool(OnPauseAllMonsterAI));
		}
	}

	public override int GetTickGroupMask()
	{
		return 256;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (TickGroup != 256)
		{
			return;
		}
		if (!BGWConsoleCommands.HasGMFlag(2))
		{
			if (CheatData.Server != null)
			{
				ShutdownCheatServer();
			}
			return;
		}
		if (CheatData.Server == null)
		{
			InitCheatServer();
		}
		if (PreloadInfo_TickerTimer > 0f)
		{
			PreloadInfo_TickerTimer -= DeltaTime;
		}
		if (VideoMemory_TickerTimer > 0f)
		{
			VideoMemory_TickerTimer -= DeltaTime;
		}
		SendCurrentFrameData();
	}

	public override void OnShutdown()
	{
		if (!DisabledInMono)
		{
			ShutdownCheatServer();
		}
	}

	private void InitCheatServer()
	{
		CheatData.Server = new NetServer();
		CheatData.Server.Init();
		CheatData.CurrentSendMonsterGuid = "";
		CheatData.bRefreshLevelPoints = true;
		CheatData.Server.SubscribePackage<FUploadPackage>(ParseUploadPackage);
		CheatData.DianaCommandList.Add(EDianaControlCommand.BeginPlay);
	}

	private void ShutdownCheatServer()
	{
		if (CheatData.Server != null)
		{
			CheatData.Server.Shutdown();
			CheatData.Server = null;
		}
	}

	private void SendCurrentFrameData()
	{
		if (!DisabledInMono && CheatData.Server != null)
		{
			if (CheatData.CanSendData() && ConstructData(out var Package))
			{
				CheatData.Server.SendData(Package);
			}
			CheatData.Server.Update();
		}
	}

	private bool ConstructData(out FDownloadPackage Package)
	{
		Package = new FDownloadPackage();
		Package.bMakeSurePackage = false;
		Package.ControlCommands = new int[CheatData.DianaCommandList.Count];
		for (int i = 0; i < CheatData.DianaCommandList.Count; i++)
		{
			EDianaControlCommand eDianaControlCommand = CheatData.DianaCommandList[i];
			Package.ControlCommands[i] = (int)eDianaControlCommand;
		}
		CheatData.DianaCommandList.Clear();
		APlayerController playerController = UGameplayStatics.GetPlayerController(base.Owner, 0);
		ABGUCharacter aBGUCharacter = playerController?.GetControlledPawn() as ABGUCharacter;
		if (playerController != null && aBGUCharacter != null)
		{
			Package.PlayerInfo = ConstructPlayerData(aBGUCharacter);
			((IBGC_TamerData)BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(aBGUCharacter)).GetSpawnedMonsterList(out List<string> OutMonsterList);
			OutMonsterList.Insert(0, BGU_DataUtil.GetActorGuid(aBGUCharacter));
			FDownloadInfo_TargetMonitorConfig targetMonitorConfig = default(FDownloadInfo_TargetMonitorConfig);
			int count = OutMonsterList.Count;
			if (count > 0)
			{
				List<BGUDebugTargetInfo> debugTargetInfos = BGU_DataUtil.GetGameStateReadonlyData<IBGC_DebugTargetMgrData, BGC_DebugTargetMgrData>(base.Owner).DebugTargetInfos;
				targetMonitorConfig.MonitorConfigs = new FNetStruct_UnitMonitorConfig[count];
				for (int j = 0; j < OutMonsterList.Count; j++)
				{
					string unitGuid = OutMonsterList[j];
					AActor MonsterCharacter = BGU_DataUtil.GetActorByGuid(base.Owner, unitGuid);
					if (!(MonsterCharacter != null))
					{
						continue;
					}
					int num = 0;
					if (debugTargetInfos.Find((BGUDebugTargetInfo Info) => Info.Self == MonsterCharacter) != null)
					{
						num = debugTargetInfos.Find((BGUDebugTargetInfo Info) => Info.Self == MonsterCharacter).Masks;
					}
					FNetStruct_UnitMonitorConfig fNetStruct_UnitMonitorConfig = targetMonitorConfig.MonitorConfigs[j];
					fNetStruct_UnitMonitorConfig.UnitGuid = unitGuid;
					fNetStruct_UnitMonitorConfig.bShowAITarget = (num & 1) != 0;
					fNetStruct_UnitMonitorConfig.bShowAOTarget = (num & 2) != 0;
					fNetStruct_UnitMonitorConfig.bShowSkillTarget = (num & 4) != 0;
					fNetStruct_UnitMonitorConfig.bShowComboTarget = (num & 8) != 0;
					fNetStruct_UnitMonitorConfig.bShowMoveToTarget = (num & 0x10) != 0;
					fNetStruct_UnitMonitorConfig.bShowHatredTarget = (num & 0x20) != 0;
					targetMonitorConfig.MonitorConfigs[j] = fNetStruct_UnitMonitorConfig;
				}
			}
			Package.TargetMonitorConfig = targetMonitorConfig;
			OutMonsterList[0] = "";
			ABGUCharacter aBGUCharacter2 = null;
			IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(aBGUCharacter);
			if (readOnlyData != null)
			{
				aBGUCharacter2 = readOnlyData.GetTargetInfo().LockTargetActor as ABGUCharacter;
				if (aBGUCharacter2 != null)
				{
					OutMonsterList[0] = BGU_DataUtil.GetActorGuid(aBGUCharacter2);
				}
			}
			Package.CurrentLockedMonsterInfo.Clean();
			if (string.IsNullOrEmpty(CheatData.CurrentSendMonsterGuid))
			{
				if (aBGUCharacter2 != null)
				{
					Package.CurrentLockedMonsterInfo = ConstructMonsterData(aBGUCharacter, aBGUCharacter2 as BGUCharacterCS);
				}
			}
			else
			{
				ABGUCharacter aBGUCharacter3 = BGU_DataUtil.GetActorByGuid(base.Owner, CheatData.CurrentSendMonsterGuid) as ABGUCharacter;
				if (aBGUCharacter3 != null)
				{
					Package.CurrentLockedMonsterInfo = ConstructMonsterData(aBGUCharacter, aBGUCharacter3 as BGUCharacterCS);
				}
			}
			Package.OtherMonsters = OutMonsterList.ToArray();
			IBUC_PlayerCameraData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_PlayerCameraData, BUC_PlayerCameraData>(aBGUCharacter);
			if (readOnlyData2 != null)
			{
				Package.CameraMonitorInfo = readOnlyData2.CameraMonitorData;
				Package.PlayerCameraInfo = readOnlyData2.PlayerCameraMonitorData;
				Package.DiagonalCameraInfo = readOnlyData2.DiagonalCameraMonitorData;
				Package.StraightCameraInfo = readOnlyData2.StraightCameraMonitorData;
				Package.GiantCameraInfo = readOnlyData2.GiantCameraMonitorData;
			}
			Package.RoleData = ConstructRoleData(playerController);
			Package.BattleInfo = ConstructBattleInfoData();
			Package.TamerManagerInfo = ConstructTamerData();
			ConstructAllActorDebugInfo(out var ActorDebugInfo, out var bMakeSurePackage);
			Package.ActorDebugInfo = ActorDebugInfo;
			if (bMakeSurePackage)
			{
				Package.bMakeSurePackage = true;
			}
			Package.RealTimeActorDebugInfo = ConstructRealTimeActorDebugInfo();
		}
		FDownloadInfo_AutoTestInfo autoTestInfo = default(FDownloadInfo_AutoTestInfo);
		BIS_AutoTestManagerV2 bIS_AutoTestManagerV = BIS_AutoTestManagerV2.Get(base.Owner);
		if (bIS_AutoTestManagerV != null && !bIS_AutoTestManagerV.IsIdleState())
		{
			List<ICSharpTestCase> testCasesToRun = BIS_AutoTestManagerV2.Get(base.Owner).TestCasesToRun;
			int count2 = testCasesToRun.Count;
			if (count2 > 0)
			{
				autoTestInfo.AutoTestTaskInfo = default(FNetStruct_AutoTestTaskInfo);
				autoTestInfo.AutoTestTaskInfo.CasesToRunInfo = new FNetStruct_AutoTestCaseInfo[count2];
				for (int num2 = 0; num2 < count2; num2++)
				{
					FNetStruct_AutoTestCaseInfo fNetStruct_AutoTestCaseInfo = new FNetStruct_AutoTestCaseInfo
					{
						CaseType = testCasesToRun[num2].GetCaseType().ToString(),
						CaseState = testCasesToRun[num2].GetCaseState().ToString()
					};
					if (testCasesToRun[num2] is b1.AutoQA.AutoTest_Template autoTest_Template)
					{
						fNetStruct_AutoTestCaseInfo.CaseName = autoTest_Template.GetName();
					}
					else if (testCasesToRun[num2] is b1.AutoQA.CrossLevel_AutoTest_Template crossLevel_AutoTest_Template)
					{
						fNetStruct_AutoTestCaseInfo.CaseName = crossLevel_AutoTest_Template.TestLabel;
					}
					autoTestInfo.AutoTestTaskInfo.CasesToRunInfo[num2] = fNetStruct_AutoTestCaseInfo;
				}
			}
		}
		if (CheatData.bRefreshLevelPoints)
		{
			CheatData.bRefreshLevelPoints = false;
			FDownloadInfo_LevelInfo levelInfo = default(FDownloadInfo_LevelInfo);
			List<FNetStruct_BirthPoint> list = new List<FNetStruct_BirthPoint>();
			BGURebirthPointBase[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGURebirthPointBase>(base.Owner);
			foreach (BGURebirthPointBase bGURebirthPointBase in allActorsOfClass)
			{
				FNetStruct_BirthPoint item = default(FNetStruct_BirthPoint);
				int rebirthPointID = bGURebirthPointBase.RebirthPointConfigComp.RebirthPointConfig.RebirthPointID;
				FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(rebirthPointID);
				FTransform fTransform = bGURebirthPointBase.GetActorTransform();
				if (rebirthPointDesc == null)
				{
					item.BirthPointName = $"{rebirthPointID}";
				}
				else
				{
					item.BirthPointName = $"{rebirthPointID} : {rebirthPointDesc.Name.ToFText()}";
					fTransform = UGSE_CharacterFuncLib.GetSceneComponentTransformByName(bGURebirthPointBase, rebirthPointDesc.SceneComponentName);
				}
				item.BirthPointType = "复活点";
				UnrealEngine.Runtime.FVector location = fTransform.GetLocation();
				UnrealEngine.Runtime.FRotator fRotator = fTransform.GetRotation().Rotator();
				item.BirthPointTransform = $"X={location.X},Y={location.Y},Z={location.Z} P={fRotator.Pitch},Y={fRotator.Yaw},R={fRotator.Roll}";
				list.Add(item);
			}
			b1.BUBirthPoint[] allActorsOfClass2 = UGameplayStatics.GetAllActorsOfClass<b1.BUBirthPoint>(base.Owner);
			foreach (b1.BUBirthPoint bUBirthPoint in allActorsOfClass2)
			{
				FNetStruct_BirthPoint item2 = new FNetStruct_BirthPoint
				{
					BirthPointName = $"{bUBirthPoint.BirthPointID}",
					BirthPointType = "出生点"
				};
				UnrealEngine.Runtime.FVector actorLocation = bUBirthPoint.GetActorLocation();
				UnrealEngine.Runtime.FRotator actorRotation = bUBirthPoint.GetActorRotation();
				item2.BirthPointTransform = $"X={actorLocation.X},Y={actorLocation.Y},Z={actorLocation.Z} P={actorRotation.Pitch},Y={actorRotation.Yaw},R={actorRotation.Roll}";
				list.Add(item2);
			}
			levelInfo.BirthPoints = list.ToArray();
			List<FNetStruct_SubLevelInfo> list2 = new List<FNetStruct_SubLevelInfo>();
			UBGUWCStreamingFuncLib.GetAllLevelCurrentState(base.Owner, out var OutLevelStreamingList, bIgnoreWCTile: false);
			foreach (KeyValuePair<string, byte> item4 in OutLevelStreamingList)
			{
				FNetStruct_SubLevelInfo item3 = new FNetStruct_SubLevelInfo
				{
					Name = item4.Key,
					CurrentStateInt = item4.Value,
					CurrentState = ((BGW_LevelStreamingManger.GSLevelCurrentState)item4.Value/*cast due to .constrained prefix*/).ToString()
				};
				list2.Add(item3);
			}
			levelInfo.SubLevelInfos = list2.ToArray();
			CheatData.LevelInfo = levelInfo;
			int count3 = TestSuiteDef.TestSuiteDict.Count;
			if (count3 > 0)
			{
				autoTestInfo.TestSuiteList = new FNetStruct_AutoTestSuiteInfo[count3];
				int num4 = 0;
				foreach (KeyValuePair<string, List<string>> item5 in TestSuiteDef.TestSuiteDict)
				{
					string key = item5.Key;
					List<string> value = item5.Value;
					int count4 = value.Count;
					FNetStruct_AutoTestSuiteInfo fNetStruct_AutoTestSuiteInfo = new FNetStruct_AutoTestSuiteInfo
					{
						SuiteName = key,
						Cases = new FNetStruct_AutoTestCaseInfo[count4]
					};
					for (int num5 = 0; num5 < count4; num5++)
					{
						FNetStruct_AutoTestCaseInfo fNetStruct_AutoTestCaseInfo2 = new FNetStruct_AutoTestCaseInfo
						{
							CaseName = value[num5]
						};
						fNetStruct_AutoTestSuiteInfo.Cases[num5] = fNetStruct_AutoTestCaseInfo2;
					}
					autoTestInfo.TestSuiteList[num4] = fNetStruct_AutoTestSuiteInfo;
					num4++;
				}
			}
			List<ICSharpTestCase> testCaseList = bIS_AutoTestManagerV.TestCaseList;
			int count5 = testCaseList.Count;
			if (count5 > 0)
			{
				autoTestInfo.TestCaseList = new FNetStruct_AutoTestCaseInfo[count5];
				for (int num6 = 0; num6 < count5; num6++)
				{
					FNetStruct_AutoTestCaseInfo fNetStruct_AutoTestCaseInfo3 = default(FNetStruct_AutoTestCaseInfo);
					if (testCaseList[num6] is b1.AutoQA.AutoTest_Template autoTest_Template2)
					{
						fNetStruct_AutoTestCaseInfo3.CaseName = autoTest_Template2.GetName();
					}
					else if (testCaseList[num6] is b1.AutoQA.CrossLevel_AutoTest_Template crossLevel_AutoTest_Template2)
					{
						fNetStruct_AutoTestCaseInfo3.CaseName = crossLevel_AutoTest_Template2.TestLabel;
					}
					autoTestInfo.TestCaseList[num6] = fNetStruct_AutoTestCaseInfo3;
				}
			}
		}
		Package.AutoTestInfo = autoTestInfo;
		Package.LevelInfo = CheatData.LevelInfo;
		Package.GameData = ConstructGameData();
		bool needUpdatePreloadInfo = false;
		bool needUpdateMemoryInfo = false;
		if (PreloadInfo_TickerTimer <= 0f)
		{
			needUpdatePreloadInfo = true;
			PreloadInfo_TickerTimer = 1f;
		}
		if (VideoMemory_TickerTimer <= 0f)
		{
			needUpdateMemoryInfo = true;
			VideoMemory_TickerTimer = 1f;
		}
		Package.PreloadInfo = ConstructPreloadInfo(needUpdatePreloadInfo, needUpdateMemoryInfo);
		Package.LightInfo = ConstructLightData();
		Package.CurPigsyStoryInfo = ConstructPigstStoryInfoData(aBGUCharacter);
		Package.BossRushInfo = ConstructBossRushInfoData(aBGUCharacter);
		return true;
	}

	private void UpdateLightCategoryData(ref FCLSCategoryWatchData CppData, ref FNetStruct_LightInfoWithCategory CsData)
	{
		CsData.OriginData = CppData.OriginData;
		CsData.CurrentData = CppData.CurrentData;
		CsData.TargetData = CppData.TargetData;
		CsData.SpeedAlpha = CppData.SpeedAlpha;
		CsData.bOriginUseCustomBlendOutSpeed = CppData.OriginUseCustomBlendOutSpeed;
		CsData.OriginCustomBlendOutSpeedAlpha = CppData.OriginCustomBlendOutSpeedAlpha;
		CsData.bTargetUseCustomBlendOutSpeed = CppData.TargetUseCustomBlendOutSpeed;
		CsData.TargetCustomBlendOutSpeedAlpha = CppData.TargetCustomBlendOutSpeedAlpha;
		CsData.CurrentAlpha = CppData.CurrentAlpha;
		CsData.TargetAlpha = CppData.TargetAlpha;
		CsData.CurrentPercentage = CppData.CurrentPercentage;
	}

	private void UpdatePointLightData(ref FCLSPlayerLightDataBase CppData, ref FNetStruct_PointLightInfo CsData)
	{
		CsData.Intensity = CppData.Intensity;
		CsData.Color = (int)CppData.Color.ToPackedRGBA();
		CsData.Radius = CppData.Radius;
		CsData.AttenuationRadius = CppData.AttenuationRadius;
		CsData.bCastShadows = CppData.CastShadows;
		CsData.CastShadowMapShadow = CppData.CastShadowMapShadow;
		CsData.ContactShadowLength = CppData.ContactShadowLength;
		CsData.bUseTemperature = CppData.UseTemperature;
		CsData.Temperature = CppData.Temperature;
		CsData.VolumetricScatteringIntensity = CppData.VolumetricScatteringIntensity;
		CsData.SpecularScale = CppData.SpecularScale;
	}

	private void UpdatePlayerLightData(ref FCLSPlayerLightWatchData CppData, ref FNetStruct_CharacterLightInfo CsData)
	{
		UpdatePointLightData(ref CppData.FrontLightData, ref CsData.FrontLight);
		UpdatePointLightData(ref CppData.BackLightData, ref CsData.BackLight);
		CsData.OriginData = CppData.OriginData;
		CsData.CurrentData = CppData.CurrentData;
		CsData.TargetData = CppData.TargetData;
		CsData.SpeedAlpha = CppData.SpeedAlpha;
		CsData.bOriginUseCustomBlendOutSpeed = CppData.OriginUseCustomBlendOutSpeed;
		CsData.OriginCustomBlendOutSpeedAlpha = CppData.OriginCustomBlendOutSpeedAlpha;
		CsData.bTargetUseCustomBlendOutSpeed = CppData.TargetUseCustomBlendOutSpeed;
		CsData.TargetCustomBlendOutSpeedAlpha = CppData.TargetCustomBlendOutSpeedAlpha;
		CsData.CurrentAlpha = CppData.CurrentAlpha;
		CsData.TargetAlpha = CppData.TargetAlpha;
		CsData.CurrentPercentage = CppData.CurrentPercentage;
	}

	private FDownloadInfo_LightInfo ConstructLightData()
	{
		FDownloadInfo_LightInfo result = default(FDownloadInfo_LightInfo);
		ACLSManager currentCLSManager = UCLSFunctionLibrary.GetCurrentCLSManager();
		if (currentCLSManager != null)
		{
			FCLSWatchData fCLSWatchData = currentCLSManager.UpdateAndGetWatchData();
			UpdateLightCategoryData(ref fCLSWatchData.DirectionalLightData, ref result.DirectionalLightData);
			UpdateLightCategoryData(ref fCLSWatchData.SkyLightData, ref result.SkyLightData);
			UpdateLightCategoryData(ref fCLSWatchData.AtmosphereData, ref result.AtmosphereData);
			UpdateLightCategoryData(ref fCLSWatchData.HeightFogData, ref result.HeightFogData);
			UpdateLightCategoryData(ref fCLSWatchData.CustomVariableData, ref result.CustomVariableData);
			UpdateLightCategoryData(ref fCLSWatchData.OtherData, ref result.OtherData);
			UpdatePlayerLightData(ref fCLSWatchData.PlayerLightData, ref result.PlayerLightData);
			List<FNetStruct_LightVolumeInfo> list = new List<FNetStruct_LightVolumeInfo>();
			foreach (FCLSVolumeWatchData volumeDatum in fCLSWatchData.VolumeData)
			{
				if (volumeDatum.Valid)
				{
					FNetStruct_LightVolumeInfo item = new FNetStruct_LightVolumeInfo
					{
						VolumeName = volumeDatum.Name,
						VolumeLevel = volumeDatum.Level,
						VolumeDynamicLevel = volumeDatum.DynamicLevel,
						bInVolume = volumeDatum.InVolume,
						DistanceToPoint = volumeDatum.DistanceToPoint
					};
					list.Add(item);
				}
			}
			result.VolumeInfos = list.ToArray();
		}
		return result;
	}

	private FDownloadInfo_Player ConstructPlayerData(ABGUCharacter PlayerCharacter)
	{
		FDownloadInfo_Player result = new FDownloadInfo_Player
		{
			bShowDebugWidget = (((IBUC_DebugInfoData)BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_DebugInfoData>(PlayerCharacter))?.IsDebugWidgetShown() ?? false),
			PlayerProperties = 
			{
				MaxHP = BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.HpMax),
				MaxMP = BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.MpMax),
				Atk = BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.Atk),
				MaxStamina = BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.StaminaMax),
				BloodBottle = BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.BloodBottomNumMax),
				PE = BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.Pevalue),
				TransEnergy = BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.TransEnergyMax)
			}
		};
		FPlayerStateParamCollection playerDetails = CheatData.PlayerDetails;
		playerDetails.OverrideLevelNumericalStrength = ((B1Global.GOverrideLevelNumericalStrength > 0) ? $"{B1Global.GOverrideLevelNumericalStrength}" : "未覆盖");
		IBUC_BeAttackData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>(PlayerCharacter);
		playerDetails.BeAttackInfoID = $"{readOnlyData.GetCurrentBeAttackedInfoID()}";
		IBUC_PlayerSpellConfData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_PlayerSpellConfData, BUC_PlayerSpellConfData>(PlayerCharacter);
		StringBuilder stringBuilder = new StringBuilder();
		int num = Math.Min(readOnlyData2.MagicConfInfo.Count, 4);
		for (int i = 0; i < num; i++)
		{
			FUStMagicConfInfo fUStMagicConfInfo = readOnlyData2.MagicConfInfo[i];
			stringBuilder.Append($"{fUStMagicConfInfo.Type}:{fUStMagicConfInfo.SpellID}  ");
		}
		playerDetails.CurrentSpells = stringBuilder.ToString();
		playerDetails.HP = $"{BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.Hp)} / {BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.HpMax)}";
		IBUC_StaminaData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_StaminaData>(PlayerCharacter);
		if (unPersistentReadOnlyData != null)
		{
			playerDetails.Stamina = $"{BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.Stamina)} / {BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.StaminaMax)} ({unPersistentReadOnlyData.GetStaminaRecoverFinal()}/s)";
		}
		playerDetails.TransEnergy = $"{BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.CurEnergy)} / {BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.TransEnergyMax)}";
		playerDetails.FaBaoEnergy = $"{BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.FabaoEnergy)} / {BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.FabaoEnergyMax)}";
		playerDetails.VigorEnergy = $"{BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.VigorEnergy)} / {BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.VigorEnergyMax)}";
		IBUC_PhantomRushData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_PhantomRushData, BUC_PhantomRushData>(PlayerCharacter);
		if (readOnlyData3 != null)
		{
			playerDetails.PhantomRushImperceptibleState = (readOnlyData3.Imperceptible ? "聚形散气隐身中" : "无");
		}
		IBUC_QiTianDaShengData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<IBUC_QiTianDaShengData, BUC_QiTianDaShengData>(PlayerCharacter);
		if (readOnlyData3 != null)
		{
			string text = "";
			switch (readOnlyData4.DaShengStage)
			{
			case EDaShengStage.LittleMonkey:
				text = "小猴子";
				break;
			case EDaShengStage.PreStage:
				text = "预备大圣";
				break;
			case EDaShengStage.DaShengMode:
				text = "大圣";
				if (readOnlyData4.DaShengDurationTimer > 0f)
				{
					text += $"（持续时间：{readOnlyData4.DaShengDurationTimer:F2} / {readOnlyData4.DaShengDurationTotalTime}秒）";
				}
				break;
			}
			if (readOnlyData4.bIsBanTrans2DaSheng)
			{
				text += "（被Ban，需要重置or复活才能恢复）";
			}
			else if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(PlayerCharacter, EBGUSimpleState.BanTrans2DaSheng))
			{
				text += "（被Ban，移除对应SimpleState可恢复）";
			}
			playerDetails.DaShengStage = text;
		}
		IBUC_ABPMotionMatchingData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPMotionMatchingData>(PlayerCharacter);
		if (unPersistentReadOnlyData2 != null)
		{
			playerDetails.MMState = unPersistentReadOnlyData2.MotionMatchingState.ToString();
		}
		string text2 = (BGUFunctionLibraryCS.BGUHasUnitSimpleState(PlayerCharacter, EBGUSimpleState.SkillSuperArmor) ? "激活" : "未激活");
		string text3 = BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.SkillSuperArmor).ToString();
		string text4 = BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.SkillSuperArmorMax).ToString();
		playerDetails.SkillSuperArmor = "(" + text2 + ")" + text3 + " / " + text4;
		BUC_MovementModes unPersistentReadOnlyData3 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MovementModes>(PlayerCharacter);
		if (unPersistentReadOnlyData3 != null)
		{
			BUC_MoveModeBase activeMover = unPersistentReadOnlyData3.ActiveMover;
			if (activeMover != null)
			{
				string[] array = activeMover.ToString().Split('_');
				playerDetails.MoveMode = array[1];
			}
			else
			{
				playerDetails.MoveMode = "No ActiveMover";
			}
		}
		playerDetails.MovementMode = PlayerCharacter.CharacterMovement.MovementMode.ToString("G");
		IBUC_BattleStateData unPersistentReadOnlyData4 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BattleStateData>(PlayerCharacter);
		if (unPersistentReadOnlyData4 != null)
		{
			if (unPersistentReadOnlyData4.IsUnitInBattle())
			{
				playerDetails.BattleState = "战斗中";
			}
			else
			{
				playerDetails.BattleState = "Not In Battle";
			}
		}
		playerDetails.BlindSlot = $"{BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.BlindSlot)} / {BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.BlindSlotMax)}";
		BUC_LifeSavingData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<BUC_LifeSavingData>(PlayerCharacter);
		if (readOnlyData5 != null)
		{
			playerDetails.HairCD = readOnlyData5.CoolDownRemainTimer.ToString();
		}
		IBUC_PlayerCameraData unPersistentReadOnlyData5 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerCameraData, BUC_PlayerCameraData>(PlayerCharacter);
		if (unPersistentReadOnlyData5 != null)
		{
			playerDetails.CameraGroupID = $"{unPersistentReadOnlyData5.GetCurrentCameraGroupID()}";
			playerDetails.CameraID = $"{unPersistentReadOnlyData5.GetCurrentFreeCameraID()}/{unPersistentReadOnlyData5.GetCurrentLockCameraID()}";
		}
		IBPC_PlayerPerformData playerStateReadonlyData = BGU_DataUtil.GetPlayerStateReadonlyData<IBPC_PlayerPerformData, BPC_PlayerPerformData>(PlayerCharacter.GetController() as APlayerController);
		if (playerStateReadonlyData != null)
		{
			playerDetails.WeakPerform = playerStateReadonlyData.GetWeakPerformDebugString();
		}
		BUC_AbnormalStateHandlers unPersistentReadOnlyData6 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AbnormalStateHandlers>(PlayerCharacter);
		if (unPersistentReadOnlyData6 != null)
		{
			playerDetails.IceAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.FreezeAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.FreezeAbnormalAccMax), unPersistentReadOnlyData6.AbnormalHanddler_Freeze.IsInFinalEffect() ? " 冰冻" : "");
			playerDetails.FireAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.BurnAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.BurnAbnormalAccMax), unPersistentReadOnlyData6.AbnormalHanddler_Burn.IsInFinalEffect() ? " 炎上" : "");
			playerDetails.PoisonAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.PoisonAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.PoisonAbnormalAccMax), unPersistentReadOnlyData6.AbnormalHanddler_Poison.IsInFinalEffect() ? " 中毒" : "");
			playerDetails.ThunderAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.ThunderAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.ThunderAbnormalAccMax), unPersistentReadOnlyData6.AbnormalHanddler_Thunder.IsInFinalEffect() ? " 麻痹" : "");
			playerDetails.YinAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.YinAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.YinAbnormalAccMax), unPersistentReadOnlyData6.AbnormalHanddler_Yin.IsInFinalEffect() ? " 阴状态" : "");
			playerDetails.YangAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.YangAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.YangAbnormalAccMax), unPersistentReadOnlyData6.AbnormalHanddler_Yang.IsInFinalEffect() ? " 阳状态" : "");
			playerDetails.Ice = string.Format("Def:{0}  Atk:{1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.FreezeDef), BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.FreezeAtk), BGUFunctionLibraryCS.BGUHasUnitSimpleState(PlayerCharacter, EBGUSimpleState.FreezeImmue) ? "  | 冰冻免疫" : "");
			playerDetails.Fire = string.Format("Def:{0}  Atk:{1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.BurnDef), BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.BurnAtk), BGUFunctionLibraryCS.BGUHasUnitSimpleState(PlayerCharacter, EBGUSimpleState.BurnImmue) ? "  | 灼烧免疫" : "");
			playerDetails.Poison = string.Format("Def:{0}  Atk:{1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.PoisonDef), BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.PoisonAtk), BGUFunctionLibraryCS.BGUHasUnitSimpleState(PlayerCharacter, EBGUSimpleState.PoisonImmue) ? "  | 中毒免疫" : "");
			playerDetails.Thunder = string.Format("Def:{0}  Atk:{1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.ThunderDef), BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.ThunderAtk), BGUFunctionLibraryCS.BGUHasUnitSimpleState(PlayerCharacter, EBGUSimpleState.ThunderImmue) ? "  | 易伤免疫" : "");
		}
		BUC_PotentialEnergyData unPersistentReadOnlyData7 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PotentialEnergyData>(PlayerCharacter);
		if (unPersistentReadOnlyData7 != null)
		{
			playerDetails.StickPotential = $"{BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.Pevalue)} / {BGUFunctionLibraryCS.BGUGetFloatAttr(PlayerCharacter, EBGUAttrFloat.PevalueMax)}  保护时间：{$"{FMath.Max(unPersistentReadOnlyData7.ProtectTime, unPersistentReadOnlyData7.DecreaseProtecTimer):F2}"}s  {BGUFunctionLibraryCS.BGUGetCurPELevel(PlayerCharacter)}级";
		}
		BUC_ChargeSkillData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<BUC_ChargeSkillData>(PlayerCharacter);
		if (readOnlyData6 != null)
		{
			playerDetails.ChargeLevel = $"Level {readOnlyData6.CurChargeLevel}  {$"{readOnlyData6.IntoNextCLevelRemaining:F2}"}s";
			playerDetails.Charging = $" {readOnlyData6.ChargeSkillStage}  {$"{readOnlyData6.ChargeTimer:F2}"}s   {readOnlyData6.NeedTriggerNextStage}";
		}
		IBUC_EnvironmentInteractionMgrData readOnlyData7 = BGU_DataUtil.GetReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>(PlayerCharacter);
		if (readOnlyData7 != null)
		{
			playerDetails.SurfaceType = readOnlyData7.ResultSurfaceType.ToString();
		}
		IBUC_SkillInstsData readOnlyData8 = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(PlayerCharacter);
		if (readOnlyData8 != null)
		{
			playerDetails.CurrentSkillID = readOnlyData8.CurrentCastingSkillID.ToString();
		}
		IBUC_FallingData readOnlyData9 = BGU_DataUtil.GetReadOnlyData<IBUC_FallingData, BUC_FallingData>(PlayerCharacter);
		if (readOnlyData9 != null)
		{
			playerDetails.HeightAboveFloor = readOnlyData9.FloorDistance.ToString();
		}
		UAnimInstance animInstance = PlayerCharacter.Mesh.GetAnimInstance();
		if (animInstance != null && animInstance.GetCurrentActiveMontage() != null)
		{
			playerDetails.CurrentPlayingMontage = animInstance.GetCurrentActiveMontage().GetName();
		}
		else
		{
			playerDetails.CurrentPlayingMontage = "None";
		}
		IBUC_StateLibData readOnlyData10 = BGU_DataUtil.GetReadOnlyData<IBUC_StateLibData, BUC_StateLibData>(PlayerCharacter);
		playerDetails.CurrentStateLibBase = readOnlyData10.StateLibBaseDebugString;
		playerDetails.CurrentStateLibMod = readOnlyData10.StateLibModDebugString;
		result.Details = new string[39];
		Array.Copy(playerDetails.AllParams, result.Details, 39);
		BUC_SimpleStateData readOnlyData11 = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(PlayerCharacter);
		List<FNetStruct_SimpleState> list = new List<FNetStruct_SimpleState>();
		FNetStruct_SimpleState item = default(FNetStruct_SimpleState);
		for (int j = 0; j < 174; j++)
		{
			if (readOnlyData11.SimpleStates[j] != 0)
			{
				item.StateName = ((EBGUSimpleState)j/*cast due to .constrained prefix*/).ToString();
				item.Layer = readOnlyData11.SimpleStates[j];
				list.Add(item);
			}
		}
		result.SimpleStates = list.ToArray();
		BUC_UnitStateData readOnlyData12 = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(PlayerCharacter);
		List<FNetStruct_UnitState> list2 = new List<FNetStruct_UnitState>();
		FNetStruct_UnitState item2 = default(FNetStruct_UnitState);
		for (int k = 0; k < 45; k++)
		{
			if (readOnlyData12.UnitStates.GetValue(k) != 0f)
			{
				item2.StateName = ((EBGUUnitState)k/*cast due to .constrained prefix*/).ToString();
				item2.Time = readOnlyData12.UnitStates.GetValue(k);
				list2.Add(item2);
			}
		}
		result.UnitStates = list2.ToArray();
		BUC_BuffData readOnlyData13 = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(PlayerCharacter);
		List<FNetStruct_Buff> list3 = new List<FNetStruct_Buff>();
		FNetStruct_Buff item3 = default(FNetStruct_Buff);
		foreach (BuffInstData allBuffInstDatum in readOnlyData13.GetAllBuffInstData())
		{
			item3.ID = allBuffInstDatum.BuffID;
			item3.Layer = allBuffInstDatum.Layer;
			item3.Time = allBuffInstDatum.LeftTime;
			item3.SourceType = allBuffInstDatum.BuffSourceType.ToString("G");
			item3.Tips = "无";
			FUStBuffDesc originalBuffDesc = BGW_GameDB.GetOriginalBuffDesc(allBuffInstDatum.BuffID);
			if (originalBuffDesc != null)
			{
				item3.Tips = originalBuffDesc.BuffTips;
			}
			list3.Add(item3);
		}
		result.Buffs = list3.ToArray();
		BUC_TalentData unPersistentReadOnlyData8 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_TalentData>(PlayerCharacter);
		int actorResID = BGU_DataUtil.GetActorResID(PlayerCharacter);
		List<FNetStruct_TalentInfo> list4 = new List<FNetStruct_TalentInfo>();
		foreach (KeyValuePair<int, int> item6 in unPersistentReadOnlyData8.ActivatingTalentDic)
		{
			int key = item6.Key;
			FNetStruct_TalentInfo item4 = new FNetStruct_TalentInfo
			{
				TalentID = key,
				TalentLevel = item6.Value
			};
			TalentSDesc talentSDescByUnitResIDInMapCache = GameDBRuntime.GetTalentSDescByUnitResIDInMapCache(key, actorResID);
			if (talentSDescByUnitResIDInMapCache != null)
			{
				item4.TalentName = talentSDescByUnitResIDInMapCache.Name.ToFText().ToString();
				item4.TalentType = talentSDescByUnitResIDInMapCache.Type.ToString("G");
				item4.TalentGroup = talentSDescByUnitResIDInMapCache.TalentGroupId;
			}
			list4.Add(item4);
		}
		result.Talents = list4.ToArray();
		BUC_PassiveSkillData unPersistentReadOnlyData9 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PassiveSkillData>(PlayerCharacter);
		using (FPassiveSkillInfoConstructor fPassiveSkillInfoConstructor = new FPassiveSkillInfoConstructor())
		{
			fPassiveSkillInfoConstructor.TableName = "Skill";
			foreach (KeyValuePair<int, FUStSkillSDesc> cachedSkillSDesc in unPersistentReadOnlyData9.CachedSkillSDescs)
			{
				FUStSkillSDesc value = cachedSkillSDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cachedSkillSDesc.Key;
				FUStSkillSDesc originalSkillSDesc = BGW_GameDB.GetOriginalSkillSDesc(fPassiveSkillInfoConstructor.TableID);
				if (value != null && originalSkillSDesc != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("CooldownTime", value.CooldownTime, originalSkillSDesc.CooldownTime);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("MinAttrCostBase1", value.MinAttrCostBase1, originalSkillSDesc.MinAttrCostBase1);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("MinAttrCostBase2", value.MinAttrCostBase2, originalSkillSDesc.MinAttrCostBase2);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("MinAttrCostRatio1", value.MinAttrCostRatio1, originalSkillSDesc.MinAttrCostRatio1);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("MinAttrCostRatio2", value.MinAttrCostRatio2, originalSkillSDesc.MinAttrCostRatio2);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "SkillEffect";
			foreach (KeyValuePair<int, FUStSkillEffectDesc> cachedSkillEffectDesc in unPersistentReadOnlyData9.CachedSkillEffectDescs)
			{
				FUStSkillEffectDesc value2 = cachedSkillEffectDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cachedSkillEffectDesc.Key;
				FUStSkillEffectDesc originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(fPassiveSkillInfoConstructor.TableID);
				if (value2 != null && originalSkillEffectDesc != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("EffectParamsFloat", value2.EffectParamsFloat, originalSkillEffectDesc.EffectParamsFloat);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("EffectParamsInt", value2.EffectParamsInt, originalSkillEffectDesc.EffectParamsInt);
					if (value2.Range != null && value2.Range.RangeParam != null && value2.Range.RangeParam.Count > 0)
					{
						fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("Range", value2.Range.RangeParam[0], originalSkillEffectDesc.Range.RangeParam[0]);
					}
				}
			}
			fPassiveSkillInfoConstructor.TableName = "Buff";
			foreach (KeyValuePair<int, Dictionary<string, float>> cachedBuffModifyDatum in unPersistentReadOnlyData9.CachedBuffModifyData)
			{
				fPassiveSkillInfoConstructor.TableID = cachedBuffModifyDatum.Key;
				FUStBuffDesc originalBuffDesc2 = BGW_GameDB.GetOriginalBuffDesc(fPassiveSkillInfoConstructor.TableID);
				BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(fPassiveSkillInfoConstructor.TableID, cachedBuffModifyDatum.Value);
				if (buffDescRuntime == null || originalBuffDesc2 == null)
				{
					continue;
				}
				int count = originalBuffDesc2.BuffEffects.Count;
				for (int l = 0; l < count; l++)
				{
					int num2 = 0;
					num2 = buffDescRuntime.GetFloatEffectParamCount(l);
					for (int m = 0; m < num2; m++)
					{
						fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"Effect[{l}]ParamsFloat[{m}]", buffDescRuntime.GetFloatEffectParam(l, m), originalBuffDesc2.BuffEffects[l].EffectParamsFloat[m]);
					}
					num2 = buffDescRuntime.GetIntEffectParamCount(l);
					for (int n = 0; n < num2; n++)
					{
						fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"Effect[{l}]ParamsInt[{n}]", buffDescRuntime.GetIntEffectParam(l, n), originalBuffDesc2.BuffEffects[l].EffectParams[n]);
					}
				}
				fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("Duration", buffDescRuntime.GetDuration(), originalBuffDesc2.Duration);
				fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("Interval", buffDescRuntime.GetInterval(), originalBuffDesc2.Interval);
				fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("MaxLayer", buffDescRuntime.GetMaxLayer(), originalBuffDesc2.MaxLayer);
				fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("TargetCount", buffDescRuntime.GetTargetCount(), originalBuffDesc2.TargetCount);
				if (originalBuffDesc2.Range != null && originalBuffDesc2.Range.RangeParam != null && originalBuffDesc2.Range.RangeParam.Count > 0)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("Range", buffDescRuntime.GetRangeParam(0), originalBuffDesc2.Range.RangeParam[0]);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "PlayerSkillCtrl";
			foreach (KeyValuePair<int, FUStPlayerSkillCtrlDesc> cachedPlayerSkillCtrlDesc in unPersistentReadOnlyData9.CachedPlayerSkillCtrlDescs)
			{
				FUStPlayerSkillCtrlDesc value3 = cachedPlayerSkillCtrlDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cachedPlayerSkillCtrlDesc.Key;
				FUStPlayerSkillCtrlDesc originalPlayerSkillCtrlDesc = BGW_GameDB.GetOriginalPlayerSkillCtrlDesc(fPassiveSkillInfoConstructor.TableID);
				if (value3 != null && originalPlayerSkillCtrlDesc != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("AttackRange", value3.AttackRange, originalPlayerSkillCtrlDesc.AttackRange);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "蓄力技";
			foreach (KeyValuePair<int, FUStChargeSkillSDesc> cachedChargeSkillSDesc in unPersistentReadOnlyData9.CachedChargeSkillSDescs)
			{
				FUStChargeSkillSDesc value4 = cachedChargeSkillSDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cachedChargeSkillSDesc.Key;
				FUStChargeSkillSDesc originalChargeSkillSDesc = BGW_GameDB.GetOriginalChargeSkillSDesc(fPassiveSkillInfoConstructor.TableID);
				if (value4 != null && originalChargeSkillSDesc != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("ChargeMoveSpeedRate", value4.ChargeMoveSpeedRate, originalChargeSkillSDesc.ChargeMoveSpeedRate);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("MaxChargeTime", value4.MaxChargeTime, originalChargeSkillSDesc.MaxChargeTime);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("ChargeLevelConfigIndex", value4.ChargeLevelConfigIndex, originalChargeSkillSDesc.ChargeLevelConfigIndex);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "RollSkill";
			foreach (KeyValuePair<int, FUStRollSkillDesc> cachedRollDesc in unPersistentReadOnlyData9.CachedRollDescs)
			{
				FUStRollSkillDesc value5 = cachedRollDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cachedRollDesc.Key;
				FUStRollSkillDesc originalRollSkillDesc = BGW_GameDB.GetOriginalRollSkillDesc(fPassiveSkillInfoConstructor.TableID);
				if (value5 != null && originalRollSkillDesc != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("EnableSkill", value5.EnableSkill, originalRollSkillDesc.EnableSkill);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "召唤";
			foreach (KeyValuePair<int, FUStSummonCommDesc> cachedSummonCommDesc in unPersistentReadOnlyData9.CachedSummonCommDescs)
			{
				FUStSummonCommDesc value6 = cachedSummonCommDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cachedSummonCommDesc.Key;
				FUStSummonCommDesc originalSummonCommDesc = BGW_GameDB.GetOriginalSummonCommDesc(fPassiveSkillInfoConstructor.TableID);
				if (value6 != null && originalSummonCommDesc != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("SummonAliveTime", value6.SummonAliveTime, originalSummonCommDesc.SummonAliveTime);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("BuffList", value6.BuffList, originalSummonCommDesc.BuffList);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "PlayerCommSkill";
			foreach (KeyValuePair<int, FUStPlayerInputSkillMappingDesc> cachedPlayerCommSkillDesc in unPersistentReadOnlyData9.CachedPlayerCommSkillDescs)
			{
				FUStPlayerInputSkillMappingDesc value7 = cachedPlayerCommSkillDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cachedPlayerCommSkillDesc.Key;
				FUStPlayerInputSkillMappingDesc originalPlayerInputSkillMappingDesc = BGW_GameDB.GetOriginalPlayerInputSkillMappingDesc(fPassiveSkillInfoConstructor.TableID);
				if (value7 != null && originalPlayerInputSkillMappingDesc != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("DodgeStartSkillID", value7.DodgeStartSkillID, originalPlayerInputSkillMappingDesc.DodgeStartSkillID);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("PreciseDodgeStartSkillID", value7.PreciseDodgeStartSkillID, originalPlayerInputSkillMappingDesc.PreciseDodgeStartSkillID);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "SkillDamage";
			foreach (KeyValuePair<int, FUStSkillDamageExpandDesc> cachedSkillDamageExpandDesc in unPersistentReadOnlyData9.CachedSkillDamageExpandDescs)
			{
				FUStSkillDamageExpandDesc value8 = cachedSkillDamageExpandDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cachedSkillDamageExpandDesc.Key;
				FUStSkillDamageExpandDesc originalSkillDamageExpandDesc = BGW_GameDB.GetOriginalSkillDamageExpandDesc(fPassiveSkillInfoConstructor.TableID);
				if (value8 != null && originalSkillDamageExpandDesc != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("CanTriggerFX", value8.CanTriggerFX, originalSkillDamageExpandDesc.CanTriggerFX);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("CanTriggerFightBackCounter", value8.CanTriggerFightBackCounter, originalSkillDamageExpandDesc.CanTriggerFightBackCounter);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("DamageReason", value8.DamageReason, originalSkillDamageExpandDesc.DamageReason);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("CritRateAddition", value8.CritRateAddition, originalSkillDamageExpandDesc.CritRateAddition);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("CritDmgAddition", value8.CritDmgAddition, originalSkillDamageExpandDesc.CritDmgAddition);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("IgnoreBeAttacked", value8.IgnoreBeAttacked, originalSkillDamageExpandDesc.IgnoreBeAttacked);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("AddTargetCurHpRatio", value8.AddTargetCurHpRatio, originalSkillDamageExpandDesc.AddTargetCurHpRatio);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("ImmobilizeHit", value8.ImmobilizeHit, originalSkillDamageExpandDesc.ImmobilizeHit);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("PartDamage", value8.PartDamage, originalSkillDamageExpandDesc.PartDamage);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("PevalueIncrements", value8.PevalueIncrements, originalSkillDamageExpandDesc.PevalueIncrements);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("TransIncrements", value8.TransIncrements, originalSkillDamageExpandDesc.TransIncrements);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "PartRule";
			foreach (KeyValuePair<int, FUStPartRuleInfoDesc> cachedPartRuleInfoDesc in unPersistentReadOnlyData9.CachedPartRuleInfoDescs)
			{
				FUStPartRuleInfoDesc value9 = cachedPartRuleInfoDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cachedPartRuleInfoDesc.Key;
				FUStPartRuleInfoDesc originalPartRuleInfoDesc = BGW_GameDB.GetOriginalPartRuleInfoDesc(fPassiveSkillInfoConstructor.TableID);
				if (value9 != null && originalPartRuleInfoDesc != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("ReduceParams", value9.ReduceParams, originalPartRuleInfoDesc.ReduceParams);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "Projectile";
			foreach (KeyValuePair<int, FUStProjectileCommDesc> cachedProjectileCommDesc in unPersistentReadOnlyData9.CachedProjectileCommDescs)
			{
				FUStProjectileCommDesc value10 = cachedProjectileCommDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cachedProjectileCommDesc.Key;
				FUStProjectileCommDesc originalProjectileCommDesc = BGW_GameDB.GetOriginalProjectileCommDesc(fPassiveSkillInfoConstructor.TableID);
				if (value10 != null && originalProjectileCommDesc != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("ProjectileLifeTime", value10.ProjectileLifeTime, originalProjectileCommDesc.ProjectileLifeTime);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "AttrCopy";
			foreach (KeyValuePair<int, FUStAttrCopyConfigDesc> cacheAttrCopyConfigDesc in unPersistentReadOnlyData9.CacheAttrCopyConfigDescs)
			{
				FUStAttrCopyConfigDesc value11 = cacheAttrCopyConfigDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cacheAttrCopyConfigDesc.Key;
				FUStAttrCopyConfigDesc originalAttrCopyDesc = BGW_GameDB.GetOriginalAttrCopyDesc(fPassiveSkillInfoConstructor.TableID);
				if (value11 != null && originalAttrCopyDesc != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("HPBase", value11.HPBase, originalAttrCopyDesc.HPBase);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("HPRatio", value11.HPRatio, originalAttrCopyDesc.HPRatio);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("MPBase", value11.MPBase, originalAttrCopyDesc.MPBase);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("MPRatio", value11.MPRatio, originalAttrCopyDesc.MPRatio);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("AtkBase", value11.AtkBase, originalAttrCopyDesc.AtkBase);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("AtkRatio", value11.AtkRatio, originalAttrCopyDesc.AtkRatio);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("DefBase", value11.DefBase, originalAttrCopyDesc.DefBase);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("DefRatio", value11.DefRatio, originalAttrCopyDesc.DefRatio);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("DmgAdditionBase", value11.DmgAdditionBase, originalAttrCopyDesc.DmgAdditionBase);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("DmgAdditionRatio", value11.DmgAdditionRatio, originalAttrCopyDesc.DmgAdditionRatio);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("DmgDefBase", value11.DmgDefBase, originalAttrCopyDesc.DmgDefBase);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("DmgDefRatio", value11.DmgDefRatio, originalAttrCopyDesc.DmgDefRatio);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("CritRateBase", value11.CritRateBase, originalAttrCopyDesc.CritRateBase);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("DmgDefRatio", value11.DmgDefRatio, originalAttrCopyDesc.DmgDefRatio);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("CritRateRatio", value11.CritRateRatio, originalAttrCopyDesc.CritRateRatio);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("CritMultiplierBase", value11.CritMultiplierBase, originalAttrCopyDesc.CritMultiplierBase);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("CritMultiplierRatio", value11.CritMultiplierRatio, originalAttrCopyDesc.CritMultiplierRatio);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("FreezeDefBase", value11.FreezeDefBase, originalAttrCopyDesc.FreezeDefBase);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("FreezeDefRatio", value11.FreezeDefRatio, originalAttrCopyDesc.FreezeDefRatio);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("BurnDefBase", value11.BurnDefBase, originalAttrCopyDesc.BurnDefBase);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("BurnDefRatio", value11.BurnDefRatio, originalAttrCopyDesc.BurnDefRatio);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("PoisonDefBase", value11.PoisonDefBase, originalAttrCopyDesc.PoisonDefBase);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("PoisonDefRatio", value11.PoisonDefRatio, originalAttrCopyDesc.PoisonDefRatio);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("ThunderDefBase", value11.ThunderDefBase, originalAttrCopyDesc.ThunderDefBase);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("ThunderDefRatio", value11.ThunderDefRatio, originalAttrCopyDesc.ThunderDefRatio);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "SuperArmor";
			foreach (KeyValuePair<int, FUStSuperArmorLevelDesc> cachedFUStSuperArmorLevelDesc in unPersistentReadOnlyData9.CachedFUStSuperArmorLevelDescs)
			{
				FUStSuperArmorLevelDesc value12 = cachedFUStSuperArmorLevelDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cachedFUStSuperArmorLevelDesc.Key;
				FUStSuperArmorLevelDesc superArmorLevelDescOrgByID = BGW_GameDB.GetSuperArmorLevelDescOrgByID(fPassiveSkillInfoConstructor.TableID);
				if (value12 != null && superArmorLevelDescOrgByID != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("SuperArmorValue", value12.SuperArmorValue, superArmorLevelDescOrgByID.SuperArmorValue);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "EffectiveHitProjectile";
			foreach (KeyValuePair<int, FUStEffectiveHitProjectileEffectDesc> cachedEffectiveHitProjectileEffectDesc in unPersistentReadOnlyData9.CachedEffectiveHitProjectileEffectDescs)
			{
				FUStEffectiveHitProjectileEffectDesc value13 = cachedEffectiveHitProjectileEffectDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cachedEffectiveHitProjectileEffectDesc.Key;
				FUStEffectiveHitProjectileEffectDesc originalEffectiveHitProjectileEffectDesc = BGW_GameDB.GetOriginalEffectiveHitProjectileEffectDesc(fPassiveSkillInfoConstructor.TableID);
				if (value13 != null && originalEffectiveHitProjectileEffectDesc != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("PEValueSwitchRatio", value13.PEValueSwitchRatio, originalEffectiveHitProjectileEffectDesc.PEValueSwitchRatio);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("CostAttr.CostAttrType", value13.CostAttr.CostAttrType, originalEffectiveHitProjectileEffectDesc.CostAttr.CostAttrType);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("CostAttr.SwitchRatio", value13.CostAttr.SwitchRatio, originalEffectiveHitProjectileEffectDesc.CostAttr.SwitchRatio);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "救命毫毛";
			foreach (KeyValuePair<int, FUStLifeSavingHairConfigDesc> cachedLifeSavingHairConfigDesc in unPersistentReadOnlyData9.CachedLifeSavingHairConfigDescs)
			{
				FUStLifeSavingHairConfigDesc value14 = cachedLifeSavingHairConfigDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cachedLifeSavingHairConfigDesc.Key;
				FUStLifeSavingHairConfigDesc originalLifeSavingHairConfigDesc = BGW_GameDB.GetOriginalLifeSavingHairConfigDesc(fPassiveSkillInfoConstructor.TableID);
				if (value14 != null && originalLifeSavingHairConfigDesc != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("DefaultCD", value14.DefaultCD, originalLifeSavingHairConfigDesc.DefaultCD);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("EffectIDList", value14.EffectIDList, originalLifeSavingHairConfigDesc.EffectIDList);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("BuffIDList", value14.BuffIDList, originalLifeSavingHairConfigDesc.BuffIDList);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "聚形散气";
			foreach (KeyValuePair<int, FUStPhantomRushSkillConfigDesc> cachedFUStPhantomRushSkillConfigDesc in unPersistentReadOnlyData9.CachedFUStPhantomRushSkillConfigDescs)
			{
				FUStPhantomRushSkillConfigDesc value15 = cachedFUStPhantomRushSkillConfigDesc.Value;
				fPassiveSkillInfoConstructor.TableID = cachedFUStPhantomRushSkillConfigDesc.Key;
				FUStPhantomRushSkillConfigDesc phantomRushSkillOrgConfigDesc = BGW_GameDB.GetPhantomRushSkillOrgConfigDesc(fPassiveSkillInfoConstructor.TableID);
				if (value15 != null && phantomRushSkillOrgConfigDesc != null)
				{
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("Duration", value15.PhantomRushDuration, phantomRushSkillOrgConfigDesc.PhantomRushDuration);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("SkillID", value15.PhantomRushSkillID, phantomRushSkillOrgConfigDesc.PhantomRushSkillID);
					fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("BeginAddBuffIDList", value15.PhantomRushBeginAddBuffIDList, phantomRushSkillOrgConfigDesc.PhantomRushBeginAddBuffIDList);
				}
			}
			fPassiveSkillInfoConstructor.TableName = "铜头铁臂";
			if (unPersistentReadOnlyData9 != null)
			{
				fPassiveSkillInfoConstructor.TableID = actorResID;
				if (unPersistentReadOnlyData9.CachedIronBodyConfigDescs != null && unPersistentReadOnlyData9.CachedIronBodyConfigDescs.TryGetValue(actorResID, out var value16))
				{
					FUStIronBodyConfigDesc originalIronBodyConfigDesc = BGW_GameDB.GetOriginalIronBodyConfigDesc(fPassiveSkillInfoConstructor.TableID);
					if (value16 != null && originalIronBodyConfigDesc != null)
					{
						fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("BeginPreciseWindowTime", value16.BeginPreciseWindowTime, originalIronBodyConfigDesc.BeginPreciseWindowTime);
						fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("EndPreciseWindowTime", value16.EndPreciseWindowTime, originalIronBodyConfigDesc.EndPreciseWindowTime);
					}
				}
			}
			foreach (KeyValuePair<int, FUStIronBodyConfigDesc> cachedIronBodyConfigDesc in unPersistentReadOnlyData9.CachedIronBodyConfigDescs)
			{
				if (actorResID != cachedIronBodyConfigDesc.Key)
				{
					continue;
				}
				fPassiveSkillInfoConstructor.TableID = cachedIronBodyConfigDesc.Key;
				FUStIronBodyConfigDesc value17 = cachedIronBodyConfigDesc.Value;
				FUStIronBodyConfigDesc originalIronBodyConfigDesc2 = BGW_GameDB.GetOriginalIronBodyConfigDesc(fPassiveSkillInfoConstructor.TableID);
				if (value17 != null && originalIronBodyConfigDesc2 != null)
				{
					int count2 = value17.StartTriggerInfoList.Count;
					for (int num3 = 0; num3 < count2; num3++)
					{
						fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"StartTriggerInfoList[{num3}].BuffID", value17.StartTriggerInfoList[num3].BuffID, originalIronBodyConfigDesc2.StartTriggerInfoList[num3].BuffID);
					}
					count2 = value17.DefeatTriggerInfoList.Count;
					for (int num4 = 0; num4 < count2; num4++)
					{
						fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"DefeatTriggerInfoList[{num4}].BuffID", value17.DefeatTriggerInfoList[num4].BuffID, originalIronBodyConfigDesc2.DefeatTriggerInfoList[num4].BuffID);
					}
					count2 = value17.PreciseTriggerInfoList.Count;
					for (int num5 = 0; num5 < count2; num5++)
					{
						fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"PreciseTriggerInfoList[{num5}].BuffID", value17.PreciseTriggerInfoList[num5].BuffID, originalIronBodyConfigDesc2.PreciseTriggerInfoList[num5].BuffID);
					}
					count2 = value17.NotPreciseTriggerInfoList.Count;
					for (int num6 = 0; num6 < count2; num6++)
					{
						fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"NotPreciseTriggerInfoList[{num6}].BuffID", value17.NotPreciseTriggerInfoList[num6].BuffID, originalIronBodyConfigDesc2.NotPreciseTriggerInfoList[num6].BuffID);
					}
				}
			}
			fPassiveSkillInfoConstructor.TableName = "定身";
			BUC_CastImmobilizeData unPersistentReadOnlyData10 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_CastImmobilizeData>(PlayerCharacter);
			if (unPersistentReadOnlyData10 != null)
			{
				foreach (KeyValuePair<int, FUStImmobilizeSkillConfigDesc> item7 in unPersistentReadOnlyData10.ImmobilizeConfigCache)
				{
					if (actorResID != item7.Key)
					{
						continue;
					}
					fPassiveSkillInfoConstructor.TableID = item7.Key;
					FUStImmobilizeSkillConfigDesc value18 = item7.Value;
					FUStImmobilizeSkillConfigDesc immobilizeSkillConfigDesc = BGW_GameDB.GetImmobilizeSkillConfigDesc(fPassiveSkillInfoConstructor.TableID);
					if (value18 != null && immobilizeSkillConfigDesc != null)
					{
						fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("DurationMs", value18.DurationMs, immobilizeSkillConfigDesc.DurationMs);
						fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("TargetCount", value18.TargetCount, immobilizeSkillConfigDesc.TargetCount);
						fPassiveSkillInfoConstructor.TryAddPassiveSkillElement("RangeRadius", value18.RangeRadius, immobilizeSkillConfigDesc.RangeRadius);
						int count3 = value18.BeginEffects.Count;
						for (int num7 = 0; num7 < count3; num7++)
						{
							fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"BeginEffects[{num7}].EffectType", value18.BeginEffects[num7].EffectType, immobilizeSkillConfigDesc.BeginEffects[num7].EffectType);
							fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"BeginEffects[{num7}].TargetBaseType", value18.BeginEffects[num7].TargetBaseType, immobilizeSkillConfigDesc.BeginEffects[num7].TargetBaseType);
							fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"BeginEffects[{num7}].Value", value18.BeginEffects[num7].Value, immobilizeSkillConfigDesc.BeginEffects[num7].Value);
						}
						count3 = value18.EndEffects.Count;
						for (int num8 = 0; num8 < count3; num8++)
						{
							fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"EndEffects[{num8}].EffectType", value18.EndEffects[num8].EffectType, immobilizeSkillConfigDesc.EndEffects[num8].EffectType);
							fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"EndEffects[{num8}].TargetBaseType", value18.EndEffects[num8].TargetBaseType, immobilizeSkillConfigDesc.EndEffects[num8].TargetBaseType);
							fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"EndEffects[{num8}].Value", value18.EndEffects[num8].Value, immobilizeSkillConfigDesc.EndEffects[num8].Value);
						}
						count3 = value18.BreakEffects.Count;
						for (int num9 = 0; num9 < count3; num9++)
						{
							fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"BreakEffects[{num9}].EffectType", value18.BreakEffects[num9].EffectType, immobilizeSkillConfigDesc.BreakEffects[num9].EffectType);
							fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"BreakEffects[{num9}].TargetBaseType", value18.BreakEffects[num9].TargetBaseType, immobilizeSkillConfigDesc.BreakEffects[num9].TargetBaseType);
							fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"BreakEffects[{num9}].Value", value18.BreakEffects[num9].Value, immobilizeSkillConfigDesc.BreakEffects[num9].Value);
						}
						count3 = value18.DeadEffects.Count;
						for (int num10 = 0; num10 < count3; num10++)
						{
							fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"DeadEffects[{num10}].EffectType", value18.DeadEffects[num10].EffectType, immobilizeSkillConfigDesc.DeadEffects[num10].EffectType);
							fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"DeadEffects[{num10}].TargetBaseType", value18.DeadEffects[num10].TargetBaseType, immobilizeSkillConfigDesc.DeadEffects[num10].TargetBaseType);
							fPassiveSkillInfoConstructor.TryAddPassiveSkillElement($"DeadEffects[{num10}].Value", value18.DeadEffects[num10].Value, immobilizeSkillConfigDesc.DeadEffects[num10].Value);
						}
					}
				}
			}
			result.PassiveSkills = fPassiveSkillInfoConstructor.PassiveSkills.ToArray();
		}
		BUC_PropMgrData readOnlyData14 = BGU_DataUtil.GetReadOnlyData<BUC_PropMgrData>(PlayerCharacter);
		if (readOnlyData14 != null)
		{
			List<FNetStruct_MoveModeStackInfo> list5 = new List<FNetStruct_MoveModeStackInfo>();
			if (readOnlyData14.MapPropType2HandleID.TryGetValue(EPropType.Movement_MovementMode, out var value19))
			{
				foreach (uint item8 in value19)
				{
					if (readOnlyData14.MapPropRequest.TryGetValue(item8, out var value20) && value20 is BGU_EnumPropRequest bGU_EnumPropRequest)
					{
						EMovementMode eMovementMode = (EMovementMode)bGU_EnumPropRequest.Value;
						string resourceInfo = bGU_EnumPropRequest.ResourceInfo;
						FNetStruct_MoveModeStackInfo item5 = new FNetStruct_MoveModeStackInfo
						{
							MoveMode = eMovementMode.ToString(),
							ResourceInfo = resourceInfo
						};
						list5.Add(item5);
					}
				}
			}
			result.MoveModeStackInfo = list5.ToArray();
		}
		return result;
	}

	private FDownloadInfo_Monster ConstructMonsterData(AActor PlayerCharacter, BGUCharacterCS Monster)
	{
		FDownloadInfo_Monster result = default(FDownloadInfo_Monster);
		if (Monster == null || PlayerCharacter == null)
		{
			return result;
		}
		result.MonsterGuid = BGU_DataUtil.GetActorGuid(Monster);
		result.bShowDebugWidget = ((IBUC_DebugInfoData)BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_DebugInfoData>(Monster))?.IsDebugWidgetShown() ?? false;
		FMonsterStateParamCollection monsterDetails = CheatData.MonsterDetails;
		int battleInfoID = (monsterDetails.BattleExtendID = Monster.GetFinalBattleInfoExtendID());
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(battleInfoID);
		monsterDetails.LevelNumericalStrength = BGW_GameDB.GetActualLevelNumericalStrength(unitBattleInfoExtendDesc);
		monsterDetails.ResID = Monster.GetResID();
		monsterDetails.Distance = Monster.GetHorizontalDistanceTo(PlayerCharacter);
		UnrealEngine.Runtime.FVector actorForwardVector = Monster.GetActorForwardVector();
		UnrealEngine.Runtime.FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(PlayerCharacter) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Monster);
		float angle = UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(actorForwardVector.GetSafeNormal2D(), fVector.GetSafeNormal2D());
		monsterDetails.Angle = angle;
		string text = (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Monster, EBGUSimpleState.SkillSuperArmor) ? "激活" : "未激活");
		string text2 = BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.SkillSuperArmor).ToString();
		string text3 = BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.SkillSuperArmorMax).ToString();
		monsterDetails.SkillSuperArmor = "(" + text + ")" + text2 + " / " + text3;
		IBUC_BeAttackData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>(Monster);
		if (readOnlyData != null)
		{
			monsterDetails.BeAttackInfoID = $"{readOnlyData.GetCurrentBeAttackedInfoID()}";
		}
		IBUC_PartMgrData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_PartMgrData, BUC_PartMgrData>(Monster);
		if (readOnlyData2 != null)
		{
			monsterDetails.PartRuleID = $"{readOnlyData2.PartRuleID}";
		}
		IBUC_DeadData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_DeadData, BUC_DeadData>(Monster);
		if (unPersistentReadOnlyData != null)
		{
			monsterDetails.DeadInfoID = $"{unPersistentReadOnlyData.GetDeadInfoID()}";
		}
		IBUC_ArmorData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_ArmorData, BUC_ArmorData>(Monster);
		if (readOnlyData3 != null)
		{
			readOnlyData3.GetBlockCounterInfo(out var CurCount, out var PerfectBlockTime, out var TotalTimes, out var BlockCD, out var BlockResetTime);
			readOnlyData3.GetHitRecoverCounterInfo(out var CurCount2, out var TotalTimes2);
			if (BlockCD <= 0f)
			{
				monsterDetails.BlockCount = $"当前: {CurCount} | 完美: {PerfectBlockTime} | 最大: {TotalTimes}";
			}
			else
			{
				monsterDetails.BlockCount = $"In CD : {BlockCD}";
			}
			if (BlockResetTime > 0f)
			{
				monsterDetails.BlockResetCount = $"倒计时：{BlockResetTime}";
			}
			else
			{
				monsterDetails.BlockResetCount = "未计时";
			}
			string text4 = ((BGUFunctionLibraryCS.BGUHasUnitState(Monster, EBGUUnitState.BlockBeatBack) || BGUFunctionLibraryCS.BGUHasUnitState(Monster, EBGUUnitState.PerfectBlockBeatBack)) ? "激活" : "未激活");
			string text5 = BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.BlockCollapseArmor).ToString();
			string text6 = BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.BlockCollapseArmorMax).ToString();
			monsterDetails.BlockBreaking = "(" + text4 + ")" + text5 + " / " + text6;
			monsterDetails.StiffBackCount = $"{CurCount2} / {TotalTimes2}";
		}
		monsterDetails.HP = $"{BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.Hp)} / {BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.HpMax)}";
		monsterDetails.Atk = $"{BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.Atk)}";
		IBUC_ABPMotionMatchingData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPMotionMatchingData>(Monster);
		if (unPersistentReadOnlyData2 != null)
		{
			monsterDetails.MMState = unPersistentReadOnlyData2.MotionMatchingState.ToString();
		}
		BUC_MovementModes unPersistentReadOnlyData3 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MovementModes>(Monster);
		if (Monster == PlayerCharacter)
		{
			monsterDetails.MoveMode = "No Target";
		}
		else if (unPersistentReadOnlyData3 != null)
		{
			BUC_MoveModeBase activeMover = unPersistentReadOnlyData3.ActiveMover;
			if (activeMover != null)
			{
				string[] array = activeMover.ToString().Split('_');
				monsterDetails.MoveMode = array[1];
			}
			else
			{
				monsterDetails.MoveMode = "No ActiveMover";
			}
		}
		monsterDetails.MovementMode = Monster.CharacterMovement.MovementMode.ToString("G");
		BUC_BattleStateData unPersistentReadOnlyData4 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BattleStateData>(Monster);
		if (unPersistentReadOnlyData4 != null)
		{
			if (unPersistentReadOnlyData4.IsUnitInBattle())
			{
				monsterDetails.BattleState = "战斗中";
			}
			else
			{
				monsterDetails.BattleState = "Not In Battle";
			}
		}
		monsterDetails.BlindSlot = $"{BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.BlindSlot)} / {BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.BlindSlotMax)}";
		BUC_AbnormalStateHandlers unPersistentReadOnlyData5 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AbnormalStateHandlers>(Monster);
		if (unPersistentReadOnlyData5 != null)
		{
			monsterDetails.IceAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.FreezeAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.FreezeAbnormalAccMax), unPersistentReadOnlyData5.AbnormalHanddler_Freeze.IsInFinalEffect() ? " 冰冻" : "");
			monsterDetails.FireAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.BurnAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.BurnAbnormalAccMax), unPersistentReadOnlyData5.AbnormalHanddler_Burn.IsInFinalEffect() ? " 炎上" : "");
			monsterDetails.PoisonAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.PoisonAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.PoisonAbnormalAccMax), unPersistentReadOnlyData5.AbnormalHanddler_Poison.IsInFinalEffect() ? " 中毒" : "");
			monsterDetails.ThunderAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.ThunderAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.ThunderAbnormalAccMax), unPersistentReadOnlyData5.AbnormalHanddler_Thunder.IsInFinalEffect() ? " 麻痹" : "");
			monsterDetails.YinAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.YinAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.YinAbnormalAccMax), unPersistentReadOnlyData5.AbnormalHanddler_Yin.IsInFinalEffect() ? " 阴状态" : "");
			monsterDetails.YangAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.YangAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.YangAbnormalAccMax), unPersistentReadOnlyData5.AbnormalHanddler_Yang.IsInFinalEffect() ? " 阳状态" : "");
			monsterDetails.IceBreak = string.Format("{0}{1}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.FreezeDef), BGUFunctionLibraryCS.BGUHasUnitSimpleState(Monster, EBGUSimpleState.FreezeImmue) ? "  | 冰冻免疫" : "");
			monsterDetails.FireBreak = string.Format("{0}{1}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.BurnDef), BGUFunctionLibraryCS.BGUHasUnitSimpleState(Monster, EBGUSimpleState.BurnImmue) ? "  | 灼烧免疫" : "");
			monsterDetails.PoisonBreak = string.Format("{0}{1}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.PoisonDef), BGUFunctionLibraryCS.BGUHasUnitSimpleState(Monster, EBGUSimpleState.PoisonImmue) ? "  | 中毒免疫" : "");
			monsterDetails.ThunderBreak = string.Format("{0}{1}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.ThunderDef), BGUFunctionLibraryCS.BGUHasUnitSimpleState(Monster, EBGUSimpleState.ThunderImmue) ? "  | 易伤免疫" : "");
		}
		IBUC_ChargeSkillData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<BUC_ChargeSkillData>(Monster);
		if (readOnlyData4 != null && readOnlyData4.IsCastingChargeSkill)
		{
			monsterDetails.ChargeSkillPhase = $"{readOnlyData4.ChargeSkillStage}";
		}
		else
		{
			monsterDetails.ChargeSkillPhase = "No ChargeSkill";
		}
		IBUC_EnvironmentInteractionMgrData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>(Monster);
		if (readOnlyData5 != null)
		{
			monsterDetails.SurfaceType = readOnlyData5.ResultSurfaceType.ToString();
		}
		IBUC_SkillInstsData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(Monster);
		if (readOnlyData6 != null)
		{
			monsterDetails.CurrentSkillID = readOnlyData6.CurrentCastingSkillID.ToString();
		}
		UAnimInstance animInstance = Monster.Mesh.GetAnimInstance();
		if (animInstance != null && animInstance.GetCurrentActiveMontage() != null)
		{
			monsterDetails.CurrentPlayingMontage = animInstance.GetCurrentActiveMontage().GetName();
		}
		else
		{
			monsterDetails.CurrentPlayingMontage = "None";
		}
		monsterDetails.CurrentTeamID = Monster.GetTeamIDInCS().ToString();
		IBUC_UnitHatredData unPersistentReadOnlyData6 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UnitHatredData>(Monster);
		if (unPersistentReadOnlyData6 != null)
		{
			monsterDetails.CurrentHatredTarget = $"当前有：{unPersistentReadOnlyData6.GetHatredTargetInfoList().Count} 个仇恨单位，其中玩家有：{unPersistentReadOnlyData6.GetPlayerHatredEntityList().Count} 个";
		}
		IBUC_TickRateData readOnlyData7 = BGU_DataUtil.GetReadOnlyData<IBUC_TickRateData, BUC_TickRateData>(Monster);
		if (readOnlyData7 != null)
		{
			monsterDetails.UROState = readOnlyData7.bIsOptimizing;
		}
		IBUC_AINodeData unPersistentReadOnlyData7 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AINodeData>(Monster);
		if (unPersistentReadOnlyData7 != null)
		{
			monsterDetails.CurrentAINode = unPersistentReadOnlyData7.ActionType;
		}
		IBUC_FsmData unPersistentReadOnlyData8 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FsmData>(Monster);
		if (unPersistentReadOnlyData8 != null)
		{
			List<FGameplayTag> currentStates = unPersistentReadOnlyData8.GetCurrentStates();
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < currentStates.Count; i++)
			{
				FGameplayTag fGameplayTag = currentStates[i];
				if (i > 0)
				{
					stringBuilder.AppendLine();
				}
				stringBuilder.Append($"{fGameplayTag.TagName}");
			}
			monsterDetails.CurrentFsmState = stringBuilder.ToString();
		}
		IBUC_AIData unPersistentReadOnlyData9 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(Monster);
		if (unPersistentReadOnlyData9 != null)
		{
			monsterDetails.CurrentFsmSolver = unPersistentReadOnlyData9.CurrentFsmSolverType.ToString();
		}
		BUC_TargetInfoData readOnlyData8 = BGU_DataUtil.GetReadOnlyData<BUC_TargetInfoData>(Monster);
		if (readOnlyData8 != null)
		{
			Func<UnitLockTargetInfo, string> func = delegate(UnitLockTargetInfo TargetInfo)
			{
				string result2 = "无目标";
				if (TargetInfo.LockTargetActor != null)
				{
					string text7 = "";
					switch (TargetInfo.LockTargetType)
					{
					case ELockTargetType.SceneComp:
						text7 = ", SceneComp名字：" + TargetInfo.LockTargetSceneCompName;
						break;
					case ELockTargetType.SkeletonSocket:
						text7 = ", SkeletonSocket名字：" + TargetInfo.LockTargetSkeletonSocketName;
						break;
					case ELockTargetType.Point:
						text7 = $", 点坐标：{TargetInfo.LockPointLocation}";
						break;
					}
					result2 = $"{BGU_DataUtil.GetActorGuid(TargetInfo.LockTargetActor).ConvertLongGuid2DisplayGuid()} [目标来源：{TargetInfo.SourceType}] [锁定类型：{TargetInfo.LockTargetType}{text7}] [目标来源2：{TargetInfo.LockTargetWayType}]";
				}
				return result2;
			};
			monsterDetails.AITarget = func(readOnlyData8.GetTargetInfo());
			monsterDetails.AOTarget = func(readOnlyData8.GetAOTarget());
			monsterDetails.SkillBaseTarget = func(readOnlyData8.GetSkillBaseTarget());
			monsterDetails.ComboTarget = func(readOnlyData8.GetComboTarget());
			monsterDetails.MoveToTarget = func(readOnlyData8.GetMoveToTarget());
		}
		IBUC_StateLibData readOnlyData9 = BGU_DataUtil.GetReadOnlyData<IBUC_StateLibData, BUC_StateLibData>(Monster);
		monsterDetails.CurrentStateLibBase = readOnlyData9.StateLibBaseDebugString;
		monsterDetails.CurrentStateLibMod = readOnlyData9.StateLibModDebugString;
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc2 = BGW_GameDB.GetUnitBattleInfoExtendDesc(Monster.GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc2 != null)
		{
			monsterDetails.CurrentOwningLevel = BGW_GameDB.GetActualLevelNumericalStrength(unitBattleInfoExtendDesc2).ToString();
			monsterDetails.CurrentHPFixedDM = unitBattleInfoExtendDesc2.HPFixedDM.ToString();
			monsterDetails.CurrentQualityType = unitBattleInfoExtendDesc2.QualityType.ToString();
		}
		else
		{
			monsterDetails.CurrentOwningLevel = "";
			monsterDetails.CurrentHPFixedDM = "";
			monsterDetails.CurrentQualityType = "";
		}
		result.Details = new string[50];
		Array.Copy(monsterDetails.AllParams, result.Details, 50);
		List<FNetStruct_SimpleState> list = new List<FNetStruct_SimpleState>();
		BUC_SimpleStateData readOnlyData10 = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(Monster);
		if (readOnlyData10 != null)
		{
			FNetStruct_SimpleState item = default(FNetStruct_SimpleState);
			for (int num = 0; num < 174; num++)
			{
				if (readOnlyData10.SimpleStates[num] != 0)
				{
					item.StateName = ((EBGUSimpleState)num/*cast due to .constrained prefix*/).ToString();
					item.Layer = readOnlyData10.SimpleStates[num];
					list.Add(item);
				}
			}
		}
		result.SimpleStates = list.ToArray();
		List<FNetStruct_UnitState> list2 = new List<FNetStruct_UnitState>();
		BUC_UnitStateData readOnlyData11 = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Monster);
		if (readOnlyData11 != null)
		{
			FNetStruct_UnitState item2 = default(FNetStruct_UnitState);
			for (int num2 = 0; num2 < 45; num2++)
			{
				if (readOnlyData11.UnitStates.GetValue(num2) != 0f)
				{
					item2.StateName = ((EBGUUnitState)num2/*cast due to .constrained prefix*/).ToString();
					item2.Time = readOnlyData11.UnitStates.GetValue(num2);
					list2.Add(item2);
				}
			}
		}
		result.UnitStates = list2.ToArray();
		List<FNetStruct_Buff> list3 = new List<FNetStruct_Buff>();
		BUC_BuffData readOnlyData12 = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Monster);
		if (readOnlyData12 != null)
		{
			FNetStruct_Buff item3 = default(FNetStruct_Buff);
			foreach (BuffInstData allBuffInstDatum in readOnlyData12.GetAllBuffInstData())
			{
				item3.ID = allBuffInstDatum.BuffID;
				item3.Layer = allBuffInstDatum.Layer;
				item3.Time = allBuffInstDatum.LeftTime;
				item3.SourceType = allBuffInstDatum.BuffSourceType.ToString("G");
				item3.Tips = "无";
				FUStBuffDesc originalBuffDesc = BGW_GameDB.GetOriginalBuffDesc(allBuffInstDatum.BuffID);
				if (originalBuffDesc != null)
				{
					item3.Tips = originalBuffDesc.BuffTips;
				}
				list3.Add(item3);
			}
		}
		result.Buffs = list3.ToArray();
		List<FNetStruct_SkillInfo> list4 = new List<FNetStruct_SkillInfo>();
		IBUC_SkillInstsData readOnlyData13 = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(Monster);
		if (readOnlyData13 != null)
		{
			int num3 = Monster.GetResID() * 100 + 99;
			for (int num4 = Monster.GetResID() * 100 + 1; num4 < num3; num4++)
			{
				FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(num4, Monster);
				if (skillSDesc == null)
				{
					continue;
				}
				FNetStruct_SkillInfo item4 = new FNetStruct_SkillInfo
				{
					SkillID = num4,
					CoolDownTime = "NoCd",
					AnimPath = skillSDesc.TemplatePath
				};
				if (!readOnlyData13.GetSkillCooldownTime(num4, out var RemainingCooldownTime, out var RemainingPreCooldownTime))
				{
					if (RemainingPreCooldownTime > 0f)
					{
						item4.CoolDownTime = $"PreCD：{RemainingPreCooldownTime:F}s";
					}
					else if (RemainingCooldownTime > 0f)
					{
						item4.CoolDownTime = $"CD：{RemainingCooldownTime:F}s";
					}
				}
				list4.Add(item4);
			}
		}
		result.Skills = list4.ToArray();
		List<FNetStruct_PartInfo> list5 = new List<FNetStruct_PartInfo>();
		if (readOnlyData2 != null && readOnlyData2.GetAllPartInfo(out var PartInfoDataDic))
		{
			foreach (KeyValuePair<int, PartInfoData> item5 in PartInfoDataDic)
			{
				int key = item5.Key;
				PartInfoData value = item5.Value;
				list5.Add(new FNetStruct_PartInfo
				{
					PartID = key,
					PartName = value.PartName,
					PartPhase = $"{value.CurrentDamagedStage} / {value.TotalDamagedStage}",
					PartState = (value.IsActive ? (value.IsBreak ? "已破碎!" : "激活!") : "未激活!"),
					PartHP = value.CurrentPartDamagedValue.ToString(),
					PartAudioType = value.PartItemAudioType.ToString(),
					PartFXType = value.PartItemFXType.ToString()
				});
			}
		}
		result.Parts = list5.ToArray();
		return result;
	}

	private FDownloadInfo_RoleData ConstructRoleData(APlayerController PlayerController)
	{
		FDownloadInfo_RoleData result = default(FDownloadInfo_RoleData);
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(PlayerController);
		if (readOnlyData != null && readOnlyData.RoleData != null && readOnlyData.RoleData.RoleCs != null && readOnlyData.RoleData.RoleCs.Task != null && readOnlyData.RoleData.RoleCs.Task.QuestList != null)
		{
			ReadOnlyQuestStageOneList questList = readOnlyData.RoleData.RoleCs.Task.QuestList;
			if (questList != null)
			{
				List<FNetStruct_TaskStage> list = new List<FNetStruct_TaskStage>();
				foreach (ReadOnlyQuestStageOne item2 in questList)
				{
					FNetStruct_TaskStage item = new FNetStruct_TaskStage
					{
						StageID = item2.Id
					};
					switch (item2.Stage)
					{
					case QuestStage.Default:
						item.StageState = "默认";
						break;
					case QuestStage.Activated:
						item.StageState = "激活";
						break;
					case QuestStage.Finished:
						item.StageState = "完成";
						break;
					}
					list.Add(item);
				}
				list.Sort((FNetStruct_TaskStage StageA, FNetStruct_TaskStage StageB) => StageA.StageID - StageB.StageID);
				result.TaskStages = list.ToArray();
			}
		}
		return result;
	}

	private FDownloadInfo_GameData ConstructGameData()
	{
		FDownloadInfo_GameData result = default(FDownloadInfo_GameData);
		BGC_MovieData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_MovieData>(base.Owner);
		if (gameStateReadonlyData != null)
		{
			List<FNetStruct_Movie> list = new List<FNetStruct_Movie>();
			foreach (KeyValuePair<int, TStrongObjectPtr<MovieInstance>> movieInstance2 in gameStateReadonlyData.MovieInstances)
			{
				MovieInstance movieInstance = movieInstance2.Value.Get();
				FNetStruct_Movie item = new FNetStruct_Movie
				{
					SequenceID = movieInstance.SequenceId,
					MovieState = movieInstance.GetCurrentStateStr()
				};
				list.Add(item);
			}
			result.CurrentPlayingMovies = list.ToArray();
		}
		return result;
	}

	private FDownloadInfo_BattleInfo ConstructBattleInfoData()
	{
		FDownloadInfo_BattleInfo result = default(FDownloadInfo_BattleInfo);
		List<FNetStruct_BattleInfoLog> list = new List<FNetStruct_BattleInfoLog>();
		foreach (BUS_BattleInfoComp.BGUBattleInfoLog sBattleInfoLog in BUS_BattleInfoComp.sBattleInfoLogList)
		{
			if (!sBattleInfoLog.IsSend)
			{
				FNetStruct_BattleInfoLog item = new FNetStruct_BattleInfoLog
				{
					LogVerbosity = (int)sBattleInfoLog.LogVerbosityType,
					BattleInfoType = (int)sBattleInfoLog.BattleInfoType,
					TimeStr = sBattleInfoLog.TimeStr,
					SelectedUnitName = sBattleInfoLog.SelectedUnitName,
					BattleInfoLogStr = sBattleInfoLog.BattleInfoLogStr,
					BattleInfoLogOptions = sBattleInfoLog.BattleInfoLogOptions
				};
				list.Add(item);
				sBattleInfoLog.SetIsSend();
			}
		}
		result.BattleInfoLogs = list.ToArray();
		result.ProjectPersistentDownloadDir = GSEFileUtil.ProjectPersistentDownloadDir;
		return result;
	}

	private FDownloadInfo_TamerManagerInfo ConstructTamerData()
	{
		FDownloadInfo_TamerManagerInfo result = default(FDownloadInfo_TamerManagerInfo);
		BGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(base.Owner);
		if (gameStateReadonlyData != null)
		{
			if (gameStateReadonlyData.TamerStrategyMap.TryGetValue(ETamerType.LevelLoaded, out var value))
			{
				result.TotalLevelMonsterCount = value.GetSpawnTamerCount();
			}
			if (gameStateReadonlyData.TamerStrategyMap.TryGetValue(ETamerType.Spawned, out var value2))
			{
				result.TotalSpawnMonsterCount = value2.GetSpawnTamerCount();
			}
			if (gameStateReadonlyData.TamerStrategyMap.TryGetValue(ETamerType.Summoned, out var value3))
			{
				result.TotalSummonMonsterCount = value3.GetSpawnTamerCount();
			}
			if (result.bShowDetailInfo = GSGameplayCVar.CVar_Diana_Debug_TamerDetail.GetValueInGameThread() == 1)
			{
				List<FNetStruct_TamerInfo> list = new List<FNetStruct_TamerInfo>();
				List<FNetStruct_DestroyTamerInfo> list2 = new List<FNetStruct_DestroyTamerInfo>();
				foreach (FTamerRef value4 in gameStateReadonlyData.UnitGuid2Tamer.Values)
				{
					if (value4.TamerType == ETamerType.LevelLoaded)
					{
						FNetStruct_TamerInfo item = new FNetStruct_TamerInfo
						{
							TamerGuid = value4.TamerGuid,
							LevelName = value4.LevelName,
							Phase = value4.Phase.ToString("G"),
							Distance = $"{value4.LastCalcDistance.X:F2}m",
							ZOffset = $"{value4.LastCalcDistance.Y:F2}m",
							Visibility = $"{value4.LastVisibility}",
							SpawnRule = value4.SpawnRuleFlags.ToString("F"),
							OriginLocation = $"{value4.Location2D} Z={value4.LocationZ}"
						};
						if (value4.bHasLODConfig)
						{
							item.LODLevel = (value4.bShowingLOD ? "显示" : "隐藏");
						}
						else
						{
							item.LODLevel = "无";
						}
						list.Add(item);
						if (value4.DelayDestroyTime > 0f)
						{
							FNetStruct_DestroyTamerInfo item2 = new FNetStruct_DestroyTamerInfo
							{
								RemainTime = value4.DelayDestroyTime.ToString("F2"),
								TamerGuid = value4.TamerGuid
							};
							list2.Add(item2);
						}
					}
				}
				result.Tamers = list.ToArray();
				result.DestroyTamers = list2.ToArray();
			}
		}
		return result;
	}

	private FDownloadInfo_PigstStoryInfo ConstructPigstStoryInfoData(ABGUCharacter PlayerCharacter)
	{
		FDownloadInfo_PigstStoryInfo result = default(FDownloadInfo_PigstStoryInfo);
		IBGC_PigsyStoryData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_PigsyStoryData>(PlayerCharacter);
		if (gameStateReadonlyData != null)
		{
			List<FNetStruct_FinishedStoryInfo> list = new List<FNetStruct_FinishedStoryInfo>();
			FNetStruct_FinishedStoryInfo item = default(FNetStruct_FinishedStoryInfo);
			foreach (int item2 in gameStateReadonlyData.FinishedStoryMemory)
			{
				item.ID = item2;
				list.Add(item);
			}
			result.FinishedStoryInfos = list.ToArray();
			result.PigstStoryInfo.LevelID = gameStateReadonlyData.CurrentLevelID;
			result.PigstStoryInfo.StoryAreaID = gameStateReadonlyData.CurrentAreaID;
			result.PigstStoryInfo.CurStoryID = gameStateReadonlyData.AiConversationStartID;
			result.PigstStoryInfo.CurStoryAiConversationContentID = gameStateReadonlyData.LastAiConversationID;
			result.PigstStoryInfo.StoryConversationType = gameStateReadonlyData.StoryConversationType.ToString();
		}
		return result;
	}

	private FDownloadInfo_BossRushInfo ConstructBossRushInfoData(ABGUCharacter PlayerCharacter)
	{
		FDownloadInfo_BossRushInfo result = default(FDownloadInfo_BossRushInfo);
		if (B1Global.GIsBossRushMode)
		{
			IBIC_BossRushData iBIC_BossRushData = RequireReadonlyGameInstanceData<IBIC_BossRushData, BIC_BossRushData>();
			if (iBIC_BossRushData != null)
			{
				List<FNetStruct_BossRushDebuffInfo> list = new List<FNetStruct_BossRushDebuffInfo>();
				FNetStruct_BossRushDebuffInfo item = default(FNetStruct_BossRushDebuffInfo);
				foreach (int debuff in iBIC_BossRushData.BossRushBattleData.DebuffList)
				{
					int resId = (item.ID = debuff);
					item.EffectID = -1;
					item.Description = "Error:Debuff配置信息表未查询到";
					BossRushDebuffDesc bossRushDebuffDesc = GameDBRuntime.GetBossRushDebuffDesc(resId);
					if (bossRushDebuffDesc != null)
					{
						item.EffectID = bossRushDebuffDesc.DebuffId;
						item.Description = bossRushDebuffDesc.DebuffBriefDesc.ToFText().ToString();
					}
					list.Add(item);
				}
				result.Debuffs = list.ToArray();
			}
		}
		return result;
	}

	private void ConstructAllActorDebugInfo(out FDownloadInfo_ActorDebugInfo ActorDebugInfo, out bool bMakeSurePackage)
	{
		bMakeSurePackage = false;
		ActorDebugInfo = default(FDownloadInfo_ActorDebugInfo);
		if (CheatData.NeedRefreshActorInfoType != EDianaActorType.Other)
		{
			bMakeSurePackage = true;
			bool flag = (CheatData.NeedRefreshActorInfoType & EDianaActorType.DynamicObstacle) == EDianaActorType.DynamicObstacle;
			bool flag2 = (CheatData.NeedRefreshActorInfoType & EDianaActorType.OverlapBox) == EDianaActorType.OverlapBox;
			bool flag3 = (CheatData.NeedRefreshActorInfoType & EDianaActorType.SpawnWaves) == EDianaActorType.SpawnWaves;
			bool flag4 = (CheatData.NeedRefreshActorInfoType & EDianaActorType.Interactor) == EDianaActorType.Interactor;
			bool flag5 = (CheatData.NeedRefreshActorInfoType & EDianaActorType.AllWorldActor) == EDianaActorType.AllWorldActor;
			List<FNetStruct_ActorInfo> ActorInfos = new List<FNetStruct_ActorInfo>();
			List<FNetStruct_DynamicObstacleDebugInfo> DynamicObstacleInfos = new List<FNetStruct_DynamicObstacleDebugInfo>();
			List<FNetStruct_OverlapBoxDebugInfo> OverlapBoxDebugInfos = new List<FNetStruct_OverlapBoxDebugInfo>();
			List<FNetStruct_SpawnWavesDebugInfo> SpawnWavesDebugInfos = new List<FNetStruct_SpawnWavesDebugInfo>();
			List<FNetStruct_InteractorDebugInfo> InteractorDebugInfos = new List<FNetStruct_InteractorDebugInfo>();
			List<FNetStruct_WorldActorDebugInfo> list = new List<FNetStruct_WorldActorDebugInfo>();
			GlobalActorData.GetAllInteractorSet(out var OutInteractorSet);
			StateMachineData.GetAllSceneObjState(out var OutSceneObjState);
			StateMachineData.GetAllSceneObjTransientState(out var OutSceneObjTransientState);
			foreach (KeyValuePair<string, GameplayTagContainerRef> item2 in OutSceneObjState)
			{
				string key = item2.Key;
				GameplayTagContainerRef value = item2.Value;
				if (OutSceneObjTransientState.TryGetValue(key, out var value2))
				{
					foreach (KeyValuePair<FGameplayTag, FGameplayTag> item3 in value2)
					{
						if (value.HasTag(item3.Key))
						{
							value.RemoveTag(item3.Key);
							value.AddTag(item3.Value);
						}
					}
				}
				ConstructSingleActorInfo(key, value, OutInteractorSet, ref ActorInfos, flag, ref DynamicObstacleInfos, flag2, ref OverlapBoxDebugInfos, flag3, ref SpawnWavesDebugInfos, flag4, ref InteractorDebugInfos);
			}
			if (flag5)
			{
				AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<AActor>(base.Owner);
				foreach (AActor aActor in allActorsOfClass)
				{
					if (!aActor.IsNullOrDestroyed())
					{
						FNetStruct_WorldActorDebugInfo item = new FNetStruct_WorldActorDebugInfo
						{
							ActorIDName = aActor.GetName(),
							AliasName = aActor.GetActorLabel(),
							ActorLevel = aActor.GetOuter()?.GetOuter()?.GetName(),
							ActorClass = aActor.GetClass()?.GetName(),
							ActorLocation = BGWCheatManageExtensions.ToNetStruct(aActor.GetActorLocation()),
							ActorRotation = BGWCheatManageExtensions.ToNetStruct(aActor.GetActorRotation()),
							ActorScale = BGWCheatManageExtensions.ToNetStruct(aActor.GetActorScale3D()),
							bHiddenInGame = aActor.Hidden
						};
						list.Add(item);
					}
				}
			}
			ActorDebugInfo.Actors = ActorInfos.ToArray();
			ActorDebugInfo.bValidDynamicObstacle = flag;
			ActorDebugInfo.DynamicObstacleInfos = DynamicObstacleInfos.ToArray();
			ActorDebugInfo.bValidOverlapBox = flag2;
			ActorDebugInfo.OverlapBoxDebugInfos = OverlapBoxDebugInfos.ToArray();
			ActorDebugInfo.bValidSpawnWaves = flag3;
			ActorDebugInfo.SpawnWavesDebugInfos = SpawnWavesDebugInfos.ToArray();
			ActorDebugInfo.bValidInteractor = flag4;
			ActorDebugInfo.InteractorDebugInfos = InteractorDebugInfos.ToArray();
			ActorDebugInfo.bValidWorldActors = flag5;
			ActorDebugInfo.WorldActorDebugInfos = list.ToArray();
		}
		CheatData.NeedRefreshActorInfoType = EDianaActorType.Other;
	}

	private void ConstructSingleActorInfo(string ActorGuid, GameplayTagContainerRef StateTagContainer, HashSet<string> AllInteractorSet, ref List<FNetStruct_ActorInfo> ActorInfos, bool bRefreshDynamicObstacleActor, ref List<FNetStruct_DynamicObstacleDebugInfo> DynamicObstacleInfos, bool bRefreshOverlapBox, ref List<FNetStruct_OverlapBoxDebugInfo> OverlapBoxDebugInfos, bool bRefreshSpawnWaves, ref List<FNetStruct_SpawnWavesDebugInfo> SpawnWavesDebugInfos, bool bRefreshInteractor, ref List<FNetStruct_InteractorDebugInfo> InteractorDebugInfos)
	{
		if (StateTagContainer == null)
		{
			return;
		}
		FNetStruct_ActorInfo item = new FNetStruct_ActorInfo
		{
			ActorGuid = ActorGuid
		};
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, ActorGuid);
		if (actorByGuid != null)
		{
			item.AliasName = actorByGuid.GetActorLabel();
			item.bShowingDebugWidget = ((IBUC_DebugInfoData)BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_DebugInfoData>(actorByGuid))?.IsDebugWidgetShown() ?? false;
			item.bRealTimeRefresh = CheatData.RealTimeActors.Contains(ActorGuid);
		}
		int count = ActorInfos.Count;
		ActorInfos.Add(item);
		if (bRefreshDynamicObstacleActor && StateTagContainer.HasTag(BGW_FlowUtils.SceneObjTag.DynamicObstacle, bExactMatch: false))
		{
			FNetStruct_DynamicObstacleDebugInfo item2 = new FNetStruct_DynamicObstacleDebugInfo
			{
				Index = count
			};
			if (StateTagContainer.HasTag(BGW_FlowUtils.DynamicObstacleTag.State_Enabled))
			{
				item2.OpenState = "State_Enabled";
			}
			if (StateTagContainer.HasTag(BGW_FlowUtils.DynamicObstacleTag.State_EnabledToDisable))
			{
				item2.OpenState = "State_EnabledToDisable";
			}
			if (StateTagContainer.HasTag(BGW_FlowUtils.DynamicObstacleTag.State_Disabled))
			{
				item2.OpenState = "State_Disabled";
			}
			if (StateTagContainer.HasTag(BGW_FlowUtils.DynamicObstacleTag.State_DisabledToEnabled))
			{
				item2.OpenState = "State_DisabledToEnabled";
			}
			DynamicObstacleInfos.Add(item2);
		}
		if (bRefreshOverlapBox && StateTagContainer.HasTag(BGW_FlowUtils.SceneObjTag.OverlapBox, bExactMatch: false))
		{
			FNetStruct_OverlapBoxDebugInfo item3 = new FNetStruct_OverlapBoxDebugInfo
			{
				Index = count
			};
			if (StateTagContainer.HasTag(BGW_FlowUtils.OverlapTag.State_Enabled))
			{
				item3.State = "State_Enabled";
			}
			if (StateTagContainer.HasTag(BGW_FlowUtils.OverlapTag.State_Disabled))
			{
				item3.State = "State_Disabled";
			}
			if (TaskData.IsPlayerInOverlap(ActorGuid, out var bInnerOverlap))
			{
				item3.bInner = bInnerOverlap;
			}
			OverlapBoxDebugInfos.Add(item3);
		}
		if (bRefreshSpawnWaves && StateTagContainer.HasTag(BGW_FlowUtils.SceneObjTag.Spawner, bExactMatch: false))
		{
			FNetStruct_SpawnWavesDebugInfo item4 = new FNetStruct_SpawnWavesDebugInfo
			{
				Index = count
			};
			if (StateTagContainer.HasTag(BGW_FlowUtils.SpawnerTag.State_Disabled))
			{
				item4.State = "State_Disabled";
			}
			if (StateTagContainer.HasTag(BGW_FlowUtils.SpawnerTag.State_Idled))
			{
				item4.State = "State_Idled";
			}
			if (StateTagContainer.HasTag(BGW_FlowUtils.SpawnerTag.State_Spawned))
			{
				item4.State = "State_Spawned";
			}
			if (StateTagContainer.HasTag(BGW_FlowUtils.SpawnerTag.State_Cleared))
			{
				item4.State = "State_Cleared";
			}
			SpawnWavesDebugInfos.Add(item4);
		}
		if (!bRefreshInteractor || !AllInteractorSet.Contains(ActorGuid))
		{
			return;
		}
		FNetStruct_InteractorDebugInfo item5 = new FNetStruct_InteractorDebugInfo
		{
			Index = count
		};
		IBUC_InteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_InteractData, BUC_InteractData>(actorByGuid);
		PersistentBUCData Ret;
		if (readOnlyData != null)
		{
			item5.InteractorID = readOnlyData.InteractiveUnitID;
			item5.State = readOnlyData.InteractUnitState.ToString("G");
			item5.DefaultGroupID = readOnlyData.DefalutInteractiveGroupID;
			item5.CurrentGroupID = readOnlyData.ActionGroupID;
			item5.bInteracting = readOnlyData.bIsInteracting;
			item5.RemainInteractTime = readOnlyData.RemainingInteractTime;
			item5.CameraBlendOutTime = readOnlyData.BlendOutTimer;
			item5.LimitReason = readOnlyData.InteractConstraint.ToString("G");
		}
		else if (RequireReadonlyGameInstanceData<IBIC_PersistentECSData, BIC_PersistentECSData>().FindOrAllocBUCDataByGuid(ActorGuid, out Ret))
		{
			GurGsPersistent.BUC_InteractData bUCInteractData = Ret.BUCInteractData;
			if (bUCInteractData != null)
			{
				item5.State = bUCInteractData.InteractUnitStatePersistent.ToString("G");
				item5.CurrentGroupID = bUCInteractData.ActionGroupIDPersistent;
			}
		}
		InteractorDebugInfos.Add(item5);
	}

	private FDownloadInfo_ActorDebugInfo ConstructRealTimeActorDebugInfo()
	{
		FDownloadInfo_ActorDebugInfo result = default(FDownloadInfo_ActorDebugInfo);
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string realTimeActor in CheatData.RealTimeActors)
		{
			hashSet.Add(realTimeActor);
		}
		foreach (string refreshOnceActor in CheatData.RefreshOnceActors)
		{
			hashSet.Add(refreshOnceActor);
		}
		CheatData.RefreshOnceActors.Clear();
		if (hashSet.Count > 0)
		{
			List<FNetStruct_ActorInfo> ActorInfos = new List<FNetStruct_ActorInfo>();
			List<FNetStruct_DynamicObstacleDebugInfo> DynamicObstacleInfos = new List<FNetStruct_DynamicObstacleDebugInfo>();
			List<FNetStruct_OverlapBoxDebugInfo> OverlapBoxDebugInfos = new List<FNetStruct_OverlapBoxDebugInfo>();
			List<FNetStruct_SpawnWavesDebugInfo> SpawnWavesDebugInfos = new List<FNetStruct_SpawnWavesDebugInfo>();
			List<FNetStruct_InteractorDebugInfo> InteractorDebugInfos = new List<FNetStruct_InteractorDebugInfo>();
			GlobalActorData.GetAllInteractorSet(out var OutInteractorSet);
			StateMachineData.GetAllSceneObjState(out var OutSceneObjState);
			StateMachineData.GetAllSceneObjTransientState(out var OutSceneObjTransientState);
			foreach (string item in hashSet)
			{
				if (OutSceneObjState.TryGetValue(item, out var value) && OutSceneObjTransientState.TryGetValue(item, out var value2))
				{
					foreach (KeyValuePair<FGameplayTag, FGameplayTag> item2 in value2)
					{
						if (value.HasTag(item2.Key))
						{
							value.RemoveTag(item2.Key);
							value.AddTag(item2.Value);
						}
					}
				}
				ConstructSingleActorInfo(item, value, OutInteractorSet, ref ActorInfos, bRefreshDynamicObstacleActor: true, ref DynamicObstacleInfos, bRefreshOverlapBox: true, ref OverlapBoxDebugInfos, bRefreshSpawnWaves: true, ref SpawnWavesDebugInfos, bRefreshInteractor: true, ref InteractorDebugInfos);
			}
			result.Actors = ActorInfos.ToArray();
			result.InteractorDebugInfos = InteractorDebugInfos.ToArray();
			result.DynamicObstacleInfos = DynamicObstacleInfos.ToArray();
			result.OverlapBoxDebugInfos = OverlapBoxDebugInfos.ToArray();
			result.SpawnWavesDebugInfos = SpawnWavesDebugInfos.ToArray();
			result.InteractorDebugInfos = InteractorDebugInfos.ToArray();
		}
		return result;
	}

	private FDownloadInfo_PreloadInfo ConstructPreloadInfo(bool NeedUpdatePreloadInfo, bool NeedUpdateMemoryInfo)
	{
		int valueInGameThread = GSGameplayCVar.CVar_SetCanUpdatePreloadInfo.GetValueInGameThread();
		FDownloadInfo_PreloadInfo result = new FDownloadInfo_PreloadInfo
		{
			CanUpdateInfo = (valueInGameThread == 1),
			UpdatePreloadInfo = NeedUpdatePreloadInfo,
			UpdatePreloadDetailInfo = NeedUpdatePreloadInfo,
			UpdateMemoryInfo = NeedUpdateMemoryInfo
		};
		UnitPreloadInfos.Clear();
		PreloadResourceInfos.Clear();
		ResourceDetailInfoArray.Clear();
		if (valueInGameThread == 1 && result.UpdatePreloadInfo)
		{
			BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(base.Owner);
			if (bGW_PreloadAssetMgr != null)
			{
				bGW_PreloadAssetMgr.GetPreloadNumInfo(out var ResourceNum_Total, out var ResourceNum_Loading, out var ResourceNum_Failed, out var ResourceNum_Success, out var ResourceNum_Unloading);
				result.ResourceNum_Total = ResourceNum_Total;
				result.ResourceNum_Loading = ResourceNum_Loading;
				result.ResourceNum_Failed = ResourceNum_Failed;
				result.ResourceNum_Success = ResourceNum_Success;
				result.ResourceNum_Unloading = ResourceNum_Unloading;
				foreach (KeyValuePair<int, (int, int)> item in bGW_PreloadAssetMgr.GetUnitPreloadInfoDict())
				{
					UnitPreloadInfos.Add(new FNetStruct_UnitPreloadInfo
					{
						ResID = item.Key,
						InstanceNum = item.Value.Item1,
						ResourceNum = item.Value.Item2
					});
				}
				foreach (KeyValuePair<EPreloadAssetSourceType, int> item2 in bGW_PreloadAssetMgr.GetPreloadResourceInfoDict())
				{
					PreloadResourceInfos.Add(new FNetStruct_PreloadResourceInfo
					{
						ResourceType = item2.Key.ToString(),
						ResourceNum = item2.Value
					});
				}
				ResourceDetailInfoArray = bGW_PreloadAssetMgr.GetPreloadResourceDetailInfoList();
			}
		}
		result.UnitPreloadInfoArray = UnitPreloadInfos.ToArray();
		result.ResourceInfoArray = PreloadResourceInfos.ToArray();
		result.ResourceDetailInfoArray = ResourceDetailInfoArray.ToArray();
		VideoMemoryStateInfos.Clear();
		SumMemoryStateInfos.Clear();
		OtherMemoryStateInfos.Clear();
		if (valueInGameThread == 1 && result.UpdateMemoryInfo)
		{
			float usedGraphicsMemory = UGSE_SystemSettingsFuncLib.GetUsedGraphicsMemory();
			float availableGraphicsMemory = UGSE_SystemSettingsFuncLib.GetAvailableGraphicsMemory();
			float usedGraphicsMemory2 = UGSE_SystemSettingsFuncLib.GetUsedGraphicsMemory(EGSGraphicsMemoryMode.SHARED);
			result.UsedVideoMemory = usedGraphicsMemory;
			result.TotalVideoMemory = availableGraphicsMemory;
			result.UsedSharedMemory = usedGraphicsMemory2 / 1024f;
			float num = 0f;
			foreach (FGSCapturedStatResult item3 in UGSE_ProfilerFuncLib.CaptureSpecificStatsInfo(AllMemoryStateNames))
			{
				string memoryValue = "";
				string statName = item3.StatName;
				switch (item3.StatType)
				{
				case EGSCapturedStatType.CYCLE:
					memoryValue = $"{item3.Value:0.00} ms";
					break;
				case EGSCapturedStatType.NUM:
				{
					float value = item3.Value;
					memoryValue = value.ToString();
					break;
				}
				case EGSCapturedStatType.MEMORY:
					if (VideoMemoryStateNames.Contains(statName))
					{
						num += item3.Value;
					}
					memoryValue = $"{item3.Value:0.00} MB";
					break;
				}
				if (VideoMemoryStateNames.Contains(statName))
				{
					VideoMemoryStateInfos.Add(new FNetStruct_MemoryStateInfo
					{
						StateName = statName,
						MemoryValue = memoryValue
					});
				}
				else if (SumMemoryStateNames.Contains(statName))
				{
					SumMemoryStateInfos.Add(new FNetStruct_MemoryStateInfo
					{
						StateName = item3.StatName,
						MemoryValue = memoryValue
					});
				}
				else
				{
					OtherMemoryStateInfos.Add(new FNetStruct_MemoryStateInfo
					{
						StateName = item3.StatName,
						MemoryValue = memoryValue
					});
				}
			}
			result.RHIStateTotalMemory = num / 1024f;
		}
		result.VideoMemoryStateInfoArray = VideoMemoryStateInfos.ToArray();
		result.SumMemoryStateInfoArray = SumMemoryStateInfos.ToArray();
		result.OtherMemoryStateInfoArray = OtherMemoryStateInfos.ToArray();
		return result;
	}

	private void MarkActorInfoRealTime(string ActorGuid, bool bRt)
	{
		if (bRt)
		{
			CheatData.RealTimeActors.Add(ActorGuid);
			return;
		}
		CheatData.RealTimeActors.Remove(ActorGuid);
		OnRefreshActorInfoOnce(ActorGuid);
	}

	private void OnRefreshActorInfoOnce(string ActorGuid)
	{
		CheatData.RefreshOnceActors.Add(ActorGuid);
	}

	private void OnRefreshActorInfo(string ActorType)
	{
		if (Enum.TryParse<EDianaActorType>(ActorType, out var result))
		{
			CheatData.NeedRefreshActorInfoType |= result;
		}
	}

	private void ParseUploadPackage(FUploadPackage InPackage)
	{
		string[] commands = InPackage.Commands;
		foreach (string command in commands)
		{
			USystemLibrary.ExecuteConsoleCommand(base.Owner, command, null);
		}
		CheatData.CurrentSendMonsterGuid = InPackage.RequestMonitorMonster;
	}

	private void OnRefreshLevelInfo()
	{
		CheatData.bRefreshLevelPoints = true;
	}

	private void OnPlayerDelayBeginPlayFinished()
	{
		CheatData.DianaCommandList.Add(EDianaControlCommand.PlayerBeginPlay);
	}

	private void OnLockAllMonsterHP(bool bLock)
	{
		CheatData.bLockAllMonsterHP = bLock;
	}

	private void OnCancelAllMonsterSkillCD(bool bCancel)
	{
		CheatData.bCancelAllMonsterSkillCD = bCancel;
	}

	private void OnPauseAllMonsterAI(bool bPause)
	{
		CheatData.bPauseAllMonsterAI = bPause;
	}
}
