using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_EnvMgrSystem : GameStateSystemBase
{
	private BGC_EnvMgrData EnvMgrData;

	public override void OnAttach()
	{
		EnvMgrData = RequireWritableData<BGC_EnvMgrData>();
	}

	public override void PreBeginPlay()
	{
		if (!(EnvMgrData.EffectMgr == null))
		{
			return;
		}
		FVector Location = FVector.ZeroVector;
		FRotator Rotation = FRotator.ZeroRotator;
		FActorSpawnParameters parameters = new FActorSpawnParameters
		{
			SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
		};
		UClass cls = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00Main/BPLibrary/BGW/BP_EnvironmentSurfaceEffectMgr.BP_EnvironmentSurfaceEffectMgr_C'", ELoadResourceType.SyncLoadAndCache);
		EnvMgrData.EffectMgr = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(Owner.World, cls, ref Location, ref Rotation, ref parameters) as BGUEnvironmentSurfaceEffectMgr;
		if (EnvMgrData.EffectMgr != null)
		{
			BGW_WorldSettings bGW_WorldSettings = Owner.World.GetWorldSettings().Cast<BGW_WorldSettings>();
			if (bGW_WorldSettings != null)
			{
				EnvMgrData.EffectMgr.WeatherType = bGW_WorldSettings.DefaultWeatherType;
				EnvMgrData.EffectMgr.DefaultEnvironmentSurfaceEffectID = bGW_WorldSettings.DefaultEnvironmentSurfaceEffectID;
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (EnvMgrData.EffectMgr != null)
		{
			EnvMgrData.EffectMgr.DestroyActor();
			EnvMgrData.EffectMgr = null;
		}
	}
}
