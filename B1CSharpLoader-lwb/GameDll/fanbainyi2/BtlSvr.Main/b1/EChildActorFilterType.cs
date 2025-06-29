using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.ChildActorFilterType")]
public enum EChildActorFilterType : byte
{
	[DisplayName("插槽匹配")]
	Socket,
	[DisplayName("ResId匹配")]
	ResId,
	[DisplayName("别名匹配")]
	NickName,
	[DisplayName("Buff匹配")]
	Buff,
	[DisplayName("全部")]
	All
}
