using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class PsmStateNodeInstance_CastSkill : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.CastSkill";

	private ProcessStateCustom_CastSkill CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_CastSkill();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetOwner(), CustomData.UnitGuid);
		if (actorByGuid != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null)
			{
				int skillId = CustomData.SkillId;
				bool needCheckSkillCanCast = CustomData.NeedCheckSkillCanCast;
				FCastSkillInfo cSI = new FCastSkillInfo(skillId, ECastSkillSourceType.CPG);
				cSI.NeedCheckSkillCanCast = needCheckSkillCanCast;
				bUS_GSEventCollection.Evt_UnitCastSkillTry.Invoke(cSI);
			}
		}
		TriggerFirstOutput(bFinish: true);
	}
}
