using System;
using BtlShare;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AutoTestPlayerConditionConfig")]
public struct FAutoTestPlayerConditionConfig
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AutoTestPlayerConditionConfig:ConditionType")]
	public EGSAutoTestPlayerCastConditionType ConditionType;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "ConditionType == EGSAutoTestPlayerCastConditionType::UnitState")]
	[USharpPath("/Script/b1-Managed.AutoTestPlayerConditionConfig:UnitState")]
	public EBGUUnitState UnitState;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "ConditionType == EGSAutoTestPlayerCastConditionType::UnitAttr")]
	[USharpPath("/Script/b1-Managed.AutoTestPlayerConditionConfig:AttrFloatType")]
	public EBGUAttrFloat AttrFloatType;

	[UMeta(MDProp.EditCondition, "ConditionType == EGSAutoTestPlayerCastConditionType::UnitAttr || ConditionType == EGSAutoTestPlayerCastConditionType::PELevel")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoTestPlayerConditionConfig:CompareOperation")]
	public EValueCompareOperations CompareOperation;

	[UMeta(MDProp.EditCondition, "ConditionType == EGSAutoTestPlayerCastConditionType::UnitAttr")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoTestPlayerConditionConfig:FloatValue")]
	public float FloatValue;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "ConditionType == EGSAutoTestPlayerCastConditionType::PELevel || ConditionType == EGSAutoTestPlayerCastConditionType::HasItem")]
	[USharpPath("/Script/b1-Managed.AutoTestPlayerConditionConfig:IntValue")]
	public int IntValue;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AutoTestPlayerConditionConfig:InverseCondition")]
	public bool InverseCondition;

	private static int AutoTestPlayerConditionConfig_StructSize;

	private static int AutoTestPlayerConditionConfig_IsValid;

	private static bool ConditionType_IsValid;

	private static int ConditionType_Offset;

	private static FFieldAddress ConditionType_PropertyAddress;

	private static bool UnitState_IsValid;

	private static int UnitState_Offset;

	private static FFieldAddress UnitState_PropertyAddress;

	private static bool AttrFloatType_IsValid;

	private static int AttrFloatType_Offset;

	private static FFieldAddress AttrFloatType_PropertyAddress;

	private static bool CompareOperation_IsValid;

	private static int CompareOperation_Offset;

	private static FFieldAddress CompareOperation_PropertyAddress;

	private static bool FloatValue_IsValid;

	private static int FloatValue_Offset;

	private static bool IntValue_IsValid;

	private static int IntValue_Offset;

	private static bool InverseCondition_IsValid;

	private static int InverseCondition_Offset;

	private static FFieldAddress InverseCondition_PropertyAddress;

	public QuestCustom_PlayerCastSkillConditionConfig ToCustomData()
	{
		return new QuestCustom_PlayerCastSkillConditionConfig
		{
			ConditionType = (int)ConditionType,
			AttrType = (int)AttrFloatType,
			UnitState = (int)UnitState,
			CompareOperation = (int)CompareOperation,
			FloatValue = FloatValue,
			IntValue = IntValue,
			InverseCondition = InverseCondition
		};
	}

	public FAutoTestPlayerConditionConfig Copy()
	{
		return this;
	}

	public static FAutoTestPlayerConditionConfig FromNative(IntPtr nativeBuffer)
	{
		return new FAutoTestPlayerConditionConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAutoTestPlayerConditionConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAutoTestPlayerConditionConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAutoTestPlayerConditionConfig(IntPtr.Add(nativeBuffer, arrayIndex * AutoTestPlayerConditionConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAutoTestPlayerConditionConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AutoTestPlayerConditionConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AutoTestPlayerConditionConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AutoTestPlayerConditionConfig");
			return;
		}
		EnumMarshaler<EGSAutoTestPlayerCastConditionType>.ToNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address, ConditionType);
		EnumMarshaler<EBGUUnitState>.ToNative(IntPtr.Add(nativeStruct, UnitState_Offset), 0, UnitState_PropertyAddress.Address, UnitState);
		EnumMarshaler<EBGUAttrFloat>.ToNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address, AttrFloatType);
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address, CompareOperation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FloatValue_Offset), FloatValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IntValue_Offset), IntValue);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, InverseCondition_Offset), 0, InverseCondition_PropertyAddress.Address, InverseCondition);
	}

	public FAutoTestPlayerConditionConfig(IntPtr nativeStruct)
	{
		if (AutoTestPlayerConditionConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AutoTestPlayerConditionConfig");
			ConditionType = EGSAutoTestPlayerCastConditionType.UnitAttr;
			UnitState = EBGUUnitState.None;
			AttrFloatType = EBGUAttrFloat.None;
			CompareOperation = EValueCompareOperations.EqualTo;
			FloatValue = 0f;
			IntValue = 0;
			InverseCondition = false;
		}
		else
		{
			ConditionType = EnumMarshaler<EGSAutoTestPlayerCastConditionType>.FromNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address);
			UnitState = EnumMarshaler<EBGUUnitState>.FromNative(IntPtr.Add(nativeStruct, UnitState_Offset), 0, UnitState_PropertyAddress.Address);
			AttrFloatType = EnumMarshaler<EBGUAttrFloat>.FromNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address);
			CompareOperation = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address);
			FloatValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FloatValue_Offset));
			IntValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IntValue_Offset));
			InverseCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, InverseCondition_Offset), 0, InverseCondition_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AutoTestPlayerConditionConfig");
		AutoTestPlayerConditionConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ConditionType_PropertyAddress, intPtr, "ConditionType");
		ConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionType");
		ConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref UnitState_PropertyAddress, intPtr, "UnitState");
		UnitState_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitState");
		UnitState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AttrFloatType_PropertyAddress, intPtr, "AttrFloatType");
		AttrFloatType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttrFloatType");
		AttrFloatType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttrFloatType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CompareOperation_PropertyAddress, intPtr, "CompareOperation");
		CompareOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperation");
		CompareOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperation", Classes.FEnumProperty);
		FloatValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "FloatValue");
		FloatValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FloatValue", Classes.FFloatProperty);
		IntValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "IntValue");
		IntValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IntValue", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref InverseCondition_PropertyAddress, intPtr, "InverseCondition");
		InverseCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "InverseCondition");
		InverseCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InverseCondition", Classes.FBoolProperty);
		AutoTestPlayerConditionConfig_IsValid = ((intPtr != IntPtr.Zero && ConditionType_IsValid && UnitState_IsValid && AttrFloatType_IsValid && CompareOperation_IsValid && FloatValue_IsValid && IntValue_IsValid && InverseCondition_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AutoTestPlayerConditionConfig", (byte)AutoTestPlayerConditionConfig_IsValid != 0);
	}

	static FAutoTestPlayerConditionConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAutoTestPlayerConditionConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAutoTestPlayerConditionConfig));
	}
}
