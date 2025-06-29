using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[Abstract]
[UInterface(Flags = 809517217u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Blutility.EditorUtilityExtension", "Blutility", UnrealModuleType.Engine, InterfaceImpl = typeof(IEditorUtilityExtensionImpl))]
public interface IEditorUtilityExtension : IInterface
{
}
