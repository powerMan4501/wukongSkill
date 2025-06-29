using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[DisplayName("可破坏物强度")]
[USharpPath("/Script/b1-Managed.DestructibleMassLevel")]
public enum DestructibleMassLevel : byte
{
	[DisplayName("任意摧毁")]
	Basic,
	[DisplayName("主角行走摧毁")]
	WalkDestroy,
	[DisplayName("主角跑步摧毁")]
	RunDestroy,
	[DisplayName("主角冲刺摧毁")]
	SprintDestroy,
	[DisplayName("大型怪摧毁")]
	GiantDestroy,
	[DisplayName("不可移动撞碎")]
	Indestructible
}
