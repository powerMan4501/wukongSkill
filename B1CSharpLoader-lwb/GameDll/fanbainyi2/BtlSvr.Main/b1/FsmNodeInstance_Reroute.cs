namespace b1;

public class FsmNodeInstance_Reroute : FsmNodeInstance
{
	protected override void OnExecuteNode()
	{
		ExecuteFirstOut();
	}
}
