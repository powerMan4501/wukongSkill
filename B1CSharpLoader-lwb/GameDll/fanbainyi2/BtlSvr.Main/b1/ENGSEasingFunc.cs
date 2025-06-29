using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ENGSEasingFunc")]
public enum ENGSEasingFunc : byte
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
	CircularInOut,
	BackEaseIn,
	BackEaseOut,
	BackEaseInOut,
	EaseInQuart,
	EaseInOutQuint,
	Sin
}
