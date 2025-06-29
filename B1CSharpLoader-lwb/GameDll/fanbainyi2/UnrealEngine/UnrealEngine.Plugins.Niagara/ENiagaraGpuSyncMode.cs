using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraGpuSyncMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraGpuSyncMode
{
	None,
	SyncCpuToGpu,
	SyncGpuToCpu,
	SyncBoth
}
