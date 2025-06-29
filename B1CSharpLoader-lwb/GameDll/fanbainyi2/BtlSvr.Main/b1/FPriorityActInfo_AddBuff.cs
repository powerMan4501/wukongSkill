using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.PriorityActInfo_AddBuff")]
public struct FPriorityActInfo_AddBuff
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("BuffID列表")]
	[Category("AddBuffAction")]
	[USharpPath("/Script/b1-Managed.PriorityActInfo_AddBuff:BuffIDList")]
	public List<int> BuffIDList;

	private static int PriorityActInfo_AddBuff_StructSize;

	private static int PriorityActInfo_AddBuff_IsValid;

	private static bool BuffIDList_IsValid;

	private static int BuffIDList_Offset;

	private static FFieldAddress BuffIDList_PropertyAddress;

	public FPriorityActInfo_AddBuff Copy()
	{
		FPriorityActInfo_AddBuff result = this;
		if (BuffIDList != null)
		{
			result.BuffIDList = new List<int>(BuffIDList);
		}
		return result;
	}

	public static FPriorityActInfo_AddBuff FromNative(IntPtr nativeBuffer)
	{
		return new FPriorityActInfo_AddBuff(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPriorityActInfo_AddBuff value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPriorityActInfo_AddBuff FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPriorityActInfo_AddBuff(IntPtr.Add(nativeBuffer, arrayIndex * PriorityActInfo_AddBuff_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPriorityActInfo_AddBuff value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PriorityActInfo_AddBuff_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PriorityActInfo_AddBuff_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PriorityActInfo_AddBuff");
		}
		else
		{
			new TArrayCopyMarshaler<int>(1, BuffIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BuffIDList_Offset), BuffIDList);
		}
	}

	public FPriorityActInfo_AddBuff(IntPtr nativeStruct)
	{
		if (PriorityActInfo_AddBuff_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PriorityActInfo_AddBuff");
			BuffIDList = null;
		}
		else
		{
			BuffIDList = new TArrayCopyMarshaler<int>(1, BuffIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BuffIDList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PriorityActInfo_AddBuff");
		PriorityActInfo_AddBuff_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref BuffIDList_PropertyAddress, intPtr, "BuffIDList");
		BuffIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffIDList");
		BuffIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffIDList", Classes.FArrayProperty);
		PriorityActInfo_AddBuff_IsValid = ((intPtr != IntPtr.Zero && BuffIDList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PriorityActInfo_AddBuff", (byte)PriorityActInfo_AddBuff_IsValid != 0);
	}

	static FPriorityActInfo_AddBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPriorityActInfo_AddBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPriorityActInfo_AddBuff));
	}
}
