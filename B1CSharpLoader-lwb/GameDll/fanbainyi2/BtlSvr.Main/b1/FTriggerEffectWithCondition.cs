using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TriggerEffectWithCondition")]
public struct FTriggerEffectWithCondition
{
	[EditAnywhere]
	[DisplayName("条件列表")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TriggerEffectWithCondition:UnitType")]
	public EDetectedUnitType UnitType;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("条件列表")]
	[USharpPath("/Script/b1-Managed.TriggerEffectWithCondition:Conditions")]
	public List<FDetectCondition> Conditions;

	[DisplayName("条件逻辑关系")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TriggerEffectWithCondition:ConditionalRelation")]
	public EConditionalRelation ConditionalRelation;

	[DisplayName("是否反转条件")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TriggerEffectWithCondition:IsReverseCondition")]
	public bool IsReverseCondition;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("效果列表")]
	[USharpPath("/Script/b1-Managed.TriggerEffectWithCondition:EffectIDList")]
	public List<int> EffectIDList;

	private static int TriggerEffectWithCondition_StructSize;

	private static int TriggerEffectWithCondition_IsValid;

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

	private static bool EffectIDList_IsValid;

	private static int EffectIDList_Offset;

	private static FFieldAddress EffectIDList_PropertyAddress;

	public FTriggerEffectWithCondition Copy()
	{
		FTriggerEffectWithCondition result = this;
		if (Conditions != null)
		{
			result.Conditions = new List<FDetectCondition>(Conditions);
		}
		if (EffectIDList != null)
		{
			result.EffectIDList = new List<int>(EffectIDList);
		}
		return result;
	}

	public static FTriggerEffectWithCondition FromNative(IntPtr nativeBuffer)
	{
		return new FTriggerEffectWithCondition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTriggerEffectWithCondition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTriggerEffectWithCondition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTriggerEffectWithCondition(IntPtr.Add(nativeBuffer, arrayIndex * TriggerEffectWithCondition_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTriggerEffectWithCondition value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TriggerEffectWithCondition_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TriggerEffectWithCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TriggerEffectWithCondition");
			return;
		}
		EnumMarshaler<EDetectedUnitType>.ToNative(IntPtr.Add(nativeStruct, UnitType_Offset), 0, UnitType_PropertyAddress.Address, UnitType);
		new TArrayCopyMarshaler<FDetectCondition>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.FromNative, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.ToNative).ToNative(IntPtr.Add(nativeStruct, Conditions_Offset), Conditions);
		EnumMarshaler<EConditionalRelation>.ToNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address, ConditionalRelation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsReverseCondition_Offset), 0, IsReverseCondition_PropertyAddress.Address, IsReverseCondition);
		new TArrayCopyMarshaler<int>(1, EffectIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, EffectIDList_Offset), EffectIDList);
	}

	public FTriggerEffectWithCondition(IntPtr nativeStruct)
	{
		if (TriggerEffectWithCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TriggerEffectWithCondition");
			UnitType = EDetectedUnitType.Self;
			Conditions = null;
			ConditionalRelation = EConditionalRelation.And;
			IsReverseCondition = false;
			EffectIDList = null;
		}
		else
		{
			UnitType = EnumMarshaler<EDetectedUnitType>.FromNative(IntPtr.Add(nativeStruct, UnitType_Offset), 0, UnitType_PropertyAddress.Address);
			Conditions = new TArrayCopyMarshaler<FDetectCondition>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.FromNative, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.ToNative).FromNative(IntPtr.Add(nativeStruct, Conditions_Offset));
			ConditionalRelation = EnumMarshaler<EConditionalRelation>.FromNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address);
			IsReverseCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsReverseCondition_Offset), 0, IsReverseCondition_PropertyAddress.Address);
			EffectIDList = new TArrayCopyMarshaler<int>(1, EffectIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, EffectIDList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TriggerEffectWithCondition");
		TriggerEffectWithCondition_StructSize = NativeReflection.GetStructSize(intPtr);
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
		NativeReflection.GetPropertyRef(ref EffectIDList_PropertyAddress, intPtr, "EffectIDList");
		EffectIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectIDList");
		EffectIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectIDList", Classes.FArrayProperty);
		TriggerEffectWithCondition_IsValid = ((intPtr != IntPtr.Zero && UnitType_IsValid && Conditions_IsValid && ConditionalRelation_IsValid && IsReverseCondition_IsValid && EffectIDList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TriggerEffectWithCondition", (byte)TriggerEffectWithCondition_IsValid != 0);
	}

	static FTriggerEffectWithCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTriggerEffectWithCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTriggerEffectWithCondition));
	}
}
