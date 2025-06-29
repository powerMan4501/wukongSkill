using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[UMetaPath("/Script/Slate.ESelectionMode", "Slate", UnrealModuleType.Engine)]
public enum ESelectionMode
{
	None,
	Single,
	SingleToggle,
	Multi
}
