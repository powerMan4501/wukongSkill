using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioCapture;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AudioCapture.AudioCaptureBlueprintLibrary", "AudioCapture", UnrealModuleType.EnginePlugin)]
public class UAudioCaptureLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetAvailableAudioInputDevices_IsValid;

	private static IntPtr GetAvailableAudioInputDevices_FunctionAddress;

	private static int GetAvailableAudioInputDevices_ParamsSize;

	private static bool GetAvailableAudioInputDevices_WorldContextObject_IsValid;

	private static FFieldAddress GetAvailableAudioInputDevices_WorldContextObject_PropertyAddress;

	private static int GetAvailableAudioInputDevices_WorldContextObject_Offset;

	private static bool GetAvailableAudioInputDevices_OnObtainDevicesEvent_IsValid;

	private static FFieldAddress GetAvailableAudioInputDevices_OnObtainDevicesEvent_PropertyAddress;

	private static int GetAvailableAudioInputDevices_OnObtainDevicesEvent_Offset;

	private static bool Conv_AudioInputDeviceInfoToString_IsValid;

	private static IntPtr Conv_AudioInputDeviceInfoToString_FunctionAddress;

	private static int Conv_AudioInputDeviceInfoToString_ParamsSize;

	private static bool Conv_AudioInputDeviceInfoToString_info_IsValid;

	private static FFieldAddress Conv_AudioInputDeviceInfoToString_info_PropertyAddress;

	private static int Conv_AudioInputDeviceInfoToString_info_Offset;

	private static bool Conv_AudioInputDeviceInfoToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_AudioInputDeviceInfoToString_ReturnValue_PropertyAddress;

	private static int Conv_AudioInputDeviceInfoToString_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AudioCapture.AudioCaptureBlueprintLibrary:GetAvailableAudioInputDevices")]
	public unsafe static void GetAvailableAudioInputDevices(UObject WorldContextObject, FOnAudioInputDevicesObtained OnObtainDevicesEvent)
	{
		if (!GetAvailableAudioInputDevices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioCapture.AudioCaptureBlueprintLibrary:GetAvailableAudioInputDevices");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAvailableAudioInputDevices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAvailableAudioInputDevices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetAvailableAudioInputDevices_WorldContextObject_Offset), 0, GetAvailableAudioInputDevices_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		FDelegateMarshaler<FOnAudioInputDevicesObtained>.ToNative(IntPtr.Add(intPtr, GetAvailableAudioInputDevices_OnObtainDevicesEvent_Offset), 0, GetAvailableAudioInputDevices_OnObtainDevicesEvent_PropertyAddress.Address, OnObtainDevicesEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAvailableAudioInputDevices_FunctionAddress, intPtr, GetAvailableAudioInputDevices_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AudioCapture.AudioCaptureBlueprintLibrary:Conv_AudioInputDeviceInfoToString")]
	public unsafe static string Conv_AudioInputDeviceInfoToString(FAudioInputDeviceInfo info)
	{
		if (!Conv_AudioInputDeviceInfoToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioCapture.AudioCaptureBlueprintLibrary:Conv_AudioInputDeviceInfoToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_AudioInputDeviceInfoToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_AudioInputDeviceInfoToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_AudioInputDeviceInfoToString_info_PropertyAddress.Address, intPtr);
		FAudioInputDeviceInfo.ToNative(IntPtr.Add(intPtr, Conv_AudioInputDeviceInfoToString_info_Offset), 0, Conv_AudioInputDeviceInfoToString_info_PropertyAddress.Address, info);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_AudioInputDeviceInfoToString_FunctionAddress, intPtr, Conv_AudioInputDeviceInfoToString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_AudioInputDeviceInfoToString_info_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_AudioInputDeviceInfoToString_ReturnValue_Offset), 0, Conv_AudioInputDeviceInfoToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_AudioInputDeviceInfoToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UAudioCaptureLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAudioCaptureLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAudioCaptureLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AudioCapture.AudioCaptureBlueprintLibrary");
		GetAvailableAudioInputDevices_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAvailableAudioInputDevices");
		GetAvailableAudioInputDevices_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAvailableAudioInputDevices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAvailableAudioInputDevices_WorldContextObject_PropertyAddress, GetAvailableAudioInputDevices_FunctionAddress, "WorldContextObject");
		GetAvailableAudioInputDevices_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailableAudioInputDevices_FunctionAddress, "WorldContextObject");
		GetAvailableAudioInputDevices_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailableAudioInputDevices_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAvailableAudioInputDevices_OnObtainDevicesEvent_PropertyAddress, GetAvailableAudioInputDevices_FunctionAddress, "OnObtainDevicesEvent");
		GetAvailableAudioInputDevices_OnObtainDevicesEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailableAudioInputDevices_FunctionAddress, "OnObtainDevicesEvent");
		GetAvailableAudioInputDevices_OnObtainDevicesEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailableAudioInputDevices_FunctionAddress, "OnObtainDevicesEvent", Classes.FDelegateProperty);
		GetAvailableAudioInputDevices_IsValid = GetAvailableAudioInputDevices_FunctionAddress != IntPtr.Zero && GetAvailableAudioInputDevices_WorldContextObject_IsValid && GetAvailableAudioInputDevices_OnObtainDevicesEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioCapture.AudioCaptureBlueprintLibrary:GetAvailableAudioInputDevices", GetAvailableAudioInputDevices_IsValid);
		Conv_AudioInputDeviceInfoToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_AudioInputDeviceInfoToString");
		Conv_AudioInputDeviceInfoToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_AudioInputDeviceInfoToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_AudioInputDeviceInfoToString_info_PropertyAddress, Conv_AudioInputDeviceInfoToString_FunctionAddress, "info");
		Conv_AudioInputDeviceInfoToString_info_Offset = NativeReflectionCached.GetPropertyOffset(Conv_AudioInputDeviceInfoToString_FunctionAddress, "info");
		Conv_AudioInputDeviceInfoToString_info_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_AudioInputDeviceInfoToString_FunctionAddress, "info", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_AudioInputDeviceInfoToString_ReturnValue_PropertyAddress, Conv_AudioInputDeviceInfoToString_FunctionAddress, "ReturnValue");
		Conv_AudioInputDeviceInfoToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_AudioInputDeviceInfoToString_FunctionAddress, "ReturnValue");
		Conv_AudioInputDeviceInfoToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_AudioInputDeviceInfoToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_AudioInputDeviceInfoToString_IsValid = Conv_AudioInputDeviceInfoToString_FunctionAddress != IntPtr.Zero && Conv_AudioInputDeviceInfoToString_info_IsValid && Conv_AudioInputDeviceInfoToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioCapture.AudioCaptureBlueprintLibrary:Conv_AudioInputDeviceInfoToString", Conv_AudioInputDeviceInfoToString_IsValid);
	}
}
