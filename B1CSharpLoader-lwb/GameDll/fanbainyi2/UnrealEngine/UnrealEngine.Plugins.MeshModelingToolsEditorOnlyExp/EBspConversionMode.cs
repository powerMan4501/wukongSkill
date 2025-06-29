using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsEditorOnlyExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsEditorOnlyExp.EBspConversionMode", "MeshModelingToolsEditorOnlyExp", UnrealModuleType.EnginePlugin)]
public enum EBspConversionMode
{
	ConvertFirst,
	CombineFirst
}
