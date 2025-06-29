using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_DynamicSDFDataProcessComp : UActorCompBaseCS
{
	public struct VelocityMotionData
	{
		public FVector Current_First_Velocity;

		public FVector Current_Next_Velocity;

		public FVector Previous_First_Velocity;

		public FVector Previous_Next_Velocity;
	}

	private class GetPerpendicularDirParameters
	{
		public FVector VectorToGet;

		public FVector AnotherDir;

		public FVector FallbackDir;

		public GetPerpendicularDirParameters(FVector VectorToGet)
		{
			this.VectorToGet = VectorToGet;
			AnotherDir = new FVector(0.0, 0.0, 1.0);
			FallbackDir = new FVector(1.0, 0.0, 0.0);
		}

		public GetPerpendicularDirParameters(FVector VectorToGet, FVector AnotherDir)
		{
			this.VectorToGet = VectorToGet;
			this.AnotherDir = AnotherDir;
			FallbackDir = new FVector(1.0, 0.0, 0.0);
		}

		public GetPerpendicularDirParameters(FVector VectorToGet, FVector AnotherDir, FVector FallbackDir)
		{
			this.VectorToGet = VectorToGet;
			this.AnotherDir = AnotherDir;
			this.FallbackDir = FallbackDir;
		}
	}

	private readonly int MaxDataHandleCount = 40;

	private readonly float FallbackRTSize = 512f;

	private readonly float FallbackSimulationSize = 4096f;

	private BUC_DynamicSDFData DynamicSDFData;

	private new TStrongObjectPtr<BGUDynamicSDFGenerator> Owner = new TStrongObjectPtr<BGUDynamicSDFGenerator>();

	private bool InitData_Close;

	public override void OnAttach()
	{
		DynamicSDFData = RequireWritableData<BUC_DynamicSDFData>();
		base.BUSEventCollection.Evt_EventOnSendDispInteractInfo += new Del_EventOnSendDispInteractInfo(EventOnSendDispInteractInfo);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		Owner.Set(GetOwner() as BGUDynamicSDFGenerator);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!InitData_Close)
		{
			InitData();
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		ClearRenderTargets();
	}

	public void InitData()
	{
		Owner.Set(GetOwner() as BGUDynamicSDFGenerator);
		if (Owner.Get().IsNullOrDestroyed())
		{
			return;
		}
		if (DynamicSDFData.NS_Simulator.Get() == null)
		{
			DynamicSDFData.NS_Simulator.Set(Owner.Get().Get_NS_DynamicSDF_Generator());
		}
		if (DynamicSDFData.GlobalMPC.Get() == null)
		{
			string path = "/Game/00Main/Design/Tech/DynamicSDF/ParameterCollection/MPC_DynamicSDF.MPC_DynamicSDF";
			UMaterialParameterCollection uMaterialParameterCollection = BGW_PreloadAssetMgr.Get(Owner.Get())?.TryGetCachedResourceObj<UMaterialParameterCollection>(path, ELoadResourceType.SyncLoadAndCache, EAssetPriority.Top);
			if (uMaterialParameterCollection != null)
			{
				DynamicSDFData.GlobalMPC.Set(uMaterialParameterCollection);
			}
		}
		if (DynamicSDFData.GlobalNPC.Get() == null)
		{
			string path2 = "/Game/00Main/Design/Tech/DynamicSDF/ParameterCollection/NPC_DynamicSDF.NPC_DynamicSDF";
			UNiagaraParameterCollection uNiagaraParameterCollection = BGW_PreloadAssetMgr.Get(Owner.Get())?.TryGetCachedResourceObj<UNiagaraParameterCollection>(path2, ELoadResourceType.SyncLoadAndCache, EAssetPriority.Top);
			if (uNiagaraParameterCollection != null)
			{
				DynamicSDFData.GlobalNPC.Set(UNiagaraFunctionLibrary.GetNiagaraParameterCollection(Owner.Get(), uNiagaraParameterCollection));
			}
		}
		SyncLoadRenderTarget(DynamicSDFData.RTTexturesDir, "RT_DynamicSDF_Base", DynamicSDFData.RT_DynamicSDF_Base);
		SyncLoadRenderTarget(DynamicSDFData.RTTexturesDir, "RT_TimeData", DynamicSDFData.RT_TimeData);
		SyncLoadRenderTarget(DynamicSDFData.RTTexturesDir, "RT_DynamicSDF_Base_Accumulated", DynamicSDFData.RT_DynamicSDF_Base_Accumulated);
		bool bParameterFound;
		float scalarParameterDefaultValue = DynamicSDFData.GlobalMPC.Get().GetScalarParameterDefaultValue(B1GlobalFNames.SimulationSize, out bParameterFound);
		if (bParameterFound)
		{
			DynamicSDFData.SimulationSize = scalarParameterDefaultValue;
		}
		else
		{
			DynamicSDFData.SimulationSize = FallbackSimulationSize;
		}
		bool bParameterFound2;
		float scalarParameterDefaultValue2 = DynamicSDFData.GlobalMPC.Get().GetScalarParameterDefaultValue(B1GlobalFNames.RTSize, out bParameterFound2);
		if (bParameterFound2)
		{
			DynamicSDFData.RTSize = scalarParameterDefaultValue2;
		}
		else
		{
			DynamicSDFData.RTSize = FallbackRTSize;
		}
		BGW_DynamicSDFMgr.Get(Owner.Get()).InitSize(scalarParameterDefaultValue2, scalarParameterDefaultValue);
		DynamicSDFData.BoneMaxPositionChangeFromPreviousThreshold = 30000f;
		DynamicSDFData.MaxDataHandleCount = MaxDataHandleCount;
		InitData_Close = true;
	}

	private void EventOnSendDispInteractInfo(bool Enable, Dictionary<int, FDispInteractInfo> Infos)
	{
		if (Enable)
		{
			OnReceiveInfos(Infos);
		}
	}

	private void UpdateSnappedData(BGW_DynamicSDFMgr SDFMgr)
	{
		DynamicSDFData.centerSnappedPos = SDFMgr.CenterSnappedPos;
		DynamicSDFData.centerSnappedPos_Previous = SDFMgr.CenterSnappedPos_Previous;
		DynamicSDFData.centerSnappedOffset = SDFMgr.CenterSnappedOffset;
		DynamicSDFData.previousCenterSnappedOffset = SDFMgr.PreviousCenterSnappedOffset;
		DynamicSDFData.centerSnappedPos_twoBefore = SDFMgr.CenterSnappedPos_TwoBefore;
		DynamicSDFData.centerPos = SDFMgr.CenterPos;
		DynamicSDFData.previousCenterPos = SDFMgr.PreviousCenterPos;
		DynamicSDFData.centerOffset = SDFMgr.CenterOffset;
	}

	private void OnReceiveInfos(Dictionary<int, FDispInteractInfo> Infos)
	{
		BGW_DynamicSDFMgr bGW_DynamicSDFMgr = BGW_DynamicSDFMgr.Get(Owner.Get());
		if (bGW_DynamicSDFMgr == null)
		{
			return;
		}
		UpdateSnappedData(bGW_DynamicSDFMgr);
		DynamicSDFData.CurrentReceivedDataCount = FMath.Min(Infos.Count, DynamicSDFData.MaxDataHandleCount);
		if (GSGameplayCVar.CVar_DrawDebugSDFInfo.GetValueInGameThread() == 1)
		{
			foreach (KeyValuePair<int, FDispInteractInfo> Info in Infos)
			{
				UBGUFunctionLibraryForCS.BGUDrawDebugCircle(Owner.Get().World, Info.Value.FirstPos, Info.Value.FirstRadius);
				UBGUFunctionLibraryForCS.BGUDrawDebugCircle(Owner.Get().World, Info.Value.NextPos, Info.Value.NextRadius);
			}
		}
		if (Owner.Get().AttachTo.IsNullOrDestroyed())
		{
			AActor controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner.Get()).GetControlledPawn();
			if (!controlledPawn.IsNullOrDestroyed())
			{
				Owner.Get().AttachTo = controlledPawn;
			}
		}
		AActor attachTo = Owner.Get().AttachTo;
		PrepareMotionData_Send_to_Niagara(Infos, attachTo);
	}

	private bool SyncLoadRenderTarget(string BaseDir, string ResourceName, TStrongObjectPtr<UTextureRenderTarget2D> RT)
	{
		if (RT.Get() == null)
		{
			string path = BaseDir + ResourceName + "." + ResourceName;
			UTextureRenderTarget2D uTextureRenderTarget2D = BGW_PreloadAssetMgr.Get(Owner.Get())?.TryGetCachedResourceObj<UTextureRenderTarget2D>(path, ELoadResourceType.SyncLoadAndCache, EAssetPriority.Top);
			if (uTextureRenderTarget2D != null)
			{
				RT.Set(uTextureRenderTarget2D);
				return true;
			}
			return false;
		}
		return true;
	}

	private void ClearRenderTargets()
	{
		URenderingLibrary.ClearRenderTarget2D(Owner.Get(), DynamicSDFData.RT_DynamicSDF_Base.Get(), new FLinearColor(65535f, 0f, -65535f, 0f));
		URenderingLibrary.ClearRenderTarget2D(Owner.Get(), DynamicSDFData.RT_TimeData.Get(), new FLinearColor(0f, 0f, 0f, 0f));
		URenderingLibrary.ClearRenderTarget2D(Owner.Get(), DynamicSDFData.RT_DynamicSDF_Base_Accumulated.Get(), new FLinearColor(65535f, 0f, 0f, 0f));
	}

	private FDispInteractInfo ChangeDataPosition(FDispInteractInfo OrigData, FVector newPosition_First, FVector newPosition_Next)
	{
		return new FDispInteractInfo
		{
			FirstPos = newPosition_First,
			FirstRadius = OrigData.FirstRadius,
			NextPos = newPosition_Next,
			NextRadius = OrigData.NextRadius
		};
	}

	private FDispInteractInfo TransformDataPosition_World_to_Local(FDispInteractInfo OrigData)
	{
		FVector newPosition_First = OrigData.FirstPos - DynamicSDFData.centerSnappedPos;
		FVector newPosition_Next = OrigData.NextPos - DynamicSDFData.centerSnappedPos;
		return ChangeDataPosition(OrigData, newPosition_First, newPosition_Next);
	}

	private FVector GetPerpendicularDir_ofVector(GetPerpendicularDirParameters inputs)
	{
		float num = FVector.DotProduct(inputs.VectorToGet, inputs.VectorToGet);
		float num2 = FVector.DotProduct(inputs.VectorToGet, inputs.AnotherDir);
		FVector result = ((!(Math.Abs(num2) < 1E-08f)) ? (num / num2 * inputs.AnotherDir - inputs.VectorToGet).GetSafeNormal() : FVector.ZeroVector);
		bool flag = false;
		if (num == 0f)
		{
			flag = true;
		}
		else if (num2 * num2 / num > 0.99999f)
		{
			flag = true;
		}
		if (flag)
		{
			return inputs.FallbackDir;
		}
		return result;
	}

	private FVector GetFaceNormal(FVector O, FVector A, FVector B, FVector MainVectorWhenFallback)
	{
		FVector fVector = A - O;
		FVector fVector2 = B - O;
		FVector result = ((!(FVector.DotProduct(fVector, fVector) < 1E-05f) && !(FVector.DotProduct(fVector2, fVector2) < 1E-05f)) ? MathLib.CrossProduct(fVector, fVector2).GetSafeNormal() : FVector.ZeroVector);
		bool num = !result.Normalize();
		GetPerpendicularDirParameters inputs = new GetPerpendicularDirParameters(MainVectorWhenFallback, new FVector(0.0, 0.0, 1.0), new FVector(-1.0, 0.0, 0.0));
		FVector perpendicularDir_ofVector = GetPerpendicularDir_ofVector(inputs);
		if (num)
		{
			return perpendicularDir_ofVector;
		}
		return result;
	}

	private FDispInteractInfo JitterDataPosition(FDispInteractInfo OrigData)
	{
		FVector newPosition_First = OrigData.FirstPos + new FVector(5.0, 5.0, 0.0);
		FVector newPosition_Next = OrigData.NextPos + new FVector(-5.0, -5.0, 0.0);
		return ChangeDataPosition(OrigData, newPosition_First, newPosition_Next);
	}

	private FDispInteractInfo TransformDataPosition_PreviousLocal_to_CurrentLocal(FDispInteractInfo PreviousLocalData)
	{
		FVector newPosition_First = PreviousLocalData.FirstPos - DynamicSDFData.centerSnappedOffset;
		FVector newPosition_Next = PreviousLocalData.NextPos - DynamicSDFData.centerSnappedOffset;
		return ChangeDataPosition(PreviousLocalData, newPosition_First, newPosition_Next);
	}

	private float GetMaxSquaredDistanceBetweenDispInteractInfo(FDispInteractInfo infoA, FDispInteractInfo infoB)
	{
		FVector firstPos = infoA.FirstPos;
		FVector nextPos = infoA.NextPos;
		FVector firstPos2 = infoB.FirstPos;
		FVector nextPos2 = infoB.NextPos;
		float val = FVector.DotProduct(firstPos, nextPos);
		float val2 = FVector.DotProduct(firstPos2, nextPos2);
		return FMath.Max(val, val2);
	}

	private FDispInteractInfo GetStoredData(int dataID, Dictionary<int, FDispInteractInfo> DataStorageDict, FDispInteractInfo defaultData)
	{
		if (DataStorageDict.TryGetValue(dataID, out var value))
		{
			if (GetMaxSquaredDistanceBetweenDispInteractInfo(value, defaultData) > DynamicSDFData.BoneMaxPositionChangeFromPreviousThreshold * DynamicSDFData.BoneMaxPositionChangeFromPreviousThreshold)
			{
				return JitterDataPosition(defaultData);
			}
			return TransformDataPosition_PreviousLocal_to_CurrentLocal(value);
		}
		return JitterDataPosition(defaultData);
	}

	private List<FVector> CalculateVelocity(FDispInteractInfo current, FDispInteractInfo previous)
	{
		FVector item = current.FirstPos - previous.FirstPos;
		FVector item2 = current.NextPos - previous.NextPos;
		return new List<FVector> { item, item2 };
	}

	private void SerializeMotionData_Base(FDispInteractInfo data, List<FVector4> storeBuffer)
	{
		FVector4 item = new FVector4(data.FirstPos, data.FirstRadius);
		FVector4 item2 = new FVector4(data.NextPos, data.NextRadius);
		storeBuffer.Add(item);
		storeBuffer.Add(item2);
	}

	private void SerializeMotionData_Velocity(VelocityMotionData data, List<FVector> storeBuffer)
	{
		storeBuffer.Add(data.Current_First_Velocity);
		storeBuffer.Add(data.Current_Next_Velocity);
		storeBuffer.Add(data.Previous_First_Velocity);
		storeBuffer.Add(data.Previous_Next_Velocity);
	}

	private void StoreData(int dataID, FDispInteractInfo data_toStore, Dictionary<int, FDispInteractInfo> storageDict)
	{
		if (!storageDict.TryGetValue(dataID, out var _))
		{
			storageDict.Add(dataID, default(FDispInteractInfo));
		}
		storageDict[dataID] = data_toStore;
	}

	private void SendMotionData_toNiagara(List<FVector4> baseData, List<FVector> velocityData, List<FVector> vertexNormalData)
	{
		UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector4(DynamicSDFData.NS_Simulator.Get(), B1GlobalFNames.User_Data, baseData);
		UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector(DynamicSDFData.NS_Simulator.Get(), B1GlobalFNames.User_VelocityData, velocityData);
		UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector(DynamicSDFData.NS_Simulator.Get(), B1GlobalFNames.User_VertexNormalData, vertexNormalData);
		UNiagaraComponent uNiagaraComponent = DynamicSDFData.NS_Simulator.Get();
		if (uNiagaraComponent != null)
		{
			uNiagaraComponent.SetVectorParameter(B1GlobalFNames.User_CenterSnappedPosition, DynamicSDFData.centerSnappedPos);
			uNiagaraComponent.SetVectorParameter(B1GlobalFNames.User_CenterSnappedOffset, DynamicSDFData.centerSnappedOffset);
			uNiagaraComponent.SetIntParameter(B1GlobalFNames.User_ReceivedDataCount, DynamicSDFData.CurrentReceivedDataCount);
		}
	}

	public void TickSendData_toParameterCollector(AActor Owner)
	{
		if (DynamicSDFData.GlobalNPC.Get() != null)
		{
			DynamicSDFData.GlobalNPC.Get()?.SetVector4Parameter("CenterSnappedPos_WorldSpace", new FVector4(3000.0, -150.0, -10.0));
		}
		if (DynamicSDFData.GlobalMPC.Get() != null)
		{
			UMaterialLibrary.SetVectorParameterValue(Owner.World, DynamicSDFData.GlobalMPC.Get(), B1GlobalFNames.CenterSnappedPos_WorldSpace, new FLinearColor(DynamicSDFData.centerSnappedPos));
			UMaterialLibrary.SetVectorParameterValue(Owner.World, DynamicSDFData.GlobalMPC.Get(), B1GlobalFNames.CenterSnappedOffset, new FLinearColor(DynamicSDFData.centerSnappedOffset));
			UMaterialLibrary.SetVectorParameterValue(Owner.World, DynamicSDFData.GlobalMPC.Get(), B1GlobalFNames.PreviousCenterSnappedPosWS, new FLinearColor(DynamicSDFData.centerSnappedPos_Previous));
			UMaterialLibrary.SetVectorParameterValue(Owner.World, DynamicSDFData.GlobalMPC.Get(), B1GlobalFNames.PreviousCenterSnappedOffset, new FLinearColor(DynamicSDFData.previousCenterSnappedOffset));
			UMaterialLibrary.SetVectorParameterValue(Owner.World, DynamicSDFData.GlobalMPC.Get(), B1GlobalFNames.CenterPos, new FLinearColor(DynamicSDFData.centerPos));
			UMaterialLibrary.SetVectorParameterValue(Owner.World, DynamicSDFData.GlobalMPC.Get(), B1GlobalFNames.PreviousCenterPos, new FLinearColor(DynamicSDFData.previousCenterPos));
			UMaterialLibrary.SetVectorParameterValue(Owner.World, DynamicSDFData.GlobalMPC.Get(), B1GlobalFNames.CenterOffset, new FLinearColor(DynamicSDFData.centerOffset));
		}
	}

	private void PrepareMotionData_Send_to_Niagara(Dictionary<int, FDispInteractInfo> DataDict, AActor Owner)
	{
		List<FVector4> list = new List<FVector4>();
		List<FVector> list2 = new List<FVector>();
		List<FVector> list3 = new List<FVector>();
		foreach (KeyValuePair<int, FDispInteractInfo> item in DataDict)
		{
			FDispInteractInfo fDispInteractInfo = TransformDataPosition_World_to_Local(item.Value);
			FDispInteractInfo storedData = GetStoredData(item.Key, DynamicSDFData.previousData_dict, fDispInteractInfo);
			FDispInteractInfo storedData2 = GetStoredData(item.Key, DynamicSDFData.twoBeforeData_dict, storedData);
			List<FVector> list4 = CalculateVelocity(fDispInteractInfo, storedData);
			CalculateVelocity(storedData, storedData2);
			VelocityMotionData data = new VelocityMotionData
			{
				Current_First_Velocity = list4[0],
				Current_Next_Velocity = list4[1],
				Previous_First_Velocity = list4[0],
				Previous_Next_Velocity = list4[1]
			};
			FVector firstPos = fDispInteractInfo.FirstPos;
			FVector nextPos = fDispInteractInfo.NextPos;
			FVector nextPos2 = storedData.NextPos;
			FVector firstPos2 = storedData.FirstPos;
			FVector faceNormal = GetFaceNormal(firstPos, nextPos, firstPos2, firstPos - nextPos);
			FVector faceNormal2 = GetFaceNormal(nextPos, nextPos2, firstPos, firstPos - nextPos);
			FVector faceNormal3 = GetFaceNormal(nextPos2, firstPos2, nextPos, firstPos2 - nextPos2);
			FVector faceNormal4 = GetFaceNormal(firstPos2, firstPos, nextPos2, firstPos2 - nextPos2);
			list3.Add(faceNormal);
			list3.Add(faceNormal2);
			list3.Add(faceNormal4);
			list3.Add(faceNormal3);
			SerializeMotionData_Base(fDispInteractInfo, list);
			SerializeMotionData_Base(storedData, list);
			SerializeMotionData_Velocity(data, list2);
			StoreData(item.Key, storedData, DynamicSDFData.twoBeforeData_dict);
			StoreData(item.Key, fDispInteractInfo, DynamicSDFData.previousData_dict);
		}
		SendMotionData_toNiagara(list, list2, list3);
		TickSendData_toParameterCollector(Owner);
	}
}
