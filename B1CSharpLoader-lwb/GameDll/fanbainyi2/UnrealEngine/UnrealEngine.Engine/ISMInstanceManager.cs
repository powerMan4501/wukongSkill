using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/Engine.SMInstanceManager", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(ISMInstanceManagerImpl))]
public interface ISMInstanceManager : IInterface
{
}
