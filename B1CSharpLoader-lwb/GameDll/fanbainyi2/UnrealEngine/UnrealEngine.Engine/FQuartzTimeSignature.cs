using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.QuartzTimeSignature", "Engine", UnrealModuleType.Engine)]
public struct FQuartzTimeSignature
{
	private static bool NumBeats_IsValid;

	private static int NumBeats_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.QuartzTimeSignature:NumBeats")]
	public int NumBeats;

	private static bool BeatType_IsValid;

	private static FFieldAddress BeatType_PropertyAddress;

	private static int BeatType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.QuartzTimeSignature:BeatType")]
	public EQuartzTimeSignatureQuantization BeatType;

	private static bool OptionalPulseOverride_IsValid;

	private static FFieldAddress OptionalPulseOverride_PropertyAddress;

	private static int OptionalPulseOverride_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.QuartzTimeSignature:OptionalPulseOverride")]
	public List<FQuartzPulseOverrideStep> OptionalPulseOverride;

	private static bool FQuartzTimeSignature_IsValid;

	private static int FQuartzTimeSignature_StructSize;

	public FQuartzTimeSignature Copy()
	{
		FQuartzTimeSignature result = this;
		if (OptionalPulseOverride != null)
		{
			result.OptionalPulseOverride = new List<FQuartzPulseOverrideStep>(OptionalPulseOverride);
		}
		return result;
	}

	public static FQuartzTimeSignature FromNative(IntPtr nativeBuffer)
	{
		return new FQuartzTimeSignature(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FQuartzTimeSignature value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FQuartzTimeSignature FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FQuartzTimeSignature(nativeBuffer + arrayIndex * FQuartzTimeSignature_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FQuartzTimeSignature value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FQuartzTimeSignature_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FQuartzTimeSignature_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.QuartzTimeSignature");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumBeats_Offset), NumBeats);
		EnumMarshaler<EQuartzTimeSignatureQuantization>.ToNative(IntPtr.Add(nativeStruct, BeatType_Offset), 0, BeatType_PropertyAddress.Address, BeatType);
		new TArrayCopyMarshaler<FQuartzPulseOverrideStep>(1, OptionalPulseOverride_PropertyAddress, CachedMarshalingDelegates<FQuartzPulseOverrideStep, FQuartzPulseOverrideStep>.FromNative, CachedMarshalingDelegates<FQuartzPulseOverrideStep, FQuartzPulseOverrideStep>.ToNative).ToNative(IntPtr.Add(nativeStruct, OptionalPulseOverride_Offset), OptionalPulseOverride);
	}

	public FQuartzTimeSignature(IntPtr nativeStruct)
	{
		if (!FQuartzTimeSignature_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.QuartzTimeSignature");
			NumBeats = 0;
			BeatType = EQuartzTimeSignatureQuantization.HalfNote;
			OptionalPulseOverride = null;
		}
		else
		{
			NumBeats = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumBeats_Offset));
			BeatType = EnumMarshaler<EQuartzTimeSignatureQuantization>.FromNative(IntPtr.Add(nativeStruct, BeatType_Offset), 0, BeatType_PropertyAddress.Address);
			OptionalPulseOverride = new TArrayCopyMarshaler<FQuartzPulseOverrideStep>(1, OptionalPulseOverride_PropertyAddress, CachedMarshalingDelegates<FQuartzPulseOverrideStep, FQuartzPulseOverrideStep>.FromNative, CachedMarshalingDelegates<FQuartzPulseOverrideStep, FQuartzPulseOverrideStep>.ToNative).FromNative(IntPtr.Add(nativeStruct, OptionalPulseOverride_Offset));
		}
	}

	static FQuartzTimeSignature()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FQuartzTimeSignature)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FQuartzTimeSignature));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.QuartzTimeSignature");
		FQuartzTimeSignature_StructSize = NativeReflection.GetStructSize(intPtr);
		NumBeats_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumBeats");
		NumBeats_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumBeats", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BeatType_PropertyAddress, intPtr, "BeatType");
		BeatType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BeatType");
		BeatType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BeatType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OptionalPulseOverride_PropertyAddress, intPtr, "OptionalPulseOverride");
		OptionalPulseOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OptionalPulseOverride");
		OptionalPulseOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OptionalPulseOverride", Classes.FArrayProperty);
		FQuartzTimeSignature_IsValid = intPtr != IntPtr.Zero && NumBeats_IsValid && BeatType_IsValid && OptionalPulseOverride_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.QuartzTimeSignature", FQuartzTimeSignature_IsValid);
	}
}
