using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SpawnWaveConfig")]
public struct FSpawnWaveConfig
{
	[DisplayName("下一波次开始条件")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SpawnWaveConfig:NextWaveStartCondition")]
	public FCompositeCondition_SpawnWaveStart NextWaveStartCondition;

	[DisplayName("生成间隔区间")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SpawnWaveConfig:SpawnIntervalRnage")]
	public FVector2D SpawnIntervalRnage;

	[UProperty]
	[DisplayName("波次刷新怪物")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SpawnWaveConfig:SpawnWaveUnits")]
	public List<FSpawnWaveUnitConfig> SpawnWaveUnits;

	private static int SpawnWaveConfig_StructSize;

	private static int SpawnWaveConfig_IsValid;

	private static bool NextWaveStartCondition_IsValid;

	private static int NextWaveStartCondition_Offset;

	private static bool SpawnIntervalRnage_IsValid;

	private static int SpawnIntervalRnage_Offset;

	private static bool SpawnWaveUnits_IsValid;

	private static int SpawnWaveUnits_Offset;

	private static FFieldAddress SpawnWaveUnits_PropertyAddress;

	public FSpawnWaveConfig Copy()
	{
		FSpawnWaveConfig result = this;
		if (SpawnWaveUnits != null)
		{
			result.SpawnWaveUnits = new List<FSpawnWaveUnitConfig>(SpawnWaveUnits);
		}
		return result;
	}

	public static FSpawnWaveConfig FromNative(IntPtr nativeBuffer)
	{
		return new FSpawnWaveConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSpawnWaveConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSpawnWaveConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSpawnWaveConfig(IntPtr.Add(nativeBuffer, arrayIndex * SpawnWaveConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSpawnWaveConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SpawnWaveConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SpawnWaveConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnWaveConfig");
			return;
		}
		FCompositeCondition_SpawnWaveStart.ToNative(IntPtr.Add(nativeStruct, NextWaveStartCondition_Offset), NextWaveStartCondition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, SpawnIntervalRnage_Offset), SpawnIntervalRnage);
		new TArrayCopyMarshaler<FSpawnWaveUnitConfig>(1, SpawnWaveUnits_PropertyAddress, CachedMarshalingDelegates<FSpawnWaveUnitConfig, FSpawnWaveUnitConfig>.FromNative, CachedMarshalingDelegates<FSpawnWaveUnitConfig, FSpawnWaveUnitConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpawnWaveUnits_Offset), SpawnWaveUnits);
	}

	public FSpawnWaveConfig(IntPtr nativeStruct)
	{
		if (SpawnWaveConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnWaveConfig");
			NextWaveStartCondition = default(FCompositeCondition_SpawnWaveStart);
			SpawnIntervalRnage = default(FVector2D);
			SpawnWaveUnits = null;
		}
		else
		{
			NextWaveStartCondition = FCompositeCondition_SpawnWaveStart.FromNative(IntPtr.Add(nativeStruct, NextWaveStartCondition_Offset));
			SpawnIntervalRnage = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, SpawnIntervalRnage_Offset));
			SpawnWaveUnits = new TArrayCopyMarshaler<FSpawnWaveUnitConfig>(1, SpawnWaveUnits_PropertyAddress, CachedMarshalingDelegates<FSpawnWaveUnitConfig, FSpawnWaveUnitConfig>.FromNative, CachedMarshalingDelegates<FSpawnWaveUnitConfig, FSpawnWaveUnitConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpawnWaveUnits_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SpawnWaveConfig");
		SpawnWaveConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NextWaveStartCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "NextWaveStartCondition");
		NextWaveStartCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NextWaveStartCondition", Classes.FStructProperty);
		SpawnIntervalRnage_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnIntervalRnage");
		SpawnIntervalRnage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnIntervalRnage", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SpawnWaveUnits_PropertyAddress, intPtr, "SpawnWaveUnits");
		SpawnWaveUnits_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnWaveUnits");
		SpawnWaveUnits_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnWaveUnits", Classes.FArrayProperty);
		SpawnWaveConfig_IsValid = ((intPtr != IntPtr.Zero && NextWaveStartCondition_IsValid && SpawnIntervalRnage_IsValid && SpawnWaveUnits_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SpawnWaveConfig", (byte)SpawnWaveConfig_IsValid != 0);
	}

	static FSpawnWaveConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSpawnWaveConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSpawnWaveConfig));
	}
}
