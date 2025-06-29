using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETrailsRenderAxisOption", "Engine", UnrealModuleType.Engine)]
public enum ETrailsRenderAxisOption
{
	Trails_CameraUp,
	Trails_SourceUp,
	Trails_WorldUp
}
