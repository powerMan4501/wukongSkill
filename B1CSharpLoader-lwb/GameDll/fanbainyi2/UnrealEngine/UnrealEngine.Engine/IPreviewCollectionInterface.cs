using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/Engine.PreviewCollectionInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(IPreviewCollectionInterfaceImpl))]
public interface IPreviewCollectionInterface : IInterface
{
}
