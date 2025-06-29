using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshPaintEditorMode;

[UEnum]
[UMetaPath("/Script/MeshPaintEditorMode.EMeshPaintColorView", "MeshPaintEditorMode", UnrealModuleType.EnginePlugin)]
public enum EMeshPaintColorView
{
	Normal,
	RGB,
	Alpha,
	Red,
	Green,
	Blue
}
