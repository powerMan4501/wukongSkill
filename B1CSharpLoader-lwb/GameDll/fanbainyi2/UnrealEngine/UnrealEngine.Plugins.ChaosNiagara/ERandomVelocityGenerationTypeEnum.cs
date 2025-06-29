using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ChaosNiagara;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ChaosNiagara.ERandomVelocityGenerationTypeEnum", "ChaosNiagara", UnrealModuleType.EnginePlugin)]
public enum ERandomVelocityGenerationTypeEnum : byte
{
	ChaosNiagara_RandomVelocityGenerationType_RandomDistribution,
	ChaosNiagara_RandomVelocityGenerationType_RandomDistributionWithStreamers,
	ChaosNiagara_RandomVelocityGenerationType_CollisionNormalBased,
	ChaosNiagara_Max
}
