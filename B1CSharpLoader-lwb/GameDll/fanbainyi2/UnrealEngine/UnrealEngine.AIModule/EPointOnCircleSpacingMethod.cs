using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EPointOnCircleSpacingMethod", "AIModule", UnrealModuleType.Engine)]
public enum EPointOnCircleSpacingMethod
{
	BySpaceBetween,
	ByNumberOfPoints
}
