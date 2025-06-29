using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CurveEditorTools;

[UEnum]
[UMetaPath("/Script/CurveEditorTools.EMultiScalePivotType", "CurveEditorTools", UnrealModuleType.EnginePlugin)]
public enum EMultiScalePivotType
{
	Average,
	BoundCenter,
	FirstKey,
	LastKey
}
