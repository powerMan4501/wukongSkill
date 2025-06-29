using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCEndStageMode")]
public enum DispLibDBCEndStageMode : byte
{
	[UMeta(MDProp.DisplayPriority, 1)]
	[DisplayName("标准结束")]
	[UMeta(MD.ToolTip, "通知特效 User.GS_EfxStop = true, User.GS_EfxEndStageTime = 结束表现时间; 经过配置的结束表现时间后特效会被ReleaseToPool或Destroy")]
	CommonEnd = 0,
	[DisplayName("瞬间结束")]
	[UMeta(MD.ToolTip, "通知特效 User.GS_EfxStop = true，User.GS_EfxEndStageTime = 0; 经过配置的结束表现时间后特效会被ReleaseToPool或Destroy")]
	[UMeta(MDProp.DisplayPriority, 1)]
	EndImmediately = 1,
	[DisplayName("自定义结束时间")]
	[UMeta(MD.ToolTip, "通知特效 User.GS_EfxStop = true，User.GS_EfxEndStageTime = 程序传入的结束表现时间; 经过程序传入的结束表现时间后特效会被ReleaseToPool或Destroy")]
	[UMeta(MDProp.DisplayPriority, 1)]
	CustomEndStageTime = 1
}
