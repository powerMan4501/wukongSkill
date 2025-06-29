using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.StreamlineBlueprint;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/StreamlineBlueprint.UStreamlineFeatureRequirementsFlags", "StreamlineBlueprint", UnrealModuleType.EnginePlugin)]
public enum EUStreamlineFeatureRequirementsFlags : byte
{
	None = 0,
	D3D11Supported = 1,
	D3D12Supported = 2,
	VulkanSupported = 4,
	VSyncOffRequired = 8,
	HardwareSchedulingRequired = 0x10
}
