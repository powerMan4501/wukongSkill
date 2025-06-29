using System;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_FamilySpecifyUnitAttr")]
public struct FDetectCondition_FamilySpecifyUnitAttr
{
	[DisplayName("匹配子Tamer信息")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_FamilySpecifyUnitAttr:MatchInfo")]
	public FTamerFamilyMatchChildInfo MatchInfo;

	[UProperty]
	[DisplayName("属性类型")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition_FamilySpecifyUnitAttr:AttrFloatType")]
	public EBGUAttrFloat AttrFloatType;

	[EditAnywhere]
	[DisplayName("属性比较方式")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_FamilySpecifyUnitAttr:CompareOperation")]
	public EValueCompareOperations CompareOperation;

	[EditAnywhere]
	[DisplayName("属性比较值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_FamilySpecifyUnitAttr:CompareValue")]
	public float CompareValue;

	private static int DetectCondition_FamilySpecifyUnitAttr_StructSize;

	private static int DetectCondition_FamilySpecifyUnitAttr_IsValid;

	private static bool MatchInfo_IsValid;

	private static int MatchInfo_Offset;

	private static bool AttrFloatType_IsValid;

	private static int AttrFloatType_Offset;

	private static FFieldAddress AttrFloatType_PropertyAddress;

	private static bool CompareOperation_IsValid;

	private static int CompareOperation_Offset;

	private static FFieldAddress CompareOperation_PropertyAddress;

	private static bool CompareValue_IsValid;

	private static int CompareValue_Offset;

	public FDetectCondition_FamilySpecifyUnitAttr Copy()
	{
		return this;
	}

	public static FDetectCondition_FamilySpecifyUnitAttr FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_FamilySpecifyUnitAttr(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_FamilySpecifyUnitAttr value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_FamilySpecifyUnitAttr FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_FamilySpecifyUnitAttr(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_FamilySpecifyUnitAttr_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_FamilySpecifyUnitAttr value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_FamilySpecifyUnitAttr_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_FamilySpecifyUnitAttr_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_FamilySpecifyUnitAttr");
			return;
		}
		FTamerFamilyMatchChildInfo.ToNative(IntPtr.Add(nativeStruct, MatchInfo_Offset), MatchInfo);
		EnumMarshaler<EBGUAttrFloat>.ToNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address, AttrFloatType);
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address, CompareOperation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CompareValue_Offset), CompareValue);
	}

	public FDetectCondition_FamilySpecifyUnitAttr(IntPtr nativeStruct)
	{
		if (DetectCondition_FamilySpecifyUnitAttr_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_FamilySpecifyUnitAttr");
			MatchInfo = default(FTamerFamilyMatchChildInfo);
			AttrFloatType = EBGUAttrFloat.None;
			CompareOperation = EValueCompareOperations.EqualTo;
			CompareValue = 0f;
		}
		else
		{
			MatchInfo = FTamerFamilyMatchChildInfo.FromNative(IntPtr.Add(nativeStruct, MatchInfo_Offset));
			AttrFloatType = EnumMarshaler<EBGUAttrFloat>.FromNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address);
			CompareOperation = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address);
			CompareValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CompareValue_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_FamilySpecifyUnitAttr");
		DetectCondition_FamilySpecifyUnitAttr_StructSize = NativeReflection.GetStructSize(intPtr);
		MatchInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatchInfo");
		MatchInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatchInfo", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref AttrFloatType_PropertyAddress, intPtr, "AttrFloatType");
		AttrFloatType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttrFloatType");
		AttrFloatType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttrFloatType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CompareOperation_PropertyAddress, intPtr, "CompareOperation");
		CompareOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperation");
		CompareOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperation", Classes.FEnumProperty);
		CompareValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareValue");
		CompareValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareValue", Classes.FFloatProperty);
		DetectCondition_FamilySpecifyUnitAttr_IsValid = ((intPtr != IntPtr.Zero && MatchInfo_IsValid && AttrFloatType_IsValid && CompareOperation_IsValid && CompareValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_FamilySpecifyUnitAttr", (byte)DetectCondition_FamilySpecifyUnitAttr_IsValid != 0);
	}

	static FDetectCondition_FamilySpecifyUnitAttr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_FamilySpecifyUnitAttr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_FamilySpecifyUnitAttr));
	}
}
