using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTools;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTools.FTransformChannelEnum", "MovieSceneTools", UnrealModuleType.Engine)]
public enum EFTransformChannelEnum : byte
{
	TranslateX,
	TranslateY,
	TranslateZ,
	RotateX,
	RotateY,
	RotateZ,
	ScaleX,
	ScaleY,
	ScaleZ
}
