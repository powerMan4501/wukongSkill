using System.Collections.Generic;

namespace b1;

public class FBulletSweepReactionInfo
{
	public List<int> TriggerEffectID;

	public List<int> AttackerTriggerEffectID;

	public FBulletSweepReactionInfo(BulletBeAttackedReactionInfo ReactionInfo)
	{
		TriggerEffectID = new List<int>(ReactionInfo.TriggerEffectID);
		AttackerTriggerEffectID = new List<int>(ReactionInfo.AttackerTriggerEffectID);
	}

	public FBulletSweepReactionInfo(BulletSweepReactionInfo ReactionInfo)
	{
		TriggerEffectID = new List<int>(ReactionInfo.TriggerEffectID);
		AttackerTriggerEffectID = new List<int>();
	}

	public FBulletSweepReactionInfo(BulletSweepSimpleStateReactionInfo ReactionInfo)
	{
		TriggerEffectID = new List<int>(ReactionInfo.TriggerEffectID);
		AttackerTriggerEffectID = new List<int>();
	}

	public void Combine(FBulletSweepReactionInfo OtherInfo)
	{
		TriggerEffectID.AddRange(OtherInfo.TriggerEffectID);
		AttackerTriggerEffectID.AddRange(OtherInfo.AttackerTriggerEffectID);
	}
}
