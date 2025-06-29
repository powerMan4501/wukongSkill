using CommB1;
using Google.Protobuf;

namespace b1;

public class QuestNodeInstance_PlayerCondition : QuestNodeInstance
{
	private QuestCustom_PlayerCastSkillConditionGroupList CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_PlayerCastSkillConditionGroupList();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
	}

	public override void Tick(float DeltaTime)
	{
		base.Tick(DeltaTime);
		CheckCondition();
	}

	private void CheckCondition()
	{
		BGU_CommonUtil.GetCurrentPlayer(base.Owner, out var Player);
		if (Player == null)
		{
			return;
		}
		foreach (QuestCustom_PlayerCastSkillConditionGroup conditionGroup in CustomData.ConditionGroups)
		{
			if (BGUPlayerConditionCheckHelper.CheckAndConditionGroup(Player, conditionGroup))
			{
				TriggerOutput(conditionGroup.Describe, bFinish: true);
				break;
			}
		}
	}

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
