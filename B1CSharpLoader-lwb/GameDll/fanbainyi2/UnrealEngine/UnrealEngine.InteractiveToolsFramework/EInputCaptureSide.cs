using UnrealEngine.Runtime;

namespace UnrealEngine.InteractiveToolsFramework;

[UEnum]
[UMetaPath("/Script/InteractiveToolsFramework.EInputCaptureSide", "InteractiveToolsFramework", UnrealModuleType.Engine)]
public enum EInputCaptureSide
{
	None = 0,
	Left = 1,
	Right = 2,
	Both = 3,
	Any = 99
}
