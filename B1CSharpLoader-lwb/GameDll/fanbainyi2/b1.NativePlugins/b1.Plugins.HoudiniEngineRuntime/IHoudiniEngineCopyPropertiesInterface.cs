using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniEngineCopyPropertiesInterface", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin, InterfaceImpl = typeof(IHoudiniEngineCopyPropertiesInterfaceImpl))]
public interface IHoudiniEngineCopyPropertiesInterface : IInterface
{
}
