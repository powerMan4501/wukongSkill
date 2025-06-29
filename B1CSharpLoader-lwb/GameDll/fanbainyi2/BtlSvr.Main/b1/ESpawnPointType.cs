using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.SpawnPointType")]
public enum ESpawnPointType : byte
{
	[UMeta(MD.DisplayName, "使用生成点")]
	UseSpawnPoints,
	[UMeta(MD.DisplayName, "使用EQS选点")]
	UseEQS,
	[UMeta(MD.DisplayName, "使用本地空间固定偏移")]
	UseLocalSpaceOffset
}
