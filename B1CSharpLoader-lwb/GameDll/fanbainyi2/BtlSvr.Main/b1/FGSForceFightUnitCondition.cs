using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSForceFightUnitCondition")]
public struct FGSForceFightUnitCondition
{
	[DisplayName("需要检测的单位")]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[Tooltip("需要检测的所有单位列表")]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitCondition:ObservedUnits")]
	public List<BGUCharacterCS> ObservedUnits;

	[VisibleAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("需要检测的所有单位列表")]
	[DisplayName("需要检测的单位")]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitCondition:ObservedTamers")]
	public List<BUTamerActor> ObservedTamers;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("需要检测的单位")]
	[Tooltip("需要检测的所有单位列表")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitCondition:ObservedTamerRefs")]
	public List<FGsActorGuidReference> ObservedTamerRefs;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("检测单位UnitState")]
	[Tooltip("是否检测单位当前是否拥有所指定的UnitState")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitCondition:ObserveHasUnitState")]
	public bool ObserveHasUnitState;

	[DisplayName("需要检测的UnitState")]
	[UMeta(MDProp.EditCondition, "ObserveHasUnitState")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitCondition:ObserveUnitStates")]
	public List<EBGUUnitState> ObserveUnitStates;

	[UProperty]
	[EditAnywhere]
	[DisplayName("检测单位SimpleState")]
	[BlueprintReadWrite]
	[Tooltip("是否检测单位当前是否拥有所指定的SimpleState")]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitCondition:ObserveHasSimpleState")]
	public bool ObserveHasSimpleState;

	[BlueprintReadWrite]
	[DisplayName("需要检测的SimpleState")]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "ObserveHasSimpleState")]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitCondition:ObserveSimpleStates")]
	public List<EBGUSimpleState> ObserveSimpleStates;

	[DisplayName("检测单位Buff")]
	[EditAnywhere]
	[Tooltip("是否检测单位当前是否拥有所指定的Buff")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitCondition:ObserveHasBuff")]
	public bool ObserveHasBuff;

	[DisplayName("需要检测的BuffID")]
	[UMeta(MDProp.EditCondition, "ObserveHasBuff")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSForceFightUnitCondition:ObserveBuffIDs")]
	public List<int> ObserveBuffIDs;

	private static int FGSForceFightUnitCondition_StructSize;

	private static int FGSForceFightUnitCondition_IsValid;

	private static bool ObservedUnits_IsValid;

	private static int ObservedUnits_Offset;

	private static FFieldAddress ObservedUnits_PropertyAddress;

	private static bool ObservedTamers_IsValid;

	private static int ObservedTamers_Offset;

	private static FFieldAddress ObservedTamers_PropertyAddress;

	private static bool ObservedTamerRefs_IsValid;

	private static int ObservedTamerRefs_Offset;

	private static FFieldAddress ObservedTamerRefs_PropertyAddress;

	private static bool ObserveHasUnitState_IsValid;

	private static int ObserveHasUnitState_Offset;

	private static FFieldAddress ObserveHasUnitState_PropertyAddress;

	private static bool ObserveUnitStates_IsValid;

	private static int ObserveUnitStates_Offset;

	private static FFieldAddress ObserveUnitStates_PropertyAddress;

	private static bool ObserveHasSimpleState_IsValid;

	private static int ObserveHasSimpleState_Offset;

	private static FFieldAddress ObserveHasSimpleState_PropertyAddress;

	private static bool ObserveSimpleStates_IsValid;

	private static int ObserveSimpleStates_Offset;

	private static FFieldAddress ObserveSimpleStates_PropertyAddress;

	private static bool ObserveHasBuff_IsValid;

	private static int ObserveHasBuff_Offset;

	private static FFieldAddress ObserveHasBuff_PropertyAddress;

	private static bool ObserveBuffIDs_IsValid;

	private static int ObserveBuffIDs_Offset;

	private static FFieldAddress ObserveBuffIDs_PropertyAddress;

	public FGSForceFightUnitCondition Copy()
	{
		FGSForceFightUnitCondition result = this;
		if (ObservedUnits != null)
		{
			result.ObservedUnits = new List<BGUCharacterCS>(ObservedUnits);
		}
		if (ObservedTamers != null)
		{
			result.ObservedTamers = new List<BUTamerActor>(ObservedTamers);
		}
		if (ObservedTamerRefs != null)
		{
			result.ObservedTamerRefs = new List<FGsActorGuidReference>(ObservedTamerRefs);
		}
		if (ObserveUnitStates != null)
		{
			result.ObserveUnitStates = new List<EBGUUnitState>(ObserveUnitStates);
		}
		if (ObserveSimpleStates != null)
		{
			result.ObserveSimpleStates = new List<EBGUSimpleState>(ObserveSimpleStates);
		}
		if (ObserveBuffIDs != null)
		{
			result.ObserveBuffIDs = new List<int>(ObserveBuffIDs);
		}
		return result;
	}

	public static FGSForceFightUnitCondition FromNative(IntPtr nativeBuffer)
	{
		return new FGSForceFightUnitCondition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSForceFightUnitCondition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSForceFightUnitCondition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSForceFightUnitCondition(IntPtr.Add(nativeBuffer, arrayIndex * FGSForceFightUnitCondition_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSForceFightUnitCondition value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSForceFightUnitCondition_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSForceFightUnitCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSForceFightUnitCondition");
			return;
		}
		new TArrayCopyMarshaler<BGUCharacterCS>(1, ObservedUnits_PropertyAddress, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObservedUnits_Offset), ObservedUnits);
		new TArrayCopyMarshaler<BUTamerActor>(1, ObservedTamers_PropertyAddress, CachedMarshalingDelegates<BUTamerActor, UObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<BUTamerActor, UObjectMarshaler<BUTamerActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObservedTamers_Offset), ObservedTamers);
		new TArrayCopyMarshaler<FGsActorGuidReference>(1, ObservedTamerRefs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObservedTamerRefs_Offset), ObservedTamerRefs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ObserveHasUnitState_Offset), 0, ObserveHasUnitState_PropertyAddress.Address, ObserveHasUnitState);
		new TArrayCopyMarshaler<EBGUUnitState>(1, ObserveUnitStates_PropertyAddress, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.FromNative, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObserveUnitStates_Offset), ObserveUnitStates);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ObserveHasSimpleState_Offset), 0, ObserveHasSimpleState_PropertyAddress.Address, ObserveHasSimpleState);
		new TArrayCopyMarshaler<EBGUSimpleState>(1, ObserveSimpleStates_PropertyAddress, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.FromNative, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObserveSimpleStates_Offset), ObserveSimpleStates);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ObserveHasBuff_Offset), 0, ObserveHasBuff_PropertyAddress.Address, ObserveHasBuff);
		new TArrayCopyMarshaler<int>(1, ObserveBuffIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObserveBuffIDs_Offset), ObserveBuffIDs);
	}

	public FGSForceFightUnitCondition(IntPtr nativeStruct)
	{
		if (FGSForceFightUnitCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSForceFightUnitCondition");
			ObservedUnits = null;
			ObservedTamers = null;
			ObservedTamerRefs = null;
			ObserveHasUnitState = false;
			ObserveUnitStates = null;
			ObserveHasSimpleState = false;
			ObserveSimpleStates = null;
			ObserveHasBuff = false;
			ObserveBuffIDs = null;
		}
		else
		{
			ObservedUnits = new TArrayCopyMarshaler<BGUCharacterCS>(1, ObservedUnits_PropertyAddress, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObservedUnits_Offset));
			ObservedTamers = new TArrayCopyMarshaler<BUTamerActor>(1, ObservedTamers_PropertyAddress, CachedMarshalingDelegates<BUTamerActor, UObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<BUTamerActor, UObjectMarshaler<BUTamerActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObservedTamers_Offset));
			ObservedTamerRefs = new TArrayCopyMarshaler<FGsActorGuidReference>(1, ObservedTamerRefs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObservedTamerRefs_Offset));
			ObserveHasUnitState = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ObserveHasUnitState_Offset), 0, ObserveHasUnitState_PropertyAddress.Address);
			ObserveUnitStates = new TArrayCopyMarshaler<EBGUUnitState>(1, ObserveUnitStates_PropertyAddress, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.FromNative, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObserveUnitStates_Offset));
			ObserveHasSimpleState = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ObserveHasSimpleState_Offset), 0, ObserveHasSimpleState_PropertyAddress.Address);
			ObserveSimpleStates = new TArrayCopyMarshaler<EBGUSimpleState>(1, ObserveSimpleStates_PropertyAddress, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.FromNative, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObserveSimpleStates_Offset));
			ObserveHasBuff = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ObserveHasBuff_Offset), 0, ObserveHasBuff_PropertyAddress.Address);
			ObserveBuffIDs = new TArrayCopyMarshaler<int>(1, ObserveBuffIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObserveBuffIDs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSForceFightUnitCondition");
		FGSForceFightUnitCondition_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ObservedUnits_PropertyAddress, intPtr, "ObservedUnits");
		ObservedUnits_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObservedUnits");
		ObservedUnits_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObservedUnits", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObservedTamers_PropertyAddress, intPtr, "ObservedTamers");
		ObservedTamers_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObservedTamers");
		ObservedTamers_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObservedTamers", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObservedTamerRefs_PropertyAddress, intPtr, "ObservedTamerRefs");
		ObservedTamerRefs_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObservedTamerRefs");
		ObservedTamerRefs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObservedTamerRefs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObserveHasUnitState_PropertyAddress, intPtr, "ObserveHasUnitState");
		ObserveHasUnitState_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveHasUnitState");
		ObserveHasUnitState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveHasUnitState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ObserveUnitStates_PropertyAddress, intPtr, "ObserveUnitStates");
		ObserveUnitStates_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveUnitStates");
		ObserveUnitStates_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveUnitStates", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObserveHasSimpleState_PropertyAddress, intPtr, "ObserveHasSimpleState");
		ObserveHasSimpleState_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveHasSimpleState");
		ObserveHasSimpleState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveHasSimpleState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ObserveSimpleStates_PropertyAddress, intPtr, "ObserveSimpleStates");
		ObserveSimpleStates_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveSimpleStates");
		ObserveSimpleStates_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveSimpleStates", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ObserveHasBuff_PropertyAddress, intPtr, "ObserveHasBuff");
		ObserveHasBuff_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveHasBuff");
		ObserveHasBuff_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveHasBuff", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ObserveBuffIDs_PropertyAddress, intPtr, "ObserveBuffIDs");
		ObserveBuffIDs_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveBuffIDs");
		ObserveBuffIDs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveBuffIDs", Classes.FArrayProperty);
		FGSForceFightUnitCondition_IsValid = ((intPtr != IntPtr.Zero && ObservedUnits_IsValid && ObservedTamers_IsValid && ObservedTamerRefs_IsValid && ObserveHasUnitState_IsValid && ObserveUnitStates_IsValid && ObserveHasSimpleState_IsValid && ObserveSimpleStates_IsValid && ObserveHasBuff_IsValid && ObserveBuffIDs_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSForceFightUnitCondition", (byte)FGSForceFightUnitCondition_IsValid != 0);
	}

	static FGSForceFightUnitCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSForceFightUnitCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSForceFightUnitCondition));
	}
}
