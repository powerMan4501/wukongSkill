using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/MovieScene.MovieSceneTrackTemplateProducer", "MovieScene", UnrealModuleType.Engine, InterfaceImpl = typeof(IMovieSceneTrackTemplateProducerImpl))]
public interface IMovieSceneTrackTemplateProducer : IInterface
{
}
