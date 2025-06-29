using UnrealEngine.Runtime;

namespace UnrealEngine.NetCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/NetCore.ENetworkFailure", "NetCore", UnrealModuleType.Engine)]
public enum ENetworkFailure : byte
{
	NetDriverAlreadyExists,
	NetDriverCreateFailure,
	NetDriverListenFailure,
	ConnectionLost,
	ConnectionTimeout,
	FailureReceived,
	OutdatedClient,
	OutdatedServer,
	PendingConnectionFailure,
	NetGuidMismatch,
	NetChecksumMismatch
}
