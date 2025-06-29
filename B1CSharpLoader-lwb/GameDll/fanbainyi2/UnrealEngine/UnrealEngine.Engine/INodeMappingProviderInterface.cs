using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/Engine.NodeMappingProviderInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(INodeMappingProviderInterfaceImpl))]
public interface INodeMappingProviderInterface : IInterface
{
}
