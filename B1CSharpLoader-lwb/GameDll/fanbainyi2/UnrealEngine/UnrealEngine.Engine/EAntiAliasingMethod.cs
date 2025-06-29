using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAntiAliasingMethod", "Engine", UnrealModuleType.Engine)]
public enum EAntiAliasingMethod
{
	AAM_None,
	AAM_FXAA,
	AAM_TemporalAA,
	AAM_MSAA,
	AAM_TSR
}
