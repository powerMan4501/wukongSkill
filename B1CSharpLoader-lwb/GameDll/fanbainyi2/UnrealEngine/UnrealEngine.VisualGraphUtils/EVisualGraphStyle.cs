using UnrealEngine.Runtime;

namespace UnrealEngine.VisualGraphUtils;

[UEnum]
[UMetaPath("/Script/VisualGraphUtils.EVisualGraphStyle", "VisualGraphUtils", UnrealModuleType.Engine)]
public enum EVisualGraphStyle
{
	Filled,
	Diagonals,
	Rounded,
	Dashed,
	Dotted,
	Solid,
	Bold
}
