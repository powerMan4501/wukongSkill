using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeImport;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/InterchangeImport.InterchangeBlockedTexturePayloadInterface", "InterchangeImport", UnrealModuleType.EnginePlugin, InterfaceImpl = typeof(IInterchangeBlockedTexturePayloadInterfaceImpl))]
public interface IInterchangeBlockedTexturePayloadInterface : IInterface
{
}
