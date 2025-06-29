using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/AIModule.GenericTeamAgentInterface", "AIModule", UnrealModuleType.Engine, InterfaceImpl = typeof(IGenericTeamAgentInterfaceImpl))]
public interface IGenericTeamAgentInterface : IInterface
{
}
