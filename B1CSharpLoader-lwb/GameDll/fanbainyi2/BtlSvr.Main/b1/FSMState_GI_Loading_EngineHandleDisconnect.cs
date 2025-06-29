using System;
using b1.EventDelDefine;

namespace b1;

public class FSMState_GI_Loading_EngineHandleDisconnect : FSMState_GI_LoadingBase
{
	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		BGW_GameLifeTimeMgr.Get(Context.GameInst).StartOpenLevel();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Context.GameInst);
		bGW_EventCollection.Evt_PreLoadMap = (Del_Void_String)Delegate.Combine(bGW_EventCollection.Evt_PreLoadMap, new Del_Void_String(OnPreLoadMap));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(Context.GameInst);
		bGW_EventCollection2.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Combine(bGW_EventCollection2.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
		UGSE_OnlineFuncLib.GEngineHandleDisconnect(Context.GameInst.GetWorldForCS());
	}

	private void OnPreLoadMap(string MapName)
	{
		BGWGameInstanceCS gameInst = Context.GameInst;
		BGWGameInstanceCS.Get(gameInst).SwitchLoadingScreenThread(UseSlateThread: true);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(gameInst);
		bGW_EventCollection.Evt_PreLoadMap = (Del_Void_String)Delegate.Remove(bGW_EventCollection.Evt_PreLoadMap, new Del_Void_String(OnPreLoadMap));
	}

	private void OnPostLoadMapWithWorld()
	{
		BGWGameInstanceCS gameInst = Context.GameInst;
		BGWGameInstanceCS.Get(gameInst).SwitchLoadingScreenThread(UseSlateThread: false);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(gameInst);
		bGW_EventCollection.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
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
