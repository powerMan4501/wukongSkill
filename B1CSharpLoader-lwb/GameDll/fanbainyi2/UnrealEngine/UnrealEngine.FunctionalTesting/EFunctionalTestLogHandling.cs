using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.EFunctionalTestLogHandling", "FunctionalTesting", UnrealModuleType.Engine)]
public enum EFunctionalTestLogHandling : byte
{
	ProjectDefault,
	OutputIsError,
	OutputIgnored
}
