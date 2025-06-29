using UnrealEngine.Runtime;

namespace UnrealEngine.ContentBrowserData;

[UEnum]
[UMetaPath("/Script/ContentBrowserData.EContentBrowserItemCategoryFilter", "ContentBrowserData", UnrealModuleType.Engine)]
public enum EContentBrowserItemCategoryFilter
{
	IncludeNone = 0,
	IncludeAssets = 1,
	IncludeClasses = 2,
	IncludeCollections = 4,
	IncludeMisc = 8,
	IncludeAll = 15
}
