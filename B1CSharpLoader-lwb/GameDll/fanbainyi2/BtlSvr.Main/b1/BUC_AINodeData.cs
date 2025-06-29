using b1.ECS;

namespace b1;

public class BUC_AINodeData : IBUC_AINodeData, IPersistentECSData
{
	public bool IsBTAborted { get; set; }

	public AINodeFinishState CanFinishAINode { get; set; }

	public EAINodeActionType ActionType { get; set; }
}
