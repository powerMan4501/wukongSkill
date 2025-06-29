using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.AnimalDistributionSpawnTendency")]
public enum EAnimalDistributionSpawnTendency : byte
{
	[DisplayName("集中分布")]
	Concentrated,
	[DisplayName("随机分布")]
	Random
}
