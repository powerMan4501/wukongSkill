using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.EFBXAnimationLengthImportType", "UnrealEd", UnrealModuleType.Engine)]
public enum EFBXAnimationLengthImportType : byte
{
	FBXALIT_ExportedTime,
	FBXALIT_AnimatedKey,
	FBXALIT_SetRange
}
