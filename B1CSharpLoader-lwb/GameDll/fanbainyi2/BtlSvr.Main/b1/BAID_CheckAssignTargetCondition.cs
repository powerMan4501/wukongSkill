using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Check Assign Target")]
[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckAssignTargetCondition")]
internal class BAID_CheckAssignTargetCondition : BAID_Base
{
	private static bool CheckAssignTargetInfo_IsValid;

	private static int CheckAssignTargetInfo_Offset;

	[BlueprintReadWrite]
	[DisplayName("检查单位参数")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckAssignTargetCondition:CheckAssignTargetInfo")]
	public FCheckAssignTargetInfo CheckAssignTargetInfo
	{
		get
		{
			CheckDestroyed();
			if (!CheckAssignTargetInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckAssignTargetCondition:CheckAssignTargetInfo");
				return default(FCheckAssignTargetInfo);
			}
			return FCheckAssignTargetInfo.FromNative(IntPtr.Add(base.Address, CheckAssignTargetInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckAssignTargetInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckAssignTargetCondition:CheckAssignTargetInfo");
			}
			else
			{
				FCheckAssignTargetInfo.ToNative(IntPtr.Add(base.Address, CheckAssignTargetInfo_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		if (!CheckAndGetValidGUIDUnit(bGUCharacterCS, out var CheckUnit))
		{
			return false;
		}
		bool result = false;
		switch (CheckAssignTargetInfo.CheckConditionType)
		{
		case ECheckConditionType.AITarget:
			result = CheckAITarget(bGUCharacterCS, CheckUnit);
			break;
		case ECheckConditionType.HpLow:
			result = CheckHPLow(CheckUnit);
			break;
		case ECheckConditionType.InRange:
			result = CheckInRange(bGUCharacterCS, CheckUnit);
			break;
		case ECheckConditionType.HasBuff:
			result = CheckIsHasBuff(CheckUnit);
			break;
		case ECheckConditionType.InAbnormalState:
			result = CheckAbnormalState(CheckUnit);
			break;
		case ECheckConditionType.BreakPart:
			result = CheckBreakPart(bGUCharacterCS, CheckUnit);
			break;
		case ECheckConditionType.Beatback:
			result = CheckBeatback(bGUCharacterCS, CheckUnit);
			break;
		case ECheckConditionType.CastSkill:
			result = CheckCastSkill(CheckUnit);
			break;
		}
		return result;
	}

	private bool CheckAndGetValidGUIDUnit(BGUCharacterCS CurCharacter, out AActor CheckUnit)
	{
		CheckUnit = null;
		if (CheckAssignTargetInfo.CheckPlayer)
		{
			CheckUnit = BGU_UnrealWorldUtil.GetNearestPlayerActor(CurCharacter, BGUFuncLibActorTransformCS.BGUGetActorLocation(CurCharacter));
		}
		else
		{
			CheckUnit = BGU_DataUtil.GetActorByGuid(this, CheckAssignTargetInfo.CheckUnitGUID);
		}
		return CheckUnit != null;
	}

	private string GetAttackerGUID(BGUCharacterCS CurCharacter)
	{
		string result = "";
		if (CheckAssignTargetInfo.IsPlayerAttack)
		{
			AActor nearestPlayerActor = BGU_UnrealWorldUtil.GetNearestPlayerActor(CurCharacter, BGUFuncLibActorTransformCS.BGUGetActorLocation(CurCharacter));
			if (nearestPlayerActor != null)
			{
				result = BGU_DataUtil.GetActorGuid(nearestPlayerActor);
			}
		}
		else
		{
			result = CheckAssignTargetInfo.CheckUnitGUID;
		}
		return result;
	}

	private bool CheckAITarget(BGUCharacterCS CurCharacter, AActor CheckUnit)
	{
		bool flag = true;
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(CheckUnit);
		if (readOnlyData == null)
		{
			flag = false;
		}
		UnitLockTargetInfo targetInfo = readOnlyData.GetTargetInfo();
		if (targetInfo == null)
		{
			flag = false;
		}
		if (!flag)
		{
			if (CheckAssignTargetInfo.CheckSelfIsAITarget)
			{
				return false;
			}
			return true;
		}
		bool flag2 = false;
		AActor lockTargetActor = targetInfo.LockTargetActor;
		if (lockTargetActor != null)
		{
			string actorGuid = BGU_DataUtil.GetActorGuid(CurCharacter);
			flag2 = BGU_DataUtil.GetActorGuid(lockTargetActor).Equals(actorGuid);
		}
		if (CheckAssignTargetInfo.CheckSelfIsAITarget)
		{
			if (flag2)
			{
				return true;
			}
		}
		else if (!flag2)
		{
			return true;
		}
		return false;
	}

	private bool CheckHPLow(AActor CheckUnit)
	{
		IBUC_AttrContainer unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(CheckUnit);
		if (unPersistentReadOnlyData == null)
		{
			return false;
		}
		float floatValue = unPersistentReadOnlyData.GetFloatValue(EBGUAttrFloat.Hp);
		float floatValue2 = unPersistentReadOnlyData.GetFloatValue(EBGUAttrFloat.HpMax);
		if (floatValue / floatValue2 * 100f <= (float)CheckAssignTargetInfo.HpLowPercent)
		{
			return true;
		}
		return false;
	}

	private bool CheckInRange(BGUCharacterCS CurCharacter, AActor CheckUnit)
	{
		FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(CurCharacter);
		FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(CheckUnit);
		if (MathLib.Dist(v, v2) <= CheckAssignTargetInfo.RangeDistance)
		{
			return true;
		}
		return false;
	}

	private bool CheckIsHasBuff(AActor CheckUnit)
	{
		IBUC_BuffData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BuffData, BUC_BuffData>(CheckUnit);
		if (unPersistentReadOnlyData == null)
		{
			return false;
		}
		if (unPersistentReadOnlyData.GetBuffInstData(CheckAssignTargetInfo.BuffID, out var BuffData) && BuffData.Layer == CheckAssignTargetInfo.BuffLayer)
		{
			return true;
		}
		return false;
	}

	private bool CheckBreakPart(BGUCharacterCS CurCharacter, AActor CheckUnit)
	{
		IBUC_UnitStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(CheckUnit);
		if (unPersistentReadOnlyData == null || !unPersistentReadOnlyData.HasState(EBGUUnitState.Beatback))
		{
			return false;
		}
		IBUC_SimpleStateData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(CheckUnit);
		if (unPersistentReadOnlyData2 == null || !unPersistentReadOnlyData2.HasSimpleState(EBGUSimpleState.BreakPart2Weak))
		{
			return false;
		}
		IBUC_PartMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PartMgrData, BUC_PartMgrData>(CheckUnit);
		if (readOnlyData == null)
		{
			return false;
		}
		if (readOnlyData.GetValidLastBreakOrDamagedPartInfo(out var BreakOrDamagedPartID, out var IsTriggerBreak, out var BreakerGUID) && BreakOrDamagedPartID == CheckAssignTargetInfo.PartID && IsTriggerBreak == CheckAssignTargetInfo.IsPartBreak)
		{
			return BreakerGUID.Equals(GetAttackerGUID(CurCharacter));
		}
		return false;
	}

	private bool CheckBeatback(BGUCharacterCS CurCharacter, AActor CheckUnit)
	{
		IBUC_UnitStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(CheckUnit);
		if (unPersistentReadOnlyData == null || !unPersistentReadOnlyData.HasState(EBGUUnitState.Beatback))
		{
			return false;
		}
		IBUC_BeAttackData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>(CheckUnit);
		if (unPersistentReadOnlyData2 == null)
		{
			return false;
		}
		if (CheckAssignTargetInfo.BeatbackStiffLevel == unPersistentReadOnlyData2.GetCurrentBeAttackedStiffLevel())
		{
			return unPersistentReadOnlyData2.GetCurrentBeAttackedAttackerGUID().Equals(GetAttackerGUID(CurCharacter));
		}
		return false;
	}

	private bool CheckCastSkill(AActor CheckUnit)
	{
		IBUC_UnitStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(CheckUnit);
		if (unPersistentReadOnlyData == null)
		{
			return false;
		}
		if (!unPersistentReadOnlyData.HasState(EBGUUnitState.Attacking))
		{
			return false;
		}
		IBUC_SkillInstsData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(CheckUnit);
		if (unPersistentReadOnlyData2 == null)
		{
			return false;
		}
		if (unPersistentReadOnlyData2.CurrentCastingSkillID == CheckAssignTargetInfo.SkillID)
		{
			return true;
		}
		return false;
	}

	private bool CheckAbnormalState(AActor CheckUnit)
	{
		return BGUFuncLib_AbnormalState.IsInFinalAbnormalState(CheckUnit, CheckAssignTargetInfo.CheckAbnormalStateType);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckAssignTargetCondition");
		CheckAssignTargetInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckAssignTargetInfo");
		CheckAssignTargetInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckAssignTargetInfo", Classes.FStructProperty);
	}

	static BAID_CheckAssignTargetCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckAssignTargetCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckAssignTargetCondition));
	}
}
