namespace b1;

public class FBehaviorGraphRightEdge : FBehaviorGraphEdgeBase, IToRightNodeEdge
{
	public FBehaviorRightNodeInstance FromNodeInstance { get; set; }

	public FBehaviorRightNodeInstance ToNodeInstance { get; set; }
}
