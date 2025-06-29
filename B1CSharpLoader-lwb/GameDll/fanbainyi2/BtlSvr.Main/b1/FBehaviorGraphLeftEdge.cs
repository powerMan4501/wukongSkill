namespace b1;

public class FBehaviorGraphLeftEdge : FBehaviorGraphEdgeBase, IFromLeftNodeEdge
{
	public bool bFromFailedPin { get; set; }

	public FBehaviorLeftNodeInstance FromNodeInstance { get; set; }

	public FBehaviorLeftNodeInstance ToNodeInstance { get; set; }
}
