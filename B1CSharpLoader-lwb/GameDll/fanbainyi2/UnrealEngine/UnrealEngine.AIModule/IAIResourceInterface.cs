using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/AIModule.AIResourceInterface", "AIModule", UnrealModuleType.Engine, InterfaceImpl = typeof(IAIResourceInterfaceImpl))]
public interface IAIResourceInterface : IInterface
{
}
