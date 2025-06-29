using System.Collections.Generic;
using System.Linq;
using CommB1;
using Google.Protobuf;

namespace b1;

public class BehaviorRightNodeInstance_CastSkillByScore : FBehaviorRightNodeInstance
{
	private List<FOneCBGCastSkillInfoCS> SkillInfoListCached = new List<FOneCBGCastSkillInfoCS>();

	public override string NodeName => B1CalliopeDef.BehaviorNode.CastSkillByScore;

	private BehaviorCustom_CastSkillByScore CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_CastSkillByScore();
		CustomData.MergeFrom(base.Node.NodeData);
		SkillInfoListCached.Clear();
		if (CustomData.SkillInfoList.Count <= 0)
		{
			return;
		}
		foreach (OneCBGCastSkillInfo skillInfo in CustomData.SkillInfoList)
		{
			if (skillInfo != null)
			{
				SkillInfoListCached.Add(new FOneCBGCastSkillInfoCS(skillInfo));
			}
		}
	}

	protected override void TriggerInput(string InputPin)
	{
		bool isGetTopRandomSkill = CustomData.IsGetTopRandomSkill;
		int topRandomSkillPercent = CustomData.TopRandomSkillPercent;
		bool needTryCastAllSkillUntilSuccess = CustomData.NeedTryCastAllSkillUntilSuccess;
		base.BUSEventCollection.Evt_AICastBestSkillByScore.Invoke(SkillInfoListCached.ToList(), isGetTopRandomSkill, topRandomSkillPercent, needTryCastAllSkillUntilSuccess);
	}
}
