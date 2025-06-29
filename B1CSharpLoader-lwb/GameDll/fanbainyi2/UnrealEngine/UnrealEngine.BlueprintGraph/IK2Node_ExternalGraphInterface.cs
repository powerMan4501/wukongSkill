using UnrealEngine.Runtime;

namespace UnrealEngine.BlueprintGraph;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/BlueprintGraph.K2Node_ExternalGraphInterface", "BlueprintGraph", UnrealModuleType.Engine, InterfaceImpl = typeof(IK2Node_ExternalGraphInterfaceImpl))]
public interface IK2Node_ExternalGraphInterface : IInterface
{
}
