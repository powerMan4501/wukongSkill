using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/Engine.SMInstanceManagerProvider", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(ISMInstanceManagerProviderImpl))]
public interface ISMInstanceManagerProvider : IInterface
{
}
