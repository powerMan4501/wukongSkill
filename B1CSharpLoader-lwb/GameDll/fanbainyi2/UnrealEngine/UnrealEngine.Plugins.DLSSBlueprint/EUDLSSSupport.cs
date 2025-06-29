using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DLSSBlueprint;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/DLSSBlueprint.UDLSSSupport", "DLSSBlueprint", UnrealModuleType.EnginePlugin)]
public enum EUDLSSSupport : byte
{
	Supported,
	NotSupported,
	NotSupportedIncompatibleHardware,
	NotSupportedDriverOutOfDate,
	NotSupportedOperatingSystemOutOfDate,
	NotSupportedByPlatformAtBuildTime,
	NotSupportedIncompatibleAPICaptureToolActive
}
