using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.AnimationCompressionFormat", "Engine", UnrealModuleType.Engine)]
public enum EAnimationCompressionFormat
{
	ACF_None,
	ACF_Float96NoW,
	ACF_Fixed48NoW,
	ACF_IntervalFixed32NoW,
	ACF_Fixed32NoW,
	ACF_Float32NoW,
	ACF_Identity
}
