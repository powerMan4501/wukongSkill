using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/Engine.PathFollowingAgentInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(IPathFollowingAgentInterfaceImpl))]
public interface IPathFollowingAgentInterface : IInterface
{
}
