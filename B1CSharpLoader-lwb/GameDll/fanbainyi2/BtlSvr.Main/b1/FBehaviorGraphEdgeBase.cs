namespace b1;

public abstract class FBehaviorGraphEdgeBase
{
	public FCalliopeEdge Edge { get; set; }

	public BUS_BehaviorGraphComp.FBehaviorInstance ParentInstance { get; set; }

	public int IsInputSuccess()
	{
		int num = 0;
		if (this is IFromLeftNodeEdge fromLeftNodeEdge)
		{
			num = fromLeftNodeEdge.FromNodeInstance.QueryConditionSuccess();
			if (num == 0)
			{
				return 0;
			}
			if (fromLeftNodeEdge.bFromFailedPin)
			{
				return -num;
			}
		}
		return num;
	}

	public void ExecuteOutput()
	{
		if (this is IToRightNodeEdge toRightNodeEdge)
		{
			toRightNodeEdge.ToNodeInstance.NotifyTriggerInput(Edge.ToPinName);
		}
	}
}
