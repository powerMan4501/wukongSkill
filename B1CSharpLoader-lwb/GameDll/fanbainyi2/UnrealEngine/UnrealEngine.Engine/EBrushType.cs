using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EBrushType", "Engine", UnrealModuleType.Engine)]
public enum EBrushType
{
	Brush_Default,
	Brush_Add,
	Brush_Subtract
}
