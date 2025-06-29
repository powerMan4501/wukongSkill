using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SpawnWaveConfig_Infinite")]
public struct FSpawnWaveConfig_Infinite
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("新波次开始条件")]
	[USharpPath("/Script/b1-Managed.SpawnWaveConfig_Infinite:NextWaveStartCondition")]
	public FCompositeCondition_SpawnWaveStart NextWaveStartCondition;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("生成间隔区间")]
	[USharpPath("/Script/b1-Managed.SpawnWaveConfig_Infinite:SpawnIntervalRnage")]
	public FVector2D SpawnIntervalRnage;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("阵列模板列表")]
	[USharpPath("/Script/b1-Managed.SpawnWaveConfig_Infinite:SpawnWaveUnits")]
	public List<FSpawnWaveConfig_Infinite_OneWaveWrap> SpawnWaveUnits;

	private static int SpawnWaveConfig_Infinite_StructSize;

	private static int SpawnWaveConfig_Infinite_IsValid;

	private static bool NextWaveStartCondition_IsValid;

	private static int NextWaveStartCondition_Offset;

	private static bool SpawnIntervalRnage_IsValid;

	private static int SpawnIntervalRnage_Offset;

	private static bool SpawnWaveUnits_IsValid;

	private static int SpawnWaveUnits_Offset;

	private static FFieldAddress SpawnWaveUnits_PropertyAddress;

	public FSpawnWaveConfig_Infinite Copy()
	{
		FSpawnWaveConfig_Infinite result = this;
		if (SpawnWaveUnits != null)
		{
			result.SpawnWaveUnits = new List<FSpawnWaveConfig_Infinite_OneWaveWrap>(SpawnWaveUnits);
		}
		return result;
	}

	public static FSpawnWaveConfig_Infinite FromNative(IntPtr nativeBuffer)
	{
		return new FSpawnWaveConfig_Infinite(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSpawnWaveConfig_Infinite value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSpawnWaveConfig_Infinite FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSpawnWaveConfig_Infinite(IntPtr.Add(nativeBuffer, arrayIndex * SpawnWaveConfig_Infinite_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSpawnWaveConfig_Infinite value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SpawnWaveConfig_Infinite_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SpawnWaveConfig_Infinite_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnWaveConfig_Infinite");
			return;
		}
		FCompositeCondition_SpawnWaveStart.ToNative(IntPtr.Add(nativeStruct, NextWaveStartCondition_Offset), NextWaveStartCondition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, SpawnIntervalRnage_Offset), SpawnIntervalRnage);
		new TArrayCopyMarshaler<FSpawnWaveConfig_Infinite_OneWaveWrap>(1, SpawnWaveUnits_PropertyAddress, CachedMarshalingDelegates<FSpawnWaveConfig_Infinite_OneWaveWrap, FSpawnWaveConfig_Infinite_OneWaveWrap>.FromNative, CachedMarshalingDelegates<FSpawnWaveConfig_Infinite_OneWaveWrap, FSpawnWaveConfig_Infinite_OneWaveWrap>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpawnWaveUnits_Offset), SpawnWaveUnits);
	}

	public FSpawnWaveConfig_Infinite(IntPtr nativeStruct)
	{
		if (SpawnWaveConfig_Infinite_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnWaveConfig_Infinite");
			NextWaveStartCondition = default(FCompositeCondition_SpawnWaveStart);
			SpawnIntervalRnage = default(FVector2D);
			SpawnWaveUnits = null;
		}
		else
		{
			NextWaveStartCondition = FCompositeCondition_SpawnWaveStart.FromNative(IntPtr.Add(nativeStruct, NextWaveStartCondition_Offset));
			SpawnIntervalRnage = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, SpawnIntervalRnage_Offset));
			SpawnWaveUnits = new TArrayCopyMarshaler<FSpawnWaveConfig_Infinite_OneWaveWrap>(1, SpawnWaveUnits_PropertyAddress, CachedMarshalingDelegates<FSpawnWaveConfig_Infinite_OneWaveWrap, FSpawnWaveConfig_Infinite_OneWaveWrap>.FromNative, CachedMarshalingDelegates<FSpawnWaveConfig_Infinite_OneWaveWrap, FSpawnWaveConfig_Infinite_OneWaveWrap>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpawnWaveUnits_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SpawnWaveConfig_Infinite");
		SpawnWaveConfig_Infinite_StructSize = NativeReflection.GetStructSize(intPtr);
		NextWaveStartCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "NextWaveStartCondition");
		NextWaveStartCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NextWaveStartCondition", Classes.FStructProperty);
		SpawnIntervalRnage_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnIntervalRnage");
		SpawnIntervalRnage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnIntervalRnage", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SpawnWaveUnits_PropertyAddress, intPtr, "SpawnWaveUnits");
		SpawnWaveUnits_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnWaveUnits");
		SpawnWaveUnits_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnWaveUnits", Classes.FArrayProperty);
		SpawnWaveConfig_Infinite_IsValid = ((intPtr != IntPtr.Zero && NextWaveStartCondition_IsValid && SpawnIntervalRnage_IsValid && SpawnWaveUnits_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SpawnWaveConfig_Infinite", (byte)SpawnWaveConfig_Infinite_IsValid != 0);
	}

	static FSpawnWaveConfig_Infinite()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSpawnWaveConfig_Infinite)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSpawnWaveConfig_Infinite));
	}
}
