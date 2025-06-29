using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.RequestTestResult")]
public enum ERequestTestResult : byte
{
	FeatureNotFound,
	NoNeedToTest,
	SelectFaild,
	SelectSuccess
}
