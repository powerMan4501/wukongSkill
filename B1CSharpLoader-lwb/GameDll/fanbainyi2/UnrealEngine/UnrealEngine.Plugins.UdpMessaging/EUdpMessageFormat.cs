using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.UdpMessaging;

[UEnum]
[UMetaPath("/Script/UdpMessaging.EUdpMessageFormat", "UdpMessaging", UnrealModuleType.EnginePlugin)]
public enum EUdpMessageFormat
{
	None,
	Json,
	TaggedProperty,
	CborPlatformEndianness,
	CborStandardEndianness
}
