using UnrealEngine.Runtime;

namespace UnrealEngine.AutomationTest;

[UEnum]
[UMetaPath("/Script/AutomationTest.EAutomationState", "AutomationTest", UnrealModuleType.Engine)]
public enum EAutomationState
{
	NotRun,
	InProcess,
	Fail,
	Success,
	Skipped
}
