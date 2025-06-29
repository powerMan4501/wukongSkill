using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/AIModule.CrowdAgentInterface", "AIModule", UnrealModuleType.Engine, InterfaceImpl = typeof(ICrowdAgentInterfaceImpl))]
public interface ICrowdAgentInterface : IInterface
{
}
