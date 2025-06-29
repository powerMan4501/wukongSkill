using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/Engine.NavRelevantInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(INavRelevantInterfaceImpl))]
public interface INavRelevantInterface : IInterface
{
}
