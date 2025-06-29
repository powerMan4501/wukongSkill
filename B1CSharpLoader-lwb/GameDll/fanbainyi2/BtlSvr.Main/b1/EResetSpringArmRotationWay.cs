using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ResetSpringArmRotationWay")]
public enum EResetSpringArmRotationWay : byte
{
	[DisplayName("不重置")]
	None,
	[DisplayName("使用主角同朝向")]
	Reset2PlayerRotation,
	[DisplayName("根据当前镜头位置测算朝向")]
	Reset2NearestRotation,
	[DisplayName("使用自定义朝向")]
	UseCustomRotation
}
