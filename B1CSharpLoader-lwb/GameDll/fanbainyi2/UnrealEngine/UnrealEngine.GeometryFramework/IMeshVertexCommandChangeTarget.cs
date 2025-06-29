using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/GeometryFramework.MeshVertexCommandChangeTarget", "GeometryFramework", UnrealModuleType.Engine, InterfaceImpl = typeof(IMeshVertexCommandChangeTargetImpl))]
public interface IMeshVertexCommandChangeTarget : IInterface
{
}
