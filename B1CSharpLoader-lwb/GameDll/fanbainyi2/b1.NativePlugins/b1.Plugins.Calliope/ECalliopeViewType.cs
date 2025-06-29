using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.ECalliopeViewType", "Calliope", UnrealModuleType.GamePlugin)]
public enum ECalliopeViewType : byte
{
	None,
	Quest,
	Combo,
	State,
	Behavior,
	Skill,
	Movie,
	Process,
	Task,
	FSM,
	Dialogue,
	Guide,
	BossRush,
	Max
}
