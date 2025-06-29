using UnrealEngine.Runtime;

namespace UnrealEngine.EditorStyle;

[UEnum]
[UMetaPath("/Script/EditorStyle.ELogCategoryColorizationMode", "EditorStyle", UnrealModuleType.Engine)]
public enum ELogCategoryColorizationMode
{
	None,
	ColorizeWholeLine,
	ColorizeCategoryOnly,
	ColorizeCategoryAsBadge
}
