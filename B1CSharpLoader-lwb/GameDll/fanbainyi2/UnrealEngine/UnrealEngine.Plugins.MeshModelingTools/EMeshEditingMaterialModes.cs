using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EMeshEditingMaterialModes", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EMeshEditingMaterialModes
{
	ExistingMaterial,
	Diffuse,
	Grey,
	Soft,
	Transparent,
	TangentNormal,
	VertexColor,
	CustomImage,
	Custom
}
