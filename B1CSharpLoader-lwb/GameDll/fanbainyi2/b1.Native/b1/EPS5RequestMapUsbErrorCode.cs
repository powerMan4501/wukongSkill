using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EPS5RequestMapUsbErrorCode", "UnrealExtent", UnrealModuleType.Game)]
public enum EPS5RequestMapUsbErrorCode : byte
{
	DeviceDoesNotExist,
	TargetDirNotExist,
	TargetDirIsUsedByAnotherProcess,
	TargetDirIsNotInParamJson,
	MkSubDirFailed,
	MapNumMax,
	Unknown,
	Success,
	NotSupport
}
