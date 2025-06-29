using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 32776)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.InterpCurveLinearColor", "CoreUObject", UnrealModuleType.Engine)]
public struct FInterpCurveLinearColor
{
	private static bool Points_IsValid;

	private static FFieldAddress Points_PropertyAddress;

	private static int Points_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveLinearColor:Points")]
	public List<FInterpCurvePointLinearColor> Points;

	private static bool IsLooped_IsValid;

	private static FFieldAddress IsLooped_PropertyAddress;

	private static int IsLooped_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveLinearColor:bIsLooped")]
	public bool IsLooped;

	private static bool LoopKeyOffset_IsValid;

	private static int LoopKeyOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveLinearColor:LoopKeyOffset")]
	public float LoopKeyOffset;

	private static bool FInterpCurveLinearColor_IsValid;

	private static int FInterpCurveLinearColor_StructSize;

	public FInterpCurveLinearColor Copy()
	{
		FInterpCurveLinearColor result = this;
		if (Points != null)
		{
			result.Points = new List<FInterpCurvePointLinearColor>(Points);
		}
		return result;
	}

	public static FInterpCurveLinearColor FromNative(IntPtr nativeBuffer)
	{
		return new FInterpCurveLinearColor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInterpCurveLinearColor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInterpCurveLinearColor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInterpCurveLinearColor(nativeBuffer + arrayIndex * FInterpCurveLinearColor_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInterpCurveLinearColor value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInterpCurveLinearColor_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInterpCurveLinearColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.InterpCurveLinearColor");
			return;
		}
		new TArrayCopyMarshaler<FInterpCurvePointLinearColor>(1, Points_PropertyAddress, CachedMarshalingDelegates<FInterpCurvePointLinearColor, BlittableTypeMarshaler<FInterpCurvePointLinearColor>>.FromNative, CachedMarshalingDelegates<FInterpCurvePointLinearColor, BlittableTypeMarshaler<FInterpCurvePointLinearColor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Points_Offset), Points);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsLooped_Offset), 0, IsLooped_PropertyAddress.Address, IsLooped);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LoopKeyOffset_Offset), LoopKeyOffset);
	}

	public FInterpCurveLinearColor(IntPtr nativeStruct)
	{
		if (!FInterpCurveLinearColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.InterpCurveLinearColor");
			Points = null;
			IsLooped = false;
			LoopKeyOffset = 0f;
		}
		else
		{
			Points = new TArrayCopyMarshaler<FInterpCurvePointLinearColor>(1, Points_PropertyAddress, CachedMarshalingDelegates<FInterpCurvePointLinearColor, BlittableTypeMarshaler<FInterpCurvePointLinearColor>>.FromNative, CachedMarshalingDelegates<FInterpCurvePointLinearColor, BlittableTypeMarshaler<FInterpCurvePointLinearColor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Points_Offset));
			IsLooped = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsLooped_Offset), 0, IsLooped_PropertyAddress.Address);
			LoopKeyOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LoopKeyOffset_Offset));
		}
	}

	static FInterpCurveLinearColor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInterpCurveLinearColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterpCurveLinearColor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.InterpCurveLinearColor");
		FInterpCurveLinearColor_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Points_PropertyAddress, intPtr, "Points");
		Points_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Points");
		Points_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Points", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLooped_PropertyAddress, intPtr, "bIsLooped");
		IsLooped_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsLooped");
		IsLooped_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsLooped", Classes.FBoolProperty);
		LoopKeyOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoopKeyOffset");
		LoopKeyOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoopKeyOffset", Classes.FFloatProperty);
		FInterpCurveLinearColor_IsValid = intPtr != IntPtr.Zero && Points_IsValid && IsLooped_IsValid && LoopKeyOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.InterpCurveLinearColor", FInterpCurveLinearColor_IsValid);
	}
}
