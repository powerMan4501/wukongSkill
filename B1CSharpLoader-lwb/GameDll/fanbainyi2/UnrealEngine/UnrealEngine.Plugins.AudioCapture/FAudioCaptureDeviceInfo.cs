using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioCapture;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AudioCapture.AudioCaptureDeviceInfo", "AudioCapture", UnrealModuleType.EnginePlugin)]
public struct FAudioCaptureDeviceInfo
{
	private static bool DeviceName_IsValid;

	private static int DeviceName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioCapture.AudioCaptureDeviceInfo:DeviceName")]
	public FName DeviceName;

	private static bool NumInputChannels_IsValid;

	private static int NumInputChannels_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioCapture.AudioCaptureDeviceInfo:NumInputChannels")]
	public int NumInputChannels;

	private static bool SampleRate_IsValid;

	private static int SampleRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioCapture.AudioCaptureDeviceInfo:SampleRate")]
	public int SampleRate;

	private static bool FAudioCaptureDeviceInfo_IsValid;

	private static int FAudioCaptureDeviceInfo_StructSize;

	public FAudioCaptureDeviceInfo Copy()
	{
		return this;
	}

	public static FAudioCaptureDeviceInfo FromNative(IntPtr nativeBuffer)
	{
		return new FAudioCaptureDeviceInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAudioCaptureDeviceInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAudioCaptureDeviceInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAudioCaptureDeviceInfo(nativeBuffer + arrayIndex * FAudioCaptureDeviceInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAudioCaptureDeviceInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAudioCaptureDeviceInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAudioCaptureDeviceInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioCapture.AudioCaptureDeviceInfo");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, DeviceName_Offset), DeviceName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumInputChannels_Offset), NumInputChannels);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SampleRate_Offset), SampleRate);
	}

	public FAudioCaptureDeviceInfo(IntPtr nativeStruct)
	{
		if (!FAudioCaptureDeviceInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioCapture.AudioCaptureDeviceInfo");
			DeviceName = default(FName);
			NumInputChannels = 0;
			SampleRate = 0;
		}
		else
		{
			DeviceName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, DeviceName_Offset));
			NumInputChannels = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumInputChannels_Offset));
			SampleRate = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SampleRate_Offset));
		}
	}

	static FAudioCaptureDeviceInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAudioCaptureDeviceInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAudioCaptureDeviceInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AudioCapture.AudioCaptureDeviceInfo");
		FAudioCaptureDeviceInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		DeviceName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DeviceName");
		DeviceName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DeviceName", Classes.FNameProperty);
		NumInputChannels_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumInputChannels");
		NumInputChannels_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumInputChannels", Classes.FIntProperty);
		SampleRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SampleRate");
		SampleRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SampleRate", Classes.FIntProperty);
		FAudioCaptureDeviceInfo_IsValid = intPtr != IntPtr.Zero && DeviceName_IsValid && NumInputChannels_IsValid && SampleRate_IsValid;
		NativeReflection.LogStructIsValid("/Script/AudioCapture.AudioCaptureDeviceInfo", FAudioCaptureDeviceInfo_IsValid);
	}
}
