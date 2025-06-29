using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.EGroomBindingType", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EGroomBindingType : byte
{
	NoneBinding,
	Rigid,
	Skinning
}
