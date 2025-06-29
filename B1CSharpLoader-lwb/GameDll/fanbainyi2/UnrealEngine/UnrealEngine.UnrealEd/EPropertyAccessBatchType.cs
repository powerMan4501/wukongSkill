using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EPropertyAccessBatchType", "UnrealEd", UnrealModuleType.Engine)]
public enum EPropertyAccessBatchType
{
	Unbatched,
	Batched
}
