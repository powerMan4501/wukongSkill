using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/Engine.RVOAvoidanceInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(IRVOAvoidanceInterfaceImpl))]
public interface IRVOAvoidanceInterface : IInterface
{
}
