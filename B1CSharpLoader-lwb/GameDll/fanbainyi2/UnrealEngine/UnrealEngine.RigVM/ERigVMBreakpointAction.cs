using UnrealEngine.Runtime;

namespace UnrealEngine.RigVM;

[UEnum]
[UMetaPath("/Script/RigVM.ERigVMBreakpointAction", "RigVM", UnrealModuleType.Engine)]
public enum ERigVMBreakpointAction
{
	None,
	Resume,
	StepOver,
	StepInto,
	StepOut,
	Max
}
