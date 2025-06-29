using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

internal class BUS_ControllerComp : UActorCompBaseCS
{
	private BUC_ControllerData ControllerData;

	public override void OnAttach()
	{
		ControllerData = RequireWritableData<BUC_ControllerData>();
		base.BUSEventCollection.Evt_AddLastSkillHit += new Del_Void_Actor(OnAddLastSkillHit);
		base.BUSEventCollection.Evt_ClearLastSkillHit += new Del_Void(OnClearLastSkillHit);
		base.BUSEventCollection.Evt_SetLocalControlled += new Del_Void_Bool(OnSetLocalControlled);
	}

	public override void PreBeginPlay()
	{
	}

	public override void OnBeginPlay()
	{
	}

	private void OnAddLastSkillHit(AActor Attacker)
	{
		ControllerData.AddLastSkillHit(Attacker);
	}

	private void OnClearLastSkillHit()
	{
		ControllerData.ClearLastSkillHit();
	}

	private void OnSetLocalControlled(bool IsLocallyControlled)
	{
		ControllerData.SetIsLocalControlled(IsLocallyControlled);
	}
}
