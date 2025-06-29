using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EVolumeLightingMethod", "Engine", UnrealModuleType.Engine)]
public enum EVolumeLightingMethod
{
	VLM_VolumetricLightmap,
	VLM_SparseVolumeLightingSamples
}
