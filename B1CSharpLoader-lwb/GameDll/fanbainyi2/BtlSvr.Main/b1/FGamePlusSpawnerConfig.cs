using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.GamePlusSpawnerConfig")]
public struct FGamePlusSpawnerConfig
{
	[DisplayName("出生概率")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GamePlusSpawnerConfig:Rate")]
	public int Rate;

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("单位蓝图")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GamePlusSpawnerConfig:ActorClass")]
	public TSubclassOf<AActor> ActorClass;

	private static int GamePlusSpawnerConfig_StructSize;

	private static int GamePlusSpawnerConfig_IsValid;

	private static bool Rate_IsValid;

	private static int Rate_Offset;

	private static bool ActorClass_IsValid;

	private static int ActorClass_Offset;

	public FGamePlusSpawnerConfig Copy()
	{
		return this;
	}

	public static FGamePlusSpawnerConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGamePlusSpawnerConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGamePlusSpawnerConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGamePlusSpawnerConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGamePlusSpawnerConfig(IntPtr.Add(nativeBuffer, arrayIndex * GamePlusSpawnerConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGamePlusSpawnerConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * GamePlusSpawnerConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (GamePlusSpawnerConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GamePlusSpawnerConfig");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Rate_Offset), Rate);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, ActorClass_Offset), ActorClass);
	}

	public FGamePlusSpawnerConfig(IntPtr nativeStruct)
	{
		if (GamePlusSpawnerConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GamePlusSpawnerConfig");
			Rate = 0;
			ActorClass = default(TSubclassOf<AActor>);
		}
		else
		{
			Rate = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Rate_Offset));
			ActorClass = TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, ActorClass_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.GamePlusSpawnerConfig");
		GamePlusSpawnerConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Rate_Offset = NativeReflection.GetPropertyOffset(intPtr, "Rate");
		Rate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Rate", Classes.FIntProperty);
		ActorClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorClass");
		ActorClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorClass", Classes.FClassProperty);
		GamePlusSpawnerConfig_IsValid = ((intPtr != IntPtr.Zero && Rate_IsValid && ActorClass_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.GamePlusSpawnerConfig", (byte)GamePlusSpawnerConfig_IsValid != 0);
	}

	static FGamePlusSpawnerConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGamePlusSpawnerConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGamePlusSpawnerConfig));
	}
}
