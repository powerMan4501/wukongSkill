using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TeleportTypeV2")]
public enum ETeleportTypeV2 : byte
{
	SimpleLevelIdAndTransform,
	RebirthPoint,
	TeleportNamedPoint,
	Dream,
	NextChapter,
	RebirthPointTeleportOnly,
	PrologueCompleted,
	BossRush
}
