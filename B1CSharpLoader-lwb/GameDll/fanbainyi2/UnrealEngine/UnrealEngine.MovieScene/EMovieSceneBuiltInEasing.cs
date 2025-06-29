using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[UMetaPath("/Script/MovieScene.EMovieSceneBuiltInEasing", "MovieScene", UnrealModuleType.Engine)]
public enum EMovieSceneBuiltInEasing
{
	Linear,
	SinIn,
	SinOut,
	SinInOut,
	QuadIn,
	QuadOut,
	QuadInOut,
	CubicIn,
	CubicOut,
	CubicInOut,
	QuartIn,
	QuartOut,
	QuartInOut,
	QuintIn,
	QuintOut,
	QuintInOut,
	ExpoIn,
	ExpoOut,
	ExpoInOut,
	CircIn,
	CircOut,
	CircInOut
}
