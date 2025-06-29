using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SubmixEffectTapDelaySettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSubmixEffectTapDelaySettings
{
	private static bool MaximumDelayLength_IsValid;

	private static int MaximumDelayLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectTapDelaySettings:MaximumDelayLength")]
	public float MaximumDelayLength;

	private static bool InterpolationTime_IsValid;

	private static int InterpolationTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectTapDelaySettings:InterpolationTime")]
	public float InterpolationTime;

	private static bool Taps_IsValid;

	private static FFieldAddress Taps_PropertyAddress;

	private static int Taps_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectTapDelaySettings:Taps")]
	public List<FTapDelayInfo> Taps;

	private static bool FSubmixEffectTapDelaySettings_IsValid;

	private static int FSubmixEffectTapDelaySettings_StructSize;

	public FSubmixEffectTapDelaySettings Copy()
	{
		FSubmixEffectTapDelaySettings result = this;
		if (Taps != null)
		{
			result.Taps = new List<FTapDelayInfo>(Taps);
		}
		return result;
	}

	public static FSubmixEffectTapDelaySettings FromNative(IntPtr nativeBuffer)
	{
		return new FSubmixEffectTapDelaySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubmixEffectTapDelaySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubmixEffectTapDelaySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubmixEffectTapDelaySettings(nativeBuffer + arrayIndex * FSubmixEffectTapDelaySettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubmixEffectTapDelaySettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubmixEffectTapDelaySettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubmixEffectTapDelaySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SubmixEffectTapDelaySettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaximumDelayLength_Offset), MaximumDelayLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InterpolationTime_Offset), InterpolationTime);
		new TArrayCopyMarshaler<FTapDelayInfo>(1, Taps_PropertyAddress, CachedMarshalingDelegates<FTapDelayInfo, FTapDelayInfo>.FromNative, CachedMarshalingDelegates<FTapDelayInfo, FTapDelayInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, Taps_Offset), Taps);
	}

	public FSubmixEffectTapDelaySettings(IntPtr nativeStruct)
	{
		if (!FSubmixEffectTapDelaySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SubmixEffectTapDelaySettings");
			MaximumDelayLength = 0f;
			InterpolationTime = 0f;
			Taps = null;
		}
		else
		{
			MaximumDelayLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaximumDelayLength_Offset));
			InterpolationTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InterpolationTime_Offset));
			Taps = new TArrayCopyMarshaler<FTapDelayInfo>(1, Taps_PropertyAddress, CachedMarshalingDelegates<FTapDelayInfo, FTapDelayInfo>.FromNative, CachedMarshalingDelegates<FTapDelayInfo, FTapDelayInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, Taps_Offset));
		}
	}

	static FSubmixEffectTapDelaySettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubmixEffectTapDelaySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubmixEffectTapDelaySettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SubmixEffectTapDelaySettings");
		FSubmixEffectTapDelaySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		MaximumDelayLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaximumDelayLength");
		MaximumDelayLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaximumDelayLength", Classes.FFloatProperty);
		InterpolationTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpolationTime");
		InterpolationTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpolationTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Taps_PropertyAddress, intPtr, "Taps");
		Taps_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Taps");
		Taps_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Taps", Classes.FArrayProperty);
		FSubmixEffectTapDelaySettings_IsValid = intPtr != IntPtr.Zero && MaximumDelayLength_IsValid && InterpolationTime_IsValid && Taps_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SubmixEffectTapDelaySettings", FSubmixEffectTapDelaySettings_IsValid);
	}
}
