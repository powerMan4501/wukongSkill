using UnrealEngine.Runtime;

namespace UnrealEngine.InteractiveToolsFramework;

[UEnum]
[UMetaPath("/Script/InteractiveToolsFramework.EInputCaptureRequestType", "InteractiveToolsFramework", UnrealModuleType.Engine)]
public enum EInputCaptureRequestType
{
	Begin = 1,
	Ignore
}
