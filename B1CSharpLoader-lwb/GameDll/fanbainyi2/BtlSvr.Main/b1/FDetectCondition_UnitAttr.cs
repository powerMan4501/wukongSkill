using System;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_UnitAttr")]
public struct FDetectCondition_UnitAttr
{
	[UProperty]
	[DisplayName("属性类型")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition_UnitAttr:AttrFloatType")]
	public EBGUAttrFloat AttrFloatType;

	[UProperty]
	[EditAnywhere]
	[DisplayName("属性比较方式")]
	[USharpPath("/Script/b1-Managed.DetectCondition_UnitAttr:CompareOperation")]
	public EValueCompareOperations CompareOperation;

	[EditAnywhere]
	[DisplayName("属性比较值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_UnitAttr:CompareValue")]
	public float CompareValue;

	private static int DetectCondition_UnitAttr_StructSize;

	private static int DetectCondition_UnitAttr_IsValid;

	private static bool AttrFloatType_IsValid;

	private static int AttrFloatType_Offset;

	private static FFieldAddress AttrFloatType_PropertyAddress;

	private static bool CompareOperation_IsValid;

	private static int CompareOperation_Offset;

	private static FFieldAddress CompareOperation_PropertyAddress;

	private static bool CompareValue_IsValid;

	private static int CompareValue_Offset;

	public FDetectCondition_UnitAttr Copy()
	{
		return this;
	}

	public static FDetectCondition_UnitAttr FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_UnitAttr(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_UnitAttr value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_UnitAttr FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_UnitAttr(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_UnitAttr_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_UnitAttr value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_UnitAttr_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_UnitAttr_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_UnitAttr");
			return;
		}
		EnumMarshaler<EBGUAttrFloat>.ToNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address, AttrFloatType);
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address, CompareOperation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CompareValue_Offset), CompareValue);
	}

	public FDetectCondition_UnitAttr(IntPtr nativeStruct)
	{
		if (DetectCondition_UnitAttr_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_UnitAttr");
			AttrFloatType = EBGUAttrFloat.None;
			CompareOperation = EValueCompareOperations.EqualTo;
			CompareValue = 0f;
		}
		else
		{
			AttrFloatType = EnumMarshaler<EBGUAttrFloat>.FromNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address);
			CompareOperation = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address);
			CompareValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CompareValue_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_UnitAttr");
		DetectCondition_UnitAttr_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref AttrFloatType_PropertyAddress, intPtr, "AttrFloatType");
		AttrFloatType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttrFloatType");
		AttrFloatType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttrFloatType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CompareOperation_PropertyAddress, intPtr, "CompareOperation");
		CompareOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperation");
		CompareOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperation", Classes.FEnumProperty);
		CompareValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareValue");
		CompareValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareValue", Classes.FFloatProperty);
		DetectCondition_UnitAttr_IsValid = ((intPtr != IntPtr.Zero && AttrFloatType_IsValid && CompareOperation_IsValid && CompareValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_UnitAttr", (byte)DetectCondition_UnitAttr_IsValid != 0);
	}

	static FDetectCondition_UnitAttr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_UnitAttr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_UnitAttr));
	}
}
