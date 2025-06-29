using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGExecutionPhase", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGExecutionPhase
{
	NotExecuted,
	PrepareData,
	Execute,
	PostExecute,
	Done
}
