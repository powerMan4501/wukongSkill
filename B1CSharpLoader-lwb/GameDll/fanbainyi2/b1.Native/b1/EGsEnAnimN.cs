using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EGsEnAnimN", "b1", UnrealModuleType.Game)]
public enum EGsEnAnimN : byte
{
	None,
	MontageJumpToSection,
	PlayerNiagaraFX,
	Max
}
