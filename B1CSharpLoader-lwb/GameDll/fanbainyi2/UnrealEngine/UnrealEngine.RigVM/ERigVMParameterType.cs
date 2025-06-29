using UnrealEngine.Runtime;

namespace UnrealEngine.RigVM;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/RigVM.ERigVMParameterType", "RigVM", UnrealModuleType.Engine)]
public enum ERigVMParameterType : byte
{
	Input,
	Output,
	Invalid
}
