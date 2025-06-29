using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EOccludedGeometryFilteringPolicy", "Engine", UnrealModuleType.Engine)]
public enum EOccludedGeometryFilteringPolicy
{
	NoOcclusionFiltering,
	VisibilityBasedFiltering
}
