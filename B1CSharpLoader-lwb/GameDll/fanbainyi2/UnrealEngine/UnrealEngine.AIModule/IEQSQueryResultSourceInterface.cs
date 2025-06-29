using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/AIModule.EQSQueryResultSourceInterface", "AIModule", UnrealModuleType.Engine, InterfaceImpl = typeof(IEQSQueryResultSourceInterfaceImpl))]
public interface IEQSQueryResultSourceInterface : IInterface
{
}
