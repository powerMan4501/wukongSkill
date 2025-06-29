using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FSummonProcessor_AdjustPointTransform : FSummonProcessorBase
{
	public override ESummonProcessorTag Tag => ESummonProcessorTag.AdjustPointTransform;

	protected override bool RunProcessor(FSummonInstance InSummonInstance)
	{
		FSummonSystemContext systemContext = InSummonInstance.SystemContext;
		FSummonProcessorData summonProcessorData = InSummonInstance.SummonProcessorData;
		FSummonReq summonReq = InSummonInstance.SummonReq;
		AActor summoner = summonReq.Summoner;
		FSummonSpawnConfigWrap spawnConfigWrap = summonReq.SpawnConfigWrap;
		if (summoner == null)
		{
			return false;
		}
		AController instigatorController = summoner.GetInstigatorController();
		BGUFuncLibActorTransformCS.BGUGetActorLocation(summoner);
		IBGC_LocalPlayerSharedData iBGC_LocalPlayerSharedData = null;
		if (spawnConfigWrap.EnsureBornPosCanNavToPlayer)
		{
			iBGC_LocalPlayerSharedData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>(summoner);
		}
		for (int i = 0; i < summonProcessorData.SelectedPoints.Count; i++)
		{
			FTransform value = summonProcessorData.SelectedPoints[i];
			FVector fVector = value.GetLocation();
			FRotator fRotator = value.GetRotation().Rotator();
			if (spawnConfigWrap.EnsureBornPosCanNavToPlayer && iBGC_LocalPlayerSharedData != null && UBGUFunctionLibrary.BGUNavigationRaycast(systemContext.SystemOwner, iBGC_LocalPlayerSharedData.CachedLocalPlayerLocation, fVector, out var HitLocation, null, instigatorController))
			{
				float num = FVector.Dist2D(iBGC_LocalPlayerSharedData.CachedLocalPlayerLocation, HitLocation);
				float num2 = 1500f;
				if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.SummonNavProtectDistLimit_ReverseCalc, out var ConfigInfo))
				{
					num2 = ConfigInfo.FloatValue;
				}
				if (num < num2)
				{
					FVector fVector2 = iBGC_LocalPlayerSharedData.CachedLocalPlayerLocation + (iBGC_LocalPlayerSharedData.CachedLocalPlayerLocation - fVector);
					fVector = ((!UBGUFunctionLibrary.BGUNavigationRaycast(systemContext.SystemOwner, iBGC_LocalPlayerSharedData.CachedLocalPlayerLocation, fVector2, out var HitLocation2, null, instigatorController)) ? fVector2 : ((FVector.Dist2D(iBGC_LocalPlayerSharedData.CachedLocalPlayerLocation, HitLocation2) > num) ? HitLocation2 : HitLocation));
				}
				else
				{
					fVector = HitLocation;
				}
			}
			switch (spawnConfigWrap.SummonUnitRotationType)
			{
			case ESummonUnitRotationType.FacingCurTarget:
			{
				AActor aActor = (BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(summoner)?.GetTargetInfo())?.LockTargetActor;
				if (aActor != null)
				{
					fRotator.Yaw = UMathLibrary.FindLookAtRotation(fVector, BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor)).Yaw;
				}
				break;
			}
			case ESummonUnitRotationType.FacingLocalPlayer:
				if (iBGC_LocalPlayerSharedData == null)
				{
					iBGC_LocalPlayerSharedData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>(summoner);
				}
				if (iBGC_LocalPlayerSharedData != null)
				{
					fRotator.Yaw = UMathLibrary.FindLookAtRotation(fVector, iBGC_LocalPlayerSharedData.CachedLocalPlayerLocation).Yaw;
				}
				break;
			case ESummonUnitRotationType.UseEffectCasterRot:
				if (summonReq.EffectCaster != null)
				{
					fRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(summonReq.EffectCaster);
				}
				break;
			case ESummonUnitRotationType.UseManualSpawnPoint:
			case ESummonUnitRotationType.UseSpawnPointRot:
				fRotator = summonReq.SpawnPointRot;
				break;
			}
			value.SetLocation(fVector);
			value.SetRotation(fRotator.Quaternion());
			summonProcessorData.SelectedPoints[i] = value;
		}
		return true;
	}

	protected override ESummonProcessorTag GetNext(FSummonInstance InSummonInstance)
	{
		return ESummonProcessorTag.GenerateSpawnInfo;
	}
}
