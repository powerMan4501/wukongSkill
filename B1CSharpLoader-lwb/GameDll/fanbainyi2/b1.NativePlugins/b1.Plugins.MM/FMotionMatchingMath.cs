using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MM.MotionMatchingMath", "MM", UnrealModuleType.GamePlugin)]
public struct FMotionMatchingMath
{
	private static bool SrcAnimIndex_IsValid;

	private static int SrcAnimIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/MM.MotionMatchingMath:SrcAnimIndex")]
	public int SrcAnimIndex;

	private static bool StartTime_IsValid;

	private static int StartTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/MM.MotionMatchingMath:StartTime")]
	public float StartTime;

	private static bool SequenceLength_IsValid;

	private static int SequenceLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/MM.MotionMatchingMath:SequenceLength")]
	public float SequenceLength;

	private static bool SerializedFeatures_IsValid;

	private static FFieldAddress SerializedFeatures_PropertyAddress;

	private static int SerializedFeatures_Offset;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/MM.MotionMatchingMath:SerializedFeatures")]
	public List<float> SerializedFeatures;

	private static bool FMotionMatchingMath_IsValid;

	private static int FMotionMatchingMath_StructSize;

	public FMotionMatchingMath Copy()
	{
		FMotionMatchingMath result = this;
		if (SerializedFeatures != null)
		{
			result.SerializedFeatures = new List<float>(SerializedFeatures);
		}
		return result;
	}

	public static FMotionMatchingMath FromNative(IntPtr nativeBuffer)
	{
		return new FMotionMatchingMath(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMotionMatchingMath value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMotionMatchingMath FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMotionMatchingMath(nativeBuffer + arrayIndex * FMotionMatchingMath_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMotionMatchingMath value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMotionMatchingMath_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMotionMatchingMath_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MotionMatchingMath");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SrcAnimIndex_Offset), SrcAnimIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StartTime_Offset), StartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SequenceLength_Offset), SequenceLength);
		new TArrayCopyMarshaler<float>(1, SerializedFeatures_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SerializedFeatures_Offset), SerializedFeatures);
	}

	public FMotionMatchingMath(IntPtr nativeStruct)
	{
		if (!FMotionMatchingMath_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MotionMatchingMath");
			SrcAnimIndex = 0;
			StartTime = 0f;
			SequenceLength = 0f;
			SerializedFeatures = null;
		}
		else
		{
			SrcAnimIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SrcAnimIndex_Offset));
			StartTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StartTime_Offset));
			SequenceLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SequenceLength_Offset));
			SerializedFeatures = new TArrayCopyMarshaler<float>(1, SerializedFeatures_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SerializedFeatures_Offset));
		}
	}

	static FMotionMatchingMath()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMotionMatchingMath)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMotionMatchingMath));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MM.MotionMatchingMath");
		FMotionMatchingMath_StructSize = NativeReflection.GetStructSize(intPtr);
		SrcAnimIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SrcAnimIndex");
		SrcAnimIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SrcAnimIndex", Classes.FIntProperty);
		StartTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StartTime");
		StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StartTime", Classes.FFloatProperty);
		SequenceLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SequenceLength");
		SequenceLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SequenceLength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SerializedFeatures_PropertyAddress, intPtr, "SerializedFeatures");
		SerializedFeatures_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SerializedFeatures");
		SerializedFeatures_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SerializedFeatures", Classes.FArrayProperty);
		FMotionMatchingMath_IsValid = intPtr != IntPtr.Zero && SrcAnimIndex_IsValid && StartTime_IsValid && SequenceLength_IsValid && SerializedFeatures_IsValid;
		NativeReflection.LogStructIsValid("/Script/MM.MotionMatchingMath", FMotionMatchingMath_IsValid);
	}
}
