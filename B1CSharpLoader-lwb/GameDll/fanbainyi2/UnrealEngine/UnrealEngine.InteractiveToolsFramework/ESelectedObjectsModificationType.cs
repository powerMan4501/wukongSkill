using UnrealEngine.Runtime;

namespace UnrealEngine.InteractiveToolsFramework;

[UEnum]
[UMetaPath("/Script/InteractiveToolsFramework.ESelectedObjectsModificationType", "InteractiveToolsFramework", UnrealModuleType.Engine)]
public enum ESelectedObjectsModificationType
{
	Replace,
	Add,
	Remove,
	Clear
}
