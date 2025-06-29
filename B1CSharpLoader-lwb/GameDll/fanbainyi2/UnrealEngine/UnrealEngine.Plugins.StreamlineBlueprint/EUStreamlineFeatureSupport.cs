using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.StreamlineBlueprint;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/StreamlineBlueprint.UStreamlineFeatureSupport", "StreamlineBlueprint", UnrealModuleType.EnginePlugin)]
public enum EUStreamlineFeatureSupport : byte
{
	Supported,
	NotSupported,
	NotSupportedIncompatibleHardware,
	NotSupportedDriverOutOfDate,
	NotSupportedOperatingSystemOutOfDate,
	NotSupportedHardewareSchedulingDisabled,
	NotSupportedByRHI,
	NotSupportedByPlatformAtBuildTime,
	NotSupportedIncompatibleAPICaptureToolActive
}
