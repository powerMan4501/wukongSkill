using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ChildActorActionType")]
public enum EChildActorActionType : byte
{
	[DisplayName("施放技能")]
	CastSkill,
	[DisplayName("添加Buff")]
	AddBuff,
	[DisplayName("移除Buff")]
	RemoveBuff,
	[DisplayName("出生插槽下单位")]
	SpawnSocketAttachTamer
}
