using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_AITransformModifyBySplineData : IBUC_AITransformModifyBySplineData
{
	private TWeakObject<BGUSplineActor> mSplineActorRef;

	private TWeakObject<BANS_GSBase> mBANSRef;

	private TWeakObject<BAIT_Base> mBAITRef;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	public bool bShowDebug { get; set; }

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	public FGameplayTag SplineGuid { get; set; }

	public float RemainTime { get; set; }

	public FTransform TargetTransform { get; set; }

	public bool bCanAdjust { get; set; }

	public ETransformBySplineType SourceType { get; set; }

	public ETransformBySplineRotateType RotateType { get; set; }

	public AActor Target { get; set; }

	public BGUSplineActor SplineActorRef
	{
		get
		{
			return mSplineActorRef.Get();
		}
		set
		{
			mSplineActorRef.Set(value);
		}
	}

	public BANS_GSBase BANSRef
	{
		get
		{
			return mBANSRef.Get();
		}
		set
		{
			mBANSRef.Set(value);
		}
	}

	public BAIT_Base BAITRef
	{
		get
		{
			return mBAITRef.Get();
		}
		set
		{
			mBAITRef.Set(value);
		}
	}
}
