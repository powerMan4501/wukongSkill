using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EPS5UsbSelectErrorCode", "UnrealExtent", UnrealModuleType.Game)]
public enum EPS5UsbSelectErrorCode : byte
{
	UsrNotInit,
	UsrParamError,
	OperationCantBeUsed,
	UsrCancel,
	Unknown,
	Success,
	NotSupport
}
