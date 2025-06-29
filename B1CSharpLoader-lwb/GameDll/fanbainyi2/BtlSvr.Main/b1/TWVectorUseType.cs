using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TWVectorUseType")]
public enum TWVectorUseType : byte
{
	[DisplayName("使用预定义的向量插槽0-单位化朝向")]
	UsePredefinedVectorSlot0,
	[DisplayName("使用预定义的向量插槽1-单位化朝向*时间")]
	UsePredefinedVectorSlot1,
	[DisplayName("使用预定义的向量插槽2")]
	UsePredefinedVectorSlot2,
	[DisplayName("使用预定义的向量插槽3")]
	UsePredefinedVectorSlot3,
	[DisplayName("使用基准向量")]
	UseVectorBase
}
