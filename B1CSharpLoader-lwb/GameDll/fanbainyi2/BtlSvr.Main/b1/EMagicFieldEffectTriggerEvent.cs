using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.MagicFieldEffectTriggerEvent")]
public enum EMagicFieldEffectTriggerEvent : byte
{
	[DisplayName("法术场出生时触发")]
	[Tooltip("出生时也会触发进入效果")]
	OnBorn,
	[DisplayName("法术场消亡时触发")]
	[Tooltip("消亡阶段也会触发退出效果")]
	OnDead,
	[DisplayName("进入法术场触发")]
	OnEnter,
	[DisplayName("退出法术场触发")]
	OnExit
}
