using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[UEnum]
[UMetaPath("/Script/JavascriptUMG.EJavascriptSizingRule", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public enum EJavascriptSizingRule
{
	FixedSize,
	Autosized,
	UserSized
}
