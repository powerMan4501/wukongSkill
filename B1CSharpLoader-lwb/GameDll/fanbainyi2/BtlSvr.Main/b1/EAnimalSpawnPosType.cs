using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.AnimalSpawnPosType")]
public enum EAnimalSpawnPosType : byte
{
	[DisplayName("实时EQS")]
	EQS_Runtime,
	[DisplayName("预置点集")]
	PresetPointset
}
