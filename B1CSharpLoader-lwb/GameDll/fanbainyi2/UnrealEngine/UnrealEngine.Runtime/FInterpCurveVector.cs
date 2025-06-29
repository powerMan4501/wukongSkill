using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 32776)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.InterpCurveVector", "CoreUObject", UnrealModuleType.Engine)]
public struct FInterpCurveVector
{
	private static bool Points_IsValid;

	private static FFieldAddress Points_PropertyAddress;

	private static int Points_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveVector:Points")]
	public List<FInterpCurvePointVector> Points;

	private static bool IsLooped_IsValid;

	private static FFieldAddress IsLooped_PropertyAddress;

	private static int IsLooped_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveVector:bIsLooped")]
	public bool IsLooped;

	private static bool LoopKeyOffset_IsValid;

	private static int LoopKeyOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveVector:LoopKeyOffset")]
	public float LoopKeyOffset;

	private static bool FInterpCurveVector_IsValid;

	private static int FInterpCurveVector_StructSize;

	public FInterpCurveVector Copy()
	{
		FInterpCurveVector result = this;
		if (Points != null)
		{
			result.Points = new List<FInterpCurvePointVector>(Points);
		}
		return result;
	}

	public static FInterpCurveVector FromNative(IntPtr nativeBuffer)
	{
		return new FInterpCurveVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInterpCurveVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInterpCurveVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInterpCurveVector(nativeBuffer + arrayIndex * FInterpCurveVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInterpCurveVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInterpCurveVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInterpCurveVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.InterpCurveVector");
			return;
		}
		new TArrayCopyMarshaler<FInterpCurvePointVector>(1, Points_PropertyAddress, CachedMarshalingDelegates<FInterpCurvePointVector, BlittableTypeMarshaler<FInterpCurvePointVector>>.FromNative, CachedMarshalingDelegates<FInterpCurvePointVector, BlittableTypeMarshaler<FInterpCurvePointVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Points_Offset), Points);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsLooped_Offset), 0, IsLooped_PropertyAddress.Address, IsLooped);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LoopKeyOffset_Offset), LoopKeyOffset);
	}

	public FInterpCurveVector(IntPtr nativeStruct)
	{
		if (!FInterpCurveVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.InterpCurveVector");
			Points = null;
			IsLooped = false;
			LoopKeyOffset = 0f;
		}
		else
		{
			Points = new TArrayCopyMarshaler<FInterpCurvePointVector>(1, Points_PropertyAddress, CachedMarshalingDelegates<FInterpCurvePointVector, BlittableTypeMarshaler<FInterpCurvePointVector>>.FromNative, CachedMarshalingDelegates<FInterpCurvePointVector, BlittableTypeMarshaler<FInterpCurvePointVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Points_Offset));
			IsLooped = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsLooped_Offset), 0, IsLooped_PropertyAddress.Address);
			LoopKeyOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LoopKeyOffset_Offset));
		}
	}

	static FInterpCurveVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInterpCurveVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterpCurveVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.InterpCurveVector");
		FInterpCurveVector_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Points_PropertyAddress, intPtr, "Points");
		Points_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Points");
		Points_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Points", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLooped_PropertyAddress, intPtr, "bIsLooped");
		IsLooped_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsLooped");
		IsLooped_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsLooped", Classes.FBoolProperty);
		LoopKeyOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoopKeyOffset");
		LoopKeyOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoopKeyOffset", Classes.FFloatProperty);
		FInterpCurveVector_IsValid = intPtr != IntPtr.Zero && Points_IsValid && IsLooped_IsValid && LoopKeyOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.InterpCurveVector", FInterpCurveVector_IsValid);
	}
}
