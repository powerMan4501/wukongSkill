using UnrealEngine.Runtime;

namespace UnrealEngine.RigVM;

[UEnum]
[UMetaPath("/Script/RigVM.ERigVMMemoryType", "RigVM", UnrealModuleType.Engine)]
public enum ERigVMMemoryType
{
	Work,
	Literal,
	External,
	Debug,
	Invalid
}
