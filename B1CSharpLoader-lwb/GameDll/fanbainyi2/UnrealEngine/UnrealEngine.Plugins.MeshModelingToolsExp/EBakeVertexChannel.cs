using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EBakeVertexChannel", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EBakeVertexChannel
{
	R,
	G,
	B,
	A,
	RGBA
}
