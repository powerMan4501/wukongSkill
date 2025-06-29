using UnrealEngine.AudioExtensions;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.SoundParameterControllerInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(ISoundParameterControllerInterfaceImpl))]
public interface ISoundParameterControllerInterface : IAudioParameterControllerInterface, IInterface
{
}
