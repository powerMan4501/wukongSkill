using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)820510880uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.MovieSceneAkAudioRTPCTrack", "AkAudio", UnrealModuleType.GamePlugin)]
public class UMovieSceneAkAudioRTPCTrack : UMovieSceneAkTrack, IMovieSceneTrackTemplateProducer, IInterface
{
}
