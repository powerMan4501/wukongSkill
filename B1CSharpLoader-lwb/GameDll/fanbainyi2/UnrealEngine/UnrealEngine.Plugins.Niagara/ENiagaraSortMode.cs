using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraSortMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraSortMode
{
	None,
	ViewDepth,
	ViewDistance,
	CustomAscending,
	CustomDecending
}
