using System;
using System.Collections.Generic;
using System.Text;
using b1.BGW;
using b1.CppExport;
using b1.Localization;
using b1.Plugins.CustomLightSystem;
using BtlB1;
using BtlShare;
using CommB1;
using Diana.Common;
using GurGsPersistent;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGUFuncLibUpLoad : UBlueprintFunctionLibrary
{
	public static FUpLoad_TamerManagerInfo ConstructTamerData(UObject WorldContext, ACharacter Player)
	{
		FUpLoad_TamerManagerInfo result = new FUpLoad_TamerManagerInfo
		{
			TamerCountInfo = new Dictionary<string, int>()
		};
		BGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(WorldContext);
		if (gameStateReadonlyData != null)
		{
			if (gameStateReadonlyData.TamerStrategyMap.TryGetValue(ETamerType.LevelLoaded, out var value))
			{
				result.TamerCountInfo.Add("已创建Unit，种在场景里/关卡加载出来的Tamer数量", value.GetSpawnTamerCount());
			}
			if (gameStateReadonlyData.TamerStrategyMap.TryGetValue(ETamerType.Spawned, out var value2))
			{
				result.TamerCountInfo.Add("已创建Unit，普通动态创建的Tamer数量", value2.GetSpawnTamerCount());
			}
			if (gameStateReadonlyData.TamerStrategyMap.TryGetValue(ETamerType.Summoned, out var value3))
			{
				result.TamerCountInfo.Add("已创建Unit，通过召唤机制动态创建的Tamer数量", value3.GetSpawnTamerCount());
			}
			List<FUpLoad_TamerInfo> list = new List<FUpLoad_TamerInfo>();
			List<FUpLoad_TamerInfo> list2 = new List<FUpLoad_TamerInfo>();
			List<FUpLoad_TamerInfo> list3 = new List<FUpLoad_TamerInfo>();
			List<FUpLoad_TamerInfo> list4 = new List<FUpLoad_TamerInfo>();
			List<FUpLoad_DestroyTamerInfo> list5 = new List<FUpLoad_DestroyTamerInfo>();
			List<FUpLoad_UnitSpawnedTamerInfo> list6 = new List<FUpLoad_UnitSpawnedTamerInfo>();
			foreach (FTamerRef value4 in gameStateReadonlyData.UnitGuid2Tamer.Values)
			{
				if (value4.TamerType != ETamerType.LevelLoaded)
				{
					continue;
				}
				FUpLoad_TamerInfo item = new FUpLoad_TamerInfo
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
				list4.Add(item);
				if (value4.DelayDestroyTime > 0f)
				{
					FUpLoad_DestroyTamerInfo item2 = new FUpLoad_DestroyTamerInfo
					{
						RemainTime = value4.DelayDestroyTime.ToString("F2"),
						TamerGuid = value4.TamerGuid
					};
					list5.Add(item2);
				}
				if (value4.MonsterInstancePtr.Value != null)
				{
					list6.Add(new FUpLoad_UnitSpawnedTamerInfo
					{
						TamerGuid = item.TamerGuid,
						LevelName = item.LevelName,
						Phase = item.Phase,
						Distance = item.Distance,
						ZOffset = item.ZOffset,
						Visibility = item.Visibility,
						SpawnRule = item.SpawnRule,
						LODLevel = item.LODLevel,
						OriginLocation = item.OriginLocation,
						SpawnedMonsterInfo = ConstructMonsterData(Player, value4.MonsterInstancePtr.Value)
					});
					if (value4.TamerType == ETamerType.LevelLoaded)
					{
						list.Add(item);
					}
					else if (value4.TamerType == ETamerType.Spawned)
					{
						list2.Add(item);
					}
					else if (value4.TamerType == ETamerType.Summoned)
					{
						list2.Add(item);
					}
				}
				else
				{
					item.IsSpawnedUnit = false;
				}
			}
			result.AllTamers = list4.ToArray();
			result.DestroyTamers = list5.ToArray();
			result.UnitSpawnedTamers = list6.ToArray();
			result.LevelTamers = list.ToArray();
			result.SpawnedTamers = list2.ToArray();
			result.SummonTamers = list3.ToArray();
			result.TamerCountInfo.Add("全部Tamer数量", list4.Count);
			result.TamerCountInfo.Add("已经销毁Tamer数量", list5.Count);
			result.TamerCountInfo.Add("已经创建出Unit的Tamer数量", list6.Count);
		}
		return result;
	}

	public static FUpLoad_Monster ConstructMonsterData(AActor PlayerCharacter, BGUCharacterCS Monster)
	{
		FUpLoad_Monster result = default(FUpLoad_Monster);
		if (Monster == null || PlayerCharacter == null)
		{
			return result;
		}
		result.MonsterGuid = BGU_DataUtil.GetActorGuid(Monster);
		FUpLoad_MonsterDetailsInfo details = new FUpLoad_MonsterDetailsInfo
		{
			Distance = Monster.GetHorizontalDistanceTo(PlayerCharacter)
		};
		UnrealEngine.Runtime.FVector actorForwardVector = Monster.GetActorForwardVector();
		UnrealEngine.Runtime.FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(PlayerCharacter) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Monster);
		float angle = UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(actorForwardVector.GetSafeNormal2D(), fVector.GetSafeNormal2D());
		details.Angle = angle;
		string text = (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Monster, EBGUSimpleState.SkillSuperArmor) ? "激活" : "未激活");
		string text2 = BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.SkillSuperArmor).ToString();
		string text3 = BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.SkillSuperArmorMax).ToString();
		details.SkillSuperArmor = "(" + text + ")" + text2 + " / " + text3;
		IBUC_BeAttackData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>(Monster);
		if (readOnlyData != null)
		{
			details.BeAttackInfoID = $"{readOnlyData.GetCurrentBeAttackedInfoID()}";
		}
		IBUC_PartMgrData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_PartMgrData, BUC_PartMgrData>(Monster);
		if (readOnlyData2 != null)
		{
			details.PartRuleID = $"{readOnlyData2.PartRuleID}";
		}
		IBUC_DeadData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_DeadData, BUC_DeadData>(Monster);
		if (unPersistentReadOnlyData != null)
		{
			details.DeadInfoID = $"{unPersistentReadOnlyData.GetDeadInfoID()}";
		}
		IBUC_ArmorData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_ArmorData, BUC_ArmorData>(Monster);
		if (readOnlyData3 != null)
		{
			readOnlyData3.GetBlockCounterInfo(out var CurCount, out var PerfectBlockTime, out var TotalTimes, out var BlockCD, out var BlockResetTime);
			readOnlyData3.GetHitRecoverCounterInfo(out var CurCount2, out var TotalTimes2);
			if (BlockCD <= 0f)
			{
				details.BlockCount = $"当前: {CurCount} | 完美: {PerfectBlockTime} | 最大: {TotalTimes}";
			}
			else
			{
				details.BlockCount = $"In CD : {BlockCD}";
			}
			if (BlockResetTime > 0f)
			{
				details.BlockResetCount = $"倒计时：{BlockResetTime}";
			}
			else
			{
				details.BlockResetCount = "未计时";
			}
			string text4 = ((BGUFunctionLibraryCS.BGUHasUnitState(Monster, EBGUUnitState.BlockBeatBack) || BGUFunctionLibraryCS.BGUHasUnitState(Monster, EBGUUnitState.PerfectBlockBeatBack)) ? "激活" : "未激活");
			string text5 = BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.BlockCollapseArmor).ToString();
			string text6 = BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.BlockCollapseArmorMax).ToString();
			details.BlockBreaking = "(" + text4 + ")" + text5 + " / " + text6;
			details.StiffBackCount = $"{CurCount2} / {TotalTimes2}";
		}
		details.HP = $"{BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.Hp)} / {BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.HpMax)}";
		IBUC_ABPMotionMatchingData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPMotionMatchingData>(Monster);
		if (unPersistentReadOnlyData2 != null)
		{
			details.MMState = unPersistentReadOnlyData2.MotionMatchingState.ToString();
		}
		BUC_MovementModes unPersistentReadOnlyData3 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MovementModes>(Monster);
		if (Monster == PlayerCharacter)
		{
			details.MoveMode = "No Target";
		}
		else if (unPersistentReadOnlyData3 != null)
		{
			BUC_MoveModeBase activeMover = unPersistentReadOnlyData3.ActiveMover;
			if (activeMover != null)
			{
				string[] array = activeMover.ToString().Split('_');
				details.MoveMode = array[1];
			}
			else
			{
				details.MoveMode = "No ActiveMover";
			}
		}
		details.MovementMode = Monster.CharacterMovement.MovementMode.ToString("G");
		BUC_BattleStateData unPersistentReadOnlyData4 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BattleStateData>(Monster);
		if (unPersistentReadOnlyData4 != null)
		{
			if (unPersistentReadOnlyData4.IsUnitInBattle())
			{
				details.BattleState = "战斗中";
			}
			else
			{
				details.BattleState = "Not In Battle";
			}
		}
		details.BlindSlot = $"{BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.BlindSlot)} / {BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.BlindSlotMax)}";
		BUC_AbnormalStateHandlers unPersistentReadOnlyData5 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AbnormalStateHandlers>(Monster);
		if (unPersistentReadOnlyData5 != null)
		{
			details.IceAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.FreezeAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.FreezeAbnormalAccMax), unPersistentReadOnlyData5.AbnormalHanddler_Freeze.IsInFinalEffect() ? " 冰冻" : "");
			details.FireAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.BurnAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.BurnAbnormalAccMax), unPersistentReadOnlyData5.AbnormalHanddler_Burn.IsInFinalEffect() ? " 炎上" : "");
			details.PoisonAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.PoisonAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.PoisonAbnormalAccMax), unPersistentReadOnlyData5.AbnormalHanddler_Poison.IsInFinalEffect() ? " 中毒" : "");
			details.ThunderAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.ThunderAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.ThunderAbnormalAccMax), unPersistentReadOnlyData5.AbnormalHanddler_Thunder.IsInFinalEffect() ? " 麻痹" : "");
			details.YinAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.YinAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.YinAbnormalAccMax), unPersistentReadOnlyData5.AbnormalHanddler_Yin.IsInFinalEffect() ? " 阴状态" : "");
			details.YangAbnormal = string.Format("{0} / {1}{2}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.YangAbnormalAcc), BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.YangAbnormalAccMax), unPersistentReadOnlyData5.AbnormalHanddler_Yang.IsInFinalEffect() ? " 阳状态" : "");
			details.IceBreak = string.Format("{0}{1}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.FreezeDef), BGUFunctionLibraryCS.BGUHasUnitSimpleState(Monster, EBGUSimpleState.FreezeImmue) ? "  | 冰冻免疫" : "");
			details.FireBreak = string.Format("{0}{1}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.BurnDef), BGUFunctionLibraryCS.BGUHasUnitSimpleState(Monster, EBGUSimpleState.BurnImmue) ? "  | 灼烧免疫" : "");
			details.PoisonBreak = string.Format("{0}{1}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.PoisonDef), BGUFunctionLibraryCS.BGUHasUnitSimpleState(Monster, EBGUSimpleState.PoisonImmue) ? "  | 中毒免疫" : "");
			details.ThunderBreak = string.Format("{0}{1}", BGUFunctionLibraryCS.BGUGetFloatAttr(Monster, EBGUAttrFloat.ThunderDef), BGUFunctionLibraryCS.BGUHasUnitSimpleState(Monster, EBGUSimpleState.ThunderImmue) ? "  | 易伤免疫" : "");
		}
		IBUC_ChargeSkillData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<BUC_ChargeSkillData>(Monster);
		if (readOnlyData4 != null && readOnlyData4.IsCastingChargeSkill)
		{
			details.ChargeSkillPhase = $"{readOnlyData4.ChargeSkillStage}";
		}
		else
		{
			details.ChargeSkillPhase = "No ChargeSkill";
		}
		IBUC_EnvironmentInteractionMgrData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>(Monster);
		if (readOnlyData5 != null)
		{
			details.SurfaceType = readOnlyData5.ResultSurfaceType.ToString();
		}
		IBUC_SkillInstsData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(Monster);
		if (readOnlyData6 != null)
		{
			details.CurrentSkillID = readOnlyData6.CurrentCastingSkillID.ToString();
		}
		UAnimInstance animInstance = Monster.Mesh.GetAnimInstance();
		if (animInstance != null && animInstance.GetCurrentActiveMontage() != null)
		{
			details.CurrentPlayingMontage = animInstance.GetCurrentActiveMontage().GetName();
		}
		else
		{
			details.CurrentPlayingMontage = "None";
		}
		details.CurrentTeamID = Monster.GetTeamIDInCS().ToString();
		IBUC_UnitHatredData unPersistentReadOnlyData6 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UnitHatredData>(Monster);
		if (unPersistentReadOnlyData6 != null)
		{
			details.CurrentHatredTarget = $"当前有：{unPersistentReadOnlyData6.GetHatredTargetInfoList().Count} 个仇恨单位，其中玩家有：{unPersistentReadOnlyData6.GetPlayerHatredEntityList().Count} 个";
		}
		IBUC_TickRateData readOnlyData7 = BGU_DataUtil.GetReadOnlyData<IBUC_TickRateData, BUC_TickRateData>(Monster);
		if (readOnlyData7 != null)
		{
			details.UROState = readOnlyData7.bIsOptimizing;
		}
		IBUC_AINodeData unPersistentReadOnlyData7 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AINodeData>(Monster);
		if (unPersistentReadOnlyData7 != null)
		{
			details.CurrentAINode = unPersistentReadOnlyData7.ActionType;
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
			details.CurrentFsmState = stringBuilder.ToString();
		}
		IBUC_AIData unPersistentReadOnlyData9 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(Monster);
		if (unPersistentReadOnlyData9 != null)
		{
			details.CurrentFsmSolver = unPersistentReadOnlyData9.CurrentFsmSolverType.ToString();
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
			details.AITarget = func(readOnlyData8.GetTargetInfo());
			details.AOTarget = func(readOnlyData8.GetAOTarget());
			details.SkillBaseTarget = func(readOnlyData8.GetSkillBaseTarget());
			details.ComboTarget = func(readOnlyData8.GetComboTarget());
			details.MoveToTarget = func(readOnlyData8.GetMoveToTarget());
		}
		IBUC_StateLibData readOnlyData9 = BGU_DataUtil.GetReadOnlyData<IBUC_StateLibData, BUC_StateLibData>(Monster);
		details.CurrentStateLibBase = readOnlyData9.StateLibBaseDebugString;
		details.CurrentStateLibMod = readOnlyData9.StateLibModDebugString;
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(Monster.GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc != null)
		{
			details.CurrentOwningLevel = BGW_GameDB.GetActualLevelNumericalStrength(unitBattleInfoExtendDesc).ToString();
			details.CurrentHPFixedDM = unitBattleInfoExtendDesc.HPFixedDM.ToString();
			details.CurrentQualityType = unitBattleInfoExtendDesc.QualityType.ToString();
		}
		else
		{
			details.CurrentOwningLevel = "";
			details.CurrentHPFixedDM = "";
			details.CurrentQualityType = "";
		}
		result.Details = details;
		List<FUpLoad_SimpleState> list = new List<FUpLoad_SimpleState>();
		BUC_SimpleStateData readOnlyData10 = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(Monster);
		if (readOnlyData10 != null)
		{
			FUpLoad_SimpleState item = default(FUpLoad_SimpleState);
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
		List<FUpLoad_UnitState> list2 = new List<FUpLoad_UnitState>();
		BUC_UnitStateData readOnlyData11 = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Monster);
		if (readOnlyData11 != null)
		{
			FUpLoad_UnitState item2 = default(FUpLoad_UnitState);
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
		List<FUpLoad_Buff> list3 = new List<FUpLoad_Buff>();
		BUC_BuffData readOnlyData12 = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Monster);
		if (readOnlyData12 != null)
		{
			FUpLoad_Buff item3 = default(FUpLoad_Buff);
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
		List<FUpLoad_SkillInfo> list4 = new List<FUpLoad_SkillInfo>();
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
				FUpLoad_SkillInfo item4 = new FUpLoad_SkillInfo
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
		List<FUpLoad_PartInfo> list5 = new List<FUpLoad_PartInfo>();
		if (readOnlyData2 != null && readOnlyData2.GetAllPartInfo(out var PartInfoDataDic))
		{
			foreach (KeyValuePair<int, PartInfoData> item5 in PartInfoDataDic)
			{
				int key = item5.Key;
				PartInfoData value = item5.Value;
				list5.Add(new FUpLoad_PartInfo
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

	public static FUpLoad_LightInfo ConstructLightData(UObject WorldContext)
	{
		FUpLoad_LightInfo result = default(FUpLoad_LightInfo);
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
			List<FUpLoad_LightVolumeInfo> list = new List<FUpLoad_LightVolumeInfo>();
			foreach (FCLSVolumeWatchData volumeDatum in fCLSWatchData.VolumeData)
			{
				if (volumeDatum.Valid)
				{
					FUpLoad_LightVolumeInfo item = new FUpLoad_LightVolumeInfo
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

	private static void UpdateLightCategoryData(ref FCLSCategoryWatchData CppData, ref FUpLoad_LightInfoWithCategory CsData)
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

	private static void UpdatePlayerLightData(ref FCLSPlayerLightWatchData CppData, ref FUpLoad_CharacterLightInfo CsData)
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

	private static void UpdatePointLightData(ref FCLSPlayerLightDataBase CppData, ref FUpLoad_PointLightInfo CsData)
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

	public static FUpLoad_ActorDebugInfo ConstructAllActorDebugInfo(UObject WorldContext)
	{
		FUpLoad_ActorDebugInfo result = default(FUpLoad_ActorDebugInfo);
		List<FUpLoad_SceneObjectInfo> SceneObjActorInfos = new List<FUpLoad_SceneObjectInfo>();
		List<FUpLoad_SceneObjectInfo> DynamicObstacleInfos = new List<FUpLoad_SceneObjectInfo>();
		List<FUpLoad_OverlapBoxDebugInfo> OverlapBoxDebugInfos = new List<FUpLoad_OverlapBoxDebugInfo>();
		List<FUpLoad_SceneObjectInfo> SpawnWavesDebugInfos = new List<FUpLoad_SceneObjectInfo>();
		List<FUpLoad_InteractorDebugInfo> InteractorDebugInfos = new List<FUpLoad_InteractorDebugInfo>();
		List<FUpLoad_WorldActorDebugInfo> list = new List<FUpLoad_WorldActorDebugInfo>();
		IBIC_StateMachineData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_StateMachineData, BIC_StateMachineData>(WorldContext);
		IBIC_TaskData gameInstanceReadonlyData2 = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(WorldContext);
		BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(WorldContext).GetAllInteractorSet(out var OutInteractorSet);
		gameInstanceReadonlyData.GetAllSceneObjState(out var OutSceneObjState);
		gameInstanceReadonlyData.GetAllSceneObjTransientState(out var OutSceneObjTransientState);
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
			ConstructSingleActorInfo(WorldContext, gameInstanceReadonlyData2, key, value, OutInteractorSet, ref SceneObjActorInfos, bRefreshDynamicObstacleActor: true, ref DynamicObstacleInfos, bRefreshOverlapBox: true, ref OverlapBoxDebugInfos, bRefreshSpawnWaves: true, ref SpawnWavesDebugInfos, bRefreshInteractor: true, ref InteractorDebugInfos);
		}
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<AActor>(WorldContext);
		foreach (AActor aActor in allActorsOfClass)
		{
			if (!aActor.IsNullOrDestroyed())
			{
				FUpLoad_WorldActorDebugInfo item = new FUpLoad_WorldActorDebugInfo
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
		result.OtherSceneObjActors = SceneObjActorInfos.ToArray();
		result.DynamicObstacleInfos = DynamicObstacleInfos.ToArray();
		result.OverlapBoxDebugInfos = OverlapBoxDebugInfos.ToArray();
		result.SpawnWavesDebugInfos = SpawnWavesDebugInfos.ToArray();
		result.InteractorDebugInfos = InteractorDebugInfos.ToArray();
		result.WorldActorDebugInfos = list.ToArray();
		return result;
	}

	private static void ConstructSingleActorInfo(UObject WorldContext, IBIC_TaskData TaskData, string ActorGuid, GameplayTagContainerRef StateTagContainer, HashSet<string> AllInteractorSet, ref List<FUpLoad_SceneObjectInfo> SceneObjActorInfos, bool bRefreshDynamicObstacleActor, ref List<FUpLoad_SceneObjectInfo> DynamicObstacleInfos, bool bRefreshOverlapBox, ref List<FUpLoad_OverlapBoxDebugInfo> OverlapBoxDebugInfos, bool bRefreshSpawnWaves, ref List<FUpLoad_SceneObjectInfo> SpawnWavesDebugInfos, bool bRefreshInteractor, ref List<FUpLoad_InteractorDebugInfo> InteractorDebugInfos)
	{
		if (StateTagContainer == null)
		{
			return;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(WorldContext, ActorGuid);
		if (actorByGuid.IsNullOrDestroyed())
		{
			return;
		}
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		if (bRefreshDynamicObstacleActor)
		{
			flag = StateTagContainer.HasTag(BGW_FlowUtils.SceneObjTag.DynamicObstacle, bExactMatch: false);
			if (flag)
			{
				FUpLoad_SceneObjectInfo fUpLoad_SceneObjectInfo = new FUpLoad_SceneObjectInfo
				{
					ActorGuid = ActorGuid,
					AliasName = actorByGuid.GetActorLabel(),
					ActorIDName = actorByGuid.GetName(),
					ActorLevel = actorByGuid.GetOuter()?.GetOuter()?.GetName(),
					ActorClass = actorByGuid.GetClass()?.GetName(),
					ActorLocation = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorLocation()),
					ActorRotation = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorRotation()),
					ActorScale = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorScale3D()),
					bHiddenInGame = actorByGuid.Hidden
				};
				if (StateTagContainer.HasTag(BGW_FlowUtils.DynamicObstacleTag.State_Enabled))
				{
					fUpLoad_SceneObjectInfo.State = "State_Enabled";
				}
				if (StateTagContainer.HasTag(BGW_FlowUtils.DynamicObstacleTag.State_EnabledToDisable))
				{
					fUpLoad_SceneObjectInfo.State = "State_EnabledToDisable";
				}
				if (StateTagContainer.HasTag(BGW_FlowUtils.DynamicObstacleTag.State_Disabled))
				{
					fUpLoad_SceneObjectInfo.State = "State_Disabled";
				}
				if (StateTagContainer.HasTag(BGW_FlowUtils.DynamicObstacleTag.State_DisabledToEnabled))
				{
					fUpLoad_SceneObjectInfo.State = "State_DisabledToEnabled";
				}
				SceneObjActorInfos.Add(fUpLoad_SceneObjectInfo);
				DynamicObstacleInfos.Add(fUpLoad_SceneObjectInfo);
			}
		}
		if (bRefreshOverlapBox)
		{
			flag2 = StateTagContainer.HasTag(BGW_FlowUtils.SceneObjTag.OverlapBox, bExactMatch: false);
			if (flag2)
			{
				FUpLoad_OverlapBoxDebugInfo fUpLoad_OverlapBoxDebugInfo = new FUpLoad_OverlapBoxDebugInfo
				{
					ActorGuid = ActorGuid,
					AliasName = actorByGuid.GetActorLabel(),
					ActorIDName = actorByGuid.GetName(),
					ActorLevel = actorByGuid.GetOuter()?.GetOuter()?.GetName(),
					ActorClass = actorByGuid.GetClass()?.GetName(),
					ActorLocation = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorLocation()),
					ActorRotation = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorRotation()),
					ActorScale = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorScale3D()),
					bHiddenInGame = actorByGuid.Hidden
				};
				if (StateTagContainer.HasTag(BGW_FlowUtils.OverlapTag.State_Enabled))
				{
					fUpLoad_OverlapBoxDebugInfo.State = "State_Enabled";
				}
				if (StateTagContainer.HasTag(BGW_FlowUtils.OverlapTag.State_Disabled))
				{
					fUpLoad_OverlapBoxDebugInfo.State = "State_Disabled";
				}
				if (TaskData.IsPlayerInOverlap(ActorGuid, out var bInnerOverlap))
				{
					fUpLoad_OverlapBoxDebugInfo.bInner = bInnerOverlap;
				}
				SceneObjActorInfos.Add(fUpLoad_OverlapBoxDebugInfo);
				OverlapBoxDebugInfos.Add(fUpLoad_OverlapBoxDebugInfo);
			}
		}
		if (bRefreshSpawnWaves)
		{
			flag3 = StateTagContainer.HasTag(BGW_FlowUtils.SceneObjTag.Spawner, bExactMatch: false);
			if (flag3)
			{
				FUpLoad_SceneObjectInfo fUpLoad_SceneObjectInfo2 = new FUpLoad_SceneObjectInfo
				{
					ActorGuid = ActorGuid,
					AliasName = actorByGuid.GetActorLabel(),
					ActorIDName = actorByGuid.GetName(),
					ActorLevel = actorByGuid.GetOuter()?.GetOuter()?.GetName(),
					ActorClass = actorByGuid.GetClass()?.GetName(),
					ActorLocation = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorLocation()),
					ActorRotation = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorRotation()),
					ActorScale = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorScale3D()),
					bHiddenInGame = actorByGuid.Hidden
				};
				if (StateTagContainer.HasTag(BGW_FlowUtils.SpawnerTag.State_Disabled))
				{
					fUpLoad_SceneObjectInfo2.State = "State_Disabled";
				}
				if (StateTagContainer.HasTag(BGW_FlowUtils.SpawnerTag.State_Idled))
				{
					fUpLoad_SceneObjectInfo2.State = "State_Idled";
				}
				if (StateTagContainer.HasTag(BGW_FlowUtils.SpawnerTag.State_Spawned))
				{
					fUpLoad_SceneObjectInfo2.State = "State_Spawned";
				}
				if (StateTagContainer.HasTag(BGW_FlowUtils.SpawnerTag.State_Cleared))
				{
					fUpLoad_SceneObjectInfo2.State = "State_Cleared";
				}
				SceneObjActorInfos.Add(fUpLoad_SceneObjectInfo2);
				SpawnWavesDebugInfos.Add(fUpLoad_SceneObjectInfo2);
			}
		}
		if (bRefreshInteractor)
		{
			flag4 = AllInteractorSet.Contains(ActorGuid);
			if (flag4)
			{
				FUpLoad_InteractorDebugInfo fUpLoad_InteractorDebugInfo = new FUpLoad_InteractorDebugInfo
				{
					ActorGuid = ActorGuid,
					AliasName = actorByGuid.GetActorLabel(),
					ActorIDName = actorByGuid.GetName(),
					ActorLevel = actorByGuid.GetOuter()?.GetOuter()?.GetName(),
					ActorClass = actorByGuid.GetClass()?.GetName(),
					ActorLocation = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorLocation()),
					ActorRotation = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorRotation()),
					ActorScale = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorScale3D()),
					bHiddenInGame = actorByGuid.Hidden
				};
				IBUC_InteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_InteractData, BUC_InteractData>(actorByGuid);
				PersistentBUCData Ret;
				if (readOnlyData != null)
				{
					fUpLoad_InteractorDebugInfo.InteractorID = readOnlyData.InteractiveUnitID;
					fUpLoad_InteractorDebugInfo.State = readOnlyData.InteractUnitState.ToString("G");
					fUpLoad_InteractorDebugInfo.DefaultGroupID = readOnlyData.DefalutInteractiveGroupID;
					fUpLoad_InteractorDebugInfo.CurrentGroupID = readOnlyData.ActionGroupID;
					fUpLoad_InteractorDebugInfo.bInteracting = readOnlyData.bIsInteracting;
					fUpLoad_InteractorDebugInfo.RemainInteractTime = readOnlyData.RemainingInteractTime;
					fUpLoad_InteractorDebugInfo.CameraBlendOutTime = readOnlyData.BlendOutTimer;
					fUpLoad_InteractorDebugInfo.LimitReason = readOnlyData.InteractConstraint.ToString("G");
				}
				else if (BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_PersistentECSData, BIC_PersistentECSData>(WorldContext).FindOrAllocBUCDataByGuid(ActorGuid, out Ret))
				{
					GurGsPersistent.BUC_InteractData bUCInteractData = Ret.BUCInteractData;
					if (bUCInteractData != null)
					{
						fUpLoad_InteractorDebugInfo.State = bUCInteractData.InteractUnitStatePersistent.ToString("G");
						fUpLoad_InteractorDebugInfo.CurrentGroupID = bUCInteractData.ActionGroupIDPersistent;
					}
				}
				SceneObjActorInfos.Add(fUpLoad_InteractorDebugInfo);
				InteractorDebugInfos.Add(fUpLoad_InteractorDebugInfo);
			}
		}
		if (!flag && !flag2 && !flag3 && !flag4)
		{
			new FUpLoad_SceneObjectInfo
			{
				ActorGuid = ActorGuid,
				AliasName = actorByGuid.GetActorLabel(),
				ActorIDName = actorByGuid.GetName(),
				ActorLevel = actorByGuid.GetOuter()?.GetOuter()?.GetName(),
				ActorClass = actorByGuid.GetClass()?.GetName(),
				ActorLocation = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorLocation()),
				ActorRotation = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorRotation()),
				ActorScale = BGWCheatManageExtensions.ToNetStruct(actorByGuid.GetActorScale3D()),
				bHiddenInGame = actorByGuid.Hidden,
				State = StateTagContainer.ToString()
			};
		}
	}

	public static FUpLoad_LevelInfo ConstructLevelInfoData(UObject WorldContext)
	{
		FUpLoad_LevelInfo result = default(FUpLoad_LevelInfo);
		List<FUpLoad_BirthPoint> list = new List<FUpLoad_BirthPoint>();
		BGURebirthPointBase[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGURebirthPointBase>(WorldContext);
		foreach (BGURebirthPointBase bGURebirthPointBase in allActorsOfClass)
		{
			FUpLoad_BirthPoint item = default(FUpLoad_BirthPoint);
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
		b1.BUBirthPoint[] allActorsOfClass2 = UGameplayStatics.GetAllActorsOfClass<b1.BUBirthPoint>(WorldContext);
		foreach (b1.BUBirthPoint bUBirthPoint in allActorsOfClass2)
		{
			FUpLoad_BirthPoint item2 = new FUpLoad_BirthPoint
			{
				BirthPointName = $"{bUBirthPoint.BirthPointID}",
				BirthPointType = "出生点"
			};
			UnrealEngine.Runtime.FVector actorLocation = bUBirthPoint.GetActorLocation();
			UnrealEngine.Runtime.FRotator actorRotation = bUBirthPoint.GetActorRotation();
			item2.BirthPointTransform = $"X={actorLocation.X},Y={actorLocation.Y},Z={actorLocation.Z} P={actorRotation.Pitch},Y={actorRotation.Yaw},R={actorRotation.Roll}";
			list.Add(item2);
		}
		result.BirthPoints = list.ToArray();
		List<FUpLoad_SubLevelInfo> list2 = new List<FUpLoad_SubLevelInfo>();
		UBGUWCStreamingFuncLib.GetAllLevelCurrentState(WorldContext, out var OutLevelStreamingList);
		foreach (KeyValuePair<string, byte> item4 in OutLevelStreamingList)
		{
			FUpLoad_SubLevelInfo item3 = new FUpLoad_SubLevelInfo
			{
				Name = item4.Key,
				CurrentState = ((BGW_LevelStreamingManger.GSLevelCurrentState)item4.Value/*cast due to .constrained prefix*/).ToString()
			};
			list2.Add(item3);
		}
		result.SubLevelInfos = list2.ToArray();
		return result;
	}

	public static FUpLoad_RoleData ConstructRoleData(APlayerController PlayerController)
	{
		FUpLoad_RoleData result = default(FUpLoad_RoleData);
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(PlayerController);
		if (readOnlyData != null && readOnlyData.RoleData != null && readOnlyData.RoleData.RoleCs != null && readOnlyData.RoleData.RoleCs.Task != null && readOnlyData.RoleData.RoleCs.Task.QuestList != null)
		{
			ReadOnlyQuestStageOneList questList = readOnlyData.RoleData.RoleCs.Task.QuestList;
			if (questList != null)
			{
				List<FUpLoad_TaskStage> list = new List<FUpLoad_TaskStage>();
				foreach (ReadOnlyQuestStageOne item2 in questList)
				{
					FUpLoad_TaskStage item = new FUpLoad_TaskStage
					{
						StageID = item2.Id,
						Describe = BGW_GameDB.GetTaskStageDesc(item2.Id).Describe
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
				list.Sort((FUpLoad_TaskStage StageA, FUpLoad_TaskStage StageB) => StageA.StageID - StageB.StageID);
				result.TaskStages = list.ToArray();
			}
		}
		return result;
	}

	public static FUpLoad_GameData ConstructGameData(UObject WorldContex)
	{
		FUpLoad_GameData result = default(FUpLoad_GameData);
		BGC_MovieData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_MovieData>(WorldContex);
		if (gameStateReadonlyData != null)
		{
			List<FUpLoad_Movie> list = new List<FUpLoad_Movie>();
			foreach (KeyValuePair<int, TStrongObjectPtr<MovieInstance>> movieInstance2 in gameStateReadonlyData.MovieInstances)
			{
				MovieInstance movieInstance = movieInstance2.Value.Get();
				FUpLoad_Movie item = new FUpLoad_Movie
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
}
