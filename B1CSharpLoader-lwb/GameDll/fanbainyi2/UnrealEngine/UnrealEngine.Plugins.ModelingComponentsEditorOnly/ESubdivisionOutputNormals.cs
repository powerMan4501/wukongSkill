using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponentsEditorOnly;

[UEnum]
[UMetaPath("/Script/ModelingComponentsEditorOnly.ESubdivisionOutputNormals", "ModelingComponentsEditorOnly", UnrealModuleType.EnginePlugin)]
public enum ESubdivisionOutputNormals
{
	Interpolated,
	Generated,
	None
}
