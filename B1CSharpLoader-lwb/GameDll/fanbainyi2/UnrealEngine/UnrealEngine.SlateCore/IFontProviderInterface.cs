using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/SlateCore.FontProviderInterface", "SlateCore", UnrealModuleType.Engine, InterfaceImpl = typeof(IFontProviderInterfaceImpl))]
public interface IFontProviderInterface : IInterface
{
}
