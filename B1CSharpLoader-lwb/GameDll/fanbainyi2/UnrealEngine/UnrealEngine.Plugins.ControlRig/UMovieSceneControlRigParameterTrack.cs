using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UClass(Flags = (ClassFlags)820510880uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ControlRig.MovieSceneControlRigParameterTrack", "ControlRig", UnrealModuleType.EnginePlugin)]
public class UMovieSceneControlRigParameterTrack : UMovieSceneNameableTrack, IMovieSceneTrackTemplateProducer, IInterface, INodeAndChannelMappings
{
}
