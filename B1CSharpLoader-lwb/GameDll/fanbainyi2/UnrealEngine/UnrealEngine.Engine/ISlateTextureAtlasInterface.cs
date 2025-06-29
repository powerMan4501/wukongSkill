using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/Engine.SlateTextureAtlasInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(ISlateTextureAtlasInterfaceImpl))]
public interface ISlateTextureAtlasInterface : IInterface
{
}
