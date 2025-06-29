using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[UMetaPath("/Script/SlateCore.EFocusCause", "SlateCore", UnrealModuleType.Engine)]
public enum EFocusCause
{
	Mouse,
	Navigation,
	SetDirectly,
	Cleared,
	OtherWidgetLostFocus,
	WindowActivate
}
