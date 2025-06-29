namespace b1;

public class FsmNodeInstance_Join : FsmNodeInstance
{
	private int JoinCount { get; set; }

	private int CurrentCount { get; set; }

	protected override void OnInitialize()
	{
		JoinCount = base.Node.InputEdges.Count;
		CurrentCount = 0;
	}

	protected override void OnExecuteNode()
	{
		CurrentCount++;
		if (CurrentCount >= JoinCount)
		{
			CurrentCount = 0;
			ExecuteFirstOut();
		}
	}
}
