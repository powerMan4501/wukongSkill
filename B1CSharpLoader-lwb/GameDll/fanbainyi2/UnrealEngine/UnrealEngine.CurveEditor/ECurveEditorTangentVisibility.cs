using UnrealEngine.Runtime;

namespace UnrealEngine.CurveEditor;

[UEnum]
[UMetaPath("/Script/CurveEditor.ECurveEditorTangentVisibility", "CurveEditor", UnrealModuleType.Engine)]
public enum ECurveEditorTangentVisibility
{
	AllTangents,
	SelectedKeys,
	NoTangents
}
