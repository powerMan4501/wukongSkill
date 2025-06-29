using b1.Plugins.AkAudio;
using Google.Protobuf;
using GUR.Runtime;
using GurCalliopeFsm;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FSMState_GI_Loading_RequestFadeAway : FSMState_GI_LoadingBase
{
	[EditableFSMParam]
	private float WaitSecond { get; set; }

	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Loading_RequestFadeAway gI_Loading_RequestFadeAway = new GI_Loading_RequestFadeAway();
		gI_Loading_RequestFadeAway.MergeFrom(Node.NodeData);
		WaitSecond = gI_Loading_RequestFadeAway.WaitSecond;
	}

	public override void OnEnter()
	{
		Context.TeleportTemplate?.LoadingFadeAwayPreBegin();
		if (!Context.GameInst.CanFadeAway())
		{
			RequestFadeAway();
		}
	}

	private void RequestFadeAway()
	{
		if (DebugConfig.FSRCrashOptions > 0 && BGUFuncLibMap.IsBattleMap(Context.GameInst))
		{
			BGW_EventCollection.Get(Context.GameInst)?.Evt_BGW_TriggerInBattleLevel(P1: true);
		}
		BGW_LoadingTipsMgr.Get(Context.GameInst).LoadingColorAlphaTracker.Open();
		Context.TeleportTemplate?.LoadingFadeAwayBegin();
		BGW_EventCollection.Get(Context.GameInst).Evt_LoadingBeginFadeAway();
		Context.GameInst.RequestFadeAway();
		AActor actorOfClass = UGameplayStatics.GetActorOfClass(Context.GameInst, UClass.GetClass<APlayerCameraManager>());
		UAkGameplayStatics.PostEvent(null, actorOfClass, 0, null, bStopWhenAttachedToDestroyed: true, "EVT_system_loading_finish");
		base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
	}

	public override int OnTick(float Delta)
	{
		if (Context.GameInst.CanFadeAway())
		{
			if (WaitSecond > 0f)
			{
				WaitSecond -= Delta;
			}
			else
			{
				RequestFadeAway();
			}
		}
		else
		{
			base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
		}
		return 100;
	}

	public override void OnExit()
	{
	}
}
