using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/GeometryFramework.MeshCommandChangeTarget", "GeometryFramework", UnrealModuleType.Engine, InterfaceImpl = typeof(IMeshCommandChangeTargetImpl))]
public interface IMeshCommandChangeTarget : IInterface
{
}
