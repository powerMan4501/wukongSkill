namespace UnrealEngine.Runtime;

public class SetCoroutineGroup : YieldInstruction
{
	public CoroutineGroup Group { get; set; }

	public override bool KeepWaiting => false;

	public SetCoroutineGroup(CoroutineGroup group)
	{
		Group = group;
	}

	public override void OnBegin()
	{
		base.Owner.Group = Group;
	}

	internal SetCoroutineGroup PoolNew(CoroutineGroup group)
	{
		Group = group;
		return this;
	}
}
