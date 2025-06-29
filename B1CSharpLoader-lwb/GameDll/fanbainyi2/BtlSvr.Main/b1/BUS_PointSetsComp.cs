using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_PointSetsComp : UActorCompBaseCS
{
	private BUC_PointSetsData PointSetsData;

	private IBGC_LevelActorData LevelActorData { get; set; }

	public override void OnBeginPlay()
	{
		GetOwner();
		PointSetsData = RequireWritableData<BUC_PointSetsData>();
		LevelActorData = RequireReadOnlyGameStateData<IBGC_LevelActorData, BGC_LevelActorData>();
		base.BUSEventCollection.Evt_AddPointsToQuene += new Del_AddPointsToQuene(AddPointsToQuene);
		base.BUSEventCollection.Evt_CallPointsRegister += new Del_CallPointsRegister(CallPointsRegister);
	}

	private void CallPointsRegister(int RequestID, PointsGenType GenType, PointsGenExtParam ExtParam)
	{
		AActor owner = GetOwner();
		switch (GenType)
		{
		case PointsGenType.ByEQS_Async:
		{
			FGSEQSExParam exParam = new FGSEQSExParam
			{
				ExParam_Int = RequestID
			};
			if (ExtParam.EQSTemplate != null)
			{
				base.BGSEventCollection.Evt_BGS_EQSObjRun.Invoke(ExtParam.EQSTemplate, GetOwner(), EBGURunEQSObjReason.GenPointSet, exParam, OnEQSFinish);
				break;
			}
			UEnvQuery uEnvQuery = PreloadAssetMgr.TryGetCachedResourceObj<UEnvQuery>(ExtParam.EQSPath, ELoadResourceType.SyncLoadAndCache);
			if (uEnvQuery != null)
			{
				base.BGSEventCollection.Evt_BGS_EQSObjRun.Invoke(uEnvQuery, GetOwner(), EBGURunEQSObjReason.GenPointSet, exParam, OnEQSFinish);
			}
			break;
		}
		case PointsGenType.ByEQS_Sync:
		{
			FGSEQSExParam fGSEQSExParam = new FGSEQSExParam
			{
				ExParam_Int = RequestID
			};
			List<FVector> Locations = new List<FVector>();
			List<float> Scores = new List<float>();
			if (ExtParam.EQSTemplate != null)
			{
				base.BGSEventCollection.Evt_BGS_EQSObjRunInstant.Invoke(ExtParam.EQSTemplate, GetOwner(), out Locations, out Scores);
			}
			else
			{
				UEnvQuery uEnvQuery2 = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UEnvQuery>(ExtParam.EQSPath, ELoadResourceType.SyncLoadAndCache);
				if (uEnvQuery2 != null)
				{
					base.BGSEventCollection.Evt_BGS_EQSObjRunInstant.Invoke(uEnvQuery2, GetOwner(), out Locations, out Scores);
				}
			}
			if (!PointSetsData.PointQueneMap.ContainsKey(RequestID))
			{
				PointSetsData.PointQueneMap.Add(RequestID, new List<FVector>());
			}
			PointSetsData.PointQueneMap[RequestID].Clear();
			PointSetsData.PointQueneMap[RequestID].AddRange(Locations);
			break;
		}
		case PointsGenType.BySocket:
		{
			List<FName> list2 = new List<FName>();
			list2.Add(ExtParam.SocketName);
			if (ExtParam.SocketNameList != null && ExtParam.SocketNameList.Count > 0)
			{
				list2.AddRange(ExtParam.SocketNameList);
			}
			{
				foreach (FName item in list2)
				{
					if (!(item == FName.None))
					{
						USceneComponent SocketOwnerComp;
						FTransform socketOrCompTransform = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, owner, item, out SocketOwnerComp);
						PointSetsData.PointQueneMap[RequestID] = new List<FVector>();
						PointSetsData.PointQueneMap_Rot[RequestID] = new List<FRotator>();
						PointSetsData.PointQueneMap[RequestID].Add(socketOrCompTransform.GetLocation());
						PointSetsData.PointQueneMap_Rot[RequestID].Add(socketOrCompTransform.Rotator());
					}
				}
				break;
			}
		}
		case PointsGenType.BySceneItem:
		{
			if (string.IsNullOrEmpty(ExtParam.SceneItemTag))
			{
				break;
			}
			List<FName> list = new List<FName>();
			list.Add(new FName(ExtParam.SceneItemTag));
			LevelActorData.GetSceneItemsByTags(list, out var OutSceneItems);
			if (!PointSetsData.PointQueneMap.ContainsKey(RequestID))
			{
				PointSetsData.PointQueneMap.Add(RequestID, new List<FVector>());
			}
			else
			{
				PointSetsData.PointQueneMap[RequestID].Clear();
			}
			if (!PointSetsData.PointQueneMap_Rot.ContainsKey(RequestID))
			{
				PointSetsData.PointQueneMap_Rot.Add(RequestID, new List<FRotator>());
			}
			else
			{
				PointSetsData.PointQueneMap_Rot[RequestID].Clear();
			}
			{
				foreach (AActor item2 in OutSceneItems)
				{
					PointSetsData.PointQueneMap[RequestID].Add(BGUFuncLibActorTransformCS.BGUGetActorLocation(item2));
					PointSetsData.PointQueneMap_Rot[RequestID].Add(BGUFuncLibActorTransformCS.BGUGetActorRotation(item2));
				}
				break;
			}
		}
		case PointsGenType.ExplodeLineTrace:
		{
			if (!PointSetsData.PointQueneMap.ContainsKey(RequestID))
			{
				PointSetsData.PointQueneMap.Add(RequestID, new List<FVector>());
			}
			else
			{
				PointSetsData.PointQueneMap[RequestID].Clear();
			}
			if (!PointSetsData.PointQueneMap_Rot.ContainsKey(RequestID))
			{
				PointSetsData.PointQueneMap_Rot.Add(RequestID, new List<FRotator>());
			}
			else
			{
				PointSetsData.PointQueneMap_Rot[RequestID].Clear();
			}
			int explode_DesiredNum = ExtParam.Explode_DesiredNum;
			int num = 0;
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < explode_DesiredNum; j++)
				{
					float num2 = MathLib.RandomFloatInRange(ExtParam.Explode_RangeDir_X.LowerBound.Value, ExtParam.Explode_RangeDir_X.UpperBound.Value);
					float num3 = MathLib.RandomFloatInRange(ExtParam.Explode_RangeDir_Y.LowerBound.Value, ExtParam.Explode_RangeDir_Y.UpperBound.Value);
					float num4 = MathLib.RandomFloatInRange(ExtParam.Explode_RangeDir_Z.LowerBound.Value, ExtParam.Explode_RangeDir_Z.UpperBound.Value);
					FVector fVector = new FVector(num2, num3, num4);
					FVector fVector2 = fVector;
					fVector2 = BGUFuncLibActorTransformCS.BGUGetActorTransform(owner).TransformDirection(fVector);
					fVector2.Normalize();
					FVector fVector3 = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
					FVector endTrace = fVector3 + fVector2 * ExtParam.Explode_LineTraceMaxLength;
					if (UBGUSelectUtil.LineTraceSimple(owner.World, fVector3, endTrace, ExtParam.Explode_TraceTypeQuery, bDebug: false, out var HitResult, null) != 1)
					{
						continue;
					}
					bool flag = false;
					if (ExtParam.Explode_PointMinBetween > 0f)
					{
						foreach (FVector item3 in PointSetsData.PointQueneMap[RequestID])
						{
							flag |= FVector.Distance(item3, HitResult.HitLocation) < ExtParam.Explode_PointMinBetween;
						}
					}
					if (!flag)
					{
						FTransform fTransform = default(FTransform);
						fTransform.SetLocation(HitResult.HitLocation);
						fTransform.SetRotation(HitResult.HitImpactNormal.Conv_VectorToQuaternion());
						PointSetsData.PointQueneMap[RequestID].Add(HitResult.HitLocation);
						PointSetsData.PointQueneMap_Rot[RequestID].Add(fTransform.Rotator());
						num++;
						if (PointSetsData.PointQueneMap[RequestID].Count >= explode_DesiredNum)
						{
							break;
						}
					}
				}
				if (PointSetsData.PointQueneMap[RequestID].Count >= explode_DesiredNum)
				{
					break;
				}
			}
			break;
		}
		}
	}

	private void OnEQSFinish(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
	{
		if (Result.Count != 0)
		{
			if (!PointSetsData.PointQueneMap.ContainsKey(ExParam.ExParam_Int))
			{
				PointSetsData.PointQueneMap.Add(ExParam.ExParam_Int, new List<FVector>());
			}
			PointSetsData.PointQueneMap[ExParam.ExParam_Int].Clear();
			PointSetsData.PointQueneMap[ExParam.ExParam_Int].AddRange(Result);
		}
	}

	private void AddPointsToQuene(int RequestID, List<FVector> Points, bool bClearTheReqQuene)
	{
		if (bClearTheReqQuene && PointSetsData.PointQueneMap.ContainsKey(RequestID))
		{
			PointSetsData.PointQueneMap[RequestID].Clear();
		}
		if (Points.Count > 0)
		{
			if (!PointSetsData.PointQueneMap.ContainsKey(RequestID))
			{
				PointSetsData.PointQueneMap.Add(RequestID, new List<FVector>());
			}
			PointSetsData.PointQueneMap[RequestID].AddRange(Points);
		}
	}
}
