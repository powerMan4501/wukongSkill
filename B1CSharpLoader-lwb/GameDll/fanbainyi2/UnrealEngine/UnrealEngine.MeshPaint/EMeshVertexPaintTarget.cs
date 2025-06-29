using UnrealEngine.Runtime;

namespace UnrealEngine.MeshPaint;

[UEnum]
[UMetaPath("/Script/MeshPaint.EMeshVertexPaintTarget", "MeshPaint", UnrealModuleType.Engine)]
public enum EMeshVertexPaintTarget
{
	ComponentInstance,
	Mesh
}
