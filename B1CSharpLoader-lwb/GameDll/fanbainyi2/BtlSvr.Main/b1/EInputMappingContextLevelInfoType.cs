using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.InputMappingContextLevelInfoType")]
public enum EInputMappingContextLevelInfoType : byte
{
	[DisplayName("所有关卡都要加载")]
	None,
	[DisplayName("只允许在这些Level中生效，其他Level不会生效")]
	OnlyAppliedToLevels,
	[DisplayName("只在这些Level中不生效，其他Level会生效")]
	NotAppliedToLevels
}
