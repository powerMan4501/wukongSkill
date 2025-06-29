using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENCPoolMethod", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENCPoolMethod
{
	None,
	AutoRelease,
	ManualRelease,
	ManualRelease_OnComplete,
	FreeInPool
}
