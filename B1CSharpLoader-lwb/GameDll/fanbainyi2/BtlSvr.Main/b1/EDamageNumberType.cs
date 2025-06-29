using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.DamageNumberType")]
public enum EDamageNumberType : byte
{
	None,
	Normal,
	Critical,
	RecoveryHP,
	Backstap
}
