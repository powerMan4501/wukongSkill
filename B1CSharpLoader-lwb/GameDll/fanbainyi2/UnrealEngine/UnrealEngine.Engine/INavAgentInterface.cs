using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/Engine.NavAgentInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(INavAgentInterfaceImpl))]
public interface INavAgentInterface : IInterface
{
}
