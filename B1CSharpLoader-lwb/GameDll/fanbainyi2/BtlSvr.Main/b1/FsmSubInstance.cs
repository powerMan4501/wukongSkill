using b1.Plugins.Calliope;
using UnrealEngine.Engine;

namespace b1;

public class FsmSubInstance : FsmInstance
{
	private FsmNodeInstance_State StateNodeInstance { get; set; }

	public static FsmSubInstance Create(FsmNodeInstance_State InStateNodeInstance)
	{
		if (InStateNodeInstance == null)
		{
			return null;
		}
		if (string.IsNullOrEmpty(InStateNodeInstance.AssetPath))
		{
			return null;
		}
		FsmInstance parentInstance = InStateNodeInstance.ParentInstance;
		AActor owner = parentInstance.Owner;
		FsmSubInstance fsmSubInstance = new FsmSubInstance
		{
			Owner = owner,
			StateNodeInstance = InStateNodeInstance,
			Graph = InStateNodeInstance.SubGraph,
			FsmData = BGU_DataUtil.GetReadOnlyData<BUC_FsmData>(owner),
			FsmIdentify = parentInstance.FsmIdentify,
			TemplateAsset = FCalliopeAssetReference.CreateInstance(owner, ECalliopeAssetType.State, InStateNodeInstance.AssetPath)
		};
		FsmInstance.InitialGraphNodes(fsmSubInstance);
		parentInstance.AddSubInstance(fsmSubInstance);
		return fsmSubInstance;
	}

	public override void Start()
	{
		if (FCalliopeGraph.IsValid(base.Graph))
		{
			FCalliopeGuid nodeGuid = GameplayTagExtension.ConvertToCalliopeGuid(StateNodeInstance.Node.NodeGuid);
			base.TemplateAsset.StartAsSubInstance(StateNodeInstance.ParentInstance.TemplateAsset, nodeGuid);
			FCalliopeNode startNode = base.Graph.GetStartNode();
			if (startNode != null)
			{
				base.Nodes[startNode.NodeGuid].ExecuteNode();
			}
		}
	}

	public override void OnTerminate()
	{
		StateNodeInstance.ParentInstance.OnTerminate();
	}

	public override void OnTick(float DeltaSeconds)
	{
		if (base.PhaseComp == null || !base.PhaseComp.CheckIfStopUpdateCurrentStates())
		{
			ProfileBegin("[FsmSubInstanceTick]State Tick");
			Evt_NotifyStateTick(DeltaSeconds);
			ProfileEnd();
			ProfileBegin("[FsmSubInstanceTick]PhaseComp Tick");
			base.PhaseComp?.OnTick(DeltaSeconds);
			ProfileEnd();
		}
	}
}
