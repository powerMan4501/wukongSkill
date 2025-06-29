using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepCore;

[UEnum]
[UMetaPath("/Script/DataprepCore.EDataprepStringMatchType", "DataprepCore", UnrealModuleType.EnginePlugin)]
public enum EDataprepStringMatchType
{
	Contains,
	MatchesWildcard,
	ExactMatch
}
