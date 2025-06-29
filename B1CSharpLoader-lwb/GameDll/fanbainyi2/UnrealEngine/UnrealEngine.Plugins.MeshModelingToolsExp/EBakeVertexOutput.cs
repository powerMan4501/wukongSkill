using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EBakeVertexOutput", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EBakeVertexOutput
{
	RGBA,
	PerChannel
}
