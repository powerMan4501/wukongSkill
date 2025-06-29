using UnrealEngine.Runtime;

namespace UnrealEngine.UMGEditor;

[UEnum]
[UMetaPath("/Script/UMGEditor.EPropertyBindingPermissionLevel", "UMGEditor", UnrealModuleType.Engine)]
public enum EPropertyBindingPermissionLevel
{
	Allow,
	Prevent,
	PreventAndWarn,
	PreventAndError
}
