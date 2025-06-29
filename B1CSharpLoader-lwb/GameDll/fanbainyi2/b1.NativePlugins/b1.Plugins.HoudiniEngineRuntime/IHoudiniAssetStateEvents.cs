using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniAssetStateEvents", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin, InterfaceImpl = typeof(IHoudiniAssetStateEventsImpl))]
public interface IHoudiniAssetStateEvents : IInterface
{
}
