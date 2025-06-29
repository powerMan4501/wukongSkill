using System;
using System.Collections.Generic;
using b1;
using b1.EventDelDefine;
using b1.Plugins.TressFX;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace GSDispLib;

public class BUS_DispLibUnitMaterialsManageComp : BUS_DispLibCompBase
{
	private BUC_DispLibUnitRendererBaseData UnitRendererBaseData;

	private BUC_DispLibSetUnitMaterialsParamsRequestsQueueData RequestsQueue;

	private IBUC_TickRateData TickRateData;

	public override void OnAttach()
	{
		base.OnAttach();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		UnitRendererBaseData = RequireWritableData<BUC_DispLibUnitRendererBaseData>();
		RequestsQueue = RequireWritableData<BUC_DispLibSetUnitMaterialsParamsRequestsQueueData>();
		if (UnitRendererBaseData == null || RequestsQueue == null)
		{
			return;
		}
		if (!UnitRendererBaseData.DataInitOver)
		{
			UPrimitiveComponent uPrimitiveComponent = Owner.GetComponentByClass<USkeletalMeshComponent>();
			if (uPrimitiveComponent.IsNullOrDestroyed())
			{
				List<UActorComponent> componentsByClass = Owner.GetComponentsByClass(UClass.GetClass<UMeshComponent>());
				if (componentsByClass.Count == 1 && !(componentsByClass[0] is UWidgetComponent))
				{
					uPrimitiveComponent = componentsByClass[0] as UMeshComponent;
				}
				else
				{
					foreach (UActorComponent item in componentsByClass)
					{
						if (item.ComponentHasTag(B1GlobalFNames.master))
						{
							uPrimitiveComponent = item as UMeshComponent;
							break;
						}
					}
				}
			}
			ACharacter aCharacter = Owner as ACharacter;
			float unitOriginHeight = 0f;
			if (!aCharacter.IsNullOrDestroyed() && !aCharacter.CapsuleComponent.IsNullOrDestroyed())
			{
				unitOriginHeight = aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight() * 2f;
			}
			if (uPrimitiveComponent.IsNullOrDestroyed())
			{
				BGW_LogUtil.LogError("[DBC] DispLib BUC_DispLibUnitRendererBaseData before init get MasterComp is null. Owner = " + GetOwner()?.GetActorLabel() + "; OwnerPath = " + GetOwner()?.GetPathName() + ";");
			}
			UnitRendererBaseData.Init(unitOriginHeight, 0, uPrimitiveComponent);
		}
		if (!RequestsQueue.DataInitOver)
		{
			RequestsQueue.Init(UnitRendererBaseData);
		}
		if (UnitRendererBaseData.DataInitOver && RequestsQueue.DataInitOver)
		{
			BindEvent(base.DispLibEventCollection);
			BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(UnitRendererBaseData.OriginMeshComp);
			if (bGS_GSEventCollection != null)
			{
				bGS_GSEventCollection.Evt_NotifyMovieBegin += new Del_Void_IntInt(OnMovieBegin);
				bGS_GSEventCollection.Evt_NotifyMovieEnd += new Del_Void_IntInt(OnMovieEnd);
			}
		}
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		if (UnitRendererBaseData == null || RequestsQueue == null || !UnitRendererBaseData.DataInitOver || !RequestsQueue.DataInitOver)
		{
			return;
		}
		CreateAllMIDycFromOriginMat_Tag_CreateMIDOnBeginPlay();
		if (!UnitRendererBaseData.CanSetMaterialQuality)
		{
			return;
		}
		CreateAllMIDycFromOriginMat();
		foreach (uint key in UnitRendererBaseData.MeshCompUniqueID2TagList.Keys)
		{
			if (!UnitRendererBaseData.CurMIDynamics.TryGetValue(key, out var value) || value == null)
			{
				continue;
			}
			foreach (MIDycInfo mIDycInfo in value)
			{
				if (!mIDycInfo.MIDyc.IsNullOrDestroyed())
				{
					mIDycInfo.SetMaterialQuality(UnitRendererBaseData.OriginMeshCompOwnerActor, 3);
				}
			}
		}
	}

	private void BindEvent(BUS_DispLibEventCollection DispLibEventCollection)
	{
		DispLibEventCollection.Evt_AddNewMeshCompToManager = (BUS_DispLibEventCollection.Del_OneMeshComp)Delegate.Combine(DispLibEventCollection.Evt_AddNewMeshCompToManager, new BUS_DispLibEventCollection.Del_OneMeshComp(AddNewMeshCompToManager));
		DispLibEventCollection.Evt_AddNewMeshCompToManagerWithTag = (BUS_DispLibEventCollection.Del_TagAndMeshComp)Delegate.Combine(DispLibEventCollection.Evt_AddNewMeshCompToManagerWithTag, new BUS_DispLibEventCollection.Del_TagAndMeshComp(AddNewMeshCompToManagerWithTag));
		DispLibEventCollection.Evt_RemoveMeshCompFromManager = (BUS_DispLibEventCollection.Del_OneMeshComp)Delegate.Combine(DispLibEventCollection.Evt_RemoveMeshCompFromManager, new BUS_DispLibEventCollection.Del_OneMeshComp(RemoveMeshCompFromManager));
		DispLibEventCollection.Evt_AddChildActorMeshCompsToManager = (BUS_DispLibEventCollection.Del_OneActor)Delegate.Combine(DispLibEventCollection.Evt_AddChildActorMeshCompsToManager, new BUS_DispLibEventCollection.Del_OneActor(AddChildActorMeshCompsToManager));
		DispLibEventCollection.Evt_RemoveChildActorMeshCompsFromManager = (BUS_DispLibEventCollection.Del_OneActor)Delegate.Combine(DispLibEventCollection.Evt_RemoveChildActorMeshCompsFromManager, new BUS_DispLibEventCollection.Del_OneActor(RemoveChildActorMeshCompsFromManager));
		DispLibEventCollection.Evt_OnSkeletalMeshAssetChanged = (BUS_DispLibEventCollection.Del_OnSkeletalMeshAssetChanged)Delegate.Combine(DispLibEventCollection.Evt_OnSkeletalMeshAssetChanged, new BUS_DispLibEventCollection.Del_OnSkeletalMeshAssetChanged(OnSkeletalMeshAssetChanged));
		DispLibEventCollection.Evt_MeshCompRemoveTag = (BUS_DispLibEventCollection.Del_TagAndMeshComp)Delegate.Combine(DispLibEventCollection.Evt_MeshCompRemoveTag, new BUS_DispLibEventCollection.Del_TagAndMeshComp(RemoveTag));
		DispLibEventCollection.Evt_MeshCompAddNewTag = (BUS_DispLibEventCollection.Del_TagAndMeshComp)Delegate.Combine(DispLibEventCollection.Evt_MeshCompAddNewTag, new BUS_DispLibEventCollection.Del_TagAndMeshComp(AddNewTag));
		DispLibEventCollection.Evt_MeshCompCleanAllTags = (BUS_DispLibEventCollection.Del_OneMeshComp)Delegate.Combine(DispLibEventCollection.Evt_MeshCompCleanAllTags, new BUS_DispLibEventCollection.Del_OneMeshComp(CleanAllTags));
		DispLibEventCollection.Evt_CheckAndCreateMIDyc = CreateNecessaryMIDycs;
		DispLibEventCollection.Evt_SetUnitMatsScalarParamByInfo_Immed = SetUnitMatsScalarParamByInfo_Immed;
		DispLibEventCollection.Evt_SetUnitMatsFLinearColorParamByInfo_Immed = SetUnitMatsFLinearColorParamByInfo_Immed;
		DispLibEventCollection.Evt_SetUnitMatsTextureParamByInfo_Immed = SetUnitMatsTextureParamByInfo_Immed;
		DispLibEventCollection.Evt_SetUnitMatsScalarParam = RequestSetUnitMatsScalarParam;
		DispLibEventCollection.Evt_SetUnitMatsFLinearColorParam = RequestSetUnitMatsColorParam;
		DispLibEventCollection.Evt_SetUnitRenderCustomDepth = RequestSetUnitRenderCustomDepth;
		DispLibEventCollection.Evt_CreateNewMaterials = RequestCreatMaterialInstanceDynamic;
		DispLibEventCollection.Evt_CreateNewMaterialsWithCustomParamsByList = RequestCreatNewMaterialsByInheritParamsList;
		DispLibEventCollection.Evt_ResetUnitMaterials = RequestResetUnitMaterial;
		DispLibEventCollection.Evt_GetFirstCacheMaterialScalarParamValue = GetFirstCacheMaterialScalarParamValue;
		DispLibEventCollection.Evt_GetFirstCacheMaterialScalarParamInitialValue = GetFirstCacheMaterialScalarParamInitialValue;
		DispLibEventCollection.Evt_GetFirstCacheMaterialFLinearColorParamValue = GetFirstCacheMaterialFLinearColorParamValue;
		DispLibEventCollection.Evt_GetFirstCacheMaterialFLinearColorParamInitialValue = GetFirstCacheMaterialFLinearColorParamInitialValue;
		DispLibEventCollection.Evt_ScalarParamOperationCounterAdd = ScalarParamOperationCounterAdd;
		DispLibEventCollection.Evt_ColorParamOperationCounterAdd = ColorParamOperationCounterAdd;
		DispLibEventCollection.Evt_TextureParamOperationCounterAdd = TextureParamOperationCounterAdd;
		DispLibEventCollection.Evt_ScalarParamOperationCounterRemove = ScalarParamOperationCounterRemove;
		DispLibEventCollection.Evt_ColorParamOperationCounterRemove = ColorParamOperationCounterRemove;
		DispLibEventCollection.Evt_TextureParamOperationCounterRemove = TextureParamOperationCounterRemove;
		DispLibEventCollection.Evt_ScalarParamResetPriority = ScalarParamStateCacheResetPriority;
		DispLibEventCollection.Evt_ColorParamResetPriority = ColorParamStateCacheResetPriority;
		DispLibEventCollection.Evt_TextureParamResetPriority = TextureParamStateCacheResetPriority;
		DispLibEventCollection.Evt_LogActorMaterialQualityInfo = LogActorMaterialQualityInfo;
	}

	private float GetCurTime()
	{
		if (UnitRendererBaseData == null)
		{
			return 0f;
		}
		if (!UnitRendererBaseData.OriginMeshComp.IsNullOrDestroyed())
		{
			return BGU_DispLibDataUtil.GSTimeAfterBeginPlay(UnitRendererBaseData.OriginMeshCompOwnerActor);
		}
		return 0f;
	}

	private string GetCurTimeLog()
	{
		if (UnitRendererBaseData == null)
		{
			return "NAN";
		}
		if (!UnitRendererBaseData.OriginMeshComp.IsNullOrDestroyed())
		{
			return BGU_DispLibDataUtil.GSTimeAfterBeginPlay(UnitRendererBaseData.OriginMeshCompOwnerActor).ToString();
		}
		return "NAN";
	}

	private void CreateAllMIDycFromOriginMat()
	{
		CreateNecessaryMIDycs(BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats);
	}

	private void CreateAllMIDycFromOriginMat_Tag_CreateMIDOnBeginPlay()
	{
		CreateNecessaryMIDycs(BUC_DispLibDBC_MaterialEffectTargetInfo.CompsByTagAllMats_CreateMIDOnBeginPlay);
	}

