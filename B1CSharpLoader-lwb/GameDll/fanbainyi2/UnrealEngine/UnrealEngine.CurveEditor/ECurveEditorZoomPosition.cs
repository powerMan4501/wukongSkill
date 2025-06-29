using UnrealEngine.Runtime;

namespace UnrealEngine.CurveEditor;

[UEnum]
[UMetaPath("/Script/CurveEditor.ECurveEditorZoomPosition", "CurveEditor", UnrealModuleType.Engine)]
public enum ECurveEditorZoomPosition
{
	CurrentTime,
	MousePosition
}
