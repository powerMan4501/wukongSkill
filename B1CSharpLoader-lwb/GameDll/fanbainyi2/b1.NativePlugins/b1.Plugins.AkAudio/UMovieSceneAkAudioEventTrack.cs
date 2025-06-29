using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)820510880uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.MovieSceneAkAudioEventTrack", "AkAudio", UnrealModuleType.GamePlugin)]
public class UMovieSceneAkAudioEventTrack : UMovieSceneAkTrack, IMovieSceneTrackTemplateProducer, IInterface
{
}
