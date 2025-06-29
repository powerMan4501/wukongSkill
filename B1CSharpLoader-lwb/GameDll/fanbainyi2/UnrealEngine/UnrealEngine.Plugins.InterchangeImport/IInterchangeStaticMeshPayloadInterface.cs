using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeImport;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/InterchangeImport.InterchangeStaticMeshPayloadInterface", "InterchangeImport", UnrealModuleType.EnginePlugin, InterfaceImpl = typeof(IInterchangeStaticMeshPayloadInterfaceImpl))]
public interface IInterchangeStaticMeshPayloadInterface : IInterface
{
}
