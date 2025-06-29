using UnrealEngine.Runtime;

namespace UnrealEngine.TimeManagement;

[UEnum]
[UMetaPath("/Script/TimeManagement.ETimedDataInputState", "TimeManagement", UnrealModuleType.Engine)]
public enum ETimedDataInputState
{
	Connected,
	Unresponsive,
	Disconnected
}
