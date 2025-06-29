using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/AIModule.AIPerceptionListenerInterface", "AIModule", UnrealModuleType.Engine, InterfaceImpl = typeof(IAIPerceptionListenerInterfaceImpl))]
public interface IAIPerceptionListenerInterface : IInterface
{
}
