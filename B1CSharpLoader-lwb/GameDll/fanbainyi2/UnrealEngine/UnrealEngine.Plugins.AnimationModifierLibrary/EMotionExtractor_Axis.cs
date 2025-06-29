using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AnimationModifierLibrary;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AnimationModifierLibrary.EMotionExtractor_Axis", "AnimationModifierLibrary", UnrealModuleType.EnginePlugin)]
public enum EMotionExtractor_Axis : byte
{
	X,
	Y,
	Z,
	XY,
	XZ,
	YZ,
	XYZ
}
