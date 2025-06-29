using System;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.UnitAttrCondition")]
public struct FUnitAttrCondition
{
	[UProperty]
	[DisplayName("属性类型")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UnitAttrCondition:AttrFloatType")]
	public EBGUAttrFloat AttrFloatType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("属性比较方式")]
	[USharpPath("/Script/b1-Managed.UnitAttrCondition:CompareOperation")]
	public EValueCompareOperations CompareOperation;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("属性比较值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitAttrCondition:CompareValue")]
	public float CompareValue;

	private static int UnitAttrCondition_StructSize;

	private static int UnitAttrCondition_IsValid;

	private static bool AttrFloatType_IsValid;

	private static int AttrFloatType_Offset;

	private static FFieldAddress AttrFloatType_PropertyAddress;

	private static bool CompareOperation_IsValid;

	private static int CompareOperation_Offset;

	private static FFieldAddress CompareOperation_PropertyAddress;

	private static bool CompareValue_IsValid;

	private static int CompareValue_Offset;

	public FUnitAttrCondition Copy()
	{
		return this;
	}

	public static FUnitAttrCondition FromNative(IntPtr nativeBuffer)
	{
		return new FUnitAttrCondition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUnitAttrCondition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUnitAttrCondition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUnitAttrCondition(IntPtr.Add(nativeBuffer, arrayIndex * UnitAttrCondition_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUnitAttrCondition value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UnitAttrCondition_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UnitAttrCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitAttrCondition");
			return;
		}
		EnumMarshaler<EBGUAttrFloat>.ToNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address, AttrFloatType);
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address, CompareOperation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CompareValue_Offset), CompareValue);
	}

	public FUnitAttrCondition(IntPtr nativeStruct)
	{
		if (UnitAttrCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitAttrCondition");
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
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UnitAttrCondition");
		UnitAttrCondition_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref AttrFloatType_PropertyAddress, intPtr, "AttrFloatType");
		AttrFloatType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttrFloatType");
		AttrFloatType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttrFloatType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CompareOperation_PropertyAddress, intPtr, "CompareOperation");
		CompareOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperation");
		CompareOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperation", Classes.FEnumProperty);
		CompareValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareValue");
		CompareValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareValue", Classes.FFloatProperty);
		UnitAttrCondition_IsValid = ((intPtr != IntPtr.Zero && AttrFloatType_IsValid && CompareOperation_IsValid && CompareValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UnitAttrCondition", (byte)UnitAttrCondition_IsValid != 0);
	}

	static FUnitAttrCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FUnitAttrCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUnitAttrCondition));
	}
}
