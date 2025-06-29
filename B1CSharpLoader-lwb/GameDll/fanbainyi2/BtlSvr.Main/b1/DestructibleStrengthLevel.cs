using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[DisplayName("可破坏物受击强度")]
[USharpPath("/Script/b1-Managed.DestructibleStrengthLevel")]
public enum DestructibleStrengthLevel : byte
{
	[DisplayName("轻力打击可摧毁")]
	LightHitDestroy = 0,
	[DisplayName("中力打击可摧毁")]
	MediumHitDestroy = 1,
	[DisplayName("重力打击可摧毁")]
	HeavyHitDestroy = 2,
	[DisplayName("仅怪力打击可摧毁")]
	SpecialHitDestroy = 3,
	[DisplayName("不可攻击摧毁")]
	Indestructible = 99
}
