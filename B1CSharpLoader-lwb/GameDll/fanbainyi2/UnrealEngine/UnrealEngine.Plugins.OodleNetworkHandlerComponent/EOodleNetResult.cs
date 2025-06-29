using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OodleNetworkHandlerComponent;

[UEnum]
[UMetaPath("/Script/OodleNetworkHandlerComponent.EOodleNetResult", "OodleNetworkHandlerComponent", UnrealModuleType.EnginePlugin)]
public enum EOodleNetResult
{
	Unknown,
	Success,
	OodleDecodeFailed,
	OodleSerializePayloadFail,
	OodleBadDecompressedLength,
	OodleNoDictionary
}
