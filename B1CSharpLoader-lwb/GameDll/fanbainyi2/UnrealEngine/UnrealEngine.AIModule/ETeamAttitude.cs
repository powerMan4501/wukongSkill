using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AIModule.ETeamAttitude", "AIModule", UnrealModuleType.Engine)]
public enum ETeamAttitude : byte
{
	Friendly,
	Neutral,
	Hostile
}
