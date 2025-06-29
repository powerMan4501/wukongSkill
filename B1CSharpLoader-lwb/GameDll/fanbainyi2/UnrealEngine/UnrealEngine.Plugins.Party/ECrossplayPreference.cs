using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Party;

[UEnum]
[UMetaPath("/Script/Party.ECrossplayPreference", "Party", UnrealModuleType.EnginePlugin)]
public enum ECrossplayPreference
{
	NoSelection,
	OptedIn,
	OptedOut,
	OptedOutRestricted
}
