using UnrealEngine.Runtime;

namespace UnrealEngine.AutomationController;

[UEnum]
[UMetaPath("/Script/AutomationController.EAutomationArtifactType", "AutomationController", UnrealModuleType.Engine)]
public enum EAutomationArtifactType
{
	None,
	Image,
	Comparison
}
