using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[DisplayName("法术场检测Comp碰撞预设类型")]
[USharpPath("/Script/b1-Managed.Type_CheckCompProfileName_MagicField")]
public enum Type_CheckCompProfileName_MagicField : byte
{
	[DisplayName("Normal")]
	NormalMagicField,
	[DisplayName("只检测PhysicsBody")]
	JustCheckPhysicsBody
}
