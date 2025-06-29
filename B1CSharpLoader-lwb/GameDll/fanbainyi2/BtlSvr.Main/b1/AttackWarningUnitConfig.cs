using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class AttackWarningUnitConfig
{
	[UProperty]
	public UAnimSequenceBase Animation;

	public float NotifyBeginTime;

	public string NotifyID { get; set; }

	public int ObjectID { get; set; }

	public int WeaponIndex { get; set; }

	public EHitActionDir HitActionDir { get; set; }

	public int HitLevel { get; set; }

	public List<FUStCheckShape> AttackWarnningCheckShape { get; set; }

	public List<FTransform> TransformList { get; set; }

	public List<AActor> IgnoreActors { get; set; }

	public FVector FixedLocalOffset { get; set; }

	public ESweepCheckHitFilterType ResultFilterType { get; set; }

	public int AttackWarnningGroupID { get; set; }

	public int FromInstanceID { get; set; }

	public bool bCanTick { get; set; }

	public bool bPaused { get; set; }

	public float DetectDistance { get; set; }

	public FName DetectSocketName { get; set; }

	public USkeletalMeshComponent SKComp { get; set; }

	public float TotalDuration { get; set; }

	public float AlreadyTickTime { get; set; }
}
