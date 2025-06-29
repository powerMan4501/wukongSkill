using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/Engine.Interface_PostProcessVolume", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(IInterface_PostProcessVolumeImpl))]
public interface IInterface_PostProcessVolume : IInterface
{
}
