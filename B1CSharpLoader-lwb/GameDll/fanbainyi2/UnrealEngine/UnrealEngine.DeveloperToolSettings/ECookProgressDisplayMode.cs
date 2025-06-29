using UnrealEngine.Runtime;

namespace UnrealEngine.DeveloperToolSettings;

[UEnum]
[UMetaPath("/Script/DeveloperToolSettings.ECookProgressDisplayMode", "DeveloperToolSettings", UnrealModuleType.Engine)]
public enum ECookProgressDisplayMode
{
	Nothing,
	RemainingPackages,
	PackageNames,
	NamesAndRemainingPackages,
	Instigators,
	InstigatorsAndCount,
	InstigatorsAndNames,
	InstigatorsAndNamesAndCount,
	Max
}
