using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DLSSBlueprint;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/DLSSBlueprint.UDLSSMode", "DLSSBlueprint", UnrealModuleType.EnginePlugin)]
public enum EUDLSSMode : byte
{
	Off,
	Auto,
	DLAA,
	UltraQuality,
	Quality,
	Balanced,
	Performance,
	UltraPerformance
}
