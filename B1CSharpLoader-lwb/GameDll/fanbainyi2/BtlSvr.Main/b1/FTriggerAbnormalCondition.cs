using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TriggerAbnormalCondition")]
public struct FTriggerAbnormalCondition
{
	[DisplayName("条件列表")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TriggerAbnormalCondition:UnitType")]
	public EDetectedUnitType UnitType;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("条件列表")]
	[USharpPath("/Script/b1-Managed.TriggerAbnormalCondition:Conditions")]
	public List<FDetectCondition> Conditions;

	[UProperty]
	[EditAnywhere]
	[DisplayName("条件逻辑关系")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TriggerAbnormalCondition:ConditionalRelation")]
	public EConditionalRelation ConditionalRelation;

	[DisplayName("是否反转条件")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TriggerAbnormalCondition:IsReverseCondition")]
	public bool IsReverseCondition;

	private static int TriggerAbnormalCondition_StructSize;

	private static int TriggerAbnormalCondition_IsValid;

	private static bool UnitType_IsValid;

	private static int UnitType_Offset;

	private static FFieldAddress UnitType_PropertyAddress;

	private static bool Conditions_IsValid;

	private static int Conditions_Offset;

	private static FFieldAddress Conditions_PropertyAddress;

	private static bool ConditionalRelation_IsValid;

	private static int ConditionalRelation_Offset;

	private static FFieldAddress ConditionalRelation_PropertyAddress;

	private static bool IsReverseCondition_IsValid;

	private static int IsReverseCondition_Offset;

	private static FFieldAddress IsReverseCondition_PropertyAddress;

	public FTriggerAbnormalCondition Copy()
	{
		FTriggerAbnormalCondition result = this;
		if (Conditions != null)
		{
			result.Conditions = new List<FDetectCondition>(Conditions);
		}
		return result;
	}

	public static FTriggerAbnormalCondition FromNative(IntPtr nativeBuffer)
	{
		return new FTriggerAbnormalCondition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTriggerAbnormalCondition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTriggerAbnormalCondition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTriggerAbnormalCondition(IntPtr.Add(nativeBuffer, arrayIndex * TriggerAbnormalCondition_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTriggerAbnormalCondition value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TriggerAbnormalCondition_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TriggerAbnormalCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TriggerAbnormalCondition");
			return;
		}
		EnumMarshaler<EDetectedUnitType>.ToNative(IntPtr.Add(nativeStruct, UnitType_Offset), 0, UnitType_PropertyAddress.Address, UnitType);
		new TArrayCopyMarshaler<FDetectCondition>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.FromNative, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.ToNative).ToNative(IntPtr.Add(nativeStruct, Conditions_Offset), Conditions);
		EnumMarshaler<EConditionalRelation>.ToNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address, ConditionalRelation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsReverseCondition_Offset), 0, IsReverseCondition_PropertyAddress.Address, IsReverseCondition);
	}

	public FTriggerAbnormalCondition(IntPtr nativeStruct)
	{
		if (TriggerAbnormalCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TriggerAbnormalCondition");
			UnitType = EDetectedUnitType.Self;
			Conditions = null;
			ConditionalRelation = EConditionalRelation.And;
			IsReverseCondition = false;
		}
		else
		{
			UnitType = EnumMarshaler<EDetectedUnitType>.FromNative(IntPtr.Add(nativeStruct, UnitType_Offset), 0, UnitType_PropertyAddress.Address);
			Conditions = new TArrayCopyMarshaler<FDetectCondition>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.FromNative, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.ToNative).FromNative(IntPtr.Add(nativeStruct, Conditions_Offset));
			ConditionalRelation = EnumMarshaler<EConditionalRelation>.FromNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address);
			IsReverseCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsReverseCondition_Offset), 0, IsReverseCondition_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TriggerAbnormalCondition");
		TriggerAbnormalCondition_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref UnitType_PropertyAddress, intPtr, "UnitType");
		UnitType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitType");
		UnitType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref Conditions_PropertyAddress, intPtr, "Conditions");
		Conditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "Conditions");
		Conditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Conditions", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ConditionalRelation_PropertyAddress, intPtr, "ConditionalRelation");
		ConditionalRelation_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionalRelation");
		ConditionalRelation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionalRelation", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsReverseCondition_PropertyAddress, intPtr, "IsReverseCondition");
		IsReverseCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsReverseCondition");
		IsReverseCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsReverseCondition", Classes.FBoolProperty);
		TriggerAbnormalCondition_IsValid = ((intPtr != IntPtr.Zero && UnitType_IsValid && Conditions_IsValid && ConditionalRelation_IsValid && IsReverseCondition_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TriggerAbnormalCondition", (byte)TriggerAbnormalCondition_IsValid != 0);
	}

	static FTriggerAbnormalCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTriggerAbnormalCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTriggerAbnormalCondition));
	}
}
