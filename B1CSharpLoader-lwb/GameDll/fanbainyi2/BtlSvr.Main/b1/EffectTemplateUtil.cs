using BtlShare;
using UnrealEngine.Engine;

namespace b1;

internal static class EffectTemplateUtil
{
	public static bool ReturnIfUnitOrMasterDead(AActor Unit)
	{
		if (Unit != null)
		{
			BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Unit);
			if (readOnlyData != null)
			{
				AActor masterActor = readOnlyData.GetMasterActor();
				if (masterActor != null)
				{
					BUC_UnitStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(masterActor);
					if (readOnlyData2 != null && readOnlyData2.HasState(EBGUUnitState.Dead))
					{
						return true;
					}
				}
			}
			BUC_UnitStateData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Unit);
			if (readOnlyData3 != null && readOnlyData3.HasState(EBGUUnitState.Dead))
			{
				return true;
			}
			return false;
		}
		return true;
	}

	public static bool ReturnIfUnitDead(AActor Unit)
	{
		if (Unit != null)
		{
			BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Unit);
			if (readOnlyData != null && readOnlyData.HasState(EBGUUnitState.Dead))
			{
				return true;
			}
			return false;
		}
		return true;
	}

	public static bool ReturnIfUnitInLifeSavingHair(AActor Unit)
	{
		if (Unit != null)
		{
			BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Unit);
			if (readOnlyData != null && (readOnlyData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) || readOnlyData.HasState(EBGUUnitState.LifeSavingHair_Rebirth)))
			{
				return true;
			}
			return false;
		}
		return true;
	}

	public static bool ReturnIfUnitInPendingOrFakeDead(AActor Unit)
	{
		if (Unit != null)
		{
			BUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(Unit);
			if (readOnlyData != null && readOnlyData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
			{
				return true;
			}
			BUC_UnitStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Unit);
			if (readOnlyData2 != null && readOnlyData2.HasState(EBGUUnitState.LifeSavingHair_FakeDead))
			{
				return true;
			}
			return false;
		}
		return true;
	}

	public static int GetSkillEffectDescIntEffectParam(FUStSkillEffectDesc SkillEffectDesc, int ParamIdx)
	{
		return SkillEffectDesc.EffectParamsInt[ParamIdx];
	}

	public static float GetSkillEffectDescFloatEffectParam(FUStSkillEffectDesc SkillEffectDesc, int ParamIdx)
	{
		return SkillEffectDesc.EffectParamsFloat[ParamIdx];
	}

	public static string GetSkillEffectDescExtraEffectParam(FUStSkillEffectDesc SkillEffectDesc, int ParamIdx)
	{
		return SkillEffectDesc.EffectParamsStr[ParamIdx];
	}

	public static BuffDescRuntime GetBuffDescRuntime(BuffInstData BuffInst)
	{
		if (BuffInst == null)
		{
			return null;
		}
		int buffID = BuffInst.BuffID;
		FUStBuffDesc originalBuffDesc = BGW_GameDB.GetOriginalBuffDesc(buffID);
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(BuffInst.RootCasterRef));
		if (originalBuffDesc != null)
		{
			return new BuffDescRuntime(buffID, readOnlyData, originalBuffDesc);
		}
		return null;
	}
}
