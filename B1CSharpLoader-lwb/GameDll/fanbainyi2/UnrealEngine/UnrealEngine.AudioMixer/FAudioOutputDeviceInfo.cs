using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.AudioOutputDeviceInfo", "AudioMixer", UnrealModuleType.Engine)]
public struct FAudioOutputDeviceInfo
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/AudioMixer.AudioOutputDeviceInfo:Name")]
	public string Name;

	private static bool DeviceId_IsValid;

	private static int DeviceId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/AudioMixer.AudioOutputDeviceInfo:DeviceId")]
	public string DeviceId;

	private static bool NumChannels_IsValid;

	private static int NumChannels_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/AudioMixer.AudioOutputDeviceInfo:NumChannels")]
	public int NumChannels;

	private static bool SampleRate_IsValid;

	private static int SampleRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/AudioMixer.AudioOutputDeviceInfo:SampleRate")]
	public int SampleRate;

	private static bool Format_IsValid;

	private static FFieldAddress Format_PropertyAddress;

	private static int Format_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/AudioMixer.AudioOutputDeviceInfo:Format")]
	public EAudioMixerStreamDataFormatType Format;

	private static bool OutputChannelArray_IsValid;

	private static FFieldAddress OutputChannelArray_PropertyAddress;

	private static int OutputChannelArray_Offset;

	[UProperty(Flags = (PropFlags)4503599627371028uL)]
	[UMetaPath("/Script/AudioMixer.AudioOutputDeviceInfo:OutputChannelArray")]
	public List<EAudioMixerChannelType> OutputChannelArray;

	private static bool IsSystemDefault_IsValid;

	private static FFieldAddress IsSystemDefault_PropertyAddress;

	private static int IsSystemDefault_Offset;

	[UProperty(Flags = (PropFlags)6755468160532500uL)]
	[UMetaPath("/Script/AudioMixer.AudioOutputDeviceInfo:bIsSystemDefault")]
	public bool IsSystemDefault;

	private static bool IsCurrentDevice_IsValid;

	private static FFieldAddress IsCurrentDevice_PropertyAddress;

	private static int IsCurrentDevice_Offset;

	[UProperty(Flags = (PropFlags)6755468160532500uL)]
	[UMetaPath("/Script/AudioMixer.AudioOutputDeviceInfo:bIsCurrentDevice")]
	public bool IsCurrentDevice;

	private static bool FAudioOutputDeviceInfo_IsValid;

	private static int FAudioOutputDeviceInfo_StructSize;

	public FAudioOutputDeviceInfo Copy()
	{
		FAudioOutputDeviceInfo result = this;
		if (OutputChannelArray != null)
		{
			result.OutputChannelArray = new List<EAudioMixerChannelType>(OutputChannelArray);
		}
		return result;
	}

	public static FAudioOutputDeviceInfo FromNative(IntPtr nativeBuffer)
	{
		return new FAudioOutputDeviceInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAudioOutputDeviceInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAudioOutputDeviceInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAudioOutputDeviceInfo(nativeBuffer + arrayIndex * FAudioOutputDeviceInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAudioOutputDeviceInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAudioOutputDeviceInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAudioOutputDeviceInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioMixer.AudioOutputDeviceInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DeviceId_Offset), DeviceId);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumChannels_Offset), NumChannels);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SampleRate_Offset), SampleRate);
		EnumMarshaler<EAudioMixerStreamDataFormatType>.ToNative(IntPtr.Add(nativeStruct, Format_Offset), 0, Format_PropertyAddress.Address, Format);
		new TArrayCopyMarshaler<EAudioMixerChannelType>(1, OutputChannelArray_PropertyAddress, CachedMarshalingDelegates<EAudioMixerChannelType, EnumMarshaler<EAudioMixerChannelType>>.FromNative, CachedMarshalingDelegates<EAudioMixerChannelType, EnumMarshaler<EAudioMixerChannelType>>.ToNative).ToNative(IntPtr.Add(nativeStruct, OutputChannelArray_Offset), OutputChannelArray);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsSystemDefault_Offset), 0, IsSystemDefault_PropertyAddress.Address, IsSystemDefault);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsCurrentDevice_Offset), 0, IsCurrentDevice_PropertyAddress.Address, IsCurrentDevice);
	}

	public FAudioOutputDeviceInfo(IntPtr nativeStruct)
	{
		if (!FAudioOutputDeviceInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioMixer.AudioOutputDeviceInfo");
			Name = FStringMarshaler.DefaultString;
			DeviceId = FStringMarshaler.DefaultString;
			NumChannels = 0;
			SampleRate = 0;
			Format = EAudioMixerStreamDataFormatType.Unknown;
			OutputChannelArray = null;
			IsSystemDefault = false;
			IsCurrentDevice = false;
		}
		else
		{
			Name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			DeviceId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DeviceId_Offset));
			NumChannels = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumChannels_Offset));
			SampleRate = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SampleRate_Offset));
			Format = EnumMarshaler<EAudioMixerStreamDataFormatType>.FromNative(IntPtr.Add(nativeStruct, Format_Offset), 0, Format_PropertyAddress.Address);
			OutputChannelArray = new TArrayCopyMarshaler<EAudioMixerChannelType>(1, OutputChannelArray_PropertyAddress, CachedMarshalingDelegates<EAudioMixerChannelType, EnumMarshaler<EAudioMixerChannelType>>.FromNative, CachedMarshalingDelegates<EAudioMixerChannelType, EnumMarshaler<EAudioMixerChannelType>>.ToNative).FromNative(IntPtr.Add(nativeStruct, OutputChannelArray_Offset));
			IsSystemDefault = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsSystemDefault_Offset), 0, IsSystemDefault_PropertyAddress.Address);
			IsCurrentDevice = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsCurrentDevice_Offset), 0, IsCurrentDevice_PropertyAddress.Address);
		}
	}

	static FAudioOutputDeviceInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAudioOutputDeviceInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAudioOutputDeviceInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AudioMixer.AudioOutputDeviceInfo");
		FAudioOutputDeviceInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FStrProperty);
		DeviceId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DeviceId");
		DeviceId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DeviceId", Classes.FStrProperty);
		NumChannels_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumChannels");
		NumChannels_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumChannels", Classes.FIntProperty);
		SampleRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SampleRate");
		SampleRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SampleRate", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Format_PropertyAddress, intPtr, "Format");
		Format_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Format");
		Format_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Format", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OutputChannelArray_PropertyAddress, intPtr, "OutputChannelArray");
		OutputChannelArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputChannelArray");
		OutputChannelArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputChannelArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSystemDefault_PropertyAddress, intPtr, "bIsSystemDefault");
		IsSystemDefault_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsSystemDefault");
		IsSystemDefault_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsSystemDefault", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCurrentDevice_PropertyAddress, intPtr, "bIsCurrentDevice");
		IsCurrentDevice_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsCurrentDevice");
		IsCurrentDevice_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsCurrentDevice", Classes.FBoolProperty);
		FAudioOutputDeviceInfo_IsValid = intPtr != IntPtr.Zero && Name_IsValid && DeviceId_IsValid && NumChannels_IsValid && SampleRate_IsValid && Format_IsValid && OutputChannelArray_IsValid && IsSystemDefault_IsValid && IsCurrentDevice_IsValid;
		NativeReflection.LogStructIsValid("/Script/AudioMixer.AudioOutputDeviceInfo", FAudioOutputDeviceInfo_IsValid);
	}
}
