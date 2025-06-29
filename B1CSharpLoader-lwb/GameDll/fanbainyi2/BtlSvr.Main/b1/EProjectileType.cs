using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ProjectileType")]
public enum EProjectileType : byte
{
	None,
	Bullet,
	MagicField
}
