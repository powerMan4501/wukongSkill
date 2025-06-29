using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeImport;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/InterchangeImport.InterchangeSlicedTexturePayloadInterface", "InterchangeImport", UnrealModuleType.EnginePlugin, InterfaceImpl = typeof(IInterchangeSlicedTexturePayloadInterfaceImpl))]
public interface IInterchangeSlicedTexturePayloadInterface : IInterface
{
}
