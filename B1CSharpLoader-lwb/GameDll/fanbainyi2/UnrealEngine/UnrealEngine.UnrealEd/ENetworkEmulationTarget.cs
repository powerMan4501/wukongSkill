using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.NetworkEmulationTarget", "UnrealEd", UnrealModuleType.Engine)]
public enum ENetworkEmulationTarget
{
	Server,
	Client,
	Any
}
