using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationCore;

[UEnum]
[UMetaPath("/Script/AnimationCore.EEulerRotationOrder", "AnimationCore", UnrealModuleType.Engine)]
public enum EEulerRotationOrder
{
	XYZ,
	XZY,
	YXZ,
	YZX,
	ZXY,
	ZYX
}
