using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ProjectileBaseType")]
public enum ProjectileBaseType : byte
{
	None,
	[DisplayName("抛射物生成者")]
	ProjectileSpawner,
	[DisplayName("效果触发者")]
	EffectCaster,
	[DisplayName("效果目标")]
	EffectTarget,
	[DisplayName("抛射物生成者当前的目标")]
	CurTarget_ProjectileSpawner,
	[DisplayName("缓存的点集")]
	UsePointSetCached,
	[DisplayName("打击点坐标")]
	UseEffectPosition,
	[DisplayName("技能目标")]
	UseSkillBaseTarget,
	[DisplayName("缓存的SceneItem")]
	SceneItemCached,
	[DisplayName("效果RootCaster")]
	EffectRootCaster,
	[DisplayName("使用EQS生成点")]
	UseEQSPoint,
	[DisplayName("使用多目标模式")]
	MutilTarget,
	[DisplayName("LocalPlayer")]
	LocalPlayer
}
