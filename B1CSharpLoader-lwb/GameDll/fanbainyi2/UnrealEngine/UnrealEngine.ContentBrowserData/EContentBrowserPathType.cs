using UnrealEngine.Runtime;

namespace UnrealEngine.ContentBrowserData;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ContentBrowserData.EContentBrowserPathType", "ContentBrowserData", UnrealModuleType.Engine)]
public enum EContentBrowserPathType : byte
{
	None,
	Internal,
	Virtual
}
