using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvQueryTestClamping", "AIModule", UnrealModuleType.Engine)]
public enum EEnvQueryTestClamping
{
	None,
	SpecifiedValue,
	FilterThreshold
}
