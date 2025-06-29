using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/SlateCore.FontFaceInterface", "SlateCore", UnrealModuleType.Engine, InterfaceImpl = typeof(IFontFaceInterfaceImpl))]
public interface IFontFaceInterface : IInterface
{
}
