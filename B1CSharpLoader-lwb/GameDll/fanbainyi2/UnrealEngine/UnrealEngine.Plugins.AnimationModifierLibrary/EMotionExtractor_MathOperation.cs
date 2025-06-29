using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AnimationModifierLibrary;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AnimationModifierLibrary.EMotionExtractor_MathOperation", "AnimationModifierLibrary", UnrealModuleType.EnginePlugin)]
public enum EMotionExtractor_MathOperation : byte
{
	None,
	Addition,
	Subtraction,
	Division,
	Multiplication
}
