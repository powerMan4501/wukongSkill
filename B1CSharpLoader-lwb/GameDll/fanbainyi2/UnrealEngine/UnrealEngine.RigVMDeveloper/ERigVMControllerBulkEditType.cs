using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UEnum]
[UMetaPath("/Script/RigVMDeveloper.ERigVMControllerBulkEditType", "RigVMDeveloper", UnrealModuleType.Engine)]
public enum ERigVMControllerBulkEditType
{
	AddExposedPin,
	RemoveExposedPin,
	RenameExposedPin,
	ChangeExposedPinType,
	AddVariable,
	RemoveVariable,
	RenameVariable,
	ChangeVariableType,
	RemoveFunction,
	Max
}
