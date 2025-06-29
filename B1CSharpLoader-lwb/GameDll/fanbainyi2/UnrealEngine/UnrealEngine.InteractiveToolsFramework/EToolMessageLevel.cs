using UnrealEngine.Runtime;

namespace UnrealEngine.InteractiveToolsFramework;

[UEnum]
[UMetaPath("/Script/InteractiveToolsFramework.EToolMessageLevel", "InteractiveToolsFramework", UnrealModuleType.Engine)]
public enum EToolMessageLevel
{
	Internal,
	UserMessage,
	UserNotification,
	UserWarning,
	UserError
}
