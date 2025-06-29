using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.MovieTriggerType")]
public enum EMovieTriggerType : byte
{
	None,
	Overlap,
	Interactor,
	Unit,
	NPC,
	Spawner,
	TaskStage
}
