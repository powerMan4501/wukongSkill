using UnrealEngine.Runtime;

namespace UnrealEngine.EditorFramework;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/EditorFramework.AssetFactoryInterface", "EditorFramework", UnrealModuleType.Engine, InterfaceImpl = typeof(IAssetFactoryInterfaceImpl))]
public interface IAssetFactoryInterface : IInterface
{
}
