namespace b1;

public class FBehaviorRightNodeInstance_PlayPigsyStory : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.PlayPigsyStory;

	protected override void PostCreate()
	{
	}

	protected override void TriggerInput(string InputPin)
	{
		base.BUSEventCollection?.Evt_PlayPigsyStory.Invoke();
	}
}
