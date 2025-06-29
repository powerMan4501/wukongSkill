using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UEnum]
[UMetaPath("/Script/RigVMDeveloper.ERigVMControllerBulkEditProgress", "RigVMDeveloper", UnrealModuleType.Engine)]
public enum ERigVMControllerBulkEditProgress
{
	BeginLoad,
	FinishedLoad,
	BeginEdit,
	FinishedEdit,
	Max
}
