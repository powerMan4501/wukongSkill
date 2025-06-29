using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AudioVolumeSubmixOverrideSettings", "Engine", UnrealModuleType.Engine)]
public struct FAudioVolumeSubmixOverrideSettings
{
	private static bool Submix_IsValid;

	private static int Submix_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.AudioVolumeSubmixOverrideSettings:Submix")]
	public USoundSubmix Submix;

	private static bool SubmixEffectChain_IsValid;

	private static FFieldAddress SubmixEffectChain_PropertyAddress;

	private static int SubmixEffectChain_Offset;

	[UProperty(Flags = (PropFlags)5629499534213653uL)]
	[UMetaPath("/Script/Engine.AudioVolumeSubmixOverrideSettings:SubmixEffectChain")]
	public List<USoundEffectSubmixPreset> SubmixEffectChain;

	private static bool CrossfadeTime_IsValid;

	private static int CrossfadeTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.AudioVolumeSubmixOverrideSettings:CrossfadeTime")]
	public float CrossfadeTime;

	private static bool FAudioVolumeSubmixOverrideSettings_IsValid;

	private static int FAudioVolumeSubmixOverrideSettings_StructSize;

	public FAudioVolumeSubmixOverrideSettings Copy()
	{
		FAudioVolumeSubmixOverrideSettings result = this;
		if (SubmixEffectChain != null)
		{
			result.SubmixEffectChain = new List<USoundEffectSubmixPreset>(SubmixEffectChain);
		}
		return result;
	}

	public static FAudioVolumeSubmixOverrideSettings FromNative(IntPtr nativeBuffer)
	{
		return new FAudioVolumeSubmixOverrideSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAudioVolumeSubmixOverrideSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAudioVolumeSubmixOverrideSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAudioVolumeSubmixOverrideSettings(nativeBuffer + arrayIndex * FAudioVolumeSubmixOverrideSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAudioVolumeSubmixOverrideSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAudioVolumeSubmixOverrideSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAudioVolumeSubmixOverrideSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AudioVolumeSubmixOverrideSettings");
			return;
		}
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(nativeStruct, Submix_Offset), Submix);
		new TArrayCopyMarshaler<USoundEffectSubmixPreset>(1, SubmixEffectChain_PropertyAddress, CachedMarshalingDelegates<USoundEffectSubmixPreset, UObjectMarshaler<USoundEffectSubmixPreset>>.FromNative, CachedMarshalingDelegates<USoundEffectSubmixPreset, UObjectMarshaler<USoundEffectSubmixPreset>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SubmixEffectChain_Offset), SubmixEffectChain);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CrossfadeTime_Offset), CrossfadeTime);
	}

	public FAudioVolumeSubmixOverrideSettings(IntPtr nativeStruct)
	{
		if (!FAudioVolumeSubmixOverrideSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AudioVolumeSubmixOverrideSettings");
			Submix = null;
			SubmixEffectChain = null;
			CrossfadeTime = 0f;
		}
		else
		{
			Submix = UObjectMarshaler<USoundSubmix>.FromNative(IntPtr.Add(nativeStruct, Submix_Offset));
			SubmixEffectChain = new TArrayCopyMarshaler<USoundEffectSubmixPreset>(1, SubmixEffectChain_PropertyAddress, CachedMarshalingDelegates<USoundEffectSubmixPreset, UObjectMarshaler<USoundEffectSubmixPreset>>.FromNative, CachedMarshalingDelegates<USoundEffectSubmixPreset, UObjectMarshaler<USoundEffectSubmixPreset>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SubmixEffectChain_Offset));
			CrossfadeTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CrossfadeTime_Offset));
		}
	}

	static FAudioVolumeSubmixOverrideSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAudioVolumeSubmixOverrideSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAudioVolumeSubmixOverrideSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AudioVolumeSubmixOverrideSettings");
		FAudioVolumeSubmixOverrideSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Submix_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Submix");
		Submix_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Submix", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SubmixEffectChain_PropertyAddress, intPtr, "SubmixEffectChain");
		SubmixEffectChain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubmixEffectChain");
		SubmixEffectChain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubmixEffectChain", Classes.FArrayProperty);
		CrossfadeTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CrossfadeTime");
		CrossfadeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CrossfadeTime", Classes.FFloatProperty);
		FAudioVolumeSubmixOverrideSettings_IsValid = intPtr != IntPtr.Zero && Submix_IsValid && SubmixEffectChain_IsValid && CrossfadeTime_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AudioVolumeSubmixOverrideSettings", FAudioVolumeSubmixOverrideSettings_IsValid);
	}
}
