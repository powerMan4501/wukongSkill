using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.EVertexColorImportOption", "UnrealEd", UnrealModuleType.Engine)]
public enum EVertexColorImportOption : byte
{
	Replace,
	Ignore,
	Override
}
