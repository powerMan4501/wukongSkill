using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Concert;

[UEnum]
[UMetaPath("/Script/Concert.EConcertServerFlags", "Concert", UnrealModuleType.EnginePlugin)]
public enum EConcertServerFlags
{
	None,
	IgnoreSessionRequirement
}
