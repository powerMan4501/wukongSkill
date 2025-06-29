using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ProjectileSpawnEventInfo")]
public struct FProjectileSpawnEventInfo
{
	[BlueprintReadWrite]
	[DisplayName("每波的子弹数量")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ProjectileSpawnEventInfo:TotalNumInAWave")]
	public int TotalNumInAWave;

	[EditAnywhere]
	[UProperty]
	[Tooltip("指该子弹在一次生成事件中的生成序号，如事件‘每波生成3颗子弹’，第一波第一颗序号为0，第二波第一颗序号为3")]
	[DisplayName("生成序号")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ProjectileSpawnEventInfo:SelfIndexInAWave")]
	public int SelfIndexInAWave;

	private static int ProjectileSpawnEventInfo_StructSize;

	public FProjectileSpawnEventInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.ProjectileSpawnEventInfo");
		ProjectileSpawnEventInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FProjectileSpawnEventInfo));
	}

	static FProjectileSpawnEventInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FProjectileSpawnEventInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FProjectileSpawnEventInfo));
	}
}
