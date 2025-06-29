using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.NaniteResourceInfo", "Engine", UnrealModuleType.Engine)]
public struct FNaniteResourceInfo
{
	private static bool PageLodMap_IsValid;

	private static FFieldAddress PageLodMap_PropertyAddress;

	private static int PageLodMap_Offset;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.NaniteResourceInfo:PageLodMap")]
	public List<byte> PageLodMap;

	private static bool ClusterLodError_IsValid;

	private static FFieldAddress ClusterLodError_PropertyAddress;

	private static int ClusterLodError_Offset;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.NaniteResourceInfo:ClusterLodError")]
	public List<float> ClusterLodError;

	private static bool ErrorCorrect_IsValid;

	private static int ErrorCorrect_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.NaniteResourceInfo:ErrorCorrect")]
	public float ErrorCorrect;

	private static bool MaxLodLevel_IsValid;

	private static int MaxLodLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.NaniteResourceInfo:MaxLodLevel")]
	public int MaxLodLevel;

	private static bool FNaniteResourceInfo_IsValid;

	private static int FNaniteResourceInfo_StructSize;

	public FNaniteResourceInfo Copy()
	{
		FNaniteResourceInfo result = this;
		if (PageLodMap != null)
		{
			result.PageLodMap = new List<byte>(PageLodMap);
		}
		if (ClusterLodError != null)
		{
			result.ClusterLodError = new List<float>(ClusterLodError);
		}
		return result;
	}

	public static FNaniteResourceInfo FromNative(IntPtr nativeBuffer)
	{
		return new FNaniteResourceInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNaniteResourceInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNaniteResourceInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNaniteResourceInfo(nativeBuffer + arrayIndex * FNaniteResourceInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNaniteResourceInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNaniteResourceInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNaniteResourceInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NaniteResourceInfo");
			return;
		}
		new TArrayCopyMarshaler<byte>(1, PageLodMap_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PageLodMap_Offset), PageLodMap);
		new TArrayCopyMarshaler<float>(1, ClusterLodError_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ClusterLodError_Offset), ClusterLodError);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ErrorCorrect_Offset), ErrorCorrect);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxLodLevel_Offset), MaxLodLevel);
	}

	public FNaniteResourceInfo(IntPtr nativeStruct)
	{
		if (!FNaniteResourceInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NaniteResourceInfo");
			PageLodMap = null;
			ClusterLodError = null;
			ErrorCorrect = 0f;
			MaxLodLevel = 0;
		}
		else
		{
			PageLodMap = new TArrayCopyMarshaler<byte>(1, PageLodMap_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PageLodMap_Offset));
			ClusterLodError = new TArrayCopyMarshaler<float>(1, ClusterLodError_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ClusterLodError_Offset));
			ErrorCorrect = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ErrorCorrect_Offset));
			MaxLodLevel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxLodLevel_Offset));
		}
	}

	static FNaniteResourceInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNaniteResourceInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNaniteResourceInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.NaniteResourceInfo");
		FNaniteResourceInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref PageLodMap_PropertyAddress, intPtr, "PageLodMap");
		PageLodMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PageLodMap");
		PageLodMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PageLodMap", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ClusterLodError_PropertyAddress, intPtr, "ClusterLodError");
		ClusterLodError_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClusterLodError");
		ClusterLodError_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClusterLodError", Classes.FArrayProperty);
		ErrorCorrect_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ErrorCorrect");
		ErrorCorrect_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ErrorCorrect", Classes.FFloatProperty);
		MaxLodLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxLodLevel");
		MaxLodLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxLodLevel", Classes.FIntProperty);
		FNaniteResourceInfo_IsValid = intPtr != IntPtr.Zero && PageLodMap_IsValid && ClusterLodError_IsValid && ErrorCorrect_IsValid && MaxLodLevel_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.NaniteResourceInfo", FNaniteResourceInfo_IsValid);
	}
}
