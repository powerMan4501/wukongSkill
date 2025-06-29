using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraScriptCompileStatus", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraScriptCompileStatus
{
	NCS_Unknown,
	NCS_Dirty,
	NCS_Error,
	NCS_UpToDate,
	NCS_BeingCreated,
	NCS_UpToDateWithWarnings,
	NCS_ComputeUpToDateWithWarnings
}
