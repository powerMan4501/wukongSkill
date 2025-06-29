using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ConditionsTarget")]
public enum EConditionsTarget : byte
{
	[DisplayName("主角")]
	Player,
	[DisplayName("通过Tag查找")]
	FindByTag,
	[DisplayName("手动选怪")]
	ManualSelect
}
