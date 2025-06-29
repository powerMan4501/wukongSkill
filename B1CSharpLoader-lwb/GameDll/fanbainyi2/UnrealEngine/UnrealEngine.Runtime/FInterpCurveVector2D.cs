using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 32776)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.InterpCurveVector2D", "CoreUObject", UnrealModuleType.Engine)]
public struct FInterpCurveVector2D
{
	private static bool Points_IsValid;

	private static FFieldAddress Points_PropertyAddress;

	private static int Points_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveVector2D:Points")]
	public List<FInterpCurvePointVector2D> Points;

	private static bool IsLooped_IsValid;

	private static FFieldAddress IsLooped_PropertyAddress;

	private static int IsLooped_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveVector2D:bIsLooped")]
	public bool IsLooped;

	private static bool LoopKeyOffset_IsValid;

	private static int LoopKeyOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveVector2D:LoopKeyOffset")]
	public float LoopKeyOffset;

	private static bool FInterpCurveVector2D_IsValid;

	private static int FInterpCurveVector2D_StructSize;

	public FInterpCurveVector2D Copy()
	{
		FInterpCurveVector2D result = this;
		if (Points != null)
		{
			result.Points = new List<FInterpCurvePointVector2D>(Points);
		}
		return result;
	}

	public static FInterpCurveVector2D FromNative(IntPtr nativeBuffer)
	{
		return new FInterpCurveVector2D(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInterpCurveVector2D value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInterpCurveVector2D FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInterpCurveVector2D(nativeBuffer + arrayIndex * FInterpCurveVector2D_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInterpCurveVector2D value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInterpCurveVector2D_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInterpCurveVector2D_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.InterpCurveVector2D");
			return;
		}
		new TArrayCopyMarshaler<FInterpCurvePointVector2D>(1, Points_PropertyAddress, CachedMarshalingDelegates<FInterpCurvePointVector2D, BlittableTypeMarshaler<FInterpCurvePointVector2D>>.FromNative, CachedMarshalingDelegates<FInterpCurvePointVector2D, BlittableTypeMarshaler<FInterpCurvePointVector2D>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Points_Offset), Points);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsLooped_Offset), 0, IsLooped_PropertyAddress.Address, IsLooped);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LoopKeyOffset_Offset), LoopKeyOffset);
	}

	public FInterpCurveVector2D(IntPtr nativeStruct)
	{
		if (!FInterpCurveVector2D_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.InterpCurveVector2D");
			Points = null;
			IsLooped = false;
			LoopKeyOffset = 0f;
		}
		else
		{
			Points = new TArrayCopyMarshaler<FInterpCurvePointVector2D>(1, Points_PropertyAddress, CachedMarshalingDelegates<FInterpCurvePointVector2D, BlittableTypeMarshaler<FInterpCurvePointVector2D>>.FromNative, CachedMarshalingDelegates<FInterpCurvePointVector2D, BlittableTypeMarshaler<FInterpCurvePointVector2D>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Points_Offset));
			IsLooped = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsLooped_Offset), 0, IsLooped_PropertyAddress.Address);
			LoopKeyOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LoopKeyOffset_Offset));
		}
	}

	static FInterpCurveVector2D()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInterpCurveVector2D)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterpCurveVector2D));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.InterpCurveVector2D");
		FInterpCurveVector2D_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Points_PropertyAddress, intPtr, "Points");
		Points_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Points");
		Points_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Points", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLooped_PropertyAddress, intPtr, "bIsLooped");
		IsLooped_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsLooped");
		IsLooped_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsLooped", Classes.FBoolProperty);
		LoopKeyOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoopKeyOffset");
		LoopKeyOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoopKeyOffset", Classes.FFloatProperty);
		FInterpCurveVector2D_IsValid = intPtr != IntPtr.Zero && Points_IsValid && IsLooped_IsValid && LoopKeyOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.InterpCurveVector2D", FInterpCurveVector2D_IsValid);
	}
}
