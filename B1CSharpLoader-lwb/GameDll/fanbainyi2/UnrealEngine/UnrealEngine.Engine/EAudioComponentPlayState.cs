using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAudioComponentPlayState", "Engine", UnrealModuleType.Engine)]
public enum EAudioComponentPlayState : byte
{
	Playing,
	Stopped,
	Paused,
	FadingIn,
	FadingOut,
	Count
}
