using UnrealEngine.Runtime;

namespace UnrealEngine.RigVM;

[UEnum]
[UMetaPath("/Script/RigVM.ERigVMCopyType", "RigVM", UnrealModuleType.Engine)]
public enum ERigVMCopyType
{
	Default,
	FloatToDouble,
	DoubleToFloat
}
