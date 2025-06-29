using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_SpiderOceanMgrCompImpl : BUS_QuestOverlapComponent
{
	private BUC_SpiderOceanMgrData SpiderOceanData;

	private bool bStartTick;

	private bool bHasForceTriggered;

	private APlayerController PlayerController;

	public override void OnAttach()
	{
		base.OnAttach();
		SpiderOceanData = RequireWritableData<BUC_SpiderOceanMgrData>();
		base.BUSEventCollection.Evt_ForceTrigger += new Del_Void_Actor(OnForceTrigger);
		PlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		SpiderOceanData.DefaultSpiderNiagaraLocation = SpiderOceanData.SpiderNiagara.GetActorLocation();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		if (!bStartTick)
		{
			return;
		}
		ANiagaraActor spiderNiagara = SpiderOceanData.SpiderNiagara;
		BGUSplineActor niagaraSpline = SpiderOceanData.NiagaraSpline;
		if (!(spiderNiagara == null))
		{
			if (niagaraSpline != null)
			{
				TickMoveSpiderNiagara(DeltaTime, niagaraSpline, spiderNiagara);
			}
			float floatValue = SpiderOceanData.SpiderDistanceCurve.GetFloatValue(SpiderOceanData.SpiderCurveTimer);
			TickUpdateSpiderStayDistance(spiderNiagara, floatValue);
			TickUpdateSpiderSectorShape(spiderNiagara, floatValue);
			SpiderOceanData.SpiderCurveTimer += DeltaTime;
		}
	}

	private void OnForceTrigger(AActor Actor)
	{
		OnActivateSpiderOcean(Actor);
		bHasForceTriggered = true;
	}

	protected override void OnReset()
	{
		base.OnReset();
		bHasForceTriggered = false;
		bStartTick = false;
		SpiderOceanData.bHasTriggeredByOverlap = false;
		SpiderOceanData.SpiderNiagara.SetActorLocation(SpiderOceanData.DefaultSpiderNiagaraLocation, bSweep: false, out var _, bTeleport: false);
		SpiderOceanData.SpiderNiagara.NiagaraComponent.Deactivate();
		SpiderOceanData.SpiderNiagara.NiagaraComponent.SetVisibility(bNewVisibility: false);
		foreach (ANiagaraActor additionalSpiderNiagara in SpiderOceanData.AdditionalSpiderNiagaraList)
		{
			if (additionalSpiderNiagara != null)
			{
				additionalSpiderNiagara.NiagaraComponent.Deactivate();
				additionalSpiderNiagara.NiagaraComponent.SetVisibility(bNewVisibility: false);
			}
		}
	}

	protected override void OnCollisionBeginOverlapImpl(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		if (!bHasForceTriggered && !SpiderOceanData.bHasTriggeredByOverlap)
		{
			OnActivateSpiderOcean(OtherActor);
			SpiderOceanData.bHasTriggeredByOverlap = true;
		}
	}

	private void TickMoveSpiderNiagara(float DeltaTime, BGUSplineActor SpiderSpline, ANiagaraActor SpiderNiagara)
	{
		if (SpiderOceanData.bStartFollowPlayer)
		{
			if (PlayerController != null && PlayerController.GetControlledPawn() != null)
			{
				FVector newLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(PlayerController.GetControlledPawn());
				SpiderNiagara.SetActorLocation(newLocation, bSweep: false, out var _, bTeleport: false);
			}
			if (SpiderOceanData.bShouldDrawDebugNiagaraLocation)
			{
				USystemLibrary.DrawDebugSphere(GetOwner(), SpiderNiagara.GetActorLocation(), 100f, 32, FLinearColor.AliceBlue, 0f, 4f);
			}
		}
		if (SpiderOceanData.SplinePointIndex >= SpiderSpline.SplineComp.GetNumberOfSplinePoints())
		{
			return;
		}
		float floatValue = SpiderOceanData.NiagaraMoveCurve.GetFloatValue(SpiderOceanData.SplinePointIndex);
		FVector locationAtSplinePoint = SpiderSpline.SplineComp.GetLocationAtSplinePoint(SpiderOceanData.SplinePointIndex, ESplineCoordinateSpace.World);
		FVector fVector = FMath.VInterpConstantTo(SpiderOceanData.VirtualSpiderNiagaraLocation, locationAtSplinePoint, DeltaTime, floatValue);
		SpiderOceanData.VirtualSpiderNiagaraLocation = fVector;
		if (fVector == locationAtSplinePoint && SpiderOceanData.SplinePointIndex++ == SpiderOceanData.SpiderFollowStartIndex)
		{
			SpiderOceanData.bStartFollowPlayer = true;
			SpiderNiagara.NiagaraComponent.SetNiagaraVariableFloat("StageSwitchAlpha", 1f);
		}
		if (!SpiderOceanData.bStartFollowPlayer)
		{
			FRotator rotationAtSplinePoint = SpiderSpline.SplineComp.GetRotationAtSplinePoint(SpiderOceanData.SplinePointIndex, ESplineCoordinateSpace.World);
			FRotator newRotation = FMath.RInterpConstantTo(SpiderNiagara.GetActorRotation(), rotationAtSplinePoint, DeltaTime, floatValue);
			SpiderNiagara.SetActorLocationAndRotation(fVector, newRotation, bSweep: false, out var _, bTeleport: false);
			if (SpiderOceanData.bShouldDrawDebugNiagaraLocation)
			{
				USystemLibrary.DrawDebugSphere(GetOwner(), SpiderNiagara.GetActorLocation(), 100f, 32, FLinearColor.AliceBlue, 0f, 4f);
			}
		}
		if (SpiderOceanData.SplinePointIndex > 0 && SpiderOceanData.SplinePointIndex != SpiderOceanData.LastSplinePointIndex)
		{
			float floatValue2 = SpiderOceanData.SpiderSpawnPointsSelectCurve.GetFloatValue(SpiderOceanData.LastSplinePointIndex);
			SelectSpiderSpawnPoints((int)floatValue2, SpiderNiagara);
		}
		SpiderOceanData.LastSplinePointIndex = SpiderOceanData.SplinePointIndex;
	}

	private void TickUpdateSpiderStayDistance(ANiagaraActor SpiderNiagara, float Distance)
	{
		SpiderNiagara.NiagaraComponent.SetNiagaraVariableFloat("Stage1StayDistance", Distance);
	}

	private void TickUpdateSpiderSectorShape(ANiagaraActor SpiderNiagara, float Distance)
	{
		UCurveVector sectorScaleCurve = SpiderOceanData.SectorScaleCurve;
		if (sectorScaleCurve != null)
		{
			FVector actorForwardVector = SpiderNiagara.GetActorForwardVector();
			FVector actorRightVector = SpiderNiagara.GetActorRightVector();
			FVector vectorValue = sectorScaleCurve.GetVectorValue(SpiderOceanData.SpiderCurveTimer);
			FVector fVector = SpiderNiagara.GetActorLocation() - actorForwardVector * Distance;
			float num = 50f * 0.5f * 1.732051f * vectorValue.X;
			float num2 = 50f * 0.5f * vectorValue.Y;
			FVector fVector2 = fVector + actorForwardVector * num;
			FVector fVector3 = fVector2 - actorRightVector * num2;
			FVector fVector4 = fVector2 + actorRightVector * num2;
			FVector safeNormal2D = (fVector3 - fVector).GetSafeNormal2D();
			FVector safeNormal2D2 = (fVector4 - fVector).GetSafeNormal2D();
			FRotator fRotator = new FRotator(0.0, SpiderNiagara.GetActorRotation().Yaw, 0.0);
			FTransform fTransform = new FTransform(fRotator);
			FTransform fTransform2 = new FTransform(safeNormal2D);
			safeNormal2D = (fTransform * fTransform2).GetLocation().GetSafeNormal();
			FTransform fTransform3 = new FTransform(safeNormal2D2);
			safeNormal2D2 = (fTransform * fTransform3).GetLocation().GetSafeNormal();
			SpiderNiagara.NiagaraComponent.SetNiagaraVariableVec3("Stage1FanShapePosition", fVector);
			SpiderNiagara.NiagaraComponent.SetNiagaraVariableVec3("Stage1FanShapeVector1", safeNormal2D);
			SpiderNiagara.NiagaraComponent.SetNiagaraVariableVec3("Stage1FanShapeVector2", safeNormal2D2);
			if (SpiderOceanData.ScaleReferenceActor != null)
			{
				float z = BGUFuncLibActorTransformCS.BGUGetActorLocation(SpiderOceanData.ScaleReferenceActor).Z;
				fVector.Z = z - 10f;
			}
			SpiderOceanData.SpiderSectorActor.SetActorLocationAndRotation(fVector, fRotator, bSweep: false, out var _, bTeleport: false);
			SpiderOceanData.SpiderSectorActor.SetActorScale3D(vectorValue);
			if (SpiderOceanData.bShouldDrawDebugNiagaraLocation)
			{
				USystemLibrary.DrawDebugSphere(GetOwner(), fVector, 50f, 32, FLinearColor.Green, 0f, 4f);
				USystemLibrary.DrawDebugArrow(GetOwner(), fVector, fVector + safeNormal2D * 300.0, 50f, FLinearColor.Green, 0f, 4f);
				USystemLibrary.DrawDebugArrow(GetOwner(), fVector, fVector + safeNormal2D2 * 300.0, 50f, FLinearColor.Green, 0f, 4f);
			}
		}
	}

	private void OnActivateSpiderOcean(AActor ScaleReferenceActor)
	{
		ANiagaraActor spiderNiagara = SpiderOceanData.SpiderNiagara;
		if (spiderNiagara != null)
		{
			spiderNiagara.NiagaraComponent.SetVisibility(bNewVisibility: true);
			spiderNiagara.NiagaraComponent.ReinitializeSystem();
			spiderNiagara.NiagaraComponent.SetNiagaraVariableFloat("StageSwitchAlpha", 0f);
			List<FVector> list = new List<FVector>();
			UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector(spiderNiagara.NiagaraComponent, B1GlobalFNames.SpawnPoints, list);
			if (SpiderOceanData.SpiderSpawnPointsSelectCurve == null)
			{
				foreach (ATargetPoint item in SpiderOceanData.SpiderSpawnPoints[SpiderOceanData.SpiderSpawnPointTag])
				{
					list.Add(item.GetActorLocation());
				}
				UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector(spiderNiagara.NiagaraComponent, B1GlobalFNames.SpawnPoints, list);
			}
			SpiderOceanData.ScaleReferenceActor = ScaleReferenceActor;
			SpiderOceanData.SplinePointIndex = 0;
			SpiderOceanData.LastSplinePointIndex = -1;
			SpiderOceanData.CurrentSpawnPointIndex = 0;
			SpiderOceanData.SpiderCurveTimer = 0f;
			SpiderOceanData.VirtualSpiderNiagaraLocation = spiderNiagara.GetActorLocation();
			SpiderOceanData.bStartFollowPlayer = false;
			bStartTick = true;
		}
		foreach (ANiagaraActor additionalSpiderNiagara in SpiderOceanData.AdditionalSpiderNiagaraList)
		{
			if (additionalSpiderNiagara != null)
			{
				additionalSpiderNiagara.NiagaraComponent.SetVisibility(bNewVisibility: true);
				additionalSpiderNiagara.NiagaraComponent.ReinitializeSystem();
			}
		}
	}

	private void SelectSpiderSpawnPoints(int SpawnPointCount, ANiagaraActor SpiderNiagara)
	{
		FName spiderSpawnPointTag = SpiderOceanData.SpiderSpawnPointTag;
		if (!SpiderOceanData.SpiderSpawnPoints.ContainsKey(spiderSpawnPointTag))
		{
			return;
		}
		List<FVector> list = new List<FVector>();
		List<ATargetPoint> list2 = SpiderOceanData.SpiderSpawnPoints[spiderSpawnPointTag];
		if (SpiderOceanData.CurrentSpawnPointIndex >= 0 && SpiderOceanData.CurrentSpawnPointIndex < list2.Count)
		{
			for (int i = SpiderOceanData.CurrentSpawnPointIndex; i < SpiderOceanData.CurrentSpawnPointIndex + SpawnPointCount; i++)
			{
				list.Add(list2[i].GetActorLocation());
			}
			UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector(SpiderNiagara.NiagaraComponent, B1GlobalFNames.SpawnPoints, list);
			SpiderOceanData.CurrentSpawnPointIndex += SpawnPointCount;
		}
	}
}
