using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.BulletOrMagicFieldMoveModeType")]
public enum EBulletOrMagicFieldMoveModeType : byte
{
	None = 0,
	StraightMode = 1,
	TraceMode = 2,
	BezierMode = 3,
	PhysicsMode = 5,
	PhysicsSimulatingMode = 7,
	CircleSurroundMoveMode = 8,
	ParabolaMoveMode = 9,
	RealPhysicsMode = 10,
	ManualCurveMoveMode = 11,
	InertialSimulatingMoveMode = 12,
	SplineMoveMode = 13,
	InnerSplineMoveMode = 14,
	FbmMoveMode = 15,
	FbmBymjMoveMode = 16,
	EnumMax = 17
}
