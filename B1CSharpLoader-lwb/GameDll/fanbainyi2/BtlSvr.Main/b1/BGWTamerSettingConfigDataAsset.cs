using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWTamerSettingConfigDataAsset")]
public class BGWTamerSettingConfigDataAsset : UBGWDataAsset
{
	private static bool TamerStrategyPreDefinesForLevelOverride_IsValid;

	private static int TamerStrategyPreDefinesForLevelOverride_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("关卡重载Tamer参数")]
	[USharpPath("/Script/b1-Managed.BGWTamerSettingConfigDataAsset:TamerStrategyPreDefinesForLevelOverride")]
	public FTamerStrategyPreDefinesForLevelOverride TamerStrategyPreDefinesForLevelOverride
	{
		get
		{
			CheckDestroyed();
			if (!TamerStrategyPreDefinesForLevelOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWTamerSettingConfigDataAsset:TamerStrategyPreDefinesForLevelOverride");
				return default(FTamerStrategyPreDefinesForLevelOverride);
			}
			return BlittableTypeMarshaler<FTamerStrategyPreDefinesForLevelOverride>.FromNative(IntPtr.Add(base.Address, TamerStrategyPreDefinesForLevelOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TamerStrategyPreDefinesForLevelOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWTamerSettingConfigDataAsset:TamerStrategyPreDefinesForLevelOverride");
			}
			else
			{
				BlittableTypeMarshaler<FTamerStrategyPreDefinesForLevelOverride>.ToNative(IntPtr.Add(base.Address, TamerStrategyPreDefinesForLevelOverride_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		TamerStrategyPreDefinesForLevelOverride = new FTamerStrategyPreDefinesForLevelOverride
		{
			DistanceForForceSpawn = 20f,
			AsyncTraceMinEffectRange = 50f,
			AsyncTraceMaxEffectRange = 150f,
			DistanceForActorBeginPlayMeter = 50f,
			DistanceForUnloadMeter = 180f,
			PreloadDistanceMedium = 40f,
			PreloadDistanceFarthest = 65f,
			PreloadDistanceLoadMonsterClass = 200f,
			PreloadDistanceUnLoadMonsterClass = 250f,
			DistanceForPatrolActorBeginPlayMeter = 120f,
			DistanceForUnloadPatrolUnitMeter = 180f,
			ZOffsetSpawnLimitMeter = 50f,
			ZOffsetUnloadLimitMeter = 100f,
			DefaultDelayDestroyTime = 5f
		};
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWTamerSettingConfigDataAsset");
		TamerStrategyPreDefinesForLevelOverride_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TamerStrategyPreDefinesForLevelOverride");
		TamerStrategyPreDefinesForLevelOverride_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TamerStrategyPreDefinesForLevelOverride", Classes.FStructProperty);
	}

	static BGWTamerSettingConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWTamerSettingConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWTamerSettingConfigDataAsset));
	}
}
