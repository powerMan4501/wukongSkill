using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EPS5UsbStorageErrorCode", "UnrealExtent", UnrealModuleType.Game)]
public enum EPS5UsbStorageErrorCode : byte
{
	DeviceDoesNotExist,
	TargetDirNotExist,
	TargetDirIsUsedByAnotherProcess,
	TargetDirIsNotInParamJson,
	MapNumMax,
	TargetDirIsFile,
	MkSubDirFailed,
	Unknown,
	Success
}
