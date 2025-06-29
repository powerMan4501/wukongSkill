using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCEffectDestroyTiming")]
public enum DispLibDBCEffectDestroyTiming : byte
{
	[DisplayName("结束表现阶段结束时")]
	[UMeta(MD.ToolTip, "经过【结束表现时间】后再回收或销毁特效，一般情况下，在结束表现时间内特效依然在产生粒子，因此【结束表现时间】为0时此选项和【结束表现阶段开始时】没有区别")]
	[UMeta(MDProp.DisplayPriority, 1)]
	OnEndDispStageEnd,
	[UMeta(MD.ToolTip, "在逻辑通知特效停止时就回收或销毁特效，一般情况下，特效从此刻起不再产生粒子")]
	[DisplayName("结束表现阶段开始时")]
	[UMeta(MDProp.DisplayPriority, 2)]
	OnEndDispStageStart
}
