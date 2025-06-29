using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ShadowPoseableComp : UActorCompBaseCS
{
	private const float MAX_POSEABLE_TIME_IN_SECOND = 100f;

	private b1.BUC_ShadowPoseableData ShadowPoseableData { get; set; }

	private IBUC_EquipData EquipData { get; set; }

	public override void OnAttach()
	{
		ShadowPoseableData = RequireWritableData<b1.BUC_ShadowPoseableData>();
		EquipData = RequireReadOnlyData<IBUC_EquipData, BUC_EquipData>();
		ShadowPoseableData.OriActorScale = GetOwner().GetActorScale3D();
		base.BUSEventCollection.Evt_TriggerGhostActor += new Del_TriggerGhostActor(OnTriggerGhostActor);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateForGhost(DeltaTime);
	}

	private void UpdateForGhost(float DeltaTime)
	{
		AActor owner = GetOwner();
		if (owner == null || owner.IsPendingKill)
		{
			return;
		}
		BGUShadowActorStaticBase bGUShadowActorStaticBase = owner as BGUShadowActorStaticBase;
		if (bGUShadowActorStaticBase == null || bGUShadowActorStaticBase.IsPendingKill || ShadowPoseableData.IsFinish)
		{
			return;
		}
		ShadowPoseableData.UpdateTimer += DeltaTime;
		foreach (MatParamInfoForData matInfo in ShadowPoseableData.MatInfoList)
		{
			float num = 0f;
			SetPoseableMeshParamValueOnMat(Value: (!(matInfo.FloatCurve == null)) ? matInfo.FloatCurve.GetFloatValue(ShadowPoseableData.UpdateTimer) : ShadowPoseableData.UpdateTimer, ParamName: matInfo.ParameterName);
		}
		foreach (FMatParam postProcessMatInfo in ShadowPoseableData.PostProcessMatInfoList)
		{
			if (postProcessMatInfo.ParamType == EGSMatParamType.FloatCurve)
			{
				float num2 = 0f;
				if (!(postProcessMatInfo.FloatCurve != null))
				{
					continue;
				}
				num2 = postProcessMatInfo.FloatCurve.GetFloatValue(ShadowPoseableData.UpdateTimer);
				foreach (UMaterialInstanceDynamic postProcessMID in ShadowPoseableData.PostProcessMIDs)
				{
					postProcessMID.SetScalarParameterValue(postProcessMatInfo.ParameterName, num2);
				}
			}
			else if (postProcessMatInfo.ParamType == EGSMatParamType.VectorCurve)
			{
				if (!(postProcessMatInfo.VectorCurve != null))
				{
					continue;
				}
				FVector vectorValue = postProcessMatInfo.VectorCurve.GetVectorValue(ShadowPoseableData.UpdateTimer);
				foreach (UMaterialInstanceDynamic postProcessMID2 in ShadowPoseableData.PostProcessMIDs)
				{
					postProcessMID2.SetVectorParameterValue(postProcessMatInfo.ParameterName, vectorValue.Conv_VectorToLinearColor());
				}
			}
			else
			{
				if (postProcessMatInfo.ParamType != EGSMatParamType.LinearColorValue || !(postProcessMatInfo.LinearColorCurve != null))
				{
					continue;
				}
				FLinearColor linearColorValue = postProcessMatInfo.LinearColorCurve.GetLinearColorValue(ShadowPoseableData.UpdateTimer);
				foreach (UMaterialInstanceDynamic postProcessMID3 in ShadowPoseableData.PostProcessMIDs)
				{
					postProcessMID3.SetVectorParameterValue(postProcessMatInfo.ParameterName, linearColorValue);
				}
			}
		}
		if (ShadowPoseableData.ScaleCurve != null)
		{
			float floatValue = ShadowPoseableData.ScaleCurve.GetFloatValue(ShadowPoseableData.UpdateTimer);
			owner.SetActorScale3D(ShadowPoseableData.OriActorScale * floatValue);
		}
		if (!(ShadowPoseableData.UpdateTimer > ShadowPoseableData.TotalUpdateTimeInSecond))
		{
			return;
		}
		ShadowPoseableData.IsFinish = true;
		foreach (BGUCharacterCS allPlayerActor in BGU_UnrealWorldUtil.GetAllPlayerActors(owner))
		{
			UCameraComponent componentByClass = allPlayerActor.GetComponentByClass<UCameraComponent>();
			if (!(componentByClass != null))
			{
				continue;
			}
			foreach (UMaterialInstanceDynamic postProcessMID4 in ShadowPoseableData.PostProcessMIDs)
			{
				componentByClass.RemoveBlendable(postProcessMID4);
			}
		}
		BGU_UnrealWorldUtil.DestroyActor(owner);
	}

	private void OnTriggerGhostActor(ACharacter PoseableChr, BGWDataAsset_GhostActorSetting GhostActorSetting, FEffectInstReq EffectInstReq = default(FEffectInstReq), UAnimMontage MontageToMapTo = null)
	{
		AActor owner = GetOwner();
		if (owner == null || owner.IsPendingKill)
		{
			return;
		}
		BGUShadowActorStaticBase bGUShadowActorStaticBase = owner as BGUShadowActorStaticBase;
		if (bGUShadowActorStaticBase == null || bGUShadowActorStaticBase.IsPendingKill)
		{
			return;
		}
		if (PoseableChr == null || PoseableChr.Mesh == null)
		{
			BGU_UnrealWorldUtil.DestroyActor(owner);
		}
		else
		{
			if (PoseableChr.GetCurrentMontage() == null)
			{
				return;
			}
			if (GhostActorSetting == null)
			{
				BGU_UnrealWorldUtil.DestroyActor(owner);
				return;
			}
			owner.SetActorScale3D(ShadowPoseableData.OriActorScale * GhostActorSetting.Scale);
			string text = "/Game/00MainHZ/Characters/Wukong/Meshes/Equip/BakeCloth/";
			string text2 = "SM_BakeCloth_";
			string text3 = ((MontageToMapTo == null) ? PoseableChr.GetCurrentMontage().GetName() : MontageToMapTo.GetName());
			IBUC_EquipData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_EquipData>(PoseableChr);
			bool flag = false;
			foreach (KeyValuePair<EquipPosition, int> item in unPersistentReadOnlyData.SelfEquipMap)
			{
				EquipPosition key = item.Key;
				EquipDesc equipDesc = GameDBRuntime.GetEquipDesc(item.Value);
				if (equipDesc == null)
				{
					continue;
				}
				if (equipDesc.HideTail == YesNoType.Yes)
				{
					flag = true;
				}
				string obj = (unPersistentReadOnlyData.EquipIllusionList.ContainsKey(key) ? unPersistentReadOnlyData.EquipIllusionList[key] : equipDesc.SkeletalMesh);
				int num = obj.LastIndexOf('.');
				string text4 = obj.Substring(num + 1);
				text3 = "AS" + text3.Substring(2);
				string path = text + text2 + text4 + "_" + text3 + "." + text2 + text4 + "_" + text3;
				UStaticMesh uStaticMesh = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UStaticMesh>(path, ELoadResourceType.AsyncLoadAndCache);
				if (uStaticMesh == null)
				{
					switch (key)
					{
					case EquipPosition.Head:
						text4 = "SK_Wukong_head_born";
						break;
					case EquipPosition.Upwear:
						text4 = "SK_WuKong_body_HuPi";
						break;
					case EquipPosition.Arm:
						text4 = "SK_WuKong_arm_HuPi";
						break;
					case EquipPosition.Foot:
						text4 = "SK_WuKong_foot_HuPi";
						break;
					case EquipPosition.Weapon:
						text4 = "SK_Wukong_Born02";
						break;
					case EquipPosition.Hulu:
						text4 = "SK_Wukong_gourd_born";
						break;
					}
					path = text + text2 + text4 + "_" + text3 + "." + text2 + text4 + "_" + text3;
					uStaticMesh = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UStaticMesh>(path, ELoadResourceType.AsyncLoadAndCache);
				}
				if (uStaticMesh != null)
				{
					switch (key)
					{
					case EquipPosition.Head:
						bGUShadowActorStaticBase.HeadMesh.SetStaticMesh(uStaticMesh);
						break;
					case EquipPosition.Upwear:
						bGUShadowActorStaticBase.BodyMesh.SetStaticMesh(uStaticMesh);
						break;
					case EquipPosition.Arm:
						bGUShadowActorStaticBase.ArmMesh.SetStaticMesh(uStaticMesh);
						break;
					case EquipPosition.Foot:
						bGUShadowActorStaticBase.FootMesh.SetStaticMesh(uStaticMesh);
						break;
					case EquipPosition.Weapon:
						bGUShadowActorStaticBase.WeaponMesh.SetStaticMesh(uStaticMesh);
						break;
					case EquipPosition.Hulu:
						bGUShadowActorStaticBase.HuluMesh.SetStaticMesh(uStaticMesh);
						break;
					}
				}
				if (equipDesc.StaticMesh.Count > 0)
				{
					string text5 = equipDesc.StaticMesh[0];
					int num2 = text5.LastIndexOf('.');
					string text6 = text5.Substring(num2 + 1);
					text5 = text + text2 + text6 + "_" + text3 + "." + text2 + text6 + "_" + text3;
					UStaticMesh staticMesh = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UStaticMesh>(text5, ELoadResourceType.AsyncLoadAndCache);
					bGUShadowActorStaticBase.HairMesh.SetStaticMesh(staticMesh);
				}
			}
			if (!flag)
			{
				string text7 = "SK_weiba";
				string path2 = text + text2 + text7 + "_" + text3 + "." + text2 + text7 + "_" + text3;
				UStaticMesh staticMesh2 = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UStaticMesh>(path2, ELoadResourceType.AsyncLoadAndCache);
				bGUShadowActorStaticBase.TailMesh.SetStaticMesh(staticMesh2);
			}
			BGUFuncLibActorTransformCS.BGUSetActorRotation(bGUShadowActorStaticBase, BGUFuncLibActorTransformCS.BGUGetActorRotation(PoseableChr), bTeleportPhysics: false);
			float num3 = 0f;
			if (GhostActorSetting.ScaleUseCurve && GhostActorSetting.ScaleCurve != null)
			{
				GhostActorSetting.ScaleCurve.GetTimeRange(out var _, out var MaxTime);
				ShadowPoseableData.ScaleCurve = GhostActorSetting.ScaleCurve;
				num3 = MaxTime;
			}
			else
			{
				owner.SetActorScale3D(ShadowPoseableData.OriActorScale * GhostActorSetting.Scale);
			}
			foreach (FMatParamInfo matParam in GhostActorSetting.MatParams)
			{
				FMatParamInfo MPI = matParam;
				ShadowPoseableData.MatInfoList.Add(new MatParamInfoForData(in MPI));
				if (MPI.FloatCurve != null)
				{
					MPI.FloatCurve.GetTimeRange(out var _, out var MaxTime2);
					if (MaxTime2 > num3)
					{
						num3 = MaxTime2;
					}
				}
			}
			if (GhostActorSetting.bEnableCustomDepthStencil)
			{
				foreach (FCustomDepthStencilInfo customDepthStencilInfo in GhostActorSetting.CustomDepthStencilInfos)
				{
					base.BUSEventCollection?.Evt_SetCustomDepthStencilByComp.Invoke(customDepthStencilInfo.ComponentTag, customDepthStencilInfo.bRenderCustomDepth, customDepthStencilInfo.CustomDepthStencilValue);
				}
			}
			List<BGUCharacterCS> allPlayerActors = BGU_UnrealWorldUtil.GetAllPlayerActors(owner);
			foreach (UMaterialInterface postProcessMatInstance in GhostActorSetting.PostProcessMatInstances)
			{
				UMaterialInstanceDynamic uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(owner, postProcessMatInstance, FName.None, EMIDCreationFlags.None);
				if (uMaterialInstanceDynamic.IsNullOrDestroyed())
				{
					continue;
				}
				ShadowPoseableData.PostProcessMIDs.Add(uMaterialInstanceDynamic);
				foreach (BGUCharacterCS item2 in allPlayerActors)
				{
					UCameraComponent componentByClass = item2.GetComponentByClass<UCameraComponent>();
					if (componentByClass != null)
					{
						componentByClass.AddOrUpdateBlendable(uMaterialInstanceDynamic);
					}
				}
			}
			foreach (FMatParam postProcessMatParam in GhostActorSetting.PostProcessMatParams)
			{
				switch (postProcessMatParam.ParamType)
				{
				case EGSMatParamType.FloatCurve:
					if (postProcessMatParam.FloatCurve != null)
					{
						postProcessMatParam.FloatCurve.GetTimeRange(out var _, out var MaxTime5);
						if (MaxTime5 > num3)
						{
							num3 = MaxTime5;
						}
						ShadowPoseableData.PostProcessMatInfoList.Add(postProcessMatParam);
					}
					break;
				case EGSMatParamType.VectorCurve:
					if (postProcessMatParam.VectorCurve != null)
					{
						postProcessMatParam.VectorCurve.GetTimeRange(out var _, out var MaxTime4);
						if (MaxTime4 > num3)
						{
							num3 = MaxTime4;
						}
						ShadowPoseableData.PostProcessMatInfoList.Add(postProcessMatParam);
					}
					break;
				case EGSMatParamType.LinearColorValue:
					if (postProcessMatParam.LinearColorCurve != null)
					{
						postProcessMatParam.LinearColorCurve.GetTimeRange(out var _, out var MaxTime3);
						if (MaxTime3 > num3)
						{
							num3 = MaxTime3;
						}
						ShadowPoseableData.PostProcessMatInfoList.Add(postProcessMatParam);
					}
					break;
				case EGSMatParamType.Float:
					foreach (UMaterialInstanceDynamic postProcessMID in ShadowPoseableData.PostProcessMIDs)
					{
						postProcessMID.SetScalarParameterValue(postProcessMatParam.ParameterName, postProcessMatParam.FloatValue);
					}
					break;
				case EGSMatParamType.Vector:
					foreach (UMaterialInstanceDynamic postProcessMID2 in ShadowPoseableData.PostProcessMIDs)
					{
						FVector inVec = postProcessMatParam.VectorValue;
						inVec.Normalize();
						if (postProcessMatParam.ParameterName == B1GlobalFNames.Direction && PoseableChr != null)
						{
							inVec = PoseableChr.GetVelocity();
							inVec.Normalize();
						}
						postProcessMID2.SetVectorParameterValue(postProcessMatParam.ParameterName, inVec.Conv_VectorToLinearColor());
					}
					break;
				case EGSMatParamType.LinearColor:
					foreach (UMaterialInstanceDynamic postProcessMID3 in ShadowPoseableData.PostProcessMIDs)
					{
						postProcessMID3.SetVectorParameterValue(postProcessMatParam.ParameterName, postProcessMatParam.LinearColorValue);
					}
					break;
				}
			}
			ShadowPoseableData.UpdateTimer = 0f;
			ShadowPoseableData.TotalUpdateTimeInSecond = ((100f < num3) ? 100f : num3);
			UpdateForGhost(0f);
			OnSetCustomPrimetiveData(EffectInstReq);
		}
	}

	private void OnSetCustomPrimetiveData(FEffectInstReq EffectInstReq)
	{
		BGUGhostActorBase bGUGhostActorBase = GetOwner() as BGUGhostActorBase;
		if (!(bGUGhostActorBase == null))
		{
			UMeshComponent poseableMeshComp = bGUGhostActorBase.PoseableMeshComp;
			if (poseableMeshComp != null)
			{
				poseableMeshComp.SetCustomPrimitiveDataFloat(10, 2f);
			}
			poseableMeshComp.SetCustomPrimitiveDataFloat(11, bGUGhostActorBase.World.GetTimeSeconds());
			poseableMeshComp.SetCustomPrimitiveDataVector3(12, EffectInstReq.HitLocation);
			poseableMeshComp.SetCustomPrimitiveDataVector3(15, EffectInstReq.HitPointNormalDir.Vector().GetSafeNormal());
			poseableMeshComp.SetCustomPrimitiveDataVector3(18, EffectInstReq.HitDiretionRealDir);
		}
	}

	private void SetPoseableMeshParamValueOnMat(FName ParamName, float Value)
	{
		BGUShadowActorStaticBase bGUShadowActorStaticBase = Owner as BGUShadowActorStaticBase;
		if (!(bGUShadowActorStaticBase == null))
		{
			bGUShadowActorStaticBase.BodyMesh.SetScalarParameterValueOnMaterials(ParamName, Value);
			bGUShadowActorStaticBase.HeadMesh.SetScalarParameterValueOnMaterials(ParamName, Value);
			bGUShadowActorStaticBase.ArmMesh.SetScalarParameterValueOnMaterials(ParamName, Value);
			bGUShadowActorStaticBase.FootMesh.SetScalarParameterValueOnMaterials(ParamName, Value);
			bGUShadowActorStaticBase.WeaponMesh.SetScalarParameterValueOnMaterials(ParamName, Value);
			bGUShadowActorStaticBase.HuluMesh.SetScalarParameterValueOnMaterials(ParamName, Value);
			bGUShadowActorStaticBase.TailMesh.SetScalarParameterValueOnMaterials(ParamName, Value);
			bGUShadowActorStaticBase.HairMesh.SetScalarParameterValueOnMaterials(ParamName, Value);
		}
	}
}
