using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.EGroomGeometryType", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EGroomGeometryType : byte
{
	Strands,
	Cards,
	Meshes
}
