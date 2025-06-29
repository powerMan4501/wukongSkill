using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertTransport;

[UEnum]
[UMetaPath("/Script/ConcertTransport.EConcertResponseCode", "ConcertTransport", UnrealModuleType.EnginePlugin)]
public enum EConcertResponseCode
{
	Pending,
	Success,
	Failed,
	InvalidRequest,
	UnknownRequest,
	TimedOut
}
