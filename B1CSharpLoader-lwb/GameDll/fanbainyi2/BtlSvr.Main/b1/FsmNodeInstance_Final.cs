namespace b1;

public class FsmNodeInstance_Final : FsmNodeInstance
{
	protected override void OnExecuteNode()
	{
		base.ParentInstance.Shutdown();
	}
}
