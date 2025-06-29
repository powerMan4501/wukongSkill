using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.EFbxSceneVertexColorImportOption", "UnrealEd", UnrealModuleType.Engine)]
public enum EFbxSceneVertexColorImportOption : byte
{
	Replace,
	Ignore,
	Override
}
