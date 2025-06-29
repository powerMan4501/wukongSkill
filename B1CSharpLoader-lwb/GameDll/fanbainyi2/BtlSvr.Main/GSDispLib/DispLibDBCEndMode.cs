using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCEndMode")]
public enum DispLibDBCEndMode : byte
{
	[UMeta(MD.ToolTip, "对于特效，该模式目前强制转换为【固定8s后销毁特效】; 对于非特效，该模式多数情况下等同于【固定时间x，x视不同效果有不同的默认值】，特殊情况以功能各自注释为准")]
	[DisplayName("自动销毁")]
	[UMeta(MDProp.DisplayPriority, 1)]
	AutoRelease,
	[DisplayName("固定持续时间")]
	[UMeta(MD.ToolTip, "适用于节奏一致、持续时间可确定的特效")]
	[UMeta(MDProp.DisplayPriority, 2)]
	FixDuration,
	[DisplayName("程序控制")]
	[UMeta(MD.ToolTip, "适用于持续时间和战斗逻辑强耦合，必须由程序控制何时销毁的特效，例如可以被驱散的Debuff")]
	[UMeta(MDProp.DisplayPriority, 3)]
	ProcedureNotity
}
