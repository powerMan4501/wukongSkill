using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.GamePlusSpawnConfig")]
public struct FGamePlusSpawnConfig
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("周目数")]
	[USharpPath("/Script/b1-Managed.GamePlusSpawnConfig:GamePlusCount")]
	public int GamePlusCount;

	[UProperty]
	[DisplayName("随机配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GamePlusSpawnConfig:SpawnerConfig")]
	public List<FGamePlusSpawnerConfig> SpawnerConfig;

	private static int GamePlusSpawnConfig_StructSize;

	private static int GamePlusSpawnConfig_IsValid;

	private static bool GamePlusCount_IsValid;

	private static int GamePlusCount_Offset;

	private static bool SpawnerConfig_IsValid;

	private static int SpawnerConfig_Offset;

	private static FFieldAddress SpawnerConfig_PropertyAddress;

	public FGamePlusSpawnConfig Copy()
	{
		FGamePlusSpawnConfig result = this;
		if (SpawnerConfig != null)
		{
			result.SpawnerConfig = new List<FGamePlusSpawnerConfig>(SpawnerConfig);
		}
		return result;
	}

	public static FGamePlusSpawnConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGamePlusSpawnConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGamePlusSpawnConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGamePlusSpawnConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGamePlusSpawnConfig(IntPtr.Add(nativeBuffer, arrayIndex * GamePlusSpawnConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGamePlusSpawnConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * GamePlusSpawnConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (GamePlusSpawnConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GamePlusSpawnConfig");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, GamePlusCount_Offset), GamePlusCount);
		new TArrayCopyMarshaler<FGamePlusSpawnerConfig>(1, SpawnerConfig_PropertyAddress, CachedMarshalingDelegates<FGamePlusSpawnerConfig, FGamePlusSpawnerConfig>.FromNative, CachedMarshalingDelegates<FGamePlusSpawnerConfig, FGamePlusSpawnerConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpawnerConfig_Offset), SpawnerConfig);
	}

	public FGamePlusSpawnConfig(IntPtr nativeStruct)
	{
		if (GamePlusSpawnConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GamePlusSpawnConfig");
			GamePlusCount = 0;
			SpawnerConfig = null;
		}
		else
		{
			GamePlusCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, GamePlusCount_Offset));
			SpawnerConfig = new TArrayCopyMarshaler<FGamePlusSpawnerConfig>(1, SpawnerConfig_PropertyAddress, CachedMarshalingDelegates<FGamePlusSpawnerConfig, FGamePlusSpawnerConfig>.FromNative, CachedMarshalingDelegates<FGamePlusSpawnerConfig, FGamePlusSpawnerConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpawnerConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.GamePlusSpawnConfig");
		GamePlusSpawnConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		GamePlusCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "GamePlusCount");
		GamePlusCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GamePlusCount", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SpawnerConfig_PropertyAddress, intPtr, "SpawnerConfig");
		SpawnerConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnerConfig");
		SpawnerConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnerConfig", Classes.FArrayProperty);
		GamePlusSpawnConfig_IsValid = ((intPtr != IntPtr.Zero && GamePlusCount_IsValid && SpawnerConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.GamePlusSpawnConfig", (byte)GamePlusSpawnConfig_IsValid != 0);
	}

	static FGamePlusSpawnConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGamePlusSpawnConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGamePlusSpawnConfig));
	}
}
