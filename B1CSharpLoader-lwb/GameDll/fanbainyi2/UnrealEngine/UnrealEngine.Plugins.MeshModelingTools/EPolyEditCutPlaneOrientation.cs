using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EPolyEditCutPlaneOrientation", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EPolyEditCutPlaneOrientation
{
	FaceNormals,
	ViewDirection
}
