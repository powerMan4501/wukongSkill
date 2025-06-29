namespace b1;

public class FsmNodeInstance_Terminate : FsmNodeInstance
{
	protected override void OnExecuteNode()
	{
		base.ParentInstance.OnTerminate();
	}
}
