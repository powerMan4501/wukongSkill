using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.EStrandsTexturesMeshType", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EStrandsTexturesMeshType : byte
{
	Static,
	Skeletal
}
