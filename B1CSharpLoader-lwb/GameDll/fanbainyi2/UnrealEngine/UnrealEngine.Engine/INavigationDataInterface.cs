using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/Engine.NavigationDataInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(INavigationDataInterfaceImpl))]
public interface INavigationDataInterface : IInterface
{
}
