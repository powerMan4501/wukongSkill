using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EBakeMapType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EBakeMapType
{
	None = 0,
	TangentSpaceNormal = 1,
	ObjectSpaceNormal = 2,
	FaceNormal = 4,
	BentNormal = 8,
	Position = 16,
	Curvature = 32,
	AmbientOcclusion = 64,
	Texture = 128,
	MultiTexture = 256,
	VertexColor = 512,
	MaterialID = 1024,
	All = 2047
}
