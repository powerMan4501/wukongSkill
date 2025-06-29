using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BoneUseForDispList")]
public struct FBoneUseForDispList
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BoneUseForDispList:InfoList")]
	public List<FBoneUseForDispMap> InfoList;

	private static int BoneUseForDispList_StructSize;

	private static int BoneUseForDispList_IsValid;

	private static bool InfoList_IsValid;

	private static int InfoList_Offset;

	private static FFieldAddress InfoList_PropertyAddress;

	public FBoneUseForDispList Copy()
	{
		FBoneUseForDispList result = this;
		if (InfoList != null)
		{
			result.InfoList = new List<FBoneUseForDispMap>(InfoList);
		}
		return result;
	}

	public static FBoneUseForDispList FromNative(IntPtr nativeBuffer)
	{
		return new FBoneUseForDispList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBoneUseForDispList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBoneUseForDispList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBoneUseForDispList(IntPtr.Add(nativeBuffer, arrayIndex * BoneUseForDispList_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBoneUseForDispList value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BoneUseForDispList_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BoneUseForDispList_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BoneUseForDispList");
		}
		else
		{
			new TArrayCopyMarshaler<FBoneUseForDispMap>(1, InfoList_PropertyAddress, CachedMarshalingDelegates<FBoneUseForDispMap, BlittableTypeMarshaler<FBoneUseForDispMap>>.FromNative, CachedMarshalingDelegates<FBoneUseForDispMap, BlittableTypeMarshaler<FBoneUseForDispMap>>.ToNative).ToNative(IntPtr.Add(nativeStruct, InfoList_Offset), InfoList);
		}
	}

	public FBoneUseForDispList(IntPtr nativeStruct)
	{
		if (BoneUseForDispList_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BoneUseForDispList");
			InfoList = null;
		}
		else
		{
			InfoList = new TArrayCopyMarshaler<FBoneUseForDispMap>(1, InfoList_PropertyAddress, CachedMarshalingDelegates<FBoneUseForDispMap, BlittableTypeMarshaler<FBoneUseForDispMap>>.FromNative, CachedMarshalingDelegates<FBoneUseForDispMap, BlittableTypeMarshaler<FBoneUseForDispMap>>.ToNative).FromNative(IntPtr.Add(nativeStruct, InfoList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BoneUseForDispList");
		BoneUseForDispList_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref InfoList_PropertyAddress, intPtr, "InfoList");
		InfoList_Offset = NativeReflection.GetPropertyOffset(intPtr, "InfoList");
		InfoList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InfoList", Classes.FArrayProperty);
		BoneUseForDispList_IsValid = ((intPtr != IntPtr.Zero && InfoList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BoneUseForDispList", (byte)BoneUseForDispList_IsValid != 0);
	}

	static FBoneUseForDispList()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBoneUseForDispList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBoneUseForDispList));
	}
}
