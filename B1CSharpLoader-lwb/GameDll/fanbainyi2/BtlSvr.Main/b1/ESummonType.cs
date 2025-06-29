using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SummonType")]
public enum ESummonType : byte
{
	Normal,
	PhantomRush,
	Hatch,
	MonsterSpawn,
	NeutralAnimSpawn
}
