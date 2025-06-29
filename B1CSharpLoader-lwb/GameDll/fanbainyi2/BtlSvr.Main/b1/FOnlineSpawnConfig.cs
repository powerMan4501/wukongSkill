using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.OnlineSpawnConfig")]
public struct FOnlineSpawnConfig
{
	[DisplayName("数量上限")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.OnlineSpawnConfig:SpawnNumOnline")]
	public int SpawnNumOnline;

	[DisplayName("保底数量")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.OnlineSpawnConfig:LowerLimitNumOnline")]
	public int LowerLimitNumOnline;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("单次检测补充的数量")]
	[USharpPath("/Script/b1-Managed.OnlineSpawnConfig:ReSpawnNumOnline")]
	public int ReSpawnNumOnline;

	private static int OnlineSpawnConfig_StructSize;

	public FOnlineSpawnConfig Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.OnlineSpawnConfig");
		OnlineSpawnConfig_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FOnlineSpawnConfig));
	}

	static FOnlineSpawnConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnlineSpawnConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnlineSpawnConfig));
	}
}
