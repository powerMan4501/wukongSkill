using UnrealEngine.Runtime;

namespace UnrealEngine.Localization;

[UEnum]
[UMetaPath("/Script/Localization.ELocalizedTextCollapseMode", "Localization", UnrealModuleType.Engine)]
public enum ELocalizedTextCollapseMode
{
	IdenticalTextIdAndSource,
	IdenticalPackageIdTextIdAndSource,
	IdenticalNamespaceAndSource
}
