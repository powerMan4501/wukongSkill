using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ProjectileSpawnerType")]
public enum EProjectileSpawnerType : byte
{
	[DisplayName("效果发起者")]
	EffectCaster,
	[DisplayName("效果目标")]
	EffectTarget,
	[DisplayName("效果RootCaster")]
	EffectRootCaster
}
