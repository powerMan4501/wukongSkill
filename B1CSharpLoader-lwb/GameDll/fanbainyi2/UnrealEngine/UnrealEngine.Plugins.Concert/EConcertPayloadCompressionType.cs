using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Concert;

[UEnum]
[UMetaPath("/Script/Concert.EConcertPayloadCompressionType", "Concert", UnrealModuleType.EnginePlugin)]
public enum EConcertPayloadCompressionType
{
	None,
	Heuristic,
	Always
}
