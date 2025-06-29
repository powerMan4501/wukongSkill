using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeImport;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/InterchangeImport.InterchangeSkeletalMeshPayloadInterface", "InterchangeImport", UnrealModuleType.EnginePlugin, InterfaceImpl = typeof(IInterchangeSkeletalMeshPayloadInterfaceImpl))]
public interface IInterchangeSkeletalMeshPayloadInterface : IInterface
{
}
