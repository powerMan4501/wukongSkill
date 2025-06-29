using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EBGUBulletDispReason")]
public enum EBGUBulletDispReason : byte
{
	None,
	Spawn,
	HitChr,
	HitSceneItem,
	LifeOver,
	BeHit
}
