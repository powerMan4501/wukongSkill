using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.ERefRotatorType", "b1", UnrealModuleType.Game)]
public enum ERefRotatorType : byte
{
	Zero,
	RefByController,
	RefByPlayer,
	RefByPlayerQTE
}
