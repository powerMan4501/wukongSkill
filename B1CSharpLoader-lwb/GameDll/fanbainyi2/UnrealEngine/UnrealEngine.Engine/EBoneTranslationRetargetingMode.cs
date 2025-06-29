using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EBoneTranslationRetargetingMode", "Engine", UnrealModuleType.Engine)]
public enum EBoneTranslationRetargetingMode
{
	Animation,
	Skeleton,
	AnimationScaled,
	AnimationRelative,
	OrientAndScale
}
