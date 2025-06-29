using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using BtlB1;
using BtlShare;
using Diana.Common;
using GSDispLib;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;
using UnrealEngine.UMG;

namespace b1;

internal class BUS_AttackFeedbackPerformComp : UActorCompBaseCS
{
	private BUC_UnitHitVEffectData UnitHitVEffectData;

	private b1.BUC_WaterSplashData WaterSplashData;

	private BUS_DispLibEventCollection DispLibEventCollection;

	private IBUC_EquipData EquipData;

	private bool bOwnerCanTriggerMotion;

	private IBUC_SimpleStateData UnitSimpleStates;

	private b1.IBUC_AkMgrData AkMgrData;

	public override void OnAttach()
	{
		bOwnerCanTriggerMotion = UBGWFunctionLibraryCS.CanCharacterTriggerMotion(Owner);
		UnitHitVEffectData = RequireWritableData<BUC_UnitHitVEffectData>();
		WaterSplashData = RequireWritableData<b1.BUC_WaterSplashData>();
		EquipData = RequireReadOnlyData<IBUC_EquipData, BUC_EquipData>();
		UnitSimpleStates = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		AkMgrData = RequireReadOnlyData<b1.IBUC_AkMgrData, BUC_AKMgrData>();
		DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
		base.BUSEventCollection.Evt_OnHitGroundPerform += new Del_OnHitGroundPerform(OnHitGroundPerform);
		base.BUSEventCollection.Evt_OnHitWorldItemPerform += new Del_OnHitWorldItemPerform(OnHitWorldItemPerform);
		base.BUSEventCollection.Evt_AttackFeedbackPerform += new Del_AttackFeedbackPerform(OnAttackFeedbackPerform);
		base.BUSEventCollection.Evt_PlayAttackHitAudioByRule += new Del_PlayAttackHitAudioByRule(OnPlayAttackHitAudioByRule);
		base.BUSEventCollection.Evt_WaterSplashSweepBegin += new Del_WaterSplashSweepBegin(WaterSplashPlay_Start);
		base.BUSEventCollection.Evt_WaterSplashSweepEnd += new Del_Void_IntInt(WaterSplashPlay_End);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UnitHitVEffectData.SweepSceneItemGapDic.BeginItr();
		int oKey;
		float oVal;
		while (UnitHitVEffectData.SweepSceneItemGapDic.NextItr(out oKey, out oVal))
		{
			oVal -= DeltaTime;
			if (oVal < 0f)
			{
				UnitHitVEffectData.SweepSceneItemGapDic.Remove(oKey);
			}
			else
			{
				UnitHitVEffectData.SweepSceneItemGapDic.Set(oKey, oVal);
			}
		}
		AActor owner = GetOwner();
		if (!(owner == null))
		{
			UWorld world = owner.World;
			if (!(world == null))
			{
				float timeSeconds = world.GetTimeSeconds();
				UpdateForCameraShakeGap(timeSeconds);
				WaterSplashPlay_Tick(DeltaTime);
			}
		}
	}

	private void UpdateForCameraShakeGap(float CurrentTimeInSeconds)
	{
		if (UnitHitVEffectData.CheckCanPlayHitCameraShake(CurrentTimeInSeconds))
		{
			UnitHitVEffectData.ResetCameraShakeGap();
		}
	}

