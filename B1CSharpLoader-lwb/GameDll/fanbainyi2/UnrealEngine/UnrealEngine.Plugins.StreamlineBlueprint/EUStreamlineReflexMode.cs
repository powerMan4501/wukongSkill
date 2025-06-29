using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.StreamlineBlueprint;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/StreamlineBlueprint.UStreamlineReflexMode", "StreamlineBlueprint", UnrealModuleType.EnginePlugin)]
public enum EUStreamlineReflexMode : byte
{
	Disabled = 0,
	Enabled = 1,
	EnabledPlusBoost = 3
}
