using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SpawnWaveType")]
public enum ESpawnWaveType : byte
{
	[UMeta(MD.DisplayName, "依次生成")]
	SpawnSequence,
	[UMeta(MD.DisplayName, "循环生成")]
	SpawnInfinite
}
