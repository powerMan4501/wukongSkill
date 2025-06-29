using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UEnum]
[UMetaPath("/Script/JavascriptEditor.EJavascriptRHIFeatureLevel", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public enum EJavascriptRHIFeatureLevel
{
	ES2,
	ES3_1,
	SM4,
	SM5,
	Num
}
