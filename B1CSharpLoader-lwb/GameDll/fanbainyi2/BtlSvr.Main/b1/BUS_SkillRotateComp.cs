using System.Collections.Generic;
using b1.ECS;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_SkillRotateComp : UActorCompBaseCS
{
	protected APlayerCameraManager PlayerCameraManager;

	private IBUC_ControllerData ControllerData;

	private IBUC_ComboCacheData ComboCacheData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_SkillSelectHelperData SkillSelectHelperData;

	private IBUC_SkillInputAssistData SkillInputAssistData;

	private IBUC_QTEData QTEData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_PlayerInputConfigData PlayerInputConfigData;

	private IBUC_PlayerInputActionData PlayerInputActionData;

	private b1.IBUC_SmartCastSkillData SmartCastSkillData;

	private IBPC_InputData InputData;

	public override void OnAttach()
	{
		ControllerData = RequireReadOnlyData<IBUC_ControllerData, BUC_ControllerData>();
		ComboCacheData = RequireReadOnlyData<IBUC_ComboCacheData, b1.BUC_ComboCacheData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		SkillSelectHelperData = RequireReadOnlyData<IBUC_SkillSelectHelperData, BUC_SkillSelectHelperData>();
		SkillInputAssistData = RequireReadOnlyData<IBUC_SkillInputAssistData, BUC_SkillInputAssistData>();
		QTEData = RequireReadOnlyData<IBUC_QTEData, BUC_QTEData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		PlayerInputConfigData = RequireReadOnlyData<IBUC_PlayerInputConfigData, BUC_PlayerInputConfigData>();
		PlayerInputActionData = RequireReadOnlyData<IBUC_PlayerInputActionData, BUC_PlayerInputActionData>();
		SmartCastSkillData = RequireReadOnlyData<b1.IBUC_SmartCastSkillData, b1.BUC_SmartCastSkillData>();
		InputData = RequireReadOnlyControlledPlayerControlData<IBPC_InputData, BPC_InputData>();
		base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnSkillRotate);
		base.BUSEventCollection.Evt_RotateToTargetSvr += new Del_Void_Float(OnRotateToTargetSvr);
	}

	public void OnRotateToTargetSvr(float TurnSpeed)
	{
		UnitLockTargetInfo TargetInfo = TargetInfoData.GetTargetInfo();
		if (TargetInfo.LockTargetEntity != Entity.Null)
		{
			RotateToTarget(in TargetInfo, TurnSpeed);
		}
		else
		{
			base.BUSEventCollection.Evt_FinishRotateMoveMode.Invoke();
		}
	}

	public override void OnBeginPlay()
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter != null)
		{
			APlayerController aPlayerController = aCharacter.GetController() as APlayerController;
			if (aPlayerController != null)
			{
				PlayerCameraManager = aPlayerController.PlayerCameraManager;
			}
		}
	}

	protected virtual void OnSkillRotate(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
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
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(MappingSkillID, aCharacter);
		if (skillSDesc == null || skillSDesc.SkillRotateType == ESkillRotateType.None || (skillSDesc.OnlyPlayerControlledSkillRotate == EGSYesNo.Yes && !ControllerData.GetIsLocalControlled()))
		{
			return;
		}
		FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(BGU_DataUtil.GetActorResID(aCharacter), Owner);
		FGSMeleeAutoLockSetting fGSMeleeAutoLockSetting = BGUFuncLibSkillCS.BGUGetCurrentMeleeAutoLockSetting(owner, MappingSkillID);
		UnitLockTargetInfo TargetInfo = TargetInfoData.GetTargetInfo();
		if (SkillSelectHelperData.GetDesiredSkillDirection().Size() > 0f)
		{
			RotateToDesiredSkillDirection();
		}
		else if (skillSDesc.SkillRotateType == ESkillRotateType.MeleeRotate)
		{
			if (TargetInfo.LockTargetWayType == ELockTargetWayType.Manual && TargetInfo.LockTargetEntity != Entity.Null)
			{
				RotateToTarget(in TargetInfo, 0f);
				return;
			}
			float inputValue = InputData.GetInputValue(GSBattleActionEn.MoveForward);
			float inputValue2 = InputData.GetInputValue(GSBattleActionEn.MoveSideways);
			bool flag = (playerCommDesc != null && playerCommDesc.AutoLockIgnoreInput == EGSYesNo.Yes) || (SmartCastSkillData != null && SmartCastSkillData.bOnlyAutoLockTarget) || GSGameplayCVar.CVar_ForceEnableOnlyAutoLockTarget.GetValueInGameThread() != 0;
			FRotator cameraRotation = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(Owner).GetCameraRotation();
			FVector b = new FVector(inputValue, inputValue2, 0.0).GetSafeNormal2D().RotateAngleAxis(cameraRotation.Yaw, FVector.UpVector);
			FVector safeNormal2D = (BGUFuncLibAICS.BGUAIGetTargetInfoRealLockPoint(TargetInfo) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner)).GetSafeNormal2D();
			float num = 0.7f;
			if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.PlayerAutoLockInputDegreeThreshold, out var ConfigInfo))
			{
				num = FMath.Cos(FMath.DegreesToRadians(ConfigInfo.FloatValue));
			}
			if (safeNormal2D.Size() > 0f && !flag)
			{
				flag = safeNormal2D.CosineAngle2D(b) > num;
			}
			bool flag2 = !(TargetInfo.LockTargetEntity == Entity.Null);
			if ((FMath.Abs(inputValue) > 0.3f || FMath.Abs(inputValue2) > 0.3f) && !(flag2 && flag))
			{
				base.BUSEventCollection.Evt_ClearTargetInfo.Invoke();
				OnInputRotate(fGSMeleeAutoLockSetting.TurnSpeed);
			}
			else
			{
				base.BUSEventCollection.Evt_RotateToTargetSvr.Invoke(fGSMeleeAutoLockSetting.TurnSpeed);
			}
		}
		else if (skillSDesc.SkillRotateType == ESkillRotateType.Roll)
		{
			OnInputRotate(PlayerInputConfigData.GSCameraAutoLockSetting.RollSkillTurnSpeed, ESkillRotateType.Roll);
		}
		else if (skillSDesc.SkillRotateType == ESkillRotateType.Qteprepare)
		{
			ABGUCharacter aBGUCharacter = QTEData.GetQTETarget() as ABGUCharacter;
			if (aBGUCharacter != null)
			{
				base.BUSEventCollection.Evt_SkillRotateTraceActor.Invoke(aBGUCharacter, fGSMeleeAutoLockSetting.TurnSpeed);
			}
		}
		else if (skillSDesc.SkillRotateType == ESkillRotateType.RotateToCamera)
		{
			OnSkillRotateToCamera(PlayerInputConfigData.GSCameraAutoLockSetting.RotateToCameraTurnSpeed);
		}
		else if (skillSDesc.SkillRotateType == ESkillRotateType.RotateToTargetInstantly)
		{
			AActor lockTargetActor = TargetInfo.LockTargetActor;
			if (!lockTargetActor.IsNullOrDestroyed())
			{
				RotateToTargetInstantly(BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor));
			}
			else if (PlayerInputActionData.IsWithInputMoving)
			{
				float inputValue3 = InputData.GetInputValue(GSBattleActionEn.MoveForward);
				float inputValue4 = InputData.GetInputValue(GSBattleActionEn.MoveSideways);
				FRotator moveYawDirection = BGUFunctionLibraryCS.GetMoveYawDirection(aCharacter.GetController(), PlayerCameraManager);
				moveYawDirection = BGUFunctionLibraryCS.CalcDirWithInput(moveYawDirection, inputValue3, inputValue4);
				RotateToTargetInstantly(BGUFuncLibActorTransformCS.BGUGetActorLocation(owner) + moveYawDirection.Vector() * 1000.0);
			}
		}
	}

	private void RotateToTarget(in UnitLockTargetInfo TargetInfo, float TurnSpeed)
	{
		AActor lockTargetActor = TargetInfo.LockTargetActor;
		if (!(lockTargetActor != null))
		{
			return;
		}
		FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(BGU_DataUtil.GetActorResID(GetOwner()), Owner);
		bool flag = playerCommDesc != null && playerCommDesc.EnableMultipointLockMode == EGSYesNo.Yes;
		bool FoundComp;
		FVector targetPositionByTargetInfo = BGU_SelectTargetUtil.GetTargetPositionByTargetInfo(in TargetInfo, new List<string> { "AutoLockPoint", "AutoLockPoint_SP" }, out FoundComp, flag);
		switch (TargetInfo.LockTargetType)
		{
		case ELockTargetType.SceneComp:
			if (flag && FoundComp)
			{
				base.BUSEventCollection.Evt_SkillRotateTraceLocation.Invoke(targetPositionByTargetInfo, TurnSpeed);
				return;
			}
			break;
		case ELockTargetType.SkeletonSocket:
			if (lockTargetActor is ACharacter aCharacter && aCharacter.Mesh != null)
			{
				base.BUSEventCollection.Evt_SkillRotateTraceLocation.Invoke(targetPositionByTargetInfo, TurnSpeed);
				return;
			}
			break;
		}
		base.BUSEventCollection.Evt_SkillRotateTraceActor.Invoke(lockTargetActor, TurnSpeed);
		base.BUSEventCollection.Evt_G4CameraTurnToTarget.Invoke(lockTargetActor.GetActorTransform());
	}

	private void RotateToDesiredSkillDirection()
	{
		if (!SimpleStateData.HasSimpleState(EBGUSimpleState.LockRotation) && SkillInputAssistData.GetIsInSkillManualSelecting() && !(SkillSelectHelperData.GetDesiredSkillDirection() == FVector.ZeroVector))
		{
			AActor owner = GetOwner();
			FVector desiredSkillDirection = SkillSelectHelperData.GetDesiredSkillDirection();
			desiredSkillDirection.Z = 0f;
			BGUFuncLibActorTransformCS.BGUSetActorRotation(owner, desiredSkillDirection.Rotation(), bTeleportPhysics: false);
		}
	}

	private void OnInputRotate(float RotateSpeed, ESkillRotateType RotateType = ESkillRotateType.None)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		ABGUCharacter aBGUCharacter = owner as ABGUCharacter;
		if (!(aBGUCharacter == null) && BGUFuncLibInput.BGUIsCanReceiveBattleInput(GetOwner()))
		{
			float num = InputData.GetInputValue(GSBattleActionEn.MoveForward);
			float num2 = InputData.GetInputValue(GSBattleActionEn.MoveSideways);
			if (FMath.IsNearlyZero(num) && FMath.IsNearlyZero(num2))
			{
				num2 = ComboCacheData.LastCacheDodgeInputDir.X;
				num = ComboCacheData.LastCacheDodgeInputDir.Y;
			}
			if (FMath.Abs(num) > 0.3f || FMath.Abs(num2) > 0.3f)
			{
				FRotator moveYawDirection = BGUFunctionLibraryCS.GetMoveYawDirection(aBGUCharacter.GetController(), PlayerCameraManager);
				moveYawDirection = BGUFunctionLibraryCS.CalcDirWithInput(moveYawDirection, num, num2);
				base.BUSEventCollection.Evt_AttackRotateToPos.Invoke(BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()) + moveYawDirection.Vector() * 100000.0, RotateSpeed, RotateType == ESkillRotateType.Roll);
			}
		}
	}

	private void OnSkillRotateToCamera(float RotateSpeed)
	{
		if (BGUFuncLibInput.BGUIsCanReceiveBattleInput(GetOwner()))
		{
			FRotator controlRotation = (GetOwner() as ABGUCharacter).GetControlRotation();
			base.BUSEventCollection.Evt_SkillRotateTraceLocation.Invoke(BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()) + controlRotation.Vector() * 1000.0, RotateSpeed);
		}
	}

	private void RotateToTargetInstantly(in FVector TargetLocation)
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.LockRotation))
		{
			return;
		}
		if (SkillSelectHelperData.GetDesiredSkillDirection() != FVector.ZeroVector)
		{
			RotateToDesiredSkillDirection();
			return;
		}
		ABGUCharacter obj = GetOwner() as ABGUCharacter;
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(obj);
		FVector actorForwardVector = obj.GetActorForwardVector();
		FRotator newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(obj);
		FVector2D unitRotateAimDir = new FVector2D(actorForwardVector.X, actorForwardVector.Y);
		FVector2D unit2TargetDir = new FVector2D(TargetLocation.X - fVector.X, TargetLocation.Y - fVector.Y);
		float rotateAngle2D = BGU_MoveUtil.GetRotateAngle2D(unitRotateAimDir, unit2TargetDir);
		if (BGU_MoveUtil.IsRotateClockwise(unitRotateAimDir, unit2TargetDir))
		{
			newRotation.Yaw = UMathLibrary.NormalizeAxis(newRotation.Yaw + rotateAngle2D);
		}
		else
		{
			newRotation.Yaw = UMathLibrary.NormalizeAxis(newRotation.Yaw - rotateAngle2D);
		}
		BGUFuncLibActorTransformCS.BGUSetActorRotation(obj, newRotation, bTeleportPhysics: false);
	}
}
