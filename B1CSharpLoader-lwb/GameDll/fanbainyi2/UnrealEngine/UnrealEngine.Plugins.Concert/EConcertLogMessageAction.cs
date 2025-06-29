using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Concert;

[UEnum]
[UMetaPath("/Script/Concert.EConcertLogMessageAction", "Concert", UnrealModuleType.EnginePlugin)]
public enum EConcertLogMessageAction
{
	None,
	Send,
	Publish,
	Receive,
	Queue,
	Discard,
	Duplicate,
	TimeOut,
	Process,
	EndpointDiscovery,
	EndpointTimeOut,
	EndpointClosure
}
