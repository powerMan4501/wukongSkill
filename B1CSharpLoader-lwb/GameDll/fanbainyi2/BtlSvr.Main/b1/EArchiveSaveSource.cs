using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.ArchiveSaveSource")]
public enum EArchiveSaveSource : byte
{
	ArchiveSaveV1 = 1,
	RoleDataMerge,
	PushTaskStageSuccess,
	PlayerDead,
	BossOrEliteDead,
	SeqPlayFinished,
	BackToMainMenu,
	TeleportFinish,
	Console,
	Interact,
	NewGamePlus,
	ReSet820Data,
	TravelLevel,
	ExitGame
}
