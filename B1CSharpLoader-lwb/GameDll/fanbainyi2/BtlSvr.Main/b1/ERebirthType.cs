using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.RebirthType")]
public enum ERebirthType : byte
{
	RebirthPoint,
	Quick,
	SelfRescue,
	EnumMax
}
