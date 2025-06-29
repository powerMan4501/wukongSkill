using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.AbnromalDispActionType")]
public enum EAbnromalDispActionType : byte
{
	[DisplayName("积累过程表现")]
	AccProcess,
	[DisplayName("最终效果Begin表现")]
	FinalBegin,
	[DisplayName("最终效果Loop表现")]
	FinalLoop,
	[DisplayName("命中额外附加表现")]
	HitExt,
	[DisplayName("死亡接续表现")]
	DeadKeep,
	[DisplayName("死亡消散表现")]
	DeadDisappear
}
