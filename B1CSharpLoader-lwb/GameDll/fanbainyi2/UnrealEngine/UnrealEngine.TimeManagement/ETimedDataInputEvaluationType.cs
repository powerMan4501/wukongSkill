using UnrealEngine.Runtime;

namespace UnrealEngine.TimeManagement;

[UEnum]
[UMetaPath("/Script/TimeManagement.ETimedDataInputEvaluationType", "TimeManagement", UnrealModuleType.Engine)]
public enum ETimedDataInputEvaluationType
{
	None,
	Timecode,
	PlatformTime
}
