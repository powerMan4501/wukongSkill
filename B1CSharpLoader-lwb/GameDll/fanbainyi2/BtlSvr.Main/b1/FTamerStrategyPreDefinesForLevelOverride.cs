using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride")]
public struct FTamerStrategyPreDefinesForLevelOverride
{
	[UMeta(MDProp.Category, "单位通用")]
	[DisplayName("强制Spawn距离")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride:DistanceForForceSpawn")]
	public float DistanceForForceSpawn;

	[Category("单位通用")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride:ZOffsetSpawnLimitMeter")]
	public float ZOffsetSpawnLimitMeter;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("单位通用")]
	[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride:ZOffsetUnloadLimitMeter")]
	public float ZOffsetUnloadLimitMeter;

	[DisplayName("延迟销毁卸载时间（触发Unload后）")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("单位通用")]
	[Tooltip("单位：秒")]
	[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride:DefaultDelayDestroyTime")]
	public float DefaultDelayDestroyTime;

	[DisplayName("触发Beginplay距离")]
	[Category("非巡逻单位")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride:DistanceForActorBeginPlayMeter")]
	public float DistanceForActorBeginPlayMeter;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("非巡逻单位")]
	[Tooltip("大于此距离时，确保销毁")]
	[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride:DistanceForUnloadMeter")]
	public float DistanceForUnloadMeter;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("射线检测最小有效距离")]
	[Category("非巡逻单位")]
	[Tooltip("大于此距离时，不可视的Monster直接删除")]
	[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride:AsyncTraceMinEffectRange")]
	public float AsyncTraceMinEffectRange;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("非巡逻单位")]
	[DisplayName("射线检测最大有效距离")]
	[Tooltip("小于此距离时，开始使用射线检测，可视的Monster会刷出来")]
	[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride:AsyncTraceMaxEffectRange")]
	public float AsyncTraceMaxEffectRange;

	[EditAnywhere]
	[UProperty]
	[Tooltip("小于此距离时，确保刷出来")]
	[BlueprintReadWrite]
	[Category("巡逻单位")]
	[DisplayName("巡逻怪Actor&ECSBeginPlay的距离")]
	[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride:DistanceForPatrolActorBeginPlayMeter")]
	public float DistanceForPatrolActorBeginPlayMeter;

	[Category("巡逻单位")]
	[DisplayName("Unload(销毁巡逻Monster)的距离")]
	[Tooltip("大于此距离时，确保销毁")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride:DistanceForUnloadPatrolUnitMeter")]
	public float DistanceForUnloadPatrolUnitMeter;

	[BlueprintReadWrite]
	[Category("预加载")]
	[DisplayName("preload中距离档")]
	[Tooltip("在TamerPhase为Loaded下对应High")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride:PreloadDistanceMedium")]
	public float PreloadDistanceMedium;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("预加载")]
	[Tooltip("在TamerPhase为Loaded下对应Low（再大于这个距离是None）")]
	[DisplayName("preload最远档")]
	[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride:PreloadDistanceFarthest")]
	public float PreloadDistanceFarthest;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("预加载")]
	[DisplayName("preload超远档（预加载MonsterClass）")]
	[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride:PreloadDistanceLoadMonsterClass")]
	public float PreloadDistanceLoadMonsterClass;

	[UProperty]
	[DisplayName("preload超远档（卸载MonsterClass）")]
	[Category("预加载")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride:PreloadDistanceUnLoadMonsterClass")]
	public float PreloadDistanceUnLoadMonsterClass;

	private static int TamerStrategyPreDefinesForLevelOverride_StructSize;

	public FTamerStrategyPreDefinesForLevelOverride Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.TamerStrategyPreDefinesForLevelOverride");
		TamerStrategyPreDefinesForLevelOverride_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FTamerStrategyPreDefinesForLevelOverride));
	}

	static FTamerStrategyPreDefinesForLevelOverride()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTamerStrategyPreDefinesForLevelOverride)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTamerStrategyPreDefinesForLevelOverride));
	}
}
