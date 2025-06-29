using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.StartJumpSpdState")]
public enum EStartJumpSpdState : byte
{
	[DisplayName("原地起跳")]
	StartJumpSpdState_Zero,
	[DisplayName("移动起跳")]
	StartJumpSpdState_Normal,
	[DisplayName("冲刺起跳")]
	StartJumpSpdState_Fast
}
