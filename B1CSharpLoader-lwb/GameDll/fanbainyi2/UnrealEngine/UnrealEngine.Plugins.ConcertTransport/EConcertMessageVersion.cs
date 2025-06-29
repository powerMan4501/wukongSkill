using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertTransport;

[UEnum]
[UMetaPath("/Script/ConcertTransport.EConcertMessageVersion", "ConcertTransport", UnrealModuleType.EnginePlugin)]
public enum EConcertMessageVersion
{
	BeforeVersioning = 0,
	Initial = 1,
	VersionPlusOne = 2,
	LatestVersion = 1
}
