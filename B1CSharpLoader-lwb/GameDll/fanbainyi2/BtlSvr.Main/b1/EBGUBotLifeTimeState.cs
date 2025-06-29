using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EBGUBotLifeTimeState")]
public enum EBGUBotLifeTimeState : byte
{
	Idle,
	Battle,
	Dead,
	Patrol,
	ReturnHome,
	EnumMax
}
