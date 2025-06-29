using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.UStCheckTransformArray", "b1", UnrealModuleType.Game)]
public struct FUStCheckTransformArray
{
	private static bool TransformList_IsValid;

	private static FFieldAddress TransformList_PropertyAddress;

	private static int TransformList_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/b1.UStCheckTransformArray:TransformList")]
	public List<FTransform> TransformList;

	private static bool FUStCheckTransformArray_IsValid;

	private static int FUStCheckTransformArray_StructSize;

	public FUStCheckTransformArray Copy()
	{
		FUStCheckTransformArray result = this;
		if (TransformList != null)
		{
			result.TransformList = new List<FTransform>(TransformList);
		}
		return result;
	}

	public static FUStCheckTransformArray FromNative(IntPtr nativeBuffer)
	{
		return new FUStCheckTransformArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUStCheckTransformArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUStCheckTransformArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUStCheckTransformArray(nativeBuffer + arrayIndex * FUStCheckTransformArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUStCheckTransformArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUStCheckTransformArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUStCheckTransformArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.UStCheckTransformArray");
		}
		else
		{
			new TArrayCopyMarshaler<FTransform>(1, TransformList_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TransformList_Offset), TransformList);
		}
	}

	public FUStCheckTransformArray(IntPtr nativeStruct)
	{
		if (!FUStCheckTransformArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.UStCheckTransformArray");
			TransformList = null;
		}
		else
		{
			TransformList = new TArrayCopyMarshaler<FTransform>(1, TransformList_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TransformList_Offset));
		}
	}

	static FUStCheckTransformArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUStCheckTransformArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUStCheckTransformArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.UStCheckTransformArray");
		FUStCheckTransformArray_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref TransformList_PropertyAddress, intPtr, "TransformList");
		TransformList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransformList");
		TransformList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransformList", Classes.FArrayProperty);
		FUStCheckTransformArray_IsValid = intPtr != IntPtr.Zero && TransformList_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.UStCheckTransformArray", FUStCheckTransformArray_IsValid);
	}
}
