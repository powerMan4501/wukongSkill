using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BattleTriggerConfig")]
public struct FBattleTriggerConfig
{
	[Tooltip("混战单位配置列表")]
	[DisplayName("混战单位配置列表")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BattleTriggerConfig:BattleUnitConfigs")]
	public List<FBattleTriggerUnitConfig> BattleUnitConfigs;

	private static int BattleTriggerConfig_StructSize;

	private static int BattleTriggerConfig_IsValid;

	private static bool BattleUnitConfigs_IsValid;

	private static int BattleUnitConfigs_Offset;

	private static FFieldAddress BattleUnitConfigs_PropertyAddress;

	public FBattleTriggerConfig Copy()
	{
		FBattleTriggerConfig result = this;
		if (BattleUnitConfigs != null)
		{
			result.BattleUnitConfigs = new List<FBattleTriggerUnitConfig>(BattleUnitConfigs);
		}
		return result;
	}

	public static FBattleTriggerConfig FromNative(IntPtr nativeBuffer)
	{
		return new FBattleTriggerConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBattleTriggerConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBattleTriggerConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBattleTriggerConfig(IntPtr.Add(nativeBuffer, arrayIndex * BattleTriggerConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBattleTriggerConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BattleTriggerConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BattleTriggerConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BattleTriggerConfig");
		}
		else
		{
			new TArrayCopyMarshaler<FBattleTriggerUnitConfig>(1, BattleUnitConfigs_PropertyAddress, CachedMarshalingDelegates<FBattleTriggerUnitConfig, FBattleTriggerUnitConfig>.FromNative, CachedMarshalingDelegates<FBattleTriggerUnitConfig, FBattleTriggerUnitConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, BattleUnitConfigs_Offset), BattleUnitConfigs);
		}
	}

	public FBattleTriggerConfig(IntPtr nativeStruct)
	{
		if (BattleTriggerConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BattleTriggerConfig");
			BattleUnitConfigs = null;
		}
		else
		{
			BattleUnitConfigs = new TArrayCopyMarshaler<FBattleTriggerUnitConfig>(1, BattleUnitConfigs_PropertyAddress, CachedMarshalingDelegates<FBattleTriggerUnitConfig, FBattleTriggerUnitConfig>.FromNative, CachedMarshalingDelegates<FBattleTriggerUnitConfig, FBattleTriggerUnitConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, BattleUnitConfigs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BattleTriggerConfig");
		BattleTriggerConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref BattleUnitConfigs_PropertyAddress, intPtr, "BattleUnitConfigs");
		BattleUnitConfigs_Offset = NativeReflection.GetPropertyOffset(intPtr, "BattleUnitConfigs");
		BattleUnitConfigs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BattleUnitConfigs", Classes.FArrayProperty);
		BattleTriggerConfig_IsValid = ((intPtr != IntPtr.Zero && BattleUnitConfigs_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BattleTriggerConfig", (byte)BattleTriggerConfig_IsValid != 0);
	}

	static FBattleTriggerConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBattleTriggerConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBattleTriggerConfig));
	}
}
