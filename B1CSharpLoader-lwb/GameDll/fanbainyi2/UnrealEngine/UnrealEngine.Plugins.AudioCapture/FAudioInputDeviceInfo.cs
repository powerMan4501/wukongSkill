using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioCapture;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AudioCapture.AudioInputDeviceInfo", "AudioCapture", UnrealModuleType.EnginePlugin)]
public struct FAudioInputDeviceInfo
{
	private static bool DeviceName_IsValid;

	private static int DeviceName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/AudioCapture.AudioInputDeviceInfo:DeviceName")]
	public string DeviceName;

	private static bool DeviceId_IsValid;

	private static int DeviceId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/AudioCapture.AudioInputDeviceInfo:DeviceId")]
	public string DeviceId;

	private static bool InputChannels_IsValid;

	private static int InputChannels_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/AudioCapture.AudioInputDeviceInfo:InputChannels")]
	public int InputChannels;

	private static bool PreferredSampleRate_IsValid;

	private static int PreferredSampleRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/AudioCapture.AudioInputDeviceInfo:PreferredSampleRate")]
	public int PreferredSampleRate;

	private static bool SupportsHardwareAEC_IsValid;

	private static FFieldAddress SupportsHardwareAEC_PropertyAddress;

	private static int SupportsHardwareAEC_Offset;

	[UProperty(Flags = (PropFlags)6755468160532500uL)]
	[UMetaPath("/Script/AudioCapture.AudioInputDeviceInfo:bSupportsHardwareAEC")]
	public bool SupportsHardwareAEC;

	private static bool FAudioInputDeviceInfo_IsValid;

	private static int FAudioInputDeviceInfo_StructSize;

	public FAudioInputDeviceInfo Copy()
	{
		return this;
	}

	public static FAudioInputDeviceInfo FromNative(IntPtr nativeBuffer)
	{
		return new FAudioInputDeviceInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAudioInputDeviceInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAudioInputDeviceInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAudioInputDeviceInfo(nativeBuffer + arrayIndex * FAudioInputDeviceInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAudioInputDeviceInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAudioInputDeviceInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAudioInputDeviceInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioCapture.AudioInputDeviceInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DeviceName_Offset), DeviceName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DeviceId_Offset), DeviceId);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InputChannels_Offset), InputChannels);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PreferredSampleRate_Offset), PreferredSampleRate);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SupportsHardwareAEC_Offset), 0, SupportsHardwareAEC_PropertyAddress.Address, SupportsHardwareAEC);
	}

	public FAudioInputDeviceInfo(IntPtr nativeStruct)
	{
		if (!FAudioInputDeviceInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioCapture.AudioInputDeviceInfo");
			DeviceName = FStringMarshaler.DefaultString;
			DeviceId = FStringMarshaler.DefaultString;
			InputChannels = 0;
			PreferredSampleRate = 0;
			SupportsHardwareAEC = false;
		}
		else
		{
			DeviceName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DeviceName_Offset));
			DeviceId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DeviceId_Offset));
			InputChannels = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InputChannels_Offset));
			PreferredSampleRate = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PreferredSampleRate_Offset));
			SupportsHardwareAEC = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SupportsHardwareAEC_Offset), 0, SupportsHardwareAEC_PropertyAddress.Address);
		}
	}

	static FAudioInputDeviceInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAudioInputDeviceInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAudioInputDeviceInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AudioCapture.AudioInputDeviceInfo");
		FAudioInputDeviceInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		DeviceName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DeviceName");
		DeviceName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DeviceName", Classes.FStrProperty);
		DeviceId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DeviceId");
		DeviceId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DeviceId", Classes.FStrProperty);
		InputChannels_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputChannels");
		InputChannels_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputChannels", Classes.FIntProperty);
		PreferredSampleRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreferredSampleRate");
		PreferredSampleRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreferredSampleRate", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SupportsHardwareAEC_PropertyAddress, intPtr, "bSupportsHardwareAEC");
		SupportsHardwareAEC_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSupportsHardwareAEC");
		SupportsHardwareAEC_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSupportsHardwareAEC", Classes.FBoolProperty);
		FAudioInputDeviceInfo_IsValid = intPtr != IntPtr.Zero && DeviceName_IsValid && DeviceId_IsValid && InputChannels_IsValid && PreferredSampleRate_IsValid && SupportsHardwareAEC_IsValid;
		NativeReflection.LogStructIsValid("/Script/AudioCapture.AudioInputDeviceInfo", FAudioInputDeviceInfo_IsValid);
	}
}
