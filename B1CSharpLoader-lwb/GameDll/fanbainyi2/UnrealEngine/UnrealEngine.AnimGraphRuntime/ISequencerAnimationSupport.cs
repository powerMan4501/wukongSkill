using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/AnimGraphRuntime.SequencerAnimationSupport", "AnimGraphRuntime", UnrealModuleType.Engine, InterfaceImpl = typeof(ISequencerAnimationSupportImpl))]
public interface ISequencerAnimationSupport : IInterface
{
}
