using System.Collections.Generic;

namespace b1;

public class BUC_BulletSweepReactionData : b1.IBUC_BulletSweepReactionData
{
	public Dictionary<int, FBulletSweepReactionInfo> BeHitedTriggerEffectIDs { get; set; }

	public Dictionary<int, FBulletSweepReactionInfo> SweepBuffTriggerEffectIDs { get; set; }

	public Dictionary<EBGUSimpleState, FBulletSweepReactionInfo> SweepSimpleStateTriggerEffectIDs { get; set; }

	public Dictionary<int, FBulletSweepReactionInfo> GetBeHitedTriggerEffectIDs()
	{
		return new Dictionary<int, FBulletSweepReactionInfo>(BeHitedTriggerEffectIDs);
	}

	public Dictionary<int, FBulletSweepReactionInfo> GetSweepBuffTriggerEffectIDs()
	{
		return new Dictionary<int, FBulletSweepReactionInfo>(SweepBuffTriggerEffectIDs);
	}

	public Dictionary<EBGUSimpleState, FBulletSweepReactionInfo> GetSweepSimpleStateTriggerEffectIDs()
	{
		return new Dictionary<EBGUSimpleState, FBulletSweepReactionInfo>(SweepSimpleStateTriggerEffectIDs);
	}

	public BUC_BulletSweepReactionData()
	{
		BeHitedTriggerEffectIDs = new Dictionary<int, FBulletSweepReactionInfo>();
		SweepBuffTriggerEffectIDs = new Dictionary<int, FBulletSweepReactionInfo>();
		SweepSimpleStateTriggerEffectIDs = new Dictionary<EBGUSimpleState, FBulletSweepReactionInfo>();
	}

	public void ClearSweepReactionInfo()
	{
		BeHitedTriggerEffectIDs.Clear();
		SweepBuffTriggerEffectIDs.Clear();
		SweepSimpleStateTriggerEffectIDs.Clear();
	}

	public void SetSweepReactionInfo(BGWDataAsset_BulletSweepReactionConfig DataAsset)
	{
		ClearSweepReactionInfo();
		if (DataAsset == null)
		{
			return;
		}
		if (DataAsset.UseBeHitedReactionConfig)
		{
			foreach (BulletBeAttackedReactionInfo item in DataAsset.BulletBeHitedReactionConfigInfo)
			{
				if (BeHitedTriggerEffectIDs.TryGetValue(item.CheckID, out var value))
				{
					value.Combine(new FBulletSweepReactionInfo(item));
				}
				else
				{
					BeHitedTriggerEffectIDs.Add(item.CheckID, new FBulletSweepReactionInfo(item));
				}
			}
		}
		if (DataAsset.UseSweepBuffReactionConfig)
		{
			foreach (BulletSweepReactionInfo item2 in DataAsset.BulletSweepBuffReactionConfigInfo)
			{
				if (SweepBuffTriggerEffectIDs.TryGetValue(item2.CheckID, out var value2))
				{
					value2.Combine(new FBulletSweepReactionInfo(item2));
				}
				else
				{
					SweepBuffTriggerEffectIDs.Add(item2.CheckID, new FBulletSweepReactionInfo(item2));
				}
			}
		}
		if (!DataAsset.UseSweepSimpleStateReactionConfig)
		{
			return;
		}
		foreach (BulletSweepSimpleStateReactionInfo item3 in DataAsset.BulletSweepSimpleStateReactionConfigInfo)
		{
			if (SweepSimpleStateTriggerEffectIDs.TryGetValue(item3.ConditionSimpleState, out var value3))
			{
				value3.Combine(new FBulletSweepReactionInfo(item3));
			}
			else
			{
				SweepSimpleStateTriggerEffectIDs.Add(item3.ConditionSimpleState, new FBulletSweepReactionInfo(item3));
			}
		}
	}
}
