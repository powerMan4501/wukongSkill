using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.EComparisonTolerance", "FunctionalTesting", UnrealModuleType.Engine)]
public enum EComparisonTolerance : byte
{
	Zero,
	Low,
	Medium,
	High,
	Custom
}
