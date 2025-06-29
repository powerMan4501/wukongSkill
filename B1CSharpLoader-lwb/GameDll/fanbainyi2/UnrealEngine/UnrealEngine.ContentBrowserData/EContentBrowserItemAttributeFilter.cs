using UnrealEngine.Runtime;

namespace UnrealEngine.ContentBrowserData;

[UEnum]
[UMetaPath("/Script/ContentBrowserData.EContentBrowserItemAttributeFilter", "ContentBrowserData", UnrealModuleType.Engine)]
public enum EContentBrowserItemAttributeFilter
{
	IncludeNone = 0,
	IncludeProject = 1,
	IncludeEngine = 2,
	IncludePlugins = 4,
	IncludeDeveloper = 8,
	IncludeLocalized = 16,
	IncludeAll = 31
}
