using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using BtlShare;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_B1TargetFuncs
{
	public delegate AActor SkillBaseTargetFunc(AActor CasterActor, out FVector OutTargetPos, out FVector OutAim2TargetDir, int Param1, int Param2, string StrParam, out bool ValidTarget);

	public delegate AActor EffectBaseTargetFunc(AActor CasterActor, AActor InnerTarget, out FVector OutTargetPos, out FVector OutAim2TargetDir);

	public static SkillBaseTargetFunc[] SkillBaseTargetFuncs;

	public static EffectBaseTargetFunc[] EffectBaseTargetFuncs;

	static BGU_B1TargetFuncs()
	{
		SkillBaseTargetFuncs = new SkillBaseTargetFunc[50];
		EffectBaseTargetFuncs = new EffectBaseTargetFunc[50];
		EffectBaseTargetFuncs[2] = EffectSelectBaseTarget_Master;
		EffectBaseTargetFuncs[0] = EffectSelectBaseTarget_Self;
		EffectBaseTargetFuncs[1] = EffectSelectBaseTarget_Target;
		EffectBaseTargetFuncs[3] = EffectSelectBaseTarget_RootMaster;
		SkillBaseTargetFuncs[0] = SkillSelectBaseTarget_NoneOrCurrenttarget;
		SkillBaseTargetFuncs[1] = SkillSelectBaseTarget_Self;
		SkillBaseTargetFuncs[2] = SkillSelectBaseTarget_Master;
		SkillBaseTargetFuncs[3] = SkillSelectBaseTarget_NearlySpecialUnitByResID;
		SkillBaseTargetFuncs[4] = SkillSelectBaseTarget_Player;
		SkillBaseTargetFuncs[5] = SkillSelectBaseTarget_SceneItem;
		SkillBaseTargetFuncs[6] = SkillSelectBaseTarget_EQSPoint;
		SkillBaseTargetFuncs[7] = SkillSelectBaseTarget_MasterTarget;
	}

	private static void FillTargetDirAndPos(AActor CasterActor, AActor BaseTargetActor, ref FVector TargetPos, ref FVector TargetDir)
	{
		if (!(CasterActor == null) && !(BaseTargetActor == null))
		{
			TargetPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(BaseTargetActor);
			TargetDir = TargetPos - BGUFuncLibActorTransformCS.BGUGetActorLocation(CasterActor);
			TargetDir.GetSafeNormal();
		}
	}

	private static bool CheckUnitHasValidTypeFilter(AActor CasterActor, AActor CheckerActor, int TargetFilter, int TargetTypeFilter, int AffiliationFilter)
	{
		if (CasterActor != null && CheckerActor != null && BGUFuncLibSelectTargetsCS.BGUIsSelectTargetByTeamFilter(CasterActor, CheckerActor, TargetFilter) && BGUFuncLibSelectTargetsCS.BGUIsSelectTargetByTypeFilter(CheckerActor, TargetTypeFilter) && BGUFuncLibSelectTargetsCS.BGUIsSelectTargetByAffiliationFilter(CasterActor, CheckerActor, AffiliationFilter))
		{
			return true;
		}
		return false;
	}

	private static AActor SelectTargetTemplate_Self(AActor CasterActor)
	{
		AActor result = null;
		if (CasterActor != null)
		{
			result = CasterActor;
		}
		return result;
	}

	private static AActor SelectTargetTemplate_Target(AActor CasterActor)
	{
		AActor result = null;
		if (CasterActor != null)
		{
			result = BGUFunctionLibraryCS.BGUGetTarget(CasterActor);
		}
		return result;
	}

	private static AActor SelectTargetTemplate_Master(AActor CasterActor)
	{
		AActor result = null;
		if (CasterActor != null)
		{
			IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(CasterActor);
			if (readOnlyData != null)
			{
				AActor masterActor = readOnlyData.GetMasterActor();
				result = ((!(masterActor != null)) ? CasterActor : masterActor);
			}
		}
		return result;
	}

	private static AActor SelectTargetTemplate_MasterTarget(AActor CasterActor)
	{
		AActor unit = null;
		if (CasterActor != null)
		{
			IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(CasterActor);
			if (readOnlyData != null)
			{
				AActor masterActor = readOnlyData.GetMasterActor();
				unit = ((!(masterActor != null)) ? CasterActor : masterActor);
			}
		}
		return BGUFunctionLibraryCS.BGUGetTarget(unit);
	}

	private static AActor SelectTargetTemplate_RootMaster(AActor CasterActor)
	{
		AActor result = null;
		if (CasterActor != null)
		{
			AActor rootMasterActor = GetRootMasterActor(CasterActor);
			result = ((!(rootMasterActor != null)) ? CasterActor : rootMasterActor);
		}
		return result;
	}

	private static AActor GetRootMasterActor(AActor Unit)
	{
		AActor aActor = Unit;
		AActor aActor2 = null;
		bool flag = false;
		while (!flag)
		{
			aActor2 = GetMasterActor(aActor);
			if (aActor2 == null)
			{
				break;
			}
			if (aActor2 == aActor)
			{
				flag = true;
			}
			else
			{
				aActor = aActor2;
			}
		}
		return aActor2;
	}

	private static AActor GetMasterActor(AActor Unit)
	{
		AActor result = null;
		IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Unit);
		if (readOnlyData != null)
		{
			result = readOnlyData.GetMasterActor();
		}
		return result;
	}

	private static AActor EffectSelectBaseTarget_Master(AActor CasterActor, AActor InnerTarget, out FVector OutTargetPos, out FVector OutAim2TargetDir)
	{
		OutTargetPos = FVector.ZeroVector;
		OutAim2TargetDir = FVector.ZeroVector;
		AActor aActor = null;
		if (CasterActor != null)
		{
			aActor = SelectTargetTemplate_Master(CasterActor);
			FillTargetDirAndPos(CasterActor, aActor, ref OutTargetPos, ref OutAim2TargetDir);
		}
		return aActor;
	}

	private static AActor EffectSelectBaseTarget_Self(AActor CasterActor, AActor InnerTarget, out FVector OutTargetPos, out FVector OutAim2TargetDir)
	{
		OutTargetPos = FVector.ZeroVector;
		OutAim2TargetDir = FVector.ZeroVector;
		AActor aActor = null;
		if (CasterActor != null)
		{
			aActor = SelectTargetTemplate_Self(CasterActor);
			FillTargetDirAndPos(CasterActor, aActor, ref OutTargetPos, ref OutAim2TargetDir);
		}
		return aActor;
	}

	private static AActor EffectSelectBaseTarget_Target(AActor CasterActor, AActor InnerTarget, out FVector OutTargetPos, out FVector OutAim2TargetDir)
	{
		OutTargetPos = FVector.ZeroVector;
		OutAim2TargetDir = FVector.ZeroVector;
		AActor aActor = null;
		if (CasterActor != null)
		{
			if (InnerTarget.IsNullOrDestroyed())
			{
				AActor aActor2 = null;
				if (CasterActor as BGUCharacterCS == null)
				{
					IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(CasterActor);
					if (readOnlyData != null)
					{
						AActor masterActor = readOnlyData.GetMasterActor();
						if (masterActor != null)
						{
							aActor2 = masterActor;
						}
					}
				}
				if (aActor2 == null)
				{
					aActor2 = CasterActor;
				}
				aActor = SelectTargetTemplate_Target(aActor2);
			}
			else
			{
				aActor = InnerTarget;
			}
			FillTargetDirAndPos(CasterActor, aActor, ref OutTargetPos, ref OutAim2TargetDir);
		}
		return aActor;
	}

	private static AActor EffectSelectBaseTarget_RootMaster(AActor CasterActor, AActor InnerTarget, out FVector OutTargetPos, out FVector OutAim2TargetDir)
	{
		OutTargetPos = FVector.ZeroVector;
		OutAim2TargetDir = FVector.ZeroVector;
		AActor aActor = null;
		if (CasterActor != null)
		{
			aActor = SelectTargetTemplate_RootMaster(CasterActor);
			FillTargetDirAndPos(CasterActor, aActor, ref OutTargetPos, ref OutAim2TargetDir);
		}
		return aActor;
	}

	public static List<AActor> EffectSelectRangeTarget(AActor CasterActor, AActor BaseTargetActor, int EffectID, in FEffectInstReq EffectInstReq)
	{
		List<AActor> result = new List<AActor>();
		if (CasterActor != null)
		{
			FUStSkillEffectDesc SkillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, CasterActor);
			if (SkillEffectDesc != null)
			{
				result = SkillEffectDesc.Range.RangeType switch
				{
					ERangeType.TargetBaseObj => EffectSelectRangeTarget_TargetBaseObj(CasterActor, BaseTargetActor, in SkillEffectDesc), 
					ERangeType.MultiTargetTurn => CommonSelectRangeTarget_MultiTargetTurn(CasterActor, SkillEffectDesc.TargetCount, SkillEffectDesc.TargetFilter, SkillEffectDesc.TargetTypeFilter, SkillEffectDesc.AffiliationTypeFilter), 
					ERangeType.FamilyTarget => EffectSelectRangeTarget_GroupFamilyTarget(CasterActor, BaseTargetActor, in SkillEffectDesc), 
					_ => CommonSelectRangeTarget_ByShape(CasterActor, BaseTargetActor, SkillEffectDesc.Range.RangeCenterType, SkillEffectDesc.Range.RangeType, (IList<int>)SkillEffectDesc.Range.RangeParam, SkillEffectDesc.TargetCount, SkillEffectDesc.TargetFilter, SkillEffectDesc.TargetTypeFilter, SkillEffectDesc.AffiliationTypeFilter, in EffectInstReq), 
				};
			}
		}
		return result;
	}

	private static List<AActor> EffectSelectRangeTarget_TargetBaseObj(AActor CasterActor, AActor BaseTargetActor, in FUStSkillEffectDesc SkillEffectDesc)
	{
		List<AActor> list = new List<AActor>();
		if (CasterActor != null && BaseTargetActor != null && CheckUnitHasValidTypeFilter(CasterActor, BaseTargetActor, SkillEffectDesc.TargetFilter, SkillEffectDesc.TargetTypeFilter, SkillEffectDesc.AffiliationTypeFilter))
		{
			list.Add(BaseTargetActor);
		}
		return list;
	}

	private static List<AActor> EffectSelectRangeTarget_GroupFamilyTarget(AActor CasterActor, AActor BaseTargetActor, in FUStSkillEffectDesc SkillEffectDesc)
	{
		List<AActor> list = new List<AActor>();
		if (CasterActor != null && BaseTargetActor != null)
		{
			BGC_CircusControlData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_CircusControlData>(UGameplayStatics.GetGameState(CasterActor));
			if (readOnlyData != null)
			{
				List<AActor> CharacterList = new List<AActor>();
				readOnlyData.TravelCircus(CasterActor, delegate(CircusMember Node)
				{
					AActor actorByGuid = BGU_DataUtil.GetActorByGuid(CasterActor, Node.ActorGuid);
					if (actorByGuid != null)
					{
						CharacterList.Add(actorByGuid);
					}
				});
				List<AActor> list2 = new List<AActor>();
				foreach (AActor item in CharacterList)
				{
					BUC_BuffData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(item);
					if (readOnlyData2 != null)
					{
						bool flag = true;
						if (SkillEffectDesc.Range.RangeParam.Count > 1)
						{
							flag = ((!readOnlyData2.HasBuff(SkillEffectDesc.Range.RangeParam[0])) ? (SkillEffectDesc.Range.RangeParam[1] == 0) : (SkillEffectDesc.Range.RangeParam[1] == 1));
						}
						if (flag && CasterActor != item)
						{
							list2.Add(item);
						}
					}
				}
				if (list2.Count > 0)
				{
					Random Rand = new Random();
					int num = Rand.Next(0, list2.Count);
					list.Add(list2[num]);
					if (SkillEffectDesc.TargetCount > 1)
					{
						List<int> list3 = new List<int>();
						list3.Add(num);
						if (list2.Count >= SkillEffectDesc.TargetCount + 2)
						{
							list3.Add((num != list2.Count - 1) ? (num + 1) : 0);
							list3.Add((num == 0) ? (list2.Count - 1) : (num - 1));
						}
						list3.Sort((int x, int y) => y.CompareTo(x));
						foreach (int item2 in list3)
						{
							list2.RemoveAt(item2);
						}
						List<AActor> list4 = list2.OrderBy((AActor x) => Rand.Next()).ToList();
						int num2 = 1;
						foreach (AActor item3 in list4)
						{
							list.Add(item3);
							num2++;
							if (num2 >= SkillEffectDesc.TargetCount)
							{
								break;
							}
						}
					}
				}
			}
		}
		return list;
	}

	public static List<AActor> BuffSelectRangeTarget(AActor OwnerActor, AActor TargetBaseActor, in BuffDescRuntime BuffDesc, in FEffectInstReq EffectInstReq, EBuffEffectTargetSelectType SelectType)
	{
		List<AActor> list = new List<AActor>();
		if (OwnerActor != null)
		{
			if (BuffDesc.GetRangeType() == ERangeType.TargetBaseObj)
			{
				if (SelectType == EBuffEffectTargetSelectType.BuffTarget || SelectType == EBuffEffectTargetSelectType.Both)
				{
					list.Add(TargetBaseActor);
				}
				if ((SelectType == EBuffEffectTargetSelectType.BuffOwner || SelectType == EBuffEffectTargetSelectType.Both) && TargetBaseActor != OwnerActor)
				{
					list.Add(OwnerActor);
				}
			}
			else
			{
				List<AActor> list2 = CommonSelectRangeTarget_ByShape(OwnerActor, TargetBaseActor, BuffDesc.GetRangeCenterType(), BuffDesc.GetRangeType(), BuffDesc.GetRangeParamList(), BuffDesc.GetTargetCount(), BuffDesc.GetTargetFilter(), BuffDesc.GetTargetTypeFilter(), BuffDesc.GetAffiliationTypeFilter(), in EffectInstReq);
				bool flag = false;
				if (SelectType == EBuffEffectTargetSelectType.BuffTarget || SelectType == EBuffEffectTargetSelectType.Both)
				{
					foreach (AActor item in list2)
					{
						if (item != null)
						{
							list.Add(item);
							flag |= item == OwnerActor;
						}
					}
				}
				if ((SelectType == EBuffEffectTargetSelectType.BuffOwner || SelectType == EBuffEffectTargetSelectType.Both) && !flag)
				{
					list.Add(OwnerActor);
				}
			}
		}
		return list;
	}

	private static List<AActor> CommonSelectRangeTarget_MultiTargetTurn(AActor CasterActor, int TargetCount, int TargetFilter, int TargetTypeFilter, int AffiliationFilter)
	{
		List<AActor> list = new List<AActor>();
		if (CasterActor != null)
		{
			IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_TargetInfoData>(CasterActor);
			if (readOnlyData != null)
			{
				foreach (UnitLockTargetInfo multiTargetInfo in readOnlyData.GetMultiTargetInfoList())
				{
					AActor lockTargetActor = multiTargetInfo.LockTargetActor;
					if (!(lockTargetActor == null))
					{
						if (list.Count >= TargetCount)
						{
							break;
						}
						if (CheckUnitHasValidTypeFilter(CasterActor, lockTargetActor, TargetFilter, TargetTypeFilter, AffiliationFilter))
						{
							list.Add(lockTargetActor);
						}
					}
				}
			}
		}
		return list;
	}

	private static List<AActor> CommonSelectRangeTarget_ByShape(AActor CasterActor, AActor BaseTargetActor, in EEffectRangeCenterType RangeCenterType, in ERangeType RangeType, in IList<int> RangeParamList, int TargetCount, int TargetFilter, int TargetTypeFilter, int AffiliationFilter, in FEffectInstReq EffectInstReq)
	{
		List<AActor> OutActors = new List<AActor>();
		if (CasterActor != null && BaseTargetActor != null)
		{
			FVector baseLoc = BGUFuncLibActorTransformCS.BGUGetActorLocation(BaseTargetActor);
			if (RangeCenterType == EEffectRangeCenterType.HitPosition)
			{
				baseLoc = EffectInstReq.HitLocation;
			}
			BGUFuncLibSelectTargetsCS.BGUSelectTargetsInShape(CasterActor, out OutActors, BaseTargetActor, baseLoc, RangeType, TargetCount, TargetFilter, TargetTypeFilter, AffiliationFilter, in RangeParamList);
		}
		return OutActors;
	}

	private static AActor SkillSelectBaseTarget_NoneOrCurrenttarget(AActor CasterActor, out FVector OutTargetPos, out FVector OutAim2TargetDir, int Param1, int Param2, string StrParam, out bool ValidTarget)
	{
		OutTargetPos = FVector.ZeroVector;
		OutAim2TargetDir = FVector.ZeroVector;
		AActor aActor = null;
		if (CasterActor != null)
		{
			aActor = SelectTargetTemplate_Target(CasterActor);
			FillTargetDirAndPos(CasterActor, aActor, ref OutTargetPos, ref OutAim2TargetDir);
		}
		ValidTarget = aActor != null;
		return aActor;
	}

	private static AActor SkillSelectBaseTarget_Self(AActor CasterActor, out FVector OutTargetPos, out FVector OutAim2TargetDir, int Param1, int Param2, string StrParam, out bool ValidTarget)
	{
		OutTargetPos = FVector.ZeroVector;
		OutAim2TargetDir = FVector.ZeroVector;
		AActor aActor = null;
		if (CasterActor != null)
		{
			aActor = CasterActor;
			FillTargetDirAndPos(CasterActor, aActor, ref OutTargetPos, ref OutAim2TargetDir);
		}
		ValidTarget = aActor != null;
		return aActor;
	}

	private static AActor SkillSelectBaseTarget_Master(AActor CasterActor, out FVector OutTargetPos, out FVector OutAim2TargetDir, int Param1, int Param2, string StrParam, out bool ValidTarget)
	{
		OutTargetPos = FVector.ZeroVector;
		OutAim2TargetDir = FVector.ZeroVector;
		AActor aActor = null;
		if (CasterActor != null)
		{
			aActor = SelectTargetTemplate_Master(CasterActor);
			FillTargetDirAndPos(CasterActor, aActor, ref OutTargetPos, ref OutAim2TargetDir);
		}
		ValidTarget = aActor != null;
		return aActor;
	}

	private static AActor SkillSelectBaseTarget_NearlySpecialUnitByResID(AActor CasterActor, out FVector OutTargetPos, out FVector OutAim2TargetDir, int Param1, int Param2, string StrParam, out bool ValidTarget)
	{
		OutTargetPos = FVector.ZeroVector;
		OutAim2TargetDir = FVector.ZeroVector;
		AActor aActor = null;
		if (CasterActor != null)
		{
			FVector2D v = new FVector2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(CasterActor));
			BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(CasterActor);
			BGUCharacterCS bGUCharacterCS = null;
			float num = -1f;
			BGUCharacterCS[] array = allActorsOfClass;
			foreach (BGUCharacterCS bGUCharacterCS2 in array)
			{
				if (BGU_DataUtil.GetActorResID(bGUCharacterCS2) == Param1)
				{
					float num2 = FVector2D.Distance(v, new FVector2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS2)));
					if ((Param2 < 0 || (float)Param2 >= num2) && (num == -1f || num > num2))
					{
						num = num2;
						bGUCharacterCS = bGUCharacterCS2;
					}
				}
			}
			if (bGUCharacterCS != null)
			{
				aActor = bGUCharacterCS;
			}
			FillTargetDirAndPos(CasterActor, aActor, ref OutTargetPos, ref OutAim2TargetDir);
		}
		ValidTarget = aActor != null;
		return aActor;
	}

	private static AActor SkillSelectBaseTarget_Player(AActor CasterActor, out FVector OutTargetPos, out FVector OutAim2TargetDir, int Param1, int Param2, string StrParam, out bool ValidTarget)
	{
		OutTargetPos = FVector.ZeroVector;
		OutAim2TargetDir = FVector.ZeroVector;
		AActor aActor = null;
		if (CasterActor != null)
		{
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(CasterActor);
			if (firstLocalPlayerController != null)
			{
				aActor = firstLocalPlayerController.GetControlledPawn();
				FillTargetDirAndPos(CasterActor, aActor, ref OutTargetPos, ref OutAim2TargetDir);
			}
		}
		ValidTarget = aActor != null;
		return aActor;
	}

	private static AActor SkillSelectBaseTarget_SceneItem(AActor CasterActor, out FVector OutTargetPos, out FVector OutAim2TargetDir, int Param1, int Param2, string StrParam, out bool ValidTarget)
	{
		OutTargetPos = FVector.ZeroVector;
		OutAim2TargetDir = FVector.ZeroVector;
		AActor aActor = null;
		if (CasterActor != null)
		{
			BGWDataAsset_TryFindSceneItemConfig bGWDataAsset_TryFindSceneItemConfig = BGW_PreloadAssetMgr.Get(CasterActor).TryGetCachedResourceObj<BGWDataAsset_TryFindSceneItemConfig>(StrParam, ELoadResourceType.SyncLoadAndCache);
			if (bGWDataAsset_TryFindSceneItemConfig != null)
			{
				BUS_EventCollectionCS.Get(CasterActor).Evt_TryCatchSceneItemByTag.Invoke(bGWDataAsset_TryFindSceneItemConfig.SceneActorTags.ToList(), bGWDataAsset_TryFindSceneItemConfig.FindSceneItemWay, bGWDataAsset_TryFindSceneItemConfig.NeedRemoveCurrentCatch, bGWDataAsset_TryFindSceneItemConfig.MinDistance, bGWDataAsset_TryFindSceneItemConfig.MaxDistance);
			}
			aActor = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(CasterActor).SceneItemCatch;
			FillTargetDirAndPos(CasterActor, aActor, ref OutTargetPos, ref OutAim2TargetDir);
		}
		ValidTarget = aActor != null;
		return aActor;
	}

	private static AActor SkillSelectBaseTarget_EQSPoint(AActor CasterActor, out FVector OutTargetPos, out FVector OutAim2TargetDir, int Param1, int Param2, string StrParam, out bool ValidTarget)
	{
		OutTargetPos = FVector.ZeroVector;
		OutAim2TargetDir = FVector.ZeroVector;
		ValidTarget = false;
		bool flag = false;
		UEnvQuery uEnvQuery = BGW_PreloadAssetMgr.Get(CasterActor).TryGetCachedResourceObj<UEnvQuery>(StrParam, ELoadResourceType.SyncLoadAndCache);
		if (uEnvQuery != null)
		{
			BGS_EventCollectionCS.Get(CasterActor).Evt_BGS_EQSObjRunInstant.Invoke(uEnvQuery, CasterActor, out var Locations, out var Scores);
			int num = -1;
			float num2 = float.MinValue;
			for (int i = 0; i < Scores.Count; i++)
			{
				if (num2 < Scores[i])
				{
					num2 = Scores[i];
					num = i;
				}
			}
			if (num > -1)
			{
				flag = true;
				OutTargetPos = ((Locations.Count > num) ? Locations[num] : BGUFuncLibActorTransformCS.BGUGetActorLocation(CasterActor));
			}
		}
		ValidTarget = flag;
		return null;
	}

	private static AActor SkillSelectBaseTarget_MasterTarget(AActor CasterActor, out FVector OutTargetPos, out FVector OutAim2TargetDir, int Param1, int Param2, string StrParam, out bool ValidTarget)
	{
		OutTargetPos = FVector.ZeroVector;
		OutAim2TargetDir = FVector.ZeroVector;
		AActor aActor = null;
		if (CasterActor != null)
		{
			aActor = SelectTargetTemplate_MasterTarget(CasterActor);
			FillTargetDirAndPos(CasterActor, aActor, ref OutTargetPos, ref OutAim2TargetDir);
		}
		ValidTarget = aActor != null;
		return aActor;
	}
}
