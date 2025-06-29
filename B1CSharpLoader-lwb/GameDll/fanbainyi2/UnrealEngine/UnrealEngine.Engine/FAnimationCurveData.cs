using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimationCurveData", "Engine", UnrealModuleType.Engine)]
public struct FAnimationCurveData
{
	private static bool FloatCurves_IsValid;

	private static FFieldAddress FloatCurves_PropertyAddress;

	private static int FloatCurves_Offset;

	[UProperty(Flags = (PropFlags)4503599627502101uL)]
	[UMetaPath("/Script/Engine.AnimationCurveData:FloatCurves")]
	public List<FFloatCurve> FloatCurves;

	private static bool TransformCurves_IsValid;

	private static FFieldAddress TransformCurves_PropertyAddress;

	private static int TransformCurves_Offset;

	[UProperty(Flags = (PropFlags)4503599627502101uL)]
	[UMetaPath("/Script/Engine.AnimationCurveData:TransformCurves")]
	public List<FTransformCurve> TransformCurves;

	private static bool FAnimationCurveData_IsValid;

	private static int FAnimationCurveData_StructSize;

	public FAnimationCurveData Copy()
	{
		FAnimationCurveData result = this;
		if (FloatCurves != null)
		{
			result.FloatCurves = new List<FFloatCurve>(FloatCurves);
		}
		if (TransformCurves != null)
		{
			result.TransformCurves = new List<FTransformCurve>(TransformCurves);
		}
		return result;
	}

	public static FAnimationCurveData FromNative(IntPtr nativeBuffer)
	{
		return new FAnimationCurveData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimationCurveData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimationCurveData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimationCurveData(nativeBuffer + arrayIndex * FAnimationCurveData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimationCurveData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimationCurveData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimationCurveData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimationCurveData");
			return;
		}
		new TArrayCopyMarshaler<FFloatCurve>(1, FloatCurves_PropertyAddress, CachedMarshalingDelegates<FFloatCurve, FFloatCurve>.FromNative, CachedMarshalingDelegates<FFloatCurve, FFloatCurve>.ToNative).ToNative(IntPtr.Add(nativeStruct, FloatCurves_Offset), FloatCurves);
		new TArrayCopyMarshaler<FTransformCurve>(1, TransformCurves_PropertyAddress, CachedMarshalingDelegates<FTransformCurve, FTransformCurve>.FromNative, CachedMarshalingDelegates<FTransformCurve, FTransformCurve>.ToNative).ToNative(IntPtr.Add(nativeStruct, TransformCurves_Offset), TransformCurves);
	}

	public FAnimationCurveData(IntPtr nativeStruct)
	{
		if (!FAnimationCurveData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimationCurveData");
			FloatCurves = null;
			TransformCurves = null;
		}
		else
		{
			FloatCurves = new TArrayCopyMarshaler<FFloatCurve>(1, FloatCurves_PropertyAddress, CachedMarshalingDelegates<FFloatCurve, FFloatCurve>.FromNative, CachedMarshalingDelegates<FFloatCurve, FFloatCurve>.ToNative).FromNative(IntPtr.Add(nativeStruct, FloatCurves_Offset));
			TransformCurves = new TArrayCopyMarshaler<FTransformCurve>(1, TransformCurves_PropertyAddress, CachedMarshalingDelegates<FTransformCurve, FTransformCurve>.FromNative, CachedMarshalingDelegates<FTransformCurve, FTransformCurve>.ToNative).FromNative(IntPtr.Add(nativeStruct, TransformCurves_Offset));
		}
	}

	static FAnimationCurveData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimationCurveData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimationCurveData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimationCurveData");
		FAnimationCurveData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FloatCurves_PropertyAddress, intPtr, "FloatCurves");
		FloatCurves_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloatCurves");
		FloatCurves_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloatCurves", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformCurves_PropertyAddress, intPtr, "TransformCurves");
		TransformCurves_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransformCurves");
		TransformCurves_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransformCurves", Classes.FArrayProperty);
		FAnimationCurveData_IsValid = intPtr != IntPtr.Zero && FloatCurves_IsValid && TransformCurves_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimationCurveData", FAnimationCurveData_IsValid);
	}
}
