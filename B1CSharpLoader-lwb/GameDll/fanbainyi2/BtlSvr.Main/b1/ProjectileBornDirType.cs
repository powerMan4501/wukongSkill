using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ProjectileBornDirType")]
public enum ProjectileBornDirType : byte
{
	[DisplayName("无")]
	None,
	[UMeta(MD.ToolTip, "Bone,Socket,SceneComp,取决于生成点类型中填的")]
	[DisplayName("插槽朝向")]
	UseSlotDir,
	[DisplayName("朝向目标点")]
	[UMeta(MD.ToolTip, "目标点取决于目标点类型中填的")]
	LookAtTargetPos,
	[DisplayName("攻击者与子弹连线XY方向")]
	[UMeta(MD.ToolTip, "主要应用于‘攻击拍飞场景物体’之类的需求")]
	XYLineFromOwner,
	[DisplayName("朝打击点法线方向")]
	[UMeta(MD.ToolTip, "只能在SkillEffect生成的效果中使用")]
	UseEffectNormal,
	[DisplayName("生成基准Actor的Rot")]
	BaseActorRot,
	[DisplayName("点集缓存的Rot")]
	UsePointSetCached,
	[DisplayName("效果触发者的Rot")]
	UseEffectCasterRot,
	[DisplayName("生成者与子弹连线方向")]
	LineFromSpawner
}
