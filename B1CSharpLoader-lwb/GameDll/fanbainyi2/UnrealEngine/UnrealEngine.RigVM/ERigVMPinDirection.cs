using UnrealEngine.Runtime;

namespace UnrealEngine.RigVM;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/RigVM.ERigVMPinDirection", "RigVM", UnrealModuleType.Engine)]
public enum ERigVMPinDirection : byte
{
	Input,
	Output,
	IO,
	Visible,
	Hidden,
	Invalid
}
