using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TrainDummySpecialDamageTypeConfig")]
public struct FTrainDummySpecialDamageTypeConfig
{
	[DisplayName("伤害类型描述")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TrainDummySpecialDamageTypeConfig:Describe")]
	public string Describe;

	[BlueprintReadWrite]
	[DisplayName("攻击SkillID")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TrainDummySpecialDamageTypeConfig:SkillID")]
	public List<int> SkillID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("攻击方ResID")]
	[USharpPath("/Script/b1-Managed.TrainDummySpecialDamageTypeConfig:AttackerResIdCondition")]
	public List<int> AttackerResIdCondition;

	[EditAnywhere]
	[DisplayName("攻击方SimpleState条件")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TrainDummySpecialDamageTypeConfig:AttackerSimpleStateCondition")]
	public List<EBGUSimpleState> AttackerSimpleStateCondition;

	[DisplayName("攻击方UnitState条件")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TrainDummySpecialDamageTypeConfig:AttackerUnitStateCondition")]
	public List<EBGUUnitState> AttackerUnitStateCondition;

	[DisplayName("受击方SimpleState条件")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TrainDummySpecialDamageTypeConfig:VictimSimpleStateCondition")]
	public List<EBGUSimpleState> VictimSimpleStateCondition;

	[UProperty]
	[DisplayName("受击方UnitState条件")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TrainDummySpecialDamageTypeConfig:VictimUnitStateCondition")]
	public List<EBGUUnitState> VictimUnitStateCondition;

	private static int TrainDummySpecialDamageTypeConfig_StructSize;

	private static int TrainDummySpecialDamageTypeConfig_IsValid;

	private static bool Describe_IsValid;

	private static int Describe_Offset;

	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	private static FFieldAddress SkillID_PropertyAddress;

	private static bool AttackerResIdCondition_IsValid;

	private static int AttackerResIdCondition_Offset;

	private static FFieldAddress AttackerResIdCondition_PropertyAddress;

	private static bool AttackerSimpleStateCondition_IsValid;

	private static int AttackerSimpleStateCondition_Offset;

	private static FFieldAddress AttackerSimpleStateCondition_PropertyAddress;

	private static bool AttackerUnitStateCondition_IsValid;

	private static int AttackerUnitStateCondition_Offset;

	private static FFieldAddress AttackerUnitStateCondition_PropertyAddress;

	private static bool VictimSimpleStateCondition_IsValid;

	private static int VictimSimpleStateCondition_Offset;

	private static FFieldAddress VictimSimpleStateCondition_PropertyAddress;

	private static bool VictimUnitStateCondition_IsValid;

	private static int VictimUnitStateCondition_Offset;

	private static FFieldAddress VictimUnitStateCondition_PropertyAddress;

	public FTrainDummySpecialDamageTypeConfig Copy()
	{
		FTrainDummySpecialDamageTypeConfig result = this;
		if (SkillID != null)
		{
			result.SkillID = new List<int>(SkillID);
		}
		if (AttackerResIdCondition != null)
		{
			result.AttackerResIdCondition = new List<int>(AttackerResIdCondition);
		}
		if (AttackerSimpleStateCondition != null)
		{
			result.AttackerSimpleStateCondition = new List<EBGUSimpleState>(AttackerSimpleStateCondition);
		}
		if (AttackerUnitStateCondition != null)
		{
			result.AttackerUnitStateCondition = new List<EBGUUnitState>(AttackerUnitStateCondition);
		}
		if (VictimSimpleStateCondition != null)
		{
			result.VictimSimpleStateCondition = new List<EBGUSimpleState>(VictimSimpleStateCondition);
		}
		if (VictimUnitStateCondition != null)
		{
			result.VictimUnitStateCondition = new List<EBGUUnitState>(VictimUnitStateCondition);
		}
		return result;
	}

	public static FTrainDummySpecialDamageTypeConfig FromNative(IntPtr nativeBuffer)
	{
		return new FTrainDummySpecialDamageTypeConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTrainDummySpecialDamageTypeConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTrainDummySpecialDamageTypeConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTrainDummySpecialDamageTypeConfig(IntPtr.Add(nativeBuffer, arrayIndex * TrainDummySpecialDamageTypeConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTrainDummySpecialDamageTypeConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TrainDummySpecialDamageTypeConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TrainDummySpecialDamageTypeConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TrainDummySpecialDamageTypeConfig");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Describe_Offset), Describe);
		new TArrayCopyMarshaler<int>(1, SkillID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SkillID_Offset), SkillID);
		new TArrayCopyMarshaler<int>(1, AttackerResIdCondition_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AttackerResIdCondition_Offset), AttackerResIdCondition);
		new TArrayCopyMarshaler<EBGUSimpleState>(1, AttackerSimpleStateCondition_PropertyAddress, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.FromNative, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AttackerSimpleStateCondition_Offset), AttackerSimpleStateCondition);
		new TArrayCopyMarshaler<EBGUUnitState>(1, AttackerUnitStateCondition_PropertyAddress, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.FromNative, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AttackerUnitStateCondition_Offset), AttackerUnitStateCondition);
		new TArrayCopyMarshaler<EBGUSimpleState>(1, VictimSimpleStateCondition_PropertyAddress, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.FromNative, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.ToNative).ToNative(IntPtr.Add(nativeStruct, VictimSimpleStateCondition_Offset), VictimSimpleStateCondition);
		new TArrayCopyMarshaler<EBGUUnitState>(1, VictimUnitStateCondition_PropertyAddress, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.FromNative, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.ToNative).ToNative(IntPtr.Add(nativeStruct, VictimUnitStateCondition_Offset), VictimUnitStateCondition);
	}

	public FTrainDummySpecialDamageTypeConfig(IntPtr nativeStruct)
	{
		if (TrainDummySpecialDamageTypeConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TrainDummySpecialDamageTypeConfig");
			Describe = null;
			SkillID = null;
			AttackerResIdCondition = null;
			AttackerSimpleStateCondition = null;
			AttackerUnitStateCondition = null;
			VictimSimpleStateCondition = null;
			VictimUnitStateCondition = null;
		}
		else
		{
			Describe = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Describe_Offset));
			SkillID = new TArrayCopyMarshaler<int>(1, SkillID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SkillID_Offset));
			AttackerResIdCondition = new TArrayCopyMarshaler<int>(1, AttackerResIdCondition_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AttackerResIdCondition_Offset));
			AttackerSimpleStateCondition = new TArrayCopyMarshaler<EBGUSimpleState>(1, AttackerSimpleStateCondition_PropertyAddress, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.FromNative, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AttackerSimpleStateCondition_Offset));
			AttackerUnitStateCondition = new TArrayCopyMarshaler<EBGUUnitState>(1, AttackerUnitStateCondition_PropertyAddress, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.FromNative, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AttackerUnitStateCondition_Offset));
			VictimSimpleStateCondition = new TArrayCopyMarshaler<EBGUSimpleState>(1, VictimSimpleStateCondition_PropertyAddress, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.FromNative, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.ToNative).FromNative(IntPtr.Add(nativeStruct, VictimSimpleStateCondition_Offset));
			VictimUnitStateCondition = new TArrayCopyMarshaler<EBGUUnitState>(1, VictimUnitStateCondition_PropertyAddress, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.FromNative, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.ToNative).FromNative(IntPtr.Add(nativeStruct, VictimUnitStateCondition_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TrainDummySpecialDamageTypeConfig");
		TrainDummySpecialDamageTypeConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Describe_Offset = NativeReflection.GetPropertyOffset(intPtr, "Describe");
		Describe_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Describe", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref SkillID_PropertyAddress, intPtr, "SkillID");
		SkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillID", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AttackerResIdCondition_PropertyAddress, intPtr, "AttackerResIdCondition");
		AttackerResIdCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackerResIdCondition");
		AttackerResIdCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackerResIdCondition", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AttackerSimpleStateCondition_PropertyAddress, intPtr, "AttackerSimpleStateCondition");
		AttackerSimpleStateCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackerSimpleStateCondition");
		AttackerSimpleStateCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackerSimpleStateCondition", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AttackerUnitStateCondition_PropertyAddress, intPtr, "AttackerUnitStateCondition");
		AttackerUnitStateCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackerUnitStateCondition");
		AttackerUnitStateCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackerUnitStateCondition", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref VictimSimpleStateCondition_PropertyAddress, intPtr, "VictimSimpleStateCondition");
		VictimSimpleStateCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "VictimSimpleStateCondition");
		VictimSimpleStateCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VictimSimpleStateCondition", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref VictimUnitStateCondition_PropertyAddress, intPtr, "VictimUnitStateCondition");
		VictimUnitStateCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "VictimUnitStateCondition");
		VictimUnitStateCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VictimUnitStateCondition", Classes.FArrayProperty);
		TrainDummySpecialDamageTypeConfig_IsValid = ((intPtr != IntPtr.Zero && Describe_IsValid && SkillID_IsValid && AttackerResIdCondition_IsValid && AttackerSimpleStateCondition_IsValid && AttackerUnitStateCondition_IsValid && VictimSimpleStateCondition_IsValid && VictimUnitStateCondition_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TrainDummySpecialDamageTypeConfig", (byte)TrainDummySpecialDamageTypeConfig_IsValid != 0);
	}

	static FTrainDummySpecialDamageTypeConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTrainDummySpecialDamageTypeConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTrainDummySpecialDamageTypeConfig));
	}
}
