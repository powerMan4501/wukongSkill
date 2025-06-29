using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.BlendSpaceMotionAnalysis;

[UEnum]
[UMetaPath("/Script/BlendSpaceMotionAnalysis.EAnalysisRootMotionAxis", "BlendSpaceMotionAnalysis", UnrealModuleType.EnginePlugin)]
public enum EAnalysisRootMotionAxis
{
	Speed,
	Direction,
	ForwardSpeed,
	RightwardSpeed,
	UpwardSpeed,
	ForwardSlope,
	RightwardSlope
}
