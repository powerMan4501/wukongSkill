using b1.Plugins.AkAudio;
using b1.Plugins.AsyncLoadingScreen;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FSMState_GI_Loading_LoadingUIBeginFadeAway : FSMState_GI_LoadingBase
{
	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		if (Context.GameInst.GetCurLoadingScreenState() == EGSLoadingScreenState.Idle)
		{
			base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
			return;
		}
		BGW_EventCollection.Get(Context.GameInst).Evt_LoadingBeginFadeAway();
		Context.GameInst.RequestFadeAway();
		AActor actorOfClass = UGameplayStatics.GetActorOfClass(Context.GameInst, UClass.GetClass<APlayerCameraManager>());
		UAkGameplayStatics.PostEvent(null, actorOfClass, 0, null, bStopWhenAttachedToDestroyed: true, "EVT_system_loading_finish");
	}

	public override int OnTick(float Delta)
	{
		if (Context.GameInst.IsLoadingScreenFadeAwayFinish())
		{
			Context.TeleportTemplate?.LoadingFadeAwayBegin();
			base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
			return 100;
		}
		return 0;
	}

	public override void OnExit()
	{
	}
}
