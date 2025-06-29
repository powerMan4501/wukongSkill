using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.LocationServicesBPLibrary;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/LocationServicesBPLibrary.ELocationAccuracy", "LocationServicesBPLibrary", UnrealModuleType.EnginePlugin)]
public enum ELocationAccuracy : byte
{
	LA_ThreeKilometers,
	LA_OneKilometer,
	LA_HundredMeters,
	LA_TenMeters,
	LA_Best,
	LA_Navigation
}
