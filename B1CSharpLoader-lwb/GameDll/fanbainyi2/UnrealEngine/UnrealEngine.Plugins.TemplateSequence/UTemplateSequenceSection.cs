using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.TemplateSequence;

[UClass(Flags = (ClassFlags)812646564uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/TemplateSequence.TemplateSequenceSection", "TemplateSequence", UnrealModuleType.EnginePlugin)]
public class UTemplateSequenceSection : UMovieSceneSubSection, IMovieSceneEntityProvider, IInterface
{
}
