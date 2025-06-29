using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 32776)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.InterpCurveFloat", "CoreUObject", UnrealModuleType.Engine)]
public struct FInterpCurveFloat
{
	private static bool Points_IsValid;

	private static FFieldAddress Points_PropertyAddress;

	private static int Points_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveFloat:Points")]
	public List<FInterpCurvePointFloat> Points;

	private static bool IsLooped_IsValid;

	private static FFieldAddress IsLooped_PropertyAddress;

	private static int IsLooped_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveFloat:bIsLooped")]
	public bool IsLooped;

	private static bool LoopKeyOffset_IsValid;

	private static int LoopKeyOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveFloat:LoopKeyOffset")]
	public float LoopKeyOffset;

	private static bool FInterpCurveFloat_IsValid;

	private static int FInterpCurveFloat_StructSize;

	public FInterpCurveFloat Copy()
	{
		FInterpCurveFloat result = this;
		if (Points != null)
		{
			result.Points = new List<FInterpCurvePointFloat>(Points);
		}
		return result;
	}

	public static FInterpCurveFloat FromNative(IntPtr nativeBuffer)
	{
		return new FInterpCurveFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInterpCurveFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInterpCurveFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInterpCurveFloat(nativeBuffer + arrayIndex * FInterpCurveFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInterpCurveFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInterpCurveFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInterpCurveFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.InterpCurveFloat");
			return;
		}
		new TArrayCopyMarshaler<FInterpCurvePointFloat>(1, Points_PropertyAddress, CachedMarshalingDelegates<FInterpCurvePointFloat, BlittableTypeMarshaler<FInterpCurvePointFloat>>.FromNative, CachedMarshalingDelegates<FInterpCurvePointFloat, BlittableTypeMarshaler<FInterpCurvePointFloat>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Points_Offset), Points);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsLooped_Offset), 0, IsLooped_PropertyAddress.Address, IsLooped);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LoopKeyOffset_Offset), LoopKeyOffset);
	}

	public FInterpCurveFloat(IntPtr nativeStruct)
	{
		if (!FInterpCurveFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.InterpCurveFloat");
			Points = null;
			IsLooped = false;
			LoopKeyOffset = 0f;
		}
		else
		{
			Points = new TArrayCopyMarshaler<FInterpCurvePointFloat>(1, Points_PropertyAddress, CachedMarshalingDelegates<FInterpCurvePointFloat, BlittableTypeMarshaler<FInterpCurvePointFloat>>.FromNative, CachedMarshalingDelegates<FInterpCurvePointFloat, BlittableTypeMarshaler<FInterpCurvePointFloat>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Points_Offset));
			IsLooped = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsLooped_Offset), 0, IsLooped_PropertyAddress.Address);
			LoopKeyOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LoopKeyOffset_Offset));
		}
	}

	static FInterpCurveFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInterpCurveFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterpCurveFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.InterpCurveFloat");
		FInterpCurveFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Points_PropertyAddress, intPtr, "Points");
		Points_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Points");
		Points_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Points", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLooped_PropertyAddress, intPtr, "bIsLooped");
		IsLooped_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsLooped");
		IsLooped_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsLooped", Classes.FBoolProperty);
		LoopKeyOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoopKeyOffset");
		LoopKeyOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoopKeyOffset", Classes.FFloatProperty);
		FInterpCurveFloat_IsValid = intPtr != IntPtr.Zero && Points_IsValid && IsLooped_IsValid && LoopKeyOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.InterpCurveFloat", FInterpCurveFloat_IsValid);
	}
}
