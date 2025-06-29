using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.MovieRelationType")]
public enum EMovieRelationType : byte
{
	[UMeta(MD.Hidden)]
	None,
	[UMeta(MD.Hidden)]
	Actor,
	[UMeta(MD.Hidden)]
	Location,
	[UMeta(MD.Hidden)]
	Monster,
	ManualLocation
}
