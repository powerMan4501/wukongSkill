using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FBGMVolumeCondition")]
public struct FBGMVolumeCondition
{
	[BlueprintReadWrite]
	[DisplayName("条件")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FBGMVolumeCondition:Condition")]
	public EBGMVolumeConditionType Condition;

	[DisplayName("反转条件")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FBGMVolumeCondition:InverseCondition")]
	public bool InverseCondition;

	[UProperty]
	[EditAnywhere]
	[DisplayName("被检测单位")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FBGMVolumeCondition:Actors")]
	public List<FGsActorGuidReference> Actors;

	[UProperty]
	[DisplayName("所需满足数量")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FBGMVolumeCondition:ConditionSusCountType")]
	public EBGMVolumeConditionSusCountType ConditionSusCountType;

	private static int FBGMVolumeCondition_StructSize;

	private static int FBGMVolumeCondition_IsValid;

	private static bool Condition_IsValid;

	private static int Condition_Offset;

	private static FFieldAddress Condition_PropertyAddress;

	private static bool InverseCondition_IsValid;

	private static int InverseCondition_Offset;

	private static FFieldAddress InverseCondition_PropertyAddress;

	private static bool Actors_IsValid;

	private static int Actors_Offset;

	private static FFieldAddress Actors_PropertyAddress;

	private static bool ConditionSusCountType_IsValid;

	private static int ConditionSusCountType_Offset;

	private static FFieldAddress ConditionSusCountType_PropertyAddress;

	public FBGMVolumeCondition Copy()
	{
		FBGMVolumeCondition result = this;
		if (Actors != null)
		{
			result.Actors = new List<FGsActorGuidReference>(Actors);
		}
		return result;
	}

	public static FBGMVolumeCondition FromNative(IntPtr nativeBuffer)
	{
		return new FBGMVolumeCondition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBGMVolumeCondition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBGMVolumeCondition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBGMVolumeCondition(IntPtr.Add(nativeBuffer, arrayIndex * FBGMVolumeCondition_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBGMVolumeCondition value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FBGMVolumeCondition_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FBGMVolumeCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FBGMVolumeCondition");
			return;
		}
		EnumMarshaler<EBGMVolumeConditionType>.ToNative(IntPtr.Add(nativeStruct, Condition_Offset), 0, Condition_PropertyAddress.Address, Condition);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, InverseCondition_Offset), 0, InverseCondition_PropertyAddress.Address, InverseCondition);
		new TArrayCopyMarshaler<FGsActorGuidReference>(1, Actors_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).ToNative(IntPtr.Add(nativeStruct, Actors_Offset), Actors);
		EnumMarshaler<EBGMVolumeConditionSusCountType>.ToNative(IntPtr.Add(nativeStruct, ConditionSusCountType_Offset), 0, ConditionSusCountType_PropertyAddress.Address, ConditionSusCountType);
	}

	public FBGMVolumeCondition(IntPtr nativeStruct)
	{
		if (FBGMVolumeCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FBGMVolumeCondition");
			Condition = EBGMVolumeConditionType.None;
			InverseCondition = false;
			Actors = null;
			ConditionSusCountType = EBGMVolumeConditionSusCountType.Once;
		}
		else
		{
			Condition = EnumMarshaler<EBGMVolumeConditionType>.FromNative(IntPtr.Add(nativeStruct, Condition_Offset), 0, Condition_PropertyAddress.Address);
			InverseCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, InverseCondition_Offset), 0, InverseCondition_PropertyAddress.Address);
			Actors = new TArrayCopyMarshaler<FGsActorGuidReference>(1, Actors_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).FromNative(IntPtr.Add(nativeStruct, Actors_Offset));
			ConditionSusCountType = EnumMarshaler<EBGMVolumeConditionSusCountType>.FromNative(IntPtr.Add(nativeStruct, ConditionSusCountType_Offset), 0, ConditionSusCountType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FBGMVolumeCondition");
		FBGMVolumeCondition_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Condition_PropertyAddress, intPtr, "Condition");
		Condition_Offset = NativeReflection.GetPropertyOffset(intPtr, "Condition");
		Condition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Condition", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref InverseCondition_PropertyAddress, intPtr, "InverseCondition");
		InverseCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "InverseCondition");
		InverseCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InverseCondition", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Actors_PropertyAddress, intPtr, "Actors");
		Actors_Offset = NativeReflection.GetPropertyOffset(intPtr, "Actors");
		Actors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Actors", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ConditionSusCountType_PropertyAddress, intPtr, "ConditionSusCountType");
		ConditionSusCountType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionSusCountType");
		ConditionSusCountType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionSusCountType", Classes.FEnumProperty);
		FBGMVolumeCondition_IsValid = ((intPtr != IntPtr.Zero && Condition_IsValid && InverseCondition_IsValid && Actors_IsValid && ConditionSusCountType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FBGMVolumeCondition", (byte)FBGMVolumeCondition_IsValid != 0);
	}

	static FBGMVolumeCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBGMVolumeCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBGMVolumeCondition));
	}
}
