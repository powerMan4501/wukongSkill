using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[UMetaPath("/Script/SlateCore.ESlateDebuggingFocusEvent", "SlateCore", UnrealModuleType.Engine)]
public enum ESlateDebuggingFocusEvent
{
	FocusChanging,
	FocusLost,
	FocusReceived
}
