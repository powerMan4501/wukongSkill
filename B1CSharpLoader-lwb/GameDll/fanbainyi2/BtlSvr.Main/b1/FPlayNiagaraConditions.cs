using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.PlayNiagaraConditions")]
public struct FPlayNiagaraConditions
{
	[DisplayName("条件列表")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PlayNiagaraConditions:UnitType")]
	public EDetectedUnitType UnitType;

	[DisplayName("条件列表")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PlayNiagaraConditions:Conditions")]
	public List<FDetectCondition> Conditions;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("条件逻辑关系")]
	[USharpPath("/Script/b1-Managed.PlayNiagaraConditions:ConditionalRelation")]
	public EConditionalRelation ConditionalRelation;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否反转条件")]
	[USharpPath("/Script/b1-Managed.PlayNiagaraConditions:IsReverseCondition")]
	public bool IsReverseCondition;

	[DisplayName("调试中查看效果")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PlayNiagaraConditions:bForDebug")]
	public bool bForDebug;

	private static int PlayNiagaraConditions_StructSize;

	private static int PlayNiagaraConditions_IsValid;

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

	private static bool bForDebug_IsValid;

	private static int bForDebug_Offset;

	private static FFieldAddress bForDebug_PropertyAddress;

	public FPlayNiagaraConditions Copy()
	{
		FPlayNiagaraConditions result = this;
		if (Conditions != null)
		{
			result.Conditions = new List<FDetectCondition>(Conditions);
		}
		return result;
	}

	public static FPlayNiagaraConditions FromNative(IntPtr nativeBuffer)
	{
		return new FPlayNiagaraConditions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPlayNiagaraConditions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPlayNiagaraConditions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPlayNiagaraConditions(IntPtr.Add(nativeBuffer, arrayIndex * PlayNiagaraConditions_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPlayNiagaraConditions value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PlayNiagaraConditions_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PlayNiagaraConditions_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PlayNiagaraConditions");
			return;
		}
		EnumMarshaler<EDetectedUnitType>.ToNative(IntPtr.Add(nativeStruct, UnitType_Offset), 0, UnitType_PropertyAddress.Address, UnitType);
		new TArrayCopyMarshaler<FDetectCondition>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.FromNative, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.ToNative).ToNative(IntPtr.Add(nativeStruct, Conditions_Offset), Conditions);
		EnumMarshaler<EConditionalRelation>.ToNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address, ConditionalRelation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsReverseCondition_Offset), 0, IsReverseCondition_PropertyAddress.Address, IsReverseCondition);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bForDebug_Offset), 0, bForDebug_PropertyAddress.Address, bForDebug);
	}

	public FPlayNiagaraConditions(IntPtr nativeStruct)
	{
		if (PlayNiagaraConditions_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PlayNiagaraConditions");
			UnitType = EDetectedUnitType.Self;
			Conditions = null;
			ConditionalRelation = EConditionalRelation.And;
			IsReverseCondition = false;
			bForDebug = false;
		}
		else
		{
			UnitType = EnumMarshaler<EDetectedUnitType>.FromNative(IntPtr.Add(nativeStruct, UnitType_Offset), 0, UnitType_PropertyAddress.Address);
			Conditions = new TArrayCopyMarshaler<FDetectCondition>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.FromNative, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.ToNative).FromNative(IntPtr.Add(nativeStruct, Conditions_Offset));
			ConditionalRelation = EnumMarshaler<EConditionalRelation>.FromNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address);
			IsReverseCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsReverseCondition_Offset), 0, IsReverseCondition_PropertyAddress.Address);
			bForDebug = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bForDebug_Offset), 0, bForDebug_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PlayNiagaraConditions");
		PlayNiagaraConditions_StructSize = NativeReflection.GetStructSize(intPtr);
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
		NativeReflection.GetPropertyRef(ref bForDebug_PropertyAddress, intPtr, "bForDebug");
		bForDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "bForDebug");
		bForDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bForDebug", Classes.FBoolProperty);
		PlayNiagaraConditions_IsValid = ((intPtr != IntPtr.Zero && UnitType_IsValid && Conditions_IsValid && ConditionalRelation_IsValid && IsReverseCondition_IsValid && bForDebug_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PlayNiagaraConditions", (byte)PlayNiagaraConditions_IsValid != 0);
	}

	static FPlayNiagaraConditions()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPlayNiagaraConditions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPlayNiagaraConditions));
	}
}
