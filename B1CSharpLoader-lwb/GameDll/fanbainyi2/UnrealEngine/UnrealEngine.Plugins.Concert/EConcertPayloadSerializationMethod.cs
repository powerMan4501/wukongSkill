using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Concert;

[UEnum]
[UMetaPath("/Script/Concert.EConcertPayloadSerializationMethod", "Concert", UnrealModuleType.EnginePlugin)]
public enum EConcertPayloadSerializationMethod
{
	Standard,
	Cbor
}
