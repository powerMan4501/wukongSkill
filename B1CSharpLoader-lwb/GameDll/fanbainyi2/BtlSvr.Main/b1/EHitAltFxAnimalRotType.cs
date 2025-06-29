using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.HitAltFxAnimalRotType")]
public enum EHitAltFxAnimalRotType : byte
{
	[DisplayName("相机Fwd方向")]
	CamDir_Fwd,
	[DisplayName("相机Bwd方向")]
	CamDir_Bwd,
	[DisplayName("相机Right方向")]
	CamDir_Right,
	[DisplayName("相机Left方向")]
	CamDir_Left,
	[DisplayName("朝向玩家")]
	RotToPlayer,
	[DisplayName("朝向玩家周围点")]
	RotToPlayerSurround
}
