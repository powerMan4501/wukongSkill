using UnrealEngine.Runtime;

namespace UnrealEngine.ViewportInteraction;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/ViewportInteraction.ViewportInteractableInterface", "ViewportInteraction", UnrealModuleType.Engine, InterfaceImpl = typeof(IViewportInteractableInterfaceImpl))]
public interface IViewportInteractableInterface : IInterface
{
}
