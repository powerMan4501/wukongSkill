using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationCore;

[UEnum]
[UMetaPath("/Script/AnimationCore.ETransformConstraintType", "AnimationCore", UnrealModuleType.Engine)]
public enum ETransformConstraintType
{
	Translation,
	Rotation,
	Scale,
	Parent
}
