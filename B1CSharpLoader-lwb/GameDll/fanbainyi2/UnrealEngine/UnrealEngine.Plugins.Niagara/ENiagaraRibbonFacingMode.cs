using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraRibbonFacingMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraRibbonFacingMode
{
	Screen,
	Custom,
	CustomSideVector
}
