using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.MFOverlapEventType")]
public enum MFOverlapEventType : byte
{
	[DisplayName("添加Buff")]
	AddBuff,
	[DisplayName("移除Buff并触发Buff移除效果")]
	RemoveBuffWithTriggerRemove,
	[DisplayName("移除Buff不触发Buff移除效果")]
	RemoveBuffWithoutTriggerRemove,
	[DisplayName("触发SkillEffect")]
	TriggerSkillEffect,
	[DisplayName("绘制符号")]
	DrawSign,
	[DisplayName("注册避让区域")]
	AddAvoidance,
	[DisplayName("注销避让区域")]
	RemoveAvoidance,
	[DisplayName("销毁带特定Flag的抛射物")]
	DestroyProjectileByFlag,
	[DisplayName("Master将区域内单位设为目标")]
	SetMastersTarget
}
