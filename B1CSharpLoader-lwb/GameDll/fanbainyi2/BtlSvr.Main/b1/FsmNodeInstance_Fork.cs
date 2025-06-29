namespace b1;

public class FsmNodeInstance_Fork : FsmNodeInstance
{
	protected override void OnExecuteNode()
	{
		ExecuteAllOut();
	}
}
