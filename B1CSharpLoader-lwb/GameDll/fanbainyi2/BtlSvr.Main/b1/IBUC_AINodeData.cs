namespace b1;

public interface IBUC_AINodeData
{
	bool IsBTAborted { get; }

	AINodeFinishState CanFinishAINode { get; }

	EAINodeActionType ActionType { get; }
}
