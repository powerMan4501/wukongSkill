using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EPS5RequestUnMapUsbErrorCode", "UnrealExtent", UnrealModuleType.Game)]
public enum EPS5RequestUnMapUsbErrorCode : byte
{
	DeviceDoesNotExist,
	TargetDirNotMap,
	Unknown,
	Success,
	NotSupport
}
