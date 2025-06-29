using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_InteractDrawComp : UActorCompBaseCS
{
	protected struct VelocityMotionData
	{
		public FVector Current_First_Velocity;

		public FVector Current_Next_Velocity;

		public FVector Previous_First_Velocity;

		public FVector Previous_Next_Velocity;
	}

	private BUC_InteractDrawData InteractDrawData;

	private TStrongObjectPtr<BGUDispInteractActor> DIOwner = new TStrongObjectPtr<BGUDispInteractActor>();

	public override void OnAttach()
	{
		InteractDrawData = RequireWritableData<BUC_InteractDrawData>();
		base.BUSEventCollection.Evt_EventOnPlayerChangeVolume += new Del_EventOnPlayerChangeVolume(EventOnPlayerChangeVolume);
		base.BUSEventCollection.Evt_EventOnSendDispInteractInfo += new Del_EventOnSendDispInteractInfo(EventOnSendDispInteractInfo);
		base.BUSEventCollection.Evt_EventOnUpdateDispInteractNSSystem += new Del_EventOnUpdateDispInteractNSSystem(EventOnUpdate_NSSystem);
		base.BUSEventCollection.Evt_OnDisableDispInteractNSSystem += new Del_Void(DisableNSSystem);
	}

	public override void OnBeginPlay()
	{
		DIOwner.Set(GetOwner() as BGUDispInteractActor);
	}

	private void EventOnPlayerChangeVolume(FDispInteractLandscapeInfo InteractLandscapeInfo)
	{
		InteractDrawData.InteractiveDataStorageSize = InteractLandscapeInfo.InteractiveData_StorageSize_cm;
		InteractDrawData.SimulationSize = InteractLandscapeInfo.SimulationSize_cm;
		UpdateLandscapeInfo(InteractLandscapeInfo);
		CombineLandscapeMaps(InteractLandscapeInfo);
		InteractDrawData.InteractLandscapeInfo = InteractLandscapeInfo;
	}

	private void EventOnSendDispInteractInfo(bool Enable, Dictionary<int, FDispInteractInfo> InfoList)
	{
		if (!(InteractDrawData.NS_Simulator.Get() == null))
		{
			InteractDrawData.NS_Simulator.Get()?.SetPaused(!Enable);
			InteractDrawData.NS_Particles.Get()?.SetPaused(!Enable);
			if (Enable)
			{
				OnReceiveInfos(InfoList, InteractDrawData.InteractLandscapeInfo);
			}
		}
	}

	private void UpdateLandscapeInfo(FDispInteractLandscapeInfo LandscapeInfo)
	{
		if (!Owner.IsNullOrDestroyed() && !LandscapeInfo.Landscape.IsNullOrDestroyed())
		{
			FVector inValue = BGUFuncLibActorTransformCS.BGUGetActorLocation(LandscapeInfo.Landscape);
			float z = LandscapeInfo.Landscape.GetActorScale3D().Z;
			float maxHeight = LandscapeInfo.MaxHeight;
			InteractDrawData.World_to_LandscapeUV_Transform = InteractDrawData.GetTransform_WorldtoUVSpace(LandscapeInfo);
			FVector fVector = InteractDrawData.World_to_LandscapeUV_Transform[0];
			FVector fVector2 = InteractDrawData.World_to_LandscapeUV_Transform[1];
			FVector fVector3 = fVector * 100000.0;
			FVector fVector4 = fVector2 * 100000.0;
			InteractDrawData.GlobalNPC.Get().SetVectorParameter("Landscape_Position", inValue);
			InteractDrawData.GlobalNPC.Get().SetFloatParameter("Landscape_ZScale", z);
			InteractDrawData.GlobalNPC.Get().SetFloatParameter("LandscapeMaxHeight", maxHeight);
			InteractDrawData.GlobalNPC.Get().SetFloatParameter("InteractiveData_StorageSize(cm)", InteractDrawData.InteractiveDataStorageSize);
			InteractDrawData.GlobalNPC.Get().SetFloatParameter("SimulationSize(cm)", InteractDrawData.SimulationSize);
			InteractDrawData.GlobalNPC.Get().SetVectorParameter("World_to_UVSpace_XVector", fVector3);
			InteractDrawData.GlobalNPC.Get().SetVectorParameter("World_to_UVSpace_YVector", fVector4);
			UMaterialLibrary.SetScalarParameterValue(Owner, InteractDrawData.GlobalMPC.Get(), B1GlobalFNames.InteractiveData_StorageSize, InteractDrawData.InteractiveDataStorageSize);
			UMaterialLibrary.SetScalarParameterValue(Owner, InteractDrawData.GlobalMPC.Get(), B1GlobalFNames.SimulationSize, InteractDrawData.SimulationSize);
			UMaterialLibrary.SetScalarParameterValue(Owner, InteractDrawData.GlobalMPC.Get(), B1GlobalFNames.LandscapeMaxHeight, maxHeight);
			UMaterialLibrary.SetVectorParameterValue(Owner, InteractDrawData.GlobalMPC.Get(), B1GlobalFNames.World_to_UVSpace_XVector, new FLinearColor(fVector3));
			UMaterialLibrary.SetVectorParameterValue(Owner, InteractDrawData.GlobalMPC.Get(), B1GlobalFNames.World_to_UVSpace_YVector, new FLinearColor(fVector4));
		}
	}

	private void CombineLandscapeMaps(FDispInteractLandscapeInfo LandscapeInfo)
	{
		if (!Owner.IsNullOrDestroyed())
		{
			UMaterialInstanceDynamic uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(Owner, InteractDrawData.M_CombineTexture.Get(), FName.None, EMIDCreationFlags.None);
			uMaterialInstanceDynamic.SetTextureParameterValue(B1GlobalFNames.R, LandscapeInfo.LS_HeightMap);
			uMaterialInstanceDynamic.SetTextureParameterValue(B1GlobalFNames.G, LandscapeInfo.LS_WeightMap);
			UTextureRenderTarget2D textureRenderTarget = InteractDrawData.RT_LandscapeMap.Get();
			URenderingLibrary.ClearRenderTarget2D(Owner, textureRenderTarget, FLinearColor.Black);
			URenderingLibrary.DrawMaterialToRenderTarget(Owner, textureRenderTarget, uMaterialInstanceDynamic);
		}
	}

	private FVector SnapToPixelWorldSize(FVector origPos)
	{
		float num = InteractDrawData.DataStorageRTSize / InteractDrawData.InteractiveDataStorageSize;
		float num2 = FMath.FloorToFloat(num * origPos.X + 0.5f) / num;
		float num3 = FMath.FloorToFloat(num * origPos.Y + 0.5f) / num;
		return new FVector(num2, num3, origPos.Z);
	}

	private void ComputeSnappedPosOffset(AActor ACenter)
	{
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(ACenter);
		InteractDrawData.centerSnappedPos = SnapToPixelWorldSize(fVector);
		if (InteractDrawData.centerPos_Previous == FVector.ZeroVector)
		{
			InteractDrawData.centerPos_Previous = fVector;
		}
		if (InteractDrawData.centerSnappedPos_Previous == FVector.ZeroVector)
		{
			InteractDrawData.centerSnappedPos_Previous = InteractDrawData.centerSnappedPos;
		}
		InteractDrawData.centerOffset = fVector - InteractDrawData.centerPos_Previous;
		InteractDrawData.centerSnappedOffset = InteractDrawData.centerSnappedPos - InteractDrawData.centerSnappedPos_Previous;
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
		FVector newPosition_First = OrigData.FirstPos - InteractDrawData.centerSnappedPos;
		FVector newPosition_Next = OrigData.NextPos - InteractDrawData.centerSnappedPos;
		return ChangeDataPosition(OrigData, newPosition_First, newPosition_Next);
	}

	private FDispInteractInfo JitterDataPosition(FDispInteractInfo OrigData)
	{
		FVector newPosition_First = OrigData.FirstPos + new FVector(5.0, 5.0, 0.0);
		FVector newPosition_Next = OrigData.NextPos + new FVector(-5.0, -5.0, 0.0);
		return ChangeDataPosition(OrigData, newPosition_First, newPosition_Next);
	}

	private FDispInteractInfo TransformDataPosition_PreviousLocal_to_CurrentLocal(FDispInteractInfo PreviousLocalData)
	{
		FVector newPosition_First = PreviousLocalData.FirstPos - InteractDrawData.centerSnappedOffset;
		FVector newPosition_Next = PreviousLocalData.NextPos - InteractDrawData.centerSnappedOffset;
		return ChangeDataPosition(PreviousLocalData, newPosition_First, newPosition_Next);
	}

	private FDispInteractInfo GetStoredData(int dataID, Dictionary<int, FDispInteractInfo> DataStorageDict, FDispInteractInfo defaultData)
	{
		if (!DataStorageDict.TryGetValue(dataID, out var value))
		{
			return JitterDataPosition(defaultData);
		}
		return TransformDataPosition_PreviousLocal_to_CurrentLocal(value);
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

	private void SendMotionData_toNiagara(List<FVector4> baseData, List<FVector> velocityData)
	{
		UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector4(InteractDrawData.NS_Simulator.Get(), B1GlobalFNames.User_Data, baseData);
		UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector(InteractDrawData.NS_Simulator.Get(), B1GlobalFNames.User_VelocityData, velocityData);
	}

	public void TickSendData_toParameterCollector(AActor Owner)
	{
		UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector(InteractDrawData.NS_Simulator.Get(), B1GlobalFNames.User_World_to_LandscapeUV_Transform, InteractDrawData.World_to_LandscapeUV_Transform);
		if (InteractDrawData.NS_Simulator.Get() != null)
		{
			InteractDrawData.NS_Simulator.Get()?.SetNiagaraVariableVec3("User.PlayerSnappedPos_WorldSpace", InteractDrawData.centerSnappedPos);
			InteractDrawData.NS_Simulator.Get()?.SetNiagaraVariableVec3("User.PlayerOffset_VirtualSpace", InteractDrawData.centerSnappedOffset / InteractDrawData.InteractiveDataStorageSize);
		}
		if (InteractDrawData.GlobalNPC.Get() != null)
		{
			InteractDrawData.GlobalNPC.Get()?.SetVectorParameter("PlayerSnappedPos_WorldSpace", InteractDrawData.centerSnappedPos);
		}
		if (InteractDrawData.GlobalMPC.Get() != null)
		{
			UMaterialLibrary.SetVectorParameterValue(Owner.World, InteractDrawData.GlobalMPC.Get(), B1GlobalFNames.PlayerSnappedPos_WorldSpace, new FLinearColor(InteractDrawData.centerSnappedPos));
		}
	}

	public void StoreCurrentCenterPosition_asPrevious()
	{
		InteractDrawData.centerSnappedPos_Previous = InteractDrawData.centerSnappedPos;
	}

	private void PrepareMotionData_Send_to_Niagara(Dictionary<int, FDispInteractInfo> DataDict, AActor Owner)
	{
		ComputeSnappedPosOffset(Owner);
		List<FVector4> list = new List<FVector4>();
		List<FVector> list2 = new List<FVector>();
		foreach (KeyValuePair<int, FDispInteractInfo> item in DataDict)
		{
			FDispInteractInfo fDispInteractInfo = TransformDataPosition_World_to_Local(item.Value);
			FDispInteractInfo storedData = GetStoredData(item.Key, InteractDrawData.previousData_dict, fDispInteractInfo);
			FDispInteractInfo storedData2 = GetStoredData(item.Key, InteractDrawData.twoBeforeData_dict, storedData);
			List<FVector> list3 = CalculateVelocity(fDispInteractInfo, storedData);
			List<FVector> list4 = CalculateVelocity(storedData, storedData2);
			VelocityMotionData data = new VelocityMotionData
			{
				Current_First_Velocity = list3[0],
				Current_Next_Velocity = list3[1],
				Previous_First_Velocity = list4[0],
				Previous_Next_Velocity = list4[1]
			};
			SerializeMotionData_Base(fDispInteractInfo, list);
			SerializeMotionData_Base(storedData, list);
			SerializeMotionData_Velocity(data, list2);
			StoreData(item.Key, storedData, InteractDrawData.twoBeforeData_dict);
			StoreData(item.Key, fDispInteractInfo, InteractDrawData.previousData_dict);
		}
		SendMotionData_toNiagara(list, list2);
		TickSendData_toParameterCollector(Owner);
		StoreCurrentCenterPosition_asPrevious();
	}

	private void OnReceiveInfos(Dictionary<int, FDispInteractInfo> InfoList, FDispInteractLandscapeInfo LandscapeInfo)
	{
		if (DIOwner.Get().AttachTo.IsNullOrDestroyed())
		{
			AActor controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner).GetControlledPawn();
			if (!controlledPawn.IsNullOrDestroyed())
			{
				DIOwner.Get().AttachTo = controlledPawn;
			}
		}
		AActor attachTo = DIOwner.Get().AttachTo;
		PrepareMotionData_Send_to_Niagara(InfoList, attachTo);
	}

	public void EventOnUpdate_NSSystem(UNiagaraSystem NS_Landscape_Interactive, UNiagaraSystem NS_Landscape_Simulator)
	{
		AActor owner = GetOwner();
		if (!owner.IsNullOrDestroyed())
		{
			if (InteractDrawData.NS_Particles.Get() != null)
			{
				InteractDrawData.NS_Particles.Get().DestroyComponent(GetOwner());
			}
			if (NS_Landscape_Interactive != null)
			{
				UNiagaraComponent newValue = UNiagaraFunctionLibrary.SpawnSystemAttached(NS_Landscape_Interactive, owner.GetRootComponent(), FName.None, FVector.ZeroVector, FRotator.ZeroRotator, EAttachLocation.SnapToTarget, bAutoDestroy: true);
				InteractDrawData.NS_Particles.Set(newValue);
			}
			if (InteractDrawData.NS_Simulator.Get() != null)
			{
				InteractDrawData.NS_Simulator.Get().DestroyComponent(GetOwner());
			}
			if (NS_Landscape_Simulator != null)
			{
				UNiagaraComponent newValue2 = UNiagaraFunctionLibrary.SpawnSystemAttached(NS_Landscape_Simulator, owner.GetRootComponent(), FName.None, FVector.ZeroVector, FRotator.ZeroRotator, EAttachLocation.SnapToTarget, bAutoDestroy: true);
				InteractDrawData.NS_Simulator.Set(newValue2);
			}
		}
	}

	private void DisableNSSystem()
	{
		if (!GetOwner().IsNullOrDestroyed())
		{
			if (InteractDrawData.NS_Particles.Get() != null)
			{
				InteractDrawData.NS_Particles.Get().DestroyComponent(GetOwner());
			}
			if (InteractDrawData.NS_Simulator.Get() != null)
			{
				InteractDrawData.NS_Simulator.Get().DestroyComponent(GetOwner());
			}
		}
	}
}
