using UnrealEngine.Runtime;

namespace UnrealEngine.InteractiveToolsFramework;

[UEnum]
[UMetaPath("/Script/InteractiveToolsFramework.EInputCaptureState", "InteractiveToolsFramework", UnrealModuleType.Engine)]
public enum EInputCaptureState
{
	Begin = 1,
	Continue,
	End,
	Ignore
}
