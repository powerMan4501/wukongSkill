using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/Calliope.CalliopeSequencePerformer", "Calliope", UnrealModuleType.GamePlugin, InterfaceImpl = typeof(ICalliopeSequencePerformerImpl))]
public interface ICalliopeSequencePerformer : IInterface
{
}
