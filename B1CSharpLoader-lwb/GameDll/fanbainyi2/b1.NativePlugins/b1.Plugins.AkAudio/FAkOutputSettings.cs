using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkOutputSettings", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkOutputSettings
{
	private static bool AudioDeviceShareSetName_IsValid;

	private static int AudioDeviceShareSetName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/AkAudio.AkOutputSettings:AudioDeviceShareSetName")]
	public string AudioDeviceShareSetName;

	private static bool IdDevice_IsValid;

	private static int IdDevice_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkOutputSettings:IdDevice")]
	public int IdDevice;

	private static bool PanRule_IsValid;

	private static FFieldAddress PanRule_PropertyAddress;

	private static int PanRule_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkOutputSettings:PanRule")]
	public EPanningRule PanRule;

	private static bool ChannelConfig_IsValid;

	private static FFieldAddress ChannelConfig_PropertyAddress;

	private static int ChannelConfig_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkOutputSettings:ChannelConfig")]
	public EAkChannelConfiguration ChannelConfig;

	private static bool FAkOutputSettings_IsValid;

	private static int FAkOutputSettings_StructSize;

	public FAkOutputSettings Copy()
	{
		return this;
	}

	public static FAkOutputSettings FromNative(IntPtr nativeBuffer)
	{
		return new FAkOutputSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkOutputSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkOutputSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkOutputSettings(nativeBuffer + arrayIndex * FAkOutputSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkOutputSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkOutputSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkOutputSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkOutputSettings");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, AudioDeviceShareSetName_Offset), AudioDeviceShareSetName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IdDevice_Offset), IdDevice);
		EnumMarshaler<EPanningRule>.ToNative(IntPtr.Add(nativeStruct, PanRule_Offset), 0, PanRule_PropertyAddress.Address, PanRule);
		EnumMarshaler<EAkChannelConfiguration>.ToNative(IntPtr.Add(nativeStruct, ChannelConfig_Offset), 0, ChannelConfig_PropertyAddress.Address, ChannelConfig);
	}

	public FAkOutputSettings(IntPtr nativeStruct)
	{
		if (!FAkOutputSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkOutputSettings");
			AudioDeviceShareSetName = FStringMarshaler.DefaultString;
			IdDevice = 0;
			PanRule = EPanningRule.PanningRule_Speakers;
			ChannelConfig = EAkChannelConfiguration.Ak_Parent;
		}
		else
		{
			AudioDeviceShareSetName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, AudioDeviceShareSetName_Offset));
			IdDevice = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IdDevice_Offset));
			PanRule = EnumMarshaler<EPanningRule>.FromNative(IntPtr.Add(nativeStruct, PanRule_Offset), 0, PanRule_PropertyAddress.Address);
			ChannelConfig = EnumMarshaler<EAkChannelConfiguration>.FromNative(IntPtr.Add(nativeStruct, ChannelConfig_Offset), 0, ChannelConfig_PropertyAddress.Address);
		}
	}

	static FAkOutputSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkOutputSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkOutputSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkOutputSettings");
		FAkOutputSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		AudioDeviceShareSetName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AudioDeviceShareSetName");
		AudioDeviceShareSetName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AudioDeviceShareSetName", Classes.FStrProperty);
		IdDevice_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IdDevice");
		IdDevice_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IdDevice", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PanRule_PropertyAddress, intPtr, "PanRule");
		PanRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PanRule");
		PanRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PanRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ChannelConfig_PropertyAddress, intPtr, "ChannelConfig");
		ChannelConfig_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChannelConfig");
		ChannelConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChannelConfig", Classes.FEnumProperty);
		FAkOutputSettings_IsValid = intPtr != IntPtr.Zero && AudioDeviceShareSetName_IsValid && IdDevice_IsValid && PanRule_IsValid && ChannelConfig_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkOutputSettings", FAkOutputSettings_IsValid);
	}
}
