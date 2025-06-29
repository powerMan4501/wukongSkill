using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ComboCondition")]
public struct FComboCondition
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ComboCondition:ConditionType")]
	public EComboConditionType ConditionType;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::UnitState")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ComboCondition:UnitState")]
	public EBGUUnitState UnitState;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::SimpleState")]
	[USharpPath("/Script/b1-Managed.ComboCondition:SimpleState")]
	public EBGUSimpleState SimpleState;

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::UnitAttr")]
	[UProperty]
	[DisplayName("属性类型")]
	[USharpPath("/Script/b1-Managed.ComboCondition:AttrFloatType")]
	public EBGUAttrFloat AttrFloatType;

	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::UnitAttr")]
	[DisplayName("属性比较方式")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ComboCondition:CompareOperation")]
	public EValueCompareOperations CompareOperation;

	[UProperty]
	[DisplayName("属性比较值")]
	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::UnitAttr")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ComboCondition:CompareValue")]
	public float CompareValue;

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::HasBuff")]
	[USharpPath("/Script/b1-Managed.ComboCondition:BuffId")]
	public int BuffId;

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::HasTalent")]
	[USharpPath("/Script/b1-Managed.ComboCondition:TalentId")]
	public int TalentId;

	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::PotentialEnergy")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("棍势等级比较方式")]
	[USharpPath("/Script/b1-Managed.ComboCondition:ComparePotentialEnergyOperation")]
	public EValueCompareOperations ComparePotentialEnergyOperation;

	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::PotentialEnergy")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("棍势等级比较值")]
	[USharpPath("/Script/b1-Managed.ComboCondition:PotentialEnergyLevel")]
	public int PotentialEnergyLevel;

	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::Charge")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("蓄力等级比较方式")]
	[USharpPath("/Script/b1-Managed.ComboCondition:CompareChargeOperation")]
	public EValueCompareOperations CompareChargeOperation;

	[UProperty]
	[EditAnywhere]
	[DisplayName("蓄力等级比较值")]
	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::Charge")]
	[USharpPath("/Script/b1-Managed.ComboCondition:ChargeLevel")]
	public int ChargeLevel;

	[EditAnywhere]
	[DisplayName("天花板高度比较方式")]
	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::CeilingHeight")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ComboCondition:CompareCeilingHeightOperation")]
	public EValueCompareOperations CompareCeilingHeightOperation;

	[UProperty]
	[EditAnywhere]
	[DisplayName("天花板高度比较值")]
	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::CeilingHeight")]
	[USharpPath("/Script/b1-Managed.ComboCondition:CeilingHeight")]
	public int CeilingHeight;

	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::StanceType")]
	[UProperty]
	[DisplayName("武器架势")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ComboCondition:StanceType")]
	public EStanceType_Combo StanceType;

	[DisplayName("技能ID列表")]
	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::AirSkillCount")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ComboCondition:SkillIDList")]
	public List<int> SkillIDList;

	[UProperty]
	[EditAnywhere]
	[DisplayName("MoveMode")]
	[UMeta(MDProp.EditCondition, "ConditionType == ComboConditionType::MoveMode")]
	[USharpPath("/Script/b1-Managed.ComboCondition:MoveMode")]
	public EBGUMoveMode MoveMode;

	[Tooltip("条件标识符，如果设置此值，则Pin的名称显示为该名称")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ComboCondition:ConditionIdentity")]
	public string ConditionIdentity;

	private static int ComboCondition_StructSize;

	private static int ComboCondition_IsValid;

	private static bool ConditionType_IsValid;

	private static int ConditionType_Offset;

	private static FFieldAddress ConditionType_PropertyAddress;

	private static bool UnitState_IsValid;

	private static int UnitState_Offset;

	private static FFieldAddress UnitState_PropertyAddress;

	private static bool SimpleState_IsValid;

	private static int SimpleState_Offset;

	private static FFieldAddress SimpleState_PropertyAddress;

	private static bool AttrFloatType_IsValid;

	private static int AttrFloatType_Offset;

	private static FFieldAddress AttrFloatType_PropertyAddress;

	private static bool CompareOperation_IsValid;

	private static int CompareOperation_Offset;

	private static FFieldAddress CompareOperation_PropertyAddress;

	private static bool CompareValue_IsValid;

	private static int CompareValue_Offset;

	private static bool BuffId_IsValid;

	private static int BuffId_Offset;

	private static bool TalentId_IsValid;

	private static int TalentId_Offset;

	private static bool ComparePotentialEnergyOperation_IsValid;

	private static int ComparePotentialEnergyOperation_Offset;

	private static FFieldAddress ComparePotentialEnergyOperation_PropertyAddress;

	private static bool PotentialEnergyLevel_IsValid;

	private static int PotentialEnergyLevel_Offset;

	private static bool CompareChargeOperation_IsValid;

	private static int CompareChargeOperation_Offset;

	private static FFieldAddress CompareChargeOperation_PropertyAddress;

	private static bool ChargeLevel_IsValid;

	private static int ChargeLevel_Offset;

	private static bool CompareCeilingHeightOperation_IsValid;

	private static int CompareCeilingHeightOperation_Offset;

	private static FFieldAddress CompareCeilingHeightOperation_PropertyAddress;

	private static bool CeilingHeight_IsValid;

	private static int CeilingHeight_Offset;

	private static bool StanceType_IsValid;

	private static int StanceType_Offset;

	private static FFieldAddress StanceType_PropertyAddress;

	private static bool SkillIDList_IsValid;

	private static int SkillIDList_Offset;

	private static FFieldAddress SkillIDList_PropertyAddress;

	private static bool MoveMode_IsValid;

	private static int MoveMode_Offset;

	private static FFieldAddress MoveMode_PropertyAddress;

	private static bool ConditionIdentity_IsValid;

	private static int ConditionIdentity_Offset;

	public FComboCondition Copy()
	{
		FComboCondition result = this;
		if (SkillIDList != null)
		{
			result.SkillIDList = new List<int>(SkillIDList);
		}
		return result;
	}

	public static FComboCondition FromNative(IntPtr nativeBuffer)
	{
		return new FComboCondition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FComboCondition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FComboCondition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FComboCondition(IntPtr.Add(nativeBuffer, arrayIndex * ComboCondition_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FComboCondition value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ComboCondition_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ComboCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ComboCondition");
			return;
		}
		EnumMarshaler<EComboConditionType>.ToNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address, ConditionType);
		EnumMarshaler<EBGUUnitState>.ToNative(IntPtr.Add(nativeStruct, UnitState_Offset), 0, UnitState_PropertyAddress.Address, UnitState);
		EnumMarshaler<EBGUSimpleState>.ToNative(IntPtr.Add(nativeStruct, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address, SimpleState);
		EnumMarshaler<EBGUAttrFloat>.ToNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address, AttrFloatType);
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address, CompareOperation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CompareValue_Offset), CompareValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffId_Offset), BuffId);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TalentId_Offset), TalentId);
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, ComparePotentialEnergyOperation_Offset), 0, ComparePotentialEnergyOperation_PropertyAddress.Address, ComparePotentialEnergyOperation);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PotentialEnergyLevel_Offset), PotentialEnergyLevel);
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, CompareChargeOperation_Offset), 0, CompareChargeOperation_PropertyAddress.Address, CompareChargeOperation);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ChargeLevel_Offset), ChargeLevel);
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, CompareCeilingHeightOperation_Offset), 0, CompareCeilingHeightOperation_PropertyAddress.Address, CompareCeilingHeightOperation);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CeilingHeight_Offset), CeilingHeight);
		EnumMarshaler<EStanceType_Combo>.ToNative(IntPtr.Add(nativeStruct, StanceType_Offset), 0, StanceType_PropertyAddress.Address, StanceType);
		new TArrayCopyMarshaler<int>(1, SkillIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SkillIDList_Offset), SkillIDList);
		EnumMarshaler<EBGUMoveMode>.ToNative(IntPtr.Add(nativeStruct, MoveMode_Offset), 0, MoveMode_PropertyAddress.Address, MoveMode);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ConditionIdentity_Offset), ConditionIdentity);
	}

	public FComboCondition(IntPtr nativeStruct)
	{
		if (ComboCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ComboCondition");
			ConditionType = EComboConditionType.None;
			UnitState = EBGUUnitState.None;
			SimpleState = EBGUSimpleState.Normal;
			AttrFloatType = EBGUAttrFloat.None;
			CompareOperation = EValueCompareOperations.EqualTo;
			CompareValue = 0f;
			BuffId = 0;
			TalentId = 0;
			ComparePotentialEnergyOperation = EValueCompareOperations.EqualTo;
			PotentialEnergyLevel = 0;
			CompareChargeOperation = EValueCompareOperations.EqualTo;
			ChargeLevel = 0;
			CompareCeilingHeightOperation = EValueCompareOperations.EqualTo;
			CeilingHeight = 0;
			StanceType = EStanceType_Combo.Heavy;
			SkillIDList = null;
			MoveMode = EBGUMoveMode.None;
			ConditionIdentity = null;
		}
		else
		{
			ConditionType = EnumMarshaler<EComboConditionType>.FromNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address);
			UnitState = EnumMarshaler<EBGUUnitState>.FromNative(IntPtr.Add(nativeStruct, UnitState_Offset), 0, UnitState_PropertyAddress.Address);
			SimpleState = EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(nativeStruct, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address);
			AttrFloatType = EnumMarshaler<EBGUAttrFloat>.FromNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address);
			CompareOperation = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address);
			CompareValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CompareValue_Offset));
			BuffId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffId_Offset));
			TalentId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TalentId_Offset));
			ComparePotentialEnergyOperation = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, ComparePotentialEnergyOperation_Offset), 0, ComparePotentialEnergyOperation_PropertyAddress.Address);
			PotentialEnergyLevel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PotentialEnergyLevel_Offset));
			CompareChargeOperation = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, CompareChargeOperation_Offset), 0, CompareChargeOperation_PropertyAddress.Address);
			ChargeLevel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ChargeLevel_Offset));
			CompareCeilingHeightOperation = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, CompareCeilingHeightOperation_Offset), 0, CompareCeilingHeightOperation_PropertyAddress.Address);
			CeilingHeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CeilingHeight_Offset));
			StanceType = EnumMarshaler<EStanceType_Combo>.FromNative(IntPtr.Add(nativeStruct, StanceType_Offset), 0, StanceType_PropertyAddress.Address);
			SkillIDList = new TArrayCopyMarshaler<int>(1, SkillIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SkillIDList_Offset));
			MoveMode = EnumMarshaler<EBGUMoveMode>.FromNative(IntPtr.Add(nativeStruct, MoveMode_Offset), 0, MoveMode_PropertyAddress.Address);
			ConditionIdentity = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ConditionIdentity_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ComboCondition");
		ComboCondition_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ConditionType_PropertyAddress, intPtr, "ConditionType");
		ConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionType");
		ConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref UnitState_PropertyAddress, intPtr, "UnitState");
		UnitState_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitState");
		UnitState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SimpleState_PropertyAddress, intPtr, "SimpleState");
		SimpleState_Offset = NativeReflection.GetPropertyOffset(intPtr, "SimpleState");
		SimpleState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SimpleState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AttrFloatType_PropertyAddress, intPtr, "AttrFloatType");
		AttrFloatType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttrFloatType");
		AttrFloatType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttrFloatType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CompareOperation_PropertyAddress, intPtr, "CompareOperation");
		CompareOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperation");
		CompareOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperation", Classes.FEnumProperty);
		CompareValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareValue");
		CompareValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareValue", Classes.FFloatProperty);
		BuffId_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffId");
		BuffId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffId", Classes.FIntProperty);
		TalentId_Offset = NativeReflection.GetPropertyOffset(intPtr, "TalentId");
		TalentId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TalentId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ComparePotentialEnergyOperation_PropertyAddress, intPtr, "ComparePotentialEnergyOperation");
		ComparePotentialEnergyOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "ComparePotentialEnergyOperation");
		ComparePotentialEnergyOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ComparePotentialEnergyOperation", Classes.FEnumProperty);
		PotentialEnergyLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "PotentialEnergyLevel");
		PotentialEnergyLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PotentialEnergyLevel", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CompareChargeOperation_PropertyAddress, intPtr, "CompareChargeOperation");
		CompareChargeOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareChargeOperation");
		CompareChargeOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareChargeOperation", Classes.FEnumProperty);
		ChargeLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChargeLevel");
		ChargeLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChargeLevel", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CompareCeilingHeightOperation_PropertyAddress, intPtr, "CompareCeilingHeightOperation");
		CompareCeilingHeightOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareCeilingHeightOperation");
		CompareCeilingHeightOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareCeilingHeightOperation", Classes.FEnumProperty);
		CeilingHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "CeilingHeight");
		CeilingHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CeilingHeight", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref StanceType_PropertyAddress, intPtr, "StanceType");
		StanceType_Offset = NativeReflection.GetPropertyOffset(intPtr, "StanceType");
		StanceType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StanceType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SkillIDList_PropertyAddress, intPtr, "SkillIDList");
		SkillIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillIDList");
		SkillIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillIDList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref MoveMode_PropertyAddress, intPtr, "MoveMode");
		MoveMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveMode");
		MoveMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveMode", Classes.FEnumProperty);
		ConditionIdentity_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionIdentity");
		ConditionIdentity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionIdentity", Classes.FStrProperty);
		ComboCondition_IsValid = ((intPtr != IntPtr.Zero && ConditionType_IsValid && UnitState_IsValid && SimpleState_IsValid && AttrFloatType_IsValid && CompareOperation_IsValid && CompareValue_IsValid && BuffId_IsValid && TalentId_IsValid && ComparePotentialEnergyOperation_IsValid && PotentialEnergyLevel_IsValid && CompareChargeOperation_IsValid && ChargeLevel_IsValid && CompareCeilingHeightOperation_IsValid && CeilingHeight_IsValid && StanceType_IsValid && SkillIDList_IsValid && MoveMode_IsValid && ConditionIdentity_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ComboCondition", (byte)ComboCondition_IsValid != 0);
	}

	static FComboCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FComboCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FComboCondition));
	}
}
