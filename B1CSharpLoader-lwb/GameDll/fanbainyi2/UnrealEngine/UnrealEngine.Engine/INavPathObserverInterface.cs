using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/Engine.NavPathObserverInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(INavPathObserverInterfaceImpl))]
public interface INavPathObserverInterface : IInterface
{
}
