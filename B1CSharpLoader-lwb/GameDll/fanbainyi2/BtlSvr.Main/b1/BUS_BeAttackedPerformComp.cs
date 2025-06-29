using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_BeAttackedPerformComp : UActorCompBaseCS
{
	private static class ScarMatrixUtil
	{
		public static FMatrix TextureMatrix = new FMatrix(new FPlane(new FVector(0.5, 0.0, 0.0), 0.0), new FPlane(new FVector(0.0, -0.5, 0.0), 0.0), new FPlane(new FVector(0.0, 0.0, 0.5), 0.0), new FPlane(new FVector(0.5, 0.5, 0.5), 1.0));

		public static FMatrix BuildViewMatrix(float DecalDepth, FVector HitPosition, FVector HitNormal, FVector DecalTangent)
		{
			FVector normal = HitPosition + HitNormal * DecalDepth * 0.5;
			FVector safeNormal = FVector.CrossProduct(DecalTangent, HitNormal * -1.0).GetSafeNormal();
			FVector safeNormal2 = FVector.CrossProduct(HitNormal * -1.0, safeNormal).GetSafeNormal();
			FVector normal2 = safeNormal * 1.0;
			FVector normal3 = safeNormal2;
			return new FMatrix(new FPlane(normal3, 0.0), new FPlane(normal2, 0.0), new FPlane(HitNormal, 0.0), new FPlane(normal, 1.0)).Inverse();
		}

		public static FMatrix BuildProjectMatrix(float DecalWidth, float DecalHeight, float DecalDepth)
		{
			return new FMatrix(new FPlane(new FVector(2f / DecalWidth, 0.0, 0.0), 0.0), new FPlane(new FVector(0.0, 2f / DecalHeight, 0.0), 0.0), new FPlane(new FVector(0.0, 0.0, -1f / DecalDepth), 0.0), new FPlane(FVector.ZeroVector, 1.0));
		}
	}

	private b1.BUC_BoneData BoneData;

	private BUC_ScarData ScarData;

	private BUC_BeAttackPerformData BeAttackPerformData;

	private IBUC_BeAttackData BeAttackData;

	private IBUC_RenderTargetMgrData RenderTargetMgrData;

	private IBUC_AbnormalStateHandlers AbnormalStateHandlers;

	private IBUC_PartMgrData PartMgrData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_GuidData GuidData;

	private int LastTTTBHitDataCount;

	private int LastBeAttackHitDataCount;

	public override void OnAttach()
	{
		BoneData = RequireWritableData<b1.BUC_BoneData>();
		ScarData = RequireWritableData<BUC_ScarData>();
		BeAttackPerformData = RequireWritableData<BUC_BeAttackPerformData>();
		BeAttackData = RequireReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>();
		RenderTargetMgrData = RequireReadOnlyData<IBUC_RenderTargetMgrData, BUC_RenderTargetMgrData>();
		AbnormalStateHandlers = RequireReadOnlyData<IBUC_AbnormalStateHandlers, BUC_AbnormalStateHandlers>();
		PartMgrData = RequireReadOnlyData<IBUC_PartMgrData, BUC_PartMgrData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		base.BUSEventCollection.Evt_BeAttackedVisualEffect += new Del_BeAttackedVisualEffect(OnBeAttackedVisualEffect);
		base.BUSEventCollection.Evt_PlayBeAttackedPhysicalAnim += new Del_PlayBeAttackedPhysicalAnim(PlayBeAttackedPhysicalAnim);
		base.BUSEventCollection.Evt_PlayBeAttackedAdditiveAnim += new Del_Void_Vector(PlayBeAttackedAdditiveAnim);
		base.BUSEventCollection.Evt_PlayBeAttackedAdditiveAnim_Jump += new Del_Void_Vector(PlayBeAttackedAdditiveAnim_Jump);
		base.BUSEventCollection.Evt_TriggerAttachBehitComp += new Del_TriggerAttachBehitComp(OnTriggerAttachBehitComp);
		base.BUSEventCollection.Evt_TriggerTTTBEffect += new Del_TriggerTTTBEffect(OnTriggerTTTBEffect);
		base.BUSEventCollection.Evt_TriggerScarFX += new Del_TriggerScarFX(OnTriggerScarFX);
		base.BUSEventCollection.Evt_TriggerClearScar += new Del_TriggerClearScar(OnTriggerClearScar);
	}

	public override void PreBeginPlay()
	{
		ScarData?.Init();
		BeAttackPerformData?.Init();
	}

	public override void OnBeginPlay()
	{
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(OwnerAsCharacterCS.GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc != null)
		{
			BeAttackPerformData.bBeHitFXNeedAttach = unitBattleInfoExtendDesc.BeHitFXAttach == EGSYesNo.Yes;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateValidCount(DeltaTime);
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		ScarData?.Init();
		BeAttackPerformData?.Init();
	}

	private void OnBeAttackedVisualEffect(AActor Attacker, ESkillDamageType SkillDamageType, EHitPerformFXEventType HitPerformFXEventType, FEffectInstReq HitReq, int SkillEffectID, int HitPartID, bool bCostDmg)
	{
		AActor owner = GetOwner();
		BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(owner);
		if (owner == null)
		{
			return;
		}
		ACharacter aCharacter = owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Attacker as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(bGUCharacterCS.GetResID());
		if (unitCommDesc == null || unitCommDesc.NoEnemyBeHitFX == EGSYesNo.Yes)
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(SkillEffectID, aCharacter);
		if (skillEffectDesc == null)
		{
			return;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked_VFX, "<character>" + Owner?.GetName() + "</><action>=============================受击特效开始=============================</>");
		}
		int actorResID = BGU_DataUtil.GetActorResID(owner);
		EHitItemFXType partItemFXType = BGUFuncLibBeAttackedAndUnitDeathDispCS.GetPartItemFXType(HitPartID, actorResID, BeAttackData.GetCurrentBeAttackedInfoID(), in PartMgrData);
		if (!bCostDmg && (int)HitPerformFXEventType <= 3)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				string text = "\n————————————————受击特效————————————————\n" + $"HitPerformType：{HitPerformFXEventType}  SkillDamageType：{SkillDamageType}  受击者ResID：{actorResID}  特效挡位：{HitReq.FXWeight_HitChr}  特效肉质：{partItemFXType}\n" + "没有造成有效伤害（伤害为0）且HitPerformType挡位低于3，因此不播受击特效\n————————————————受击特效————————————————";
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked_VFX, "<character>" + Owner?.GetName() + "</><action>" + text + "</>");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked_VFX, "<character>" + Owner?.GetName() + "</><action>=============================受击特效结束=============================</>");
			}
			return;
		}
		FUStBeAttackedFXMapDesc beAttackedFXMapDesc = BGW_GameDB.GetBeAttackedFXMapDesc(Owner is BGUPlayerCharacterCS, SkillDamageType, HitPerformFXEventType, partItemFXType, actorResID, HitReq.FXWeight_HitChr);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text2 = "\n————————————————受击特效————————————————\n" + $"HitPerformType：{HitPerformFXEventType}  SkillDamageType：{SkillDamageType}  受击者ResID：{actorResID}  特效挡位:{HitReq.FXWeight_HitChr}  特效肉质：{partItemFXType}\n";
			text2 = ((beAttackedFXMapDesc == null) ? (text2 + "未在BeAttackedFX表中查询到对应视效\n") : (text2 + $"BeAttackedFX表ID: {beAttackedFXMapDesc.ID}\n"));
			text2 += "————————————————受击特效————————————————";
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked_VFX, "<character>" + Owner?.GetName() + "</><action>" + text2 + "</>");
		}
		if (beAttackedFXMapDesc == null)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked_VFX, "<character>" + Owner?.GetName() + "</><action>=============================受击特效结束=============================</>");
			}
			return;
		}
		FTransform fTransform = default(FTransform);
		if (skillEffectDesc.FXTransUseConfig == EGSYesNo.Yes)
		{
			FRotator rotation = MathLib.Conv_VectorToRotator(new FVector(skillEffectDesc.PlayFXLocalDirY, skillEffectDesc.PlayFXLocalDirZ, skillEffectDesc.PlayFXLocalDirX));
			FRotator rotation2 = BGUFuncLibActorTransformCS.BGUGetActorTransform(aCharacter).TransformRotation(rotation);
			FVector socketLocation = aCharacter.Mesh.GetSocketLocation(new FName(skillEffectDesc.PlayFXSocketName));
			fTransform = new FTransform(rotation2, socketLocation);
		}
		else
		{
			FVector hitLocation = HitReq.HitLocation;
			FRotator hitPointNormalDir = HitReq.HitPointNormalDir;
			fTransform = BGUFunctionLibraryCS.GetFrontLocationByHitPoint(Attacker, hitLocation, hitPointNormalDir, ETraceTypeQuery.TraceTypeQuery4, GSGameplayCVar.CVar_EnableAtkFXLog.GetValueInGameThread() != 0);
		}
		string text3 = beAttackedFXMapDesc.BeHitFXPath;
		if (BeAttackPerformData.bBeHitFXNeedAttach && !string.IsNullOrEmpty(beAttackedFXMapDesc.BeHitFXPathAttachVer))
		{
			text3 = beAttackedFXMapDesc.BeHitFXPathAttachVer;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked_VFX, "<character>" + Owner?.GetName() + "</><action>受击特效资源路径是：" + text3 + "</>");
		}
		if (beAttackedFXMapDesc.IsUseDispConfig == EGSYesNo.Yes)
		{
			base.BUSEventCollection?.Evt_RequestSpawnFXByDispConfig.Invoke(text3, out var _, null, NeedSetSpawnTransform: true, fTransform);
		}
		else
		{
			UObject uObject = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<UObject>(text3, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low);
			UParticleSystem uParticleSystem = null;
			UNiagaraSystem uNiagaraSystem = null;
			if (uObject != null)
			{
				uParticleSystem = uObject as UParticleSystem;
				if (uParticleSystem == null)
				{
					uNiagaraSystem = uObject as UNiagaraSystem;
				}
			}
			if (uParticleSystem != null || uNiagaraSystem != null)
			{
				if (uParticleSystem != null)
				{
					UBGUFunctionLibraryForCS.BGUSetParticleSysSortPriority(UGameplayStaticsEx.SpawnEmitterAtLocation(owner, uParticleSystem, ref fTransform), -1);
				}
				else
				{
					UNiagaraFunctionLibrary.SpawnSystemAtLocation(owner, uNiagaraSystem, fTransform.GetLocation(), fTransform.Rotator(), fTransform.GetScale3D(), bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.AutoRelease, bPreCullCheck: false);
				}
			}
			else if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked_VFX, "<character>" + Owner?.GetName() + "</><action>未配置该受击特效,请检查</>");
			}
		}
		if (AbnormalStateHandlers != null)
		{
			AbnormalStateHandlers.PlayHitExtFX(fTransform);
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked_VFX, "<character>" + Owner?.GetName() + "</><action>=============================受击特效结束=============================</>");
		}
	}

	private void PlayBeAttackedPhysicalAnim(float HitWeight, FVector HitDirection, FVector HitLocation)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		ACharacter aCharacter = owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		int actorResID = BGU_DataUtil.GetActorResID(owner);
		UHitPhysicalAnimComp componentByClass = aCharacter.GetComponentByClass<UHitPhysicalAnimComp>();
		if (componentByClass != null)
		{
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(actorResID);
			if (BGW_LogUtil.LogIfNull(unitCommDesc, "Find UnitCommDesc failed! ResID: {0}", actorResID))
			{
				return;
			}
			FUStPhysicalHitBoneRuleDesc physicalHitBoneRuleDesc = BGW_GameDB.GetPhysicalHitBoneRuleDesc(unitCommDesc.PhysicalHitBoneRuleID);
			float num = 20f;
			if (BGW_LogUtil.LogIfNull(physicalHitBoneRuleDesc, "Find PhysicalHitBoneRuleDesc failed! ResID: {0}", unitCommDesc.PhysicalHitBoneRuleID))
			{
				return;
			}
			List<FName> physicalHitBoneList = GetPhysicalHitBoneList(HitLocation, physicalHitBoneRuleDesc.BoneName);
			componentByClass.BeHit(physicalHitBoneList, -HitDirection, HitWeight * num);
			string text = "";
			{
				foreach (FName item in physicalHitBoneList)
				{
					text = text + item.ToString() + ", ";
				}
				return;
			}
		}
		Msg_ValidateError Msg = default(Msg_ValidateError);
		Msg.Type = 2;
		Msg.ResID = actorResID;
		BGWGameInstanceCS.GetObject<CSApiBattle>(GetOwner()).EnqueueMessage(ref Msg);
	}

	private void PlayBeAttackedAdditiveAnim(FVector HitDirection)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		ACharacter aCharacter = owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(BGU_DataUtil.GetActorResID(aCharacter));
		if (unitCommDesc != null && (unitCommDesc.CanTriggerAdditiveBeHitAnim == EGSYesNo.Yes || BGUFunctionLibraryCS.BGUHasUnitSimpleState(owner, EBGUSimpleState.CanTriggerBeHitAdditiveAnim)))
		{
			UAnimMontage beHitAdditiveMontagePath = GetBeHitAdditiveMontagePath(HitDirection);
			if (beHitAdditiveMontagePath != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(aCharacter, beHitAdditiveMontagePath, FName.None);
			}
		}
	}

	private void PlayBeAttackedAdditiveAnim_Jump(FVector HitDirection)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		ACharacter aCharacter = owner as ACharacter;
		if (!(aCharacter == null))
		{
			UAnimMontage beHitAdditiveMontagePath_DurJump = GetBeHitAdditiveMontagePath_DurJump(HitDirection);
			if (beHitAdditiveMontagePath_DurJump != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(aCharacter, beHitAdditiveMontagePath_DurJump, FName.None);
			}
		}
	}

	private void OnTriggerAttachBehitComp(int ObjectID, float Duration, float Strength, FTransform HitTransform, FVector HitDiretionRealDir, FName AttachBoneName)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (!(aCharacter == null))
		{
			float timeSeconds = aCharacter.World.GetTimeSeconds();
			FVector location = HitTransform.GetLocation() - BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter);
			HitTransform.SetLocation(location);
			int num = BeAttackPerformData.SetRTParams(RenderTargetType.BeAttacked, HitTransform, Strength, timeSeconds, Duration, HitDiretionRealDir);
			if (num >= 0)
			{
				RTParams rTParams = BeAttackPerformData.RTParamsList[RenderTargetType.BeAttacked][num];
				int count = BeAttackPerformData.RTParamsList[RenderTargetType.BeAttacked].Count;
				List<FLinearColor> colorValues = new List<FLinearColor>
				{
					rTParams.HitTransform.GetLocation().Conv_VectorToLinearColor(),
					rTParams.HitTransform.GetRotation().Vector().GetSafeNormal()
						.Conv_VectorToLinearColor(),
					rTParams.HitDir.Conv_VectorToLinearColor()
				};
				List<float> floatValues = new List<float> { rTParams.Strength, rTParams.BeginAnimTime };
				base.BUSEventCollection?.Evt_SetMatsParam.Invoke(B1GlobalFNames.HitDataCount, new MaterialParamInfo(count, count, 0f, 0f), ForceUpdateDefaultValue: true);
				base.BUSEventCollection?.Evt_PushRenderTargetValuesToGroup.Invoke(RenderTargetType.BeAttacked, num, colorValues, floatValues);
				base.BUSEventCollection?.Evt_SetMatsParam.Invoke(RenderTargetMgrData.GetParamName(RenderTargetType.BeAttacked), new MaterialParamInfo(RenderTargetType.BeAttacked), ForceUpdateDefaultValue: true);
			}
		}
	}

	private void OnTriggerTTTBEffect(float Duration, float Strength, FName HitBoneName, FVector HitLocation, FVector HitPointNormalDir, FVector HitDiretionRealDir)
	{
		if (OwnerAsCharacterCS == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = OwnerAsCharacterCS.Mesh;
		if (!(mesh == null))
		{
			FVector BoneLocation;
			FName SocketName = mesh.FindClosestBone_K2(HitLocation, out BoneLocation);
			FTransform t = BGUFuncLibComponentCS.BGUGetSocketTransform(mesh, ref SocketName);
			FTransform refPoseTransform = UGSE_SkeletalMeshFuncLib.GetRefPoseTransform(mesh, mesh.GetBoneIndex(SocketName), bIsLocal: false);
			FVector translation = MathLib.TransformLocation(refPoseTransform, MathLib.InverseTransformLocation(t, BoneLocation));
			FRotator rotation = MathLib.TransformRotation(refPoseTransform, MathLib.InverseTransformRotation(t, HitPointNormalDir.Conv_VectorToRotator()));
			FTransform hitTransform = new FTransform(rotation, translation);
			float timeSeconds = OwnerAsCharacterCS.World.GetTimeSeconds();
			int num = BeAttackPerformData.SetRTParams(RenderTargetType.TTTB, hitTransform, Strength, timeSeconds, Duration, HitDiretionRealDir);
			if (num >= 0)
			{
				int count = BeAttackPerformData.RTParamsList[RenderTargetType.TTTB].Count;
				RTParams rTParams = BeAttackPerformData.RTParamsList[RenderTargetType.TTTB][num];
				List<FLinearColor> colorValues = new List<FLinearColor>
				{
					rTParams.HitTransform.GetLocation().Conv_VectorToLinearColor(),
					FLinearColor.Black,
					rTParams.HitDir.Conv_VectorToLinearColor()
				};
				List<float> floatValues = new List<float> { rTParams.Strength, rTParams.BeginAnimTime };
				base.BUSEventCollection?.Evt_SetMatsLayerParam.Invoke(0, B1GlobalFNames.TTTB, B1GlobalFNames.HitDataCount, new MaterialParamInfo(count, count, 0f, 0f), ForceUpdateDefaultValue: true);
				base.BUSEventCollection?.Evt_PushRenderTargetValuesToGroup.Invoke(RenderTargetType.TTTB, num, colorValues, floatValues);
				base.BUSEventCollection?.Evt_SetMatsLayerParam.Invoke(0, B1GlobalFNames.TTTB, B1GlobalFNames.Tongtoutiebi_DataTexture, new MaterialParamInfo(RenderTargetType.TTTB), ForceUpdateDefaultValue: true);
			}
		}
	}

	private void OnTriggerScarFX(int ScarInfoDescID, FName HitBoneName, FVector HitLocation, FVector HitPointNormalDir, FVector HitTangent)
	{
		FUStScarInfoDesc scarInfoDesc = BGW_GameDB.GetScarInfoDesc(ScarInfoDescID);
		if (scarInfoDesc == null || !ScarData.ScarDecalBrushInfoDict.TryGetValue(scarInfoDesc.ScarDecalTriggerType, out var value))
		{
			return;
		}
		USkeletalMeshComponent mesh = OwnerAsCharacterCS.Mesh;
		if (!(mesh != null))
		{
			return;
		}
		FTransform t = BGUFuncLibComponentCS.BGUGetSocketTransform(mesh, ref HitBoneName);
		FTransform refPoseTransform = UGSE_SkeletalMeshFuncLib.GetRefPoseTransform(mesh, mesh.GetBoneIndex(HitBoneName), bIsLocal: false);
		FVector hitPosition = MathLib.TransformLocation(refPoseTransform, MathLib.InverseTransformLocation(t, HitLocation));
		FRotator inRot = MathLib.TransformRotation(refPoseTransform, MathLib.InverseTransformRotation(t, HitPointNormalDir.Conv_VectorToRotator()));
		FRotator inRot2 = MathLib.TransformRotation(refPoseTransform, MathLib.InverseTransformRotation(t, HitTangent.Conv_VectorToRotator()));
		FMatrix fMatrix = ScarMatrixUtil.BuildViewMatrix(0.1f, hitPosition, inRot.Conv_RotatorToVector(), inRot2.Conv_RotatorToVector());
		int decalWidth = scarInfoDesc.DecalWidth;
		int decalHeight = scarInfoDesc.DecalHeight;
		float decalDepth = (float)scarInfoDesc.DecalDepth / 10f;
		int scarTextureDecalID = scarInfoDesc.ScarTextureDecalID;
		int num = 0;
		float timeSeconds = Owner.World.GetTimeSeconds();
		float fadeTime = scarInfoDesc.FadeTime;
		float emissiveTime = scarInfoDesc.EmissiveTime;
		FMatrix fMatrix2 = ScarMatrixUtil.BuildProjectMatrix(decalWidth, decalHeight, decalDepth);
		FMatrix fMatrix3 = fMatrix * fMatrix2 * ScarMatrixUtil.TextureMatrix;
		if (ScarData.TempRT == null)
		{
			ScarData.TempRT = URenderingLibrary.CreateRenderTarget2D(Owner, 16, 16, ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor.Black, bAutoGenerateMipMaps: false);
			ScarData.TempRT.AutoGenerateMips = false;
			ScarData.TempRT.LODGroup = ETextureGroup.TEXTUREGROUP_Pixels2D;
		}
		if (!(ScarData.TempRT != null))
		{
			return;
		}
		FLinearColor fLinearColor = new FLinearColor(fMatrix3.M11, fMatrix3.M12, fMatrix3.M13);
		FLinearColor fLinearColor2 = new FLinearColor(fMatrix3.M21, fMatrix3.M22, fMatrix3.M23);
		FLinearColor fLinearColor3 = new FLinearColor(fMatrix3.M31, fMatrix3.M32, fMatrix3.M33);
		FLinearColor fLinearColor4 = new FLinearColor(fMatrix3.M41, fMatrix3.M42, fMatrix3.M43);
		foreach (UActorComponent item in OwnerAsCharacterCS.GetComponentsByClass(UClass.GetClass<UMeshComponent>()))
		{
			UMeshComponent uMeshComponent = item as UMeshComponent;
			if (!(uMeshComponent != null))
			{
				continue;
			}
			List<UMaterialInterface> materials = uMeshComponent.GetMaterials();
			for (int i = 0; i < materials.Count; i++)
			{
				UMaterialInstanceDynamic uMaterialInstanceDynamic = materials[i] as UMaterialInstanceDynamic;
				if (uMaterialInstanceDynamic == null)
				{
					uMaterialInstanceDynamic = uMeshComponent.CreateDynamicMaterialInstance(i, null, FName.None);
				}
				if (uMaterialInstanceDynamic != null)
				{
					if (GSGameplayCVar.CVar_ScarDebug.GetValueInGameThread() == 1)
					{
						uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.DecalX, fLinearColor);
						uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.DecalY, fLinearColor2);
						uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.DecalZ, fLinearColor3);
						uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.DecalW, fLinearColor4);
						uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.pix4, new FLinearColor(scarTextureDecalID, num, timeSeconds, fadeTime));
						uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.pix5, new FLinearColor(0f, 0f, emissiveTime));
					}
					uMaterialInstanceDynamic.SetScalarParameterValue(B1GlobalFNames.ValidDecalAmount, 1f);
					uMaterialInstanceDynamic.SetTextureParameterValue(B1GlobalFNames.HitInfoTex, ScarData.TempRT);
					uMeshComponent.SetMaterial(i, uMaterialInstanceDynamic);
				}
			}
		}
		if (GSGameplayCVar.CVar_ScarDebug.GetValueInGameThread() == 1)
		{
			USystemLibrary.DrawDebugArrow(Owner, HitLocation, HitLocation + HitTangent * 1000.0, 30f, FLinearColor.Black, 10f, 10f);
		}
		value.BeginDraw();
		URenderingLibrary.BeginDrawCanvasToRenderTarget(Owner, ScarData.TempRT, out var Canvas, out var _, out var Context);
		Canvas.DrawTexture(null, value.DrawPosition, new FVector2D(1.0, 1.0), new FVector2D(0.0, 0.0), new FVector2D(1.0, 1.0), fLinearColor, EBlendMode.BLEND_Masked, 0f, new FVector2D(0.5, 0.5));
		value.NextCol();
		Canvas.DrawTexture(null, value.DrawPosition, new FVector2D(1.0, 1.0), new FVector2D(0.0, 0.0), new FVector2D(1.0, 1.0), fLinearColor2, EBlendMode.BLEND_Masked, 0f, new FVector2D(0.5, 0.5));
		value.NextCol();
		Canvas.DrawTexture(null, value.DrawPosition, new FVector2D(1.0, 1.0), new FVector2D(0.0, 0.0), new FVector2D(1.0, 1.0), fLinearColor3, EBlendMode.BLEND_Masked, 0f, new FVector2D(0.5, 0.5));
		value.NextCol();
		Canvas.DrawTexture(null, value.DrawPosition, new FVector2D(1.0, 1.0), new FVector2D(0.0, 0.0), new FVector2D(1.0, 1.0), fLinearColor4, EBlendMode.BLEND_Masked, 0f, new FVector2D(0.5, 0.5));
		value.NextCol();
		Canvas.DrawTexture(null, value.DrawPosition, new FVector2D(1.0, 1.0), new FVector2D(0.0, 0.0), new FVector2D(1.0, 1.0), new FLinearColor(scarTextureDecalID, num, timeSeconds, fadeTime), EBlendMode.BLEND_Masked, 0f, new FVector2D(0.5, 0.5));
		value.NextCol();
		Canvas.DrawTexture(null, value.DrawPosition, new FVector2D(1.0, 1.0), new FVector2D(0.0, 0.0), new FVector2D(1.0, 1.0), new FLinearColor(0f, 0f, emissiveTime), EBlendMode.BLEND_Masked, 0f, new FVector2D(0.5, 0.5));
		value.NextCol();
		URenderingLibrary.EndDrawCanvasToRenderTarget(Owner, Context);
		value.NextRow();
		ScarData.ScarDecalBrushInfoDict[scarInfoDesc.ScarDecalTriggerType] = value;
	}

	private void OnTriggerClearScar(EScarDecalTriggerType ScarDecalTriggerType)
	{
		if (!(ScarData.TempRT != null) || !ScarData.ScarDecalBrushInfoDict.TryGetValue(ScarDecalTriggerType, out var value))
		{
			return;
		}
		foreach (UActorComponent item in OwnerAsCharacterCS.GetComponentsByClass(UClass.GetClass<UMeshComponent>()))
		{
			UMeshComponent uMeshComponent = item as UMeshComponent;
			if (!(uMeshComponent != null))
			{
				continue;
			}
			List<UMaterialInterface> materials = uMeshComponent.GetMaterials();
			for (int i = 0; i < materials.Count; i++)
			{
				UMaterialInstanceDynamic uMaterialInstanceDynamic = materials[i] as UMaterialInstanceDynamic;
				if (uMaterialInstanceDynamic != null)
				{
					uMaterialInstanceDynamic.SetScalarParameterValue(B1GlobalFNames.ValidDecalAmount, 0f);
					uMeshComponent.SetMaterial(i, uMaterialInstanceDynamic);
				}
			}
		}
		URenderingLibrary.BeginDrawCanvasToRenderTarget(Owner, ScarData.TempRT, out var Canvas, out var _, out var Context);
		FVector2D screenPosition = default(FVector2D);
		for (int j = value.BeginY; j < value.EndY; j++)
		{
			screenPosition.Y = j;
			for (int k = 0; k <= value.XLength; k++)
			{
				screenPosition.X = k;
				Canvas.DrawTexture(null, screenPosition, new FVector2D(1.0, 1.0), new FVector2D(0.0, 0.0), new FVector2D(1.0, 1.0), FLinearColor.Black, EBlendMode.BLEND_Masked, 0f, new FVector2D(0.5, 0.5));
			}
		}
		URenderingLibrary.EndDrawCanvasToRenderTarget(Owner, Context);
		value.Reset();
		ScarData.ScarDecalBrushInfoDict[ScarDecalTriggerType] = value;
	}

	private void UpdateValidCount(float DeltaTime)
	{
		if (GetOwner() == null)
		{
			return;
		}
		int num = 0;
		if (BeAttackPerformData.RTParamsList[RenderTargetType.TTTB].Count > 0)
		{
			foreach (int item in BeAttackPerformData.RTParamsList[RenderTargetType.TTTB].Keys.ToList())
			{
				RTParams value = BeAttackPerformData.RTParamsList[RenderTargetType.TTTB][item];
				value.RemainingUpdateTime -= DeltaTime;
				if (value.RemainingUpdateTime >= 0f)
				{
					if (item >= num)
					{
						num = item + 1;
					}
					BeAttackPerformData.RTParamsList[RenderTargetType.TTTB][item] = value;
				}
				else
				{
					base.BUSEventCollection?.Evt_ClearRenderTargetValuesForGroup.Invoke(RenderTargetType.TTTB, item);
					BeAttackPerformData.RTParamsList[RenderTargetType.TTTB].Remove(item);
				}
			}
		}
		if (LastTTTBHitDataCount != num)
		{
			LastTTTBHitDataCount = num;
			base.BUSEventCollection?.Evt_SetMatsLayerParam.Invoke(0, B1GlobalFNames.TTTB, B1GlobalFNames.HitDataCount, new MaterialParamInfo(LastTTTBHitDataCount, LastTTTBHitDataCount, 0f, 0f), ForceUpdateDefaultValue: true);
		}
		int num2 = 0;
		if (BeAttackPerformData.RTParamsList[RenderTargetType.BeAttacked].Count > 0)
		{
			foreach (int item2 in BeAttackPerformData.RTParamsList[RenderTargetType.BeAttacked].Keys.ToList())
			{
				RTParams value2 = BeAttackPerformData.RTParamsList[RenderTargetType.BeAttacked][item2];
				value2.RemainingUpdateTime -= DeltaTime;
				if (value2.RemainingUpdateTime >= 0f)
				{
					if (item2 >= num2)
					{
						num2 = item2 + 1;
					}
					BeAttackPerformData.RTParamsList[RenderTargetType.BeAttacked][item2] = value2;
				}
				else
				{
					base.BUSEventCollection?.Evt_ClearRenderTargetValuesForGroup.Invoke(RenderTargetType.BeAttacked, item2);
					BeAttackPerformData.RTParamsList[RenderTargetType.BeAttacked].Remove(item2);
				}
			}
		}
		if (LastBeAttackHitDataCount != num2)
		{
			LastBeAttackHitDataCount = num2;
			base.BUSEventCollection?.Evt_SetMatsParam.Invoke(B1GlobalFNames.HitDataCount, new MaterialParamInfo(LastBeAttackHitDataCount, LastBeAttackHitDataCount, 0f, 0f), ForceUpdateDefaultValue: true);
		}
	}

	private UAnimMontage GetBeHitAdditiveMontagePath(FVector HitDirection)
	{
		UAnimMontage result = null;
		BGWDataAsset_UnitBeAttackedConfig uBAConfig = BGW_PreloadAssetMgr.Get(Owner).GetUBAConfig(GetActorResID(), GetFinalBattleInfoExtendID(), GuidData.GetFinalGuid(), BeAttackData.UnitBeAttackedConfigPath);
		if (uBAConfig != null)
		{
			result = ((HitDirection.X == 1f) ? uBAConfig.ForwardBeAttackedAdditiveAnim : ((HitDirection.Y == 1f) ? uBAConfig.LeftBeAttackedAdditiveAnim : ((HitDirection.Y != -1f) ? uBAConfig.BackwardBeAttackedAdditiveAnim : uBAConfig.RightBeAttackedAdditiveAnim)));
		}
		return result;
	}

	private UAnimMontage GetBeHitAdditiveMontagePath_DurJump(FVector HitDirection)
	{
		UAnimMontage result = null;
		BGWDataAsset_UnitBeAttackedConfig uBAConfig = BGW_PreloadAssetMgr.Get(Owner).GetUBAConfig(GetActorResID(), GetFinalBattleInfoExtendID(), GuidData.GetFinalGuid(), BeAttackData.UnitBeAttackedConfigPath);
		if (uBAConfig != null)
		{
			result = ((HitDirection.X == 1f) ? uBAConfig.ForwardBeAttackedAdditiveAnim_Jump : ((HitDirection.Y == 1f) ? uBAConfig.LeftBeAttackedAdditiveAnim_Jump : ((HitDirection.Y != -1f) ? uBAConfig.BackwardBeAttackedAdditiveAnim_Jump : uBAConfig.RightBeAttackedAdditiveAnim_Jump)));
		}
		return result;
	}

	private List<FName> GetPhysicalHitBoneList(FVector HitLocation, IList<string> WhiteList, int Depth = 1)
	{
		List<FName> list = new List<FName>();
		AActor owner = GetOwner();
		if (owner == null)
		{
			return list;
		}
		ACharacter aCharacter = owner as ACharacter;
		if (aCharacter == null)
		{
			return list;
		}
		if (!BoneData.HasInited())
		{
			BoneData.Initialize(aCharacter);
		}
		FName nearestBoneName = UBGUFunctionLibrary.GetNearestBoneName(aCharacter.Mesh, HitLocation, WhiteList.ToList());
		list.Add(nearestBoneName);
		FName fName = nearestBoneName;
		Queue<FName> queue = new Queue<FName>();
		queue.Enqueue(nearestBoneName);
		for (int i = 0; i < Depth; i++)
		{
			if (fName != FName.None)
			{
				fName = aCharacter.Mesh.GetParentBone(fName);
				if (fName != FName.None && WhiteList.Contains(fName.ToString()))
				{
					list.Add(fName);
				}
			}
			if (queue.Count <= 0)
			{
				continue;
			}
			int count = queue.Count;
			for (int j = 0; j < count; j++)
			{
				FName key = queue.Dequeue();
				if (!BoneData.ChildBoneDict.ContainsKey(key))
				{
					continue;
				}
				foreach (FName item in BoneData.ChildBoneDict[key])
				{
					queue.Enqueue(item);
					if (WhiteList.Contains(item.ToString()))
					{
						list.Add(item);
					}
				}
			}
		}
		return list;
	}
}
