using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/MovieScene.NodeAndChannelMappings", "MovieScene", UnrealModuleType.Engine, InterfaceImpl = typeof(INodeAndChannelMappingsImpl))]
public interface INodeAndChannelMappings : IInterface
{
}
