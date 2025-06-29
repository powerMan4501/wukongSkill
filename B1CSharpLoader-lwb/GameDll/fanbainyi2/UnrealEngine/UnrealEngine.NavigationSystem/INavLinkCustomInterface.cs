using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/NavigationSystem.NavLinkCustomInterface", "NavigationSystem", UnrealModuleType.Engine, InterfaceImpl = typeof(INavLinkCustomInterfaceImpl))]
public interface INavLinkCustomInterface : IInterface
{
}
