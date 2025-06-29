using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraRibbonUVDistributionMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraRibbonUVDistributionMode
{
	ScaledUniformly,
	ScaledUsingRibbonSegmentLength,
	TiledOverRibbonLength,
	TiledFromStartOverRibbonLength
}
