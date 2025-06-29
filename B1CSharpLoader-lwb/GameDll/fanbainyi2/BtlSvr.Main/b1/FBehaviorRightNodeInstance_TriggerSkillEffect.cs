using BtlShare;
using CommB1;
using Google.Protobuf;

namespace b1;

public class FBehaviorRightNodeInstance_TriggerSkillEffect : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.TriggerSkillEffect;

	public BehaviorCustom_TriggerSkillEffect CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_TriggerSkillEffect();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		FEffectInstReq fEffectInstReq = new FEffectInstReq(base.Owner);
		fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(base.Owner);
		fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(base.Owner);
		fEffectInstReq.HitActionDir = EHitActionDir.Default;
		FEffectInstReq effectInstReq = fEffectInstReq;
		base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(CustomData.EffectId, effectInstReq);
	}
}
