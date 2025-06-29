using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/Engine.NetworkPredictionInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(INetworkPredictionInterfaceImpl))]
public interface INetworkPredictionInterface : IInterface
{
}
