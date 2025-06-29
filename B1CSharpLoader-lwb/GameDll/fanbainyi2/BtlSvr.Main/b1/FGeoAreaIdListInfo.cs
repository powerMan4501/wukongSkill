using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.GeoAreaIdListInfo")]
public struct FGeoAreaIdListInfo
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GeoAreaIdListInfo:AreaIdList")]
	public List<int> AreaIdList;

	private static int GeoAreaIdListInfo_StructSize;

	private static int GeoAreaIdListInfo_IsValid;

	private static bool AreaIdList_IsValid;

	private static int AreaIdList_Offset;

	private static FFieldAddress AreaIdList_PropertyAddress;

	public FGeoAreaIdListInfo Copy()
	{
		FGeoAreaIdListInfo result = this;
		if (AreaIdList != null)
		{
			result.AreaIdList = new List<int>(AreaIdList);
		}
		return result;
	}

	public static FGeoAreaIdListInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGeoAreaIdListInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeoAreaIdListInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeoAreaIdListInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeoAreaIdListInfo(IntPtr.Add(nativeBuffer, arrayIndex * GeoAreaIdListInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeoAreaIdListInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * GeoAreaIdListInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (GeoAreaIdListInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GeoAreaIdListInfo");
		}
		else
		{
			new TArrayCopyMarshaler<int>(1, AreaIdList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AreaIdList_Offset), AreaIdList);
		}
	}

	public FGeoAreaIdListInfo(IntPtr nativeStruct)
	{
		if (GeoAreaIdListInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GeoAreaIdListInfo");
			AreaIdList = null;
		}
		else
		{
			AreaIdList = new TArrayCopyMarshaler<int>(1, AreaIdList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AreaIdList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.GeoAreaIdListInfo");
		GeoAreaIdListInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref AreaIdList_PropertyAddress, intPtr, "AreaIdList");
		AreaIdList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AreaIdList");
		AreaIdList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AreaIdList", Classes.FArrayProperty);
		GeoAreaIdListInfo_IsValid = ((intPtr != IntPtr.Zero && AreaIdList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.GeoAreaIdListInfo", (byte)GeoAreaIdListInfo_IsValid != 0);
	}

	static FGeoAreaIdListInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGeoAreaIdListInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeoAreaIdListInfo));
	}
}
