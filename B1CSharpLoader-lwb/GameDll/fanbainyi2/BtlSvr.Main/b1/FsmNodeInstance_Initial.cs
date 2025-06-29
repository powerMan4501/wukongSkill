namespace b1;

public class FsmNodeInstance_Initial : FsmNodeInstance
{
	protected override void OnExecuteNode()
	{
		ExecuteFirstOut();
	}
}
