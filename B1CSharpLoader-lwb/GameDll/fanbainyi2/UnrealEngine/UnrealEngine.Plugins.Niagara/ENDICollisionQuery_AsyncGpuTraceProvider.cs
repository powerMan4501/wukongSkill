using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENDICollisionQuery_AsyncGpuTraceProvider", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENDICollisionQuery_AsyncGpuTraceProvider
{
	Default,
	HWRT,
	GSDF,
	None
}
