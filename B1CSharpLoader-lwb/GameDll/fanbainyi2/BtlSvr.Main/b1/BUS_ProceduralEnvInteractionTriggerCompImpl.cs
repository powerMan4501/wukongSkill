using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ProceduralEnvInteractionTriggerCompImpl : UActorCompBaseCS
{
	private b1.BUC_ProceduralEnvInteractionTriggerData ProceduralEnvInteractionTriggerData;

	private IBGC_EnvMgrData EnvMgrData;

	public override void OnAttach()
	{
		ProceduralEnvInteractionTriggerData = RequireWritableData<b1.BUC_ProceduralEnvInteractionTriggerData>();
		EnvMgrData = RequireReadOnlyGameStateData<IBGC_EnvMgrData, BGC_EnvMgrData>();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!ProceduralEnvInteractionTriggerData.bEnable)
		{
			return;
		}
		if (ProceduralEnvInteractionTriggerData.DelayTimer > 0f)
		{
			ProceduralEnvInteractionTriggerData.DelayTimer -= DeltaTime;
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		FVector lineTraceEnd = fVector + Owner.GetActorUpVector() * (0f - ProceduralEnvInteractionTriggerData.TraceLength);
		BGUFuncLibSelectTargetsCS.LineTraceForHitWorldItem(Owner, fVector, lineTraceEnd, out var hitResultSimple);
		if (hitResultSimple.HitActor != null)
		{
			OnSweepHitWorldItemForFX(hitResultSimple.HitActor);
		}
		if (ProceduralEnvInteractionTriggerData.HitProtectTimer > 0f)
		{
			ProceduralEnvInteractionTriggerData.HitProtectTimer -= DeltaTime;
			return;
		}
		ProceduralEnvInteractionTriggerData.HitProtectTimer = ProceduralEnvInteractionTriggerData.SampleCollectionProtectTime;
		if (hitResultSimple.HitActor != null)
		{
			OnSweepHitWorldItem();
		}
	}

	private void OnSweepHitWorldItemForFX(AActor BeHitActor)
	{
		if (ProceduralEnvInteractionTriggerData.OverrideSurfaceType != ESceneItemSurfaceType.DefaultSurface)
		{
			if (EnvMgrData.EffectMgr == null)
			{
				BGW_LogUtil.LogError("BUS_ProceduralEnvInteractionTriggerCompImpl::OnSweepHitWorldItemForFX call failure: No EnvironmentSurfaceEffectMgr found!");
			}
			else if (BeHitActor == null)
			{
				BGW_LogUtil.LogError("BUS_ProceduralEnvInteractionTriggerCompImpl::OnSweepHitWorldItemForFX BeHitActor == null!");
			}
			else
			{
				EnvMgrData.EffectMgr.OnSweepHitWorldItemForSurfaceTypeOverrideDraw(BeHitActor, BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner).Conv_VectorToVector2D(), ProceduralEnvInteractionTriggerData.Size, ProceduralEnvInteractionTriggerData.OverrideSurfaceType, ProceduralEnvInteractionTriggerData.OverrideSurfacePersistTime, ProceduralEnvInteractionTriggerData.OverrideSurfaceFXActorTag, AActorStatics.GetEntityHash(Owner), ProceduralEnvInteractionTriggerData.bDrawDebug, ProceduralEnvInteractionTriggerData.DebugDrawOffset);
			}
		}
	}

	private void OnSweepHitWorldItem()
	{
		if (ProceduralEnvInteractionTriggerData.OverrideSurfaceType != ESceneItemSurfaceType.DefaultSurface)
		{
			if (EnvMgrData.EffectMgr == null)
			{
				BGW_LogUtil.LogError("BUS_ProceduralEnvInteractionTriggerCompImpl::OnSweepHitWorldItem call failure: No EnvironmentSurfaceEffectMgr found!");
			}
			else
			{
				EnvMgrData.EffectMgr.OnSweepHitWorldItemForSurfaceTypeOverride(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner).Conv_VectorToVector2D(), ProceduralEnvInteractionTriggerData.Size, ProceduralEnvInteractionTriggerData.OverrideSurfaceType, AActorStatics.GetEntityHash(Owner));
			}
		}
	}
}
