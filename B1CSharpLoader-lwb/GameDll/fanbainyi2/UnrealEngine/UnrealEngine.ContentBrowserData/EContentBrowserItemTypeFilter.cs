using UnrealEngine.Runtime;

namespace UnrealEngine.ContentBrowserData;

[UEnum]
[UMetaPath("/Script/ContentBrowserData.EContentBrowserItemTypeFilter", "ContentBrowserData", UnrealModuleType.Engine)]
public enum EContentBrowserItemTypeFilter
{
	IncludeNone,
	IncludeFolders,
	IncludeFiles,
	IncludeAll
}
