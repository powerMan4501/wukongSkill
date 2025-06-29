using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EEmitterNormalsMode", "Engine", UnrealModuleType.Engine)]
public enum EEmitterNormalsMode
{
	ENM_CameraFacing,
	ENM_Spherical,
	ENM_Cylindrical
}
