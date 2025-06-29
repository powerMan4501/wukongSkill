using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)820510880uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Niagara.MovieSceneNiagaraBoolParameterTrack", "Niagara", UnrealModuleType.EnginePlugin)]
public class UMovieSceneNiagaraBoolParameterTrack : UMovieSceneNiagaraParameterTrack, IMovieSceneTrackTemplateProducer, IInterface
{
}
