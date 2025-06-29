using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_AITransformModifyBySplineData
{
	bool bShowDebug { get; }

	FGameplayTag SplineGuid { get; }

	float RemainTime { get; }

	AActor Target { get; }

	FTransform TargetTransform { get; }

	bool bCanAdjust { get; }

	ETransformBySplineType SourceType { get; }

	BGUSplineActor SplineActorRef { get; }

	BANS_GSBase BANSRef { get; }

	BAIT_Base BAITRef { get; }

	ETransformBySplineRotateType RotateType { get; }
}
