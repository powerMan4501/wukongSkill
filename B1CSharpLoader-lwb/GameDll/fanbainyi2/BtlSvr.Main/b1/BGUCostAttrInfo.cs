using System;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BGUCostAttrInfo")]
public struct BGUCostAttrInfo
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUCostAttrInfo:Attr")]
	public EBGUAttrFloat Attr;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUCostAttrInfo:CostValue")]
	public float CostValue;

	private static int BGUCostAttrInfo_StructSize;

	private static int BGUCostAttrInfo_IsValid;

	private static bool Attr_IsValid;

	private static int Attr_Offset;

	private static FFieldAddress Attr_PropertyAddress;

	private static bool CostValue_IsValid;

	private static int CostValue_Offset;

	public BGUCostAttrInfo Copy()
	{
		return this;
	}

	public static BGUCostAttrInfo FromNative(IntPtr nativeBuffer)
	{
		return new BGUCostAttrInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BGUCostAttrInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BGUCostAttrInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BGUCostAttrInfo(IntPtr.Add(nativeBuffer, arrayIndex * BGUCostAttrInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BGUCostAttrInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BGUCostAttrInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BGUCostAttrInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BGUCostAttrInfo");
			return;
		}
		EnumMarshaler<EBGUAttrFloat>.ToNative(IntPtr.Add(nativeStruct, Attr_Offset), 0, Attr_PropertyAddress.Address, Attr);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CostValue_Offset), CostValue);
	}

	public BGUCostAttrInfo(IntPtr nativeStruct)
	{
		if (BGUCostAttrInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BGUCostAttrInfo");
			Attr = EBGUAttrFloat.None;
			CostValue = 0f;
		}
		else
		{
			Attr = EnumMarshaler<EBGUAttrFloat>.FromNative(IntPtr.Add(nativeStruct, Attr_Offset), 0, Attr_PropertyAddress.Address);
			CostValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CostValue_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BGUCostAttrInfo");
		BGUCostAttrInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Attr_PropertyAddress, intPtr, "Attr");
		Attr_Offset = NativeReflection.GetPropertyOffset(intPtr, "Attr");
		Attr_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Attr", Classes.FEnumProperty);
		CostValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "CostValue");
		CostValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CostValue", Classes.FFloatProperty);
		BGUCostAttrInfo_IsValid = ((intPtr != IntPtr.Zero && Attr_IsValid && CostValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BGUCostAttrInfo", (byte)BGUCostAttrInfo_IsValid != 0);
	}

	static BGUCostAttrInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUCostAttrInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUCostAttrInfo));
	}
}
