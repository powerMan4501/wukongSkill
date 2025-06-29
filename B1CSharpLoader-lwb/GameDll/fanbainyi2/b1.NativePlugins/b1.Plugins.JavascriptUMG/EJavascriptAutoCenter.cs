using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[UEnum]
[UMetaPath("/Script/JavascriptUMG.EJavascriptAutoCenter", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public enum EJavascriptAutoCenter
{
	None,
	PrimaryWorkArea,
	PreferredWorkArea
}
