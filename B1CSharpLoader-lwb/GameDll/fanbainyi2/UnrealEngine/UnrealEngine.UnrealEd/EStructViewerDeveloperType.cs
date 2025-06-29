using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EStructViewerDeveloperType", "UnrealEd", UnrealModuleType.Engine)]
public enum EStructViewerDeveloperType
{
	SVDT_None,
	SVDT_CurrentUser,
	SVDT_All,
	SVDT_Max
}
