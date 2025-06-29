using System;
using System.Collections.Generic;

namespace b1;

public abstract class FBehaviorLeftNodeInstance : FBehaviorNodeInstanceBase
{
	public override bool bLeftNode => true;

	public Func<FBehaviorLeftNodeInstance, int> NodeCondition { get; set; }

	public Dictionary<string, FBehaviorGraphLeftEdge> LeftEdges { get; } = new Dictionary<string, FBehaviorGraphLeftEdge>();

	public int ConditionCoolDownTimeMs { get; protected set; }

	public int QueryConditionSuccess()
	{
		return IsSuccess();
	}

	protected virtual int IsSuccess()
	{
		return NodeCondition(this);
	}
}
