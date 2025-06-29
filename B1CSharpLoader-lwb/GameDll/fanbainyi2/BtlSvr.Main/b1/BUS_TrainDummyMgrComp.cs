using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using b1.AutoQA;
using b1.BGW;
using b1.EventDelDefine;
using BtlShare;
using ResB1;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_TrainDummyMgrComp : UActorCompBaseCS
{
	private BUC_TrainDummyMgrConfigData TrainDummyMgrConfigData;

	private BUC_TrainDummyMgrData TrainDummyMgrData;

	public override void OnAttach()
	{
		TrainDummyMgrConfigData = RequireWritableData<BUC_TrainDummyMgrConfigData>();
		TrainDummyMgrData = RequireWritableData<BUC_TrainDummyMgrData>();
		base.BUSEventCollection.Evt_SetTrainDummyInfo += new Del_SetTrainDummyInfo(SetTrainDummyInfo);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_ReportSkillDamageInfo = (BGW_EventCollection.Del_ReportSkillDamageInfo)Delegate.Combine(bGWEventCollection.Evt_ReportSkillDamageInfo, new BGW_EventCollection.Del_ReportSkillDamageInfo(OnReportSkillDamageInfo));
	}

	private void DestroySpawnedUnit()
	{
		TrainDummyMgrData.CurrentDPSInfo = null;
		if (TrainDummyMgrData.IsUnitSpawned)
		{
			BGU_UnrealWorldUtil.RequestDestroyUnit(Owner, TrainDummyMgrData.SpawnUnitGuid);
		}
		BUC_TrainDummyMgrData trainDummyMgrData = TrainDummyMgrData;
		BUC_TrainDummyMgrData trainDummyMgrData2 = TrainDummyMgrData;
		bool flag = (TrainDummyMgrData.IsPlayerInit = false);
		bool isUnitSpawned = (trainDummyMgrData2.IsUnitManaged = flag);
		trainDummyMgrData.IsUnitSpawned = isUnitSpawned;
		TrainDummyMgrConfigData.TrainDummyClass = null;
	}

	private void SetTrainDummyInfo(string TrainDummyClassPath, int PlayerRoleDataConfigID, string TrainDummyConfigPath, float DPSCalTime = -1f)
	{
		DestroySpawnedUnit();
		TrainDummyMgrConfigData.PlayerRoleDataConfigID = PlayerRoleDataConfigID;
		List<RoleDataConfigDesc> roleDataConfigByType = GameDBRuntime.GetRoleDataConfigByType(PlayerRoleDataConfigID);
		UClass uClass = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UClass>(TrainDummyClassPath, ELoadResourceType.SyncLoadAndCache);
		BGWDataAsset_TrainDummyConfig bGWDataAsset_TrainDummyConfig = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_TrainDummyConfig>(TrainDummyConfigPath, ELoadResourceType.SyncLoadAndCache);
		if (roleDataConfigByType == null || uClass == null || bGWDataAsset_TrainDummyConfig == null)
		{
			TrainDummyFailed();
			return;
		}
		TrainDummyMgrData.TrainDummyFailed = false;
		TrainDummyMgrData.IsNeedDestroyUnitAfterFinish = true;
		TrainDummyMgrConfigData.TrainDummyClass = uClass;
		TrainDummyMgrConfigData.TrainDummyHPType = bGWDataAsset_TrainDummyConfig.TrainDummyHPType;
		TrainDummyMgrConfigData.TrainDummyHPValue = ((bGWDataAsset_TrainDummyConfig.TrainDummyHPType == EGSTrainDummyHPType.Infinite) ? int.MaxValue : bGWDataAsset_TrainDummyConfig.TrainDummyHPValue);
		TrainDummyMgrConfigData.NeedCloseTrainDummyAI = bGWDataAsset_TrainDummyConfig.NeedCloseTrainDummyAI;
		TrainDummyMgrConfigData.DPSCalTimeType = bGWDataAsset_TrainDummyConfig.DPSCalTimeType;
		TrainDummyMgrConfigData.DPSCalTime = bGWDataAsset_TrainDummyConfig.DPSCalTime;
		TrainDummyMgrConfigData.SpecialDamageTypeConfigList = bGWDataAsset_TrainDummyConfig.SpecialDamageTypeConfigList.ToList();
		if (DPSCalTime > 0f)
		{
			TrainDummyMgrConfigData.DPSCalTime = DPSCalTime;
		}
	}

	private void OnReportSkillDamageInfo(AActor Attacker, AActor Victim, int SkillID, int BuffID, int EffectID, float SkillDamageValue)
	{
		if (!(Attacker == null) && !(Victim == null) && TrainDummyMgrData.IsUnitManaged && BGU_DataUtil.GetActorGuid(Victim) == TrainDummyMgrData.SpawnUnitGuid)
		{
			if (TrainDummyMgrConfigData.TrainDummyHPType == EGSTrainDummyHPType.Infinite)
			{
				BUS_EventCollectionCS.Get(Victim)?.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Hp, BGUFunctionLibraryCS.BGUGetFloatAttr(Victim, EBGUAttrFloat.HpMax));
			}
			List<string> specialDamageType = GetSpecialDamageType(Attacker, Victim, SkillID, BuffID, EffectID);
			OnDummyGetDamaged(Attacker, Victim, SkillID, BuffID, EffectID, SkillDamageValue, specialDamageType);
		}
	}

	private List<string> GetSpecialDamageType(AActor Attacker, AActor Victim, int SkillID, int BuffID, int EffectID)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < TrainDummyMgrConfigData.SpecialDamageTypeConfigList.Count; i++)
		{
			FTrainDummySpecialDamageTypeConfig fTrainDummySpecialDamageTypeConfig = TrainDummyMgrConfigData.SpecialDamageTypeConfigList[i];
			if (fTrainDummySpecialDamageTypeConfig.SkillID != null && fTrainDummySpecialDamageTypeConfig.SkillID.Contains(SkillID))
			{
				ListExtensions.AddUnique(list, fTrainDummySpecialDamageTypeConfig.Describe);
				continue;
			}
			bool flag = false;
			if (fTrainDummySpecialDamageTypeConfig.AttackerResIdCondition != null && fTrainDummySpecialDamageTypeConfig.AttackerResIdCondition.Count > 0 && Attacker is BGUCharacterCS bGUCharacterCS && fTrainDummySpecialDamageTypeConfig.AttackerResIdCondition.Contains(bGUCharacterCS.GetResID()))
			{
				ListExtensions.AddUnique(list, fTrainDummySpecialDamageTypeConfig.Describe);
				continue;
			}
			if (fTrainDummySpecialDamageTypeConfig.AttackerSimpleStateCondition != null && fTrainDummySpecialDamageTypeConfig.AttackerSimpleStateCondition.Count > 0)
			{
				IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Victim);
				if (readOnlyData != null)
				{
					foreach (EBGUSimpleState item in fTrainDummySpecialDamageTypeConfig.AttackerSimpleStateCondition)
					{
						if (readOnlyData.HasSimpleState(item))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						ListExtensions.AddUnique(list, fTrainDummySpecialDamageTypeConfig.Describe);
						continue;
					}
				}
			}
			if (fTrainDummySpecialDamageTypeConfig.AttackerUnitStateCondition != null && fTrainDummySpecialDamageTypeConfig.AttackerUnitStateCondition.Count > 0)
			{
				IBUC_UnitStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(Attacker);
				if (readOnlyData2 != null)
				{
					foreach (EBGUUnitState item2 in fTrainDummySpecialDamageTypeConfig.AttackerUnitStateCondition)
					{
						if (readOnlyData2.HasState(item2))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						ListExtensions.AddUnique(list, fTrainDummySpecialDamageTypeConfig.Describe);
						continue;
					}
				}
			}
			if (fTrainDummySpecialDamageTypeConfig.VictimSimpleStateCondition != null && fTrainDummySpecialDamageTypeConfig.VictimSimpleStateCondition.Count > 0)
			{
				IBUC_SimpleStateData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Victim);
				if (readOnlyData3 != null)
				{
					foreach (EBGUSimpleState item3 in fTrainDummySpecialDamageTypeConfig.VictimSimpleStateCondition)
					{
						if (readOnlyData3.HasSimpleState(item3))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						ListExtensions.AddUnique(list, fTrainDummySpecialDamageTypeConfig.Describe);
						continue;
					}
				}
			}
			if (fTrainDummySpecialDamageTypeConfig.VictimUnitStateCondition == null || fTrainDummySpecialDamageTypeConfig.VictimUnitStateCondition.Count <= 0)
			{
				continue;
			}
			IBUC_UnitStateData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(Victim);
			if (readOnlyData4 == null)
			{
				continue;
			}
			foreach (EBGUUnitState item4 in fTrainDummySpecialDamageTypeConfig.VictimUnitStateCondition)
			{
				if (readOnlyData4.HasState(item4))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				ListExtensions.AddUnique(list, fTrainDummySpecialDamageTypeConfig.Describe);
			}
		}
		return list;
	}

	private void OnDummyGetDamaged(AActor Attacker, AActor Victim, int SkillID, int BuffID, int EffectID, float SkillDamageValue, List<string> SpecialDamageTypeList)
	{
		if (TrainDummyMgrData.IsUnitManaged && BGU_DataUtil.GetActorGuid(Victim) == TrainDummyMgrData.SpawnUnitGuid)
		{
			if (TrainDummyMgrData.CurrentDPSInfo == null)
			{
				TrainDummyMgrData.CurrentDPSInfo = new DPSCalculateInfo(BGU_DataUtil.GetActorResID(Victim), TrainDummyMgrConfigData.PlayerRoleDataConfigID, TrainDummyMgrConfigData.DPSCalTimeType, TrainDummyMgrConfigData.DPSCalTime);
			}
			TrainDummyMgrData.CurrentDPSInfo.ApplyDamage(SkillDamageValue, BGU_DataUtil.GetActorResID(Attacker), SkillID, EffectID, SpecialDamageTypeList);
		}
	}

	public void SetupEnv()
	{
		if (TrainDummyMgrConfigData.TrainDummyClass.Value == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner).GetControlledPawn() as BGUCharacterCS;
		if (!(bGUCharacterCS == null) && !(bGUCharacterCS.GetCurrentMontage() != null))
		{
			IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(bGUCharacterCS);
			if (readOnlyData != null && !readOnlyData.HasState(EBGUUnitState.Attacking))
			{
				TrainDummyMgrData.SpawnUnitGuid = BGU_UnrealWorldUtil.RequestSpawnUnit(Owner.World, TrainDummyMgrConfigData.TrainDummyClass.Value, BGUFuncLibActorTransformCS.BGUGetActorTransform(Owner), Owner);
				TrainDummyMgrData.IsUnitSpawned = true;
				BUC_TrainDummyMgrData trainDummyMgrData = TrainDummyMgrData;
				bool isUnitManaged = (TrainDummyMgrData.IsPlayerInit = false);
				trainDummyMgrData.IsUnitManaged = isUnitManaged;
			}
		}
	}

	public void TryManageDummy()
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(Owner, TrainDummyMgrData.SpawnUnitGuid));
		if (bUS_GSEventCollection != null)
		{
			if (TrainDummyMgrConfigData.TrainDummyHPType == EGSTrainDummyHPType.Value)
			{
				bUS_GSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.HpMaxBase, TrainDummyMgrConfigData.TrainDummyHPValue);
				bUS_GSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Hp, TrainDummyMgrConfigData.TrainDummyHPValue);
			}
			if (TrainDummyMgrConfigData.TrainDummyHPType != EGSTrainDummyHPType.Infinite)
			{
				bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.ForcePerformance);
			}
			if (TrainDummyMgrConfigData.NeedCloseTrainDummyAI)
			{
				UBehaviorTree bT = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UBehaviorTree>("BehaviorTree'/Game/00Main/Design/AI/BTs/Template/BT_Empty.BT_Empty'", ELoadResourceType.SyncLoadAndCache);
				bUS_GSEventCollection.Evt_SetBT.Invoke(bT);
				bUS_GSEventCollection.Evt_SetSummonStateBehaviorTree.Invoke(ESummonBehaviorState.Default, bT);
				bUS_GSEventCollection.Evt_SetUnitWakeUpEnabled.Invoke(P1: false);
				bUS_GSEventCollection.Evt_OverrideArmorSetting.Invoke(new FGSArmorSettingInBP
				{
					Armor_Enable = false,
					Armor_SkillID = new List<int>(),
					CounterWithBloodConfig = new List<FGSArmorCounterWithBlood>()
				});
				bUS_GSEventCollection.Evt_SetLockAllPartHP.Invoke(P1: true);
				bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.ImmueStiff);
			}
			TrainDummyMgrData.IsUnitManaged = true;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		new List<AActor>();
		if (TrainDummyMgrData.TrainDummyFailed)
		{
			TrainDummyMgrData.CurrentDPSInfo = new DPSCalculateInfo(-1, TrainDummyMgrConfigData.PlayerRoleDataConfigID, TrainDummyMgrConfigData.DPSCalTimeType, TrainDummyMgrConfigData.DPSCalTime, _IsValid: false);
			TrainDummyFinish();
		}
		else if (!TrainDummyMgrData.IsUnitSpawned)
		{
			SetupEnv();
		}
		else if (!TrainDummyMgrData.IsUnitManaged)
		{
			TryManageDummy();
		}
		else if (!TrainDummyMgrData.IsPlayerInit)
		{
			InitPlayer();
		}
		else if (TrainDummyMgrData.CurrentDPSInfo != null && (BGUFunctionLibraryCS.BGUIsUnitDead(BGU_DataUtil.GetActorByGuid(Owner, TrainDummyMgrData.SpawnUnitGuid)) || TrainDummyMgrData.CurrentDPSInfo.Tick(DeltaTime)))
		{
			TrainDummyFinish();
		}
	}

	private void TrainDummyFailed()
	{
		TrainDummyMgrData.TrainDummyFailed = true;
	}

	private void TrainDummyFinish()
	{
		TrainDummyMgrData.TrainDummyFailed = false;
		TrainDummyMgrData.FinishedDPSInfos.Add(TrainDummyMgrData.CurrentDPSInfo);
		b1.BGUTrainDummyMgrActor bGUTrainDummyMgrActor = Owner as b1.BGUTrainDummyMgrActor;
		if (bGUTrainDummyMgrActor != null && bGUTrainDummyMgrActor.GetActorGuid(out var OutActorGuid))
		{
			base.BGWEventCollection.Evt_TrainDummyResultReport(OutActorGuid);
			if (TrainDummyMgrData.IsNeedDestroyUnitAfterFinish)
			{
				DestroySpawnedUnit();
			}
			TrainDummyMgrData.CurrentDPSInfo = null;
		}
	}

	public string GetOutputDpsResultInfo(DPSCalculateInfo DPSInfo, bool OutputAsCSV = false)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (DPSInfo.IsValid)
		{
			if (OutputAsCSV)
			{
				List<RoleDataConfigDesc> roleDataConfigByType = GameDBRuntime.GetRoleDataConfigByType(DPSInfo.PlayerRoleDataConfigID);
				DPSInfo.GetMaxOneHitDamageInfo(out var EffectID, out var Damage);
				List<string> values = new List<string>
				{
					roleDataConfigByType[0].Desc,
					DPSInfo.TotalTime.ToString(),
					DPSInfo.TotalDamage.ToString(),
					DPSInfo.GetDPSValue().ToString(),
					DPSInfo.GetDPHValue().ToString(),
					Damage.ToString(),
					EffectID.ToString()
				};
				stringBuilder.AppendLine(string.Join(",", values));
			}
			else
			{
				stringBuilder.AppendLine("████████████████████████████████████████████████████████████████████████████");
				stringBuilder.AppendLine(" 基本信息 ----------------------------------------------------------------------------------------------");
				stringBuilder.AppendLine("\t测试基础配置");
				stringBuilder.AppendLine($"\t\t测试时间：{DPSInfo.TotalTime}秒");
				List<RoleDataConfigDesc> roleDataConfigByType2 = GameDBRuntime.GetRoleDataConfigByType(DPSInfo.PlayerRoleDataConfigID);
				if (roleDataConfigByType2 != null)
				{
					Dictionary<RoleDataConfigItemType, string> dictionary = new Dictionary<RoleDataConfigItemType, string>();
					foreach (RoleDataConfigDesc item in roleDataConfigByType2)
					{
						if (!dictionary.ContainsKey(item.ItemType))
						{
							dictionary.Add(item.ItemType, "");
						}
						if (item.ItemType == RoleDataConfigItemType.Level)
						{
							dictionary[item.ItemType] += $"{item.ItemNum}, ";
						}
						else
						{
							dictionary[item.ItemType] += $"{item.ItemId}, ";
						}
					}
					stringBuilder.AppendLine("\t主角配置预制信息");
					if (roleDataConfigByType2.Count > 0)
					{
						stringBuilder.AppendLine("\t\t预制名: " + roleDataConfigByType2[0].Desc);
					}
					foreach (KeyValuePair<RoleDataConfigItemType, string> item2 in dictionary)
					{
						stringBuilder.AppendLine($"\t\t{item2.Key}：{item2.Value}");
					}
				}
				stringBuilder.AppendLine("\t敌人基本信息");
				stringBuilder.AppendLine($"\t\tResID：{DPSInfo.DummyResID}");
				stringBuilder.AppendLine(" 伤害信息 ----------------------------------------------------------------------------------------------");
				stringBuilder.AppendLine($"\t总伤害：{DPSInfo.TotalDamage}");
				stringBuilder.AppendLine($"\tDPS：{DPSInfo.GetDPSValue()}");
				stringBuilder.AppendLine($"\tDPH：{DPSInfo.GetDPHValue()}");
				DPSInfo.GetMaxOneHitDamageInfo(out var EffectID2, out var Damage2);
				stringBuilder.AppendLine($"\t最高单次伤害：{Damage2} ( EffectID: {EffectID2} )");
				stringBuilder.AppendLine(" ResID伤害信息 ----------------------------------------------------------------------------------------");
				foreach (KeyValuePair<int, float> item3 in DPSInfo.ResIdDamageInfo)
				{
					stringBuilder.AppendLine($"\tResID：{item3.Key} \t\tDamage：{item3.Value}");
				}
				stringBuilder.AppendLine(" 特殊伤害信息 ------------------------------------------------------------------------------------------");
				foreach (KeyValuePair<string, float> item4 in DPSInfo.SpecialDamageInfo)
				{
					stringBuilder.AppendLine($"\t{item4.Key}：\t\t{item4.Value}");
				}
				stringBuilder.AppendLine("████████████████████████████████████████████████████████████████████████████");
			}
		}
		else
		{
			stringBuilder.AppendLine($"打桩失败，主角配置预制ID：{DPSInfo.PlayerRoleDataConfigID}");
		}
		return stringBuilder.ToString();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		if (TrainDummyMgrData.FinishedDPSInfos.Count != 0)
		{
			PrintResultToFile(IsCSV: true);
			PrintResultToFile(IsCSV: false);
		}
	}

	private void PrintResultToFile(bool IsCSV)
	{
		string text = (IsCSV ? "SandBagResult.csv" : "SandBagResult.txt");
		string path = FPaths.ProjectDir + "\\SandBagLogs\\" + text;
		string path2 = FPaths.ProjectDir + "\\SandBagLogs";
		if (!Directory.Exists(path2))
		{
			Directory.CreateDirectory(path2);
		}
		StreamWriter streamWriter = new StreamWriter(path, append: false, Encoding.UTF8);
		if (IsCSV)
		{
			streamWriter.WriteLine("预制套装,测试时间,总伤害,DPS,DPH,最高单次伤害,最高伤害的EffectID");
		}
		foreach (DPSCalculateInfo finishedDPSInfo in TrainDummyMgrData.FinishedDPSInfos)
		{
			streamWriter.Write(GetOutputDpsResultInfo(finishedDPSInfo, IsCSV));
		}
		streamWriter.Close();
	}

	private void InitPlayer()
	{
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner).GetControlledPawn();
		if (!(controlledPawn == null))
		{
			BUS_EventCollectionCS.Get(controlledPawn)?.Evt_TriggerTeleportResetPlayer.Invoke();
			if (GameDBRuntime.GetRoleDataConfigByType(TrainDummyMgrConfigData.PlayerRoleDataConfigID) != null)
			{
				BGUFunctionLibraryManaged.RunScriptGM($"ReInitRoleData {TrainDummyMgrConfigData.PlayerRoleDataConfigID}", Owner);
				TrainDummyMgrData.IsPlayerInit = true;
			}
		}
	}
}
