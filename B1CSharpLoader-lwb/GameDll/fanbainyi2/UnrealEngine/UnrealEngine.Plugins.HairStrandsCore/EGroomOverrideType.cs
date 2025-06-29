using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.EGroomOverrideType", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EGroomOverrideType : byte
{
	Auto,
	Enable,
	Disable
}
