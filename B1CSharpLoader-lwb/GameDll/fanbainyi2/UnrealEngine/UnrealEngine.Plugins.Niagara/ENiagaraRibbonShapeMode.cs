using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraRibbonShapeMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraRibbonShapeMode
{
	Plane,
	MultiPlane,
	Tube,
	Custom
}
