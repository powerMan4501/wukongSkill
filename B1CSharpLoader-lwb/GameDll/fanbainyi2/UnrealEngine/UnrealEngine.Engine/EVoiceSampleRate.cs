using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EVoiceSampleRate", "Engine", UnrealModuleType.Engine)]
public enum EVoiceSampleRate
{
	Low16000Hz = 16000,
	Normal24000Hz = 24000
}
