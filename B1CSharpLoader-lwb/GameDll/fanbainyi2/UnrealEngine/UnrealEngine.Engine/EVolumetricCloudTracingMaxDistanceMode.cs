using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EVolumetricCloudTracingMaxDistanceMode", "Engine", UnrealModuleType.Engine)]
public enum EVolumetricCloudTracingMaxDistanceMode
{
	DistanceFromCloudLayerEntryPoint,
	DistanceFromPointOfView
}
