using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMetadataTypesConstantStructStringMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMetadataTypesConstantStructStringMode
{
	String,
	SoftObjectPath,
	SoftClassPath
}
