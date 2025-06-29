using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

public class FSMState_GI_Loading_TeleportTemplateEnd : FSMState_GI_LoadingBase
{
	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		Context.TeleportTemplate.OnEnd();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Context.TeleportTemplate.PlayerPawn);
		bUS_GSEventCollection?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.TeleportEnd, -1f);
		bUS_GSEventCollection?.Evt_TeleportFinish.Invoke();
		CVarFuncLib.DestroyHandle(Context.TeleportTemplate.GrassTickInterval_CvarHandle);
		base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
		UAkGameplayStatics.SetRTPCValue(null, 1f, 0, null, new FName("RTPC_Block_Sp"));
	}

	public override int OnTick(float Delta)
	{
		return 100;
	}

	public override void OnExit()
	{
	}
}
