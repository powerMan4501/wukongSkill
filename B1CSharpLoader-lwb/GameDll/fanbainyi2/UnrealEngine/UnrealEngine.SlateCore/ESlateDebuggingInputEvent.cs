using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[UMetaPath("/Script/SlateCore.ESlateDebuggingInputEvent", "SlateCore", UnrealModuleType.Engine)]
public enum ESlateDebuggingInputEvent
{
	MouseMove,
	MouseEnter,
	MouseLeave,
	PreviewMouseButtonDown,
	MouseButtonDown,
	MouseButtonUp,
	MouseButtonDoubleClick,
	MouseWheel,
	TouchStart,
	TouchEnd,
	TouchForceChanged,
	TouchFirstMove,
	TouchMoved,
	DragDetected,
	DragEnter,
	DragLeave,
	DragOver,
	DragDrop,
	DropMessage,
	PreviewKeyDown,
	KeyDown,
	KeyUp,
	KeyChar,
	AnalogInput,
	TouchGesture,
	MotionDetected
}
