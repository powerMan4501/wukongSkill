using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/Engine.VisualLoggerDebugSnapshotInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(IVisualLoggerDebugSnapshotInterfaceImpl))]
public interface IVisualLoggerDebugSnapshotInterface : IInterface
{
}
