using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Party;

[UEnum]
[UMetaPath("/Script/Party.EPlatformIconDisplayRule", "Party", UnrealModuleType.EnginePlugin)]
public enum EPlatformIconDisplayRule
{
	Always,
	AlwaysIfDifferent,
	AlwaysWhenInCrossplayParty,
	AlwaysIfDifferentWhenInCrossplayParty,
	Never
}
