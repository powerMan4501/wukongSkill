using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UEnum]
[UMetaPath("/Script/JavascriptEditor.EJavascriptWidgetMode", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public enum EJavascriptWidgetMode
{
	WM_Translate = 0,
	WM_TranslateRotateZ = 1,
	WM_2D = 2,
	WM_Rotate = 3,
	WM_Scale = 4,
	WM_Max = 5,
	WM_None = 255
}
