using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SpawnWaveConfig_Infinite_OneWaveWrap")]
public struct FSpawnWaveConfig_Infinite_OneWaveWrap
{
	[UProperty]
	[DisplayName("每波怪物配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SpawnWaveConfig_Infinite_OneWaveWrap:SpawnWaveUnits")]
	public List<FSpawnWaveUnitConfig> SpawnWaveUnits;

	[DisplayName("单位剩余数量小于该值时触发填补队列刷新")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("只刷新一次，填 <= 0时不生效")]
	[USharpPath("/Script/b1-Managed.SpawnWaveConfig_Infinite_OneWaveWrap:RemainUnitNumToTriggerFill")]
	public int RemainUnitNumToTriggerFill;

	[UProperty]
	[DisplayName("填补队列")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SpawnWaveConfig_Infinite_OneWaveWrap:SpawnWaveUnits_Fill")]
	public List<FSpawnWaveUnitConfig> SpawnWaveUnits_Fill;

	private static int SpawnWaveConfig_Infinite_OneWaveWrap_StructSize;

	private static int SpawnWaveConfig_Infinite_OneWaveWrap_IsValid;

	private static bool SpawnWaveUnits_IsValid;

	private static int SpawnWaveUnits_Offset;

	private static FFieldAddress SpawnWaveUnits_PropertyAddress;

	private static bool RemainUnitNumToTriggerFill_IsValid;

	private static int RemainUnitNumToTriggerFill_Offset;

	private static bool SpawnWaveUnits_Fill_IsValid;

	private static int SpawnWaveUnits_Fill_Offset;

	private static FFieldAddress SpawnWaveUnits_Fill_PropertyAddress;

	public FSpawnWaveConfig_Infinite_OneWaveWrap Copy()
	{
		FSpawnWaveConfig_Infinite_OneWaveWrap result = this;
		if (SpawnWaveUnits != null)
		{
			result.SpawnWaveUnits = new List<FSpawnWaveUnitConfig>(SpawnWaveUnits);
		}
		if (SpawnWaveUnits_Fill != null)
		{
			result.SpawnWaveUnits_Fill = new List<FSpawnWaveUnitConfig>(SpawnWaveUnits_Fill);
		}
		return result;
	}

	public static FSpawnWaveConfig_Infinite_OneWaveWrap FromNative(IntPtr nativeBuffer)
	{
		return new FSpawnWaveConfig_Infinite_OneWaveWrap(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSpawnWaveConfig_Infinite_OneWaveWrap value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSpawnWaveConfig_Infinite_OneWaveWrap FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSpawnWaveConfig_Infinite_OneWaveWrap(IntPtr.Add(nativeBuffer, arrayIndex * SpawnWaveConfig_Infinite_OneWaveWrap_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSpawnWaveConfig_Infinite_OneWaveWrap value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SpawnWaveConfig_Infinite_OneWaveWrap_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SpawnWaveConfig_Infinite_OneWaveWrap_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnWaveConfig_Infinite_OneWaveWrap");
			return;
		}
		new TArrayCopyMarshaler<FSpawnWaveUnitConfig>(1, SpawnWaveUnits_PropertyAddress, CachedMarshalingDelegates<FSpawnWaveUnitConfig, FSpawnWaveUnitConfig>.FromNative, CachedMarshalingDelegates<FSpawnWaveUnitConfig, FSpawnWaveUnitConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpawnWaveUnits_Offset), SpawnWaveUnits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RemainUnitNumToTriggerFill_Offset), RemainUnitNumToTriggerFill);
		new TArrayCopyMarshaler<FSpawnWaveUnitConfig>(1, SpawnWaveUnits_Fill_PropertyAddress, CachedMarshalingDelegates<FSpawnWaveUnitConfig, FSpawnWaveUnitConfig>.FromNative, CachedMarshalingDelegates<FSpawnWaveUnitConfig, FSpawnWaveUnitConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpawnWaveUnits_Fill_Offset), SpawnWaveUnits_Fill);
	}

	public FSpawnWaveConfig_Infinite_OneWaveWrap(IntPtr nativeStruct)
	{
		if (SpawnWaveConfig_Infinite_OneWaveWrap_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnWaveConfig_Infinite_OneWaveWrap");
			SpawnWaveUnits = null;
			RemainUnitNumToTriggerFill = 0;
			SpawnWaveUnits_Fill = null;
		}
		else
		{
			SpawnWaveUnits = new TArrayCopyMarshaler<FSpawnWaveUnitConfig>(1, SpawnWaveUnits_PropertyAddress, CachedMarshalingDelegates<FSpawnWaveUnitConfig, FSpawnWaveUnitConfig>.FromNative, CachedMarshalingDelegates<FSpawnWaveUnitConfig, FSpawnWaveUnitConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpawnWaveUnits_Offset));
			RemainUnitNumToTriggerFill = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RemainUnitNumToTriggerFill_Offset));
			SpawnWaveUnits_Fill = new TArrayCopyMarshaler<FSpawnWaveUnitConfig>(1, SpawnWaveUnits_Fill_PropertyAddress, CachedMarshalingDelegates<FSpawnWaveUnitConfig, FSpawnWaveUnitConfig>.FromNative, CachedMarshalingDelegates<FSpawnWaveUnitConfig, FSpawnWaveUnitConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpawnWaveUnits_Fill_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SpawnWaveConfig_Infinite_OneWaveWrap");
		SpawnWaveConfig_Infinite_OneWaveWrap_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SpawnWaveUnits_PropertyAddress, intPtr, "SpawnWaveUnits");
		SpawnWaveUnits_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnWaveUnits");
		SpawnWaveUnits_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnWaveUnits", Classes.FArrayProperty);
		RemainUnitNumToTriggerFill_Offset = NativeReflection.GetPropertyOffset(intPtr, "RemainUnitNumToTriggerFill");
		RemainUnitNumToTriggerFill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RemainUnitNumToTriggerFill", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SpawnWaveUnits_Fill_PropertyAddress, intPtr, "SpawnWaveUnits_Fill");
		SpawnWaveUnits_Fill_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnWaveUnits_Fill");
		SpawnWaveUnits_Fill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnWaveUnits_Fill", Classes.FArrayProperty);
		SpawnWaveConfig_Infinite_OneWaveWrap_IsValid = ((intPtr != IntPtr.Zero && SpawnWaveUnits_IsValid && RemainUnitNumToTriggerFill_IsValid && SpawnWaveUnits_Fill_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SpawnWaveConfig_Infinite_OneWaveWrap", (byte)SpawnWaveConfig_Infinite_OneWaveWrap_IsValid != 0);
	}

	static FSpawnWaveConfig_Infinite_OneWaveWrap()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSpawnWaveConfig_Infinite_OneWaveWrap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSpawnWaveConfig_Infinite_OneWaveWrap));
	}
}
