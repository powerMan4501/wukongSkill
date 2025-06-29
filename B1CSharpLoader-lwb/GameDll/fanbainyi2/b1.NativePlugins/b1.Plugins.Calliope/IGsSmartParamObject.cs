using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/Calliope.GsSmartParamObject", "Calliope", UnrealModuleType.GamePlugin, InterfaceImpl = typeof(IGsSmartParamObjectImpl))]
public interface IGsSmartParamObject : IInterface
{
}
