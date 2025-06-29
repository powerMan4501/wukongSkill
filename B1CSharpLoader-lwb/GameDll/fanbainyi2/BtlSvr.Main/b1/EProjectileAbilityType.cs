using UnrealEngine.Runtime;

namespace b1;

[UMeta(MDEnum.Bitflags)]
[UMeta(MDEnum.UseEnumValuesAsMaskValuesInEditor, true)]
[UEnum]
[USharpPath("/Script/b1-Managed.ProjectileAbilityType")]
public enum EProjectileAbilityType : byte
{
	[UMeta(MD.Hidden)]
	Default = 0,
	[UMeta(MDFunc.DisplayName, "动态缩放功能")]
	DynamicScale = 2,
	[UMeta(MDFunc.DisplayName, "激光子弹")]
	LaserBullet = 4,
	[UMeta(MDFunc.DisplayName, "程序化环境交互")]
	ProceduralEnvInteract = 8,
	[UMeta(MDFunc.DisplayName, "材质融合")]
	BulletMatMerge = 0x10,
	[UMeta(MDFunc.DisplayName, "破碎物子弹")]
	DestructibleBullet = 0x20,
	[UMeta(MDFunc.DisplayName, "卷飞物理尸体")]
	ThrowUpDeadUnit = 0x40,
	[UMeta(MDFunc.DisplayName, "破风音效")]
	WindBrokenAudio = 0x80
}
