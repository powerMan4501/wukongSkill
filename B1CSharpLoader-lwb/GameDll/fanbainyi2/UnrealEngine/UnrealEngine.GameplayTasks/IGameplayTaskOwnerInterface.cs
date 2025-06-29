using UnrealEngine.Runtime;

namespace UnrealEngine.GameplayTasks;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/GameplayTasks.GameplayTaskOwnerInterface", "GameplayTasks", UnrealModuleType.Engine, InterfaceImpl = typeof(IGameplayTaskOwnerInterfaceImpl))]
public interface IGameplayTaskOwnerInterface : IInterface
{
}
