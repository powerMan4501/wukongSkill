using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsEditorOnlyExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsEditorOnlyExp.EAttributeEditorAttribType", "MeshModelingToolsEditorOnlyExp", UnrealModuleType.EnginePlugin)]
public enum EAttributeEditorAttribType
{
	Int32,
	Boolean,
	Float,
	Vector2,
	Vector3,
	Vector4,
	String,
	Unknown
}
