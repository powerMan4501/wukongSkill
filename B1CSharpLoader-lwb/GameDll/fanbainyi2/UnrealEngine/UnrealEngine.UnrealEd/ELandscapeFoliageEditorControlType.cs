using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.ELandscapeFoliageEditorControlType", "UnrealEd", UnrealModuleType.Engine)]
public enum ELandscapeFoliageEditorControlType
{
	IgnoreCtrl,
	RequireCtrl,
	RequireNoCtrl
}
