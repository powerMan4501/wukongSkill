using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraPreviewGridResetMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraPreviewGridResetMode
{
	Never,
	Individual,
	All
}
