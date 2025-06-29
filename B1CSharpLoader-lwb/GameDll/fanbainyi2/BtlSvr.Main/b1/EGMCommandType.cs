using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EGMCommandType")]
public enum EGMCommandType : byte
{
	None,
	ShowBattleUI,
	EnableEnemyBar,
	Invincible,
	LockHP,
	LockStamina,
	Invisible,
	LockEnemyHP,
	CancelEnemyCD,
	ToggleAllEnemyAI,
	Lock60FPS,
	VSync,
	EnumMax
}
