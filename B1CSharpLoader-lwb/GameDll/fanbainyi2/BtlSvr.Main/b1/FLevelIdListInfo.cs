using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.LevelIdListInfo")]
public struct FLevelIdListInfo
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.LevelIdListInfo:LevelIdList")]
	public List<int> LevelIdList;

	private static int LevelIdListInfo_StructSize;

	private static int LevelIdListInfo_IsValid;

	private static bool LevelIdList_IsValid;

	private static int LevelIdList_Offset;

	private static FFieldAddress LevelIdList_PropertyAddress;

	public FLevelIdListInfo Copy()
	{
		FLevelIdListInfo result = this;
		if (LevelIdList != null)
		{
			result.LevelIdList = new List<int>(LevelIdList);
		}
		return result;
	}

	public static FLevelIdListInfo FromNative(IntPtr nativeBuffer)
	{
		return new FLevelIdListInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLevelIdListInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLevelIdListInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLevelIdListInfo(IntPtr.Add(nativeBuffer, arrayIndex * LevelIdListInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLevelIdListInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * LevelIdListInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (LevelIdListInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LevelIdListInfo");
		}
		else
		{
			new TArrayCopyMarshaler<int>(1, LevelIdList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, LevelIdList_Offset), LevelIdList);
		}
	}

	public FLevelIdListInfo(IntPtr nativeStruct)
	{
		if (LevelIdListInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LevelIdListInfo");
			LevelIdList = null;
		}
		else
		{
			LevelIdList = new TArrayCopyMarshaler<int>(1, LevelIdList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, LevelIdList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.LevelIdListInfo");
		LevelIdListInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref LevelIdList_PropertyAddress, intPtr, "LevelIdList");
		LevelIdList_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelIdList");
		LevelIdList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelIdList", Classes.FArrayProperty);
		LevelIdListInfo_IsValid = ((intPtr != IntPtr.Zero && LevelIdList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.LevelIdListInfo", (byte)LevelIdListInfo_IsValid != 0);
	}

	static FLevelIdListInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FLevelIdListInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLevelIdListInfo));
	}
}
