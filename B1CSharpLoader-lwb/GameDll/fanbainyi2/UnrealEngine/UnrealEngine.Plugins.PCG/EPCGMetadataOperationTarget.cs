using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMetadataOperationTarget", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMetadataOperationTarget
{
	PropertyToAttribute,
	AttributeToProperty,
	AttributeToAttribute
}
