using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.StreamlineBlueprint;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/StreamlineBlueprint.UStreamlineDLSSGMode", "StreamlineBlueprint", UnrealModuleType.EnginePlugin)]
public enum EUStreamlineDLSSGMode : byte
{
	Off,
	On,
	Auto
}
