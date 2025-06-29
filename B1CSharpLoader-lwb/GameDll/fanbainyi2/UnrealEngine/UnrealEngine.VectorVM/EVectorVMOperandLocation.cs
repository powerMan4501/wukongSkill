using UnrealEngine.Runtime;

namespace UnrealEngine.VectorVM;

[UEnum]
[UMetaPath("/Script/VectorVM.EVectorVMOperandLocation", "VectorVM", UnrealModuleType.Engine)]
public enum EVectorVMOperandLocation
{
	Register,
	Constant,
	Num
}
