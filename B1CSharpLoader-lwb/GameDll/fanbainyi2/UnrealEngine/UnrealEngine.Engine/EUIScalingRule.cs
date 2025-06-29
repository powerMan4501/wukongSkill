using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EUIScalingRule", "Engine", UnrealModuleType.Engine)]
public enum EUIScalingRule
{
	ShortestSide,
	LongestSide,
	Horizontal,
	Vertical,
	ScaleToFit,
	Custom
}
