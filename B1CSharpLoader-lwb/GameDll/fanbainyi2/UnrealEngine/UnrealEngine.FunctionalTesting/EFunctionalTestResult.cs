using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.EFunctionalTestResult", "FunctionalTesting", UnrealModuleType.Engine)]
public enum EFunctionalTestResult : byte
{
	Default,
	Invalid,
	Error,
	Running,
	Failed,
	Succeeded
}
