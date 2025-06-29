using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGCreateSplineMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGCreateSplineMode
{
	CreateDataOnly,
	CreateComponent,
	CreateNewActor
}
