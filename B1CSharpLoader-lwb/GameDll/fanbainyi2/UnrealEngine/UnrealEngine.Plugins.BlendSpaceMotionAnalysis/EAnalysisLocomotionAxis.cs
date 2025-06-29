using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.BlendSpaceMotionAnalysis;

[UEnum]
[UMetaPath("/Script/BlendSpaceMotionAnalysis.EAnalysisLocomotionAxis", "BlendSpaceMotionAnalysis", UnrealModuleType.EnginePlugin)]
public enum EAnalysisLocomotionAxis
{
	Speed,
	Direction,
	ForwardSpeed,
	RightwardSpeed,
	UpwardSpeed,
	ForwardSlope,
	RightwardSlope
}
