using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/Water.WaterBrushActorInterface", "Water", UnrealModuleType.EnginePlugin, InterfaceImpl = typeof(IWaterBrushActorInterfaceImpl))]
public interface IWaterBrushActorInterface : IInterface
{
}
