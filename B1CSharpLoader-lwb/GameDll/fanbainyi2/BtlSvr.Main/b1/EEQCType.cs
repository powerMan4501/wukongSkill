using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EEQCType")]
public enum EEQCType : byte
{
	None,
	Target,
	Player,
	Querier
}
