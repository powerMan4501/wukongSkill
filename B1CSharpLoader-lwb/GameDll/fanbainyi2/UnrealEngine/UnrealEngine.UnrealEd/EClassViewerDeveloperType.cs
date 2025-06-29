using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EClassViewerDeveloperType", "UnrealEd", UnrealModuleType.Engine)]
public enum EClassViewerDeveloperType
{
	CVDT_None,
	CVDT_CurrentUser,
	CVDT_All,
	CVDT_Max
}
