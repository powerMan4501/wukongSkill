using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponentsEditorOnly;

[UEnum]
[UMetaPath("/Script/ModelingComponentsEditorOnly.ESubdivisionScheme", "ModelingComponentsEditorOnly", UnrealModuleType.EnginePlugin)]
public enum ESubdivisionScheme
{
	Bilinear,
	CatmullClark,
	Loop
}
