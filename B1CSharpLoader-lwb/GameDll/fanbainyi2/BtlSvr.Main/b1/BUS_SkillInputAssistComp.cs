using System.Collections.Generic;
using b1.ECS;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_SkillInputAssistComp : UActorCompBaseCS
{
	private BUC_SkillInputAssistData SkillInputAssistData;

	private IBUC_SkillSelectHelperData SkillSelectHelperData;

	private IBUC_ChargeSkillData ChargeSkillData;

	private IBUC_SkillMappingData SkillMappingData;

	private IBUC_PlayerInputActionData PlayerInputActionData;

	public override void OnAttach()
	{
		SkillInputAssistData = RequireWritableData<BUC_SkillInputAssistData>();
		SkillSelectHelperData = RequireReadOnlyData<IBUC_SkillSelectHelperData, BUC_SkillSelectHelperData>();
		ChargeSkillData = RequireReadOnlyData<IBUC_ChargeSkillData, BUC_ChargeSkillData>();
		SkillMappingData = RequireReadOnlyData<IBUC_SkillMappingData, BUC_SkillMappingData>();
		PlayerInputActionData = RequireReadOnlyData<IBUC_PlayerInputActionData, BUC_PlayerInputActionData>();
		base.BUSEventCollection.Evt_SkillDragWillCancel += new Del_Void_Bool(OnSkillDragWillCancel);
		base.BUSEventCollection.Evt_CameraLockCleared += new Del_Void(OnCameraLockCleared);
		base.BUSEventCollection.Evt_TriggerInputSkillRelease += new Del_Void_Int(OnTriggerInputSkillRelease);
		base.BUSEventCollection.Evt_TriggerInputSkillSelect += new Del_Void_Int(OnTriggerInputSkillSelect);
		base.BUSEventCollection.Evt_ForceCancelSkillSelect += new Del_ForceCancelSkillSelect(OnForceCancelSkillSelect);
		base.BUSEventCollection.Evt_UnitSkillBreak += new Del_UnitSkillBreak(OnSkillBreak);
		base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnCastSkillSuccess);
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickInputSkillManualSelect();
		TickInputSkillAutoSelect();
		UpdateSkillSelectSuctionTarget(DeltaTime);
		TickInputSkillSelectSuction(DeltaTime);
		TickInputSkillSelectSwitchTarget();
		if (SkillInputAssistData.InputSkillSelectVec.Size() > 1f)
		{
			SkillInputAssistData.InputSkillSelectVec.Normalize();
		}
		TickSkillDrag();
	}

	protected virtual void UpdateSkillSelectSuctionTarget(float DeltaTime)
	{
		if (SkillInputAssistData.UpdateSuctionTargetTimer > 0f)
		{
			SkillInputAssistData.UpdateSuctionTargetTimer -= DeltaTime;
			return;
		}
		int inputSelectingSkillID = SkillInputAssistData.InputSelectingSkillID;
		if (inputSelectingSkillID == 0 || !SkillInputAssistData.bInputSkillManualSelect)
		{
			return;
		}
		AActor owner = GetOwner();
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(inputSelectingSkillID, owner);
		if (playerSkillCtrlDesc == null || playerSkillCtrlDesc.SkillSelectOpType != ESkillSelectOpType.Suction)
		{
			return;
		}
		SkillInputAssistData.SkillSelectSuctionTargetEntity = Entity.Null;
		List<ABGUCharacter> OutArray;
		switch (playerSkillCtrlDesc.SmartSelectShapeType)
		{
		case ESmartSelectShapeType.SssSector:
		case ESmartSelectShapeType.SssArrow:
		case ESmartSelectShapeType.SssRectangle:
		{
			float num = float.MaxValue;
			UBGUSelectUtil.SphereOverlapBGUCharacters(owner, BGUFuncLibActorTransformCS.BGUGetActorLocation(owner), playerSkillCtrlDesc.AttackRange, out OutArray);
			foreach (ABGUCharacter item in OutArray)
			{
				if (!(item == owner))
				{
					FVector2D unitRotateAimDir = new FVector2D((BGUFuncLibActorTransformCS.BGUGetActorLocation(item) - BGUFuncLibActorTransformCS.BGUGetActorLocation(owner)).GetSafeNormal());
					FVector2D unit2TargetDir = new FVector2D(SkillSelectHelperData.GetDesiredSkillDirection().GetSafeNormal());
					float rotateAngle2D = BGU_MoveUtil.GetRotateAngle2D(unitRotateAimDir, unit2TargetDir);
					if (rotateAngle2D < num && rotateAngle2D < 10f)
					{
						SkillInputAssistData.SkillSelectSuctionTargetEntity = ECSUtil.ToEntity(item);
						num = rotateAngle2D;
					}
				}
			}
			break;
		}
		case ESmartSelectShapeType.SssCircle:
		case ESmartSelectShapeType.SssArrowToCircle:
		{
			float num3 = float.MaxValue;
			UBGUSelectUtil.SphereOverlapBGUCharacters(owner, SkillSelectHelperData.GetDesiredSkillLocation(), playerSkillCtrlDesc.SelectShapeParam1, out OutArray);
			foreach (ABGUCharacter item2 in OutArray)
			{
				if (!(item2 == owner) && !(FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(owner), BGUFuncLibActorTransformCS.BGUGetActorLocation(item2)) > playerSkillCtrlDesc.AttackRange))
				{
					float num4 = FVector.Dist2D(SkillSelectHelperData.GetDesiredSkillLocation(), BGUFuncLibActorTransformCS.BGUGetActorLocation(item2));
					if (num4 < num3)
					{
						SkillInputAssistData.SkillSelectSuctionTargetEntity = ECSUtil.ToEntity(item2);
						num3 = num4;
					}
				}
			}
			break;
		}
		case ESmartSelectShapeType.SssShootUi:
		{
			APlayerCameraManager localPlayerCameraManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(owner);
			float num = float.MaxValue;
			UBGUSelectUtil.SphereOverlapBGUCharacters(owner, BGUFuncLibActorTransformCS.BGUGetActorLocation(owner), playerSkillCtrlDesc.AttackRange, out OutArray);
			foreach (ABGUCharacter item3 in OutArray)
			{
				if (!(item3 == owner))
				{
					FVector safeNormal = (BGUFuncLibActorTransformCS.BGUGetActorLocation(item3) - localPlayerCameraManager.GetCameraLocation()).GetSafeNormal();
					FVector forwardVector = localPlayerCameraManager.GetCameraRotation().GetForwardVector();
					float num2 = MathLib.DegAcos(FVector.DotProduct(safeNormal, forwardVector));
					if (num2 < num && num2 < 5f)
					{
						SkillInputAssistData.SkillSelectSuctionTargetEntity = ECSUtil.ToEntity(item3);
						num = num2;
					}
				}
			}
			break;
		}
		}
		SkillInputAssistData.UpdateSuctionTargetTimer = 0.2f;
	}

	protected virtual void TickInputSkillSelectSuction(float DeltaTime)
	{
		int inputSelectingSkillID = SkillInputAssistData.InputSelectingSkillID;
		if (inputSelectingSkillID == 0 || !SkillInputAssistData.bInputSkillManualSelect)
		{
			return;
		}
		AActor owner = GetOwner();
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(inputSelectingSkillID, owner);
		if (playerSkillCtrlDesc == null || playerSkillCtrlDesc.SkillSelectOpType != ESkillSelectOpType.Suction)
		{
			return;
		}
		AActor aActor = ECSUtil.ToActor(SkillInputAssistData.SkillSelectSuctionTargetEntity);
		if (aActor.IsNullOrDestroyed())
		{
			return;
		}
		switch (playerSkillCtrlDesc.SmartSelectShapeType)
		{
		case ESmartSelectShapeType.SssSector:
		case ESmartSelectShapeType.SssArrow:
		case ESmartSelectShapeType.SssRectangle:
		{
			FVector safeNormal2D = (BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(owner)).GetSafeNormal2D();
			FVector safeNormal2D2 = SkillSelectHelperData.GetDesiredSkillDirection().GetSafeNormal2D();
			if (!(BGU_MoveUtil.GetRotateAngle2D(new FVector2D(safeNormal2D2), new FVector2D(safeNormal2D)) <= 1f))
			{
				FRotator inRot = FMath.RInterpConstantTo(safeNormal2D2.Rotation(), safeNormal2D.Rotation(), DeltaTime, 30f);
				SkillInputAssistData.InputSkillSelectVec = CalcSkillSelectVecByRealVector(inputSelectingSkillID, inRot.GetForwardVector());
			}
			break;
		}
		case ESmartSelectShapeType.SssCircle:
		case ESmartSelectShapeType.SssArrowToCircle:
		{
			FVector RealVec = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor) - SkillSelectHelperData.GetDesiredSkillLocation();
			if (!(RealVec.Size2D() < 30f))
			{
				FVector2D fVector2D = CalcSkillSelectVecByRealVector(inputSelectingSkillID, in RealVec);
				fVector2D.Normalize();
				SkillInputAssistData.InputSkillSelectVec += fVector2D * 0.30000001192092896 * DeltaTime;
			}
			break;
		}
		case ESmartSelectShapeType.SssShootUi:
		{
			APlayerCameraManager localPlayerCameraManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(owner);
			base.BUSEventCollection.Evt_SetShootSuctionTargetDir.Invoke((BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor) - localPlayerCameraManager.GetCameraLocation()).GetSafeNormal());
			break;
		}
		case ESmartSelectShapeType.SssInCircle:
			break;
		}
	}

	protected virtual void TickInputSkillSelectSwitchTarget()
	{
		int inputSelectingSkillID = SkillInputAssistData.InputSelectingSkillID;
		if (inputSelectingSkillID != 0 && SkillInputAssistData.bInputSkillManualSelect)
		{
			AActor aActor = ECSExtension.ToActor(SkillInputAssistData.SkillSelectSwitchTargetEntity);
			if (!aActor.IsNullOrDestroyed())
			{
				FVector RealVec = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
				SkillInputAssistData.InputSkillSelectVec = CalcSkillSelectVecByRealVector(inputSelectingSkillID, in RealVec);
			}
		}
	}

	protected virtual void TickInputSkillAutoSelect()
	{
		if (SkillInputAssistData.InputSelectingSkillID == 0 || !SkillInputAssistData.bInputSkillAutoSelect)
		{
			return;
		}
		AActor owner = GetOwner();
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillInputAssistData.InputSelectingSkillID, owner);
		if (playerSkillCtrlDesc == null)
		{
			return;
		}
		UnitLockTargetInfo TargetInfo = BGUFunctionLibraryCS.BGUGetTargetInfo(owner);
		if (TargetInfo.LockTargetActor == null || TargetInfo.LockTargetWayType != ELockTargetWayType.Manual)
		{
			BGW_EffectTemplateList.Get(owner).GetSkillSelectTargetTemplate(playerSkillCtrlDesc.SmartSelectTargetType)?.GetBestTarget(owner, SkillInputAssistData.InputSelectingSkillID, out TargetInfo);
		}
		AActor lockTargetActor = TargetInfo.LockTargetActor;
		if (!(lockTargetActor != null))
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor);
		if (TargetInfo.LockTargetType == ELockTargetType.SkeletonSocket)
		{
			ACharacter aCharacter = lockTargetActor as ACharacter;
			if (aCharacter != null && aCharacter.Mesh != null)
			{
				fVector = aCharacter.Mesh.GetSocketLocation(new FName(TargetInfo.LockTargetSkeletonSocketName));
			}
		}
		FVector RealVec = fVector - BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
		float num = RealVec.Size();
		FVector safeNormal = RealVec.GetSafeNormal();
		float disRatio = FMath.Clamp(num / playerSkillCtrlDesc.AttackRange, 0f, 1f);
		base.BUSEventCollection.Evt_SkillDragByRealDirection.Invoke(SkillInputAssistData.InputSelectingSkillID, safeNormal, disRatio);
		SkillInputAssistData.InputSkillSelectVec = CalcSkillSelectVecByRealVector(SkillInputAssistData.InputSelectingSkillID, in RealVec);
		if (playerSkillCtrlDesc.SkillSelectOpType == ESkillSelectOpType.SwitchTarget)
		{
			SkillInputAssistData.SkillSelectSwitchTargetEntity = TargetInfo.LockTargetEntity;
		}
	}

	protected FVector2D CalcSkillSelectVecByRealVector(int SkillID, in FVector RealVec)
	{
		AActor owner = GetOwner();
		APlayerCameraManager localPlayerCameraManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(owner);
		FVector2D unit2TargetDir = new FVector2D(localPlayerCameraManager.GetCameraRotation().GetForwardVector());
		FVector zeroVector = FVector.ZeroVector;
		zeroVector.Y = -1f;
		float num = RealVec.Size2D();
		FVector2D unitRotateAimDir = new FVector2D(RealVec.GetSafeNormal2D());
		float num2 = BGU_MoveUtil.GetRotateAngle2D(unitRotateAimDir, unit2TargetDir);
		if (BGU_MoveUtil.IsRotateClockwise(unitRotateAimDir, unit2TargetDir))
		{
			num2 *= -1f;
		}
		FVector2D fVector2D = new FVector2D(MathLib.RotateAngleAxis(zeroVector, num2, FVector.UpVector));
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, owner);
		if (playerSkillCtrlDesc == null)
		{
			return FVector2D.ZeroVector;
		}
		fVector2D.Normalize();
		return fVector2D * (num / playerSkillCtrlDesc.AttackRange);
	}

	protected virtual void TickInputSkillManualSelect()
	{
		if (SkillInputAssistData.InputSelectingSkillID == 0)
		{
			return;
		}
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillInputAssistData.InputSelectingSkillID, GetOwner());
		if (playerSkillCtrlDesc == null || playerSkillCtrlDesc.SmartSelectShapeType == ESmartSelectShapeType.SssNone)
		{
			return;
		}
		if (playerSkillCtrlDesc.SmartSelectShapeType == ESmartSelectShapeType.SssShootUi)
		{
			SkillInputAssistData.bInputSkillManualSelect = true;
			SkillInputAssistData.bInputSkillAutoSelect = false;
		}
		else if (!SkillInputAssistData.bInputSkillManualSelect && IsHaveInput())
		{
			SkillInputAssistData.bInputSkillManualSelect = true;
			SkillInputAssistData.bInputSkillAutoSelect = false;
			if (playerSkillCtrlDesc.HasSkillWheel == EGSYesNo.Yes)
			{
				BGW_UIEventCollection.Get(GetOwner()).Evt_UI_InputSkillManualSelect(GetOwner(), SkillInputAssistData.InputSelectingSkillID);
			}
		}
	}

	protected virtual bool IsHaveInput()
	{
		return new FVector2D(PlayerInputActionData.AxisSkillDragX, PlayerInputActionData.AxisSkillDragY).Size() >= 0.03f;
	}

	protected virtual void TickSkillDrag()
	{
		if (SkillInputAssistData.bInputSkillManualSelect)
		{
			base.BUSEventCollection.Evt_SkillDrag.Invoke(SkillInputAssistData.InputSelectingSkillID, SkillInputAssistData.InputSkillSelectVec, SkillInputAssistData.InputSkillSelectVec.Size(), SkillInputAssistData.bSkillDragWillCancel);
		}
	}

	private void OnTriggerInputSkillSelect(int SkillID)
	{
		AActor owner = GetOwner();
		if (BGU_CommonUtil.CheckSkillCanCast(owner, SkillID, SkillID) != ECanCastSkillResult.CCSR_OK)
		{
			return;
		}
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, owner);
		if (skillSDesc == null)
		{
			return;
		}
		BGUFuncLibSelectTargetsCS.BGUSetShowAttackRange(owner, bShow: true, SkillID);
		SkillInputAssistData.InputSelectingSkillID = SkillID;
		SkillInputAssistData.bInputSkillManualSelect = false;
		SkillInputAssistData.TargetInfoBeforeInputSkill = new UnitLockTargetInfo();
		SkillInputAssistData.SkillSelectSuctionTargetEntity = Entity.Null;
		SkillInputAssistData.SkillSelectSwitchTargetEntity = Entity.Null;
		if (skillSDesc.SkillType == ESkillType.ChargeSkillBegin)
		{
			SkillInputAssistData.TargetInfoBeforeInputSkill = BGUFunctionLibraryCS.BGUGetTargetInfo(owner);
			BGUFunctionLibraryCS.BGUTrySmartCastSpell(owner, SkillID, null);
		}
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillInputAssistData.InputSelectingSkillID, owner);
		if (playerSkillCtrlDesc == null)
		{
			return;
		}
		if (playerSkillCtrlDesc.SmartSelectShapeType != ESmartSelectShapeType.SssNone)
		{
			SkillInputAssistData.bInputSkillAutoSelect = true;
		}
		foreach (int skillSelectBuff in playerSkillCtrlDesc.SkillSelectBuffList)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(skillSelectBuff, owner, owner, -1f, EBuffSourceType.SkillInputAssist);
		}
	}

	protected virtual void OnTriggerInputSkillRelease(int SkillID)
	{
		if (SkillInputAssistData.bSkillDragWillCancel)
		{
			TriggerCancelSkillSelect(SkillID);
			return;
		}
		AActor owner = GetOwner();
		if (SkillInputAssistData.InputSelectingSkillID != 0 && SkillInputAssistData.InputSelectingSkillID != SkillID && SkillInputAssistData.InputSelectingSkillID != SkillID)
		{
			return;
		}
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, owner);
		if (skillSDesc == null)
		{
			return;
		}
		if (skillSDesc.SkillType == ESkillType.ChargeSkillBegin && ChargeSkillData.IsCastingChargeSkill)
		{
			if (ChargeSkillData.CurrentBeginChargeSkillID == SkillID)
			{
				SkillInputAssistData.TargetInfoBeforeInputSkill = new UnitLockTargetInfo();
				base.BUSEventCollection.Evt_TriggerNextChargeSkillStage.Invoke(P1: false);
			}
			else
			{
				SkillInputAssistData.TargetInfoBeforeInputSkill = BGUFunctionLibraryCS.BGUGetTargetInfo(owner);
				base.BUSEventCollection.Evt_RequestSmartCastSkill.Invoke(SkillID, null);
			}
		}
		else
		{
			SkillInputAssistData.TargetInfoBeforeInputSkill = BGUFunctionLibraryCS.BGUGetTargetInfo(owner);
			base.BUSEventCollection.Evt_RequestSmartCastSkill.Invoke(SkillID, null);
		}
		OnEndSkillSelect();
	}

	private void TriggerCancelSkillSelect(int SkillID, bool bTriggerBySkillBreak = false)
	{
		AActor owner = GetOwner();
		if (SkillInputAssistData.InputSelectingSkillID != 0 && SkillInputAssistData.InputSelectingSkillID != SkillID && SkillInputAssistData.InputSelectingSkillID != SkillID)
		{
			return;
		}
		if (!bTriggerBySkillBreak)
		{
			FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, owner);
			if (skillSDesc == null)
			{
				return;
			}
			SkillInputAssistData.TargetInfoBeforeInputSkill = new UnitLockTargetInfo();
			if (skillSDesc.SkillType == ESkillType.ChargeSkillBegin && ChargeSkillData.IsCastingChargeSkill && ChargeSkillData.CurrentBeginChargeSkillID == SkillID)
			{
				base.BUSEventCollection.Evt_TriggerCancelChargeSkill.Invoke();
			}
		}
		OnEndSkillSelect();
	}

	protected virtual void OnEndSkillSelect()
	{
		AActor owner = GetOwner();
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillInputAssistData.InputSelectingSkillID, owner);
		if (playerSkillCtrlDesc != null)
		{
			foreach (int skillSelectBuff in playerSkillCtrlDesc.SkillSelectBuffList)
			{
				base.BUSEventCollection.Evt_BuffRemove.Invoke(skillSelectBuff, EBuffEffectTriggerType.None, 1);
			}
		}
		BGUFuncLibSelectTargetsCS.BGUSetShowAttackRange(owner, bShow: false, 0);
		base.BUSEventCollection.Evt_ResetAttackTracing.Invoke();
		base.BUSEventCollection.Evt_ResetSkillSelectHelper.Invoke();
		SkillInputAssistData.InputSelectingSkillID = 0;
		SkillInputAssistData.bInputSkillManualSelect = false;
		SkillInputAssistData.bInputSkillAutoSelect = false;
		SkillInputAssistData.SkillSelectSuctionTargetEntity = Entity.Null;
		SkillInputAssistData.SkillSelectSwitchTargetEntity = Entity.Null;
	}

	private void OnForceCancelSkillSelect(bool bCancelBySkillBreak = false)
	{
		if (SkillInputAssistData.InputSelectingSkillID != 0)
		{
			TriggerCancelSkillSelect(SkillInputAssistData.InputSelectingSkillID, bCancelBySkillBreak);
		}
	}

	private void OnSkillDragWillCancel(bool bWillCancel)
	{
		SkillInputAssistData.bSkillDragWillCancel = bWillCancel;
	}

	private void OnCameraLockCleared()
	{
		if (SkillInputAssistData.InputSelectingSkillID != 0)
		{
			FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillInputAssistData.InputSelectingSkillID, GetOwner());
			if (playerSkillCtrlDesc != null && playerSkillCtrlDesc.CancelSelectWhenCameraLockCleared != EGSYesNo.No)
			{
				OnForceCancelSkillSelect();
			}
		}
	}

	private void OnSkillBreak(int SkillID, string Reason)
	{
		OnForceCancelSkillSelect(bCancelBySkillBreak: true);
	}

	private void OnCastSkillSuccess(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		if (SkillInputAssistData.InputSelectingSkillID == 0)
		{
			return;
		}
		int num = MappingSkillID;
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(MappingSkillID, GetOwner());
		if (skillSDesc != null)
		{
			if ((skillSDesc.SkillType == ESkillType.ChargeSkillBegin || skillSDesc.SkillType == ESkillType.ChargeSkillEnd) && ChargeSkillData.IsCastingChargeSkill)
			{
				num = ChargeSkillData.CurrentBeginChargeSkillID;
			}
			if (SkillInputAssistData.InputSelectingSkillID != num)
			{
				OnForceCancelSkillSelect(bCancelBySkillBreak: true);
			}
		}
	}
}
