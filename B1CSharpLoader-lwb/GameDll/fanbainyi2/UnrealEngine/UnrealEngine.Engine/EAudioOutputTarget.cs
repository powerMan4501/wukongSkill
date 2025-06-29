using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAudioOutputTarget", "Engine", UnrealModuleType.Engine)]
public enum EAudioOutputTarget
{
	Speaker,
	Controller,
	ControllerFallbackToSpeaker
}
