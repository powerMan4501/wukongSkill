using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

public class BPS_NetCloseSystem : PlayerControllerSystemBase
{
	public override void OnAttach()
	{
		GetPlayerEventCollection().Evt_CloseConnectionWithResult += new Del_CloseConnectionWithResult(OnCloseConnectionWithResult);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
		bGW_EventCollection.Evt_ReceiveCloseReason = (BGW_EventCollection.Del_BGW_Void_String)Delegate.Combine(bGW_EventCollection.Evt_ReceiveCloseReason, new BGW_EventCollection.Del_BGW_Void_String(OnReceiveCloserReason));
	}

	private void OnCloseConnectionWithResult(EGSNetCloseResult CloseResult)
	{
		if (GSEUtil.Ensure(!Owner.World.IsServer(), "Net close failed: request close connection's player controller is server"))
		{
			UGSE_OnlineFuncLib.CloseServerConnection(CloseResult, Owner);
		}
	}

	private void OnReceiveCloserReason(string CloseReason)
	{
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
		bGW_EventCollection.Evt_ReceiveCloseReason = (BGW_EventCollection.Del_BGW_Void_String)Delegate.Remove(bGW_EventCollection.Evt_ReceiveCloseReason, new BGW_EventCollection.Del_BGW_Void_String(OnReceiveCloserReason));
	}
}
