using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_GhostPoseableComp : UActorCompBaseCS
{
	private const float MAX_POSEABLE_TIME_IN_SECOND = 100f;

	private b1.BUC_GhostPoseableData GhostPoseableData;

	public override void OnAttach()
	{
		GhostPoseableData = RequireWritableData<b1.BUC_GhostPoseableData>();
		GhostPoseableData.OriActorScale = GetOwner().GetActorScale3D();
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
		BGUGhostActorBase bGUGhostActorBase = owner as BGUGhostActorBase;
		if (bGUGhostActorBase == null || bGUGhostActorBase.IsPendingKill || GhostPoseableData.IsFinish)
		{
			return;
		}
		GhostPoseableData.UpdateTimer += DeltaTime;
		foreach (MatParamInfoForData matInfo in GhostPoseableData.MatInfoList)
		{
			float num = 0f;
			bGUGhostActorBase.SetPoseableMeshParamValueOnMat(Value: (!(matInfo.FloatCurve == null)) ? matInfo.FloatCurve.GetFloatValue(GhostPoseableData.UpdateTimer) : GhostPoseableData.UpdateTimer, ParamName: matInfo.ParameterName);
		}
		foreach (FMatParam postProcessMatInfo in GhostPoseableData.PostProcessMatInfoList)
		{
			if (postProcessMatInfo.ParamType == EGSMatParamType.FloatCurve)
			{
				float num2 = 0f;
				if (!(postProcessMatInfo.FloatCurve != null))
				{
					continue;
				}
				num2 = postProcessMatInfo.FloatCurve.GetFloatValue(GhostPoseableData.UpdateTimer);
				foreach (UMaterialInstanceDynamic postProcessMID in GhostPoseableData.PostProcessMIDs)
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
				FVector vectorValue = postProcessMatInfo.VectorCurve.GetVectorValue(GhostPoseableData.UpdateTimer);
				foreach (UMaterialInstanceDynamic postProcessMID2 in GhostPoseableData.PostProcessMIDs)
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
				FLinearColor linearColorValue = postProcessMatInfo.LinearColorCurve.GetLinearColorValue(GhostPoseableData.UpdateTimer);
				foreach (UMaterialInstanceDynamic postProcessMID3 in GhostPoseableData.PostProcessMIDs)
				{
					postProcessMID3.SetVectorParameterValue(postProcessMatInfo.ParameterName, linearColorValue);
				}
			}
		}
		if (GhostPoseableData.ScaleCurve != null)
		{
			float floatValue = GhostPoseableData.ScaleCurve.GetFloatValue(GhostPoseableData.UpdateTimer);
			owner.SetActorScale3D(GhostPoseableData.OriActorScale * floatValue);
		}
		if (!(GhostPoseableData.UpdateTimer > GhostPoseableData.TotalUpdateTimeInSecond))
		{
			return;
		}
		GhostPoseableData.IsFinish = true;
		UCameraComponent uCameraComponent = UGameplayStatics.GetPlayerCharacter(owner, 0)?.GetComponentByClass<UCameraComponent>();
		if (uCameraComponent != null)
		{
			foreach (UMaterialInstanceDynamic postProcessMID4 in GhostPoseableData.PostProcessMIDs)
			{
				uCameraComponent.RemoveBlendable(postProcessMID4);
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
		BGUGhostActorBase bGUGhostActorBase = owner as BGUGhostActorBase;
		if (bGUGhostActorBase == null || bGUGhostActorBase.IsPendingKill)
		{
			return;
		}
		if (PoseableChr == null || PoseableChr.Mesh == null)
		{
			BGU_UnrealWorldUtil.DestroyActor(owner);
			return;
		}
		if (GhostActorSetting == null)
		{
			BGU_UnrealWorldUtil.DestroyActor(owner);
			return;
		}
		owner.SetActorScale3D(GhostPoseableData.OriActorScale * GhostActorSetting.Scale);
		USkeletalMesh newMesh = PoseableChr.Mesh.SkeletalMesh;
		IBUC_CharacterModularData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_CharacterModularData, BUC_CharacterModularData>(PoseableChr);
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.EquipMeshesIndexByAttachSocket.TryGetValue("", out var value))
		{
			newMesh = value;
		}
		USkeletalMeshComponent inComponentToCopy = PoseableChr.Mesh;
		if (GhostActorSetting.JustCopyWeapon)
		{
			BGUWeaponBase obj = BGUFunctionLibraryCS.BGUGetWeaponByIndex(PoseableChr, GhostActorSetting.WeaponIndex) as BGUWeaponBase;
			if (obj == null)
			{
				BGU_UnrealWorldUtil.DestroyActor(owner);
			}
			newMesh = obj.SkeletalMeshComp.SkeletalMesh;
			inComponentToCopy = obj.SkeletalMeshComp;
		}
		bGUGhostActorBase.CopyMesh(newMesh);
		bGUGhostActorBase.RefreshMeshComponentList();
		for (int i = 0; i < GhostActorSetting.MatInstances.Count; i++)
		{
			UMaterialInterface uMaterialInterface = GhostActorSetting.MatInstances[i];
			if (uMaterialInterface != null)
			{
				bGUGhostActorBase.PoseableMeshComp.SetMaterial(i, uMaterialInterface);
			}
		}
		bGUGhostActorBase.CopyPose(inComponentToCopy);
		float num = 0f;
		if (GhostActorSetting.ScaleUseCurve && GhostActorSetting.ScaleCurve != null)
		{
			GhostActorSetting.ScaleCurve.GetTimeRange(out var _, out var MaxTime);
			GhostPoseableData.ScaleCurve = GhostActorSetting.ScaleCurve;
			num = MaxTime;
		}
		else
		{
			owner.SetActorScale3D(GhostPoseableData.OriActorScale * GhostActorSetting.Scale);
		}
		foreach (FMatParamInfo matParam in GhostActorSetting.MatParams)
		{
			FMatParamInfo MPI = matParam;
			GhostPoseableData.MatInfoList.Add(new MatParamInfoForData(in MPI));
			if (MPI.FloatCurve != null)
			{
				MPI.FloatCurve.GetTimeRange(out var _, out var MaxTime2);
				if (MaxTime2 > num)
				{
					num = MaxTime2;
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
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(owner, 0);
		UCameraComponent uCameraComponent = playerCharacter?.GetComponentByClass<UCameraComponent>();
		if (uCameraComponent != null && GhostActorSetting.PostProcessMatInstances.Count > 0)
		{
			foreach (UMaterialInterface postProcessMatInstance in GhostActorSetting.PostProcessMatInstances)
			{
				UMaterialInstanceDynamic uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(owner, postProcessMatInstance, FName.None, EMIDCreationFlags.None);
				if (!uMaterialInstanceDynamic.IsNullOrDestroyed())
				{
					uCameraComponent.AddOrUpdateBlendable(uMaterialInstanceDynamic);
					GhostPoseableData.PostProcessMIDs.Add(uMaterialInstanceDynamic);
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
					if (MaxTime5 > num)
					{
						num = MaxTime5;
					}
					GhostPoseableData.PostProcessMatInfoList.Add(postProcessMatParam);
				}
				break;
			case EGSMatParamType.VectorCurve:
				if (postProcessMatParam.VectorCurve != null)
				{
					postProcessMatParam.VectorCurve.GetTimeRange(out var _, out var MaxTime4);
					if (MaxTime4 > num)
					{
						num = MaxTime4;
					}
					GhostPoseableData.PostProcessMatInfoList.Add(postProcessMatParam);
				}
				break;
			case EGSMatParamType.LinearColorValue:
				if (postProcessMatParam.LinearColorCurve != null)
				{
					postProcessMatParam.LinearColorCurve.GetTimeRange(out var _, out var MaxTime3);
					if (MaxTime3 > num)
					{
						num = MaxTime3;
					}
					GhostPoseableData.PostProcessMatInfoList.Add(postProcessMatParam);
				}
				break;
			case EGSMatParamType.Float:
				foreach (UMaterialInstanceDynamic postProcessMID in GhostPoseableData.PostProcessMIDs)
				{
					postProcessMID.SetScalarParameterValue(postProcessMatParam.ParameterName, postProcessMatParam.FloatValue);
				}
				break;
			case EGSMatParamType.Vector:
				foreach (UMaterialInstanceDynamic postProcessMID2 in GhostPoseableData.PostProcessMIDs)
				{
					FVector inVec = postProcessMatParam.VectorValue;
					inVec.Normalize();
					if (postProcessMatParam.ParameterName == B1GlobalFNames.Direction && playerCharacter != null)
					{
						inVec = playerCharacter.GetVelocity();
						inVec.Normalize();
					}
					postProcessMID2.SetVectorParameterValue(postProcessMatParam.ParameterName, inVec.Conv_VectorToLinearColor());
				}
				break;
			case EGSMatParamType.LinearColor:
				foreach (UMaterialInstanceDynamic postProcessMID3 in GhostPoseableData.PostProcessMIDs)
				{
					postProcessMID3.SetVectorParameterValue(postProcessMatParam.ParameterName, postProcessMatParam.LinearColorValue);
				}
				break;
			}
		}
		GhostPoseableData.UpdateTimer = 0f;
		GhostPoseableData.TotalUpdateTimeInSecond = ((100f < num) ? 100f : num);
		UpdateForGhost(0f);
		OnSetCustomPrimetiveData(EffectInstReq);
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
}
