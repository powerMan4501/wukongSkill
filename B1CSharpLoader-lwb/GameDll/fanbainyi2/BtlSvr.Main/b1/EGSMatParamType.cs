using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EGSMatParamType")]
public enum EGSMatParamType : byte
{
	[UMeta(MD.Hidden)]
	None = 0,
	Float = 1,
	Vector = 2,
	LinearColor = 3,
	FloatCurve = 4,
	VectorCurve = 5,
	LinearColorValue = 6,
	[UMeta(MD.Hidden)]
	OwnerInfoStart = 64,
	OwnerWorldLocation = 65,
	OwnerForwardVector = 66,
	OwnerVelocity = 67,
	OwnerSocketLocation = 68,
	OwnerSocketForwardVector = 69,
	[UMeta(MD.Hidden)]
	PlayerInfoStart = 128,
	PlayerWorldLocation = 129,
	PlayerForwardVector = 130,
	PlayerVelocity = 131,
	PlayerSocketLocation = 132,
	PlayerSocketForwardVector = 133
}
