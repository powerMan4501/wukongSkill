using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBGWStreamingVolumeUsage", "b1", UnrealModuleType.Game)]
public enum EBGWStreamingVolumeUsage : byte
{
	Loading,
	LoadingAndVisibility,
	VisibilityBlockingOnLoad,
	BlockingOnLoad,
	LoadingNotVisible
}
