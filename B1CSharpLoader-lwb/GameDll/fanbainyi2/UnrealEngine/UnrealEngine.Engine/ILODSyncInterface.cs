using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/Engine.LODSyncInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(ILODSyncInterfaceImpl))]
public interface ILODSyncInterface : IInterface
{
}
