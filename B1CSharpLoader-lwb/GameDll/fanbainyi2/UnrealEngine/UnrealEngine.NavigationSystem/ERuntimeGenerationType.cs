using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[UEnum]
[UMetaPath("/Script/NavigationSystem.ERuntimeGenerationType", "NavigationSystem", UnrealModuleType.Engine)]
public enum ERuntimeGenerationType
{
	Static,
	DynamicModifiersOnly,
	Dynamic,
	LegacyGeneration
}
