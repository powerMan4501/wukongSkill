using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraCompilationState", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraCompilationState
{
	CheckDDC,
	Precompile,
	StartCompileJob,
	AwaitResult,
	ProcessResult,
	PutToDDC,
	Finished,
	Aborted
}
