using System.Collections.Generic;

namespace b1;

public class FBehaviorLeftNodeInstance_LogicAnd : FBehaviorLeftNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.LogicalAnd;

	protected override int IsSuccess()
	{
		foreach (KeyValuePair<string, FBehaviorGraphLeftEdge> leftEdge in base.LeftEdges)
		{
			int num = leftEdge.Value.IsInputSuccess();
			if (num == 0)
			{
				return 0;
			}
			if (num < 0)
			{
				return -1;
			}
		}
		return 1;
	}
}
