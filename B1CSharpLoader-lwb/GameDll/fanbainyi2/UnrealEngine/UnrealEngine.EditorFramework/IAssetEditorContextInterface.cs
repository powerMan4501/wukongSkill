using UnrealEngine.Runtime;

namespace UnrealEngine.EditorFramework;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/EditorFramework.AssetEditorContextInterface", "EditorFramework", UnrealModuleType.Engine, InterfaceImpl = typeof(IAssetEditorContextInterfaceImpl))]
public interface IAssetEditorContextInterface : IInterface
{
}
