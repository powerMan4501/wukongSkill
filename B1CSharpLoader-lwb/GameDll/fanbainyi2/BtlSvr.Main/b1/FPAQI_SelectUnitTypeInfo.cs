using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FPAQI_SelectUnitTypeInfo")]
public struct FPAQI_SelectUnitTypeInfo
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("选择单位方式类型")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FPAQI_SelectUnitTypeInfo:SelectUnitType")]
	public EPriorityActionSelectUnitType SelectUnitType;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("选择单位方式整型参数")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FPAQI_SelectUnitTypeInfo:SelectUnitTypeIntParams")]
	public List<int> SelectUnitTypeIntParams;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("选择单位方式浮点型型参数")]
	[USharpPath("/Script/b1-Managed.FPAQI_SelectUnitTypeInfo:SelectUnitTypeFloatParams")]
	public List<float> SelectUnitTypeFloatParams;

	private static int FPAQI_SelectUnitTypeInfo_StructSize;

	private static int FPAQI_SelectUnitTypeInfo_IsValid;

	private static bool SelectUnitType_IsValid;

	private static int SelectUnitType_Offset;

	private static FFieldAddress SelectUnitType_PropertyAddress;

	private static bool SelectUnitTypeIntParams_IsValid;

	private static int SelectUnitTypeIntParams_Offset;

	private static FFieldAddress SelectUnitTypeIntParams_PropertyAddress;

	private static bool SelectUnitTypeFloatParams_IsValid;

	private static int SelectUnitTypeFloatParams_Offset;

	private static FFieldAddress SelectUnitTypeFloatParams_PropertyAddress;

	public FPAQI_SelectUnitTypeInfo Copy()
	{
		FPAQI_SelectUnitTypeInfo result = this;
		if (SelectUnitTypeIntParams != null)
		{
			result.SelectUnitTypeIntParams = new List<int>(SelectUnitTypeIntParams);
		}
		if (SelectUnitTypeFloatParams != null)
		{
			result.SelectUnitTypeFloatParams = new List<float>(SelectUnitTypeFloatParams);
		}
		return result;
	}

	public static FPAQI_SelectUnitTypeInfo FromNative(IntPtr nativeBuffer)
	{
		return new FPAQI_SelectUnitTypeInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPAQI_SelectUnitTypeInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPAQI_SelectUnitTypeInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPAQI_SelectUnitTypeInfo(IntPtr.Add(nativeBuffer, arrayIndex * FPAQI_SelectUnitTypeInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPAQI_SelectUnitTypeInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FPAQI_SelectUnitTypeInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FPAQI_SelectUnitTypeInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FPAQI_SelectUnitTypeInfo");
			return;
		}
		EnumMarshaler<EPriorityActionSelectUnitType>.ToNative(IntPtr.Add(nativeStruct, SelectUnitType_Offset), 0, SelectUnitType_PropertyAddress.Address, SelectUnitType);
		new TArrayCopyMarshaler<int>(1, SelectUnitTypeIntParams_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SelectUnitTypeIntParams_Offset), SelectUnitTypeIntParams);
		new TArrayCopyMarshaler<float>(1, SelectUnitTypeFloatParams_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SelectUnitTypeFloatParams_Offset), SelectUnitTypeFloatParams);
	}

	public FPAQI_SelectUnitTypeInfo(IntPtr nativeStruct)
	{
		if (FPAQI_SelectUnitTypeInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FPAQI_SelectUnitTypeInfo");
			SelectUnitType = EPriorityActionSelectUnitType.AllInWandering;
			SelectUnitTypeIntParams = null;
			SelectUnitTypeFloatParams = null;
		}
		else
		{
			SelectUnitType = EnumMarshaler<EPriorityActionSelectUnitType>.FromNative(IntPtr.Add(nativeStruct, SelectUnitType_Offset), 0, SelectUnitType_PropertyAddress.Address);
			SelectUnitTypeIntParams = new TArrayCopyMarshaler<int>(1, SelectUnitTypeIntParams_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SelectUnitTypeIntParams_Offset));
			SelectUnitTypeFloatParams = new TArrayCopyMarshaler<float>(1, SelectUnitTypeFloatParams_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SelectUnitTypeFloatParams_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FPAQI_SelectUnitTypeInfo");
		FPAQI_SelectUnitTypeInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SelectUnitType_PropertyAddress, intPtr, "SelectUnitType");
		SelectUnitType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SelectUnitType");
		SelectUnitType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SelectUnitType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SelectUnitTypeIntParams_PropertyAddress, intPtr, "SelectUnitTypeIntParams");
		SelectUnitTypeIntParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "SelectUnitTypeIntParams");
		SelectUnitTypeIntParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SelectUnitTypeIntParams", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SelectUnitTypeFloatParams_PropertyAddress, intPtr, "SelectUnitTypeFloatParams");
		SelectUnitTypeFloatParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "SelectUnitTypeFloatParams");
		SelectUnitTypeFloatParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SelectUnitTypeFloatParams", Classes.FArrayProperty);
		FPAQI_SelectUnitTypeInfo_IsValid = ((intPtr != IntPtr.Zero && SelectUnitType_IsValid && SelectUnitTypeIntParams_IsValid && SelectUnitTypeFloatParams_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FPAQI_SelectUnitTypeInfo", (byte)FPAQI_SelectUnitTypeInfo_IsValid != 0);
	}

	static FPAQI_SelectUnitTypeInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPAQI_SelectUnitTypeInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPAQI_SelectUnitTypeInfo));
	}
}
