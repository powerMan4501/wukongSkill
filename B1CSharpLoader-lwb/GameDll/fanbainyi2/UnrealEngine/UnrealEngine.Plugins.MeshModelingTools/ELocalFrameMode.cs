using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.ELocalFrameMode", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum ELocalFrameMode
{
	FromObject,
	FromGeometry
}
