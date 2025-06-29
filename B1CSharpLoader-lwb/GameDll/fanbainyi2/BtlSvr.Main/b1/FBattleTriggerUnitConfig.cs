using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BattleTriggerUnitConfig")]
public struct FBattleTriggerUnitConfig
{
	[BlueprintReadWrite]
	[DisplayName("单位")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BattleTriggerUnitConfig:Unit")]
	public FGsActorGuidReference Unit;

	[Tooltip("开战队伍ID大于0，触发混战后会切换队伍到对应ID；若小于等于0，则不切换队伍。")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("开战切换队伍ID")]
	[USharpPath("/Script/b1-Managed.BattleTriggerUnitConfig:SwitchTeamID")]
	public int SwitchTeamID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("混战指定目标")]
	[Tooltip("若配置了开战目标，触发混战后，会指定目标列表第一个作为当前目标，其余加入仇恨列表；若已有目标，则列表所有单位加入仇恨列表。若未配置则没有操作。")]
	[USharpPath("/Script/b1-Managed.BattleTriggerUnitConfig:TargetUnit")]
	public List<FGsActorGuidReference> TargetUnit;

	private static int BattleTriggerUnitConfig_StructSize;

	private static int BattleTriggerUnitConfig_IsValid;

	private static bool Unit_IsValid;

	private static int Unit_Offset;

	private static bool SwitchTeamID_IsValid;

	private static int SwitchTeamID_Offset;

	private static bool TargetUnit_IsValid;

	private static int TargetUnit_Offset;

	private static FFieldAddress TargetUnit_PropertyAddress;

	public FBattleTriggerUnitConfig Copy()
	{
		FBattleTriggerUnitConfig result = this;
		if (TargetUnit != null)
		{
			result.TargetUnit = new List<FGsActorGuidReference>(TargetUnit);
		}
		return result;
	}

	public static FBattleTriggerUnitConfig FromNative(IntPtr nativeBuffer)
	{
		return new FBattleTriggerUnitConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBattleTriggerUnitConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBattleTriggerUnitConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBattleTriggerUnitConfig(IntPtr.Add(nativeBuffer, arrayIndex * BattleTriggerUnitConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBattleTriggerUnitConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BattleTriggerUnitConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BattleTriggerUnitConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BattleTriggerUnitConfig");
			return;
		}
		FGsActorGuidReference.ToNative(IntPtr.Add(nativeStruct, Unit_Offset), Unit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SwitchTeamID_Offset), SwitchTeamID);
		new TArrayCopyMarshaler<FGsActorGuidReference>(1, TargetUnit_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).ToNative(IntPtr.Add(nativeStruct, TargetUnit_Offset), TargetUnit);
	}

	public FBattleTriggerUnitConfig(IntPtr nativeStruct)
	{
		if (BattleTriggerUnitConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BattleTriggerUnitConfig");
			Unit = default(FGsActorGuidReference);
			SwitchTeamID = 0;
			TargetUnit = null;
		}
		else
		{
			Unit = FGsActorGuidReference.FromNative(IntPtr.Add(nativeStruct, Unit_Offset));
			SwitchTeamID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SwitchTeamID_Offset));
			TargetUnit = new TArrayCopyMarshaler<FGsActorGuidReference>(1, TargetUnit_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).FromNative(IntPtr.Add(nativeStruct, TargetUnit_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BattleTriggerUnitConfig");
		BattleTriggerUnitConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Unit_Offset = NativeReflection.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Unit", Classes.FStructProperty);
		SwitchTeamID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SwitchTeamID");
		SwitchTeamID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SwitchTeamID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TargetUnit_PropertyAddress, intPtr, "TargetUnit");
		TargetUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetUnit");
		TargetUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetUnit", Classes.FArrayProperty);
		BattleTriggerUnitConfig_IsValid = ((intPtr != IntPtr.Zero && Unit_IsValid && SwitchTeamID_IsValid && TargetUnit_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BattleTriggerUnitConfig", (byte)BattleTriggerUnitConfig_IsValid != 0);
	}

	static FBattleTriggerUnitConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBattleTriggerUnitConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBattleTriggerUnitConfig));
	}
}
