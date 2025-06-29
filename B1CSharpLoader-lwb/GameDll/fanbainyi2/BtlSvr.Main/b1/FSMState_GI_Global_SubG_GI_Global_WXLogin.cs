using System;
using b1.EventDelDefine;
using Google.Protobuf;
using GurCalliopeFsm;

namespace b1;

public class FSMState_GI_Global_SubG_GI_Global_WXLogin : FSMState_GI_Global_SubG_GI_Global_Base
{
	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Global_SubG_GI_Global_WXLogin gI_Global_SubG_GI_Global_WXLogin = new GI_Global_SubG_GI_Global_WXLogin();
		gI_Global_SubG_GI_Global_WXLogin.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Global_SubG_GI_Global_WXLogin.SubGraphAsset;
	}

	public override void OnAbort()
	{
		base.OnAbort();
		BGW_EventCollection.Get(base.OwningInstance.OwnerUObj).Evt_BGW_AbortFSMInstance(base.SubGraphRuntimeInstance);
	}

	protected override FSMContext_GI_Global GenSubGraphContext()
	{
		return Context;
	}

	public override void OnSubGraphEnter()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Context.OwnerUObj);
		bGW_EventCollection.Evt_TriggerWXLoginSuccess = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_TriggerWXLoginSuccess, new Del_Void(TriggerWXLoginSuccess));
	}

	private void TriggerWXLoginSuccess()
	{
		base.SubGraphRuntimeInstance.TriggerEvent(EGI_Global.WXLoginSuccess);
	}

	public override void OnSubGraphFinish()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Context.OwnerUObj);
		bGW_EventCollection.Evt_TriggerWXLoginSuccess = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_TriggerWXLoginSuccess, new Del_Void(TriggerWXLoginSuccess));
		base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Global_WXLogin_Return.Finish);
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}
}
