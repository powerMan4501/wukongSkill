using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.ERotationComponent", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum ERotationComponent
{
	EulerX,
	EulerY,
	EulerZ,
	QuaternionAngle,
	SwingAngle,
	TwistAngle
}
