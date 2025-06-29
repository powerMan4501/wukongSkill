using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieScene3DPathSection_Axis", "MovieSceneTracks", UnrealModuleType.Engine)]
public enum EMovieScene3DPathSection_Axis : byte
{
	X,
	Y,
	Z,
	NEG_X,
	NEG_Y,
	NEG_Z
}
