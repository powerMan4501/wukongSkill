using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BUS_DispLibWEFMComp : BUS_DispLibCompBase
{
	private BUC_DispLibUnitRendererBaseData UnitRendererBaseData;

	private BUC_DispLibWEFMRequestsQueueData RequestsQueue;

	private BWS_DispLibEventCollection DispWorld_EC;

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		UnitRendererBaseData = RequireWritableData<BUC_DispLibUnitRendererBaseData>();
		RequestsQueue = RequireWritableData<BUC_DispLibWEFMRequestsQueueData>();
		DispWorld_EC = BWS_DispLibEventCollection.Get(DispLibDispWorld.GetInstance(GetOwner()));
		BUS_DispLibEventCollection dispLibEventCollection = base.DispLibEventCollection;
		dispLibEventCollection.Evt_RequestDynamicWindEvent = (BUS_DispLibEventCollection.Del_RequestInjectWind)Delegate.Combine(dispLibEventCollection.Evt_RequestDynamicWindEvent, new BUS_DispLibEventCollection.Del_RequestInjectWind(RequestDynamicWindEvent));
		BUS_DispLibEventCollection dispLibEventCollection2 = base.DispLibEventCollection;
		dispLibEventCollection2.Evt_RequestPauseWind = (BUS_DispLibEventCollection.Del_RequestPauseWind)Delegate.Combine(dispLibEventCollection2.Evt_RequestPauseWind, new BUS_DispLibEventCollection.Del_RequestPauseWind(RequestPauseWind));
		BUS_DispLibEventCollection dispLibEventCollection3 = base.DispLibEventCollection;
		dispLibEventCollection3.Evt_RequestContinueWind = (BUS_DispLibEventCollection.Del_RequestContinueWind)Delegate.Combine(dispLibEventCollection3.Evt_RequestContinueWind, new BUS_DispLibEventCollection.Del_RequestContinueWind(RequestContinueWind));
	}

	private void RequestDynamicWindEvent(ref uint RequesterUniqueID, FVector CenterPosWS, FVector DirWS, FVector WindSizeV3, float WindIntensity, int WindType, float DistanceDamplingRate, FVector4 WindDataV4, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		DispWorld_EC?.Evt_DLDWorld_RequestDirectInject_Wind(ref RequesterUniqueID, CenterPosWS, DirWS, WindSizeV3, WindIntensity, WindType, DistanceDamplingRate, WindDataV4, AnimNotifyUniqueID, MontageUniqueID);
	}

	private void RequestPauseWind(FName EventName)
	{
		for (int i = 0; i < RequestsQueue.PermanentWindRequests.Length; i++)
		{
			if (RequestsQueue.PermanentWindRequests[i].EventName.PlainName == EventName.PlainName)
			{
				RequestsQueue.PermanentWindRequests[i].isPause = true;
			}
		}
	}

	private void RequestContinueWind(FName EventName)
	{
		for (int i = 0; i < RequestsQueue.PermanentWindRequests.Length; i++)
		{
			if (RequestsQueue.PermanentWindRequests[i].EventName.PlainName == EventName.PlainName)
			{
				RequestsQueue.PermanentWindRequests[i].isPause = false;
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (DispWorld_EC == null || RequestsQueue == null)
		{
			return;
		}
		for (int i = 0; i < RequestsQueue.PermanentWindRequests.Length; i++)
		{
			if (RequestsQueue.PermanentWindRequests[i].MotorType == 0 || RequestsQueue.PermanentWindRequests[i].isPause)
			{
				continue;
			}
			BUC_DispLib_PermanentWindMotor bUC_DispLib_PermanentWindMotor = RequestsQueue.PermanentWindRequests[i];
			FTransform socketTransform = UnitRendererBaseData.OriginMeshComp.GetSocketTransform(bUC_DispLib_PermanentWindMotor.SocketName);
			FVector location = socketTransform.GetLocation();
			FVector fVector = (location - bUC_DispLib_PermanentWindMotor.LastFrameSocketPosWS) / DeltaTime;
			bUC_DispLib_PermanentWindMotor.LastFrameSocketPosWS = location;
			fVector.ToDirectionAndLength(out var dir, out var length);
			if (!(length < bUC_DispLib_PermanentWindMotor.VelocityThreshold))
			{
				FVector centerPosWS = socketTransform.TransformPosition(bUC_DispLib_PermanentWindMotor.SocketLocalOffset);
				FVector axisVector = DispLibFuncUtil.GetAxisVector(bUC_DispLib_PermanentWindMotor.VelocityDir, UnitRendererBaseData.OriginMeshComp, socketTransform, dir, bUC_DispLib_PermanentWindMotor.VelocityDirLocalRotation);
				FVector axisVector2 = DispLibFuncUtil.GetAxisVector(bUC_DispLib_PermanentWindMotor.RangeAxis, UnitRendererBaseData.OriginMeshComp, socketTransform, dir, bUC_DispLib_PermanentWindMotor.RangeAxisLocalRotation);
				if (bUC_DispLib_PermanentWindMotor.WindMotorMode != DispLibDBCWindMotorMode.LocalDirectionalWind && bUC_DispLib_PermanentWindMotor.WindMotorMode != DispLibDBCWindMotorMode.NoWind)
				{
					axisVector *= (double)bUC_DispLib_PermanentWindMotor.ScaleSecondVelocity;
				}
				float num = bUC_DispLib_PermanentWindMotor.BaseIntensity + bUC_DispLib_PermanentWindMotor.ScaleVelocityIntensity * length;
				if (!(num <= 0.0001f))
				{
					DispWorld_EC.Evt_DLDWorld_RequestDirectInject_Wind(ref bUC_DispLib_PermanentWindMotor.RequesterUniqueID, centerPosWS, axisVector, bUC_DispLib_PermanentWindMotor.SizeV3, num, bUC_DispLib_PermanentWindMotor.MotorType, bUC_DispLib_PermanentWindMotor.DistanceDamplingRate, new FVector4(axisVector2, bUC_DispLib_PermanentWindMotor.RangeMask));
				}
			}
		}
		for (int j = 0; j < RequestsQueue.PermanentHeatRequests.Length; j++)
		{
			if (RequestsQueue.PermanentHeatRequests[j].isPause)
			{
				continue;
			}
			BUC_DispLib_PermanentHeatMotor bUC_DispLib_PermanentHeatMotor = RequestsQueue.PermanentHeatRequests[j];
			if (!(FMath.FRand() >= bUC_DispLib_PermanentHeatMotor.TriggerProbability))
			{
				FTransform socketTransform2 = UnitRendererBaseData.OriginMeshComp.GetSocketTransform(bUC_DispLib_PermanentHeatMotor.SocketName);
				FVector centerPosWS2 = socketTransform2.TransformPosition(bUC_DispLib_PermanentHeatMotor.SocketLocalOffset);
				FVector socketVelocity = FVector.ZeroVector;
				if (bUC_DispLib_PermanentHeatMotor.NeedCalBoneVelocity)
				{
					FVector location2 = socketTransform2.GetLocation();
					socketVelocity = (location2 - bUC_DispLib_PermanentHeatMotor.LastFrameSocketPosWS) / DeltaTime;
					bUC_DispLib_PermanentHeatMotor.LastFrameSocketPosWS = location2;
				}
				socketVelocity.ToDirectionAndLength(out var _, out var _);
				FVector axisVector3 = DispLibFuncUtil.GetAxisVector(bUC_DispLib_PermanentHeatMotor.RangeAxis, UnitRendererBaseData.OriginMeshComp, socketTransform2, socketVelocity, bUC_DispLib_PermanentHeatMotor.SocketLocalRotation);
				float intensity = FMath.Lerp(bUC_DispLib_PermanentHeatMotor.MinIntensity, bUC_DispLib_PermanentHeatMotor.MaxIntensity, FMath.FRand());
				DispWorld_EC.Evt_DLDWorld_RequestDirectInject_Heat(out var _, centerPosWS2, bUC_DispLib_PermanentHeatMotor.SizeV3, intensity, bUC_DispLib_PermanentHeatMotor.DistanceDamplingRate, new FVector4(axisVector3, bUC_DispLib_PermanentHeatMotor.RangeMask));
			}
		}
	}
}
