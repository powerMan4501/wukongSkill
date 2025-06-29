using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMouseCaptureMode", "Engine", UnrealModuleType.Engine)]
public enum EMouseCaptureMode
{
	NoCapture,
	CapturePermanently,
	CapturePermanently_IncludingInitialMouseDown,
	CaptureDuringMouseDown,
	CaptureDuringRightMouseDown
}
