using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AnimationModifierLibrary;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AnimationModifierLibrary.EMotionExtractor_MotionType", "AnimationModifierLibrary", UnrealModuleType.EnginePlugin)]
public enum EMotionExtractor_MotionType : byte
{
	Translation,
	Rotation,
	Scale,
	TranslationSpeed,
	RotationSpeed
}
