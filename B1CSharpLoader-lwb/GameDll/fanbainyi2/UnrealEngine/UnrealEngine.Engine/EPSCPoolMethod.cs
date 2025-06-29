using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EPSCPoolMethod", "Engine", UnrealModuleType.Engine)]
public enum EPSCPoolMethod
{
	None,
	AutoRelease,
	ManualRelease,
	ManualRelease_OnComplete,
	FreeInPool
}
