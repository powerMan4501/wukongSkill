using UnrealEngine.Runtime;

namespace UnrealEngine.VisualGraphUtils;

[UEnum]
[UMetaPath("/Script/VisualGraphUtils.EVisualGraphEdgeDirection", "VisualGraphUtils", UnrealModuleType.Engine)]
public enum EVisualGraphEdgeDirection
{
	SourceToTarget,
	TargetToSource,
	BothWays
}
