using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AudioVolumeSubmixSendSettings", "Engine", UnrealModuleType.Engine)]
public struct FAudioVolumeSubmixSendSettings
{
	private static bool ListenerLocationState_IsValid;

	private static FFieldAddress ListenerLocationState_PropertyAddress;

	private static int ListenerLocationState_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioVolumeSubmixSendSettings:ListenerLocationState")]
	public EAudioVolumeLocationState ListenerLocationState;

	private static bool SubmixSends_IsValid;

	private static FFieldAddress SubmixSends_PropertyAddress;

	private static int SubmixSends_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.AudioVolumeSubmixSendSettings:SubmixSends")]
	public List<FSoundSubmixSendInfo> SubmixSends;

	private static bool FAudioVolumeSubmixSendSettings_IsValid;

	private static int FAudioVolumeSubmixSendSettings_StructSize;

	public FAudioVolumeSubmixSendSettings Copy()
	{
		FAudioVolumeSubmixSendSettings result = this;
		if (SubmixSends != null)
		{
			result.SubmixSends = new List<FSoundSubmixSendInfo>(SubmixSends);
		}
		return result;
	}

	public static FAudioVolumeSubmixSendSettings FromNative(IntPtr nativeBuffer)
	{
		return new FAudioVolumeSubmixSendSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAudioVolumeSubmixSendSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAudioVolumeSubmixSendSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAudioVolumeSubmixSendSettings(nativeBuffer + arrayIndex * FAudioVolumeSubmixSendSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAudioVolumeSubmixSendSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAudioVolumeSubmixSendSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAudioVolumeSubmixSendSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AudioVolumeSubmixSendSettings");
			return;
		}
		EnumMarshaler<EAudioVolumeLocationState>.ToNative(IntPtr.Add(nativeStruct, ListenerLocationState_Offset), 0, ListenerLocationState_PropertyAddress.Address, ListenerLocationState);
		new TArrayCopyMarshaler<FSoundSubmixSendInfo>(1, SubmixSends_PropertyAddress, CachedMarshalingDelegates<FSoundSubmixSendInfo, FSoundSubmixSendInfo>.FromNative, CachedMarshalingDelegates<FSoundSubmixSendInfo, FSoundSubmixSendInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, SubmixSends_Offset), SubmixSends);
	}

	public FAudioVolumeSubmixSendSettings(IntPtr nativeStruct)
	{
		if (!FAudioVolumeSubmixSendSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AudioVolumeSubmixSendSettings");
			ListenerLocationState = EAudioVolumeLocationState.InsideTheVolume;
			SubmixSends = null;
		}
		else
		{
			ListenerLocationState = EnumMarshaler<EAudioVolumeLocationState>.FromNative(IntPtr.Add(nativeStruct, ListenerLocationState_Offset), 0, ListenerLocationState_PropertyAddress.Address);
			SubmixSends = new TArrayCopyMarshaler<FSoundSubmixSendInfo>(1, SubmixSends_PropertyAddress, CachedMarshalingDelegates<FSoundSubmixSendInfo, FSoundSubmixSendInfo>.FromNative, CachedMarshalingDelegates<FSoundSubmixSendInfo, FSoundSubmixSendInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, SubmixSends_Offset));
		}
	}

	static FAudioVolumeSubmixSendSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAudioVolumeSubmixSendSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAudioVolumeSubmixSendSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AudioVolumeSubmixSendSettings");
		FAudioVolumeSubmixSendSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ListenerLocationState_PropertyAddress, intPtr, "ListenerLocationState");
		ListenerLocationState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ListenerLocationState");
		ListenerLocationState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ListenerLocationState", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SubmixSends_PropertyAddress, intPtr, "SubmixSends");
		SubmixSends_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubmixSends");
		SubmixSends_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubmixSends", Classes.FArrayProperty);
		FAudioVolumeSubmixSendSettings_IsValid = intPtr != IntPtr.Zero && ListenerLocationState_IsValid && SubmixSends_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AudioVolumeSubmixSendSettings", FAudioVolumeSubmixSendSettings_IsValid);
	}
}
