using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Concert;

[UEnum]
[UMetaPath("/Script/Concert.EConcertSourceValidationMode", "Concert", UnrealModuleType.EnginePlugin)]
public enum EConcertSourceValidationMode
{
	Hard,
	Soft,
	SoftAutoProceed
}
