using System;
using System.Collections.Generic;
using b1.AutoQA;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_BuffDispComp : UActorCompBaseCS
{
	private BUC_BuffData BuffData;

	private IBGC_BuffDispMgrData BuffDispMgrData;

	private BUC_BuffDispData BuffDispData;

	private int OwnerResID;

	private Dictionary<int, Dictionary<int, int>> LayerDispMap = new Dictionary<int, Dictionary<int, int>>();

	public override void OnAttach()
	{
		BuffData = RequireWritableData<BUC_BuffData>();
		BuffDispMgrData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_BuffDispMgrData, BGC_BuffDispMgrData>(Owner);
		BuffDispData = RequireWritableData<BUC_BuffDispData>();
		base.BUSEventCollection.Evt_OnBuffLayerChangedNotify += new Del_OnBuffLayerChangedNotify(OnBuffLayerChanged);
		base.BUSEventCollection.Evt_TriggerBuffDamageFX += new Del_Void_IntInt(PlayDamageFX);
		base.BUSEventCollection.Evt_TriggerBuffAlmostEndFX += new Del_Void_IntInt(PlayAlmostEndFX);
		base.BUSEventCollection.Evt_OnBuffLayerChanged += new Del_OnBuffLayerChanged(OnBuffLayerChanged);
		base.BUSEventCollection.Evt_RequestHideOldBuffDisp += new Del_Void_Bool(OnRequestHideOldBuffDisp);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
		bGW_EventCollection.Evt_PostSeamlessTravel = (BGW_EventCollection.Del_BGW_Void)Delegate.Combine(bGW_EventCollection.Evt_PostSeamlessTravel, new BGW_EventCollection.Del_BGW_Void(OnPostSeamlessTravel));
		if (!(Owner is ACharacter))
		{
			SetCanTick(Val: false);
		}
	}

	public void OnPostSeamlessTravel()
	{
		foreach (KeyValuePair<int, BuffInstData> item in BuffData.BuffInstsDict)
		{
			OnBuffAdd(item.Key);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
		bGW_EventCollection.Evt_PostSeamlessTravel = (BGW_EventCollection.Del_BGW_Void)Delegate.Remove(bGW_EventCollection.Evt_PostSeamlessTravel, new BGW_EventCollection.Del_BGW_Void(OnPostSeamlessTravel));
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		OwnerResID = GetUnitResID_BuffDisp(Owner);
	}

	private void OnBuffAdd(int BuffID)
	{
		if (BuffDispMgrData != null && this.BuffData.GetBuffInstData(BuffID, out var BuffData))
		{
			AActor aActor = EntitySharedRefFuncLib.Actor(BuffData.CasterRef);
			int unitResID_BuffDisp = GetUnitResID_BuffDisp(aActor);
			FUStBuffDispDesc buffDispDesc = BGW_GameDB.GetBuffDispDesc(OwnerResID, BuffID, unitResID_BuffDisp);
			if (BuffDispMgrData.CanTrigger() || (buffDispDesc != null && buffDispDesc.ForceDisplay == EGSYesNo.Yes))
			{
				TriggerBuffAdd(BuffID, aActor, BuffData);
			}
			else
			{
				AddBuffDispToQueue(BuffID);
			}
		}
	}

	private void TriggerBuffAdd(int BuffID, AActor Caster, BuffInstData InBuffInstData)
	{
		bool flag = false;
		float duration = InBuffInstData.Duration;
		int unitResID_BuffDisp = GetUnitResID_BuffDisp(Caster);
		CreateBuffDispInstance(BuffID, unitResID_BuffDisp, out var NormalDispInstance, out var SingleDispInstanceList, out var GroupDispInstanceList);
		if (NormalDispInstance != null && NormalDispInstance.BuffDispDesc != null && (!InBuffInstData.bAlreadyDisplayed_Normal || NormalDispInstance.BuffDispDesc.AllowReplay == EGSYesNo.Yes))
		{
			ClearDispInstance(NormalDispInstance.InstanceID, bRemove: false);
			flag |= PlayAddBuffDisp(NormalDispInstance, duration, Caster);
			InBuffInstData.bAlreadyDisplayed_Normal = true;
		}
		foreach (FBuffDispInstance item in SingleDispInstanceList)
		{
			if (item != null && item.BuffDispDesc != null && (!InBuffInstData.bAlreadyDisplayed_Single || item.BuffDispDesc.AllowReplay == EGSYesNo.Yes))
			{
				ClearDispInstance(item.InstanceID, bRemove: false);
				flag |= PlayAddBuffDisp(item, duration, Caster);
				InBuffInstData.bAlreadyDisplayed_Single = true;
			}
		}
		foreach (FBuffDispInstance item2 in GroupDispInstanceList)
		{
			if (item2 != null)
			{
				ClearDispInstance(item2.InstanceID, bRemove: false);
				flag |= PlayAddBuffDisp(item2, duration, Caster, BuffID);
			}
		}
		if (flag)
		{
			base.BGSEventCollection.Evt_BGS_IncreaseBuffDispGlobalTriggerCounter.Invoke();
		}
	}

	private void AddBuffDispToQueue(int BuffID)
	{
		if (!BuffDispData.PendingBuffDispList.Contains(BuffID))
		{
			BuffDispData.PendingBuffDispList.Add(BuffID);
		}
	}

	private void OnBuffRemove(int BuffID)
	{
		BuffDispData.PendingBuffDispList.Remove(BuffID);
		OnBuffLayerDispClear(BuffID);
		ClearDispInstanceByBuffID(BuffID);
		DoBuffDispAction(BuffID, TriggerRemoveBuffDisp);
		RemoveDispInstanceByBuffID(BuffID);
		BuffDispData.Buff2DispGroupMultiMap.Remove(BuffID);
	}

	private void OnBuffLayerChanged(int BuffID, int OldLayer, int NewLayer)
	{
		if (NewLayer <= 0)
		{
			if (OldLayer > 0)
			{
				OnBuffRemove(BuffID);
			}
		}
		else
		{
			OnBuffAdd(BuffID);
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickAllCurveParam(DeltaTime);
		TickPendingBuffDipStrategy();
	}

	private void TickPendingBuffDipStrategy()
	{
		if (BuffDispMgrData == null)
		{
			return;
		}
		int num = 0;
		while (BuffDispMgrData.CanTrigger() && BuffDispData.PendingBuffDispList.Count > 0)
		{
			int buffID = BuffDispData.PendingBuffDispList[0];
			if (this.BuffData.GetBuffInstData(buffID, out var BuffData))
			{
				AActor caster = EntitySharedRefFuncLib.Actor(BuffData.CasterRef);
				TriggerBuffAdd(buffID, caster, BuffData);
				BuffDispData.PendingBuffDispList.RemoveAt(0);
				if (++num >= BuffDispMgrData.MaxTriggerCountPerFrame)
				{
					break;
				}
			}
		}
	}

	private void PlayOneFX(FBuffDispInstance DispInstance, FUStFXSetting FXSetting, bool CanBeLooping)
	{
		AActor owner = GetOwner();
		if (BGW_LogUtil.LogIfNull(owner, "GetOwner is null") || FXSetting.PSPath.Equals(""))
		{
			return;
		}
		UObject uObject = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UObject>(FXSetting.PSPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low);
		if (uObject == null || uObject.IsNullOrDestroyed())
		{
			return;
		}
		UFXSystemComponent uFXSystemComponent = null;
		UParticleSystem uParticleSystem = uObject as UParticleSystem;
		UNiagaraSystem uNiagaraSystem = uObject as UNiagaraSystem;
		EPSCPoolMethod poolingMethod = EPSCPoolMethod.None;
		if (uParticleSystem != null)
		{
			if (!CanBeLooping)
			{
				if (UBGUFunctionLibraryForCS.BGUGetParticleSystemIsLooping(uParticleSystem))
				{
					BGW_LogUtil.LogError("CanBeLooping is False, But ParticleSystem is with Loop:%s", UObject.GetNameSafe(uParticleSystem));
					return;
				}
			}
			else
			{
				poolingMethod = ((!UBGUFunctionLibraryForCS.BGUGetParticleSystemIsLooping(uParticleSystem)) ? EPSCPoolMethod.AutoRelease : EPSCPoolMethod.ManualRelease);
			}
		}
		else if (uNiagaraSystem == null)
		{
			return;
		}
		ACharacter aCharacter = owner as ACharacter;
		if (!(aCharacter != null))
		{
			uFXSystemComponent = ((FXSetting.IsAttach == EGSYesNo.Yes) ? ((!(uParticleSystem != null)) ? ((UFXSystemComponent)UNiagaraFunctionLibrary.SpawnSystemAttached(uNiagaraSystem, GetOwner().GetRootComponent(), new FName(FXSetting.AttachName), FVector.ZeroVector, FRotator.ZeroRotator, EAttachLocation.SnapToTarget, bAutoDestroy: true)) : ((UFXSystemComponent)UGameplayStatics.SpawnEmitterAttached(uParticleSystem, GetOwner().GetRootComponent(), FName.None, FVector.ZeroVector, FRotator.ZeroRotator, new FVector(FXSetting.Scale), EAttachLocation.SnapToTarget, bAutoDestroy: true, poolingMethod, bAutoActivate: true))) : ((!(uParticleSystem != null)) ? ((UFXSystemComponent)UNiagaraFunctionLibrary.SpawnSystemAtLocation(GetOwner().World, uNiagaraSystem, BGUFuncLibActorTransformCS.BGUGetActorLocation(owner), FRotator.ZeroRotator, new FVector(FXSetting.Scale), bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.AutoRelease, bPreCullCheck: false)) : ((UFXSystemComponent)UGameplayStatics.SpawnEmitterAtLocation(GetOwner().World, uParticleSystem, BGUFuncLibActorTransformCS.BGUGetActorLocation(owner), FRotator.ZeroRotator, new FVector(FXSetting.Scale), bAutoDestroy: true, poolingMethod, bAutoActivateSystem: true))));
		}
		else
		{
			USceneComponent SocketOwnerComp;
			FTransform socketOrCompTransform = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, aCharacter, new FName(FXSetting.AttachName), out SocketOwnerComp);
			FVector scale = new FVector(FXSetting.Scale);
			if (FXSetting.UseScaleFit == EGSYesNo.Yes)
			{
				float num = aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight() / 96f;
				scale *= (double)num;
			}
			if (FXSetting.IsAttach == EGSYesNo.Yes)
			{
				uFXSystemComponent = ((!(uParticleSystem != null)) ? ((UFXSystemComponent)UNiagaraFunctionLibrary.SpawnSystemAttached(uNiagaraSystem, SocketOwnerComp, new FName(FXSetting.AttachName), FVector.ZeroVector, FRotator.ZeroRotator, EAttachLocation.SnapToTarget, bAutoDestroy: true)) : ((UFXSystemComponent)UGameplayStatics.SpawnEmitterAttached(uParticleSystem, SocketOwnerComp, new FName(FXSetting.AttachName), FVector.ZeroVector, FRotator.ZeroRotator, scale, EAttachLocation.SnapToTarget, bAutoDestroy: true, poolingMethod, bAutoActivate: true)));
			}
			else
			{
				FQuat fQuat = new FQuat(FRotator.ZeroRotator);
				uFXSystemComponent = ((!(uParticleSystem != null)) ? ((UFXSystemComponent)UNiagaraFunctionLibrary.SpawnSystemAtLocation(GetOwner().World, uNiagaraSystem, socketOrCompTransform.GetLocation(), new FRotator(socketOrCompTransform.GetRotation() * fQuat), scale, bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.AutoRelease, bPreCullCheck: false)) : ((UFXSystemComponent)UGameplayStatics.SpawnEmitterAtLocation(GetOwner().World, uParticleSystem, socketOrCompTransform.GetLocation(), new FRotator(socketOrCompTransform.GetRotation() * fQuat), scale, bAutoDestroy: true, poolingMethod, bAutoActivateSystem: true)));
			}
			if (FXSetting.IsAttachToSkin == EGSYesNo.Yes)
			{
				UParticleSystemComponent uParticleSystemComponent = uFXSystemComponent as UParticleSystemComponent;
				if (uParticleSystemComponent != null)
				{
					FParticleSysParam item = new FParticleSysParam
					{
						ParamType = EParticleSysParamType.PSPT_Actor,
						Actor = aCharacter,
						Name = new FName(FXSetting.SkelMeshParamName)
					};
					uParticleSystemComponent.InstanceParameters.Add(item);
				}
				UNiagaraComponent uNiagaraComponent = uFXSystemComponent as UNiagaraComponent;
				if (uNiagaraComponent != null)
				{
					string overrideName = FXParamName.SkeltalMesh_Skin_ParamName.ToString();
					UNiagaraFunctionLibrary.OverrideSystemUserVariableSkeletalMeshComponent(uNiagaraComponent, overrideName, aCharacter.Mesh);
					uNiagaraComponent.Activate();
				}
			}
		}
		if (BGW_LogUtil.LogIfNull(uFXSystemComponent, "FXComp is null SpawnEmitter Failed"))
		{
			return;
		}
		if (uParticleSystem != null)
		{
			if (UBGUFunctionLibraryForCS.BGUGetParticleSystemIsLooping(uParticleSystem))
			{
				DispInstance.PlayingBuffFXs.Add(uFXSystemComponent);
			}
		}
		else
		{
			DispInstance.PlayingBuffFXs.Add(uFXSystemComponent);
		}
		string[] array = FXSetting.AddTags.Split(',');
		if (array.Length >= 1)
		{
			string[] array2 = array;
			foreach (string name in array2)
			{
				uFXSystemComponent.ComponentTags.Add(new FName(name));
			}
		}
	}

	private void PlayOneFXWithDispConfig(FBuffDispInstance DispInstance, string DBCPath, bool NeedCacheRequestID = false, AActor Caster = null)
	{
		int num = SpawnFXByDispConfig(DBCPath, Caster);
		if (NeedCacheRequestID && num > 0)
		{
			DispInstance.PlayingBuffDispConfigRequestIDs.Add(num);
		}
	}

	private int SpawnFXByDispConfig(string DBCPath, AActor Caster = null)
	{
		USceneComponent emitterDispOwnerComp = null;
		if (Caster != null)
		{
			BGUCharacterCS bGUCharacterCS = Caster as BGUCharacterCS;
			emitterDispOwnerComp = ((!(bGUCharacterCS != null)) ? Caster.RootComponent : bGUCharacterCS.Mesh);
		}
		base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(DBCPath, out var RequestID, emitterDispOwnerComp);
		return RequestID;
	}

	private void PlayDamageFX(int BuffID, int CasterResID)
	{
		if (!(GetOwner() as BGUCharacterCS).IsNullOrDestroyed())
		{
			GetBuffDispInstanceByBuffID(BuffID, out var NormalDispInstance, out var SingleDispInstance, out var GroupDispInstance);
			if (NormalDispInstance != null)
			{
				PlayDamageFX(NormalDispInstance);
			}
			if (SingleDispInstance != null)
			{
				PlayDamageFX(SingleDispInstance);
			}
			if (GroupDispInstance != null)
			{
				PlayDamageFX(GroupDispInstance);
			}
		}
	}

	private void PlayDamageFX(FBuffDispInstance DispInstance)
	{
		FUStBuffDispDesc buffDispDesc = DispInstance.BuffDispDesc;
		if (buffDispDesc.DamageFXSetting.Count < 1)
		{
			return;
		}
		foreach (FUStFXSetting item in buffDispDesc.DamageFXSetting)
		{
			if (buffDispDesc.IsUseDispConfig == EGSYesNo.No)
			{
				PlayOneFX(DispInstance, item, CanBeLooping: false);
			}
			else
			{
				PlayOneFXWithDispConfig(DispInstance, item.PSPath);
			}
		}
	}

	private void StartTickCurveParam(FBuffDispInstance DispInstance, float BuffDuration, FUStFloatCurveToParam FloatCurveToParam)
	{
		BuffDispTickData item = new BuffDispTickData
		{
			CurrentCurvePos = 0f,
			CurvePosScale = 1f,
			FloatCurveToParam = FloatCurveToParam,
			CurveFloat = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UCurveFloat>(FloatCurveToParam.FloatCurvePath, ELoadResourceType.SyncLoadAndCache)
		};
		if (BGW_LogUtil.LogIfNull(item.CurveFloat, "TryGetCachedResourceObj Failed BuffID:%d Res:%s", DispInstance.InstanceID, FloatCurveToParam.FloatCurvePath))
		{
			return;
		}
		if (BuffDuration > 0f && FloatCurveToParam.CurvePosFitType != EGSPosFitType.FitBegin)
		{
			float MinTime = 0f;
			float MaxTime = 0f;
			item.CurveFloat.GetTimeRange(out MinTime, out MaxTime);
			if (FloatCurveToParam.CurvePosFitType == EGSPosFitType.FitEnd)
			{
				item.CurrentCurvePos = MaxTime - BuffDuration;
			}
			else if (FloatCurveToParam.CurvePosFitType == EGSPosFitType.FitBothWithScale && BuffDuration != 0f)
			{
				item.CurvePosScale = MaxTime / BuffDuration;
			}
		}
		DispInstance.PlayingBuffTickDataList.Add(item);
	}

	private void EndTickCurveParam(BuffDispTickData BuffDispTickData)
	{
		if (BGW_LogUtil.LogIfNull(BuffDispTickData.FloatCurveToParam, "FloatCurveToParam is null") || BGW_LogUtil.LogIfNull(BuffDispTickData.CurveFloat, "CurveFloat is null"))
		{
			return;
		}
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (!BGW_LogUtil.LogIfNull(aCharacter, "GetOwner Cast To ABGUCharacter is null") && BuffDispTickData.FloatCurveToParam.IsResetOnEnd == EGSYesNo.Yes)
		{
			float floatValue = BuffDispTickData.CurveFloat.GetFloatValue(0f);
			if (BuffDispTickData.FloatCurveToParam.UsePrimitiveData == EGSYesNo.Yes)
			{
				aCharacter.Mesh.SetCustomPrimitiveDataFloat(BuffDispTickData.FloatCurveToParam.DataIndex, floatValue);
			}
			else
			{
				aCharacter.Mesh.SetScalarParameterValueOnMaterials(new FName(BuffDispTickData.FloatCurveToParam.ParamName), floatValue);
			}
		}
	}

	private void TickAllCurveParam(float DeltaTime)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		foreach (KeyValuePair<long, FBuffDispInstance> buffDispInstance in BuffDispData.BuffDispInstances)
		{
			List<BuffDispTickData> playingBuffTickDataList = buffDispInstance.Value.PlayingBuffTickDataList;
			for (int i = 0; i < playingBuffTickDataList.Count; i++)
			{
				BuffDispTickData value = playingBuffTickDataList[i];
				value.CurrentCurvePos += DeltaTime * value.CurvePosScale;
				playingBuffTickDataList[i] = value;
				if (!(value.CurrentCurvePos < 0f))
				{
					float currentCurvePos = value.CurrentCurvePos;
					float floatValue = value.CurveFloat.GetFloatValue(currentCurvePos);
					if (value.FloatCurveToParam.UsePrimitiveData == EGSYesNo.Yes)
					{
						aCharacter.Mesh.SetCustomPrimitiveDataFloat(value.FloatCurveToParam.DataIndex, floatValue);
					}
					else
					{
						aCharacter.Mesh.SetScalarParameterValueOnMaterials(new FName(value.FloatCurveToParam.ParamName), floatValue);
					}
				}
			}
		}
	}

	private bool PlayAddBuffDisp(FBuffDispInstance InDispInstance, float BuffDuration, AActor Caster, int BuffID = 0)
	{
		if (InDispInstance == null)
		{
			return false;
		}
		if (InDispInstance.DispType == EBuffDispType.Group)
		{
			if (BuffID > 0)
			{
				int count = InDispInstance.BuffsInGroup.Count;
				ListExtensions.AddUnique(InDispInstance.BuffsInGroup, BuffID);
				if (count > 0)
				{
					return false;
				}
			}
		}
		else
		{
			ClearDispInstance(InDispInstance);
		}
		FUStBuffDispDesc buffDispDesc = InDispInstance.BuffDispDesc;
		for (int i = 0; i < buffDispDesc.EnterFX.Count; i++)
		{
			FUStFXSetting fUStFXSetting = buffDispDesc.EnterFX[i];
			if (buffDispDesc.IsUseDispConfig == EGSYesNo.No)
			{
				PlayOneFX(InDispInstance, fUStFXSetting, CanBeLooping: true);
			}
			else
			{
				PlayOneFXWithDispConfig(InDispInstance, fUStFXSetting.PSPath, NeedCacheRequestID: true, Caster);
			}
		}
		if (buffDispDesc.IsUseDispConfig == EGSYesNo.No)
		{
			for (int j = 0; j < buffDispDesc.TickingCurveParam.Count; j++)
			{
				FUStFloatCurveToParam floatCurveToParam = buffDispDesc.TickingCurveParam[j];
				StartTickCurveParam(InDispInstance, BuffDuration, floatCurveToParam);
			}
		}
		else if (BuffDispData.HiddenPendingBuffID.Contains(BuffID))
		{
			TriggerHideBuffDispInstance(InDispInstance, bHide: true);
			BuffDispData.HiddenBuffDispInstances.Add(InDispInstance.InstanceID);
			BuffDispData.HiddenPendingBuffID.Remove(BuffID);
		}
		if (buffDispDesc.MaterialSetting.Count > 0)
		{
			AActor owner = GetOwner();
			for (int k = 0; k < buffDispDesc.MaterialSetting.Count; k++)
			{
				string path = buffDispDesc.MaterialSetting[k];
				BGWDataAsset_BuffSetCurveValueToMeshConfig bGWDataAsset_BuffSetCurveValueToMeshConfig = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<BGWDataAsset_BuffSetCurveValueToMeshConfig>(path, ELoadResourceType.SyncLoadAndCache);
				int num = -(InDispInstance.GetMaterialUniqueIndexBase() + k);
				base.BUSEventCollection.Evt_BeginForSetCurveValueToMesh.Invoke(num, bGWDataAsset_BuffSetCurveValueToMeshConfig.FloatCurveParamList, bGWDataAsset_BuffSetCurveValueToMeshConfig.LinearColorCurveParamList, bGWDataAsset_BuffSetCurveValueToMeshConfig.NotApplyToChrMesh, bGWDataAsset_BuffSetCurveValueToMeshConfig.MatIndexList, bGWDataAsset_BuffSetCurveValueToMeshConfig.BothWeapons, bGWDataAsset_BuffSetCurveValueToMeshConfig.WeaponIndexList, bGWDataAsset_BuffSetCurveValueToMeshConfig.WeaponMatIndexList, bGWDataAsset_BuffSetCurveValueToMeshConfig.BothChildMeshes, bGWDataAsset_BuffSetCurveValueToMeshConfig.ChildMeshTagList, bGWDataAsset_BuffSetCurveValueToMeshConfig.ChildMeshMatIndexList, bGWDataAsset_BuffSetCurveValueToMeshConfig.BothChildActor, bGWDataAsset_BuffSetCurveValueToMeshConfig.ChildActorMeshMatIndexList, BuffDuration, bGWDataAsset_BuffSetCurveValueToMeshConfig.bFitRealTime);
				base.BUSEventCollection.Evt_BeginForSetCurveValueToHair.Invoke(num, bGWDataAsset_BuffSetCurveValueToMeshConfig.HairType, bGWDataAsset_BuffSetCurveValueToMeshConfig.HairCompTagList, bGWDataAsset_BuffSetCurveValueToMeshConfig.HairFloatCurveParamList, BuffDuration);
			}
		}
		return true;
	}

	private void TriggerRemoveBuffDisp(FBuffDispInstance DispInstance, int BuffID)
	{
		if (DispInstance.DispType == EBuffDispType.Group)
		{
			DispInstance.BuffsInGroup.Remove(BuffID);
			if (DispInstance.BuffsInGroup.Count > 0)
			{
				return;
			}
		}
		FUStBuffDispDesc buffDispDesc = DispInstance.BuffDispDesc;
		for (int i = 0; i < buffDispDesc.LeaveFX.Count; i++)
		{
			FUStFXSetting fUStFXSetting = buffDispDesc.LeaveFX[i];
			if (buffDispDesc.IsUseDispConfig == EGSYesNo.No)
			{
				PlayOneFX(DispInstance, fUStFXSetting, CanBeLooping: false);
			}
			else
			{
				PlayOneFXWithDispConfig(DispInstance, fUStFXSetting.PSPath);
			}
		}
		if (buffDispDesc.MaterialSetting.Count > 0)
		{
			AActor owner = GetOwner();
			for (int j = 0; j < buffDispDesc.MaterialSetting.Count; j++)
			{
				string path = buffDispDesc.MaterialSetting[j];
				BGWDataAsset_BuffSetCurveValueToMeshConfig bGWDataAsset_BuffSetCurveValueToMeshConfig = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<BGWDataAsset_BuffSetCurveValueToMeshConfig>(path, ELoadResourceType.SyncLoadAndCache);
				int notifyInstID = -(DispInstance.GetMaterialUniqueIndexBase() + j);
				bool needRecovery = bGWDataAsset_BuffSetCurveValueToMeshConfig.NeedRecovery;
				base.BUSEventCollection.Evt_OverForSetCurveValueToMesh.Invoke(notifyInstID, needRecovery);
				base.BUSEventCollection.Evt_OverForSetCurveValueToHair.Invoke(notifyInstID, needRecovery);
			}
		}
	}

	private void DoBuffDispAction(int BuffID, Action<FBuffDispInstance, int> PlayAction)
	{
		GetBuffDispInstanceByBuffID(BuffID, out var NormalDispInstance, out var SingleDispInstance, out var GroupDispInstance);
		if (NormalDispInstance != null)
		{
			PlayAction(NormalDispInstance, BuffID);
		}
		if (SingleDispInstance != null)
		{
			PlayAction(SingleDispInstance, BuffID);
		}
		if (GroupDispInstance != null)
		{
			PlayAction(GroupDispInstance, BuffID);
		}
	}

	private void PlayAlmostEndFX(int BuffID, int CasterResID)
	{
		if (BGW_GameDB.GetBuffDispDesc(OwnerResID, BuffID, CasterResID) != null)
		{
			ClearDispInstanceByBuffID(BuffID);
			DoBuffDispAction(BuffID, PlayAlmostEndFX);
		}
	}

	private void PlayAlmostEndFX(FBuffDispInstance DispInstance, int BuffID)
	{
		if (DispInstance.DispType == EBuffDispType.Group)
		{
			return;
		}
		FUStBuffDispDesc buffDispDesc = DispInstance.BuffDispDesc;
		foreach (FUStFXSetting item in buffDispDesc.AlmostLeaveFX)
		{
			if (buffDispDesc.IsUseDispConfig == EGSYesNo.No)
			{
				PlayOneFX(DispInstance, item, CanBeLooping: false);
			}
			else
			{
				PlayOneFXWithDispConfig(DispInstance, item.PSPath);
			}
		}
		if (buffDispDesc.MaterialSetting.Count > 0)
		{
			AActor owner = GetOwner();
			for (int i = 0; i < buffDispDesc.MaterialSetting.Count; i++)
			{
				string path = buffDispDesc.MaterialSetting[i];
				BGWDataAsset_BuffSetCurveValueToMeshConfig bGWDataAsset_BuffSetCurveValueToMeshConfig = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<BGWDataAsset_BuffSetCurveValueToMeshConfig>(path, ELoadResourceType.SyncLoadAndCache);
				int notifyInstID = -(DispInstance.GetMaterialUniqueIndexBase() + i);
				bool needRecovery = bGWDataAsset_BuffSetCurveValueToMeshConfig.NeedRecovery;
				base.BUSEventCollection.Evt_OverForSetCurveValueToMesh.Invoke(notifyInstID, needRecovery);
				base.BUSEventCollection.Evt_OverForSetCurveValueToHair.Invoke(notifyInstID, needRecovery);
			}
		}
	}

	private void OnBuffLayerChanged(EntitySharedRef RootCasterRef, int BuffID, int Layer_OldValue, int Layer_NewValue)
	{
		int unitResID_BuffDisp = GetUnitResID_BuffDisp(Owner);
		int unitResID_BuffDisp2 = GetUnitResID_BuffDisp(RootCasterRef);
		FUStBuffLayerDispDesc buffLayerDispDesc = BGW_GameDB.GetBuffLayerDispDesc(unitResID_BuffDisp, BuffID, unitResID_BuffDisp2);
		if (buffLayerDispDesc == null)
		{
			return;
		}
		Dictionary<int, FUStBuffLayerDispConfig> dictionary = new Dictionary<int, FUStBuffLayerDispConfig>();
		foreach (FUStBuffLayerDispConfig item in buffLayerDispDesc.Config)
		{
			if (!dictionary.ContainsKey(item.LayerIndex))
			{
				dictionary.Add(item.LayerIndex, item);
			}
		}
		GetNeedHandle_LayerList(BuffID, Layer_NewValue, dictionary, out var NeedRemoveLayer, out var NeedAddLayer);
		foreach (int item2 in NeedRemoveLayer)
		{
			int p = LayerDispMap[BuffID][item2];
			base.BUSEventCollection.Evt_RequestDestroyByFXRequestID.Invoke(p);
			LayerDispMap[BuffID].Remove(item2);
		}
		foreach (int item3 in NeedAddLayer)
		{
			FUStBuffLayerDispConfig fUStBuffLayerDispConfig = dictionary[item3];
			int value = SpawnFXByDispConfig(fUStBuffLayerDispConfig.DBCPath, EntitySharedRefFuncLib.Actor(RootCasterRef));
			if (!LayerDispMap.ContainsKey(BuffID))
			{
				LayerDispMap.Add(BuffID, new Dictionary<int, int>());
			}
			LayerDispMap[BuffID].Add(item3, value);
		}
	}

	private void GetNeedHandle_LayerList(int BuffID, int LayerIndex, Dictionary<int, FUStBuffLayerDispConfig> ConfigMap, out List<int> NeedRemoveLayer, out List<int> NeedAddLayer)
	{
		NeedAddLayer = new List<int>();
		NeedRemoveLayer = new List<int>();
		int num = -1;
		foreach (KeyValuePair<int, FUStBuffLayerDispConfig> item in ConfigMap)
		{
			if (item.Value.MixType == EBuffLayerDispMixType.Override && item.Value.LayerIndex <= LayerIndex)
			{
				num = item.Value.LayerIndex;
			}
		}
		Dictionary<int, int> value;
		bool flag = LayerDispMap.TryGetValue(BuffID, out value);
		if (flag)
		{
			foreach (int key in value.Keys)
			{
				if (key < num)
				{
					NeedRemoveLayer.Add(key);
				}
			}
			foreach (int key2 in value.Keys)
			{
				if (key2 > LayerIndex)
				{
					NeedRemoveLayer.Add(key2);
				}
			}
		}
		foreach (KeyValuePair<int, FUStBuffLayerDispConfig> item2 in ConfigMap)
		{
			if (item2.Key >= num && item2.Key <= LayerIndex && (!flag || !value.ContainsKey(item2.Key)))
			{
				if (item2.Value.MixType == EBuffLayerDispMixType.Override)
				{
					NeedAddLayer.Clear();
				}
				NeedAddLayer.Add(item2.Key);
			}
		}
	}

	private void OnBuffLayerDispClear(int BuffID)
	{
		if (!LayerDispMap.TryGetValue(BuffID, out var value))
		{
			return;
		}
		foreach (KeyValuePair<int, int> item in value)
		{
			base.BUSEventCollection.Evt_RequestDestroyByFXRequestID.Invoke(item.Value);
		}
		LayerDispMap.Remove(BuffID);
	}

	public int GetUnitResID_BuffDisp(AActor Unit)
	{
		BGUCharacterCS bGUCharacterCS = Unit as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			return bGUCharacterCS.GetResID();
		}
		return ((IBUC_MasterData)BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Unit))?.GetMasterResID() ?? (-1);
	}

	public int GetUnitResID_BuffDisp(EntitySharedRef entity)
	{
		return ((IBUC_ConfigInfoData)BGU_DataUtil.GetReadOnlyData<BUC_ConfigInfoData>(entity))?.ResID ?? ((IBUC_MasterData)BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(entity))?.GetMasterResID() ?? (-1);
	}

	private FBuffDispInstance CreateDispInstance(int CasterResID, EBuffDispType InDispType, int BuffID, int BuffDispGroupID, int BuffDispID)
	{
		FBuffDispInstance value = null;
		long num = FBuffDispInstance.GenerateInstanceID(BuffID, InDispType, BuffDispGroupID);
		if (BuffDispData.BuffDispInstances.TryGetValue(num, out value))
		{
			return value;
		}
		switch (InDispType)
		{
		case EBuffDispType.Buff:
		{
			FUStBuffDispDesc buffDispDesc2 = BGW_GameDB.GetBuffDispDesc(OwnerResID, BuffDispID, CasterResID);
			if (buffDispDesc2 != null)
			{
				value = new FBuffDispInstance
				{
					DispType = InDispType,
					BuffID = BuffID,
					BuffDispGroupID = 0,
					BuffDispDesc = buffDispDesc2,
					InstanceID = num
				};
			}
			break;
		}
		case EBuffDispType.SingleInGroup:
		{
			FUStBuffDispDesc buffDispDesc3 = BGW_GameDB.GetBuffDispDesc(OwnerResID, BuffDispID, CasterResID);
			if (buffDispDesc3 != null)
			{
				value = new FBuffDispInstance
				{
					DispType = InDispType,
					BuffID = BuffID,
					BuffDispGroupID = BuffDispGroupID,
					BuffDispDesc = buffDispDesc3,
					InstanceID = num
				};
			}
			break;
		}
		case EBuffDispType.Group:
		{
			FUStBuffDispDesc buffDispDesc = BGW_GameDB.GetBuffDispDesc(OwnerResID, BuffDispID, CasterResID);
			if (buffDispDesc != null)
			{
				value = new FBuffDispInstance
				{
					DispType = InDispType,
					BuffID = 0,
					BuffDispGroupID = BuffDispGroupID,
					BuffDispDesc = buffDispDesc,
					InstanceID = num
				};
			}
			break;
		}
		}
		if (value != null)
		{
			BuffDispData.BuffDispInstances[num] = value;
		}
		return value;
	}

	private void CreateBuffDispInstance(int BuffID, int CasterResID, out FBuffDispInstance NormalDispInstance, out IList<FBuffDispInstance> SingleDispInstanceList, out IList<FBuffDispInstance> GroupDispInstanceList)
	{
		NormalDispInstance = null;
		SingleDispInstanceList = new List<FBuffDispInstance>();
		GroupDispInstanceList = new List<FBuffDispInstance>();
		NormalDispInstance = CreateDispInstance(CasterResID, EBuffDispType.Buff, BuffID, 0, BuffID);
		List<int> buffDispGroup = BGW_GameDB.GetBuffDispGroup(BuffID);
		if (buffDispGroup == null || buffDispGroup.Count <= 0)
		{
			return;
		}
		foreach (int item in buffDispGroup)
		{
			FUStBuffDispGroupDesc buffDispGroupDesc = BGW_GameDB.GetBuffDispGroupDesc(item);
			if (buffDispGroupDesc == null)
			{
				continue;
			}
			BuffDispData.Buff2DispGroupMultiMap.Add(BuffID, item);
			FBuffDispInstance fBuffDispInstance = CreateDispInstance(CasterResID, EBuffDispType.SingleInGroup, BuffID, item, buffDispGroupDesc.SingleBuffDisp);
			if (fBuffDispInstance != null)
			{
				SingleDispInstanceList.Add(fBuffDispInstance);
			}
			FBuffDispInstance value = null;
			if (BuffDispData.DispGroupID2InstanceIDMap.TryGetValue(item, out var value2) && !BuffDispData.BuffDispInstances.TryGetValue(value2, out value))
			{
				BuffDispData.DispGroupID2InstanceIDMap.Remove(item);
			}
			if (value == null)
			{
				value = CreateDispInstance(CasterResID, EBuffDispType.Group, BuffID, item, buffDispGroupDesc.GroupBuffDisp);
				if (value != null)
				{
					BuffDispData.DispGroupID2InstanceIDMap[item] = value.InstanceID;
				}
			}
			if (value != null)
			{
				GroupDispInstanceList.Add(value);
			}
		}
	}

	private void GetBuffDispInstanceByBuffID(int BuffID, out FBuffDispInstance NormalDispInstance, out FBuffDispInstance SingleDispInstance, out FBuffDispInstance GroupDispInstance)
	{
		NormalDispInstance = null;
		SingleDispInstance = null;
		GroupDispInstance = null;
		long key = FBuffDispInstance.GenerateInstanceID(BuffID);
		BuffDispData.BuffDispInstances.TryGetValue(key, out NormalDispInstance);
		if (!BuffDispData.Buff2DispGroupMultiMap.TryGetValue(BuffID, out var value))
		{
			return;
		}
		foreach (int item in value)
		{
			long key2 = FBuffDispInstance.GenerateInstanceID(BuffID, EBuffDispType.SingleInGroup, item);
			BuffDispData.BuffDispInstances.TryGetValue(key2, out SingleDispInstance);
			if (BuffDispData.DispGroupID2InstanceIDMap.TryGetValue(item, out var value2))
			{
				BuffDispData.BuffDispInstances.TryGetValue(value2, out GroupDispInstance);
			}
		}
	}

	private void RemoveDispInstanceByBuffID(int BuffID)
	{
		long instanceID = FBuffDispInstance.GenerateInstanceID(BuffID);
		ClearDispInstance(instanceID, bRemove: true);
		if (!BuffDispData.Buff2DispGroupMultiMap.TryGetValue(BuffID, out var value))
		{
			return;
		}
		foreach (int item in value)
		{
			long instanceID2 = FBuffDispInstance.GenerateInstanceID(BuffID, EBuffDispType.SingleInGroup, item);
			ClearDispInstance(instanceID2, bRemove: true);
			if (BuffDispData.DispGroupID2InstanceIDMap.TryGetValue(item, out var value2))
			{
				ClearDispInstance(value2, bRemove: true);
			}
		}
	}

	private void ClearDispInstanceByBuffID(int BuffID)
	{
		long instanceID = FBuffDispInstance.GenerateInstanceID(BuffID);
		ClearDispInstance(instanceID, bRemove: false);
		if (!BuffDispData.Buff2DispGroupMultiMap.TryGetValue(BuffID, out var value))
		{
			return;
		}
		foreach (int item in value)
		{
			long instanceID2 = FBuffDispInstance.GenerateInstanceID(BuffID, EBuffDispType.SingleInGroup, item);
			ClearDispInstance(instanceID2, bRemove: false);
		}
	}

	private void ClearDispInstance(FBuffDispInstance DispInstance)
	{
		List<int> playingBuffDispConfigRequestIDs = DispInstance.PlayingBuffDispConfigRequestIDs;
		if (playingBuffDispConfigRequestIDs != null)
		{
			for (int i = 0; i < playingBuffDispConfigRequestIDs.Count; i++)
			{
				int p = playingBuffDispConfigRequestIDs[i];
				base.BUSEventCollection.Evt_RequestDestroyByFXRequestID.Invoke(p);
			}
			playingBuffDispConfigRequestIDs.Clear();
		}
		List<UFXSystemComponent> playingBuffFXs = DispInstance.PlayingBuffFXs;
		if (playingBuffFXs != null)
		{
			for (int j = 0; j < playingBuffFXs.Count; j++)
			{
				UFXSystemComponent uFXSystemComponent = playingBuffFXs[j];
				UParticleSystemComponent uParticleSystemComponent = uFXSystemComponent as UParticleSystemComponent;
				if (uParticleSystemComponent != null)
				{
					if (UBGUFunctionLibraryForCS.BGUGetParticleSystemIsLooping(uParticleSystemComponent.Template))
					{
						uParticleSystemComponent.ReleaseToPool();
					}
					continue;
				}
				UNiagaraComponent uNiagaraComponent = uFXSystemComponent as UNiagaraComponent;
				if (uNiagaraComponent != null)
				{
					uNiagaraComponent.Deactivate();
				}
			}
			playingBuffFXs.Clear();
		}
		List<BuffDispTickData> playingBuffTickDataList = DispInstance.PlayingBuffTickDataList;
		if (playingBuffTickDataList != null)
		{
			for (int k = 0; k < playingBuffTickDataList.Count; k++)
			{
				EndTickCurveParam(playingBuffTickDataList[k]);
			}
			playingBuffTickDataList.Clear();
		}
	}

	private void ClearDispInstance(long InstanceID, bool bRemove)
	{
		if (!BuffDispData.BuffDispInstances.TryGetValue(InstanceID, out var value))
		{
			return;
		}
		if (value.DispType == EBuffDispType.Group)
		{
			if (value.BuffsInGroup.Count != 0)
			{
				return;
			}
			if (bRemove)
			{
				BuffDispData.DispGroupID2InstanceIDMap.Remove(value.BuffDispGroupID);
			}
		}
		ClearDispInstance(value);
		if (bRemove)
		{
			BuffDispData.BuffDispInstances.Remove(InstanceID);
		}
	}

	private void OnRequestHideOldBuffDisp(bool bHide)
	{
		if (bHide)
		{
			BuffDispData.HiddenBuffDispInstances.Clear();
			BuffDispData.HiddenPendingBuffID.Clear();
			foreach (KeyValuePair<long, FBuffDispInstance> buffDispInstance in BuffDispData.BuffDispInstances)
			{
				TriggerHideBuffDispInstance(buffDispInstance.Value, bHide: true);
				BuffDispData.HiddenBuffDispInstances.Add(buffDispInstance.Key);
			}
			BuffDispData.HiddenPendingBuffID.AddRange(BuffDispData.HiddenPendingBuffID);
			return;
		}
		foreach (long hiddenBuffDispInstance in BuffDispData.HiddenBuffDispInstances)
		{
			if (BuffDispData.BuffDispInstances.TryGetValue(hiddenBuffDispInstance, out var value))
			{
				TriggerHideBuffDispInstance(value, bHide: false);
			}
		}
		BuffDispData.HiddenBuffDispInstances.Clear();
		BuffDispData.HiddenPendingBuffID.Clear();
	}

	private void TriggerHideBuffDispInstance(FBuffDispInstance DispInstance, bool bHide)
	{
		if (DispInstance == null)
		{
			return;
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(this);
		foreach (int playingBuffDispConfigRequestID in DispInstance.PlayingBuffDispConfigRequestIDs)
		{
			bUS_DispLibEventCollection.Evt_RequestSetDBCNiagaraVisibleState(playingBuffDispConfigRequestID, !bHide, 100);
			bUS_DispLibEventCollection.Evt_RequestSetDBCAudioMuteState(playingBuffDispConfigRequestID, !bHide);
			bUS_DispLibEventCollection.Evt_RequestSetDBCCameraShakeIntensityScale(playingBuffDispConfigRequestID, bHide ? 0f : 1f);
		}
	}
}
