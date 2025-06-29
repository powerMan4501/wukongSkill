using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.AttackIKType")]
public enum EAttackIKType : byte
{
	[UMeta(MD.DisplayName, "关闭")]
	None,
	[UMeta(MD.DisplayName, "地形坡度")]
	TerrainSlope,
	[UMeta(MD.DisplayName, "俯仰角")]
	AvatarBonePitchOnly,
	[UMeta(MD.DisplayName, "翻滚角")]
	AvatarBoneRollOnly,
	[UMeta(MD.DisplayName, "范围对准")]
	FishSpike,
	[UMeta(MD.DisplayName, "主角锁定点俯仰")]
	AvatarLockPointPitch
}
