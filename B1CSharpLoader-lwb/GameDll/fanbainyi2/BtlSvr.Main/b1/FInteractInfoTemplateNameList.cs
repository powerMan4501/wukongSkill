using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.InteractInfoTemplateNameList")]
public struct FInteractInfoTemplateNameList
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.InteractInfoTemplateNameList:BoneNameList")]
	public List<FName> BoneNameList;

	private static int InteractInfoTemplateNameList_StructSize;

	private static int InteractInfoTemplateNameList_IsValid;

	private static bool BoneNameList_IsValid;

	private static int BoneNameList_Offset;

	private static FFieldAddress BoneNameList_PropertyAddress;

	public FInteractInfoTemplateNameList Copy()
	{
		FInteractInfoTemplateNameList result = this;
		if (BoneNameList != null)
		{
			result.BoneNameList = new List<FName>(BoneNameList);
		}
		return result;
	}

	public static FInteractInfoTemplateNameList FromNative(IntPtr nativeBuffer)
	{
		return new FInteractInfoTemplateNameList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInteractInfoTemplateNameList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInteractInfoTemplateNameList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInteractInfoTemplateNameList(IntPtr.Add(nativeBuffer, arrayIndex * InteractInfoTemplateNameList_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInteractInfoTemplateNameList value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * InteractInfoTemplateNameList_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (InteractInfoTemplateNameList_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InteractInfoTemplateNameList");
		}
		else
		{
			new TArrayCopyMarshaler<FName>(1, BoneNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BoneNameList_Offset), BoneNameList);
		}
	}

	public FInteractInfoTemplateNameList(IntPtr nativeStruct)
	{
		if (InteractInfoTemplateNameList_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InteractInfoTemplateNameList");
			BoneNameList = null;
		}
		else
		{
			BoneNameList = new TArrayCopyMarshaler<FName>(1, BoneNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BoneNameList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.InteractInfoTemplateNameList");
		InteractInfoTemplateNameList_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref BoneNameList_PropertyAddress, intPtr, "BoneNameList");
		BoneNameList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BoneNameList");
		BoneNameList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BoneNameList", Classes.FArrayProperty);
		InteractInfoTemplateNameList_IsValid = ((intPtr != IntPtr.Zero && BoneNameList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.InteractInfoTemplateNameList", (byte)InteractInfoTemplateNameList_IsValid != 0);
	}

	static FInteractInfoTemplateNameList()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FInteractInfoTemplateNameList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInteractInfoTemplateNameList));
	}
}
