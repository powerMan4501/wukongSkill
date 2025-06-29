namespace b1;

public interface IToRightNodeEdge
{
	FCalliopeEdge Edge { get; }

	FBehaviorRightNodeInstance ToNodeInstance { get; }

	void ExecuteOutput();
}
