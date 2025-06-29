using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Concert;

[UEnum]
[UMetaPath("/Script/Concert.EConcertConnectionResult", "Concert", UnrealModuleType.EnginePlugin)]
public enum EConcertConnectionResult
{
	None,
	ConnectionAccepted,
	ConnectionRefused,
	AlreadyConnected
}
