using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.BeAttackedBlendType")]
public enum EBeAttackedBlendType : byte
{
	None = 0,
	Physics = 1,
	AdditiveAnim = 2,
	MatJitter = 4,
	Scar = 8
}
