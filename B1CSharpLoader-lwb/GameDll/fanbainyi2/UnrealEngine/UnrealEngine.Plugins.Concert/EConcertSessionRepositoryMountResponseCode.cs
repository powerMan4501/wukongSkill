using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Concert;

[UEnum]
[UMetaPath("/Script/Concert.EConcertSessionRepositoryMountResponseCode", "Concert", UnrealModuleType.EnginePlugin)]
public enum EConcertSessionRepositoryMountResponseCode
{
	None,
	Mounted,
	AlreadyMounted,
	NotFound
}
