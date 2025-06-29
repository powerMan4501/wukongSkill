using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/Engine.DestructibleInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(IDestructibleInterfaceImpl))]
public interface IDestructibleInterface : IInterface
{
}
