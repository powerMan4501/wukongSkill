using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Concert;

[UEnum]
[UMetaPath("/Script/Concert.EConcertSessionResponseCode", "Concert", UnrealModuleType.EnginePlugin)]
public enum EConcertSessionResponseCode
{
	Success,
	Failed,
	InvalidRequest
}
