using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.SubmixEffectSubmixEQSettings", "AudioMixer", UnrealModuleType.Engine)]
public struct FSubmixEffectSubmixEQSettings
{
	private static bool EQBands_IsValid;

	private static FFieldAddress EQBands_PropertyAddress;

	private static int EQBands_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectSubmixEQSettings:EQBands")]
	public List<FSubmixEffectEQBand> EQBands;

	private static bool FSubmixEffectSubmixEQSettings_IsValid;

	private static int FSubmixEffectSubmixEQSettings_StructSize;

	public FSubmixEffectSubmixEQSettings Copy()
	{
		FSubmixEffectSubmixEQSettings result = this;
		if (EQBands != null)
		{
			result.EQBands = new List<FSubmixEffectEQBand>(EQBands);
		}
		return result;
	}

	public static FSubmixEffectSubmixEQSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSubmixEffectSubmixEQSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubmixEffectSubmixEQSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubmixEffectSubmixEQSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubmixEffectSubmixEQSettings(nativeBuffer + arrayIndex * FSubmixEffectSubmixEQSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubmixEffectSubmixEQSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubmixEffectSubmixEQSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubmixEffectSubmixEQSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioMixer.SubmixEffectSubmixEQSettings");
		}
		else
		{
			new TArrayCopyMarshaler<FSubmixEffectEQBand>(1, EQBands_PropertyAddress, CachedMarshalingDelegates<FSubmixEffectEQBand, FSubmixEffectEQBand>.FromNative, CachedMarshalingDelegates<FSubmixEffectEQBand, FSubmixEffectEQBand>.ToNative).ToNative(IntPtr.Add(nativeStruct, EQBands_Offset), EQBands);
		}
	}

	public FSubmixEffectSubmixEQSettings(IntPtr nativeStruct)
	{
		if (!FSubmixEffectSubmixEQSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioMixer.SubmixEffectSubmixEQSettings");
			EQBands = null;
		}
		else
		{
			EQBands = new TArrayCopyMarshaler<FSubmixEffectEQBand>(1, EQBands_PropertyAddress, CachedMarshalingDelegates<FSubmixEffectEQBand, FSubmixEffectEQBand>.FromNative, CachedMarshalingDelegates<FSubmixEffectEQBand, FSubmixEffectEQBand>.ToNative).FromNative(IntPtr.Add(nativeStruct, EQBands_Offset));
		}
	}

	static FSubmixEffectSubmixEQSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubmixEffectSubmixEQSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubmixEffectSubmixEQSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AudioMixer.SubmixEffectSubmixEQSettings");
		FSubmixEffectSubmixEQSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref EQBands_PropertyAddress, intPtr, "EQBands");
		EQBands_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EQBands");
		EQBands_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EQBands", Classes.FArrayProperty);
		FSubmixEffectSubmixEQSettings_IsValid = intPtr != IntPtr.Zero && EQBands_IsValid;
		NativeReflection.LogStructIsValid("/Script/AudioMixer.SubmixEffectSubmixEQSettings", FSubmixEffectSubmixEQSettings_IsValid);
	}
}
