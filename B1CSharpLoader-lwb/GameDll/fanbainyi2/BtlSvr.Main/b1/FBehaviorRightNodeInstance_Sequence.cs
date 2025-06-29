using System.Collections.Generic;

namespace b1;

public class FBehaviorRightNodeInstance_Sequence : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.Sequence;

	protected override void TriggerInput(string InputPin)
	{
		foreach (KeyValuePair<string, FBehaviorGraphRightEdge> rightEdge in base.RightEdges)
		{
			rightEdge.Value.ExecuteOutput();
		}
		Finish();
	}
}
