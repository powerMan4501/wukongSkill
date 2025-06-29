using UnrealEngine.Runtime;

namespace UnrealEngine.MeshPaint;

[UEnum]
[UMetaPath("/Script/MeshPaint.EMeshPaintColorViewMode", "MeshPaint", UnrealModuleType.Engine)]
public enum EMeshPaintColorViewMode
{
	Normal,
	RGB,
	Alpha,
	Red,
	Green,
	Blue
}
