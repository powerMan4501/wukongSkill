using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[UEnum]
[UMetaPath("/Script/JavascriptUMG.EJavascriptWindowType", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public enum EJavascriptWindowType
{
	Normal,
	Menu,
	ToolTip,
	Notification,
	CursorDecorator
}
