using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCPlayAdvanceNiagaraInfo : DBCFXInfoBase
{
	public FVector MinorPosWSOnSpawn;

	public FVector MinorPosWSLastFrame;

	public bool isAttach_RealAttach;

	public FRotator AttachedTargetRotatorOffset;

	public FVector Scale_SourceSetting;

	public float AttachSocketDistanceACC;

	public FVector LastTickAttachSocketLocation;

	public FRotator AttachSocketRotOnAttach;

	public DispLibAdvanceNiagaraDispLogicMode DispLogicMode;

	public DispLibAttachConstraintMode AttachConstraintMode;

	public FVector2D AttachConstraintValue;

	public FName RealAttachedTargetSocketName;

	public bool AttachedEmitter;

	public FName RealAttachedEmitterSocketName;

	public FVector AttachedEmitterLocationOffset;

	public FRotator AttachedEmitterRotationOffset;

	public FQuat AttachedEmitterRotationOffsetQuat;

	public bool SetSelfSKMeshParam;

	public bool SetMinorSKMeshParam;

	public bool UseExtraCustomParams;

	public List<BUC_DispLibUtil_NameAndScalar> SetScalarParam;

	public List<BUC_DispLibUtil_NameAndLColor> SetLColorParam;

	public List<BUC_DispLibUtil_NameAndScalarCurve> SetCurveScalarParam;

	public List<BUC_DispLibUtil_NameAndLColorCurve> SetCurveLColorParam;

	public List<BUC_DispLibUtil_NameAndVectorCurve> SetCurveV3Param;

	public BUC_DispLibDBC_PlayAdvanceNiagara SourceRequest { get; set; }

	public USceneComponent MinorDispOwnerComp { get; set; }

	public bool IS_MERGED_REQUEST { get; protected set; }

	public uint MergeMangerSystemTemplateUniqueID { get; protected set; }

	public float EndDispStageStartTime { get; set; }

	public DBCTransformParam DBCOverrideTransform_SourceSetting { get; protected set; }

	public void DBCInfoInit(float CurTime, uint _IdentityID, int _EventIndexInDA, uint _DBCDataAssetUniqueID, USceneComponent _SourceDispOwnerComp, BUC_DispLibDBC_PlayAdvanceNiagara _Request, USceneComponent _MinorDispOwnerComp, FVector _MinorPosWSOnSpawn, uint _ANID = 0u, uint _MontageUniqueID = 0u, DBCTransformParam _DBCOverrideTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), int OverrideDBCMergeNiagaraSetting = -1)
	{
		DBCInfoInit(_SourceDispOwnerComp);
		NGInstanceLifeState = DispLibDBCNiagaraInstanceState.WaitForSpawn;
		base.IdentityID = _IdentityID;
		base.EventIndexInDataAsset = _EventIndexInDA;
		DBCDataAssetUniqueID = _DBCDataAssetUniqueID;
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		SourceRequest = _Request;
		OffsetInLocalSpace = SourceRequest.OffsetInLocalSpace;
		AttachedTargetLocationOffset = SourceRequest.AttachedTargetLocationOffset;
		AttachedTargetRotatorOffset = SourceRequest.AttachedTargetRotationOffset;
		Scale_SourceSetting = SourceRequest.Scale;
		DBCOverrideTransform_SourceSetting = _DBCOverrideTransform;
		DBCOverrideTransform = _DBCOverrideTransform;
		MinorDispOwnerComp = _MinorDispOwnerComp;
		base.Template = SourceRequest.Template;
		base.OverrideMeshCompTagName = SourceRequest.OverrideMeshCompTagName;
		SnapGround = SourceRequest.SnapGround;
		SnapGroundRotationMode = SourceRequest.SnapGroundRotationMode;
		isAttach_SourceSetting = SourceRequest.AttachedTarget;
		if (DBCOverrideTransform.IsValid() && DBCOverrideTransform.AttachedTargetSocketName != FName.None)
		{
			AttachedTargetSocketName = DBCOverrideTransform.AttachedTargetSocketName;
		}
		else
		{
			AttachedTargetSocketName = SourceRequest.AttachedTargetSocketName;
		}
		base.FXAttachComp = base.SourceDispOwnerComp;
		if (base.OverrideMeshCompTagName != FName.None)
		{
			BUC_DispLibUnitRendererBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_DispLibUnitRendererBaseData>(base.SourceDispOwnerComp.GetOwner());
			if (readOnlyData != null && readOnlyData.GetFirstMatchMeshComp(base.OverrideMeshCompTagName, out var Result))
			{
				base.FXAttachComp = Result;
			}
		}
		if (_MinorPosWSOnSpawn == default(FVector) && !MinorDispOwnerComp.IsNullOrDestroyed())
		{
			MinorPosWSOnSpawn = MinorDispOwnerComp.GetSocketLocation(SourceRequest.AttachedEmitterSocketName);
		}
		else
		{
			MinorPosWSOnSpawn = _MinorPosWSOnSpawn;
		}
		MinorPosWSLastFrame = _MinorPosWSOnSpawn;
		PlayAtTime = CurTime + SourceRequest.Delay;
		GameAge = 0f;
		EndMode = SourceRequest.EndMode;
		if (EndMode == DispLibDBCEndMode.FixDuration)
		{
			EndAtTime = PlayAtTime + SourceRequest.Duration;
		}
		else
		{
			EndAtTime = -1f;
		}
		DelayTimeAfterStop = SourceRequest.DelayTimeAfterStop;
		if (EndMode == DispLibDBCEndMode.AutoRelease)
		{
			EndMode = DispLibDBCEndMode.FixDuration;
			EndAtTime = PlayAtTime + 8f;
		}
		if (SourceRequest.ForcePoolModeNone)
		{
			UEPoolMode = ENCPoolMethod.None;
		}
		else
		{
			UEPoolMode = DispLibFuncUtil.GetNCPoolMethodByDBCEndMode(EndMode);
		}
		isAttach_SourceSetting = SourceRequest.AttachedTarget;
		AttachedEmitter = SourceRequest.AttachedEmitter;
		AttachConstraintMode = SourceRequest.AttachConstraintMode;
		AttachConstraintValue = SourceRequest.AttachConstraintValue;
		bool flag = AttachConstraintValue.X <= 0f;
		switch (AttachConstraintMode)
		{
		case DispLibAttachConstraintMode.FixedTime:
			if (flag)
			{
				AttachConstraintValue.X = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCAttachConstraintValue_FixedTime;
			}
			break;
		case DispLibAttachConstraintMode.RootVelocityThreshold:
			if (flag)
			{
				AttachConstraintValue.X = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCAttachConstraintValue_RootVelocity;
			}
			AttachConstraintValue.X *= AttachConstraintValue.X;
			break;
		case DispLibAttachConstraintMode.AttachedSocketVelocityThreshold:
			if (flag)
			{
				AttachConstraintValue.X = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCAttachConstraintValue_AttachedSocketVelocity;
			}
			AttachConstraintValue.X *= AttachConstraintValue.X;
			break;
		case DispLibAttachConstraintMode.AttachedSocketVelocityAndTorsionThreshold:
			if (flag)
			{
				AttachConstraintValue = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion;
			}
			AttachConstraintValue.X *= AttachConstraintValue.X;
			break;
		case DispLibAttachConstraintMode.AttachedSocketDistanceACCAndTorsionThreshold:
			if (flag)
			{
				AttachConstraintValue = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion;
			}
			AttachConstraintValue.X *= AttachConstraintValue.X;
			break;
		}
		FName attachedTargetSocketName = SourceRequest.AttachedTargetSocketName;
		DispLibSocketSearchMode targetSocketSearchMode = SourceRequest.TargetSocketSearchMode;
		if (targetSocketSearchMode == DispLibSocketSearchMode.OnlyOriginSocket)
		{
			RealAttachedTargetSocketName = attachedTargetSocketName;
		}
		else
		{
			bool flag2 = false;
			if (targetSocketSearchMode == DispLibSocketSearchMode.OriginSocketPrecedence && (attachedTargetSocketName == FName.None || base.FXAttachComp.DoesSocketExist(attachedTargetSocketName)))
			{
				flag2 = true;
				RealAttachedTargetSocketName = attachedTargetSocketName;
			}
			if (!flag2)
			{
				BUC_DispLibDBCBaseData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_DispLibDBCBaseData>(base.SourceDispOwnerComp.GetOwner());
				if (readOnlyData2 != null && readOnlyData2.InterfaceSockets.TryGetValue(attachedTargetSocketName, out var value))
				{
					RealAttachedTargetSocketName = value;
				}
			}
		}
		FName fName = (RealAttachedEmitterSocketName = SourceRequest.AttachedEmitterSocketName);
		DispLibSocketSearchMode emitterSocketSearchMode = SourceRequest.EmitterSocketSearchMode;
		if (emitterSocketSearchMode == DispLibSocketSearchMode.OnlyOriginSocket)
		{
			RealAttachedEmitterSocketName = fName;
		}
		else if (!MinorDispOwnerComp.IsNullOrDestroyed())
		{
			bool flag3 = false;
			if (emitterSocketSearchMode == DispLibSocketSearchMode.OriginSocketPrecedence && (fName == FName.None || MinorDispOwnerComp.DoesSocketExist(fName)))
			{
				flag3 = true;
				RealAttachedEmitterSocketName = fName;
			}
			if (!flag3)
			{
				BUC_DispLibDBCBaseData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BUC_DispLibDBCBaseData>(MinorDispOwnerComp.GetOwner());
				if (readOnlyData3 != null && readOnlyData3.InterfaceSockets.TryGetValue(fName, out var value2))
				{
					RealAttachedEmitterSocketName = value2;
				}
			}
		}
		AttachedEmitterLocationOffset = SourceRequest.AttachedEmitterLocationOffset;
		AttachedEmitterRotationOffset = SourceRequest.AttachedEmitterRotationOffset;
		AttachedEmitterRotationOffsetQuat = new FQuat(AttachedEmitterRotationOffset);
		SetSelfSKMeshParam = SourceRequest.SetSelfSKMeshParam;
		SetMinorSKMeshParam = SourceRequest.SetMinorSKMeshParam;
		UseExtraCustomParams = SourceRequest.UseExtraCustomParams;
		SetScalarParam = SourceRequest.SetScalarParam;
		SetLColorParam = SourceRequest.SetColorParam;
		SetCurveScalarParam = SourceRequest.SetCurveScalarParam;
		SetCurveLColorParam = SourceRequest.SetCurveLColorParam;
		SetCurveV3Param = SourceRequest.SetCurveV3Param;
		DispLogicMode = SourceRequest.DispLogicMode;
		PausePriority = SourceRequest.PausePriority;
		PauseMode = SourceRequest.PauseMode;
		EndStagePriority = SourceRequest.EndStagePriority;
		if (DispLogicMode == DispLibAdvanceNiagaraDispLogicMode.MatchingToNearestSocket)
		{
			USkinnedMeshComponent uSkinnedMeshComponent = base.SourceDispOwnerComp as USkinnedMeshComponent;
			if (uSkinnedMeshComponent != null)
			{
				FVector location = DBCOverrideTransform.Transform.GetLocation();
				RealAttachedTargetSocketName = uSkinnedMeshComponent.FindClosestBone_K2(location, out var _);
				FTransform fTransform = BGUFuncLibComponentCS.BGUGetSocketTransform(uSkinnedMeshComponent, ref RealAttachedTargetSocketName);
				LastTickAttachSocketLocation = fTransform.GetLocation();
				AttachSocketRotOnAttach = fTransform.Rotator();
				FTransform relativeTransform = fTransform.GetRelativeTransform(DBCOverrideTransform.Transform);
				DBCOverrideTransform = new DBCTransformParam(relativeTransform, DBCTransformType.OffsetInSocketLocalSpace, DBCTransformOverrdieAttachType.NoOverrdie, _AddDataAssetOffset: false);
			}
			else
			{
				UMeshComponent uMeshComponent = base.SourceDispOwnerComp as UMeshComponent;
				if (uMeshComponent != null)
				{
					RealAttachedTargetSocketName = FName.None;
					FTransform fTransform2 = BGUFuncLibComponentCS.BGUGetSocketTransform(uMeshComponent, ref RealAttachedTargetSocketName);
					LastTickAttachSocketLocation = fTransform2.GetLocation();
					AttachSocketRotOnAttach = fTransform2.Rotator();
					FTransform relativeTransform2 = fTransform2.GetRelativeTransform(DBCOverrideTransform.Transform);
					DBCOverrideTransform = new DBCTransformParam(relativeTransform2, DBCTransformType.OffsetInSocketLocalSpace, DBCTransformOverrdieAttachType.NoOverrdie, _AddDataAssetOffset: false);
				}
			}
		}
		if (DispLogicMode == DispLibAdvanceNiagaraDispLogicMode.DBCMergedSystem)
		{
			if (OverrideDBCMergeNiagaraSetting == 0)
			{
				IS_MERGED_REQUEST = false;
			}
			else
			{
				IS_MERGED_REQUEST = SourceRequest.MergedSettings.Enable;
			}
			if (IS_MERGED_REQUEST && !SourceRequest.MergedSettings.MergeMangerSystem.IsNullOrDestroyed())
			{
				MergeMangerSystemTemplateUniqueID = SourceRequest.MergedSettings.MergeMangerSystem.GetUniqueID();
			}
			else
			{
				IS_MERGED_REQUEST = false;
				DispLogicMode = DispLibAdvanceNiagaraDispLogicMode.Custom;
			}
		}
		MetaString = SourceRequest.MetaString;
		SpawnCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(SpawnCallback, CallbackParams.SpawnCallback);
		OverTickCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(OverTickCallback, CallbackParams.OverTickCallback);
		PreEndCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreEndCallback, CallbackParams.PreEndCallback);
		PreDestroyCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreDestroyCallback, CallbackParams.PreDestroyCallback);
	}

	public bool DBCInfoInitFromAbstractEvent(DBCAbstractEventInfo AbstractEvent, int _EventIndex, uint _DBCDataAssetUniqueID, float CurTime, BUC_DispLibDBC_PlayAdvanceNiagara _RealRequest, int OverrideDBCMergeNiagaraSetting = -1)
	{
		SourceRequest = _RealRequest;
		GameAge = AbstractEvent.AbstractEventGameAge;
		PlayAtTime = AbstractEvent.AbstractEventStartAtTime + SourceRequest.Delay;
		base.ForceNiagaraVisibleState = AbstractEvent.ForceNiagaraVisibleState;
		ForceChangeVisibleStateDEFPriority = SourceRequest.ForceChangeVisibleStateDEFPriority;
		if (base.ForceNiagaraVisibleState != -1 && ForceChangeVisibleStateDEFPriority > AbstractEvent.ForceNiagaraVisibleStateRequestATKPriority)
		{
			base.ForceNiagaraVisibleState = -1;
		}
		EndMode = SourceRequest.EndMode;
		if (EndMode == DispLibDBCEndMode.FixDuration)
		{
			EndAtTime = PlayAtTime + SourceRequest.Duration;
		}
		else
		{
			EndAtTime = -1f;
		}
		if (EndMode == DispLibDBCEndMode.AutoRelease)
		{
			EndMode = DispLibDBCEndMode.FixDuration;
			EndAtTime = PlayAtTime + 8f;
		}
		if (EndMode == DispLibDBCEndMode.FixDuration && CurTime > EndAtTime)
		{
			return false;
		}
		base.IsPause = false;
		base.PauseAtTime = 0f;
		base.PauseRequestOperationCounter = 0;
		DBCInfoInit(AbstractEvent.SourceDispOwnerComp);
		NGInstanceLifeState = DispLibDBCNiagaraInstanceState.WaitForSpawn;
		base.IdentityID = AbstractEvent.IdentityID;
		base.EventIndexInDataAsset = _EventIndex;
		DBCDataAssetUniqueID = _DBCDataAssetUniqueID;
		base.AnimNotifyUniqueID = AbstractEvent.AnimNotifyUniqueID;
		base.MontageUniqueID = AbstractEvent.MontageUniqueID;
		DBCOverrideTransform_SourceSetting = AbstractEvent.DBCOverrideTransform;
		DBCOverrideTransform = AbstractEvent.DBCOverrideTransform;
		MinorDispOwnerComp = AbstractEvent.MinorDispOwnerComp;
		OffsetInLocalSpace = SourceRequest.OffsetInLocalSpace;
		AttachedTargetLocationOffset = SourceRequest.AttachedTargetLocationOffset;
		AttachedTargetRotatorOffset = SourceRequest.AttachedTargetRotationOffset;
		Scale_SourceSetting = SourceRequest.Scale;
		base.Template = SourceRequest.Template;
		base.OverrideMeshCompTagName = SourceRequest.OverrideMeshCompTagName;
		SnapGround = SourceRequest.SnapGround;
		SnapGroundRotationMode = SourceRequest.SnapGroundRotationMode;
		isAttach_SourceSetting = SourceRequest.AttachedTarget;
		if (DBCOverrideTransform.IsValid() && DBCOverrideTransform.AttachedTargetSocketName != FName.None)
		{
			AttachedTargetSocketName = DBCOverrideTransform.AttachedTargetSocketName;
		}
		else
		{
			AttachedTargetSocketName = SourceRequest.AttachedTargetSocketName;
		}
		base.FXAttachComp = base.SourceDispOwnerComp;
		if (base.OverrideMeshCompTagName != FName.None)
		{
			BUC_DispLibUnitRendererBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_DispLibUnitRendererBaseData>(base.SourceDispOwnerComp.GetOwner());
			if (readOnlyData != null && readOnlyData.GetFirstMatchMeshComp(base.OverrideMeshCompTagName, out var Result))
			{
				base.FXAttachComp = Result;
			}
		}
		if (AbstractEvent.MinorPosWSOnSpawn == default(FVector) && !MinorDispOwnerComp.IsNullOrDestroyed())
		{
			MinorPosWSOnSpawn = MinorDispOwnerComp.GetSocketLocation(SourceRequest.AttachedEmitterSocketName);
		}
		else
		{
			MinorPosWSOnSpawn = AbstractEvent.MinorPosWSOnSpawn;
		}
		MinorPosWSLastFrame = AbstractEvent.MinorPosWSOnSpawn;
		DelayTimeAfterStop = SourceRequest.DelayTimeAfterStop;
		if (SourceRequest.ForcePoolModeNone)
		{
			UEPoolMode = ENCPoolMethod.None;
		}
		else
		{
			UEPoolMode = DispLibFuncUtil.GetNCPoolMethodByDBCEndMode(EndMode);
		}
		isAttach_SourceSetting = SourceRequest.AttachedTarget;
		AttachedEmitter = SourceRequest.AttachedEmitter;
		AttachConstraintMode = SourceRequest.AttachConstraintMode;
		AttachConstraintValue = SourceRequest.AttachConstraintValue;
		bool flag = AttachConstraintValue.X <= 0f;
		switch (AttachConstraintMode)
		{
		case DispLibAttachConstraintMode.FixedTime:
			if (flag)
			{
				AttachConstraintValue.X = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCAttachConstraintValue_FixedTime;
			}
			break;
		case DispLibAttachConstraintMode.RootVelocityThreshold:
			if (flag)
			{
				AttachConstraintValue.X = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCAttachConstraintValue_RootVelocity;
			}
			AttachConstraintValue.X *= AttachConstraintValue.X;
			break;
		case DispLibAttachConstraintMode.AttachedSocketVelocityThreshold:
			if (flag)
			{
				AttachConstraintValue.X = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCAttachConstraintValue_AttachedSocketVelocity;
			}
			AttachConstraintValue.X *= AttachConstraintValue.X;
			break;
		case DispLibAttachConstraintMode.AttachedSocketVelocityAndTorsionThreshold:
			if (flag)
			{
				AttachConstraintValue = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCAttachConstraintValue_AttachedSocketVelocityAndTorsion;
			}
			AttachConstraintValue.X *= AttachConstraintValue.X;
			break;
		case DispLibAttachConstraintMode.AttachedSocketDistanceACCAndTorsionThreshold:
			if (flag)
			{
				AttachConstraintValue = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCAttachConstraintValue_AttachedSocketDistanceACCAndTorsion;
			}
			AttachConstraintValue.X *= AttachConstraintValue.X;
			break;
		}
		FName attachedTargetSocketName = SourceRequest.AttachedTargetSocketName;
		DispLibSocketSearchMode targetSocketSearchMode = SourceRequest.TargetSocketSearchMode;
		if (targetSocketSearchMode == DispLibSocketSearchMode.OnlyOriginSocket)
		{
			RealAttachedTargetSocketName = attachedTargetSocketName;
		}
		else
		{
			bool flag2 = false;
			if (targetSocketSearchMode == DispLibSocketSearchMode.OriginSocketPrecedence && (attachedTargetSocketName == FName.None || base.FXAttachComp.DoesSocketExist(attachedTargetSocketName)))
			{
				flag2 = true;
				RealAttachedTargetSocketName = attachedTargetSocketName;
			}
			if (!flag2)
			{
				BUC_DispLibDBCBaseData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_DispLibDBCBaseData>(base.SourceDispOwnerComp.GetOwner());
				if (readOnlyData2 != null && readOnlyData2.InterfaceSockets.TryGetValue(attachedTargetSocketName, out var value))
				{
					RealAttachedTargetSocketName = value;
				}
			}
		}
		FName fName = (RealAttachedEmitterSocketName = SourceRequest.AttachedEmitterSocketName);
		DispLibSocketSearchMode emitterSocketSearchMode = SourceRequest.EmitterSocketSearchMode;
		if (emitterSocketSearchMode == DispLibSocketSearchMode.OnlyOriginSocket)
		{
			RealAttachedEmitterSocketName = fName;
		}
		else if (!MinorDispOwnerComp.IsNullOrDestroyed())
		{
			bool flag3 = false;
			if (emitterSocketSearchMode == DispLibSocketSearchMode.OriginSocketPrecedence && (fName == FName.None || MinorDispOwnerComp.DoesSocketExist(fName)))
			{
				flag3 = true;
				RealAttachedEmitterSocketName = fName;
			}
			if (!flag3)
			{
				BUC_DispLibDBCBaseData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BUC_DispLibDBCBaseData>(MinorDispOwnerComp.GetOwner());
				if (readOnlyData3 != null && readOnlyData3.InterfaceSockets.TryGetValue(fName, out var value2))
				{
					RealAttachedEmitterSocketName = value2;
				}
			}
		}
		AttachedEmitterLocationOffset = SourceRequest.AttachedEmitterLocationOffset;
		AttachedEmitterRotationOffset = SourceRequest.AttachedEmitterRotationOffset;
		AttachedEmitterRotationOffsetQuat = new FQuat(AttachedEmitterRotationOffset);
		SetSelfSKMeshParam = SourceRequest.SetSelfSKMeshParam;
		SetMinorSKMeshParam = SourceRequest.SetMinorSKMeshParam;
		UseExtraCustomParams = SourceRequest.UseExtraCustomParams;
		SetScalarParam = SourceRequest.SetScalarParam;
		SetLColorParam = SourceRequest.SetColorParam;
		SetCurveScalarParam = SourceRequest.SetCurveScalarParam;
		SetCurveLColorParam = SourceRequest.SetCurveLColorParam;
		SetCurveV3Param = SourceRequest.SetCurveV3Param;
		DispLogicMode = SourceRequest.DispLogicMode;
		PausePriority = SourceRequest.PausePriority;
		PauseMode = SourceRequest.PauseMode;
		EndStagePriority = SourceRequest.EndStagePriority;
		ForceChangeVisibleStateDEFPriority = SourceRequest.ForceChangeVisibleStateDEFPriority;
		if (DispLogicMode == DispLibAdvanceNiagaraDispLogicMode.MatchingToNearestSocket)
		{
			USkinnedMeshComponent uSkinnedMeshComponent = base.SourceDispOwnerComp as USkinnedMeshComponent;
			if (uSkinnedMeshComponent != null)
			{
				FVector location = DBCOverrideTransform.Transform.GetLocation();
				RealAttachedTargetSocketName = uSkinnedMeshComponent.FindClosestBone_K2(location, out var _);
				FTransform relativeTransform = BGUFuncLibComponentCS.BGUGetSocketTransform(uSkinnedMeshComponent, ref RealAttachedTargetSocketName).GetRelativeTransform(DBCOverrideTransform.Transform);
				DBCOverrideTransform = new DBCTransformParam(relativeTransform, DBCTransformType.OffsetInSocketLocalSpace, DBCTransformOverrdieAttachType.NoOverrdie, _AddDataAssetOffset: false);
			}
			else
			{
				UMeshComponent uMeshComponent = base.SourceDispOwnerComp as UMeshComponent;
				if (uMeshComponent != null)
				{
					RealAttachedTargetSocketName = FName.None;
					FTransform relativeTransform2 = uMeshComponent.GetWorldTransform().GetRelativeTransform(DBCOverrideTransform.Transform);
					DBCOverrideTransform = new DBCTransformParam(relativeTransform2, DBCTransformType.OffsetInSocketLocalSpace, DBCTransformOverrdieAttachType.NoOverrdie, _AddDataAssetOffset: false);
				}
			}
		}
		if (DispLogicMode == DispLibAdvanceNiagaraDispLogicMode.DBCMergedSystem)
		{
			if (OverrideDBCMergeNiagaraSetting == 0)
			{
				IS_MERGED_REQUEST = false;
			}
			else
			{
				IS_MERGED_REQUEST = SourceRequest.MergedSettings.Enable;
			}
			if (IS_MERGED_REQUEST)
			{
				if (!SourceRequest.MergedSettings.MergeMangerSystem.IsNullOrDestroyed())
				{
					MergeMangerSystemTemplateUniqueID = SourceRequest.MergedSettings.MergeMangerSystem.GetUniqueID();
				}
				else
				{
					IS_MERGED_REQUEST = false;
					DispLogicMode = DispLibAdvanceNiagaraDispLogicMode.Custom;
				}
			}
		}
		MetaString = SourceRequest.MetaString;
		SpawnCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(SpawnCallback, AbstractEvent.SpawnCallback);
		OverTickCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(OverTickCallback, AbstractEvent.OverTickCallback);
		PreEndCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreEndCallback, AbstractEvent.PreEndCallback);
		PreDestroyCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreDestroyCallback, AbstractEvent.PreDestroyCallback);
		return true;
	}

	public override bool CheckHasTag(FName Tag)
	{
		UNiagaraComponent uNiagaraComponent = base.NiagaraComponent.Get();
		if (uNiagaraComponent.IsNullOrDestroyed())
		{
			return false;
		}
		if (!uNiagaraComponent.ComponentHasTag(Tag))
		{
			return MetaString == Tag;
		}
		return true;
	}
}
