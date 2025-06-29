using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_SpiderOceanMgrData : IBUC_SpiderOceanMgrData, IPersistentECSData
{
	public ANiagaraActor SpiderNiagara { get; set; }

	public List<ANiagaraActor> AdditionalSpiderNiagaraList { get; set; }

	public BGUSplineActor NiagaraSpline { get; set; }

	public int SpiderFollowStartIndex { get; set; }

	public AActor SpiderSectorActor { get; set; }

	public UCurveFloat NiagaraMoveCurve { get; set; }

	public UCurveFloat SpiderDistanceCurve { get; set; }

	public UCurveFloat SpiderSpawnPointsSelectCurve { get; set; }

	public bool bShouldDrawDebugNiagaraLocation { get; set; }

	public FName SpiderSpawnPointTag { get; set; }

	public UCurveVector SectorScaleCurve { get; set; }

	public AActor ScaleReferenceActor { get; set; }

	public int SplinePointIndex { get; set; }

	public int LastSplinePointIndex { get; set; }

	public Dictionary<FName, List<ATargetPoint>> SpiderSpawnPoints { get; set; }

	public int CurrentSpawnPointIndex { get; set; }

	public float SpiderCurveTimer { get; set; }

	public bool bStartFollowPlayer { get; set; }

	public FVector VirtualSpiderNiagaraLocation { get; set; }

	public FVector DefaultSpiderNiagaraLocation { get; set; }

	public bool bHasTriggeredByOverlap { get; set; }

	public void CopyBPDataToData(ANiagaraActor InSpiderNiagara, List<ANiagaraActor> InAdditionalSpiderNiagaraList, BGUSplineActor InNiagaraSpline, int InSpiderFollowStartIndex, AActor InSpiderSectorActor, UCurveFloat InNiagaraMoveCurve, UCurveFloat InSpiderDistanceCurve, List<SpiderSpawnPointData> InSpiderSpawnPoints, UCurveFloat InSpiderSpawnPointsSelectCurve, bool bDrawDebugNiagaraLocation, FName InSpiderSpawnPointTag, UCurveVector InScaleCurve)
	{
		SpiderNiagara = InSpiderNiagara;
		AdditionalSpiderNiagaraList = InAdditionalSpiderNiagaraList;
		NiagaraSpline = InNiagaraSpline;
		SpiderFollowStartIndex = InSpiderFollowStartIndex;
		SpiderSectorActor = InSpiderSectorActor;
		NiagaraMoveCurve = InNiagaraMoveCurve;
		SpiderDistanceCurve = InSpiderDistanceCurve;
		SpiderSpawnPoints = new Dictionary<FName, List<ATargetPoint>>();
		foreach (SpiderSpawnPointData InSpiderSpawnPoint in InSpiderSpawnPoints)
		{
			SpiderSpawnPoints.Add(InSpiderSpawnPoint.Tag, InSpiderSpawnPoint.SpiderSpawnPoints);
		}
		SpiderSpawnPointsSelectCurve = InSpiderSpawnPointsSelectCurve;
		bShouldDrawDebugNiagaraLocation = bDrawDebugNiagaraLocation;
		SpiderSpawnPointTag = InSpiderSpawnPointTag;
		SectorScaleCurve = InScaleCurve;
	}
}
