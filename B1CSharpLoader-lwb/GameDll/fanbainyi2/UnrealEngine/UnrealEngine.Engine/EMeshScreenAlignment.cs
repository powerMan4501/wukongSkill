using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMeshScreenAlignment", "Engine", UnrealModuleType.Engine)]
public enum EMeshScreenAlignment
{
	PSMA_MeshFaceCameraWithRoll,
	PSMA_MeshFaceCameraWithSpin,
	PSMA_MeshFaceCameraWithLockedAxis
}
