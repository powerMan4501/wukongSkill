using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.EComparisonMethod", "FunctionalTesting", UnrealModuleType.Engine)]
public enum EComparisonMethod : byte
{
	Equal_To,
	Not_Equal_To,
	Greater_Than_Or_Equal_To,
	Less_Than_Or_Equal_To,
	Greater_Than,
	Less_Than
}
