using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EEasingFunc", "Engine", UnrealModuleType.Engine)]
public enum EEasingFunc : byte
{
	Linear,
	Step,
	SinusoidalIn,
	SinusoidalOut,
	SinusoidalInOut,
	EaseIn,
	EaseOut,
	EaseInOut,
	ExpoIn,
	ExpoOut,
	ExpoInOut,
	CircularIn,
	CircularOut,
	CircularInOut
}
