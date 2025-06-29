using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 32776)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.InterpCurveQuat", "CoreUObject", UnrealModuleType.Engine)]
public struct FInterpCurveQuat
{
	private static bool Points_IsValid;

	private static FFieldAddress Points_PropertyAddress;

	private static int Points_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveQuat:Points")]
	public List<FInterpCurvePointQuat> Points;

	private static bool IsLooped_IsValid;

	private static FFieldAddress IsLooped_PropertyAddress;

	private static int IsLooped_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveQuat:bIsLooped")]
	public bool IsLooped;

	private static bool LoopKeyOffset_IsValid;

	private static int LoopKeyOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveQuat:LoopKeyOffset")]
	public float LoopKeyOffset;

	private static bool FInterpCurveQuat_IsValid;

	private static int FInterpCurveQuat_StructSize;

	public FInterpCurveQuat Copy()
	{
		FInterpCurveQuat result = this;
		if (Points != null)
		{
			result.Points = new List<FInterpCurvePointQuat>(Points);
		}
		return result;
	}

	public static FInterpCurveQuat FromNative(IntPtr nativeBuffer)
	{
		return new FInterpCurveQuat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInterpCurveQuat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInterpCurveQuat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInterpCurveQuat(nativeBuffer + arrayIndex * FInterpCurveQuat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInterpCurveQuat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInterpCurveQuat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInterpCurveQuat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.InterpCurveQuat");
			return;
		}
		new TArrayCopyMarshaler<FInterpCurvePointQuat>(1, Points_PropertyAddress, CachedMarshalingDelegates<FInterpCurvePointQuat, BlittableTypeMarshaler<FInterpCurvePointQuat>>.FromNative, CachedMarshalingDelegates<FInterpCurvePointQuat, BlittableTypeMarshaler<FInterpCurvePointQuat>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Points_Offset), Points);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsLooped_Offset), 0, IsLooped_PropertyAddress.Address, IsLooped);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LoopKeyOffset_Offset), LoopKeyOffset);
	}

	public FInterpCurveQuat(IntPtr nativeStruct)
	{
		if (!FInterpCurveQuat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.InterpCurveQuat");
			Points = null;
			IsLooped = false;
			LoopKeyOffset = 0f;
		}
		else
		{
			Points = new TArrayCopyMarshaler<FInterpCurvePointQuat>(1, Points_PropertyAddress, CachedMarshalingDelegates<FInterpCurvePointQuat, BlittableTypeMarshaler<FInterpCurvePointQuat>>.FromNative, CachedMarshalingDelegates<FInterpCurvePointQuat, BlittableTypeMarshaler<FInterpCurvePointQuat>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Points_Offset));
			IsLooped = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsLooped_Offset), 0, IsLooped_PropertyAddress.Address);
			LoopKeyOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LoopKeyOffset_Offset));
		}
	}

	static FInterpCurveQuat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInterpCurveQuat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterpCurveQuat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.InterpCurveQuat");
		FInterpCurveQuat_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Points_PropertyAddress, intPtr, "Points");
		Points_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Points");
		Points_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Points", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLooped_PropertyAddress, intPtr, "bIsLooped");
		IsLooped_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsLooped");
		IsLooped_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsLooped", Classes.FBoolProperty);
		LoopKeyOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoopKeyOffset");
		LoopKeyOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoopKeyOffset", Classes.FFloatProperty);
		FInterpCurveQuat_IsValid = intPtr != IntPtr.Zero && Points_IsValid && IsLooped_IsValid && LoopKeyOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.InterpCurveQuat", FInterpCurveQuat_IsValid);
	}
}
