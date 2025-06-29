using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EPS5UsbWriteErrorCode", "UnrealExtent", UnrealModuleType.Game)]
public enum EPS5UsbWriteErrorCode : byte
{
	NoAvailableSpace,
	OpenIOError,
	WriteIOError,
	NoUsbStorageDevice,
	Unknown,
	Success,
	NotSupport
}
