using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.WaveStopActionType")]
public enum EWaveStopActionType : byte
{
	[DisplayName("销毁所有已生成的单位")]
	DestroyAllSpawnedUnits,
	[DisplayName("所有已生成的单位触发‘回家’")]
	SpawnedUnitsReturnHome
}
