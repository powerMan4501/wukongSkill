using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMobileAntiAliasingMethod", "Engine", UnrealModuleType.Engine)]
public enum EMobileAntiAliasingMethod
{
	None,
	FXAA,
	TemporalAA,
	MSAA
}
