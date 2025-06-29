using UnrealEngine.Runtime;

namespace b1;

public class BUS_BTCheckComp : UActorCompBaseCS
{
	private BUC_BTCheckData BTCheckData { get; set; }

	public override void OnAttach()
	{
		BTCheckData = RequireWritableData<BUC_BTCheckData>();
	}

	public override void PreBeginPlay()
	{
		BTCheckData.HasInit = true;
		BTCheckData.Owner = new TWeakObject<BGUCharacterCS>(Owner as BGUCharacterCS);
		BTCheckData.TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		BTCheckData.AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		BTCheckData.SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		BTCheckData.UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		BTCheckData.BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		BTCheckData.FsmData = RequireReadOnlyData<IBUC_FsmData, BUC_FsmData>();
		BTCheckData.BeAttackData = RequireReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>();
		BTCheckData.MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		BTCheckData.GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		BTCheckData.SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		BTCheckData.TransformInfoData = RequireReadOnlyData<IBUC_ActorTransformInfoData, BUC_ActorTransformInfoData>();
		BTCheckData.SceneItemData = RequireReadOnlyData<IBUC_SceneItemData, BUC_SceneItemData>();
		BTCheckData.AIData = RequireReadOnlyData<IBUC_AIData, BUC_AIData>();
		BTCheckData.GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		BTCheckData.TamerFamilyTreeData = RequireReadOnlyGameStateData<IBGC_CircusControlData, BGC_CircusControlData>();
		BTCheckData.LocalPlayerSharedData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
	}
}
