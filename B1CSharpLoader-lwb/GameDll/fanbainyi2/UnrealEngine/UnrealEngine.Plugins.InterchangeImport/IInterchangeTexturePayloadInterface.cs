using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeImport;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/InterchangeImport.InterchangeTexturePayloadInterface", "InterchangeImport", UnrealModuleType.EnginePlugin, InterfaceImpl = typeof(IInterchangeTexturePayloadInterfaceImpl))]
public interface IInterchangeTexturePayloadInterface : IInterface
{
}
