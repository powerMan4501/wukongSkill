using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 32776)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.InterpCurveTwoVectors", "CoreUObject", UnrealModuleType.Engine)]
public struct FInterpCurveTwoVectors
{
	private static bool Points_IsValid;

	private static FFieldAddress Points_PropertyAddress;

	private static int Points_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveTwoVectors:Points")]
	public List<FInterpCurvePointTwoVectors> Points;

	private static bool IsLooped_IsValid;

	private static FFieldAddress IsLooped_PropertyAddress;

	private static int IsLooped_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveTwoVectors:bIsLooped")]
	public bool IsLooped;

	private static bool LoopKeyOffset_IsValid;

	private static int LoopKeyOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurveTwoVectors:LoopKeyOffset")]
	public float LoopKeyOffset;

	private static bool FInterpCurveTwoVectors_IsValid;

	private static int FInterpCurveTwoVectors_StructSize;

	public FInterpCurveTwoVectors Copy()
	{
		FInterpCurveTwoVectors result = this;
		if (Points != null)
		{
			result.Points = new List<FInterpCurvePointTwoVectors>(Points);
		}
		return result;
	}

	public static FInterpCurveTwoVectors FromNative(IntPtr nativeBuffer)
	{
		return new FInterpCurveTwoVectors(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInterpCurveTwoVectors value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInterpCurveTwoVectors FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInterpCurveTwoVectors(nativeBuffer + arrayIndex * FInterpCurveTwoVectors_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInterpCurveTwoVectors value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInterpCurveTwoVectors_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInterpCurveTwoVectors_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.InterpCurveTwoVectors");
			return;
		}
		new TArrayCopyMarshaler<FInterpCurvePointTwoVectors>(1, Points_PropertyAddress, CachedMarshalingDelegates<FInterpCurvePointTwoVectors, BlittableTypeMarshaler<FInterpCurvePointTwoVectors>>.FromNative, CachedMarshalingDelegates<FInterpCurvePointTwoVectors, BlittableTypeMarshaler<FInterpCurvePointTwoVectors>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Points_Offset), Points);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsLooped_Offset), 0, IsLooped_PropertyAddress.Address, IsLooped);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LoopKeyOffset_Offset), LoopKeyOffset);
	}

	public FInterpCurveTwoVectors(IntPtr nativeStruct)
	{
		if (!FInterpCurveTwoVectors_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.InterpCurveTwoVectors");
			Points = null;
			IsLooped = false;
			LoopKeyOffset = 0f;
		}
		else
		{
			Points = new TArrayCopyMarshaler<FInterpCurvePointTwoVectors>(1, Points_PropertyAddress, CachedMarshalingDelegates<FInterpCurvePointTwoVectors, BlittableTypeMarshaler<FInterpCurvePointTwoVectors>>.FromNative, CachedMarshalingDelegates<FInterpCurvePointTwoVectors, BlittableTypeMarshaler<FInterpCurvePointTwoVectors>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Points_Offset));
			IsLooped = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsLooped_Offset), 0, IsLooped_PropertyAddress.Address);
			LoopKeyOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LoopKeyOffset_Offset));
		}
	}

	static FInterpCurveTwoVectors()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInterpCurveTwoVectors)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterpCurveTwoVectors));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.InterpCurveTwoVectors");
		FInterpCurveTwoVectors_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Points_PropertyAddress, intPtr, "Points");
		Points_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Points");
		Points_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Points", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLooped_PropertyAddress, intPtr, "bIsLooped");
		IsLooped_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsLooped");
		IsLooped_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsLooped", Classes.FBoolProperty);
		LoopKeyOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoopKeyOffset");
		LoopKeyOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoopKeyOffset", Classes.FFloatProperty);
		FInterpCurveTwoVectors_IsValid = intPtr != IntPtr.Zero && Points_IsValid && IsLooped_IsValid && LoopKeyOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.InterpCurveTwoVectors", FInterpCurveTwoVectors_IsValid);
	}
}
