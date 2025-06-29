using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[UMetaPath("/Script/SlateCore.ESlateDebuggingStateChangeEvent", "SlateCore", UnrealModuleType.Engine)]
public enum ESlateDebuggingStateChangeEvent
{
	MouseCaptureGained,
	MouseCaptureLost
}
