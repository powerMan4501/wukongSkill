using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UEnum]
[UMetaPath("/Script/MovieSceneTracks.EParticleKey", "MovieSceneTracks", UnrealModuleType.Engine)]
public enum EParticleKey
{
	Activate,
	Deactivate,
	Trigger
}
