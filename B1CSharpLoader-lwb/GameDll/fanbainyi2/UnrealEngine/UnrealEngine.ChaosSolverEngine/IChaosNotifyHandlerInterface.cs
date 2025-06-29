using UnrealEngine.Runtime;

namespace UnrealEngine.ChaosSolverEngine;

[Abstract]
[UInterface(Flags = 810565793u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/ChaosSolverEngine.ChaosNotifyHandlerInterface", "ChaosSolverEngine", UnrealModuleType.Engine, InterfaceImpl = typeof(IChaosNotifyHandlerInterfaceImpl))]
public interface IChaosNotifyHandlerInterface : IInterface
{
}
