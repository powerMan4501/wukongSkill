using b1.Plugins.AkAudio;
using b1.Plugins.AsyncLoadingScreen;
using Google.Protobuf;
using GUR.Runtime;
using GurCalliopeFsm;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FSMState_GI_Loading_OpenLoadingScreen : FSMState_GI_LoadingBase
{
	[EditableFSMParam]
	private int WaitTick { get; set; }

	[EditableFSMParam(ParamType = FSMParamType.Enum)]
	private ELoadingUIFadeInReason Reason { get; set; }

	private int TickCounter { get; set; }

	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Loading_OpenLoadingScreen gI_Loading_OpenLoadingScreen = new GI_Loading_OpenLoadingScreen();
		gI_Loading_OpenLoadingScreen.MergeFrom(Node.NodeData);
		WaitTick = gI_Loading_OpenLoadingScreen.WaitTick;
		Reason = (ELoadingUIFadeInReason)gI_Loading_OpenLoadingScreen.Reason;
	}

	public override void OnEnter()
	{
		Context.Reason = Reason;
		if (Context.GameInst.GetCurLoadingScreenState() == EGSLoadingScreenState.Idle)
		{
			AActor actorOfClass = UGameplayStatics.GetActorOfClass(Context.GameInst, UClass.GetClass<APlayerCameraManager>());
			UAkGameplayStatics.PostEvent(null, actorOfClass, 0, null, bStopWhenAttachedToDestroyed: true, "EVT_system_loading_begin");
			EGSLoadingScreenType eGSLoadingScreenType = EGSLoadingScreenType.Full;
			if (Context.TravelLevelTemplate != null)
			{
				eGSLoadingScreenType = Context.TravelLevelTemplate.GetLoadingScreenType();
			}
			else if (Context.TeleportTemplate != null)
			{
				eGSLoadingScreenType = Context.TeleportTemplate.GetLoadingScreenType();
			}
			eGSLoadingScreenType = ((eGSLoadingScreenType == EGSLoadingScreenType.Unknown) ? EGSLoadingScreenType.FullBlack : eGSLoadingScreenType);
			Context.GameInst.OpenLoadingScreen(UseSlateThread: false, eGSLoadingScreenType);
			BGW_DebugMgr.Get(Context.GameInst).UpdateUserConfigToSentry();
			BGW_EventCollection.Get(Context.GameInst).Evt_BlockInput(EBlockType.Loading, IsBlock: true);
			BGW_EventCollection.Get(Context.OwnerUObj).Evt_PostLoadingScreenOpen();
			BGW_EventCollection.Get(Context.GameInst).Evt_BGW_PreFetchLoadingTips(new FLoadingTipsInfo(Context));
		}
	}

	public override int OnTick(float Delta)
	{
		if (TickCounter > WaitTick)
		{
			Context.TeleportTemplate?.LoadingFadeInFinish();
			base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
		}
		TickCounter++;
		return 100;
	}

	public override void OnExit()
	{
	}
}
