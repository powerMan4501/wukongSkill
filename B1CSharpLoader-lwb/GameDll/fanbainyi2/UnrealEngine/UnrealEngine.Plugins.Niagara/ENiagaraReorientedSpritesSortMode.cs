using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraReorientedSpritesSortMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraReorientedSpritesSortMode
{
	Unordered,
	Sort,
	WBOIT
}
