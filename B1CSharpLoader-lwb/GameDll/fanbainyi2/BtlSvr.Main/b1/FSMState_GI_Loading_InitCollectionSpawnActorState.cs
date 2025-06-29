using UnrealEngine.Engine;

namespace b1;

public class FSMState_GI_Loading_InitCollectionSpawnActorState : FSMState_GI_LoadingBase
{
	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		BGW_EventCollection.Get(Context.GameInst).Evt_InitCollectionSpawnActorState(UGameplayStatics.GetCurrentLevelName(Context.GameInst));
		base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
	}

	public override int OnTick(float Delta)
	{
		return 100;
	}

	public override void OnExit()
	{
	}
}
