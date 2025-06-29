using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EStreamingVolumeUsage", "Engine", UnrealModuleType.Engine)]
public enum EStreamingVolumeUsage
{
	SVB_Loading,
	SVB_LoadingAndVisibility,
	SVB_VisibilityBlockingOnLoad,
	SVB_BlockingOnLoad,
	SVB_LoadingNotVisible
}
