using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.KillUnitMapResult")]
public enum EKillUnitMapResult : byte
{
	[DisplayName("爆头")]
	HeadShot,
	[DisplayName("肢解")]
	RandomCut,
	[DisplayName("炸碎")]
	Boom
}
