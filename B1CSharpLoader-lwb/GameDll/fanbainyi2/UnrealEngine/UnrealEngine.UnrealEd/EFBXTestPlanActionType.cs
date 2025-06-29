using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EFBXTestPlanActionType", "UnrealEd", UnrealModuleType.Engine)]
public enum EFBXTestPlanActionType
{
	Import,
	Reimport,
	AddLOD,
	ReimportLOD,
	ImportReload,
	AddAlternateSkinnig
}
