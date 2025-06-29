using UnrealEngine.Runtime;

namespace UnrealEngine.BlueprintGraph;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/BlueprintGraph.NodeDependingOnEnumInterface", "BlueprintGraph", UnrealModuleType.Engine, InterfaceImpl = typeof(INodeDependingOnEnumInterfaceImpl))]
public interface INodeDependingOnEnumInterface : IInterface
{
}
