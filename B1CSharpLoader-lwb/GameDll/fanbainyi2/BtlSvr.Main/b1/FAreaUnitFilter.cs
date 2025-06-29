using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AreaUnitFilter")]
public struct FAreaUnitFilter
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AreaUnitFilter:UnitFilterType")]
	public EAreaUnitFilterType UnitFilterType;

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "TriggerUnitFilter != ETriggerUnitFilter::SpecifiedResID")]
	[USharpPath("/Script/b1-Managed.AreaUnitFilter:SpecifiedResIDList")]
	public List<int> SpecifiedResIDList;

	private static int AreaUnitFilter_StructSize;

	private static int AreaUnitFilter_IsValid;

	private static bool UnitFilterType_IsValid;

	private static int UnitFilterType_Offset;

	private static FFieldAddress UnitFilterType_PropertyAddress;

	private static bool SpecifiedResIDList_IsValid;

	private static int SpecifiedResIDList_Offset;

	private static FFieldAddress SpecifiedResIDList_PropertyAddress;

	public FAreaUnitFilter Copy()
	{
		FAreaUnitFilter result = this;
		if (SpecifiedResIDList != null)
		{
			result.SpecifiedResIDList = new List<int>(SpecifiedResIDList);
		}
		return result;
	}

	public static FAreaUnitFilter FromNative(IntPtr nativeBuffer)
	{
		return new FAreaUnitFilter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAreaUnitFilter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAreaUnitFilter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAreaUnitFilter(IntPtr.Add(nativeBuffer, arrayIndex * AreaUnitFilter_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAreaUnitFilter value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AreaUnitFilter_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AreaUnitFilter_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AreaUnitFilter");
			return;
		}
		EnumMarshaler<EAreaUnitFilterType>.ToNative(IntPtr.Add(nativeStruct, UnitFilterType_Offset), 0, UnitFilterType_PropertyAddress.Address, UnitFilterType);
		new TArrayCopyMarshaler<int>(1, SpecifiedResIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpecifiedResIDList_Offset), SpecifiedResIDList);
	}

	public FAreaUnitFilter(IntPtr nativeStruct)
	{
		if (AreaUnitFilter_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AreaUnitFilter");
			UnitFilterType = EAreaUnitFilterType.All;
			SpecifiedResIDList = null;
		}
		else
		{
			UnitFilterType = EnumMarshaler<EAreaUnitFilterType>.FromNative(IntPtr.Add(nativeStruct, UnitFilterType_Offset), 0, UnitFilterType_PropertyAddress.Address);
			SpecifiedResIDList = new TArrayCopyMarshaler<int>(1, SpecifiedResIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpecifiedResIDList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AreaUnitFilter");
		AreaUnitFilter_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref UnitFilterType_PropertyAddress, intPtr, "UnitFilterType");
		UnitFilterType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitFilterType");
		UnitFilterType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitFilterType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SpecifiedResIDList_PropertyAddress, intPtr, "SpecifiedResIDList");
		SpecifiedResIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpecifiedResIDList");
		SpecifiedResIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpecifiedResIDList", Classes.FArrayProperty);
		AreaUnitFilter_IsValid = ((intPtr != IntPtr.Zero && UnitFilterType_IsValid && SpecifiedResIDList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AreaUnitFilter", (byte)AreaUnitFilter_IsValid != 0);
	}

	static FAreaUnitFilter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAreaUnitFilter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAreaUnitFilter));
	}
}
