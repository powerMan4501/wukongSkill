using UnrealEngine.Runtime;

namespace UnrealEngine.RigVM;

[UEnum]
[UMetaPath("/Script/RigVM.ERigVMRegisterType", "RigVM", UnrealModuleType.Engine)]
public enum ERigVMRegisterType
{
	Plain,
	String,
	Name,
	Struct,
	Invalid
}
