using UnrealEngine.Runtime;

namespace UnrealEngine.MeshPaint;

[UEnum]
[UMetaPath("/Script/MeshPaint.EMeshPaintMode", "MeshPaint", UnrealModuleType.Engine)]
public enum EMeshPaintMode
{
	PaintColors,
	PaintWeights
}
