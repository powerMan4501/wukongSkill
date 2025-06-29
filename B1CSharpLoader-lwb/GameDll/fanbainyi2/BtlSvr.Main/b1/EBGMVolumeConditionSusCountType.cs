using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EBGMVolumeConditionSusCountType")]
public enum EBGMVolumeConditionSusCountType : byte
{
	[DisplayName("任一")]
	Once,
	[DisplayName("所有")]
	All
}
