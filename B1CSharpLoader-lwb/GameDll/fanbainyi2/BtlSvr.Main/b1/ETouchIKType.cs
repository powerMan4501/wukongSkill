using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TouchIKType")]
public enum ETouchIKType : byte
{
	LeftHand,
	RightHand,
	LeftFoot,
	RightFoot,
	Head,
	Tail,
	Weapon,
	EnumMax
}
