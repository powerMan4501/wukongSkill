using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.StreamlineBlueprint;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/StreamlineBlueprint.UStreamlineFeature", "StreamlineBlueprint", UnrealModuleType.EnginePlugin)]
public enum EUStreamlineFeature : byte
{
	DLSSG,
	Reflex,
	Count
}
