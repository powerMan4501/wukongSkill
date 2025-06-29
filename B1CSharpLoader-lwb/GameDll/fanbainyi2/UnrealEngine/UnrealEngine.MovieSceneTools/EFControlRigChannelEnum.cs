using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTools;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTools.FControlRigChannelEnum", "MovieSceneTools", UnrealModuleType.Engine)]
public enum EFControlRigChannelEnum : byte
{
	Bool,
	Enum,
	Integer,
	Float,
	Vector2DX,
	Vector2DY,
	PositionX,
	PositionY,
	PositionZ,
	RotatorX,
	RotatorY,
	RotatorZ,
	ScaleX,
	ScaleY,
	ScaleZ
}
