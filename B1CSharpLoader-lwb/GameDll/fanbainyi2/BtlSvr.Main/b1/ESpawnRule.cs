using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SpawnRule")]
public enum ESpawnRule : byte
{
	Random,
	RandomLeast,
	First
}
