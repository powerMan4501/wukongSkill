using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[UMetaPath("/Script/SlateCore.ENavigationSource", "SlateCore", UnrealModuleType.Engine)]
public enum ENavigationSource
{
	FocusedWidget,
	WidgetUnderCursor
}
