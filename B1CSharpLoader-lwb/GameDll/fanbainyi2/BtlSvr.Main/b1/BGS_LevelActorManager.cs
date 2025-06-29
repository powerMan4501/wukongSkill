using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BGS_LevelActorManager : GameStateSystemBase
{
	private BGC_LevelActorData LevelActorData { get; set; }

	public override void OnAttach()
	{
		LevelActorData = RequireWritableData<BGC_LevelActorData>();
		base.BGSEventCollection.Evt_OnSpawnStaticMeshActor += new Del_SpawnStaticMeshActor(OnSpawnStaticMeshActor);
		base.BGSEventCollection.Evt_RegisterSceneItem += new Del_Void_Actor(RegisterSceneItem);
		base.BGSEventCollection.Evt_UnregisterSceneItem += new Del_Void_Actor(UnregisterSceneItem);
		base.BGSEventCollection.Evt_BGS_OnRegisterAllowUseSpecialItemArea += new Del_Actor(RegisterAllowUseSpecialItemArea);
		base.BGSEventCollection.Evt_BGS_OnUnregisterAllowUseSpecialItemArea += new Del_Actor(UnregisterAllowUseSpecialItemArea);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		List<AStaticMeshActor> list = new List<AStaticMeshActor>();
		foreach (KeyValuePair<AStaticMeshActor, TStrongObjectPtr<BGWDataAsset_StaticMeshActorSetting>> spawnedActor in LevelActorData.SpawnedActors)
		{
			BGWDataAsset_StaticMeshActorSetting bGWDataAsset_StaticMeshActorSetting = spawnedActor.Value.Get();
			if (!(bGWDataAsset_StaticMeshActorSetting == null))
			{
				bGWDataAsset_StaticMeshActorSetting.ExistedTime += DeltaTime;
				if (bGWDataAsset_StaticMeshActorSetting.ExistedTime >= bGWDataAsset_StaticMeshActorSetting.TotalExistTime)
				{
					list.Add(spawnedActor.Key);
				}
				UpdateMaterial(spawnedActor.Key, DeltaTime);
			}
		}
		foreach (AStaticMeshActor item in list)
		{
			LevelActorData.SpawnedActors.Remove(item);
			BGU_UnrealWorldUtil.DestroyActor(item);
		}
		list.Clear();
	}

	private void RegisterAllowUseSpecialItemArea(AActor Actor)
	{
		BUAllowUseSpecialItemArea bUAllowUseSpecialItemArea = Actor as BUAllowUseSpecialItemArea;
		if (bUAllowUseSpecialItemArea == null)
		{
			return;
		}
		List<int> allowUseItemIDS = bUAllowUseSpecialItemArea.GetAllowUseItemIDS();
		if (allowUseItemIDS.Count <= 0)
		{
			return;
		}
		foreach (int item in allowUseItemIDS)
		{
			LevelActorData.AllowUseSpecialItemAreaMultiMap.Add(item, bUAllowUseSpecialItemArea);
		}
	}

	private void UnregisterAllowUseSpecialItemArea(AActor Actor)
	{
		BUAllowUseSpecialItemArea bUAllowUseSpecialItemArea = Actor as BUAllowUseSpecialItemArea;
		if (bUAllowUseSpecialItemArea == null)
		{
			return;
		}
		foreach (int allowUseItemID in bUAllowUseSpecialItemArea.GetAllowUseItemIDS())
		{
			if (LevelActorData.AllowUseSpecialItemAreaMultiMap.ContainsKey(allowUseItemID))
			{
				List<BUAllowUseSpecialItemArea> list = LevelActorData.AllowUseSpecialItemAreaMultiMap[allowUseItemID];
				if (list.Count == 1)
				{
					LevelActorData.AllowUseSpecialItemAreaMultiMap.Remove(allowUseItemID);
				}
				else
				{
					list.Remove(bUAllowUseSpecialItemArea);
				}
			}
		}
	}

	private void RegisterSceneItem(AActor SceneItem)
	{
		List<FName> list = SceneItem.Tags.ToList();
		if (list.Count <= 0)
		{
			return;
		}
		foreach (FName item in list)
		{
			LevelActorData.TagSceneItemMultiMap.Add(item, SceneItem);
		}
		LevelActorData.RegisteredSceneItemTags.Add(SceneItem, list);
	}

	private void UnregisterSceneItem(AActor SceneItem)
	{
		if (!LevelActorData.RegisteredSceneItemTags.ContainsKey(SceneItem))
		{
			return;
		}
		foreach (FName item in LevelActorData.RegisteredSceneItemTags[SceneItem])
		{
			if (LevelActorData.TagSceneItemMultiMap.ContainsKey(item))
			{
				List<AActor> list = LevelActorData.TagSceneItemMultiMap[item];
				if (list.Count == 1)
				{
					LevelActorData.TagSceneItemMultiMap.Remove(item);
				}
				else
				{
					list.Remove(SceneItem);
				}
			}
		}
		LevelActorData.RegisteredSceneItemTags.Remove(SceneItem);
	}

	private void OnSpawnStaticMeshActor(BGWDataAsset_StaticMeshActorSetting InStaticMeshActorSetting, BGUCharacterCS Owner, bool bAttach)
	{
		if (Owner == null)
		{
			return;
		}
		AStaticMeshActor aStaticMeshActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay<AStaticMeshActor>(Owner.World);
		aStaticMeshActor.StaticMeshComponent.CastShadow = false;
		aStaticMeshActor.StaticMeshComponent.SetTranslucentSortPriority(-10);
		aStaticMeshActor.StaticMeshComponent.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		aStaticMeshActor.StaticMeshComponent.AffectDistanceFieldLighting = false;
		aStaticMeshActor.SetMobility(EComponentMobility.Movable);
		BGWDataAsset_StaticMeshActorSetting bGWDataAsset_StaticMeshActorSetting = UObject.NewObject<BGWDataAsset_StaticMeshActorSetting>(aStaticMeshActor, FName.None, EObjectFlags.Transient, InStaticMeshActorSetting, copyTransientsFromClassDefaults: false, (IntPtr)0);
		bGWDataAsset_StaticMeshActorSetting.ExistedTime = 0f;
		LevelActorData.SpawnedActors.Add(aStaticMeshActor, new TStrongObjectPtr_NoCollect<BGWDataAsset_StaticMeshActorSetting>(bGWDataAsset_StaticMeshActorSetting));
		FHitResult SweepHitResult;
		if (bAttach)
		{
			aStaticMeshActor.AttachToActor(Owner, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepWorld, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			aStaticMeshActor.SetActorRelativeLocation(FVector.ZeroVector, bSweep: false, out SweepHitResult, bTeleport: false);
			aStaticMeshActor.SetActorRelativeRotation(FRotator.ZeroRotator, bSweep: false, out SweepHitResult, bTeleport: false);
		}
		else
		{
			FVector newLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			FRotator newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner);
			aStaticMeshActor.SetActorLocationAndRotation(newLocation, newRotation, bSweep: false, out var _, bTeleport: false);
		}
		float scaledCapsuleHalfHeight = Owner.CapsuleComponent.GetScaledCapsuleHalfHeight();
		scaledCapsuleHalfHeight /= InStaticMeshActorSetting.Mesh.GetBounds().SphereRadius;
		scaledCapsuleHalfHeight *= 2f;
		aStaticMeshActor.SetActorScale3D(new FVector(scaledCapsuleHalfHeight));
		aStaticMeshActor.AddActorLocalOffset(FVector.UpVector * (0f - Owner.CapsuleComponent.GetScaledCapsuleHalfHeight()), bSweep: false, out SweepHitResult, bTeleport: false);
		aStaticMeshActor.StaticMeshComponent.SetStaticMesh(bGWDataAsset_StaticMeshActorSetting.Mesh);
		for (int i = 0; i < bGWDataAsset_StaticMeshActorSetting.Materials.Count; i++)
		{
			UMaterialInterface parent = bGWDataAsset_StaticMeshActorSetting.Materials[i];
			UMaterialInstanceDynamic material = UMaterialLibrary.CreateDynamicMaterialInstance(aStaticMeshActor, parent, FName.None, EMIDCreationFlags.None);
			aStaticMeshActor.StaticMeshComponent.SetMaterial(i, material);
		}
		float num = 0f;
		foreach (UMaterialInterface material2 in aStaticMeshActor.StaticMeshComponent.GetMaterials())
		{
			UMaterialInstanceDynamic uMaterialInstanceDynamic = material2 as UMaterialInstanceDynamic;
			if (uMaterialInstanceDynamic == null)
			{
				continue;
			}
			foreach (FMatParam materialParameter in bGWDataAsset_StaticMeshActorSetting.MaterialParameters)
			{
				switch (materialParameter.ParamType)
				{
				case EGSMatParamType.Float:
					uMaterialInstanceDynamic.SetScalarParameterValue(materialParameter.ParameterName, materialParameter.FloatValue);
					break;
				case EGSMatParamType.Vector:
				{
					FVector inVec = materialParameter.VectorValue;
					if (materialParameter.ParameterName == B1GlobalFNames.Direction)
					{
						inVec = Owner.GetVelocity();
						inVec.Normalize();
					}
					uMaterialInstanceDynamic.SetVectorParameterValue(materialParameter.ParameterName, inVec.Conv_VectorToLinearColor());
					break;
				}
				case EGSMatParamType.LinearColor:
					uMaterialInstanceDynamic.SetVectorParameterValue(materialParameter.ParameterName, materialParameter.LinearColorValue);
					break;
				}
			}
		}
		foreach (FMatParam materialParameter2 in bGWDataAsset_StaticMeshActorSetting.MaterialParameters)
		{
			switch (materialParameter2.ParamType)
			{
			case EGSMatParamType.FloatCurve:
				if (materialParameter2.FloatCurve != null)
				{
					materialParameter2.FloatCurve.GetTimeRange(out var _, out var MaxTime3);
					if (MaxTime3 > num)
					{
						num = MaxTime3;
					}
				}
				break;
			case EGSMatParamType.VectorCurve:
				if (materialParameter2.VectorCurve != null)
				{
					materialParameter2.VectorCurve.GetTimeRange(out var _, out var MaxTime2);
					if (MaxTime2 > num)
					{
						num = MaxTime2;
					}
				}
				break;
			case EGSMatParamType.LinearColorValue:
				if (materialParameter2.LinearColorCurve != null)
				{
					materialParameter2.LinearColorCurve.GetTimeRange(out var _, out var MaxTime);
					if (MaxTime > num)
					{
						num = MaxTime;
					}
				}
				break;
			}
		}
		if (bGWDataAsset_StaticMeshActorSetting.DurationTime == 0)
		{
			bGWDataAsset_StaticMeshActorSetting.TotalExistTime = num;
		}
		else
		{
			bGWDataAsset_StaticMeshActorSetting.TotalExistTime = bGWDataAsset_StaticMeshActorSetting.DurationTime;
		}
		UpdateMaterial(aStaticMeshActor, 0f);
	}

	private void UpdateMaterial(AStaticMeshActor StaticMeshActor, float DeltaTime)
	{
		if (StaticMeshActor == null || !LevelActorData.SpawnedActors.ContainsKey(StaticMeshActor))
		{
			return;
		}
		BGWDataAsset_StaticMeshActorSetting bGWDataAsset_StaticMeshActorSetting = LevelActorData.SpawnedActors[StaticMeshActor].Get();
		if (bGWDataAsset_StaticMeshActorSetting == null)
		{
			return;
		}
		foreach (UMaterialInterface material in StaticMeshActor.StaticMeshComponent.GetMaterials())
		{
			UMaterialInstanceDynamic uMaterialInstanceDynamic = material as UMaterialInstanceDynamic;
			if (uMaterialInstanceDynamic == null)
			{
				continue;
			}
			foreach (FMatParam materialParameter in bGWDataAsset_StaticMeshActorSetting.MaterialParameters)
			{
				switch (materialParameter.ParamType)
				{
				case EGSMatParamType.FloatCurve:
					if (materialParameter.FloatCurve != null)
					{
						float floatValue = materialParameter.FloatCurve.GetFloatValue(DeltaTime);
						uMaterialInstanceDynamic.SetScalarParameterValue(materialParameter.ParameterName, floatValue);
					}
					break;
				case EGSMatParamType.VectorCurve:
					if (materialParameter.VectorCurve != null)
					{
						FVector vectorValue = materialParameter.VectorCurve.GetVectorValue(DeltaTime);
						uMaterialInstanceDynamic.SetVectorParameterValue(materialParameter.ParameterName, vectorValue.Conv_VectorToLinearColor());
					}
					break;
				case EGSMatParamType.LinearColorValue:
					if (materialParameter.LinearColorCurve != null)
					{
						FLinearColor linearColorValue = materialParameter.LinearColorCurve.GetLinearColorValue(DeltaTime);
						uMaterialInstanceDynamic.SetVectorParameterValue(materialParameter.ParameterName, linearColorValue);
					}
					break;
				}
			}
		}
	}
}
