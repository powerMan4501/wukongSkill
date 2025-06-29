using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

internal class BUIAStrangeBox : b1.BUIADummyMeshAnim
{
	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		BPC_PlayerInteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerInteractData>((User as APawn).PlayerState);
		if (readOnlyData != null && readOnlyData.TmpIsSpDrop)
		{
			base.DoInteractAction(InteractiveActorID, User, InteractiveActor, Action);
		}
		else
		{
			BUS_EventCollectionCS.Get(User).Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(Action.ParamsInt[1], ECastSkillSourceType.Interact));
		}
		return true;
	}

	public override void OnBreakInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		BPC_PlayerInteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerInteractData>((User as APawn).PlayerState);
		if (readOnlyData != null && readOnlyData.TmpIsSpDrop)
		{
			base.OnBreakInteractAction(InteractiveActorID, User, InteractiveActor, Action);
		}
	}

	public override void OnFinishInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		BPC_PlayerInteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerInteractData>((User as APawn).PlayerState);
		if (readOnlyData != null && readOnlyData.TmpIsSpDrop)
		{
			base.OnFinishInteractAction(InteractiveActorID, User, InteractiveActor, Action);
		}
	}

	public override void UpdateIdle(AActor InteractiveActor, FUStInteractionMappingDesc Action, EBGUInteractUnitState State)
	{
		base.UpdateIdle(InteractiveActor, Action, State);
	}
}
