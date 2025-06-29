using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FSweepCheckUnitConfig
{
	public int TriggerSkillID;

	public string NotifyID;

	public int ObjectID;

	public int WeaponIndex;

	public List<FUStCheckShape> SweepCheckShape;

	public List<AbnormalStateAccConfig> AbnormalStateEffectList;

	public List<FTriggerEffectWithCondition> EffectsWithCondition_Before;

	public List<int> EffectIDList;

	public List<FTriggerEffectWithCondition> EffectsWithCondition_After;

	public List<int> EffectIDListForSceneItem;

	public FHitDestructibleActorConfig HitDestructibleActorConfig;

	public int HitChrAudioID;

	public int HitChrFXWeight;

	public FHitCheckConf HitCheckConf;

	public bool CanHitProjectile;

	public List<FTransform> TransformList;

	public float SweepCheckProtectTime;

	public List<AActor> IgnoreActors;

	public float BeginTimeWorldSeconds;

	public float NotifyBeginTime;

	public float PassedTime;

	[UProperty]
	public UAnimSequenceBase Animation;

	[UProperty]
	public UAnimMontage SPAtkReboundingAM;

	[UProperty]
	public UAnimMontage LowSPAtkReboundingAM;

	public int SweepCheckGroupID;

	public int FromInstanceID;

	public bool bPaused { get; set; }

	public int HasSameShape(FUStCheckShape ShapeToCompare, int GroupID)
	{
		if (GroupID == SweepCheckGroupID)
		{
			for (int i = 0; i < SweepCheckShape.Count; i++)
			{
				FUStCheckShape fUStCheckShape = SweepCheckShape[i];
				if (ShapeToCompare.SocketName == fUStCheckShape.SocketName && ShapeToCompare.Radius == fUStCheckShape.Radius && ShapeToCompare.Scale == fUStCheckShape.Scale && ShapeToCompare.IsCapsuleShape == fUStCheckShape.IsCapsuleShape && ShapeToCompare.SKComp == fUStCheckShape.SKComp && ShapeToCompare.Rotation == fUStCheckShape.Rotation)
				{
					return i;
				}
			}
		}
		return -1;
	}
}
