using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.DamageCalcType")]
public enum EDamageCalcType : byte
{
	Normal,
	ElemDot,
	HPMaxRatioAbs
}
