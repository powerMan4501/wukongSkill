using UnrealEngine.Runtime;

namespace UnrealEngine.UMGEditor;

[UEnum]
[UMetaPath("/Script/UMGEditor.EWidgetCompileTimeTickPrediction", "UMGEditor", UnrealModuleType.Engine)]
public enum EWidgetCompileTimeTickPrediction
{
	WontTick,
	OnDemand,
	WillTick
}
