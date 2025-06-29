using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.TrajectorySampleRange", "Engine", UnrealModuleType.Engine)]
public struct FTrajectorySampleRange
{
	private static bool Samples_IsValid;

	private static FFieldAddress Samples_PropertyAddress;

	private static int Samples_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.TrajectorySampleRange:Samples")]
	public List<FTrajectorySample> Samples;

	private static bool SampleRate_IsValid;

	private static int SampleRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.TrajectorySampleRange:SampleRate")]
	public int SampleRate;

	private static bool FTrajectorySampleRange_IsValid;

	private static int FTrajectorySampleRange_StructSize;

	public FTrajectorySampleRange Copy()
	{
		FTrajectorySampleRange result = this;
		if (Samples != null)
		{
			result.Samples = new List<FTrajectorySample>(Samples);
		}
		return result;
	}

	public static FTrajectorySampleRange FromNative(IntPtr nativeBuffer)
	{
		return new FTrajectorySampleRange(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTrajectorySampleRange value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTrajectorySampleRange FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTrajectorySampleRange(nativeBuffer + arrayIndex * FTrajectorySampleRange_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTrajectorySampleRange value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTrajectorySampleRange_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTrajectorySampleRange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TrajectorySampleRange");
			return;
		}
		new TArrayCopyMarshaler<FTrajectorySample>(1, Samples_PropertyAddress, CachedMarshalingDelegates<FTrajectorySample, FTrajectorySample>.FromNative, CachedMarshalingDelegates<FTrajectorySample, FTrajectorySample>.ToNative).ToNative(IntPtr.Add(nativeStruct, Samples_Offset), Samples);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SampleRate_Offset), SampleRate);
	}

	public FTrajectorySampleRange(IntPtr nativeStruct)
	{
		if (!FTrajectorySampleRange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TrajectorySampleRange");
			Samples = null;
			SampleRate = 0;
		}
		else
		{
			Samples = new TArrayCopyMarshaler<FTrajectorySample>(1, Samples_PropertyAddress, CachedMarshalingDelegates<FTrajectorySample, FTrajectorySample>.FromNative, CachedMarshalingDelegates<FTrajectorySample, FTrajectorySample>.ToNative).FromNative(IntPtr.Add(nativeStruct, Samples_Offset));
			SampleRate = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SampleRate_Offset));
		}
	}

	static FTrajectorySampleRange()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTrajectorySampleRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTrajectorySampleRange));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.TrajectorySampleRange");
		FTrajectorySampleRange_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Samples_PropertyAddress, intPtr, "Samples");
		Samples_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Samples");
		Samples_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Samples", Classes.FArrayProperty);
		SampleRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SampleRate");
		SampleRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SampleRate", Classes.FIntProperty);
		FTrajectorySampleRange_IsValid = intPtr != IntPtr.Zero && Samples_IsValid && SampleRate_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.TrajectorySampleRange", FTrajectorySampleRange_IsValid);
	}
}
