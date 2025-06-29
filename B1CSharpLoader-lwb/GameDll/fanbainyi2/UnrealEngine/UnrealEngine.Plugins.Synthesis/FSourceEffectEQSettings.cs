using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectEQSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectEQSettings
{
	private static bool EQBands_IsValid;

	private static FFieldAddress EQBands_PropertyAddress;

	private static int EQBands_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectEQSettings:EQBands")]
	public List<FSourceEffectEQBand> EQBands;

	private static bool FSourceEffectEQSettings_IsValid;

	private static int FSourceEffectEQSettings_StructSize;

	public FSourceEffectEQSettings Copy()
	{
		FSourceEffectEQSettings result = this;
		if (EQBands != null)
		{
			result.EQBands = new List<FSourceEffectEQBand>(EQBands);
		}
		return result;
	}

	public static FSourceEffectEQSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectEQSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectEQSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectEQSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectEQSettings(nativeBuffer + arrayIndex * FSourceEffectEQSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectEQSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectEQSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectEQSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectEQSettings");
		}
		else
		{
			new TArrayCopyMarshaler<FSourceEffectEQBand>(1, EQBands_PropertyAddress, CachedMarshalingDelegates<FSourceEffectEQBand, FSourceEffectEQBand>.FromNative, CachedMarshalingDelegates<FSourceEffectEQBand, FSourceEffectEQBand>.ToNative).ToNative(IntPtr.Add(nativeStruct, EQBands_Offset), EQBands);
		}
	}

	public FSourceEffectEQSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectEQSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectEQSettings");
			EQBands = null;
		}
		else
		{
			EQBands = new TArrayCopyMarshaler<FSourceEffectEQBand>(1, EQBands_PropertyAddress, CachedMarshalingDelegates<FSourceEffectEQBand, FSourceEffectEQBand>.FromNative, CachedMarshalingDelegates<FSourceEffectEQBand, FSourceEffectEQBand>.ToNative).FromNative(IntPtr.Add(nativeStruct, EQBands_Offset));
		}
	}

	static FSourceEffectEQSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectEQSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectEQSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectEQSettings");
		FSourceEffectEQSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref EQBands_PropertyAddress, intPtr, "EQBands");
		EQBands_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EQBands");
		EQBands_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EQBands", Classes.FArrayProperty);
		FSourceEffectEQSettings_IsValid = intPtr != IntPtr.Zero && EQBands_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectEQSettings", FSourceEffectEQSettings_IsValid);
	}
}
