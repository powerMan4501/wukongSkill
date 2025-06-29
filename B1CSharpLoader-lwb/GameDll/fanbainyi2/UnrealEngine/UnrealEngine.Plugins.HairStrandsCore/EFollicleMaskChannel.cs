using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.EFollicleMaskChannel", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EFollicleMaskChannel : byte
{
	R,
	G,
	B,
	A
}
