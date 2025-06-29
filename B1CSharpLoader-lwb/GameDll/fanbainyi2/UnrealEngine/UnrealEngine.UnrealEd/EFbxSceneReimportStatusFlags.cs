using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EFbxSceneReimportStatusFlags", "UnrealEd", UnrealModuleType.Engine)]
public enum EFbxSceneReimportStatusFlags
{
	None = 0,
	Added = 1,
	Removed = 2,
	Same = 4,
	FoundContentBrowserAsset = 8,
	ReimportAsset = 0x10
}
