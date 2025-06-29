using UnrealEngine.Runtime;

namespace UnrealEngine.InteractiveToolsFramework;

[UEnum]
[UMetaPath("/Script/InteractiveToolsFramework.EInputDevices", "InteractiveToolsFramework", UnrealModuleType.Engine)]
public enum EInputDevices
{
	None = 0,
	Keyboard = 1,
	Mouse = 2,
	Gamepad = 4,
	OculusTouch = 8,
	HTCViveWands = 16,
	AnySpatialDevice = 24,
	TabletFingers = 1024
}
