using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OodleNetworkHandlerComponent;

[UEnum]
[UMetaPath("/Script/OodleNetworkHandlerComponent.EOodleNetworkEnableMode", "OodleNetworkHandlerComponent", UnrealModuleType.EnginePlugin)]
public enum EOodleNetworkEnableMode
{
	AlwaysEnabled,
	WhenCompressedPacketReceived
}
