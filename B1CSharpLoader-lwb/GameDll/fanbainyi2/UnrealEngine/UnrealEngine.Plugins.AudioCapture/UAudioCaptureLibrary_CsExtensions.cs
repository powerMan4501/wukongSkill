using UnrealEngine.Engine;

namespace UnrealEngine.Plugins.AudioCapture;

public static class UAudioCaptureLibrary_CsExtensions
{
	public static void GetAvailableAudioInputDevices(this UWorld WorldContextObject, FOnAudioInputDevicesObtained OnObtainDevicesEvent)
	{
		UAudioCaptureLibrary.GetAvailableAudioInputDevices(WorldContextObject, OnObtainDevicesEvent);
	}
}
