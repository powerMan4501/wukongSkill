using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class FBehaviorRightNodeInstance_CastSkill : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.CastSkill;

	private BehaviorCustom_CastSkill CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_CastSkill();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		if (!CustomData.CanCastWhenDead)
		{
			BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(base.Owner);
			if ((readOnlyData != null && readOnlyData.HasState(EBGUUnitState.Dead)) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(base.Owner, EBGUSimpleState.PendingDeathInAnimationSyncing))
			{
				return;
			}
		}
		int skillId = CustomData.SkillId;
		FCastSkillInfo fCastSkillInfo = new FCastSkillInfo(skillId, ECastSkillSourceType.CBG);
		fCastSkillInfo.NeedCheckSkillCanCast = CustomData.NeedCheckSkillCanCast;
		fCastSkillInfo.MontageStartSectionName = new FName(CustomData.MontageStartSectionName);
		FCastSkillInfo cSI = fCastSkillInfo;
		base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(cSI);
	}
}
