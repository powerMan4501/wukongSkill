using UnrealEngine.Runtime;

namespace UnrealEngine.TimeManagement;

[UEnum]
[UMetaPath("/Script/TimeManagement.EFrameNumberDisplayFormats", "TimeManagement", UnrealModuleType.Engine)]
public enum EFrameNumberDisplayFormats
{
	NonDropFrameTimecode,
	DropFrameTimecode,
	Seconds,
	Frames,
	MAX_Count
}
