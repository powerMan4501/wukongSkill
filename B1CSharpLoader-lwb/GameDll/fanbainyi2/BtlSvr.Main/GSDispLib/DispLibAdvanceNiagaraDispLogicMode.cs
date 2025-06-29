using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibAdvanceNiagaraDispLogicMode")]
public enum DispLibAdvanceNiagaraDispLogicMode : byte
{
	[DisplayName("自定义")]
	[UMeta(MD.ToolTip, "具体行为由程序定义，用于框架不能满足的复杂情况，参数如何配置需要与程序沟通")]
	[UMeta(MDProp.DisplayPriority, 1)]
	Custom,
	[DisplayName("标准指向性受击")]
	[UMeta(MD.ToolTip, "在挂点位置创建特效但不依附挂点，创建时旋转特效使其X轴由发射者挂点位置指向目标挂点位置(忽略配置的目标旋转参数)，用于中枪后反向喷血等有指向的短促受击表现，EndMode可配置")]
	[UMeta(MDProp.DisplayPriority, 2)]
	StandardDirBeHit,
	[UMeta(MDProp.DisplayPriority, 3)]
	[UMeta(MD.ToolTip, "每帧传入发射者世界位置")]
	[DisplayName("标准关联性")]
	StandardInteraction,
	[UMeta(MD.ToolTip, "[4.24实验暂时不要用]每帧同步特效位置到 PlayerCameraManager 的 CameraPos 前方")]
	[UMeta(MDProp.DisplayPriority, 4)]
	[DisplayName("面片后处理")]
	PlanePostProcess,
	[DisplayName("微偏移受击")]
	[UMeta(MD.ToolTip, "向攻击者方向略微偏移一点的受击特效，默认偏移距离在Config里配置，可以给具体效果配置CustomV4Param.X 覆盖默认距离")]
	[UMeta(MDProp.DisplayPriority, 5)]
	TinyOffsetBeHit,
	[DisplayName("拟合最近挂点")]
	[UMeta(MDProp.DisplayPriority, 6)]
	[UMeta(MD.ToolTip, "如果逻辑层传入有效 OverrideTransform，DBC查找 MasterComp 上离传入位置最近的挂点并以此挂点覆写【依附目标插槽】参数，同时修改 OverrideTransformLO，RO 为 OffsetInSocketLocalSpace 模式且自动换算为相对偏移。注意，此时【依附目标挂点】【目标插槽查找模式】【Override Transform 转化为参数】依然有效, 且【Override Transform 转化为参数】传入特效的是DBC转化后的相对偏移")]
	MatchingToNearestSocket,
	[DisplayName("DBC特效合并")]
	[UMeta(MD.ToolTip, "DBC特效合并")]
	[UMeta(MDProp.DisplayPriority, 7)]
	DBCMergedSystem
}
