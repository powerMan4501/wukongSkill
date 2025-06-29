using System.Collections.Generic;
using BtlB1;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FSummonProcessor_SelectPoints : FSummonProcessorBase
{
	public override ESummonProcessorTag Tag => ESummonProcessorTag.SelectPoints;

	private Dictionary<int, FSummonInstance> EqsQueryRequestCache { get; } = new Dictionary<int, FSummonInstance>();

	protected override bool RunProcessor(FSummonInstance InSummonInstance)
	{
		FSummonSystemContext systemContext = InSummonInstance.SystemContext;
		FSummonProcessorData summonProcessorData = InSummonInstance.SummonProcessorData;
		FSummonReq summonReq = InSummonInstance.SummonReq;
		AActor summoner = summonReq.Summoner;
		FSummonSpawnConfigWrap spawnConfigWrap = summonReq.SpawnConfigWrap;
		summonProcessorData.SelectedPoints.Clear();
		switch (spawnConfigWrap.SummonUnitLocationType)
		{
		case ESummonUnitLocationType.UsePointSetCached:
		{
			IBUC_PointSetsData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PointSetsData, BUC_PointSetsData>(summoner);
			if (spawnConfigWrap.PointSetCachedReqID <= 0 || readOnlyData == null || !readOnlyData.PointQueneMap.TryGetValue(spawnConfigWrap.PointSetCachedReqID, out var value))
			{
				break;
			}
			foreach (FVector item in value)
			{
				summonProcessorData.SelectedPoints.Add(new FTransform(item));
			}
			break;
		}
		case ESummonUnitLocationType.UseManualSpawnPoint:
		{
			BGWMonkeySummonDataAsset summonPointDA = spawnConfigWrap.SummonPointDA;
			if (summonPointDA == null || summonPointDA.SummonSpawnPointList.Count <= summonReq.SummonCount)
			{
				return true;
			}
			FSummonSpawnQuene fSummonSpawnQuene = summonPointDA.SummonSpawnPointList[summonReq.SummonCount];
			if (fSummonSpawnQuene.SpawnQuenes.Count <= 0)
			{
				break;
			}
			int randomNumberInt = UB1Util.GetRandomNumberInt(0, fSummonSpawnQuene.SpawnQuenes.Count - 1);
			BGUCharacterCS bGUCharacterCS = summoner as BGUCharacterCS;
			if (bGUCharacterCS == null)
			{
				return true;
			}
			float scaledCapsuleHalfHeight = bGUCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight();
			FTransform t = BGUFuncLibActorTransformCS.BGUGetActorTransform(bGUCharacterCS);
			foreach (FTransform spawnPoint in fSummonSpawnQuene.SpawnQuenes[randomNumberInt].SpawnPoints)
			{
				FVector translation = t.TransformLocation(spawnPoint.GetLocation()) - new FVector(0.0, 0.0, scaledCapsuleHalfHeight);
				FQuat rotation = t.TransformRotation(spawnPoint.GetRotation());
				summonProcessorData.SelectedPoints.Add(new FTransform(rotation, translation));
			}
			break;
		}
		case ESummonUnitLocationType.UseEqsdata:
		{
			AActor querier = ((summonReq.BuffOwner != null) ? summonReq.BuffOwner : summoner);
			UEnvQuery eQSTemplate = spawnConfigWrap.EQSTemplate;
			if (eQSTemplate != null)
			{
				int key = systemContext.BGSEventCollection.Evt_BGS_EQSObjRun.Invoke(eQSTemplate, querier, EBGURunEQSObjReason.Summon, new FGSEQSExParam
				{
					ExParam_Bool = summonReq.bTeleportSelf
				}, OnEQSFinish);
				EqsQueryRequestCache[key] = InSummonInstance;
				return false;
			}
			break;
		}
		case ESummonUnitLocationType.UseEffectCasterPos:
			if (summonReq.EffectCaster != null)
			{
				FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(summonReq.EffectCaster);
				fVector2 = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, summonReq.EffectCaster, spawnConfigWrap.SpawnSocketName, out var _).GetLocation();
				summonProcessorData.SelectedPoints.Add(new FTransform(fVector2));
			}
			break;
		case ESummonUnitLocationType.UseCasterPos:
			if (summoner != null)
			{
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(summoner);
				fVector = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, summoner, spawnConfigWrap.SpawnSocketName, out var _).GetLocation();
				summonProcessorData.SelectedPoints.Add(new FTransform(fVector));
			}
			break;
		case ESummonUnitLocationType.UseEffectPos:
			summonProcessorData.SelectedPoints.Add(new FTransform(summonReq.HitLocation));
			break;
		}
		if (summonProcessorData.SelectedPoints.Count == 0)
		{
			summonProcessorData.SelectedPoints.Add(BGUFuncLibActorTransformCS.BGUGetActorTransform(summonReq.Summoner));
		}
		summonReq.SummonCount = summonProcessorData.SelectedPoints.Count;
		return true;
	}

	protected override ESummonProcessorTag GetNext(FSummonInstance InSummonInstance)
	{
		if (InSummonInstance.SummonProcessorData.SelectedPoints.Count == 0)
		{
			return ESummonProcessorTag.Exception;
		}
		return ESummonProcessorTag.AdjustPointTransform;
	}

	private void OnEQSFinish(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
	{
		if (ExParam.RunEQSObjReason != EBGURunEQSObjReason.Summon || !EqsQueryRequestCache.TryGetValue(QueryID, out var value))
		{
			return;
		}
		foreach (FVector item in Result)
		{
			value.SummonProcessorData.SelectedPoints.Add(new FTransform(item));
		}
		EqsQueryRequestCache.Remove(QueryID);
		RunNext(value);
	}
}
