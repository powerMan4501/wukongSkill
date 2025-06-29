using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraph;

[UEnum]
[UMetaPath("/Script/AnimGraph.ETransitionGetter", "AnimGraph", UnrealModuleType.Engine)]
public enum ETransitionGetter
{
	AnimationAsset_GetCurrentTime,
	AnimationAsset_GetLength,
	AnimationAsset_GetCurrentTimeFraction,
	AnimationAsset_GetTimeFromEnd,
	AnimationAsset_GetTimeFromEndFraction,
	CurrentState_ElapsedTime,
	CurrentState_GetBlendWeight,
	CurrentTransitionDuration,
	ArbitraryState_GetBlendWeight
}