	private void OnMovieBegin(int SeqID, int UniqueID)
	{
		if (!UnitRendererBaseData.CanSetMaterialQuality)
		{
			return;
		}
		UnitRendererBaseData.ForceOverrideMaterialQuality = -1;
		foreach (uint key in UnitRendererBaseData.MeshCompUniqueID2TagList.Keys)
		{
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (Interior_CheckMatMatached(BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats, key, i, out var MIDycInfo) && !MIDycInfo.MIDyc.IsNullOrDestroyed())
				{
					MIDycInfo.SetMaterialQuality(UnitRendererBaseData.OriginMeshCompOwnerActor, -1);
				}
			}
		}
	}

	private void OnMovieEnd(int SeqID, int UniqueID)
	{
		UnitRendererBaseData.ForceOverrideMaterialQuality = -99;
		foreach (KeyValuePair<uint, MIDycInfo[]> curMIDynamic in UnitRendererBaseData.CurMIDynamics)
		{
			uint key = curMIDynamic.Key;
			MIDycInfo[] value = curMIDynamic.Value;
			if (!RequestsQueue.Queue.TryGetValue(key, out var value2) || value == null || value2 == null || value.Length != value2.Length)
			{
				continue;
			}
			for (int i = 0; i < value.Length; i++)
			{
				if (!value[i].MIDyc.IsNullOrDestroyed())
				{
					DispLibMaterialParamsRequestsInfo dispLibMaterialParamsRequestsInfo = value2[i];
					if (dispLibMaterialParamsRequestsInfo != null && dispLibMaterialParamsRequestsInfo.GetValidEventsCount() == 0)
					{
						dispLibMaterialParamsRequestsInfo.isSleep = true;
					}
				}
			}
		}
	}

	private bool CreateNecessaryMIDycs(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode)
	{
		foreach (KeyValuePair<UPrimitiveComponent, List<FName>> meshComp2Tag in UnitRendererBaseData.MeshComp2TagList)
		{
			UPrimitiveComponent key = meshComp2Tag.Key;
			List<FName> value = meshComp2Tag.Value;
			if (key.IsNullOrDestroyed() || !Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			uint uniqueID = key.GetUniqueID();
			if (!UnitRendererBaseData.OriginMaterialInterfaces.TryGetValue(uniqueID, out var value2) || !UnitRendererBaseData.CurMIDynamics.TryGetValue(uniqueID, out var value3) || value2 == null || value3 == null || value2.Length != value3.Length)
			{
				continue;
			}
			for (int i = 0; i < value2.Length; i++)
			{
				if (Interior_CheckMatMatached(FilterMode, uniqueID, i, out var MIDycInfo))
				{
					UMaterialInterface uMaterialInterface = value2[i];
					if (!uMaterialInterface.IsNullOrDestroyed() && MIDycInfo.MIDyc.IsNullOrDestroyed())
					{
						Interior_Creat_One_DynamicMaterialInstance(key, i, uMaterialInterface, FName.None, MIDycInfo);
					}
				}
			}
		}
		return true;
	}

	private void Internal_AddMaterialInfoForNewPrimComp(UPrimitiveComponent NewPrimComp, uint NewPrimCompID)
	{
		int numMaterials = NewPrimComp.GetNumMaterials();
		UMaterialInterface[] array;
		if (numMaterials == 0)
		{
			UTressFXComponent uTressFXComponent = NewPrimComp as UTressFXComponent;
			array = ((!uTressFXComponent.IsNullOrDestroyed()) ? new UMaterialInterface[2] { uTressFXComponent.HairMaterial, uTressFXComponent.HairMaterialLowQuality } : new UMaterialInterface[2]);
		}
		else
		{
			array = new UMaterialInterface[numMaterials];
			for (int i = 0; i < numMaterials; i++)
			{
				array[i] = NewPrimComp.GetMaterial(i);
			}
		}
		for (int j = 0; j < numMaterials; j++)
		{
			UMaterialInterface uMaterialInterface = array[j];
			if (uMaterialInterface.IsNullOrDestroyed())
			{
				continue;
			}
			UMaterialInstanceDynamic uMaterialInstanceDynamic = uMaterialInterface as UMaterialInstanceDynamic;
			if (!uMaterialInstanceDynamic.IsNullOrDestroyed())
			{
				NewPrimComp.GetOwner().GetActorLabel();
				UMaterialInterface parent = uMaterialInstanceDynamic.Parent;
				if (!parent.IsNullOrDestroyed())
				{
					parent.GetName();
				}
			}
		}
		MIDycInfo[] array2 = new MIDycInfo[array.Length];
		UMeshComponent uMeshComponent = NewPrimComp as UMeshComponent;
		List<FName> list = null;
		bool flag = true;
		if (uMeshComponent.IsNullOrDestroyed())
		{
			flag = false;
		}
		else
		{
			list = uMeshComponent.GetMaterialSlotNames();
			if (list.Count == 0)
			{
				flag = false;
			}
		}
		for (int k = 0; k < array.Length; k++)
		{
			if (flag)
			{
				array2[k] = new MIDycInfo(null, list[k]);
			}
			else
			{
				array2[k] = new MIDycInfo(null, B1GlobalFNames.GroomMat);
			}
		}
		UnitRendererBaseData.OriginMaterialInterfaces.Add(NewPrimCompID, array);
		UnitRendererBaseData.CurMIDynamics.Add(NewPrimCompID, array2);
	}

	private void Internal_AddRequestsQueueForNewMeshComp(uint NewMeshCompID, BUC_DispLibUnitRendererBaseData RenderBaseData)
	{
		if (RequestsQueue.Queue.ContainsKey(NewMeshCompID))
		{
			return;
		}
		int compCurMIDynamicsCount = RenderBaseData.GetCompCurMIDynamicsCount(NewMeshCompID);
		if (compCurMIDynamicsCount != 0)
		{
			DispLibMaterialParamsRequestsInfo[] array = new DispLibMaterialParamsRequestsInfo[compCurMIDynamicsCount];
			for (int i = 0; i < compCurMIDynamicsCount; i++)
			{
				array[i] = new DispLibMaterialParamsRequestsInfo();
			}
			RequestsQueue.Queue.Add(NewMeshCompID, array);
		}
	}

	private void Internal_RemoveMaterialInfoForRemovedMeshComp(uint RemovedMeshCompID)
	{
		UnitRendererBaseData.OriginMaterialInterfaces.Remove(RemovedMeshCompID);
		UnitRendererBaseData.CurMIDynamics.Remove(RemovedMeshCompID);
	}

	private void Internal_RemoveRequestsQueueForRemovedMeshComp(uint RemovedMeshCompID)
	{
		RequestsQueue.Queue.Remove(RemovedMeshCompID);
	}

	private void OnSkeletalMeshAssetChanged(USkeletalMeshComponent MeshComp, USkeletalMesh OldSkeletalMesh, USkeletalMesh NewSkeletalMesh)
	{
		if (MeshComp.IsNullOrDestroyed() || NewSkeletalMesh.IsNullOrDestroyed() || MeshComp.SkeletalMesh != NewSkeletalMesh)
		{
			return;
		}
		uint uniqueID = MeshComp.GetUniqueID();
		if (!UnitRendererBaseData.CurMIDynamics.TryGetValue(uniqueID, out var _) || !UnitRendererBaseData.OriginMaterialInterfaces.TryGetValue(uniqueID, out var _) || !RequestsQueue.Queue.TryGetValue(uniqueID, out var _))
		{
			return;
		}
		UMaterialInterface[] array = MeshComp.GetMaterials().ToArray();
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			UMaterialInterface uMaterialInterface = array[i];
			if (!uMaterialInterface.IsNullOrDestroyed())
			{
				(uMaterialInterface as UMaterialInstanceDynamic).IsNullOrDestroyed();
			}
		}
		MIDycInfo[] array2 = new MIDycInfo[num];
		List<FName> materialSlotNames = MeshComp.GetMaterialSlotNames();
		for (int j = 0; j < num; j++)
		{
			if (materialSlotNames.Count != 0)
			{
				array2[j] = new MIDycInfo(null, materialSlotNames[j]);
			}
			else
			{
				array2[j] = new MIDycInfo(null, B1GlobalFNames.GroomMat);
			}
		}
		DispLibMaterialParamsRequestsInfo[] array3 = new DispLibMaterialParamsRequestsInfo[num];
		for (int k = 0; k < num; k++)
		{
			array3[k] = new DispLibMaterialParamsRequestsInfo();
		}
		MIDycInfo[] array4 = UnitRendererBaseData.CurMIDynamics[uniqueID];
		DispLibMaterialParamsRequestsInfo[] array5 = RequestsQueue.Queue[uniqueID];
		int num2 = array5.Length;
		UnitRendererBaseData.OriginMaterialInterfaces[uniqueID] = array;
		UnitRendererBaseData.CurMIDynamics[uniqueID] = array2;
		RequestsQueue.Queue[uniqueID] = array3;
		if (UnitRendererBaseData.CanSetMaterialQuality)
		{
			CreateAllMIDycFromOriginMat();
			foreach (uint key11 in UnitRendererBaseData.MeshCompUniqueID2TagList.Keys)
			{
				if (!UnitRendererBaseData.CurMIDynamics.TryGetValue(key11, out var value4) || value4 == null)
				{
					continue;
				}
				foreach (MIDycInfo mIDycInfo in value4)
				{
					if (!mIDycInfo.MIDyc.IsNullOrDestroyed())
					{
						mIDycInfo.SetMaterialQuality(UnitRendererBaseData.OriginMeshCompOwnerActor, 3);
					}
				}
			}
		}
		for (int m = 0; m < num && m < num2; m++)
		{
			DispLibMaterialParamsRequestsInfo dispLibMaterialParamsRequestsInfo = array5[m];
			if (dispLibMaterialParamsRequestsInfo == null || dispLibMaterialParamsRequestsInfo.RequestsQueueIsEmpty() || !UnitRendererBaseData.GetOneValidMIDycInfo(uniqueID, m, out var MIDycInfo))
			{
				continue;
			}
			foreach (KeyValuePair<FName, DispLib_One_UnitMat_ScalarParamState> item in dispLibMaterialParamsRequestsInfo.GlobalScalarParamQueue)
			{
				FName key = item.Key;
				DispLib_One_UnitMat_ScalarParamState value5 = item.Value;
				DispLib_One_UnitMat_ScalarParamState orAdd_One_ScalarParamData = array3[m].GetOrAdd_One_ScalarParamData(EMaterialParameterAssociation.GlobalParameter, null, key, MIDycInfo);
				if (orAdd_One_ScalarParamData != null)
				{
					_ = value5.InitialValue;
					_ = orAdd_One_ScalarParamData.InitialValue;
					_ = value5.OperationCount;
					orAdd_One_ScalarParamData.InheritOtherParamState(value5);
				}
			}
			foreach (KeyValuePair<FName, DispLib_One_UnitMat_ColorParamState> item2 in dispLibMaterialParamsRequestsInfo.GlobalColorParamQueue)
			{
				FName key2 = item2.Key;
				DispLib_One_UnitMat_ColorParamState value6 = item2.Value;
				DispLib_One_UnitMat_ColorParamState orAdd_One_ColorParamData = array3[m].GetOrAdd_One_ColorParamData(EMaterialParameterAssociation.GlobalParameter, null, key2, MIDycInfo);
				if (orAdd_One_ColorParamData != null)
				{
					_ = value6.InitialValue != orAdd_One_ColorParamData.InitialValue;
					_ = value6.OperationCount;
					orAdd_One_ColorParamData.InheritOtherParamState(value6);
				}
			}
			foreach (KeyValuePair<FName, DispLib_One_UnitMat_TextureParamState> item3 in dispLibMaterialParamsRequestsInfo.GlobalTextureParamQueue)
			{
				FName key3 = item3.Key;
				DispLib_One_UnitMat_TextureParamState value7 = item3.Value;
				DispLib_One_UnitMat_TextureParamState orAdd_One_TextureParamData = array3[m].GetOrAdd_One_TextureParamData(EMaterialParameterAssociation.GlobalParameter, null, key3, MIDycInfo);
				if (orAdd_One_TextureParamData != null)
				{
					_ = value7.InitialValue != orAdd_One_TextureParamData.InitialValue;
					_ = value7.OperationCount;
					orAdd_One_TextureParamData.InheritOtherParamState(value7);
				}
			}
			foreach (KeyValuePair<UMaterialFunctionInterface, int> item4 in array4[m].LayerFunction2LayerIndex)
			{
				UMaterialFunctionInterface key4 = item4.Key;
				int value8 = item4.Value;
				if (dispLibMaterialParamsRequestsInfo.LayerScalarParamQueue.TryGetValue(value8, out var value9))
				{
					foreach (KeyValuePair<FName, DispLib_One_UnitMat_ScalarParamState> item5 in value9)
					{
						FName key5 = item5.Key;
						DispLib_One_UnitMat_ScalarParamState value10 = item5.Value;
						DispLib_One_UnitMat_ScalarParamState orAdd_One_ScalarParamData2 = array3[m].GetOrAdd_One_ScalarParamData(EMaterialParameterAssociation.LayerParameter, key4, key5, MIDycInfo);
						if (orAdd_One_ScalarParamData2 != null)
						{
							_ = value10.InitialValue;
							_ = orAdd_One_ScalarParamData2.InitialValue;
							_ = value10.OperationCount;
							orAdd_One_ScalarParamData2.InheritOtherParamState(value10);
						}
					}
				}
				if (dispLibMaterialParamsRequestsInfo.LayerColorParamQueue.TryGetValue(value8, out var value11))
				{
					foreach (KeyValuePair<FName, DispLib_One_UnitMat_ColorParamState> item6 in value11)
					{
						FName key6 = item6.Key;
						DispLib_One_UnitMat_ColorParamState value12 = item6.Value;
						DispLib_One_UnitMat_ColorParamState orAdd_One_ColorParamData2 = array3[m].GetOrAdd_One_ColorParamData(EMaterialParameterAssociation.LayerParameter, key4, key6, MIDycInfo);
						if (orAdd_One_ColorParamData2 != null)
						{
							_ = value12.InitialValue != orAdd_One_ColorParamData2.InitialValue;
							_ = value12.OperationCount;
							orAdd_One_ColorParamData2.InheritOtherParamState(value12);
						}
					}
				}
				if (dispLibMaterialParamsRequestsInfo.LayerTextureParamQueue.TryGetValue(value8, out var value13))
				{
					foreach (KeyValuePair<FName, DispLib_One_UnitMat_TextureParamState> item7 in value13)
					{
						FName key7 = item7.Key;
						DispLib_One_UnitMat_TextureParamState value14 = item7.Value;
						DispLib_One_UnitMat_TextureParamState orAdd_One_TextureParamData2 = array3[m].GetOrAdd_One_TextureParamData(EMaterialParameterAssociation.LayerParameter, key4, key7, MIDycInfo);
						if (orAdd_One_TextureParamData2 != null)
						{
							_ = value14.InitialValue != orAdd_One_TextureParamData2.InitialValue;
							_ = value14.OperationCount;
							orAdd_One_TextureParamData2.InheritOtherParamState(value14);
						}
					}
				}
				if (dispLibMaterialParamsRequestsInfo.BlendScalarParamQueue.TryGetValue(value8, out var value15))
				{
					foreach (KeyValuePair<FName, DispLib_One_UnitMat_ScalarParamState> item8 in value15)
					{
						FName key8 = item8.Key;
						DispLib_One_UnitMat_ScalarParamState value16 = item8.Value;
						DispLib_One_UnitMat_ScalarParamState orAdd_One_ScalarParamData3 = array3[m].GetOrAdd_One_ScalarParamData(EMaterialParameterAssociation.BlendParameter, key4, key8, MIDycInfo);
						if (orAdd_One_ScalarParamData3 != null)
						{
							_ = value16.InitialValue;
							_ = orAdd_One_ScalarParamData3.InitialValue;
							_ = value16.OperationCount;
							orAdd_One_ScalarParamData3.InheritOtherParamState(value16);
						}
					}
				}
				if (dispLibMaterialParamsRequestsInfo.BlendColorParamQueue.TryGetValue(value8, out var value17))
				{
					foreach (KeyValuePair<FName, DispLib_One_UnitMat_ColorParamState> item9 in value17)
					{
						FName key9 = item9.Key;
						DispLib_One_UnitMat_ColorParamState value18 = item9.Value;
						DispLib_One_UnitMat_ColorParamState orAdd_One_ColorParamData3 = array3[m].GetOrAdd_One_ColorParamData(EMaterialParameterAssociation.BlendParameter, key4, key9, MIDycInfo);
						if (orAdd_One_ColorParamData3 != null)
						{
							_ = value18.InitialValue != orAdd_One_ColorParamData3.InitialValue;
							_ = value18.OperationCount;
							orAdd_One_ColorParamData3.InheritOtherParamState(value18);
						}
					}
				}
				if (!dispLibMaterialParamsRequestsInfo.BlendTextureParamQueue.TryGetValue(value8, out var value19))
				{
					continue;
				}
				foreach (KeyValuePair<FName, DispLib_One_UnitMat_TextureParamState> item10 in value19)
				{
					FName key10 = item10.Key;
					DispLib_One_UnitMat_TextureParamState value20 = item10.Value;
					DispLib_One_UnitMat_TextureParamState orAdd_One_TextureParamData3 = array3[m].GetOrAdd_One_TextureParamData(EMaterialParameterAssociation.BlendParameter, key4, key10, MIDycInfo);
					if (orAdd_One_TextureParamData3 != null)
					{
						_ = value20.InitialValue != orAdd_One_TextureParamData3.InitialValue;
						_ = value20.OperationCount;
						orAdd_One_TextureParamData3.InheritOtherParamState(value20);
					}
				}
			}
		}
		base.DispLibEventCollection.Evt_SkeletalMeshAssetChanged_AfterMainDataUpdate(MeshComp, OldSkeletalMesh, NewSkeletalMesh);
	}

	private void AddChildActorMeshCompsToManager(AActor ChildActor)
	{
		if (!ChildActor.IsNullOrDestroyed() && !(ChildActor == GetOwner()))
		{
			List<UActorComponent> componentsByClass = ChildActor.GetComponentsByClass(UClass.GetClass<UMeshComponent>());
			List<UActorComponent> componentsByClass2 = ChildActor.GetComponentsByClass(UClass.GetClass<UTressFXComponent>());
			componentsByClass.AddRange(componentsByClass2);
			for (int i = 0; i < componentsByClass.Count; i++)
			{
				AddNewMeshCompToManager(componentsByClass[i] as UPrimitiveComponent);
			}
		}
	}

	private void RemoveChildActorMeshCompsFromManager(AActor ChildActor)
	{
		if (!ChildActor.IsNullOrDestroyed() && !(ChildActor == GetOwner()))
		{
			List<UActorComponent> componentsByClass = ChildActor.GetComponentsByClass(UClass.GetClass<UMeshComponent>());
			List<UActorComponent> componentsByClass2 = ChildActor.GetComponentsByClass(UClass.GetClass<UTressFXComponent>());
			componentsByClass.AddRange(componentsByClass2);
			for (int i = 0; i < componentsByClass.Count; i++)
			{
				RemoveMeshCompFromManager(componentsByClass[i] as UPrimitiveComponent);
			}
		}
	}

	private void SetMeshCompRayTracingState(uint MeshCompID, bool CastHybridRayTracingShadow, bool VisibleInRayTracing)
	{
		foreach (UPrimitiveComponent key in UnitRendererBaseData.MeshComp2TagList.Keys)
		{
			if (!key.IsNullOrDestroyed() && key.GetUniqueID() == MeshCompID)
			{
				key.SetCastHybridRayTracingShadow(CastHybridRayTracingShadow);
				key.SetVisibleInRayTracing(VisibleInRayTracing);
				break;
			}
		}
	}

	private void AddNewMeshCompToManager(UPrimitiveComponent NewMeshComp)
	{
		if (NewMeshComp.IsNullOrDestroyed() || NewMeshComp == UnitRendererBaseData.OriginMeshComp || UnitRendererBaseData.MeshComp2TagList.ContainsKey(NewMeshComp))
		{
			return;
		}
		uint uniqueID = NewMeshComp.GetUniqueID();
		List<FName> list = NewMeshComp.ComponentTags.ToList();
		List<FName> list2 = new List<FName>();
		if (list.Count == 0)
		{
			list2.Add(DispLibDispWorld.NonTag);
		}
		else
		{
			foreach (FName item in list)
			{
				if (!(item == DispLibDispWorld.MasterComp) && !(item == DispLibDispWorld.NonTag) && !list2.Contains(item))
				{
					list2.Add(item);
				}
			}
		}
		UnitRendererBaseData.MeshComp2TagList.Add(NewMeshComp, list2);
		if (UnitRendererBaseData.MeshCompUniqueID2TagList.ContainsKey(uniqueID))
		{
			UnitRendererBaseData.MeshCompUniqueID2TagList[uniqueID] = list2;
		}
		else
		{
			UnitRendererBaseData.MeshCompUniqueID2TagList.Add(uniqueID, list2);
		}
		foreach (FName item2 in list2)
		{
			if (UnitRendererBaseData.Tag2MeshCompList.TryGetValue(item2, out var value))
			{
				value.Add(NewMeshComp);
				continue;
			}
			UnitRendererBaseData.Tag2MeshCompList.Add(item2, new List<UPrimitiveComponent> { NewMeshComp });
		}
		Internal_AddMaterialInfoForNewPrimComp(NewMeshComp, uniqueID);
		Internal_AddRequestsQueueForNewMeshComp(uniqueID, UnitRendererBaseData);
		base.DispLibEventCollection.Evt_AddNewMeshComp_AfterMainDataUpdate(NewMeshComp);
	}

	private void AddNewMeshCompToManagerWithTag(FName Tag, UPrimitiveComponent NewMeshComp)
	{
		if (!NewMeshComp.IsNullOrDestroyed() && !(NewMeshComp == UnitRendererBaseData.OriginMeshComp) && !(Tag == DispLibDispWorld.MasterComp) && !(Tag == DispLibDispWorld.NonTag) && !UnitRendererBaseData.MeshComp2TagList.ContainsKey(NewMeshComp))
		{
			uint uniqueID = NewMeshComp.GetUniqueID();
			List<FName> value = new List<FName> { Tag };
			UnitRendererBaseData.MeshComp2TagList.Add(NewMeshComp, value);
			UnitRendererBaseData.MeshCompUniqueID2TagList.Add(uniqueID, value);
			if (UnitRendererBaseData.Tag2MeshCompList.TryGetValue(Tag, out var value2))
			{
				value2.Add(NewMeshComp);
			}
			else
			{
				UnitRendererBaseData.Tag2MeshCompList.Add(Tag, new List<UPrimitiveComponent> { NewMeshComp });
			}
			Internal_AddMaterialInfoForNewPrimComp(NewMeshComp, uniqueID);
			Internal_AddRequestsQueueForNewMeshComp(uniqueID, UnitRendererBaseData);
			base.DispLibEventCollection.Evt_AddNewMeshComp_AfterMainDataUpdate(NewMeshComp);
		}
	}

	private void RemoveMeshCompFromManager(UPrimitiveComponent RemovedMeshComp)
	{
		if (RemovedMeshComp.IsNullOrDestroyed() || RemovedMeshComp == UnitRendererBaseData.OriginMeshComp || !UnitRendererBaseData.MeshComp2TagList.ContainsKey(RemovedMeshComp))
		{
			return;
		}
		uint uniqueID = RemovedMeshComp.GetUniqueID();
		UnitRendererBaseData.MeshComp2TagList.Remove(RemovedMeshComp);
		UnitRendererBaseData.MeshCompUniqueID2TagList.Remove(uniqueID);
		foreach (List<UPrimitiveComponent> value in UnitRendererBaseData.Tag2MeshCompList.Values)
		{
			value.Remove(RemovedMeshComp);
		}
		Internal_RemoveMaterialInfoForRemovedMeshComp(uniqueID);
		Internal_RemoveRequestsQueueForRemovedMeshComp(uniqueID);
		base.DispLibEventCollection.Evt_RemoveMeshComp_AfterMainDataUpdate(RemovedMeshComp);
	}

	private void RemoveTag(FName RemoveTag, UPrimitiveComponent TargetMeshComp)
	{
		if (TargetMeshComp.IsNullOrDestroyed() || TargetMeshComp == UnitRendererBaseData.OriginMeshComp || RemoveTag == DispLibDispWorld.MasterComp || RemoveTag == DispLibDispWorld.NonTag || !UnitRendererBaseData.Tag2MeshCompList.TryGetValue(RemoveTag, out var value))
		{
			return;
		}
		value.Remove(TargetMeshComp);
		uint uniqueID = TargetMeshComp.GetUniqueID();
		bool flag = false;
		if (UnitRendererBaseData.MeshComp2TagList.TryGetValue(TargetMeshComp, out var value2))
		{
			value2.Remove(RemoveTag);
			UnitRendererBaseData.MeshCompUniqueID2TagList[uniqueID] = value2;
			if (value2.Count == 0)
			{
				flag = true;
			}
		}
		if (flag)
		{
			value2.Add(DispLibDispWorld.NonTag);
			if (UnitRendererBaseData.Tag2MeshCompList.TryGetValue(DispLibDispWorld.NonTag, out var value3))
			{
				value3.Add(TargetMeshComp);
				return;
			}
			UnitRendererBaseData.Tag2MeshCompList.Add(DispLibDispWorld.NonTag, new List<UPrimitiveComponent> { TargetMeshComp });
		}
	}

	private void CleanAllTags(UPrimitiveComponent MeshComp)
	{
		if (!MeshComp.IsNullOrDestroyed() && !(MeshComp == UnitRendererBaseData.OriginMeshComp) && UnitRendererBaseData.MeshComp2TagList.TryGetValue(MeshComp, out var value) && !value.Contains(DispLibDispWorld.NonTag))
		{
			value.Clear();
			value.Add(DispLibDispWorld.NonTag);
			if (UnitRendererBaseData.Tag2MeshCompList.TryGetValue(DispLibDispWorld.NonTag, out var value2))
			{
				value2.Add(MeshComp);
			}
			else
			{
				UnitRendererBaseData.Tag2MeshCompList.Add(DispLibDispWorld.NonTag, new List<UPrimitiveComponent> { MeshComp });
			}
			uint uniqueID = MeshComp.GetUniqueID();
			UnitRendererBaseData.MeshCompUniqueID2TagList[uniqueID] = value;
		}
	}

	private void AddNewTag(FName AddNewTag, UPrimitiveComponent TargetMeshComp)
	{
		if (TargetMeshComp.IsNullOrDestroyed() || TargetMeshComp == UnitRendererBaseData.OriginMeshComp || AddNewTag == DispLibDispWorld.MasterComp || AddNewTag == DispLibDispWorld.NonTag || !UnitRendererBaseData.MeshComp2TagList.TryGetValue(TargetMeshComp, out var value))
		{
			return;
		}
		bool flag = false;
		bool flag2 = false;
		if (value.Contains(DispLibDispWorld.NonTag))
		{
			flag = true;
			flag2 = true;
			value.Clear();
			value.Add(AddNewTag);
		}
		else if (!value.Contains(AddNewTag))
		{
			flag2 = true;
			value.Add(AddNewTag);
		}
		if (!flag2)
		{
			return;
		}
		if (flag)
		{
			UnitRendererBaseData.Tag2MeshCompList[DispLibDispWorld.NonTag].Remove(TargetMeshComp);
		}
		if (UnitRendererBaseData.Tag2MeshCompList.TryGetValue(AddNewTag, out var value2))
		{
			if (!value2.Contains(TargetMeshComp))
			{
				value2.Add(TargetMeshComp);
			}
		}
		else
		{
			UnitRendererBaseData.Tag2MeshCompList.Add(AddNewTag, new List<UPrimitiveComponent> { TargetMeshComp });
		}
		uint uniqueID = TargetMeshComp.GetUniqueID();
		UnitRendererBaseData.MeshCompUniqueID2TagList[uniqueID] = value;
	}

	private void RequestSetUnitRenderCustomDepth(bool b)
	{
		UGSE_RenderUtilFuncLib.SetRenderCustomDepth(GetOwner(), b);
	}

	private bool GetFirstCacheMaterialScalarParamValue(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, out float ParamCurValue)
	{
		ParamCurValue = 0f;
		if (!CreateNecessaryMIDycs(FilterMode))
		{
			return false;
		}
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) && !MIDycInfo.MIDyc.IsNullOrDestroyed() && MIDycInfo.GetMPI(Association, ParameterName, LayerFunction, out var MPI))
				{
					ParamCurValue = MIDycInfo.MIDyc.GetScalarParameterValueByInfo(MPI);
					return true;
				}
			}
		}
		return false;
	}

	private bool GetFirstCacheMaterialScalarParamInitialValue(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, out float ParamInitialValue)
	{
		ParamInitialValue = 0f;
		if (!CreateNecessaryMIDycs(FilterMode))
		{
			return false;
		}
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (!Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) || MIDycInfo.MIDyc.IsNullOrDestroyed() || !MIDycInfo.GetMPI(Association, ParameterName, LayerFunction, out var MPI) || !RequestsQueue.GetOneMaterialParamsRequestsInfo(key, i, out var MatParamsRequestInfo))
				{
					continue;
				}
				switch (Association)
				{
				case EMaterialParameterAssociation.GlobalParameter:
				{
					DispLib_One_UnitMat_ScalarParamState value6 = null;
					if (!MatParamsRequestInfo.GlobalScalarParamQueue.TryGetValue(ParameterName, out value6))
					{
						float scalarParameterValueByInfo3 = MIDycInfo.MIDyc.GetScalarParameterValueByInfo(MPI);
						value6 = new DispLib_One_UnitMat_ScalarParamState(ParameterName, scalarParameterValueByInfo3);
						MatParamsRequestInfo.GlobalScalarParamQueue.Add(ParameterName, value6);
					}
					ParamInitialValue = value6.InitialValue;
					return true;
				}
				case EMaterialParameterAssociation.LayerParameter:
				{
					int index2 = MPI.Index;
					Dictionary<FName, DispLib_One_UnitMat_ScalarParamState> value4 = null;
					if (!MatParamsRequestInfo.LayerScalarParamQueue.TryGetValue(index2, out value4))
					{
						value4 = new Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>();
						MatParamsRequestInfo.LayerScalarParamQueue.Add(index2, value4);
					}
					DispLib_One_UnitMat_ScalarParamState value5 = null;
					if (!value4.TryGetValue(ParameterName, out value5))
					{
						float scalarParameterValueByInfo2 = MIDycInfo.MIDyc.GetScalarParameterValueByInfo(MPI);
						value5 = new DispLib_One_UnitMat_ScalarParamState(ParameterName, scalarParameterValueByInfo2);
						value4.Add(ParameterName, value5);
					}
					ParamInitialValue = value5.InitialValue;
					return true;
				}
				default:
				{
					int index = MPI.Index;
					Dictionary<FName, DispLib_One_UnitMat_ScalarParamState> value2 = null;
					if (!MatParamsRequestInfo.BlendScalarParamQueue.TryGetValue(index, out value2))
					{
						value2 = new Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>();
						MatParamsRequestInfo.BlendScalarParamQueue.Add(index, value2);
					}
					if (!value2.TryGetValue(ParameterName, out var value3))
					{
						float scalarParameterValueByInfo = MIDycInfo.MIDyc.GetScalarParameterValueByInfo(MPI);
						value3 = new DispLib_One_UnitMat_ScalarParamState(ParameterName, scalarParameterValueByInfo);
						value2.Add(ParameterName, value3);
					}
					ParamInitialValue = value3.InitialValue;
					return true;
				}
				}
			}
		}
		return false;
	}

	private bool GetFirstCacheMaterialFLinearColorParamValue(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, out FLinearColor ParamCurValue)
	{
		ParamCurValue = FLinearColor.White;
		if (!CreateNecessaryMIDycs(FilterMode))
		{
			return false;
		}
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) && !MIDycInfo.MIDyc.IsNullOrDestroyed() && MIDycInfo.GetMPI(Association, ParameterName, LayerFunction, out var MPI))
				{
					ParamCurValue = MIDycInfo.MIDyc.GetVectorParameterValueByInfo(MPI);
					return true;
				}
			}
		}
		return false;
	}

	private bool GetFirstCacheMaterialFLinearColorParamInitialValue(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, out FLinearColor ParamInitialValue)
	{
		ParamInitialValue = FLinearColor.White;
		if (!CreateNecessaryMIDycs(FilterMode))
		{
			return false;
		}
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (!Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) || MIDycInfo.MIDyc.IsNullOrDestroyed() || !MIDycInfo.GetMPI(Association, ParameterName, LayerFunction, out var MPI) || !RequestsQueue.GetOneMaterialParamsRequestsInfo(key, i, out var MatParamsRequestInfo))
				{
					continue;
				}
				switch (Association)
				{
				case EMaterialParameterAssociation.GlobalParameter:
				{
					if (!MatParamsRequestInfo.GlobalColorParamQueue.TryGetValue(ParameterName, out var value6))
					{
						FLinearColor vectorParameterValueByInfo3 = MIDycInfo.MIDyc.GetVectorParameterValueByInfo(MPI);
						value6 = new DispLib_One_UnitMat_ColorParamState(ParameterName, vectorParameterValueByInfo3);
						MatParamsRequestInfo.GlobalColorParamQueue.Add(ParameterName, value6);
					}
					ParamInitialValue = value6.InitialValue;
					return true;
				}
				case EMaterialParameterAssociation.LayerParameter:
				{
					int index2 = MPI.Index;
					Dictionary<FName, DispLib_One_UnitMat_ColorParamState> value4 = null;
					if (!MatParamsRequestInfo.LayerColorParamQueue.TryGetValue(index2, out value4))
					{
						value4 = new Dictionary<FName, DispLib_One_UnitMat_ColorParamState>();
						MatParamsRequestInfo.LayerColorParamQueue.Add(index2, value4);
					}
					DispLib_One_UnitMat_ColorParamState value5 = null;
					if (!value4.TryGetValue(ParameterName, out value5))
					{
						FLinearColor vectorParameterValueByInfo2 = MIDycInfo.MIDyc.GetVectorParameterValueByInfo(MPI);
						value5 = new DispLib_One_UnitMat_ColorParamState(ParameterName, vectorParameterValueByInfo2);
						value4.Add(ParameterName, value5);
					}
					ParamInitialValue = value5.InitialValue;
					return true;
				}
				default:
				{
					int index = MPI.Index;
					Dictionary<FName, DispLib_One_UnitMat_ColorParamState> value2 = null;
					if (!MatParamsRequestInfo.BlendColorParamQueue.TryGetValue(index, out value2))
					{
						value2 = new Dictionary<FName, DispLib_One_UnitMat_ColorParamState>();
						MatParamsRequestInfo.BlendColorParamQueue.Add(index, value2);
					}
					DispLib_One_UnitMat_ColorParamState value3 = null;
					if (!value2.TryGetValue(ParameterName, out value3))
					{
						FLinearColor vectorParameterValueByInfo = MIDycInfo.MIDyc.GetVectorParameterValueByInfo(MPI);
						value3 = new DispLib_One_UnitMat_ColorParamState(ParameterName, vectorParameterValueByInfo);
						value2.Add(ParameterName, value3);
					}
					ParamInitialValue = value3.InitialValue;
					return true;
				}
				}
			}
		}
		return false;
	}

	private void ScalarParamStateCacheResetPriority(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, uint MatParamEventID, FName OperationEventName, int EventPriority)
	{
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) && RequestsQueue.GetOneMaterialParamsRequestsInfo(key, i, out var MatParamsRequestInfo))
				{
					MatParamsRequestInfo.ScalarParamStateCacheResetPriority(Association, LayerFunction, ParameterName, MIDycInfo, EventPriority);
				}
			}
		}
	}

	private void ColorParamStateCacheResetPriority(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, uint MatParamEventID, FName OperationEventName, int EventPriority)
	{
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) && RequestsQueue.GetOneMaterialParamsRequestsInfo(key, i, out var MatParamsRequestInfo))
				{
					MatParamsRequestInfo.ColorParamStateCacheResetPriority(Association, LayerFunction, ParameterName, MIDycInfo, EventPriority);
				}
			}
		}
	}

	private void TextureParamStateCacheResetPriority(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, uint MatParamEventID, FName OperationEventName, int EventPriority)
	{
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) && RequestsQueue.GetOneMaterialParamsRequestsInfo(key, i, out var MatParamsRequestInfo))
				{
					MatParamsRequestInfo.TextureParamStateCacheResetPriority(Association, LayerFunction, ParameterName, MIDycInfo, EventPriority);
				}
			}
		}
	}

	private void ScalarParamOperationCounterAdd(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, uint MatParamEventID, FName OperationEventName)
	{
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) && RequestsQueue.GetOneMaterialParamsRequestsInfo(key, i, out var MatParamsRequestInfo))
				{
					MatParamsRequestInfo.ScalarParamOperationCounterAdd(Association, LayerFunction, ParameterName, MIDycInfo);
				}
			}
		}
	}

	private void ColorParamOperationCounterAdd(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, uint MatParamEventID, FName OperationEventName)
	{
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) && RequestsQueue.GetOneMaterialParamsRequestsInfo(key, i, out var MatParamsRequestInfo))
				{
					MatParamsRequestInfo.ColorParamOperationCounterAdd(Association, LayerFunction, ParameterName, MIDycInfo);
				}
			}
		}
	}

	private void TextureParamOperationCounterAdd(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, uint MatParamEventID, FName OperationEventName)
	{
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) && RequestsQueue.GetOneMaterialParamsRequestsInfo(key, i, out var MatParamsRequestInfo))
				{
					MatParamsRequestInfo.TextureParamOperationCounterAdd(Association, LayerFunction, ParameterName, MIDycInfo);
				}
			}
		}
	}

	private void ScalarParamOperationCounterRemove(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, uint MatParamEventID, FName OperationEventName)
	{
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) && RequestsQueue.GetOneMaterialParamsRequestsInfo(key, i, out var MatParamsRequestInfo))
				{
					MatParamsRequestInfo.ScalarParamOperationCounterRemove(Association, LayerFunction, ParameterName, MIDycInfo, MatParamEventID, OperationEventName);
				}
			}
		}
	}

	private void ColorParamOperationCounterRemove(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, uint MatParamEventID, FName OperationEventName)
	{
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) && RequestsQueue.GetOneMaterialParamsRequestsInfo(key, i, out var MatParamsRequestInfo))
				{
					MatParamsRequestInfo.ColorParamOperationCounterRemove(Association, LayerFunction, ParameterName, MIDycInfo, MatParamEventID, OperationEventName);
				}
			}
		}
	}

	private void TextureParamOperationCounterRemove(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, uint MatParamEventID, FName OperationEventName)
	{
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) && RequestsQueue.GetOneMaterialParamsRequestsInfo(key, i, out var MatParamsRequestInfo))
				{
					MatParamsRequestInfo.TextureParamOperationCounterRemove(Association, LayerFunction, ParameterName, MIDycInfo, MatParamEventID, OperationEventName);
				}
			}
		}
	}

	private bool Interior_CheckMatMatached(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, uint MeshCompID, int MatIndex, out MIDycInfo MIDycInfo)
	{
		if (!UnitRendererBaseData.GetOneValidMIDycInfo(MeshCompID, MatIndex, out MIDycInfo))
		{
			return false;
		}
		switch (FilterMode.MatsFilterMode)
		{
		case DispLibDBCMaterialsFilterMode.AllMats:
			return true;
		case DispLibDBCMaterialsFilterMode.ByIndexes:
			if (FilterMode.MatIndexes.Contains(MatIndex))
			{
				return true;
			}
			return false;
		case DispLibDBCMaterialsFilterMode.ByExcludeIndexes:
			if (!FilterMode.MatIndexes.Contains(MatIndex))
			{
				return true;
			}
			return false;
		default:
		{
			if (!UnitRendererBaseData.Get_One_MaterialSlotName(MeshCompID, MatIndex, out var SlotName))
			{
				return false;
			}
			switch (FilterMode.MatsFilterMode)
			{
			case DispLibDBCMaterialsFilterMode.BySlotNames:
				if (FilterMode.MatSlotNames.Contains(SlotName))
				{
					return true;
				}
				return false;
			case DispLibDBCMaterialsFilterMode.ByExcludeSlotNames:
				if (!FilterMode.MatSlotNames.Contains(SlotName))
				{
					return true;
				}
				return false;
			default:
			{
				if (!UnitRendererBaseData.OriginMaterialInterfaces.TryGetValue(MeshCompID, out var value))
				{
					return false;
				}
				UMaterialInterface uMaterialInterface = value[MatIndex];
				if (uMaterialInterface.IsNullOrDestroyed())
				{
					return false;
				}
				UMaterial baseMaterial = uMaterialInterface.GetBaseMaterial();
				switch (FilterMode.MatsFilterMode)
				{
				case DispLibDBCMaterialsFilterMode.ByUMaterial:
					if (FilterMode.MatShaders.Contains(baseMaterial))
					{
						return true;
					}
					return false;
				case DispLibDBCMaterialsFilterMode.ByExcludeUMaterial:
					if (!FilterMode.MatShaders.Contains(baseMaterial))
					{
						return true;
					}
					return false;
				default:
					return false;
				}
			}
			}
		}
		}
	}

	private bool Interior_CheckCompMatached(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, List<FName> MeshCompTags)
	{
		if (MeshCompTags == null)
		{
			return false;
		}
		switch (FilterMode.CompsFilterMode)
		{
		case DispLibDBCCompsFilterMode.AllComps:
			return true;
		case DispLibDBCCompsFilterMode.ByTags:
			foreach (FName compTag in FilterMode.CompTags)
			{
				if (MeshCompTags.Contains(compTag))
				{
					return true;
				}
			}
			return false;
		case DispLibDBCCompsFilterMode.ByExcludeTags:
			foreach (FName compTag2 in FilterMode.CompTags)
			{
				if (MeshCompTags.Contains(compTag2))
				{
					return false;
				}
			}
			return true;
		default:
			return false;
		}
	}

	private void SetUnitMatsScalarParamByInfo_Immed(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, FName ParameterName, UMaterialFunctionInterface LayerFunction, float Value, float EventStartTime, int Priority)
	{
		if (!CreateNecessaryMIDycs(FilterMode))
		{
			return;
		}
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (!Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) || MIDycInfo.MIDyc.IsNullOrDestroyed() || !MIDycInfo.GetMPI(Association, ParameterName, LayerFunction, out var MPI) || !RequestsQueue.GetOneMaterialParamsRequestsInfo(key, i, out var MatParamsRequestInfo))
				{
					continue;
				}
				bool flag = false;
				switch (Association)
				{
				case EMaterialParameterAssociation.GlobalParameter:
				{
					if (!MatParamsRequestInfo.GlobalScalarParamQueue.TryGetValue(ParameterName, out var value6))
					{
						float scalarParameterValueByInfo3 = MIDycInfo.MIDyc.GetScalarParameterValueByInfo(MPI);
						value6 = new DispLib_One_UnitMat_ScalarParamState(ParameterName, scalarParameterValueByInfo3);
						MatParamsRequestInfo.GlobalScalarParamQueue.Add(ParameterName, value6);
					}
					if (!value6.HasValidEvent || (value6.Priority < Priority && !MathLib.IsNearlyEqual(Value, value6.Value)) || (value6.Priority == Priority && !MathLib.IsNearlyEqual(Value, value6.Value) && value6.CurRequestStartTime <= EventStartTime))
					{
						flag = true;
						MatParamsRequestInfo.isDirty = true;
						value6.SetData(Value, EventStartTime, Priority);
					}
					break;
				}
				case EMaterialParameterAssociation.LayerParameter:
				{
					int index2 = MPI.Index;
					Dictionary<FName, DispLib_One_UnitMat_ScalarParamState> value4 = null;
					if (!MatParamsRequestInfo.LayerScalarParamQueue.TryGetValue(index2, out value4))
					{
						value4 = new Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>();
						MatParamsRequestInfo.LayerScalarParamQueue.Add(index2, value4);
					}
					DispLib_One_UnitMat_ScalarParamState value5 = null;
					if (!value4.TryGetValue(ParameterName, out value5))
					{
						float scalarParameterValueByInfo2 = MIDycInfo.MIDyc.GetScalarParameterValueByInfo(MPI);
						value5 = new DispLib_One_UnitMat_ScalarParamState(ParameterName, scalarParameterValueByInfo2);
						value4.Add(ParameterName, value5);
					}
					if (!value5.HasValidEvent || (value5.Priority < Priority && !MathLib.IsNearlyEqual(Value, value5.Value)) || (value5.Priority == Priority && !MathLib.IsNearlyEqual(Value, value5.Value) && value5.CurRequestStartTime <= EventStartTime))
					{
						flag = true;
						MatParamsRequestInfo.isDirty = true;
						value5.SetData(Value, EventStartTime, Priority);
					}
					break;
				}
				case EMaterialParameterAssociation.BlendParameter:
				{
					int index = MPI.Index;
					Dictionary<FName, DispLib_One_UnitMat_ScalarParamState> value2 = null;
					if (!MatParamsRequestInfo.BlendScalarParamQueue.TryGetValue(index, out value2))
					{
						value2 = new Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>();
						MatParamsRequestInfo.BlendScalarParamQueue.Add(index, value2);
					}
					DispLib_One_UnitMat_ScalarParamState value3 = null;
					if (!value2.TryGetValue(ParameterName, out value3))
					{
						float scalarParameterValueByInfo = MIDycInfo.MIDyc.GetScalarParameterValueByInfo(MPI);
						value3 = new DispLib_One_UnitMat_ScalarParamState(ParameterName, scalarParameterValueByInfo);
						value2.Add(ParameterName, value3);
					}
					if (value3.HasValidEvent && (value3.Priority >= Priority || MathLib.IsNearlyEqual(Value, value3.Value)) && (value3.Priority != Priority || MathLib.IsNearlyEqual(Value, value3.Value) || !(value3.CurRequestStartTime <= EventStartTime)))
					{
						break;
					}
					flag = true;
					if (BWC_DispLibDispWorldGlobalData.isRayTracing && ParameterName.PlainName == "Dissolve_Intensity")
					{
						if (Value >= 1f)
						{
							SetMeshCompRayTracingState(key, CastHybridRayTracingShadow: false, VisibleInRayTracing: true);
						}
						else if (Value <= 0f)
						{
							SetMeshCompRayTracingState(key, CastHybridRayTracingShadow: true, VisibleInRayTracing: false);
						}
						else if (Value < value3.Value)
						{
							SetMeshCompRayTracingState(key, CastHybridRayTracingShadow: true, VisibleInRayTracing: false);
						}
						else
						{
							SetMeshCompRayTracingState(key, CastHybridRayTracingShadow: false, VisibleInRayTracing: true);
						}
					}
					MatParamsRequestInfo.isDirty = true;
					value3.SetData(Value, EventStartTime, Priority);
					break;
				}
				}
				if (flag)
				{
					MIDycInfo.MIDyc.SetScalarParameterValueByInfo(MPI, Value);
					if (UnitRendererBaseData.CanSetMaterialQuality)
					{
						MIDycInfo.SetMaterialQuality(UnitRendererBaseData.OriginMeshCompOwnerActor, -1);
					}
				}
			}
		}
	}

	private void SetUnitMatsFLinearColorParamByInfo_Immed(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, FName ParameterName, UMaterialFunctionInterface LayerFunction, FLinearColor Value, float EventStartTime, int Priority)
	{
		if (!CreateNecessaryMIDycs(FilterMode))
		{
			return;
		}
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (!Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) || MIDycInfo.MIDyc.IsNullOrDestroyed() || !MIDycInfo.GetMPI(Association, ParameterName, LayerFunction, out var MPI) || !RequestsQueue.GetOneMaterialParamsRequestsInfo(key, i, out var MatParamsRequestInfo))
				{
					continue;
				}
				bool flag = false;
				switch (Association)
				{
				case EMaterialParameterAssociation.GlobalParameter:
				{
					if (!MatParamsRequestInfo.GlobalColorParamQueue.TryGetValue(ParameterName, out var value6))
					{
						FLinearColor vectorParameterValueByInfo3 = MIDycInfo.MIDyc.GetVectorParameterValueByInfo(MPI);
						value6 = new DispLib_One_UnitMat_ColorParamState(ParameterName, vectorParameterValueByInfo3);
						MatParamsRequestInfo.GlobalColorParamQueue.Add(ParameterName, value6);
					}
					if (!value6.HasValidEvent || (value6.Priority < Priority && !BGU_DispLibDataUtil.FLinearColorIsNearlyEqual(Value, value6.Value)) || (value6.Priority == Priority && !BGU_DispLibDataUtil.FLinearColorIsNearlyEqual(Value, value6.Value) && value6.CurRequestStartTime <= EventStartTime))
					{
						flag = true;
						MatParamsRequestInfo.isDirty = true;
						value6.SetData(Value, EventStartTime, Priority);
					}
					break;
				}
				case EMaterialParameterAssociation.LayerParameter:
				{
					int index2 = MPI.Index;
					Dictionary<FName, DispLib_One_UnitMat_ColorParamState> value4 = null;
					if (!MatParamsRequestInfo.LayerColorParamQueue.TryGetValue(index2, out value4))
					{
						value4 = new Dictionary<FName, DispLib_One_UnitMat_ColorParamState>();
						MatParamsRequestInfo.LayerColorParamQueue.Add(index2, value4);
					}
					DispLib_One_UnitMat_ColorParamState value5 = null;
					if (!value4.TryGetValue(ParameterName, out value5))
					{
						FLinearColor vectorParameterValueByInfo2 = MIDycInfo.MIDyc.GetVectorParameterValueByInfo(MPI);
						value5 = new DispLib_One_UnitMat_ColorParamState(ParameterName, vectorParameterValueByInfo2);
						value4.Add(ParameterName, value5);
					}
					if (!value5.HasValidEvent || (value5.Priority < Priority && !BGU_DispLibDataUtil.FLinearColorIsNearlyEqual(Value, value5.Value)) || (value5.Priority == Priority && !BGU_DispLibDataUtil.FLinearColorIsNearlyEqual(Value, value5.Value) && value5.CurRequestStartTime <= EventStartTime))
					{
						flag = true;
						MatParamsRequestInfo.isDirty = true;
						value5.SetData(Value, EventStartTime, Priority);
					}
					break;
				}
				case EMaterialParameterAssociation.BlendParameter:
				{
					int index = MPI.Index;
					Dictionary<FName, DispLib_One_UnitMat_ColorParamState> value2 = null;
					if (!MatParamsRequestInfo.BlendColorParamQueue.TryGetValue(index, out value2))
					{
						value2 = new Dictionary<FName, DispLib_One_UnitMat_ColorParamState>();
						MatParamsRequestInfo.BlendColorParamQueue.Add(index, value2);
					}
					DispLib_One_UnitMat_ColorParamState value3 = null;
					if (!value2.TryGetValue(ParameterName, out value3))
					{
						FLinearColor vectorParameterValueByInfo = MIDycInfo.MIDyc.GetVectorParameterValueByInfo(MPI);
						value3 = new DispLib_One_UnitMat_ColorParamState(ParameterName, vectorParameterValueByInfo);
						value2.Add(ParameterName, value3);
					}
					if (!value3.HasValidEvent || (value3.Priority < Priority && !BGU_DispLibDataUtil.FLinearColorIsNearlyEqual(Value, value3.Value)) || (value3.Priority == Priority && !BGU_DispLibDataUtil.FLinearColorIsNearlyEqual(Value, value3.Value) && value3.CurRequestStartTime <= EventStartTime))
					{
						flag = true;
						MatParamsRequestInfo.isDirty = true;
						value3.SetData(Value, EventStartTime, Priority);
					}
					break;
				}
				}
				if (flag)
				{
					MIDycInfo.MIDyc.SetVectorParameterValueByInfo(MPI, Value);
					if (UnitRendererBaseData.CanSetMaterialQuality)
					{
						MIDycInfo.SetMaterialQuality(UnitRendererBaseData.OriginMeshCompOwnerActor, -1);
					}
				}
			}
		}
	}

	private void SetUnitMatsTextureParamByInfo_Immed(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, FName ParameterName, UMaterialFunctionInterface LayerFunction, UTexture Value, float EventStartTime, int Priority)
	{
		if (Value.IsNullOrDestroyed() || !CreateNecessaryMIDycs(FilterMode))
		{
			return;
		}
		foreach (KeyValuePair<uint, List<FName>> meshCompUniqueID2Tag in UnitRendererBaseData.MeshCompUniqueID2TagList)
		{
			uint key = meshCompUniqueID2Tag.Key;
			List<FName> value = meshCompUniqueID2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(key); i++)
			{
				if (!Interior_CheckMatMatached(FilterMode, key, i, out var MIDycInfo) || MIDycInfo.MIDyc.IsNullOrDestroyed() || !MIDycInfo.GetMPI(Association, ParameterName, LayerFunction, out var MPI) || !RequestsQueue.GetOneMaterialParamsRequestsInfo(key, i, out var MatParamsRequestInfo))
				{
					continue;
				}
				bool flag = false;
				switch (Association)
				{
				case EMaterialParameterAssociation.GlobalParameter:
				{
					if (!MatParamsRequestInfo.GlobalTextureParamQueue.TryGetValue(ParameterName, out var value6))
					{
						UTexture textureParameterValueByInfo3 = MIDycInfo.MIDyc.GetTextureParameterValueByInfo(MPI);
						value6 = new DispLib_One_UnitMat_TextureParamState(ParameterName, textureParameterValueByInfo3);
						MatParamsRequestInfo.GlobalTextureParamQueue.Add(ParameterName, value6);
					}
					if (!value6.HasValidEvent || (value6.Priority < Priority && Value != value6.Value) || (value6.Priority == Priority && Value != value6.Value && value6.CurRequestStartTime <= EventStartTime))
					{
						flag = true;
						MatParamsRequestInfo.isDirty = true;
						value6.SetData(Value, EventStartTime, Priority);
					}
					break;
				}
				case EMaterialParameterAssociation.LayerParameter:
				{
					int index2 = MPI.Index;
					Dictionary<FName, DispLib_One_UnitMat_TextureParamState> value4 = null;
					if (!MatParamsRequestInfo.LayerTextureParamQueue.TryGetValue(index2, out value4))
					{
						value4 = new Dictionary<FName, DispLib_One_UnitMat_TextureParamState>();
						MatParamsRequestInfo.LayerTextureParamQueue.Add(index2, value4);
					}
					DispLib_One_UnitMat_TextureParamState value5 = null;
					if (!value4.TryGetValue(ParameterName, out value5))
					{
						UTexture textureParameterValueByInfo2 = MIDycInfo.MIDyc.GetTextureParameterValueByInfo(MPI);
						value5 = new DispLib_One_UnitMat_TextureParamState(ParameterName, textureParameterValueByInfo2);
						value4.Add(ParameterName, value5);
					}
					if (!value5.HasValidEvent || (value5.Priority < Priority && Value != value5.Value) || (value5.Priority == Priority && Value != value5.Value && value5.CurRequestStartTime <= EventStartTime))
					{
						flag = true;
						MatParamsRequestInfo.isDirty = true;
						value5.SetData(Value, EventStartTime, Priority);
					}
					break;
				}
				case EMaterialParameterAssociation.BlendParameter:
				{
					int index = MPI.Index;
					Dictionary<FName, DispLib_One_UnitMat_TextureParamState> value2 = null;
					if (!MatParamsRequestInfo.BlendTextureParamQueue.TryGetValue(index, out value2))
					{
						value2 = new Dictionary<FName, DispLib_One_UnitMat_TextureParamState>();
						MatParamsRequestInfo.BlendTextureParamQueue.Add(index, value2);
					}
					DispLib_One_UnitMat_TextureParamState value3 = null;
					if (!value2.TryGetValue(ParameterName, out value3))
					{
						UTexture textureParameterValueByInfo = MIDycInfo.MIDyc.GetTextureParameterValueByInfo(MPI);
						value3 = new DispLib_One_UnitMat_TextureParamState(ParameterName, textureParameterValueByInfo);
						value2.Add(ParameterName, value3);
					}
					if (!value3.HasValidEvent || (value3.Priority < Priority && Value != value3.Value) || (value3.Priority == Priority && Value != value3.Value && value3.CurRequestStartTime <= EventStartTime))
					{
						flag = true;
						MatParamsRequestInfo.isDirty = true;
						value3.SetData(Value, EventStartTime, Priority);
					}
					break;
				}
				}
				if (flag)
				{
					MIDycInfo.MIDyc.SetTextureParameterValueByInfo(MPI, Value);
					if (UnitRendererBaseData.CanSetMaterialQuality)
					{
						MIDycInfo.SetMaterialQuality(UnitRendererBaseData.OriginMeshCompOwnerActor, -1);
					}
				}
			}
		}
	}

	private void RequestSetUnitMatsScalarParam(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, FName ScalarAttributeName, float ScalarValue, float EventStartTime, int Priority)
	{
		SetUnitMatsScalarParamByInfo_Immed(FilterMode, EMaterialParameterAssociation.GlobalParameter, ScalarAttributeName, null, ScalarValue, EventStartTime, Priority);
	}

	private void RequestSetUnitMatsColorParam(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, FName ColorAttributeName, FLinearColor FLinearColorValue, float EventStartTime, int Priority)
	{
		SetUnitMatsFLinearColorParamByInfo_Immed(FilterMode, EMaterialParameterAssociation.GlobalParameter, ColorAttributeName, null, FLinearColorValue, EventStartTime, Priority);
	}

	private void RequestResetUnitMatsScalarParam(FName ScalarAttributeName, int Priority, int MatIndex)
	{
	}

	private void RequestCreatMaterialInstanceDynamic(DispLibRefParam Receipt, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, UMaterialInterface MatInterface, DispLibMaterialParamsInheritMode InheritMode)
	{
		Receipt.Clean();
		if (MatInterface.IsNullOrDestroyed())
		{
			if (CreateNecessaryMIDycs(FilterMode))
			{
				Receipt.DBCReturn_uintID = RequestsQueue.RequestNewUniqueID();
			}
			return;
		}
		Receipt.DBCReturn_uintID = RequestsQueue.RequestNewUniqueID();
		foreach (KeyValuePair<UPrimitiveComponent, List<FName>> meshComp2Tag in UnitRendererBaseData.MeshComp2TagList)
		{
			UPrimitiveComponent key = meshComp2Tag.Key;
			List<FName> value = meshComp2Tag.Value;
			uint uniqueID = key.GetUniqueID();
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(uniqueID); i++)
			{
				if (Interior_CheckMatMatached(FilterMode, uniqueID, i, out var MIDycInfo) && Interior_Creat_One_DynamicMaterialInstance(key, i, MatInterface, new FName(MatInterface.GetName() + "_DBCBUS"), MIDycInfo) && UnitRendererBaseData.Get_One_OriginMaterialInterface(uniqueID, i, out var OMI))
				{
					UMaterialInstance uMaterialInstance = OMI as UMaterialInstance;
					UMaterialInstanceDynamic mIDyc = MIDycInfo.MIDyc;
					switch (InheritMode)
					{
					case DispLibMaterialParamsInheritMode.InheritAllSameNameParams:
						mIDyc.CopyMaterialInstanceParameters(uMaterialInstance);
						break;
					case DispLibMaterialParamsInheritMode.InheritOverrideSameNameParams:
						mIDyc.CopyParameterOverrides(uMaterialInstance);
						break;
					}
				}
			}
		}
	}

	private void RequestResetUnitMaterial(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, uint ResetThisIDChange)
	{
		if (ResetThisIDChange == 0)
		{
			return;
		}
		foreach (KeyValuePair<UPrimitiveComponent, List<FName>> meshComp2Tag in UnitRendererBaseData.MeshComp2TagList)
		{
			UPrimitiveComponent key = meshComp2Tag.Key;
			List<FName> value = meshComp2Tag.Value;
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			uint uniqueID = key.GetUniqueID();
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(uniqueID); i++)
			{
				if (Interior_CheckMatMatached(FilterMode, uniqueID, i, out var MIDycInfo) && RequestsQueue.GetOneMaterialParamsRequestsInfo(uniqueID, i, out var MatParamsRequestInfo) && MatParamsRequestInfo.CurSetMatRequestID == ResetThisIDChange && UnitRendererBaseData.Get_One_OriginMaterialInterface(uniqueID, i, out var OMI))
				{
					MatParamsRequestInfo.CurSetMatRequestID = 0u;
					MatParamsRequestInfo.isDirty = false;
					key.SetMaterial(i, OMI);
					MIDycInfo.SetMIDyc(null);
				}
			}
		}
	}

	private bool Interior_Creat_One_DynamicMaterialInstance(UPrimitiveComponent PrimComp, int MatIndex, UMaterialInterface SourceMaterial, FName OptionalName, MIDycInfo Info)
	{
		UMaterialInstanceDynamic uMaterialInstanceDynamic = null;
		UMeshComponent obj = PrimComp as UMeshComponent;
		UMaterialInstanceDynamic uMaterialInstanceDynamic2 = SourceMaterial as UMaterialInstanceDynamic;
		if (uMaterialInstanceDynamic2.IsNullOrDestroyed())
		{
			uMaterialInstanceDynamic = ((!obj.IsNullOrDestroyed()) ? UMaterialLibrary.CreateDynamicMaterialInstance(PrimComp, SourceMaterial, OptionalName, EMIDCreationFlags.None) : UMaterialLibrary.CreateDynamicMaterialInstance(PrimComp, SourceMaterial, OptionalName, EMIDCreationFlags.None));
			if (uMaterialInstanceDynamic.IsNullOrDestroyed())
			{
				return false;
			}
			PrimComp.SetMaterial(MatIndex, uMaterialInstanceDynamic);
		}
		else
		{
			uMaterialInstanceDynamic = uMaterialInstanceDynamic2;
		}
		Info.SetMIDyc(uMaterialInstanceDynamic);
		return true;
	}

	private void Interior_InheritScalarParamOnCreatNewMIDyc(FName ParamName, DispLibMaterialParamsRequestsInfo CurMatParamsInfo, UMaterialInstanceDynamic NewMIDyc, UMaterialInstanceDynamic OldDycMat, UMaterialInstance OriginMI)
	{
		if (!OldDycMat.IsNullOrDestroyed())
		{
			bool flag = false;
			foreach (FScalarParameterValue scalarParameterValue in OldDycMat.ScalarParameterValues)
			{
				if (scalarParameterValue.ParameterInfo.Name == ParamName)
				{
					NewMIDyc.SetScalarParameterValue(ParamName, scalarParameterValue.ParameterValue);
					flag = true;
					break;
				}
			}
			if (flag)
			{
				return;
			}
		}
		if (OriginMI.IsNullOrDestroyed())
		{
			return;
		}
		foreach (FScalarParameterValue scalarParameterValue2 in OriginMI.ScalarParameterValues)
		{
			if (scalarParameterValue2.ParameterInfo.Name == ParamName)
			{
				NewMIDyc.SetScalarParameterValue(ParamName, scalarParameterValue2.ParameterValue);
				break;
			}
		}
	}

	private void Interior_InheritColorParamOnCreatNewMIDyc(FName ParamName, DispLibMaterialParamsRequestsInfo CurMatParamsInfo, UMaterialInstanceDynamic NewMIDyc, UMaterialInstanceDynamic OldDycMat, UMaterialInstance OriginMI)
	{
		if (OldDycMat != null)
		{
			bool flag = false;
			foreach (FVectorParameterValue vectorParameterValue in OldDycMat.VectorParameterValues)
			{
				if (vectorParameterValue.ParameterInfo.Name == ParamName)
				{
					NewMIDyc.SetVectorParameterValue(ParamName, vectorParameterValue.ParameterValue);
					flag = true;
					break;
				}
			}
			if (flag)
			{
				return;
			}
		}
		if (OriginMI.IsNullOrDestroyed())
		{
			return;
		}
		foreach (FVectorParameterValue vectorParameterValue2 in OriginMI.VectorParameterValues)
		{
			if (vectorParameterValue2.ParameterInfo.Name == ParamName)
			{
				NewMIDyc.SetVectorParameterValue(ParamName, vectorParameterValue2.ParameterValue);
				break;
			}
		}
	}

	private void Interior_InheritTextureParamOnCreatNewMIDyc(FName ParamName, DispLibMaterialParamsRequestsInfo CurMatParamsInfo, UMaterialInstanceDynamic NewMIDyc, UMaterialInstanceDynamic OldDycMat, UMaterialInstance OriginMI)
	{
		if (OldDycMat != null)
		{
			bool flag = false;
			foreach (FTextureParameterValue textureParameterValue in OldDycMat.TextureParameterValues)
			{
				if (textureParameterValue.ParameterInfo.Name == ParamName)
				{
					NewMIDyc.SetTextureParameterValue(ParamName, textureParameterValue.ParameterValue);
					flag = true;
					break;
				}
			}
			if (flag)
			{
				return;
			}
		}
		if (OriginMI.IsNullOrDestroyed())
		{
			return;
		}
		foreach (FTextureParameterValue textureParameterValue2 in OriginMI.TextureParameterValues)
		{
			if (textureParameterValue2.ParameterInfo.Name == ParamName)
			{
				NewMIDyc.SetTextureParameterValue(ParamName, textureParameterValue2.ParameterValue);
				break;
			}
		}
	}

	private void Interior_InheritParamsOnCreatNewMIDyc(DispLibMaterialParamsRequestsInfo CurMatParamsInfo, UMaterialInstanceDynamic NewMIDyc, UMaterialInstanceDynamic OldDycMat, UMaterialInstance OriginMI, List<FName> InheritScalarParam, List<FName> InheritFLinearColorParam, List<FName> InheritTextureParam)
	{
		if (InheritScalarParam != null)
		{
			for (int i = 0; i < InheritScalarParam.Count; i++)
			{
				Interior_InheritScalarParamOnCreatNewMIDyc(InheritScalarParam[i], CurMatParamsInfo, NewMIDyc, OldDycMat, OriginMI);
			}
		}
		if (InheritFLinearColorParam != null)
		{
			for (int j = 0; j < InheritFLinearColorParam.Count; j++)
			{
				Interior_InheritColorParamOnCreatNewMIDyc(InheritFLinearColorParam[j], CurMatParamsInfo, NewMIDyc, OldDycMat, OriginMI);
			}
		}
		if (InheritTextureParam != null)
		{
			for (int k = 0; k < InheritTextureParam.Count; k++)
			{
				Interior_InheritTextureParamOnCreatNewMIDyc(InheritTextureParam[k], CurMatParamsInfo, NewMIDyc, OldDycMat, OriginMI);
			}
		}
	}

	private void Interior_Creat_OneMaterialDynamic_InheritParamsList(uint ChangeMaterialEventID, UPrimitiveComponent MeshComp, int MatIndex, UMaterialInterface MatInterface, MIDycInfo MIDycInfo, bool InheritCurParamQueue, List<FName> InheritScalarParam, List<FName> InheritFLinearColorParam, List<FName> InheritTextureParam)
	{
		UMaterialInstanceDynamic mIDyc = MIDycInfo.MIDyc;
		uint uniqueID = MeshComp.GetUniqueID();
		if (!Interior_Creat_One_DynamicMaterialInstance(MeshComp, MatIndex, MatInterface, new FName(MatInterface.GetName() + "_DBCBUS"), MIDycInfo) || !UnitRendererBaseData.Get_One_OriginMaterialInterface(uniqueID, MatIndex, out var OMI))
		{
			return;
		}
		UMaterialInstanceDynamic mIDyc2 = MIDycInfo.MIDyc;
		UMaterialInstance originMI = OMI as UMaterialInstance;
		if (RequestsQueue.GetOneMaterialParamsRequestsInfo(uniqueID, MatIndex, out var MatParamsRequestInfo))
		{
			MatParamsRequestInfo.CurSetMatRequestID = ChangeMaterialEventID;
			if (InheritCurParamQueue)
			{
				Interior_InheritParamsOnCreatNewMIDyc(MatParamsRequestInfo, mIDyc2, mIDyc, originMI, InheritScalarParam, InheritFLinearColorParam, InheritTextureParam);
			}
		}
	}

	private void RequestCreatNewMaterialsByInheritParamsList(DispLibRefParam Receipt, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, UMaterialInterface MatInterface, bool InheritCurParamQueue, List<FName> InheritScalarParam, List<FName> InheritFLinearColorParam, List<FName> InheritTextureParam)
	{
		Receipt.Clean();
		if (!CreateNecessaryMIDycs(FilterMode))
		{
			return;
		}
		uint changeMaterialEventID = (Receipt.DBCReturn_uintID = RequestsQueue.RequestNewUniqueID());
		if (MatInterface.IsNullOrDestroyed())
		{
			return;
		}
		foreach (KeyValuePair<UPrimitiveComponent, List<FName>> meshComp2Tag in UnitRendererBaseData.MeshComp2TagList)
		{
			UPrimitiveComponent key = meshComp2Tag.Key;
			List<FName> value = meshComp2Tag.Value;
			uint uniqueID = key.GetUniqueID();
			if (!Interior_CheckCompMatached(FilterMode, value))
			{
				continue;
			}
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(uniqueID); i++)
			{
				if (Interior_CheckMatMatached(FilterMode, uniqueID, i, out var MIDycInfo))
				{
					Interior_Creat_OneMaterialDynamic_InheritParamsList(changeMaterialEventID, key, i, MatInterface, MIDycInfo, InheritCurParamQueue, InheritScalarParam, InheritFLinearColorParam, InheritTextureParam);
				}
			}
		}
	}

	private void LogActorMaterialQualityInfo()
	{
		if (UnitRendererBaseData == null)
		{
			return;
		}
		foreach (KeyValuePair<UPrimitiveComponent, List<FName>> meshComp2Tag in UnitRendererBaseData.MeshComp2TagList)
		{
			UPrimitiveComponent key = meshComp2Tag.Key;
			_ = meshComp2Tag.Value;
			uint uniqueID = key.GetUniqueID();
			for (int i = 0; i < UnitRendererBaseData.GetCompCurMIDynamicsCount(uniqueID); i++)
			{
				if (UnitRendererBaseData.GetOneValidMIDycInfo(uniqueID, i, out var MIDycInfo) && !MIDycInfo.MIDyc.IsNullOrDestroyed())
				{
					MIDycInfo.MIDyc.GetName();
				}
			}
		}
	}

	public void Base_OnTick(float DeltaTime)
	{
		if (!UnitRendererBaseData.DataInitOver || !RequestsQueue.DataInitOver)
		{
			return;
		}
		foreach (KeyValuePair<uint, MIDycInfo[]> curMIDynamic in UnitRendererBaseData.CurMIDynamics)
		{
			uint key = curMIDynamic.Key;
			MIDycInfo[] value = curMIDynamic.Value;
			if (!RequestsQueue.Queue.TryGetValue(key, out var value2))
			{
				continue;
			}
			for (int i = 0; i < value.Length; i++)
			{
				MIDycInfo mIDycInfo = value[i];
				if (mIDycInfo.MIDyc.IsNullOrDestroyed())
				{
					continue;
				}
				DispLibMaterialParamsRequestsInfo dispLibMaterialParamsRequestsInfo = value2[i];
				if (!dispLibMaterialParamsRequestsInfo.HasParamNeedReset)
				{
					continue;
				}
				foreach (DispLib_One_UnitMat_ScalarParamState value3 in dispLibMaterialParamsRequestsInfo.GlobalScalarParamQueue.Values)
				{
					if (value3.CurTickNeedReset2InitialValue)
					{
						FMaterialParameterInfo parameterInfo = new FMaterialParameterInfo
						{
							Association = EMaterialParameterAssociation.GlobalParameter,
							Name = value3.ParamName,
							Index = -1
						};
						mIDycInfo.MIDyc.SetScalarParameterValueByInfo(parameterInfo, value3.InitialValue);
						value3.OnParamValueReset();
					}
				}
				foreach (KeyValuePair<int, Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>> item in dispLibMaterialParamsRequestsInfo.LayerScalarParamQueue)
				{
					foreach (DispLib_One_UnitMat_ScalarParamState value4 in item.Value.Values)
					{
						if (value4.CurTickNeedReset2InitialValue)
						{
							FMaterialParameterInfo parameterInfo2 = new FMaterialParameterInfo
							{
								Association = EMaterialParameterAssociation.LayerParameter,
								Name = value4.ParamName,
								Index = item.Key
							};
							mIDycInfo.MIDyc.SetScalarParameterValueByInfo(parameterInfo2, value4.InitialValue);
							value4.OnParamValueReset();
						}
					}
				}
				foreach (KeyValuePair<int, Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>> item2 in dispLibMaterialParamsRequestsInfo.BlendScalarParamQueue)
				{
					foreach (DispLib_One_UnitMat_ScalarParamState value5 in item2.Value.Values)
					{
						if (!value5.CurTickNeedReset2InitialValue)
						{
							continue;
						}
						FMaterialParameterInfo parameterInfo3 = new FMaterialParameterInfo
						{
							Association = EMaterialParameterAssociation.BlendParameter,
							Name = value5.ParamName,
							Index = item2.Key
						};
						mIDycInfo.MIDyc.SetScalarParameterValueByInfo(parameterInfo3, value5.InitialValue);
						value5.OnParamValueReset();
						if (BWC_DispLibDispWorldGlobalData.isRayTracing && value5.ParamName.PlainName == "Dissolve_Intensity")
						{
							if (value5.InitialValue >= 0.5f)
							{
								SetMeshCompRayTracingState(key, CastHybridRayTracingShadow: false, VisibleInRayTracing: true);
							}
							else
							{
								SetMeshCompRayTracingState(key, CastHybridRayTracingShadow: true, VisibleInRayTracing: false);
							}
						}
					}
				}
				foreach (DispLib_One_UnitMat_ColorParamState value6 in dispLibMaterialParamsRequestsInfo.GlobalColorParamQueue.Values)
				{
					if (value6.CurTickNeedReset2InitialValue)
					{
						FMaterialParameterInfo parameterInfo4 = new FMaterialParameterInfo
						{
							Association = EMaterialParameterAssociation.GlobalParameter,
							Name = value6.ParamName,
							Index = -1
						};
						mIDycInfo.MIDyc.SetVectorParameterValueByInfo(parameterInfo4, value6.InitialValue);
						value6.OnParamValueReset();
					}
				}
				foreach (KeyValuePair<int, Dictionary<FName, DispLib_One_UnitMat_ColorParamState>> item3 in dispLibMaterialParamsRequestsInfo.LayerColorParamQueue)
				{
					foreach (DispLib_One_UnitMat_ColorParamState value7 in item3.Value.Values)
					{
						if (value7.CurTickNeedReset2InitialValue)
						{
							FMaterialParameterInfo parameterInfo5 = new FMaterialParameterInfo
							{
								Association = EMaterialParameterAssociation.LayerParameter,
								Name = value7.ParamName,
								Index = item3.Key
							};
							mIDycInfo.MIDyc.SetVectorParameterValueByInfo(parameterInfo5, value7.InitialValue);
							value7.OnParamValueReset();
						}
					}
				}
				foreach (KeyValuePair<int, Dictionary<FName, DispLib_One_UnitMat_ColorParamState>> item4 in dispLibMaterialParamsRequestsInfo.BlendColorParamQueue)
				{
					foreach (DispLib_One_UnitMat_ColorParamState value8 in item4.Value.Values)
					{
						if (value8.CurTickNeedReset2InitialValue)
						{
							FMaterialParameterInfo parameterInfo6 = new FMaterialParameterInfo
							{
								Association = EMaterialParameterAssociation.BlendParameter,
								Name = value8.ParamName,
								Index = item4.Key
							};
							mIDycInfo.MIDyc.SetVectorParameterValueByInfo(parameterInfo6, value8.InitialValue);
							value8.OnParamValueReset();
						}
					}
				}
				dispLibMaterialParamsRequestsInfo.HasParamNeedReset = false;
				if (dispLibMaterialParamsRequestsInfo.GetValidEventsCount() == 0)
				{
					dispLibMaterialParamsRequestsInfo.isSleep = true;
				}
			}
			if (!UnitRendererBaseData.CanSetMaterialQuality)
			{
				continue;
			}
			for (int j = 0; j < value.Length; j++)
			{
				MIDycInfo mIDycInfo2 = value[j];
				if (!mIDycInfo2.MIDyc.IsNullOrDestroyed())
				{
					DispLibMaterialParamsRequestsInfo dispLibMaterialParamsRequestsInfo2 = value2[j];
					if (UnitRendererBaseData.ForceOverrideMaterialQuality == -99 && dispLibMaterialParamsRequestsInfo2.isSleep)
					{
						mIDycInfo2.SetMaterialQuality(UnitRendererBaseData.OriginMeshCompOwnerActor, 3);
					}
				}
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 256;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		if (TickGroup == 256 && (TickRateData == null || TickRateData.CanTickFor10000Distance()))
		{
			Base_OnTick(DeltaTime);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		if (UnitRendererBaseData.CanSetMaterialQuality)
		{
			foreach (UMaterialInterface[] value4 in UnitRendererBaseData.OriginMaterialInterfaces.Values)
			{
				for (int i = 0; i < value4.Length; i++)
				{
					UGSE_ActorFuncLib.SetMaterialInterfaceQualityLevel(UnitRendererBaseData.OriginMeshCompOwnerActor, value4[i], -1);
				}
			}
			foreach (KeyValuePair<uint, MIDycInfo[]> curMIDynamic in UnitRendererBaseData.CurMIDynamics)
			{
				MIDycInfo[] value = curMIDynamic.Value;
				foreach (MIDycInfo mIDycInfo in value)
				{
					if (!mIDycInfo.MIDyc.IsNullOrDestroyed())
					{
						mIDycInfo.SetMaterialQuality(UnitRendererBaseData.OriginMeshCompOwnerActor, -1);
					}
				}
			}
		}
		foreach (KeyValuePair<uint, MIDycInfo[]> curMIDynamic2 in UnitRendererBaseData.CurMIDynamics)
		{
			uint key = curMIDynamic2.Key;
			MIDycInfo[] value2 = curMIDynamic2.Value;
			if (!RequestsQueue.Queue.TryGetValue(key, out var value3))
			{
				continue;
			}
			for (int k = 0; k < value2.Length; k++)
			{
				MIDycInfo mIDycInfo2 = value2[k];
				if (mIDycInfo2.MIDyc.IsNullOrDestroyed())
				{
					continue;
				}
				DispLibMaterialParamsRequestsInfo dispLibMaterialParamsRequestsInfo = value3[k];
				foreach (DispLib_One_UnitMat_ScalarParamState value5 in dispLibMaterialParamsRequestsInfo.GlobalScalarParamQueue.Values)
				{
					if (value5.CurTickNeedReset2InitialValue)
					{
						FMaterialParameterInfo parameterInfo = new FMaterialParameterInfo
						{
							Association = EMaterialParameterAssociation.GlobalParameter,
							Name = value5.ParamName,
							Index = -1
						};
						mIDycInfo2.MIDyc.SetScalarParameterValueByInfo(parameterInfo, value5.InitialValue);
						value5.OnParamValueForceReset();
					}
				}
				foreach (KeyValuePair<int, Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>> item in dispLibMaterialParamsRequestsInfo.LayerScalarParamQueue)
				{
					foreach (DispLib_One_UnitMat_ScalarParamState value6 in item.Value.Values)
					{
						if (value6.CurTickNeedReset2InitialValue)
						{
							FMaterialParameterInfo parameterInfo2 = new FMaterialParameterInfo
							{
								Association = EMaterialParameterAssociation.LayerParameter,
								Name = value6.ParamName,
								Index = item.Key
							};
							mIDycInfo2.MIDyc.SetScalarParameterValueByInfo(parameterInfo2, value6.InitialValue);
							value6.OnParamValueForceReset();
						}
					}
				}
				foreach (KeyValuePair<int, Dictionary<FName, DispLib_One_UnitMat_ScalarParamState>> item2 in dispLibMaterialParamsRequestsInfo.BlendScalarParamQueue)
				{
					foreach (DispLib_One_UnitMat_ScalarParamState value7 in item2.Value.Values)
					{
						if (value7.CurTickNeedReset2InitialValue)
						{
							FMaterialParameterInfo parameterInfo3 = new FMaterialParameterInfo
							{
								Association = EMaterialParameterAssociation.BlendParameter,
								Name = value7.ParamName,
								Index = item2.Key
							};
							mIDycInfo2.MIDyc.SetScalarParameterValueByInfo(parameterInfo3, value7.InitialValue);
							value7.OnParamValueForceReset();
						}
					}
				}
				foreach (DispLib_One_UnitMat_ColorParamState value8 in dispLibMaterialParamsRequestsInfo.GlobalColorParamQueue.Values)
				{
					if (value8.CurTickNeedReset2InitialValue)
					{
						FMaterialParameterInfo parameterInfo4 = new FMaterialParameterInfo
						{
							Association = EMaterialParameterAssociation.GlobalParameter,
							Name = value8.ParamName,
							Index = -1
						};
						mIDycInfo2.MIDyc.SetVectorParameterValueByInfo(parameterInfo4, value8.InitialValue);
						value8.OnParamValueForceReset();
					}
				}
				foreach (KeyValuePair<int, Dictionary<FName, DispLib_One_UnitMat_ColorParamState>> item3 in dispLibMaterialParamsRequestsInfo.LayerColorParamQueue)
				{
					foreach (DispLib_One_UnitMat_ColorParamState value9 in item3.Value.Values)
					{
						if (value9.CurTickNeedReset2InitialValue)
						{
							FMaterialParameterInfo parameterInfo5 = new FMaterialParameterInfo
							{
								Association = EMaterialParameterAssociation.LayerParameter,
								Name = value9.ParamName,
								Index = item3.Key
							};
							mIDycInfo2.MIDyc.SetVectorParameterValueByInfo(parameterInfo5, value9.InitialValue);
							value9.OnParamValueForceReset();
						}
					}
				}
				foreach (KeyValuePair<int, Dictionary<FName, DispLib_One_UnitMat_ColorParamState>> item4 in dispLibMaterialParamsRequestsInfo.BlendColorParamQueue)
				{
					foreach (DispLib_One_UnitMat_ColorParamState value10 in item4.Value.Values)
					{
						if (value10.CurTickNeedReset2InitialValue)
						{
							FMaterialParameterInfo parameterInfo6 = new FMaterialParameterInfo
							{
								Association = EMaterialParameterAssociation.BlendParameter,
								Name = value10.ParamName,
								Index = item4.Key
							};
							mIDycInfo2.MIDyc.SetVectorParameterValueByInfo(parameterInfo6, value10.InitialValue);
							value10.OnParamValueForceReset();
						}
					}
				}
				dispLibMaterialParamsRequestsInfo.HasParamNeedReset = false;
			}
		}
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(UnitRendererBaseData.OriginMeshComp);
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_NotifyMovieBegin -= new Del_Void_IntInt(OnMovieBegin);
			bGS_GSEventCollection.Evt_NotifyMovieEnd -= new Del_Void_IntInt(OnMovieEnd);
		}
	}
}
