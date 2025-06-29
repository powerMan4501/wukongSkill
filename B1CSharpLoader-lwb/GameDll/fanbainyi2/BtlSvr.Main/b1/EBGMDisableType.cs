using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EBGMDisableType")]
public enum EBGMDisableType : byte
{
	[UMeta(MD.Hidden)]
	None = 0,
	BossBattleBGM = 1,
	EliteBattleBGM = 2,
	MonsterBattleBGM = 3,
	WanderBGM = 4,
	TransMusic = 32
}
