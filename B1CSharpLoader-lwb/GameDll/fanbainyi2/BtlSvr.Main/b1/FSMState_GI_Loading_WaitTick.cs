using Google.Protobuf;
using GUR.Runtime;
using GurCalliopeFsm;

namespace b1;

public class FSMState_GI_Loading_WaitTick : FSMState_GI_LoadingBase
{
	private int TickCount;

	[EditableFSMParam(ParamType = FSMParamType.Normal)]
	private int WaitTotalTick { get; set; }

	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Loading_WaitTick gI_Loading_WaitTick = new GI_Loading_WaitTick();
		gI_Loading_WaitTick.MergeFrom(Node.NodeData);
		WaitTotalTick = gI_Loading_WaitTick.WaitTotalTick;
	}

	public override void OnEnter()
	{
	}

	public override int OnTick(float Delta)
	{
		if (TickCount < WaitTotalTick)
		{
			TickCount++;
			return (int)((float)TickCount / (float)WaitTotalTick * 100f);
		}
		base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
		return 100;
	}

	public override void OnExit()
	{
	}
}
