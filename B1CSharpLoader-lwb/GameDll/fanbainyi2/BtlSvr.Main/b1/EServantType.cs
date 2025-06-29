using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ServantType")]
public enum EServantType : byte
{
	None,
	Normal,
	Dummy,
	Clone,
	PhantomRush,
	MonsterSpawn,
	NeutralAnimSpawn
}
