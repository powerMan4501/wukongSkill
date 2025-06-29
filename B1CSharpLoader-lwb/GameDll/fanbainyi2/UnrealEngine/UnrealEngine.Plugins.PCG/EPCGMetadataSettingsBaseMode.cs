using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMetadataSettingsBaseMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMetadataSettingsBaseMode
{
	Inferred,
	NoBroadcast,
	Broadcast
}
