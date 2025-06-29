using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EBGMPriority")]
public enum EBGMPriority : byte
{
	BossBattleBGM,
	EliteBattleBGM,
	MonsterBattleBGM,
	WanderBGM
}
