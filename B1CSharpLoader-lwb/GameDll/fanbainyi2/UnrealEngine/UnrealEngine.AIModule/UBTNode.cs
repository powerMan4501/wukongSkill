using UnrealEngine.GameplayTasks;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Game")]
[UMetaPath("/Script/AIModule.BTNode", "AIModule", UnrealModuleType.Engine)]
public class UBTNode : UObject, IGameplayTaskOwnerInterface, IInterface
{
}
