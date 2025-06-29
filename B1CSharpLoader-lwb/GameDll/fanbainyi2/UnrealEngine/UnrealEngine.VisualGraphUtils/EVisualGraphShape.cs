using UnrealEngine.Runtime;

namespace UnrealEngine.VisualGraphUtils;

[UEnum]
[UMetaPath("/Script/VisualGraphUtils.EVisualGraphShape", "VisualGraphUtils", UnrealModuleType.Engine)]
public enum EVisualGraphShape
{
	Box,
	Polygon,
	Ellipse,
	Circle,
	Triangle,
	PlainText,
	Diamond,
	Parallelogram,
	House
}
