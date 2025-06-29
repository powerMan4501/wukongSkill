using System;
using b1.Plugins.Calliope;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ObserveActorInfo")]
public struct FObserveActorInfo
{
	[UProperty]
	[Tooltip("监视条件")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ObserveActorInfo:ConditionType")]
	public EObserveConditionType ConditionType;

	[DisplayName("观察对象")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ObserveActorInfo:ObservedPlayerOrUnitOrActor")]
	public FGsSmartParam ObservedPlayerOrUnitOrActor;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ObserveActorInfo:UnitState")]
	public EBGUUnitState UnitState;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ObserveActorInfo:SimpleState")]
	public EBGUSimpleState SimpleState;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ObserveActorInfo:AttrFloatType")]
	public EBGUAttrFloat AttrFloatType;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ObserveActorInfo:CompareOperation")]
	public EValueCompareOperations CompareOperation;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ObserveActorInfo:CompareValue")]
	public float CompareValue;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ObserveActorInfo:Buff")]
	public FGsSmartParam Buff;

	private static int ObserveActorInfo_StructSize;

	private static int ObserveActorInfo_IsValid;

	private static bool ConditionType_IsValid;

	private static int ConditionType_Offset;

	private static FFieldAddress ConditionType_PropertyAddress;

	private static bool ObservedPlayerOrUnitOrActor_IsValid;

	private static int ObservedPlayerOrUnitOrActor_Offset;

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

	private static bool Buff_IsValid;

	private static int Buff_Offset;

	public FObserveActorInfo Copy()
	{
		return this;
	}

	public static FObserveActorInfo FromNative(IntPtr nativeBuffer)
	{
		return new FObserveActorInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FObserveActorInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FObserveActorInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FObserveActorInfo(IntPtr.Add(nativeBuffer, arrayIndex * ObserveActorInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FObserveActorInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ObserveActorInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ObserveActorInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ObserveActorInfo");
			return;
		}
		EnumMarshaler<EObserveConditionType>.ToNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address, ConditionType);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, ObservedPlayerOrUnitOrActor_Offset), ObservedPlayerOrUnitOrActor);
		EnumMarshaler<EBGUUnitState>.ToNative(IntPtr.Add(nativeStruct, UnitState_Offset), 0, UnitState_PropertyAddress.Address, UnitState);
		EnumMarshaler<EBGUSimpleState>.ToNative(IntPtr.Add(nativeStruct, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address, SimpleState);
		EnumMarshaler<EBGUAttrFloat>.ToNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address, AttrFloatType);
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address, CompareOperation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CompareValue_Offset), CompareValue);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Buff_Offset), Buff);
	}

	public FObserveActorInfo(IntPtr nativeStruct)
	{
		if (ObserveActorInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ObserveActorInfo");
			ConditionType = EObserveConditionType.None;
			ObservedPlayerOrUnitOrActor = default(FGsSmartParam);
			UnitState = EBGUUnitState.None;
			SimpleState = EBGUSimpleState.Normal;
			AttrFloatType = EBGUAttrFloat.None;
			CompareOperation = EValueCompareOperations.EqualTo;
			CompareValue = 0f;
			Buff = default(FGsSmartParam);
		}
		else
		{
			ConditionType = EnumMarshaler<EObserveConditionType>.FromNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address);
			ObservedPlayerOrUnitOrActor = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, ObservedPlayerOrUnitOrActor_Offset));
			UnitState = EnumMarshaler<EBGUUnitState>.FromNative(IntPtr.Add(nativeStruct, UnitState_Offset), 0, UnitState_PropertyAddress.Address);
			SimpleState = EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(nativeStruct, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address);
			AttrFloatType = EnumMarshaler<EBGUAttrFloat>.FromNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address);
			CompareOperation = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address);
			CompareValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CompareValue_Offset));
			Buff = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Buff_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ObserveActorInfo");
		ObserveActorInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ConditionType_PropertyAddress, intPtr, "ConditionType");
		ConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionType");
		ConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionType", Classes.FEnumProperty);
		ObservedPlayerOrUnitOrActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObservedPlayerOrUnitOrActor");
		ObservedPlayerOrUnitOrActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObservedPlayerOrUnitOrActor", Classes.FStructProperty);
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
		Buff_Offset = NativeReflection.GetPropertyOffset(intPtr, "Buff");
		Buff_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Buff", Classes.FStructProperty);
		ObserveActorInfo_IsValid = ((intPtr != IntPtr.Zero && ConditionType_IsValid && ObservedPlayerOrUnitOrActor_IsValid && UnitState_IsValid && SimpleState_IsValid && AttrFloatType_IsValid && CompareOperation_IsValid && CompareValue_IsValid && Buff_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ObserveActorInfo", (byte)ObserveActorInfo_IsValid != 0);
	}

	static FObserveActorInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FObserveActorInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FObserveActorInfo));
	}
}
