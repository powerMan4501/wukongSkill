using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public static class BGUFuncLib_AbnormalState
{
	[BlueprintCallable]
	[UFunction]
	public static int GetAbnormalStateAccEffectOrBuffID(AActor Caster, AbnormalStateAccConfig config)
	{
		if (Caster == null || !config.IsValid())
		{
			return -1;
		}
		BGUCharacterCS bGUCharacterCS = Caster as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			bGUCharacterCS = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Caster).GetMasterActor() as BGUCharacterCS;
		}
		if (bGUCharacterCS == null)
		{
			return -1;
		}
		IBUC_ActorBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_ActorBasicData, BUC_ActorBasicData>(bGUCharacterCS);
		if (readOnlyData == null)
		{
			return -1;
		}
		if (config.Condition.Conditions != null && config.Condition.Conditions.Count > 0 && BGUFunctionLibraryCS.CheckConditions(Caster, config.Condition.UnitType, config.Condition.Conditions, config.Condition.ConditionalRelation, config.Condition.IsReverseCondition) != 1)
		{
			return -1;
		}
		return 900000 + ((readOnlyData.ActorType == BGU_ActorType.CharacterPlayer) ? 1 : 2) * 10000 + (int)config.AccType * 1000 + (int)config.AbnormalStateType * 100 + config.Level * 10;
	}

	[UFunction]
	[BlueprintCallable]
	public static bool IsInFinalAbnormalState(AActor Unit, EAbnormalStateType AbnormalStateType)
	{
		if (Unit.IsNullOrDestroyed())
		{
			return false;
		}
		return BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AbnormalStateHandlers, BUC_AbnormalStateHandlers>(Unit)?.IsInFinalState(AbnormalStateType) ?? false;
	}

	[UFunction]
	[BlueprintCallable]
	public static EBGUSimpleState GetImmueStateType(EAbnormalStateType AbnormalStateType)
	{
		return AbnormalStateType switch
		{
			EAbnormalStateType.Abnormal_Burn => EBGUSimpleState.BurnImmue, 
			EAbnormalStateType.Abnormal_Freeze => EBGUSimpleState.FreezeImmue, 
			EAbnormalStateType.Abnormal_Poison => EBGUSimpleState.PoisonImmue, 
			EAbnormalStateType.Abnormal_Thunder => EBGUSimpleState.ThunderImmue, 
			EAbnormalStateType.Abnormal_Yin => EBGUSimpleState.YinImmue, 
			EAbnormalStateType.Abnormal_Yang => EBGUSimpleState.YangImmue, 
			_ => EBGUSimpleState.Normal, 
		};
	}
}
