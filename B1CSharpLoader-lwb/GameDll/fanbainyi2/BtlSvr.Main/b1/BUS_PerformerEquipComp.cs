using System;
using System.Collections.Generic;
using b1.BGW;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_PerformerEquipComp : UActorCompBaseCS
{
	private BUC_PerformerEquipData PerformerEquipData { get; set; }

	private IBUC_CharacterModularData CharacterModularData { get; set; }

	private IBUC_EquipData EquipData { get; set; }

	private IBPC_RoleBaseData PlayerRoleData { get; set; }

	private IBUC_EnvironmentMaskData EnvironmentMaskData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		PerformerEquipData = RequireWritableData<BUC_PerformerEquipData>();
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_TriggerSyncEquip = (BGW_EventCollection.Del_TriggerSyncEquip)Delegate.Combine(bGWEventCollection.Evt_TriggerSyncEquip, new BGW_EventCollection.Del_TriggerSyncEquip(OnTriggerSyncEquip));
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		if (!(Owner is BGUPerformerActorCS bGUPerformerActorCS))
		{
			return;
		}
		if (PerformerEquipData.bUseMergeMesh)
		{
			PerformerEquipData.MasterMeshComponent = new TWeakObject<USkeletalMeshComponent>(bGUPerformerActorCS.Mesh);
			bGUPerformerActorCS.Mesh.GetChildrenComponents(bIncludeAllDescendants: false, out var Children);
			foreach (USceneComponent item in Children)
			{
				if (item is USkeletalMeshComponent uSkeletalMeshComponent && uSkeletalMeshComponent.ComponentTags.Count > 0)
				{
					FName fName = uSkeletalMeshComponent.ComponentTags[0];
					if (fName != FName.None)
					{
						PerformerEquipData.TaggedMeshComponents.Add(fName, new TWeakObject<USkeletalMeshComponent>(uSkeletalMeshComponent));
					}
				}
			}
		}
		OnTriggerSyncEquip(ESeqHiddenHeadType.Hidden);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		PerformerEquipData.MasterMeshComponent.Set(null);
		PerformerEquipData.TaggedMeshComponents.Clear();
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_TriggerSyncEquip = (BGW_EventCollection.Del_TriggerSyncEquip)Delegate.Remove(bGWEventCollection.Evt_TriggerSyncEquip, new BGW_EventCollection.Del_TriggerSyncEquip(OnTriggerSyncEquip));
		base.OnEndPlay(EndPlayReason);
	}

	private void OnTriggerSyncEquip(ESeqHiddenHeadType HiddenHeadType)
	{
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetOwner(), 0);
		if (playerCharacter == null)
		{
			return;
		}
		if (PerformerEquipData.bUseMergeMesh)
		{
			CharacterModularData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_CharacterModularData>(playerCharacter);
			if (CharacterModularData == null || !PerformerEquipData.MasterMeshComponent.IsValid())
			{
				return;
			}
			USkeletalMeshComponent uSkeletalMeshComponent = PerformerEquipData.MasterMeshComponent.Get();
			if (CharacterModularData.EquipMeshesIndexByAttachSocket.TryGetValue("", out var value) && uSkeletalMeshComponent.SkeletalMesh != value)
			{
				uSkeletalMeshComponent.SetSkeletalMesh(value);
			}
			foreach (KeyValuePair<FName, TWeakObject<USkeletalMeshComponent>> taggedMeshComponent in PerformerEquipData.TaggedMeshComponents)
			{
				FName key = taggedMeshComponent.Key;
				if (!taggedMeshComponent.Value.IsValid())
				{
					continue;
				}
				USkeletalMeshComponent uSkeletalMeshComponent2 = taggedMeshComponent.Value.Get();
				if (CharacterModularData.EquipTagAndAttachSocketMapping.TryGetValue(key, out var value2))
				{
					if (CharacterModularData.EquipMeshesIndexByAttachSocket.TryGetValue(value2, out var value3))
					{
						uSkeletalMeshComponent2.SetSkeletalMesh(value3);
					}
					uSkeletalMeshComponent2.AttachToComponent(uSkeletalMeshComponent, new FName(value2), EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
				}
			}
		}
		else
		{
			EquipData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_EquipData>(playerCharacter);
			PlayerRoleData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(playerCharacter.PlayerState);
			if (PlayerRoleData == null || EquipData == null)
			{
				return;
			}
			foreach (KeyValuePair<EquipPosition, int> item in EquipData.MapEquip)
			{
				int OutValue = 0;
				PlayerRoleData.EquipList?.TryGetValue(item.Key, out OutValue);
				if ((HiddenHeadType == ESeqHiddenHeadType.Hidden || HiddenHeadType == ESeqHiddenHeadType.HiddenExceptDaSheng) && item.Key == EquipPosition.Head)
				{
					if (HiddenHeadType == ESeqHiddenHeadType.HiddenExceptDaSheng)
					{
						int num = 12001;
						if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.DaShengHeadEquipID, out var ConfigInfo))
						{
							num = ConfigInfo.IntValue;
						}
						if (OutValue != num)
						{
							OutValue = 0;
						}
					}
					else
					{
						OutValue = 0;
					}
				}
				base.BUSEventCollection.Evt_ChangePreviewEquip.Invoke(item.Key, OutValue);
			}
		}
		EnvironmentMaskData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_EnvironmentMaskData>(playerCharacter);
		if (EnvironmentMaskData == null)
		{
			return;
		}
		BGWDataAsset_EnvironmentMaskGlobalConfig environmentMaskGlobalConfig = BGW_PreloadAssetMgr.Get(Owner).EnvironmentMaskGlobalConfig;
		if (environmentMaskGlobalConfig == null || environmentMaskGlobalConfig.EnvironmentMaskMappingList == null)
		{
			BGW_LogUtil.LogError("EnvironmentMaskGlobalConfig is not loaded!");
			return;
		}
		foreach (KeyValuePair<ESceneItemSurfaceType, float> accumulatedMaskDatum in EnvironmentMaskData.AccumulatedMaskData)
		{
			ESceneItemSurfaceType key2 = accumulatedMaskDatum.Key;
			float value4 = accumulatedMaskDatum.Value;
			if (!environmentMaskGlobalConfig.EnvironmentMaskMappingList.TryGetValue(key2, out var value5))
			{
				continue;
			}
			FName fName = new FName(value5.LayerMappingName_Layer);
			FName fName2 = new FName(value5.ParamName);
			if (!(fName == FName.None) && !(fName2 == FName.None))
			{
				FMatLayerFunctionInfo value6 = default(FMatLayerFunctionInfo);
				if (BGW_PreloadAssetMgr.Get(this).MatLayerFunctionMappingConfigMap.TryGetValue(0, out var value7) && value7.MatLayerFunctionInfoMap.TryGetValue(fName, out value6))
				{
					UMaterialFunctionInterface layerFunction = value6.LayerFunction;
					EMaterialParameterAssociation association = value6.Association;
					SetMaterialParameters(fName2, layerFunction, association, value4);
				}
			}
		}
	}

	private void SetMaterialParameters(FName ParamName, UMaterialFunctionInterface LayerFunction, EMaterialParameterAssociation Association, float Value)
	{
		if (Owner == null)
		{
			return;
		}
		foreach (UActorComponent item in Owner.GetComponentsByClass(UClass.GetClass<UMeshComponent>()))
		{
			UMeshComponent uMeshComponent = item as UMeshComponent;
			if (uMeshComponent == null)
			{
				continue;
			}
			int numMaterials = uMeshComponent.GetNumMaterials();
			for (int i = 0; i < numMaterials; i++)
			{
				UMaterialInstanceDynamic uMaterialInstanceDynamic = uMeshComponent.CreateDynamicMaterialInstance(i, null, FName.None);
				if (uMaterialInstanceDynamic != null)
				{
					FMaterialParameterInfo parameterInfo = uMaterialInstanceDynamic.GetParameterInfo(Association, ParamName, LayerFunction);
					uMaterialInstanceDynamic.SetScalarParameterValueByInfo(parameterInfo, Value);
				}
			}
		}
	}
}
