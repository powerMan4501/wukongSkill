using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/NavigationSystem.NavLinkHostInterface", "NavigationSystem", UnrealModuleType.Engine, InterfaceImpl = typeof(INavLinkHostInterfaceImpl))]
public interface INavLinkHostInterface : IInterface
{
}