	private void OnHitWorldItemPerform(UObject World, int ObjectID, float SweepProtectGap, List<int> SkillEffectIDList, FVector PrePosition, FVector CurPosition, ref FEffectInstReq EffectInstReq)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(World) || SkillEffectIDList.Count < 1 || !UnitHitVEffectData.IsInSweepSceneItemGap(ObjectID))
		{
			return;
		}
		int skillEffectID = 0;
		ESkillDamageType eSkillDamageType = ESkillDamageType.NoneEffectAtk;
		foreach (int SkillEffectID in SkillEffectIDList)
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(SkillEffectID, GetOwner());
			if (skillEffectDesc != null && skillEffectDesc.EffectParamsInt.Count > 2 && skillEffectDesc.EffectType == EBuffAndSkillEffectType.SkillDamage)
			{
				skillEffectID = SkillEffectID;
				eSkillDamageType = (ESkillDamageType)skillEffectDesc.EffectParamsInt[2];
				break;
			}
		}
		if (eSkillDamageType == ESkillDamageType.NoneEffectAtk)
		{
			return;
		}
		int valueInGameThread = GSGameplayCVar.CVar_EnableAtkFXLog.GetValueInGameThread();
		FVector fVector = EffectInstReq.HitLocation - PrePosition;
		fVector.Normalize();
		FVector fVector2 = PrePosition - fVector * 50.0;
		FVector fVector3 = EffectInstReq.HitLocation + fVector * 50.0;
		if (!BGUFuncLibSelectTargetsCS.LineTraceForHitWorldItem(World, fVector2, fVector3, out var hitResultSimple))
		{
			return;
		}
		int unitResID = 0;
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			unitResID = bGUCharacterCS.GetResID();
		}
		ESceneItemSurfaceType surfaceType = (ESceneItemSurfaceType)hitResultSimple.SurfaceType;
		if (valueInGameThread != 0)
		{
		}
		FUStHitSceneItemPerformDesc hitSceneItemPerformDesc = BGW_GameDB.GetHitSceneItemPerformDesc(surfaceType, eSkillDamageType, unitResID, skillEffectID);
		if (hitSceneItemPerformDesc == null)
		{
			return;
		}
		FTransform spawnTransform = new FTransform(hitResultSimple.HitImpactNormal.Rotation(), hitResultSimple.HitLocation);
		if (!string.IsNullOrEmpty(hitSceneItemPerformDesc.HitWorldItemFXPath))
		{
			base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(hitSceneItemPerformDesc.HitWorldItemFXPath, out var _, null, NeedSetSpawnTransform: true, spawnTransform);
		}
		if (!string.IsNullOrEmpty(hitSceneItemPerformDesc.HitWorldItemDecalPath))
		{
			FVector location = hitResultSimple.HitLocation;
			FVector fVector4 = MathLib.ProjectPointontoPlane(fVector2, location, hitResultSimple.HitImpactNormal);
			FVector fVector5 = MathLib.ProjectPointontoPlane(fVector3, location, hitResultSimple.HitImpactNormal);
			FRotator rotation = default(FRotator);
			FVector inVec = fVector5 - fVector4;
			inVec.Normalize();
			FQuat fQuat = inVec.Conv_VectorToQuaternion();
			rotation.Pitch = fQuat.Rotator().Pitch;
			rotation.Yaw = fQuat.Rotator().Yaw;
			rotation.Roll = MathLib.MakeRotFromZ(hitResultSimple.HitImpactNormal).Roll;
			TSubclassOf<AActor> tSubclassOf = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UClass>(hitSceneItemPerformDesc.HitWorldItemDecalPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low);
			if (tSubclassOf != null)
			{
				FActorSpawnParametersInterop parameters = new FActorSpawnParametersInterop
				{
					SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
				};
				bGUCharacterCS.World.SpawnActor(tSubclassOf.Value, ref location, ref rotation, ref parameters);
			}
		}
		UnitHitVEffectData.MarkSweepSceneItemProtect(ObjectID, SweepProtectGap);
	}

	private void OnHitGroundPerform(UObject World, List<EAtkFXOnGroundType> AtkFXTypeList, FVector PreLocation, float LineTraceHeight, float SamplingRadius, int SkillEffectID, float SurfaceSamplingRadius, bool EnableCheckThroughWall, float HitFXRadiusMin, float HitFXRadiusMax, float HitFXRadiusExpandTime)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		ESkillDamageType skillDamageType = ESkillDamageType.NoneEffectAtk;
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(SkillEffectID, bGUCharacterCS);
		if (skillEffectDesc != null && skillEffectDesc.EffectParamsInt.Count > 2)
		{
			skillDamageType = (ESkillDamageType)skillEffectDesc.EffectParamsInt[2];
		}
		FVector fVector = PreLocation - new FVector(0.0, 0.0, LineTraceHeight);
		PreLocation.Z = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS).Z + bGUCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight();
		if (UBGUSelectUtil.LineTraceSimple(Owner, PreLocation, fVector, ETraceTypeQuery.TraceTypeQuery6, bDebug: false, out var HitResult, null) <= 0 || (EnableCheckThroughWall && UBGUSelectUtil.LineTraceSimple(Owner, BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS), HitResult.HitLocation, ETraceTypeQuery.TraceTypeQuery6, bDebug: false, out var HitResult2, null) > 0 && FVector.Dist(HitResult2.HitLocation, HitResult.HitLocation) > 50f))
		{
			return;
		}
		int valueInGameThread = GSGameplayCVar.CVar_EnableAtkFXLog.GetValueInGameThread();
		int resID = bGUCharacterCS.GetResID();
		if (!SurfaceTypeSampling(World, PreLocation, SurfaceSamplingRadius, LineTraceHeight, out var SurfaceType))
		{
			return;
		}
		List<AActor> ignores = new List<AActor> { bGUCharacterCS };
		FVector hitLocation = HitResult.HitLocation;
		using List<EAtkFXOnGroundType>.Enumerator enumerator = AtkFXTypeList.GetEnumerator();
		while (enumerator.MoveNext())
		{
			switch (enumerator.Current)
			{
			case EAtkFXOnGroundType.UseDBC:
			{
				FUStHitSceneItemPerformDesc hitSceneItemPerformDesc = BGW_GameDB.GetHitSceneItemPerformDesc(SurfaceType, skillDamageType, resID, SkillEffectID);
				if (hitSceneItemPerformDesc == null)
				{
					break;
				}
				FRotator rotation = BGUFunctionLibraryCS.BGUCalcSlopeSurfaceRot(bGUCharacterCS, ignores, PreLocation, fVector, SamplingRadius);
				rotation.Yaw = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner).Yaw;
				FTransform spawnTransform = new FTransform(rotation, HitResult.HitLocation);
				if (!string.IsNullOrEmpty(hitSceneItemPerformDesc.HitGroundFXPath))
				{
					base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(hitSceneItemPerformDesc.HitGroundFXPath, out var _, null, NeedSetSpawnTransform: true, spawnTransform);
				}
				if (!string.IsNullOrEmpty(hitSceneItemPerformDesc.HitGroundDecalPath))
				{
					TSubclassOf<AActor> tSubclassOf = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UClass>(hitSceneItemPerformDesc.HitGroundDecalPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low);
					if (tSubclassOf != null)
					{
						FActorSpawnParametersInterop parameters = new FActorSpawnParametersInterop
						{
							SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
						};
						FVector location = HitResult.HitLocation;
						bGUCharacterCS.World.SpawnActor(tSubclassOf.Value, ref location, ref rotation, ref parameters);
					}
				}
				break;
			}
			case EAtkFXOnGroundType.UseMatPainter:
			{
				float timeSeconds = bGUCharacterCS.World.GetTimeSeconds();
				List<MaterialScalarParamData> floatValues = new List<MaterialScalarParamData>
				{
					new MaterialScalarParamData(B1GlobalFNames.AffectRadius, HitFXRadiusMin),
					new MaterialScalarParamData(B1GlobalFNames.FadeTime, timeSeconds + 10f),
					new MaterialScalarParamData(B1GlobalFNames.EndTime, -1f)
				};
				List<MaterialVectorParamData> vectorValues = new List<MaterialVectorParamData>
				{
					new MaterialVectorParamData(B1GlobalFNames.HitPositionWS, hitLocation.Conv_VectorToLinearColor())
				};
				base.BGSEventCollection.Evt_BGS_DrawUseMatPainter.Invoke(SurfaceType, EMatPainterType.Point, floatValues, vectorValues);
				break;
			}
			}
		}
	}

	private bool SurfaceTypeSampling(UObject World, FVector SamplingCenter, float SamplingRadius, float LineTraceHeight, out ESceneItemSurfaceType SurfaceType)
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		Dictionary<ESceneItemSurfaceType, int> dictionary = new Dictionary<ESceneItemSurfaceType, int>();
		for (int i = 0; i < 9; i++)
		{
			FVector fVector = SamplingCenter;
			switch (i)
			{
			case 1:
				fVector += new FVector(0f - SamplingRadius, SamplingRadius, 0.0);
				break;
			case 2:
				fVector += new FVector(0.0, SamplingRadius, 0.0);
				break;
			case 3:
				fVector += new FVector(SamplingRadius, SamplingRadius, 0.0);
				break;
			case 4:
				fVector += new FVector(0f - SamplingRadius, 0.0, 0.0);
				break;
			case 5:
				fVector += new FVector(SamplingRadius, 0.0, 0.0);
				break;
			case 6:
				fVector += new FVector(0f - SamplingRadius, 0f - SamplingRadius, 0.0);
				break;
			case 7:
				fVector += new FVector(0.0, 0f - SamplingRadius, 0.0);
				break;
			case 8:
				fVector += new FVector(SamplingRadius, 0f - SamplingRadius, 0.0);
				break;
			}
			FVector endTrace = fVector - new FVector(0.0, 0.0, LineTraceHeight + 2f * bGUCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight());
			if (UBGUSelectUtil.LineTraceSimple(Owner, fVector, endTrace, ETraceTypeQuery.TraceTypeQuery6, bDebug: false, out var HitResult, null) <= 0)
			{
				continue;
			}
			ESceneItemSurfaceType surfaceType = (ESceneItemSurfaceType)HitResult.SurfaceType;
			if (surfaceType != ESceneItemSurfaceType.DefaultSurface)
			{
				if (dictionary.ContainsKey(surfaceType))
				{
					dictionary[surfaceType]++;
				}
				else
				{
					dictionary.Add(surfaceType, 1);
				}
			}
		}
		SurfaceType = ESceneItemSurfaceType.DefaultSurface;
		if (dictionary.Count < 1)
		{
			return false;
		}
		int num = 0;
		foreach (KeyValuePair<ESceneItemSurfaceType, int> item in dictionary)
		{
			if (num < item.Value)
			{
				SurfaceType = item.Key;
				num = item.Value;
			}
		}
		return true;
	}

	private void OnAttackFeedbackPerform(AActor Victim, ESkillDamageType SkillDamageType, EHitPerformFXEventType FinalHitPerformFXEventType, FEffectInstReq EffectInstReq, int CasterResID, int SkillEffectID, int HitPartID)
	{
		if (EffectInstReq.FXWeight_HitChr == -1)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS2 = Victim as BGUCharacterCS;
		if (bGUCharacterCS2 == null)
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(SkillEffectID, bGUCharacterCS);
		if (skillEffectDesc == null)
		{
			return;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked_VFX, "<character>" + Owner?.GetName() + "</><action>=============================攻击特效开始=============================</>");
		}
		int actorResID = GetActorResID();
		IBUC_BeAttackData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>(Victim);
		IBUC_PartMgrData PartMgrData = BGU_DataUtil.GetReadOnlyData<IBUC_PartMgrData, BUC_PartMgrData>(Victim);
		EHitItemFXType partItemFXType = BGUFuncLibBeAttackedAndUnitDeathDispCS.GetPartItemFXType(HitPartID, actorResID, readOnlyData.GetCurrentBeAttackedInfoID(), in PartMgrData);
		EHitPerformFXEventType overrideHitPerformFXEventType = GetOverrideHitPerformFXEventType(CasterResID, FinalHitPerformFXEventType, partItemFXType);
		FUStAttackHitFXMapDesc attackHitFXMapDesc = BGW_GameDB.GetAttackHitFXMapDesc(actorResID, EffectInstReq.FXWeight_HitChr, SkillDamageType, overrideHitPerformFXEventType);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = "\n————————————————攻击特效————————————————\n" + $"HitPerformType:{overrideHitPerformFXEventType}  SkillDamageType:{SkillDamageType}  攻击者ResID:{actorResID}  HitFXWeight:{EffectInstReq.FXWeight_HitChr}\n";
			text = ((attackHitFXMapDesc == null) ? (text + "未在AttackHitFX表中查询到对应视效\n") : (text + $"AttackHitFX表ID: {attackHitFXMapDesc.ID}\n"));
			text += "————————————————攻击特效————————————————";
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked_VFX, "<character>" + Owner?.GetName() + "</><action>" + text + "</>");
		}
		if (attackHitFXMapDesc == null)
		{
			return;
		}
		FTransform fTransform = new FTransform(EffectInstReq.HitPointNormalDir, EffectInstReq.HitLocation);
		if (skillEffectDesc.FXTransUseConfig == EGSYesNo.Yes)
		{
			FRotator rotation = MathLib.Conv_VectorToRotator(new FVector(skillEffectDesc.PlayFXLocalDirY, skillEffectDesc.PlayFXLocalDirZ, skillEffectDesc.PlayFXLocalDirX));
			FRotator rotation2 = BGUFuncLibActorTransformCS.BGUGetActorTransform(bGUCharacterCS2).TransformRotation(rotation);
			FVector socketLocation = bGUCharacterCS2.Mesh.GetSocketLocation(new FName(skillEffectDesc.PlayFXSocketName));
			FVector fVector = (UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetOwner()).PlayerCameraManager.GetCameraLocation() - BGUFuncLibActorTransformCS.BGUGetActorLocation(Victim)).GetSafeNormal() * skillEffectDesc.FXCameraOffset;
			socketLocation += fVector;
			fTransform = new FTransform(rotation2, socketLocation);
		}
		else
		{
			FVector hitLocation = EffectInstReq.HitLocation;
			FRotator hitPointNormalDir = EffectInstReq.HitPointNormalDir;
			fTransform = BGUFunctionLibraryCS.GetFrontLocationByHitPoint(bGUCharacterCS, hitLocation, hitPointNormalDir, ETraceTypeQuery.TraceTypeQuery4, GSGameplayCVar.CVar_EnableAtkFXLog.GetValueInGameThread() != 0);
		}
		string hitFXPath = attackHitFXMapDesc.HitFXPath;
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked_VFX, "<character>" + Owner?.GetName() + "</><action>攻击特效资源路径是：" + hitFXPath + "</>");
		}
		if (attackHitFXMapDesc.IsUseDispConfig == EGSYesNo.Yes)
		{
			FTransform spawnTransform = fTransform;
			base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(hitFXPath, out var _, null, NeedSetSpawnTransform: true, spawnTransform);
		}
		else
		{
			UObject uObject = BGW_PreloadAssetMgr.Get(bGUCharacterCS).TryGetCachedResourceObj<UObject>(hitFXPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low);
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
			if (uParticleSystem != null)
			{
				UGameplayStaticsEx.SpawnEmitterAtLocation(Victim, uParticleSystem, ref fTransform);
			}
			else if (uNiagaraSystem != null)
			{
				UNiagaraFunctionLibrary.SpawnSystemAtLocation(Victim, uNiagaraSystem, fTransform.GetLocation(), fTransform.Rotator(), fTransform.GetScale3D(), bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.AutoRelease, bPreCullCheck: false);
			}
			else if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked_VFX, "<character>" + Owner?.GetName() + "</><action>未配置该攻击特效,请检查</>");
			}
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(bGUCharacterCS);
		if (firstLocalPlayerController != null)
		{
			string directionalFXPath = attackHitFXMapDesc.DirectionalFXPath;
			if (!string.IsNullOrEmpty(directionalFXPath))
			{
				FVector2D fVector2D = BGUFunctionLibraryCS.BGUCalcWorldPositionProjectToScreenVec(UGSE_EngineFuncLib.GetFirstLocalPlayerController(bGUCharacterCS), EffectInstReq.SweepCheckBegin, EffectInstReq.SweepCheckEnd);
				float num = 0f - fVector2D.Y;
				float x = fVector2D.X;
				float num2 = FMath.Clamp(FMath.Acos(x / FMath.Sqrt(x * x + num * num)) / (float)Math.PI * 180f, 0f, 180f);
				if (num < 0f)
				{
					num2 *= -1f;
				}
				FRotator rotation3 = UMathLibrary.RotatorFromAxisAndAngle(firstLocalPlayerController.GetActorForwardVector(), num2);
				FTransform Transform = new FTransform(rotation3, fTransform.GetLocation());
				if (attackHitFXMapDesc.IsUseDispConfig == EGSYesNo.Yes)
				{
					base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(directionalFXPath, out var _, null, NeedSetSpawnTransform: true, Transform);
				}
				else
				{
					UParticleSystem uParticleSystem2 = BGW_PreloadAssetMgr.Get(bGUCharacterCS).TryGetCachedResourceObj<UParticleSystem>(directionalFXPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low);
					if (uParticleSystem2 != null)
					{
						UGameplayStaticsEx.SpawnEmitterAtLocation(Victim, uParticleSystem2, ref Transform);
					}
					else if (DebugConfig.IsOpenBattleInfoTool)
					{
						BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked_VFX, "<character>" + Owner?.GetName() + "</><action>未配置该指向性特效,请检查</>");
					}
				}
			}
			if (!attackHitFXMapDesc.PromptEffectMPCPath.Equals(string.Empty))
			{
				if (attackHitFXMapDesc.MPCParamWithCurve.Count > 0)
				{
					foreach (FUStMPCParamWithCurve item in attackHitFXMapDesc.MPCParamWithCurve)
					{
						base.BUSEventCollection.Evt_TriggerMPCScalarParamTick.Invoke(attackHitFXMapDesc.PromptEffectMPCPath, item.MPCParamName, item.MPCFloatCurvePath, item.MPCCurveTotalTime, item.MPCFloatOriValue);
					}
				}
				if (attackHitFXMapDesc.BlurLocMPCParamName != "")
				{
					FLinearColor value = default(FLinearColor);
					BGUFunctionLibraryCS.ProjectWorldLocationToWidgetPositionWithSZInS(firstLocalPlayerController, fTransform.GetLocation(), out var ScreenPos);
					float viewportScale = UWidgetLayoutLibrary.GetViewportScale(firstLocalPlayerController);
					ScreenPos *= (double)viewportScale;
					firstLocalPlayerController.GetViewportSize(out var SizeX, out var SizeY);
					value.R = FMath.Clamp(ScreenPos.X / (float)SizeX, 0f, 1f);
					value.G = FMath.Clamp(ScreenPos.Y / (float)SizeY, 0f, 1f);
					if (DispLibEventCollection != null)
					{
						BUC_DispLibDBC_ModifyMaterialParameterCollection d = default(BUC_DispLibDBC_ModifyMaterialParameterCollection).SetCustomData(attackHitFXMapDesc.PromptEffectMPCPath, 0f, 10f, new FName(attackHitFXMapDesc.BlurLocMPCParamName), value);
						DispLibEventCollection.Evt_RequestApply_One_ModMPC?.Invoke(d, out var _);
					}
				}
			}
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked_VFX, "<character>" + Owner?.GetName() + "</><action>=============================攻击特效结束=============================</>");
		}
	}

	private void OnPlayAttackHitAudioByRule(AActor Victim, int HitAudioID, EHitPerformAudioEventType HitPerformAudioEventType, FVector HitResultLocation, FRotator DirectionRotator, int CasterResID, int HitPartID)
	{
		if (Victim.IsNullOrDestroyed())
		{
			return;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HitAudio, "<character>" + Owner?.GetName() + "</><action>=============================攻击音效开始=============================</>");
		}
		int actorResID = BGU_DataUtil.GetActorResID(Victim);
		int num = 0;
		if (EquipData != null && EquipData.SelfEquipMap.TryGetValue(EquipPosition.Weapon, out var value))
		{
			EquipDesc equipDesc = GameDBRuntime.GetEquipDesc(value);
			if (equipDesc != null)
			{
				num = equipDesc.AudioHitMappingId;
			}
		}
		FUStAttackHitAudioInfoDesc fUStAttackHitAudioInfoDesc = null;
		Dictionary<int, FUStAttackHitAudioInfoDesc> allAttackHitAudioInfoDesc = BGW_GameDB.GetAllAttackHitAudioInfoDesc();
		if (allAttackHitAudioInfoDesc != null)
		{
			foreach (KeyValuePair<int, FUStAttackHitAudioInfoDesc> item in allAttackHitAudioInfoDesc)
			{
				if (item.Value.BaseID == HitAudioID && item.Value.AudioMappingID == num)
				{
					fUStAttackHitAudioInfoDesc = item.Value;
					break;
				}
			}
		}
		if (fUStAttackHitAudioInfoDesc == null)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HitAudio, $"<character>{Owner.GetName()}</><action> AttackHitAudio表不存在BaseID：{HitAudioID}, AudioMappingID: {num} 的项,请检查  </>");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HitAudio, "<character>" + Owner?.GetName() + "</><action>=============================攻击音效结束=============================</>");
			}
			return;
		}
		IBUC_BeAttackData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>(Victim);
		IBUC_PartMgrData PartMgrData = BGU_DataUtil.GetReadOnlyData<IBUC_PartMgrData, BUC_PartMgrData>(Victim);
		EHitItemAudioType partItemAudioType = BGUFuncLibBeAttackedAndUnitDeathDispCS.GetPartItemAudioType(HitPartID, actorResID, readOnlyData.GetCurrentBeAttackedInfoID(), in PartMgrData);
		EHitPerformAudioEventType overrideHitPerformAudioEventType = GetOverrideHitPerformAudioEventType(actorResID, HitPerformAudioEventType);
		string text = fUStAttackHitAudioInfoDesc.AudioFolderPath + "/" + fUStAttackHitAudioInfoDesc.PreAkEventName + "_" + AttackHitAKNameMapping.HitPerformTypeNameMap[overrideHitPerformAudioEventType] + "_" + AttackHitAKNameMapping.HitItemTypeNameMap[partItemAudioType] + "." + fUStAttackHitAudioInfoDesc.PreAkEventName + "_" + AttackHitAKNameMapping.HitPerformTypeNameMap[overrideHitPerformAudioEventType] + "_" + AttackHitAKNameMapping.HitItemTypeNameMap[partItemAudioType];
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HitAudio, $"<character>{Owner.GetName()}</><action> HitAudioID:{HitAudioID}, 尝试全匹配，命中表现：{AttackHitAKNameMapping.HitPerformTypeNameMap[overrideHitPerformAudioEventType]}，音效肉质：{AttackHitAKNameMapping.HitItemTypeNameMap[partItemAudioType]}</>");
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HitAudio, "<character>" + Owner.GetName() + "</><action> 资源路径：" + text + "</>");
		}
		UObject uObject = TryGetAudioObj(text);
		if (uObject == null)
		{
			text = fUStAttackHitAudioInfoDesc.AudioFolderPath + "/" + fUStAttackHitAudioInfoDesc.PreAkEventName + "_" + AttackHitAKNameMapping.HitPerformTypeNameMap[overrideHitPerformAudioEventType] + "_all." + fUStAttackHitAudioInfoDesc.PreAkEventName + "_" + AttackHitAKNameMapping.HitPerformTypeNameMap[overrideHitPerformAudioEventType] + "_all";
			uObject = TryGetAudioObj(text);
			if (DebugConfig.IsOpenBattleInfoTool && uObject != null)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HitAudio, $"<character>{Owner.GetName()}</><action> HitAudioID:{HitAudioID}, 全匹配失败，此次匹配命中表现{AttackHitAKNameMapping.HitPerformTypeNameMap[overrideHitPerformAudioEventType]}，但不区分肉质，肉质以all作为缺省</>");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HitAudio, "<character>" + Owner.GetName() + "</><action> 资源路径：" + text + "</>");
			}
		}
		if (uObject == null)
		{
			text = fUStAttackHitAudioInfoDesc.AudioFolderPath + "/" + fUStAttackHitAudioInfoDesc.PreAkEventName + "_" + AttackHitAKNameMapping.HitPerformTypeNameMap[EHitPerformAudioEventType.NormalHit] + "_" + AttackHitAKNameMapping.HitItemTypeNameMap[EHitItemAudioType.NormalBody] + "." + fUStAttackHitAudioInfoDesc.PreAkEventName + "_" + AttackHitAKNameMapping.HitPerformTypeNameMap[EHitPerformAudioEventType.NormalHit] + "_" + AttackHitAKNameMapping.HitItemTypeNameMap[EHitItemAudioType.NormalBody];
			uObject = TryGetAudioObj(text);
			if (DebugConfig.IsOpenBattleInfoTool && uObject != null)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HitAudio, $"<character>{Owner.GetName()}</><action> HitAudioID:{HitAudioID}, 一级缺省匹配失败, 保底播一个普通命中肉体作为缺省</>");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HitAudio, "<character>" + Owner.GetName() + "</><action> 资源路径：" + text + "</>");
			}
		}
		if (DebugConfig.IsOpenBattleInfoTool && uObject == null)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HitAudio, $"<character>{Owner.GetName()}</><action> HitAudioID:{HitAudioID}, 保底匹配也失败，请检查，命中表现：{AttackHitAKNameMapping.HitPerformTypeNameMap[overrideHitPerformAudioEventType]}，肉质：{AttackHitAKNameMapping.HitItemTypeNameMap[partItemAudioType]}</>");
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HitAudio, "<character>" + Owner.GetName() + "</><action> 资源路径：" + text + "</>");
		}
		UAkAudioEvent uAkAudioEvent = uObject as UAkAudioEvent;
		if (uAkAudioEvent != null)
		{
			UAkGameplayStatics.SpawnAkComponentAtLocation(Owner, uAkAudioEvent, HitResultLocation, DirectionRotator, AutoPost: true, string.Empty)?.SetRTPCValue(null, bOwnerCanTriggerMotion ? 1 : 0, 0, B1GlobalFNames.MotionSwitch.ToString());
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HitAudio, "<character>" + Owner?.GetName() + "</><action>=============================攻击音效结束=============================</>");
		}
	}

	private UObject TryGetAudioObj(string AudioPath)
	{
		BGWDataAsset_HitAudioPreloadList hitAudioPreloadListConfig = BGW_PreloadAssetMgr.Get(Owner).HitAudioPreloadListConfig;
		if (hitAudioPreloadListConfig != null && hitAudioPreloadListConfig.ObjMapping.TryGetValue(AudioPath, out var value))
		{
			return value;
		}
		return null;
	}

	private EHitPerformFXEventType GetOverrideHitPerformFXEventType(int AttackerResID, EHitPerformFXEventType HitPerformFXEventType, EHitItemFXType HitItemFXType)
	{
		Dictionary<int, FUStAttackerHitFXMappingDesc> allAttackerHitFXMappingDesc = BGW_GameDB.GetAllAttackerHitFXMappingDesc();
		if (allAttackerHitFXMappingDesc != null && allAttackerHitFXMappingDesc.Count > 0)
		{
			foreach (KeyValuePair<int, FUStAttackerHitFXMappingDesc> item in allAttackerHitFXMappingDesc)
			{
				int key = item.Key;
				FUStAttackerHitFXMappingDesc value = item.Value;
				if (value != null && (AttackerResID == key / 100 || key < 1000) && value.HitItemType == HitItemFXType && (int)value.LowerHitPerformTypeCondition > (int)HitPerformFXEventType)
				{
					return value.MappingHitPerformType;
				}
			}
		}
		return HitPerformFXEventType;
	}

	private EHitPerformAudioEventType GetOverrideHitPerformAudioEventType(int VictimResID, EHitPerformAudioEventType HitPerformAudioEventType)
	{
		Dictionary<int, FUStAttackerHitAudioEventMappingDesc> allAttackerHitAudioEventMappingDesc = BGW_GameDB.GetAllAttackerHitAudioEventMappingDesc();
		if (allAttackerHitAudioEventMappingDesc != null && allAttackerHitAudioEventMappingDesc.Count > 0)
		{
			foreach (KeyValuePair<int, FUStAttackerHitAudioEventMappingDesc> item in allAttackerHitAudioEventMappingDesc)
			{
				FUStAttackerHitAudioEventMappingDesc value = item.Value;
				if (value == null)
				{
					continue;
				}
				bool flag = true;
				if (value.AttackerResID > 0 && value.AttackerResID != GetActorResID())
				{
					flag = false;
				}
				bool flag2 = true;
				if (value.VictimResID > 0 && value.VictimResID != VictimResID)
				{
					flag2 = false;
				}
				if (!(flag && flag2))
				{
					continue;
				}
				switch (value.MappingCondition)
				{
				case EHitPerformAudioMappingCondition.Lower:
					if ((int)value.ConditionEventType > (int)HitPerformAudioEventType)
					{
						return value.MappingHitPerformType;
					}
					break;
				case EHitPerformAudioMappingCondition.Replace:
					if (value.ConditionEventType == HitPerformAudioEventType)
					{
						return value.MappingHitPerformType;
					}
					break;
				}
			}
		}
		return HitPerformAudioEventType;
	}

	private void WaterSplashPlay_Start(int UniqueID, int FromInstanceID, FWaterSplashSweepConfig SweepConfig)
	{
		if (WaterSplashData != null)
		{
			string key = $"{FromInstanceID}{UniqueID}";
			WaterSplashData.SweepConfigDic[key] = SweepConfig;
			WaterSplashData.bFlag_BindSkillBreak++;
			if (WaterSplashData.bFlag_BindSkillBreak == 1)
			{
				base.BUSEventCollection.Evt_UnitSkillBreak += new Del_UnitSkillBreak(OnSkillBreak);
			}
		}
	}

	private void WaterSplashPlay_End(int UniqueID, int FromInstanceID)
	{
		if (WaterSplashData == null)
		{
			return;
		}
		string key = $"{FromInstanceID}{UniqueID}";
		if (!WaterSplashData.SweepConfigDic.ContainsKey(key))
		{
			return;
		}
		FWaterSplashSweepConfig fWaterSplashSweepConfig = WaterSplashData.SweepConfigDic[key];
		if (fWaterSplashSweepConfig != null)
		{
			FTransform worldTransform = GetMeshComp(fWaterSplashSweepConfig.WeaponIndex).GetWorldTransform();
			foreach (KeyValuePair<float, FVector> presetLocalPoint in fWaterSplashSweepConfig.PresetLocalPoints)
			{
				PlayWaterSplash_Unit(fWaterSplashSweepConfig, presetLocalPoint.Value, worldTransform);
			}
			StopWaterSplashAudio(fWaterSplashSweepConfig);
		}
		WaterSplashData.SweepConfigDic.Remove(key);
		WaterSplashData.bFlag_BindSkillBreak--;
		if (WaterSplashData.bFlag_BindSkillBreak == 0)
		{
			base.BUSEventCollection.Evt_UnitSkillBreak -= new Del_UnitSkillBreak(OnSkillBreak);
		}
	}

	private void StopAllWaterSplashAudio()
	{
	}

	private void StopWaterSplashAudio(FWaterSplashSweepConfig SweepConfig)
	{
	}

	private void OnSkillBreak(int SkillID, string Reason)
	{
		if (WaterSplashData != null)
		{
			StopAllWaterSplashAudio();
			WaterSplashData.SweepConfigDic.Clear();
		}
	}

	private void WaterSplashPlay_Tick(float DeltaTime)
	{
		if (WaterSplashData == null || WaterSplashData.SweepConfigDic.Count < 1 || UnitSimpleStates.HasSimpleState(EBGUSimpleState.Immobilizing) || UnitSimpleStates.HasSimpleState(EBGUSimpleState.Frozen))
		{
			return;
		}
		foreach (KeyValuePair<string, FWaterSplashSweepConfig> item in WaterSplashData.SweepConfigDic)
		{
			item.Value.CurTime += DeltaTime;
			FTransform worldTransform = GetMeshComp(item.Value.WeaponIndex).GetWorldTransform();
			List<float> list = new List<float>();
			foreach (KeyValuePair<float, FVector> presetLocalPoint in item.Value.PresetLocalPoints)
			{
				if (item.Value.CurTime >= presetLocalPoint.Key)
				{
					PlayWaterSplash_Unit(item.Value, presetLocalPoint.Value, worldTransform);
					list.Add(presetLocalPoint.Key);
					continue;
				}
				break;
			}
			foreach (float item2 in list)
			{
				item.Value.PresetLocalPoints.Remove(item2);
			}
		}
	}

	private USkeletalMeshComponent GetMeshComp(int WeaponIndex)
	{
		USkeletalMeshComponent result = null;
		if (WeaponIndex == -1)
		{
			result = OwnerAsCharacterCS.Mesh;
		}
		else
		{
			_ = B1GlobalFNames.weapon_;
			AActor aActor = BGUFunctionLibraryCS.BGUGetWeaponByIndex(Owner, WeaponIndex);
			if (aActor != null)
			{
				result = aActor.GetComponentByClass<USkeletalMeshComponent>();
			}
		}
		return result;
	}

	private void PlayWaterSplash_Unit(FWaterSplashSweepConfig SweepConfig, FVector LocalPos, FTransform MeshTrans)
	{
		if (WaterSplashData == null || WaterSplashData.WaterSplashConfig == null || SweepConfig == null)
		{
			return;
		}
		FVector fVector = MeshTrans.TransformPosition(LocalPos);
		int mappingID = SweepConfig.MappingID;
		float sweepRadius = SweepConfig.SweepRadius;
		if (WaterSplashData.WaterSplashConfig.bDrawDebug)
		{
			USystemLibrary.DrawDebugSphere(Owner, fVector, 10f, 8, FLinearColor.Blue, 2f, 0.2f);
		}
		FVector startTrace = fVector;
		startTrace.Z = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner).Z + OwnerAsCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight();
		FVector endTrace = fVector;
		endTrace.Z -= sweepRadius;
		if (UBGUSelectUtil.LineTraceSimple(Owner, startTrace, endTrace, ETraceTypeQuery.TraceTypeQuery6, WaterSplashData.WaterSplashConfig.bDrawDebug, out var HitResult, null) > 0 && WaterSplashData.WaterSplashConfig.ResourceMap.TryGetValue(mappingID, out var value))
		{
			ESceneItemSurfaceType surfaceType = (ESceneItemSurfaceType)HitResult.SurfaceType;
			if (value.FXMap.TryGetValue(surfaceType, out var value2))
			{
				if (value2.NiagaraSys != null)
				{
					FTransform transform = default(FTransform);
					transform.Scale3D = FVector.OneVector;
					transform.SetLocation(HitResult.HitLocation);
					DBCTransformParam dBCTransform = new DBCTransformParam(transform);
					int gamePlayDispReqID = DispLibEventCollection.Evt_RequestSpawn_One_Advance_Niagara(value2.AdvanceNiagara, DispLibRefParam.Instance, null, FVector.ZeroVector, dBCTransform);
					if (value2.ApplyDir)
					{
						FRotator inRot = MathLib.FindLookAtRotation(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), HitResult.HitLocation);
						inRot.Pitch = 0f;
						inRot.Roll = 0f;
						FVector fVector2 = inRot.Conv_RotatorToVector();
						DispLibEventCollection.Evt_RequestSetDBCNiagaraVectorParam(gamePlayDispReqID, B1GlobalFNames.User_WaterSplashDir, fVector2);
						if (WaterSplashData.WaterSplashConfig.bDrawDebug)
						{
							USystemLibrary.DrawDebugArrow(Owner, HitResult.HitLocation, HitResult.HitLocation + fVector2 * 500.0, 100f, FLinearColor.Red, 2f, 0.5f);
						}
						if (SweepConfig.PresetLocalSweepTangent.Count > SweepConfig.Index)
						{
							FVector fVector3 = MeshTrans.TransformDirection(SweepConfig.PresetLocalSweepTangent[SweepConfig.Index]);
							DispLibEventCollection.Evt_RequestSetDBCNiagaraVectorParam(gamePlayDispReqID, B1GlobalFNames.User_Tangent, fVector3);
							if (WaterSplashData.WaterSplashConfig.bDrawDebug)
							{
								USystemLibrary.DrawDebugArrow(Owner, HitResult.HitLocation, HitResult.HitLocation + fVector3 * 500.0, 100f, FLinearColor.Green, 2f, 0.5f);
							}
						}
					}
				}
				if (!SweepConfig.AlreadyPostAudio && value2.AkEvent != null)
				{
					base.BUSEventCollection.Evt_PostAkEvent_Follow.Invoke(OwnerAsCharacterCS.Mesh, WaterSplashData.WaterSplashConfig.SocketName_PostAudio, value2.AkEvent);
					SweepConfig.PlayingID = AkMgrData.LastPlayingID;
					SweepConfig.AlreadyPostAudio = true;
				}
				if (WaterSplashData.WaterSplashConfig.bDrawDebug)
				{
					USystemLibrary.DrawDebugSphere(Owner, HitResult.HitLocation, 30f, 8, FLinearColor.Green, 2f, 0.5f);
				}
			}
		}
		SweepConfig.Index++;
	}
}
