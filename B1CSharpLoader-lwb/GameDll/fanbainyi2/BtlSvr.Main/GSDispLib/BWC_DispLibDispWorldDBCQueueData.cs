using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BWC_DispLibDispWorldDBCQueueData : BUC_DispLibDataBase
{
	private TStrongObjectPtr<AActor> DLDWorld;

	private uint UniqueRequestID;

	public bool HasMPCParamNeedReset;

	internal Dictionary<uint, List<uint>> OwnerCompIDMap = new Dictionary<uint, List<uint>>();

	internal Dictionary<DispLibDBCActorGroup, List<uint>> ActorGroupMapSourceDispOwnerCompID = new Dictionary<DispLibDBCActorGroup, List<uint>>();

	internal Dictionary<uint, List<DBCAbstractEventInfo>> AbstractEventCacheQueue = new Dictionary<uint, List<DBCAbstractEventInfo>>();

	internal Dictionary<uint, List<DBCPlayCascadeInfo>> PlayCascadeCacheQueue = new Dictionary<uint, List<DBCPlayCascadeInfo>>();

	internal Dictionary<uint, List<DBCPlayNiagaraInfo>> PlayNiagaraCacheQueue = new Dictionary<uint, List<DBCPlayNiagaraInfo>>();

	internal Dictionary<uint, List<DBCPlayAdvanceNiagaraInfo>> PlayAdvanceNiagaraCacheQueue = new Dictionary<uint, List<DBCPlayAdvanceNiagaraInfo>>();

	internal Dictionary<uint, List<DBCChangeMaterialInfo>> ChangeMaterialCacheQueue = new Dictionary<uint, List<DBCChangeMaterialInfo>>();

	internal Dictionary<uint, List<DBCModifyMaterialInfo>> ModifyMaterialCacheQueue = new Dictionary<uint, List<DBCModifyMaterialInfo>>();

	internal Dictionary<uint, List<DBCModifyNiagaraParamsInfo>> ModifyNiagaraParamsCacheQueue = new Dictionary<uint, List<DBCModifyNiagaraParamsInfo>>();

	internal Dictionary<uint, List<DBCScenePhysicalInteractorInfo>> PlaySPICacheQueue = new Dictionary<uint, List<DBCScenePhysicalInteractorInfo>>();

	internal Dictionary<uint, List<DBCPlayArtFresnelInfo>> PlayArtFresnelCacheQueue = new Dictionary<uint, List<DBCPlayArtFresnelInfo>>();

	internal Dictionary<uint, List<DBCSpawnSimpleActorInfo>> SpawnSimpleActorCacheQueue = new Dictionary<uint, List<DBCSpawnSimpleActorInfo>>();

	internal Dictionary<uint, List<DBCPlayAudioInfo>> PlayAudioCacheQueue = new Dictionary<uint, List<DBCPlayAudioInfo>>();

	internal Dictionary<uint, List<DBCPlayCameraShakeInfo>> PlayCameraShakeCacheQueue = new Dictionary<uint, List<DBCPlayCameraShakeInfo>>();

	internal Dictionary<uint, List<DBCPlayCustomCameraShakeInfo>> PlayCustomCameraShakeCacheQueue = new Dictionary<uint, List<DBCPlayCustomCameraShakeInfo>>();

	internal Dictionary<uint, List<DBCCustomEventInfo>> CustomEventsCacheQueue = new Dictionary<uint, List<DBCCustomEventInfo>>();

	internal Dictionary<uint, List<DBCModifyMaterialParameterCollectionInfo>> ModifyMPCCacheQueue = new Dictionary<uint, List<DBCModifyMaterialParameterCollectionInfo>>();

	internal DBCModMatScalabilityManager ModMatScalabilityMgr = new DBCModMatScalabilityManager();

	internal DBCModMatCSharpObjectPool ModMatCSharpObjectPool = new DBCModMatCSharpObjectPool();

	internal Dictionary<uint, Dictionary<int, DBCOneNiagaraScalabilityManager>> NiagaraScalability_PerDataAssetPool = new Dictionary<uint, Dictionary<int, DBCOneNiagaraScalabilityManager>>();

	internal Dictionary<uint, DBCOneNiagaraScalabilityManager> NiagaraScalability_GlobalSystemPool = new Dictionary<uint, DBCOneNiagaraScalabilityManager>();

	internal Dictionary<uint, Dictionary<uint, DBCOneNiagaraScalabilityManager>> NiagaraScalability_PreActorSystemPool = new Dictionary<uint, Dictionary<uint, DBCOneNiagaraScalabilityManager>>();

	internal Dictionary<uint, DBCMergeNiagaraMangerInfo> DBCMergeNiagaraData = new Dictionary<uint, DBCMergeNiagaraMangerInfo>();

	internal Dictionary<string, Dictionary<FName, DispLib_One_MPC_ScalarParamState>> MPC_ScalarParamStateCacheQueue = new Dictionary<string, Dictionary<FName, DispLib_One_MPC_ScalarParamState>>();

	internal Dictionary<string, Dictionary<FName, DispLib_One_MPC_ColorParamState>> MPC_ColorParamStateCacheQueue = new Dictionary<string, Dictionary<FName, DispLib_One_MPC_ColorParamState>>();

	internal bool WEFM_CurFrameExecuteQueueisFull;

	internal int WEFM_EveryFrameExecuteCount;

	internal int WEFMWindBufferMaxCount;

	internal int WEFMWindBufferMaxIndex;

	internal int WEFM_LastFreeSeatIndex;

	internal int WEFM_ValidEventsCount;

	internal int WEFM_CurFrameExecuteAtIndex;

	internal DBCWEFMWindReserveExecuteInfo[] Wind_ReserveExecuteBuffer;

	internal Dictionary<uint, List<DBCWEFMWindEventInfo>> WEFMWindEventCacheQueue = new Dictionary<uint, List<DBCWEFMWindEventInfo>>();

	internal uint WEFMWindRequesterUniqueID;

	internal FVector[] GS_WSArr_CenterPosWS;

	internal FVector[] GS_WSArr_DirWS;

	internal FVector[] GS_WSArr_SizeV3;

	internal float[] GS_WSArr_WindIntensity;

	internal int[] GS_WSArr_WindType;

	internal float[] GS_WSArr_WindDistanceDamplingRate;

	internal FVector4[] GS_WSArr_WindDataV4;

	private uint CustomEventID { get; set; }

	public uint RequestNewUniqueID()
	{
		UniqueRequestID++;
		return UniqueRequestID;
	}

	public uint RequestNewCustomEventID()
	{
		CustomEventID++;
		return CustomEventID;
	}

	internal bool OnOneDBCMergeNiagaraEventDoPlay(DBCPlayAdvanceNiagaraInfo ChildNiagaraEventInfo)
	{
		if (!DBCMergeNiagaraData.TryGetValue(ChildNiagaraEventInfo.MergeMangerSystemTemplateUniqueID, out var value))
		{
			if (ChildNiagaraEventInfo.SourceDispOwnerComp.IsNullOrDestroyed())
			{
				return false;
			}
			value = new DBCMergeNiagaraMangerInfo(ChildNiagaraEventInfo.SourceDispOwnerComp, ChildNiagaraEventInfo.SourceRequest.MergedSettings, ChildNiagaraEventInfo.SourceDispOwnerComp.GetWorldLocation());
			DBCMergeNiagaraData.Add(ChildNiagaraEventInfo.MergeMangerSystemTemplateUniqueID, value);
		}
		if (!value.IsValid())
		{
			return false;
		}
		value.OnOneChildEventDoPlay(ChildNiagaraEventInfo);
		return true;
	}

	internal DBCOneNiagaraScalabilityManager GetNiagaraScalabilityManager(DBCFXInfoBase Info, BUC_DispLibDBC_NiagaraEventScalabilitySettings Setting)
	{
		if (!Setting.Enable)
		{
			return null;
		}
		UNiagaraSystem template = Info.Template;
		uint uniqueID = template.GetUniqueID();
		DBCOneNiagaraScalabilityManager value = null;
		if (Setting.PoolMode == DispLibDBCNiagaraScalabilityPoolMode.GlobalSameDataAssets)
		{
			int eventIndexInDataAsset = Info.EventIndexInDataAsset;
			if (!NiagaraScalability_PerDataAssetPool.TryGetValue(Info.DBCDataAssetUniqueID, out var value2))
			{
				value2 = new Dictionary<int, DBCOneNiagaraScalabilityManager>();
				NiagaraScalability_PerDataAssetPool.Add(Info.DBCDataAssetUniqueID, value2);
			}
			if (!value2.TryGetValue(eventIndexInDataAsset, out value))
			{
				value = new DBCOneNiagaraScalabilityManager(template, Setting);
				value2.Add(eventIndexInDataAsset, value);
			}
		}
		else if (Setting.PoolMode == DispLibDBCNiagaraScalabilityPoolMode.GlobalSameNiagaraSystem)
		{
			if (!NiagaraScalability_GlobalSystemPool.TryGetValue(uniqueID, out value))
			{
				value = new DBCOneNiagaraScalabilityManager(template, Setting);
				NiagaraScalability_GlobalSystemPool.Add(uniqueID, value);
			}
		}
		else if (Setting.PoolMode == DispLibDBCNiagaraScalabilityPoolMode.PreSourceOwnerSameNiagaraSystem)
		{
			if (!NiagaraScalability_PreActorSystemPool.TryGetValue(Info.OwnerActorUniqueID, out var value3))
			{
				value3 = new Dictionary<uint, DBCOneNiagaraScalabilityManager>();
				NiagaraScalability_PreActorSystemPool.Add(Info.OwnerActorUniqueID, value3);
			}
			if (!value3.TryGetValue(uniqueID, out value))
			{
				value = new DBCOneNiagaraScalabilityManager(Info.Template, Setting);
				value3.Add(uniqueID, value);
			}
		}
		return value;
	}

	public bool MPCScalarParamOperationCounterAdd(out bool DataChanged, UMaterialParameterCollection MPCInstance, string MPCAssetPath, FName ParamName)
	{
		DispLib_One_MPC_ScalarParamState orAdd_One_MPCScalarParamState = GetOrAdd_One_MPCScalarParamState(out DataChanged, MPCInstance, MPCAssetPath, ParamName);
		if (orAdd_One_MPCScalarParamState == null)
		{
			return false;
		}
		orAdd_One_MPCScalarParamState.OperationCountAdd();
		return true;
	}

	public bool MPCColorParamOperationCounterAdd(out bool DataChanged, UMaterialParameterCollection MPCInstance, string MPCAssetPath, FName ParamName)
	{
		DispLib_One_MPC_ColorParamState orAdd_One_MPCColorParamState = GetOrAdd_One_MPCColorParamState(out DataChanged, MPCInstance, MPCAssetPath, ParamName);
		if (orAdd_One_MPCColorParamState == null)
		{
			return false;
		}
		orAdd_One_MPCColorParamState.OperationCountAdd();
		return true;
	}

	public bool MPCScalarParamOperationCounterRemove(out bool DataChanged, UMaterialParameterCollection MPCInstance, string MPCAssetPath, FName ParamName)
	{
		DispLib_One_MPC_ScalarParamState orAdd_One_MPCScalarParamState = GetOrAdd_One_MPCScalarParamState(out DataChanged, MPCInstance, MPCAssetPath, ParamName);
		if (orAdd_One_MPCScalarParamState == null)
		{
			return false;
		}
		orAdd_One_MPCScalarParamState.OperationCountRemove();
		HasMPCParamNeedReset = HasMPCParamNeedReset || orAdd_One_MPCScalarParamState.CurTickNeedReset2InitialValue;
		return true;
	}

	public bool MPCColorParamOperationCounterRemove(out bool DataChanged, UMaterialParameterCollection MPCInstance, string MPCAssetPath, FName ParamName)
	{
		DispLib_One_MPC_ColorParamState orAdd_One_MPCColorParamState = GetOrAdd_One_MPCColorParamState(out DataChanged, MPCInstance, MPCAssetPath, ParamName);
		if (orAdd_One_MPCColorParamState == null)
		{
			return false;
		}
		orAdd_One_MPCColorParamState.OperationCountRemove();
		HasMPCParamNeedReset = HasMPCParamNeedReset || orAdd_One_MPCColorParamState.CurTickNeedReset2InitialValue;
		return true;
	}

	public DispLib_One_MPC_ScalarParamState GetOrAdd_One_MPCScalarParamState(out bool DataChanged, UMaterialParameterCollection MPCInstance, string MPCAssetPath, FName ParamName)
	{
		DataChanged = false;
		if (DLDWorld.Get().IsNullOrDestroyed())
		{
			return null;
		}
		if (!MPC_ScalarParamStateCacheQueue.ContainsKey(MPCAssetPath))
		{
			MPC_ScalarParamStateCacheQueue.Add(MPCAssetPath, new Dictionary<FName, DispLib_One_MPC_ScalarParamState>());
		}
		if (MPC_ScalarParamStateCacheQueue[MPCAssetPath].TryGetValue(ParamName, out var value))
		{
			if (!value.isInitialValueValid && !MPCInstance.IsNullOrDestroyed())
			{
				DataChanged = true;
				value.SetParamInitialValue(UMaterialLibrary.GetScalarParameterValue(DLDWorld.Get(), MPCInstance, ParamName));
			}
		}
		else
		{
			DispLib_One_MPC_ScalarParamState dispLib_One_MPC_ScalarParamState = new DispLib_One_MPC_ScalarParamState(MPCAssetPath, ParamName);
			if (!MPCInstance.IsNullOrDestroyed())
			{
				dispLib_One_MPC_ScalarParamState.SetParamInitialValue(UMaterialLibrary.GetScalarParameterValue(DLDWorld.Get(), MPCInstance, ParamName));
			}
			DataChanged = true;
			MPC_ScalarParamStateCacheQueue[MPCAssetPath].Add(ParamName, dispLib_One_MPC_ScalarParamState);
		}
		return MPC_ScalarParamStateCacheQueue[MPCAssetPath][ParamName];
	}

	public DispLib_One_MPC_ColorParamState GetOrAdd_One_MPCColorParamState(out bool DataChanged, UMaterialParameterCollection MPCInstance, string MPCAssetPath, FName ParamName)
	{
		DataChanged = false;
		if (DLDWorld.Get().IsNullOrDestroyed())
		{
			return null;
		}
		if (!MPC_ColorParamStateCacheQueue.ContainsKey(MPCAssetPath))
		{
			MPC_ColorParamStateCacheQueue.Add(MPCAssetPath, new Dictionary<FName, DispLib_One_MPC_ColorParamState>());
		}
		if (MPC_ColorParamStateCacheQueue[MPCAssetPath].TryGetValue(ParamName, out var value))
		{
			if (!value.isInitialValueValid && !MPCInstance.IsNullOrDestroyed())
			{
				DataChanged = true;
				value.SetParamInitialValue(UMaterialLibrary.GetVectorParameterValue(DLDWorld.Get(), MPCInstance, ParamName));
			}
		}
		else
		{
			DispLib_One_MPC_ColorParamState dispLib_One_MPC_ColorParamState = new DispLib_One_MPC_ColorParamState(MPCAssetPath, ParamName);
			if (!MPCInstance.IsNullOrDestroyed())
			{
				dispLib_One_MPC_ColorParamState.SetParamInitialValue(UMaterialLibrary.GetVectorParameterValue(DLDWorld.Get(), MPCInstance, ParamName));
			}
			DataChanged = true;
			MPC_ColorParamStateCacheQueue[MPCAssetPath].Add(ParamName, dispLib_One_MPC_ColorParamState);
		}
		return MPC_ColorParamStateCacheQueue[MPCAssetPath][ParamName];
	}

	public uint RequestNewWEFMWindRequesterUniqueID()
	{
		return ++WEFMWindRequesterUniqueID;
	}

	internal void InitWindQueue(int MaxWindQueueCount = 10)
	{
		WEFM_EveryFrameExecuteCount = MaxWindQueueCount;
		GS_WSArr_CenterPosWS = new FVector[MaxWindQueueCount];
		GS_WSArr_DirWS = new FVector[MaxWindQueueCount];
		GS_WSArr_SizeV3 = new FVector[MaxWindQueueCount];
		GS_WSArr_WindType = new int[MaxWindQueueCount];
		GS_WSArr_WindIntensity = new float[MaxWindQueueCount];
		GS_WSArr_WindDistanceDamplingRate = new float[MaxWindQueueCount];
		GS_WSArr_WindDataV4 = new FVector4[MaxWindQueueCount];
		int num = 5;
		WEFMWindBufferMaxCount = num * WEFM_EveryFrameExecuteCount;
		WEFMWindBufferMaxIndex = WEFMWindBufferMaxCount - 1;
		Wind_ReserveExecuteBuffer = new DBCWEFMWindReserveExecuteInfo[WEFMWindBufferMaxCount];
		for (int i = 0; i < WEFMWindBufferMaxCount; i++)
		{
			Wind_ReserveExecuteBuffer[i] = new DBCWEFMWindReserveExecuteInfo(0u, FVector.ZeroVector, FVector.ZeroVector, FVector.ZeroVector, 0f, 0, 0f, FVector4.ZeroVector);
		}
		WEFM_LastFreeSeatIndex = 0;
		WEFM_ValidEventsCount = 0;
		WEFM_CurFrameExecuteAtIndex = 0;
		for (int j = 0; j < MaxWindQueueCount; j++)
		{
			GS_WSArr_CenterPosWS[j] = FVector.ZeroVector;
			GS_WSArr_DirWS[j] = FVector.ForwardVector;
			GS_WSArr_SizeV3[j] = FVector.ZeroVector;
			GS_WSArr_WindType[j] = 0;
			GS_WSArr_WindIntensity[j] = 0f;
			GS_WSArr_WindDistanceDamplingRate[j] = 1f;
			GS_WSArr_WindDataV4[j] = FVector4.ZeroVector;
		}
	}

	internal void Init(AActor DispLibWorldActor, int MaxWindQueueCount = 10, int MaxHeatQueueCount = 10)
	{
		UniqueRequestID = 0u;
		CustomEventID = 0u;
		DLDWorld = new TStrongObjectPtr<AActor>(DispLibWorldActor);
		InitWindQueue(MaxWindQueueCount);
	}

	internal void AddAbstractEvent2CacheQueue(uint SourceDispOwnerCompID, DBCAbstractEventInfo Info)
	{
		if (AbstractEventCacheQueue.TryGetValue(SourceDispOwnerCompID, out var value))
		{
			value.Add(Info);
			return;
		}
		List<DBCAbstractEventInfo> value2 = new List<DBCAbstractEventInfo> { Info };
		AbstractEventCacheQueue.Add(SourceDispOwnerCompID, value2);
		if (OwnerCompIDMap.TryGetValue(Info.OwnerActorUniqueID, out var value3))
		{
			if (!value3.Contains(SourceDispOwnerCompID))
			{
				value3.Add(SourceDispOwnerCompID);
			}
		}
		else
		{
			OwnerCompIDMap.Add(Info.OwnerActorUniqueID, new List<uint> { SourceDispOwnerCompID });
		}
	}

	internal void AddItem2CacheQueue<T>(uint SourceDispOwnerCompID, T Info, Dictionary<uint, List<T>> CacheQueue) where T : DBCInfoBase
	{
		if (CacheQueue.TryGetValue(SourceDispOwnerCompID, out var value))
		{
			value.Add(Info);
			return;
		}
		List<T> value2 = new List<T> { Info };
		CacheQueue.Add(SourceDispOwnerCompID, value2);
		if (OwnerCompIDMap.TryGetValue(Info.OwnerActorUniqueID, out var value3))
		{
			if (!value3.Contains(SourceDispOwnerCompID))
			{
				value3.Add(SourceDispOwnerCompID);
			}
		}
		else
		{
			OwnerCompIDMap.Add(Info.OwnerActorUniqueID, new List<uint> { SourceDispOwnerCompID });
		}
	}

	internal bool Get_First_DBCInfo_ByDBCID<T>(uint SourceDispOwnerCompID, uint DBCID, Dictionary<uint, List<T>> CacheQueue, out T FindThisInfo) where T : DBCInfoBase
	{
		FindThisInfo = null;
		if (CacheQueue.TryGetValue(SourceDispOwnerCompID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				if (value[num].IdentityID == DBCID)
				{
					FindThisInfo = value[num];
					return true;
				}
			}
		}
		return false;
	}

	internal bool Get_First_DBCInfo_ByANID<T>(uint SourceDispOwnerCompID, int ANID, Dictionary<uint, List<T>> CacheQueue, out T FindThisInfo) where T : DBCInfoBase
	{
		FindThisInfo = null;
		if (CacheQueue.TryGetValue(SourceDispOwnerCompID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				if (value[num].AnimNotifyUniqueID == ANID)
				{
					FindThisInfo = value[num];
					return true;
				}
			}
		}
		return false;
	}

	internal void Reset()
	{
		UniqueRequestID = 0u;
		CustomEventID = 0u;
		if (PlayCascadeCacheQueue != null)
		{
			foreach (List<DBCPlayCascadeInfo> value in PlayCascadeCacheQueue.Values)
			{
				foreach (DBCPlayCascadeInfo item in value)
				{
					item.CascadeComponent = null;
				}
			}
			PlayCascadeCacheQueue.Clear();
		}
		if (PlayNiagaraCacheQueue != null)
		{
			foreach (List<DBCPlayNiagaraInfo> value2 in PlayNiagaraCacheQueue.Values)
			{
				foreach (DBCPlayNiagaraInfo item2 in value2)
				{
					item2.NiagaraComponent?.Delete();
				}
			}
			PlayNiagaraCacheQueue.Clear();
		}
		if (PlayAdvanceNiagaraCacheQueue != null)
		{
			foreach (List<DBCPlayAdvanceNiagaraInfo> value3 in PlayAdvanceNiagaraCacheQueue.Values)
			{
				foreach (DBCPlayAdvanceNiagaraInfo item3 in value3)
				{
					item3.NiagaraComponent?.Delete();
				}
			}
			PlayAdvanceNiagaraCacheQueue.Clear();
		}
		ChangeMaterialCacheQueue.Clear();
		ModifyMaterialCacheQueue.Clear();
		PlaySPICacheQueue.Clear();
		PlayArtFresnelCacheQueue.Clear();
		SpawnSimpleActorCacheQueue.Clear();
		PlayAudioCacheQueue.Clear();
		PlayCameraShakeCacheQueue.Clear();
		PlayCustomCameraShakeCacheQueue.Clear();
		WEFMWindEventCacheQueue.Clear();
		CustomEventsCacheQueue.Clear();
	}
}
