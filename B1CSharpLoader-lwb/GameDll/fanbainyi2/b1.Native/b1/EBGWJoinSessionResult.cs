using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBGWJoinSessionResult", "b1", UnrealModuleType.Game)]
public enum EBGWJoinSessionResult : byte
{
	Success,
	SessionIsFull,
	SessionDoesNotExist,
	CouldNotRetrieveAddress,
	AlreadyInSession,
	UnknownError
}
