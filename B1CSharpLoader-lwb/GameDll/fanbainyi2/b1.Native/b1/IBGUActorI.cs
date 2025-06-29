using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UInterface(Flags = 810565793u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGUActorI", "b1", UnrealModuleType.Game, InterfaceImpl = typeof(IBGUActorIImpl))]
public interface IBGUActorI : IInterface
{
}
