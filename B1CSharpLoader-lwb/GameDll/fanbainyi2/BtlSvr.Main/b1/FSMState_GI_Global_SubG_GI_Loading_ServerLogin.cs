using Google.Protobuf;
using GUR.Runtime;
using GurCalliopeFsm;
using UnrealEngine.Engine;

namespace b1;

public class FSMState_GI_Global_SubG_GI_Loading_ServerLogin : FSMState_GI_Global_SubG_GI_Loading_Base
{
	[FSMInputParam]
	public APlayerController PlayerController { get; set; }

	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Global_SubG_GI_Loading_ServerLogin gI_Global_SubG_GI_Loading_ServerLogin = new GI_Global_SubG_GI_Loading_ServerLogin();
		gI_Global_SubG_GI_Loading_ServerLogin.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Global_SubG_GI_Loading_ServerLogin.SubGraphAsset;
		if (InputParams is FSMInputData_GI_Global_SubG_GI_Loading_ServerLogin fSMInputData_GI_Global_SubG_GI_Loading_ServerLogin)
		{
			PlayerController = fSMInputData_GI_Global_SubG_GI_Loading_ServerLogin.PlayerController;
		}
	}

	public override void OnAbort()
	{
		base.OnAbort();
		BGW_EventCollection.Get(base.OwningInstance.OwnerUObj).Evt_BGW_AbortFSMInstance(base.SubGraphRuntimeInstance);
	}

	protected override FSMContext_GI_Loading GenSubGraphContext()
	{
		return new FSMContext_GI_Loading(Context.OwnerUObj as BGWGameInstanceCS)
		{
			Controller = PlayerController
		};
	}

	public override void OnSubGraphFinish()
	{
		base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_ServerLogin_Return.Finish);
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}

	public override void OnSubGraphEnter()
	{
	}
}
