using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[UEnum]
[UMetaPath("/Script/NavigationSystem.ENavSystemOverridePolicy", "NavigationSystem", UnrealModuleType.Engine)]
public enum ENavSystemOverridePolicy
{
	Override,
	Append,
	Skip
}
