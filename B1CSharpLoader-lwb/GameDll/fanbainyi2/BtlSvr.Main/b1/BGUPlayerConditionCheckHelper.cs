using System;
using b1.BGW;
using BtlShare;
using CommB1;
using UnrealEngine.Engine;

namespace b1;

public class BGUPlayerConditionCheckHelper
{
	public static bool CheckAndConditionGroup(ACharacter Player, QuestCustom_PlayerCastSkillConditionGroup ConditionGroup)
	{
		if (Player == null)
		{
			return false;
		}
		foreach (QuestCustom_PlayerCastSkillConditionConfig conditionConfig in ConditionGroup.ConditionConfigs)
		{
			if (!CheckCondition(Player, conditionConfig))
			{
				return false;
			}
		}
		return true;
	}

	public static bool CheckCondition(ACharacter Player, QuestCustom_PlayerCastSkillConditionConfig Condition)
	{
		if (Player == null)
		{
			return false;
		}
		bool flag = false;
		EGSAutoTestPlayerCastConditionType eGSAutoTestPlayerCastConditionType = (EGSAutoTestPlayerCastConditionType)Condition.ConditionType;
		switch (eGSAutoTestPlayerCastConditionType)
		{
		case EGSAutoTestPlayerCastConditionType.UnitState:
			if (eGSAutoTestPlayerCastConditionType == EGSAutoTestPlayerCastConditionType.UnitState)
			{
				flag = OnCheckUnitState(Player, (EBGUUnitState)Condition.UnitState);
			}
			break;
		case EGSAutoTestPlayerCastConditionType.UnitAttr:
			flag = OnCheckUnitAttr(Player, (EBGUAttrFloat)Condition.AttrType, (EValueCompareOperations)Condition.CompareOperation, Condition.FloatValue);
			break;
		case EGSAutoTestPlayerCastConditionType.HasItem:
			flag = OnCheckHasItem(Player, Condition.IntValue);
			break;
		case EGSAutoTestPlayerCastConditionType.PELevel:
			flag = OnCheckChargeLevel(Player, (EValueCompareOperations)Condition.CompareOperation, Condition.IntValue);
			break;
		case EGSAutoTestPlayerCastConditionType.NotPreloading:
			flag = OnCheckNotPreloading(Player);
			break;
		}
		if (Condition.InverseCondition)
		{
			flag = !flag;
		}
		return flag;
	}

	public static bool OnCheckNotPreloading(ACharacter Player)
	{
		BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(Player);
		if (bGW_PreloadAssetMgr == null)
		{
			return false;
		}
		return !bGW_PreloadAssetMgr.IsPreloading();
	}

	public static bool OnCheckHasItem(ACharacter Player, int ItemID)
	{
		return RoleDataHelper.HasItem(BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(Player.GetController()), ItemID);
	}

	public static bool OnCheckChargeLevel(AActor Player, EValueCompareOperations CompareOperation, int CompareValue)
	{
		int num = BGUFunctionLibraryCS.BGUGetCurPELevel(Player);
		return CheckCompareValue(CompareOperation, num, CompareValue);
	}

	public static bool CheckCompareValue(EValueCompareOperations CompareOperation, float NowValue, float CompareValue)
	{
		bool flag = false;
		return CompareOperation switch
		{
			EValueCompareOperations.EqualTo => Math.Abs(NowValue - CompareValue) < 1E-08f, 
			EValueCompareOperations.NotEqualTo => Math.Abs(NowValue - CompareValue) > 1E-08f, 
			EValueCompareOperations.LessThan => NowValue < CompareValue, 
			EValueCompareOperations.LessThanOrEqualTo => NowValue <= CompareValue, 
			EValueCompareOperations.GreaterThan => NowValue > CompareValue, 
			EValueCompareOperations.GreaterThanOrEqualTo => NowValue >= CompareValue, 
			EValueCompareOperations.LessThanPercentage => NowValue < CompareValue, 
			EValueCompareOperations.LessThanOrEqualToPercentage => NowValue <= CompareValue, 
			EValueCompareOperations.GreaterThanPercentage => NowValue > CompareValue, 
			EValueCompareOperations.GreaterThanOrEqualToPercentage => NowValue >= CompareValue, 
			_ => flag, 
		};
	}

	public static bool OnCheckUnitState(AActor ObserveActor, EBGUUnitState UnitState)
	{
		if (ObserveActor == null)
		{
			return false;
		}
		IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(ObserveActor);
		if (readOnlyData != null && readOnlyData.HasState(UnitState))
		{
			return true;
		}
		return false;
	}

	public static bool OnCheckUnitAttr(AActor Player, EBGUAttrFloat AttrFloatType, EValueCompareOperations CompareOperation, float CompareValue)
	{
		if (Player == null)
		{
			return false;
		}
		IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(Player);
		if (readOnlyData == null)
		{
			return false;
		}
		float floatValue = readOnlyData.GetFloatValue(AttrFloatType);
		float floatValMin = readOnlyData.GetFloatValMin(AttrFloatType);
		float floatValMax = readOnlyData.GetFloatValMax(AttrFloatType);
		float num = (floatValue - floatValMin) / (floatValMax - floatValMin) * 100f;
		bool result = false;
		switch (CompareOperation)
		{
		case EValueCompareOperations.EqualTo:
			result = Math.Abs(floatValue - CompareValue) < 1E-08f;
			break;
		case EValueCompareOperations.NotEqualTo:
			result = Math.Abs(floatValue - CompareValue) > 1E-08f;
			break;
		case EValueCompareOperations.LessThan:
			result = floatValue < CompareValue;
			break;
		case EValueCompareOperations.LessThanOrEqualTo:
			result = floatValue <= CompareValue;
			break;
		case EValueCompareOperations.GreaterThan:
			result = floatValue > CompareValue;
			break;
		case EValueCompareOperations.GreaterThanOrEqualTo:
			result = floatValue >= CompareValue;
			break;
		case EValueCompareOperations.LessThanPercentage:
			result = num < CompareValue;
			break;
		case EValueCompareOperations.LessThanOrEqualToPercentage:
			result = num <= CompareValue;
			break;
		case EValueCompareOperations.GreaterThanPercentage:
			result = num > CompareValue;
			break;
		case EValueCompareOperations.GreaterThanOrEqualToPercentage:
			result = num >= CompareValue;
			break;
		}
		return result;
	}
}
