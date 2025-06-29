using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.TimeManagement;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/TimeManagement.TimedDataInputEvaluationData", "TimeManagement", UnrealModuleType.Engine)]
public struct FTimedDataInputEvaluationData
{
	private static bool DistanceToNewestSampleSeconds_IsValid;

	private static int DistanceToNewestSampleSeconds_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/TimeManagement.TimedDataInputEvaluationData:DistanceToNewestSampleSeconds")]
	public float DistanceToNewestSampleSeconds;

	private static bool DistanceToOldestSampleSeconds_IsValid;

	private static int DistanceToOldestSampleSeconds_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/TimeManagement.TimedDataInputEvaluationData:DistanceToOldestSampleSeconds")]
	public float DistanceToOldestSampleSeconds;

	private static bool FTimedDataInputEvaluationData_IsValid;

	private static int FTimedDataInputEvaluationData_StructSize;

	public FTimedDataInputEvaluationData Copy()
	{
		return this;
	}

	public static FTimedDataInputEvaluationData FromNative(IntPtr nativeBuffer)
	{
		return new FTimedDataInputEvaluationData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTimedDataInputEvaluationData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTimedDataInputEvaluationData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTimedDataInputEvaluationData(nativeBuffer + arrayIndex * FTimedDataInputEvaluationData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTimedDataInputEvaluationData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTimedDataInputEvaluationData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTimedDataInputEvaluationData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TimeManagement.TimedDataInputEvaluationData");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DistanceToNewestSampleSeconds_Offset), DistanceToNewestSampleSeconds);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DistanceToOldestSampleSeconds_Offset), DistanceToOldestSampleSeconds);
	}

	public FTimedDataInputEvaluationData(IntPtr nativeStruct)
	{
		if (!FTimedDataInputEvaluationData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TimeManagement.TimedDataInputEvaluationData");
			DistanceToNewestSampleSeconds = 0f;
			DistanceToOldestSampleSeconds = 0f;
		}
		else
		{
			DistanceToNewestSampleSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DistanceToNewestSampleSeconds_Offset));
			DistanceToOldestSampleSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DistanceToOldestSampleSeconds_Offset));
		}
	}

	static FTimedDataInputEvaluationData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTimedDataInputEvaluationData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTimedDataInputEvaluationData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/TimeManagement.TimedDataInputEvaluationData");
		FTimedDataInputEvaluationData_StructSize = NativeReflection.GetStructSize(intPtr);
		DistanceToNewestSampleSeconds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceToNewestSampleSeconds");
		DistanceToNewestSampleSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceToNewestSampleSeconds", Classes.FFloatProperty);
		DistanceToOldestSampleSeconds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceToOldestSampleSeconds");
		DistanceToOldestSampleSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceToOldestSampleSeconds", Classes.FFloatProperty);
		FTimedDataInputEvaluationData_IsValid = intPtr != IntPtr.Zero && DistanceToNewestSampleSeconds_IsValid && DistanceToOldestSampleSeconds_IsValid;
		NativeReflection.LogStructIsValid("/Script/TimeManagement.TimedDataInputEvaluationData", FTimedDataInputEvaluationData_IsValid);
	}
}
