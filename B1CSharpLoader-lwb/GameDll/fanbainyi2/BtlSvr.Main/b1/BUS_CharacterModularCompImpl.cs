using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using BtlB1;
using GSDispLib;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_CharacterModularCompImpl : UActorCompBaseCS
{
	private BUC_CharacterModularData CharacterModularData;

	private IBUC_SeqPerformerConfigInfoData PerformerConfigInfoData;

	public override void OnAttach()
	{
		CharacterModularData = RequireWritableData<BUC_CharacterModularData>();
		PerformerConfigInfoData = RequireReadOnlyData<IBUC_SeqPerformerConfigInfoData, BUC_SeqPerformerConfigInfoData>();
		base.BUSEventCollection.Evt_CharacterModuleChanged += new Del_CharacterModuleChanged(OnCharacterModuleChanged);
		base.BUSEventCollection.Evt_RefreshCharacterModuleAttachment += new Del_RefreshCharacterModuleAttachment(RefreshSkeletalMeshAttachment);
		base.BUSEventCollection.Evt_SetCharacterModuleConstraintProfile += new Del_SetCharacterModuleConstraintProfile(OnSetCharacterModuleConstraintProfile);
		base.BUSEventCollection.Evt_OnCharacterPhysicSimulateStateChanged += new Del_Void_Bool(OnCharacterPhysicSimulateStateChanged);
		base.BUSEventCollection.Evt_SetModularMeshVisibility += new Del_Void_Bool(OnSetModularMeshVisibility);
		base.BUSEventCollection.Evt_TriggerModularMeshTickAnimForCopyPose += new Del_Void(OnTriggerModularMeshTickAnimForCopyPose);
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		InitModularMesh();
		if (CharacterModularData.MasterMesh != null && CharacterModularData.MapEquipSMC.Count > 0)
		{
			CharacterModularData.MasterMesh.VisibilityBasedAnimTickOption = EVisibilityBasedAnimTickOption.AlwaysTickPoseAndRefreshBones;
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		if (CharacterModularData.MapEquipSMC.Count > 0)
		{
			foreach (TStrongObjectPtr<USkeletalMeshComponent> value in CharacterModularData.MapEquipSMC.Values)
			{
				value?.Dispose();
			}
		}
		if (CharacterModularData.MapEquipStaticMeshComp.Count > 0)
		{
			foreach (List<TStrongObjectPtr<UStaticMeshComponent>> value2 in CharacterModularData.MapEquipStaticMeshComp.Values)
			{
				if (value2 == null)
				{
					continue;
				}
				foreach (TStrongObjectPtr<UStaticMeshComponent> item in value2)
				{
					item?.Dispose();
				}
				value2.Clear();
			}
		}
		CharacterModularData.MapEquipSMC.Clear();
		CharacterModularData.MapEquipSMCMontage.Clear();
		CharacterModularData.MapEquipStaticMeshComp.Clear();
		CharacterModularData.MasterMesh = null;
		CharacterModularData.EquipMeshesIndexByAttachSocket.Clear();
		CharacterModularData.EquipTagAndAttachSocketMapping.Clear();
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickForUnloadStrategy(DeltaTime);
	}

	private void TickForUnloadStrategy(float DeltaTime)
	{
		bool flag = false;
		foreach (EquipPosition key2 in CharacterModularData.PendingUnloadEquips.Keys)
		{
			List<int> list = CharacterModularData.PendingUnloadEquips[key2];
			for (int num = list.Count - 1; num >= 0; num--)
			{
				int key = list[num];
				if (CharacterModularData.LoadedEquipResources.TryGetValue(key, out var value))
				{
					bool flag2 = false;
					if (value.bForceUnload)
					{
						flag2 = true;
					}
					else if (value.bStartTickingForUnload)
					{
						if (value.RemainingTime > 0f)
						{
							value.RemainingTime -= DeltaTime;
						}
						else
						{
							flag2 = true;
						}
					}
					if (flag2)
					{
						foreach (KeyValuePair<string, bool> resource in value.Resources)
						{
							BGW_PreloadAssetMgr.Get(this).TryRecyclingCachedResourceObj(resource.Key);
						}
						CharacterModularData.LoadedEquipResources.Remove(key);
						CharacterModularData.PendingUnloadEquips[key2].RemoveAt(num);
						flag = true;
					}
				}
			}
		}
	}

	private void InitModularMesh()
	{
		AActor owner = GetOwner();
		USkeletalMeshComponent uSkeletalMeshComponent = null;
		List<UActorComponent> componentsByClass = owner.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>());
		if (owner is ACharacter)
		{
			uSkeletalMeshComponent = (owner as ACharacter).Mesh;
		}
		else
		{
			foreach (UActorComponent item in componentsByClass)
			{
				if (item.ComponentHasTag(B1GlobalFNames.master))
				{
					uSkeletalMeshComponent = item as USkeletalMeshComponent;
					break;
				}
			}
		}
		if (uSkeletalMeshComponent == null)
		{
			return;
		}
		CharacterModularData.MasterMesh = uSkeletalMeshComponent;
		Dictionary<FName, USkeletalMeshComponent> dictionary = new Dictionary<FName, USkeletalMeshComponent>();
		foreach (KeyValuePair<int, EquipPositionConfDesc> item2 in GameDBRuntime.GetAllEquipPositionDesc())
		{
			if (dictionary.Count == 0)
			{
				foreach (UActorComponent item3 in componentsByClass)
				{
					USkeletalMeshComponent value = item3 as USkeletalMeshComponent;
					foreach (FName componentTag in item3.ComponentTags)
					{
						if (dictionary.ContainsKey(componentTag))
						{
							dictionary[componentTag] = value;
						}
						else
						{
							dictionary.Add(componentTag, value);
						}
					}
				}
			}
			EquipPosition equipPosition = item2.Value.EquipPosition;
			FName fName = new FName(item2.Value.SkeletalMeshComponentTag);
			if (dictionary.TryGetValue(fName, out var value2))
			{
				if (CharacterModularData.EquipPositionTag.ContainsKey(equipPosition))
				{
					CharacterModularData.EquipPositionTag[equipPosition] = fName;
				}
				else
				{
					CharacterModularData.EquipPositionTag.Add(equipPosition, fName);
				}
				if (value2 == null)
				{
					continue;
				}
				value2.SetMasterPoseComponent(uSkeletalMeshComponent);
				CharacterModularData.MapEquipSMC.Add(equipPosition, new TStrongObjectPtr<USkeletalMeshComponent>(value2));
				List<TStrongObjectPtr<UStaticMeshComponent>> list = new List<TStrongObjectPtr<UStaticMeshComponent>>();
				value2.GetChildrenComponents(bIncludeAllDescendants: false, out var Children);
				foreach (USceneComponent item4 in Children)
				{
					if (item4 is UStaticMeshComponent obj)
					{
						list.Add(new TStrongObjectPtr<UStaticMeshComponent>(obj));
					}
				}
				CharacterModularData.MapEquipStaticMeshComp.Add(equipPosition, list);
			}
			if (CharacterModularData.TailMesh == null && dictionary.TryGetValue(B1GlobalFNames.weiba, out value2) && !(value2 == null))
			{
				CharacterModularData.TailMesh = value2;
			}
		}
	}

	public void OnCharacterModuleChanged(EquipPosition EquipPosition, int RequestID, in FCharacterModuleResourceData ResourceData)
	{
		if (!CanTriggerCharacterModuleChanged())
		{
			return;
		}
		if (CharacterModularData.MapEquipResourceLoadRequest.TryGetValue(EquipPosition, out var value) && RequestID != value.RequestID && CharacterModularData.LoadedEquipResources.TryGetValue(value.RequestID, out var value2))
		{
			value2.bStartTickingForUnload = true;
			value2.RemainingTime = GSGameplayCVar.CVar_EquipUnloadDelayTime.GetValueInGameThread();
			if (!CharacterModularData.PendingUnloadEquips.ContainsKey(EquipPosition))
			{
				CharacterModularData.PendingUnloadEquips.Add(EquipPosition, new List<int>());
			}
			if (!CharacterModularData.PendingUnloadEquips[EquipPosition].Contains(value.RequestID))
			{
				CharacterModularData.PendingUnloadEquips[EquipPosition].Add(value.RequestID);
				int valueInGameThread = GSGameplayCVar.CVar_EquipForceUnloadMaxLimit.GetValueInGameThread();
				if (CharacterModularData.PendingUnloadEquips[EquipPosition].Count > valueInGameThread)
				{
					int key = CharacterModularData.PendingUnloadEquips[EquipPosition][0];
					if (CharacterModularData.LoadedEquipResources.TryGetValue(key, out var value3))
					{
						value3.bForceUnload = true;
					}
				}
			}
		}
		if (CharacterModularData.LoadedEquipResources.TryGetValue(RequestID, out var value4))
		{
			value4.bStartTickingForUnload = false;
			value4.bForceUnload = false;
			if (!CharacterModularData.PendingUnloadEquips.ContainsKey(EquipPosition))
			{
				CharacterModularData.PendingUnloadEquips.Add(EquipPosition, new List<int>());
			}
			CharacterModularData.PendingUnloadEquips[EquipPosition].Remove(RequestID);
		}
		if (!CharacterModularData.MapEquipSMC.ContainsKey(EquipPosition))
		{
			return;
		}
		string skeletalMeshPath = ResourceData.SkeletalMeshPath;
		string aBPClassPath = ResourceData.ABPClassPath;
		List<string> staticMeshPathList = ResourceData.StaticMeshPathList;
		string attachSocketName = ResourceData.AttachSocketName;
		ECharacterModularType modularType = ResourceData.ModularType;
		int audioMappingID = ResourceData.AudioMappingID;
		bool bHideTail = ResourceData.bHideTail;
		skeletalMeshPath = FPackageName.ExportTextPathToObjectPath(skeletalMeshPath);
		aBPClassPath = FPackageName.ExportTextPathToObjectPath(aBPClassPath);
		for (int i = 0; i < staticMeshPathList.Count; i++)
		{
			staticMeshPathList[i] = FPackageName.ExportTextPathToObjectPath(staticMeshPathList[i]);
		}
		EquipResourceLoadRequestData equipResourceLoadRequestData = new EquipResourceLoadRequestData();
		equipResourceLoadRequestData.RequestID = RequestID;
		equipResourceLoadRequestData.SkeletalMeshPath = skeletalMeshPath;
		equipResourceLoadRequestData.ABPClassPath = aBPClassPath;
		equipResourceLoadRequestData.AttachSocketName = attachSocketName;
		equipResourceLoadRequestData.ModularType = modularType;
		equipResourceLoadRequestData.bHideTail = bHideTail;
		equipResourceLoadRequestData.SkeletalMeshObj = null;
		equipResourceLoadRequestData.ABPClassObj = null;
		equipResourceLoadRequestData.StaticMesh = new Dictionary<string, TStrongObjectPtr<UStaticMesh>>();
		foreach (string item in staticMeshPathList)
		{
			equipResourceLoadRequestData.StaticMesh.Add(item, null);
		}
		if (CharacterModularData.MapEquipResourceLoadRequest.ContainsKey(EquipPosition))
		{
			value = CharacterModularData.MapEquipResourceLoadRequest[EquipPosition];
			value.SkeletalMeshObj?.Dispose();
			value.SkeletalMeshObj = null;
			value.ABPClassObj?.Dispose();
			value.ABPClassObj = null;
			foreach (KeyValuePair<string, TStrongObjectPtr<UStaticMesh>> item2 in value.StaticMesh)
			{
				item2.Value?.Dispose();
			}
			value.StaticMesh.Clear();
			CharacterModularData.MapEquipResourceLoadRequest[EquipPosition] = equipResourceLoadRequestData;
		}
		else
		{
			CharacterModularData.MapEquipResourceLoadRequest.Add(EquipPosition, equipResourceLoadRequestData);
		}
		if (!CharacterModularData.LoadedEquipResources.ContainsKey(RequestID))
		{
			CharacterModularData.LoadedEquipResources.Add(RequestID, new EquipResourceManageData(skeletalMeshPath));
		}
		BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(Owner);
		bGW_PreloadAssetMgr.TryGetCachedResourceObj<UObject>(skeletalMeshPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.High, OnEquipResourceLoaded, RequestID);
		if (aBPClassPath.Length > 0)
		{
			CharacterModularData.LoadedEquipResources[RequestID].AddPath(aBPClassPath);
			bGW_PreloadAssetMgr.TryGetCachedResourceObj<UObject>(aBPClassPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.High, OnEquipResourceLoaded, RequestID);
		}
		if (staticMeshPathList.Count > 0)
		{
			foreach (string item3 in staticMeshPathList)
			{
				CharacterModularData.LoadedEquipResources[RequestID].AddPath(item3);
				bGW_PreloadAssetMgr.TryGetCachedResourceObj<UObject>(item3, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.High, OnEquipResourceLoaded, RequestID);
			}
		}
		string[] array = new string[4] { "AS_Wukong_PreciseDodge_F_01", "AS_Wukong_PreciseDodge_B_01", "AS_Wukong_PreciseDodge_L_01", "AS_Wukong_PreciseDodge_R_01" };
		string text = "/Game/00MainHZ/Characters/Wukong/Meshes/Equip/BakeCloth/";
		string text2 = "SM_BakeCloth_";
		int num = skeletalMeshPath.LastIndexOf('.');
		string text3 = skeletalMeshPath.Substring(num + 1);
		string[] array2 = array;
		foreach (string text4 in array2)
		{
			string exportTextPath = text + text2 + text3 + "_" + text4 + "." + text2 + text3 + "_" + text4;
			exportTextPath = FPackageName.ExportTextPathToObjectPath(exportTextPath);
			CharacterModularData.LoadedEquipResources[RequestID].AddPath(exportTextPath);
			bGW_PreloadAssetMgr.TryGetCachedResourceObj<UStaticMesh>(exportTextPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.High, OnEquipOtherResourceLoaded, RequestID);
		}
		if (staticMeshPathList.Count > 0)
		{
			string text5 = staticMeshPathList[0];
			int num2 = text5.LastIndexOf('.');
			string text6 = text5.Substring(num2 + 1);
			array2 = array;
			foreach (string text7 in array2)
			{
				text5 = text + text2 + text6 + "_" + text7 + "." + text2 + text6 + "_" + text7;
				text5 = FPackageName.ExportTextPathToObjectPath(text5);
				CharacterModularData.LoadedEquipResources[RequestID].AddPath(text5);
				bGW_PreloadAssetMgr.TryGetCachedResourceObj<UStaticMesh>(text5, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.High, OnEquipOtherResourceLoaded, RequestID);
			}
		}
		foreach (FUStAudioExtendDesc value5 in BGW_GameDB.GetAllAudioExtendDescs().Values)
		{
			if (value5.AudioMappingID == audioMappingID)
			{
				string audioPath = value5.AudioPath;
				audioPath = FPackageName.ExportTextPathToObjectPath(audioPath);
				CharacterModularData.LoadedEquipResources[RequestID].AddPath(audioPath);
				bGW_PreloadAssetMgr.TryGetCachedResourceObj<UAkAudioEvent>(audioPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.High, OnEquipOtherResourceLoaded, RequestID);
			}
		}
		string text8 = "SK_weiba";
		array2 = array;
		foreach (string text9 in array2)
		{
			string path = text + text2 + text8 + "_" + text9 + "." + text2 + text8 + "_" + text9;
			bGW_PreloadAssetMgr.TryGetCachedResourceObj<UStaticMesh>(path, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.High);
		}
	}

	private bool CanTriggerCharacterModuleChanged()
	{
		if (GSGameplayCVar.CVar_DisableChangeEquip.GetValueInGameThread() == 1)
		{
			return false;
		}
		if (GSGameplayCVar.CVar_DisableChangeEquipForPlay.GetValueInGameThread() == 1 && (Owner is BGUCharacterCS || Owner is BGUShadowActorBase || Owner is BGUPerformerActorCS || Owner is BUTamerActor))
		{
			return false;
		}
		if (GSGameplayCVar.CVar_DisableChangeEquipForSystem.GetValueInGameThread() == 1 && (Owner is b1.BGUEquipPreviewActorBase || Owner is b1.BGUTransPreviewActorBase))
		{
			return false;
		}
		return true;
	}

	private void OnEquipOtherResourceLoaded(int ReqID, UObject Obj)
	{
		EquipResourceManageData value;
		if (Obj == null)
		{
			BGW_LogUtil.LogError("OnEquipOtherResourceLoaded: Failed to load equip!");
		}
		else if (CharacterModularData.LoadedEquipResources.TryGetValue(ReqID, out value))
		{
			value.OnResourceLoaded(Obj.GetPathName());
		}
	}

	private void OnEquipResourceLoaded(int ReqID, UObject Obj)
	{
		if (Obj == null)
		{
			BGW_LogUtil.LogError("OnEquipResourceLoaded: Failed to load equip!");
			return;
		}
		USkeletalMesh uSkeletalMesh = null;
		UClass uClass = null;
		UStaticMesh uStaticMesh = null;
		string text = "";
		string text2 = "";
		string text3 = "";
		string pathName = Obj.GetPathName();
		if (Obj is USkeletalMesh)
		{
			uSkeletalMesh = Obj as USkeletalMesh;
			text = pathName;
		}
		else if (Obj is UClass)
		{
			uClass = Obj as UClass;
			text2 = pathName;
		}
		else if (Obj is UStaticMesh)
		{
			uStaticMesh = Obj as UStaticMesh;
			text3 = pathName;
		}
		if (CharacterModularData.LoadedEquipResources.TryGetValue(ReqID, out var value))
		{
			value.OnResourceLoaded(pathName);
		}
		EquipPosition equipPosition = EquipPosition.Head;
		EquipResourceLoadRequestData equipResourceLoadRequestData = null;
		foreach (KeyValuePair<EquipPosition, EquipResourceLoadRequestData> item in CharacterModularData.MapEquipResourceLoadRequest)
		{
			if (text.Length > 0 && item.Value.SkeletalMeshPath.Equals(text))
			{
				equipPosition = item.Key;
				equipResourceLoadRequestData = item.Value;
				break;
			}
			if (text2.Length > 0 && item.Value.ABPClassPath.Equals(text2))
			{
				equipPosition = item.Key;
				equipResourceLoadRequestData = item.Value;
				break;
			}
			if (text3.Length > 0 && item.Value.StaticMesh.ContainsKey(text3))
			{
				equipPosition = item.Key;
				equipResourceLoadRequestData = item.Value;
				break;
			}
		}
		if (equipResourceLoadRequestData == null)
		{
			return;
		}
		if (uSkeletalMesh != null)
		{
			equipResourceLoadRequestData.SkeletalMeshObj = new TStrongObjectPtr<USkeletalMesh>(uSkeletalMesh);
		}
		if (uClass != null)
		{
			equipResourceLoadRequestData.ABPClassObj = new TStrongObjectPtr<UClass>(uClass);
		}
		if (uStaticMesh != null)
		{
			equipResourceLoadRequestData.StaticMesh[text3] = new TStrongObjectPtr<UStaticMesh>(uStaticMesh);
		}
		if (equipResourceLoadRequestData.SkeletalMeshObj == null || (equipResourceLoadRequestData.ABPClassPath.Length > 0 && equipResourceLoadRequestData.ABPClassObj == null))
		{
			return;
		}
		foreach (KeyValuePair<string, TStrongObjectPtr<UStaticMesh>> item2 in equipResourceLoadRequestData.StaticMesh)
		{
			if (item2.Value == null)
			{
				return;
			}
		}
		if (!CharacterModularData.MapEquipSMC.TryGetValue(equipPosition, out var value2) || value2.Get().IsNullOrDestroyed())
		{
			return;
		}
		if (!CharacterModularData.MapEquipModularType.ContainsKey(equipPosition))
		{
			CharacterModularData.MapEquipModularType.Add(equipPosition, equipResourceLoadRequestData.ModularType);
		}
		else
		{
			CharacterModularData.MapEquipModularType[equipPosition] = equipResourceLoadRequestData.ModularType;
		}
		if (!CharacterModularData.MapEquipHideTail.ContainsKey(equipPosition))
		{
			CharacterModularData.MapEquipHideTail.Add(equipPosition, equipResourceLoadRequestData.bHideTail);
		}
		else
		{
			CharacterModularData.MapEquipHideTail[equipPosition] = equipResourceLoadRequestData.bHideTail;
		}
		uSkeletalMesh = equipResourceLoadRequestData.SkeletalMeshObj.Get();
		USkeletalMesh skeletalMesh = value2.Get().SkeletalMesh;
		RefreshSkeletalMesh(equipPosition, equipResourceLoadRequestData);
		RefreshStaticMesh(equipPosition, equipResourceLoadRequestData);
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
		bUS_DispLibEventCollection?.Evt_OnSkeletalMeshAssetChanged?.Invoke(value2.Get(), skeletalMesh, uSkeletalMesh);
		if (equipResourceLoadRequestData.bHideTail)
		{
			CharacterModularData.TailMesh?.SetHiddenInGame(NewHidden: true);
		}
		else if (!CharacterModularData.ShouldHideTail())
		{
			CharacterModularData.TailMesh?.SetHiddenInGame(NewHidden: false);
		}
		if (!CharacterModularData.MapEquipStaticMeshComp.TryGetValue(equipPosition, out var value3) || !CharacterModularData.EquipPositionTag.TryGetValue(equipPosition, out var value4))
		{
			return;
		}
		foreach (TStrongObjectPtr<UStaticMeshComponent> item3 in value3)
		{
			if (!item3.Get().IsNullOrDestroyed())
			{
				bUS_DispLibEventCollection?.Evt_RemoveMeshCompFromManager?.Invoke(item3.Get());
				bUS_DispLibEventCollection?.Evt_AddNewMeshCompToManagerWithTag?.Invoke(value4, item3.Get());
			}
		}
	}

	private void RefreshStaticMesh(EquipPosition EquipPosition, EquipResourceLoadRequestData Request)
	{
		if (!CharacterModularData.MapEquipStaticMeshComp.TryGetValue(EquipPosition, out var value) || value.Count == 0)
		{
			return;
		}
		int num = 0;
		foreach (KeyValuePair<string, TStrongObjectPtr<UStaticMesh>> item in Request.StaticMesh)
		{
			if (num >= value.Count)
			{
				break;
			}
			UStaticMeshComponent uStaticMeshComponent = value[num++].Get();
			if (!uStaticMeshComponent.IsNullOrDestroyed())
			{
				UStaticMesh uStaticMesh = item.Value.Get();
				uStaticMeshComponent.SetStaticMesh(item.Value.Get());
				List<FStaticMaterial> staticMaterials = uStaticMesh.GetStaticMaterials();
				for (int i = 0; i < staticMaterials.Count; i++)
				{
					uStaticMeshComponent.SetMaterial(i, staticMaterials[i].MaterialInterface);
				}
			}
		}
		for (int j = num; j < value.Count; j++)
		{
			UStaticMeshComponent uStaticMeshComponent2 = value[num++].Get();
			if (!uStaticMeshComponent2.IsNullOrDestroyed())
			{
				uStaticMeshComponent2.SetStaticMesh(null);
			}
		}
	}

	private void RefreshSkeletalMesh(EquipPosition EquipPosition, EquipResourceLoadRequestData Request)
	{
		if (CharacterModularData.MapEquipSMC.TryGetValue(EquipPosition, out var value))
		{
			_ = value.Get().SkeletalMesh;
			USkeletalMesh uSkeletalMesh = Request.SkeletalMeshObj.Get();
			UClass uClass = ((Request.ABPClassObj != null) ? Request.ABPClassObj.Get() : null);
			if (Request.ModularType != ECharacterModularType.CopyPose)
			{
				uClass = null;
			}
			BeforeSetNewSM(EquipPosition, Request.ModularType);
			value.Get().SetSkeletalMesh(uSkeletalMesh);
			value.Get().SetAnimClass(uClass);
			AfterSetNewSM(EquipPosition, Request.ModularType, uSkeletalMesh, Request.AttachSocketName);
		}
	}

	private void BeforeSetNewSM(EquipPosition EquipPosition, ECharacterModularType ModularType)
	{
		if (!CharacterModularData.MapEquipSMC.TryGetValue(EquipPosition, out var value))
		{
			return;
		}
		USkeletalMeshComponent uSkeletalMeshComponent = value.Get();
		if (!(CharacterModularData.MasterMesh == null))
		{
			switch (ModularType)
			{
			case ECharacterModularType.MasterPose:
				uSkeletalMeshComponent.SetMasterPoseComponent(CharacterModularData.MasterMesh);
				break;
			case ECharacterModularType.CopyPose:
				uSkeletalMeshComponent.SetMasterPoseComponent(null);
				break;
			case ECharacterModularType.AttachToSocket:
				uSkeletalMeshComponent.SetMasterPoseComponent(null);
				break;
			}
			ResetModularCollisionProfile(uSkeletalMeshComponent, ModularType);
		}
	}

	private void ResetModularCollisionProfile(USkeletalMeshComponent SMC, ECharacterModularType ModularType)
	{
		if (!(SMC == null) && (PerformerConfigInfoData == null || !PerformerConfigInfoData.bUseCustomBodyPartCollision))
		{
			switch (ModularType)
			{
			case ECharacterModularType.MasterPose:
				SMC.SetCollisionProfileName(B1GlobalFNames.NoCollision);
				break;
			case ECharacterModularType.CopyPose:
				SMC.SetCollisionProfileName(B1GlobalFNames.BodyPart);
				break;
			case ECharacterModularType.AttachToSocket:
				SMC.SetCollisionProfileName(B1GlobalFNames.BodyPart);
				break;
			}
		}
	}

	private void AfterSetNewSM(EquipPosition EquipPosition, ECharacterModularType ModularType, USkeletalMesh NewSM, string AttachSocketName)
	{
		if (!CharacterModularData.MapEquipSMC.TryGetValue(EquipPosition, out var value))
		{
			return;
		}
		RefreshSkeletalMeshMaterials(value.Get(), NewSM);
		string attachSocketName = "";
		if (ModularType == ECharacterModularType.AttachToSocket && !AttachSocketName.Equals(""))
		{
			TArrayReadWrite<FName> componentTags = value.Get().ComponentTags;
			if (componentTags.Count != 0)
			{
				FName fName = componentTags[0];
				if (fName != FName.None)
				{
					Dictionary<FName, string> equipTagAndAttachSocketMapping = CharacterModularData.EquipTagAndAttachSocketMapping;
					Dictionary<string, USkeletalMesh> equipMeshesIndexByAttachSocket = CharacterModularData.EquipMeshesIndexByAttachSocket;
					if (equipTagAndAttachSocketMapping.ContainsKey(fName))
					{
						string text = equipTagAndAttachSocketMapping[fName];
						if (text != AttachSocketName && equipMeshesIndexByAttachSocket.ContainsKey(text))
						{
							equipMeshesIndexByAttachSocket.Remove(text);
						}
						equipTagAndAttachSocketMapping[fName] = AttachSocketName;
					}
					else
					{
						equipTagAndAttachSocketMapping.Add(fName, AttachSocketName);
					}
					if (equipMeshesIndexByAttachSocket.ContainsKey(AttachSocketName))
					{
						equipMeshesIndexByAttachSocket[AttachSocketName] = NewSM;
					}
					else
					{
						equipMeshesIndexByAttachSocket.Add(AttachSocketName, NewSM);
					}
				}
			}
			attachSocketName = AttachSocketName;
		}
		RefreshSkeletalMeshAttachment(EquipPosition, attachSocketName);
		bool flag = ModularType == ECharacterModularType.CopyPose;
		b1.BUAnimModularMesh bUAnimModularMesh = value.Get().GetAnimInstance() as b1.BUAnimModularMesh;
		if (bUAnimModularMesh != null)
		{
			bUAnimModularMesh.bStopCopyPose = !flag;
		}
	}

	public override float GetAccumulatedDeltaTime()
	{
		if (!HasBegunPlay())
		{
			return -1f;
		}
		return 0f;
	}

	public override float GetCustomTimeDilation()
	{
		return 1f;
	}

	private void RefreshSkeletalMeshMaterials(USkeletalMeshComponent SMC, USkeletalMesh NewSM)
	{
		if (!(NewSM == null))
		{
			List<FSkeletalMaterial> materials = NewSM.GetMaterials();
			for (int i = 0; i < materials.Count; i++)
			{
				SMC.SetMaterial(i, materials[i].MaterialInterface);
			}
			for (int j = materials.Count; j < UGSE_SkeletalMeshFuncLib.GetNumOverrideMaterials(SMC); j++)
			{
				SMC.SetMaterial(j, null);
			}
		}
	}

	private void RefreshSkeletalMeshAttachment(EquipPosition EquipPosition, string AttachSocketName)
	{
		if (!(CharacterModularData.MasterMesh == null) && CharacterModularData.MapEquipSMC.TryGetValue(EquipPosition, out var value))
		{
			value.Get().AttachTo(CharacterModularData.MasterMesh, new FName(AttachSocketName), EAttachLocation.SnapToTarget, bWeldSimulatedBodies: true);
		}
	}

	private void OnSetCharacterModuleConstraintProfile(EquipPosition EquipPosition, in FName ProfileName, int InstanceID, int UniqueID)
	{
		if (!CharacterModularData.MapEquipSMC.TryGetValue(EquipPosition, out var value))
		{
			return;
		}
		string value2 = Convert.ToString(InstanceID) + Convert.ToString(UniqueID);
		if (ProfileName.Equals(FName.None))
		{
			if (!CharacterModularData.MapEquipSMCMontage.TryGetValue(EquipPosition, out var value3) || !value3.Equals(value2))
			{
				return;
			}
		}
		else
		{
			CharacterModularData.MapEquipSMCMontage[EquipPosition] = value2;
		}
		value.Get().SetConstraintProfileForAll(ProfileName, bDefaultIfNotFound: true);
		value.Get().UpdateJointsFromAnimation = true;
	}

	private void OnCharacterPhysicSimulateStateChanged(bool EnableSimulate)
	{
		if (EnableSimulate)
		{
			DisableBodyPartCollision();
		}
		else
		{
			ResetBodyPartCollision();
		}
	}

	private void ResetBodyPartCollision()
	{
		if (PerformerConfigInfoData != null && PerformerConfigInfoData.bUseCustomBodyPartCollision)
		{
			return;
		}
		foreach (KeyValuePair<EquipPosition, TStrongObjectPtr<USkeletalMeshComponent>> item in CharacterModularData.MapEquipSMC)
		{
			USkeletalMeshComponent uSkeletalMeshComponent = item.Value.Get();
			if (!(uSkeletalMeshComponent == null) && CharacterModularData.MapEquipModularType.TryGetValue(item.Key, out var value))
			{
				ResetModularCollisionProfile(uSkeletalMeshComponent, value);
			}
		}
		CharacterModularData.TailMesh?.SetCollisionProfileName(B1GlobalFNames.BodyPart);
	}

	private void DisableBodyPartCollision()
	{
		if (PerformerConfigInfoData != null && PerformerConfigInfoData.bUseCustomBodyPartCollision)
		{
			return;
		}
		foreach (KeyValuePair<EquipPosition, TStrongObjectPtr<USkeletalMeshComponent>> item in CharacterModularData.MapEquipSMC)
		{
			USkeletalMeshComponent uSkeletalMeshComponent = item.Value.Get();
			if (!(uSkeletalMeshComponent == null))
			{
				uSkeletalMeshComponent.SetCollisionProfileName(B1GlobalFNames.NoCollision);
			}
		}
		CharacterModularData.TailMesh?.SetCollisionProfileName(B1GlobalFNames.NoCollision);
	}

	private void OnSetModularMeshVisibility(bool bVisible)
	{
		foreach (KeyValuePair<EquipPosition, TStrongObjectPtr<USkeletalMeshComponent>> item in CharacterModularData.MapEquipSMC)
		{
			USkeletalMeshComponent uSkeletalMeshComponent = item.Value.Get();
			if (!(uSkeletalMeshComponent == null))
			{
				uSkeletalMeshComponent.SetVisibility(bVisible);
			}
		}
		foreach (KeyValuePair<EquipPosition, List<TStrongObjectPtr<UStaticMeshComponent>>> item2 in CharacterModularData.MapEquipStaticMeshComp)
		{
			foreach (TStrongObjectPtr<UStaticMeshComponent> item3 in item2.Value)
			{
				UStaticMeshComponent uStaticMeshComponent = item3.Get();
				if (!(uStaticMeshComponent == null))
				{
					uStaticMeshComponent.SetVisibility(bVisible);
				}
			}
		}
		if (CharacterModularData.TailMesh != null)
		{
			CharacterModularData.TailMesh.SetVisibility(bVisible);
		}
	}

	private void OnTriggerModularMeshTickAnimForCopyPose()
	{
		foreach (KeyValuePair<EquipPosition, TStrongObjectPtr<USkeletalMeshComponent>> item in CharacterModularData.MapEquipSMC)
		{
			USkeletalMeshComponent uSkeletalMeshComponent = item.Value.Get();
			if (!(uSkeletalMeshComponent == null) && !uSkeletalMeshComponent.MasterPoseComponent.IsValid())
			{
				UGSE_AnimFuncLib.TickAnimationAndRefreshBone_SkeletalMesh(uSkeletalMeshComponent);
			}
		}
	}
}
