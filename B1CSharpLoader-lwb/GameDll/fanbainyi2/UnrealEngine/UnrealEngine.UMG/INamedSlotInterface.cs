using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/UMG.NamedSlotInterface", "UMG", UnrealModuleType.Engine, InterfaceImpl = typeof(INamedSlotInterfaceImpl))]
public interface INamedSlotInterface : IInterface
{
}
