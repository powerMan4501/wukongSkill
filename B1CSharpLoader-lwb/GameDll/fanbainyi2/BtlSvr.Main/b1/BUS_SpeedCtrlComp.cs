using b1.EventDelDefine;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_SpeedCtrlComp : UActorCompBaseCS
{
	private BUC_SpeedCtrlData SpeedCtrlData;

	private UBUC_ACharacterComponent ChrComp;

	private IBUC_ActorBasicData BasicData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_EnvironmentInteractionMgrData SurfaceCheckData;

	private IBUC_GlideMoveData GlideMoveData;

	private IBUC_ParkourMoveData ParkourMoveData;

	private IBUC_HardMoveData HardMoveData;

	private IBUC_PropMgrData PropMgrData;

	private IBUC_TickRateData TickRateData;

	private IBUC_ManualSplineMoveData ManualSplineMoveData;

	private IBUC_TargetInfoData TargetInfoData;

	private int SpeedCtrlID;

	public override void OnAttach()
	{
		SpeedCtrlData = RequireWritableData<BUC_SpeedCtrlData>();
		ChrComp = RequireWritableData<UBUC_ACharacterComponent>();
		BasicData = RequireReadOnlyData<IBUC_ActorBasicData, BUC_ActorBasicData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		SurfaceCheckData = RequireReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>();
		GlideMoveData = RequireReadOnlyData<IBUC_GlideMoveData, b1.BUC_GlideMoveData>();
		ParkourMoveData = RequireReadOnlyData<IBUC_ParkourMoveData, b1.BUC_ParkourMoveData>();
		HardMoveData = RequireReadOnlyData<IBUC_HardMoveData, b1.BUC_HardMoveData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		ManualSplineMoveData = RequireReadOnlyData<IBUC_ManualSplineMoveData, BUC_ManualSplineMoveData>();
		base.BUSEventCollection.Evt_OnSetJumpSpeedRate += new Del_Void(OnSetJumpSpeedRate);
		base.BUSEventCollection.Evt_AISetSpeedRate += new Del_AISetSpeedRate(OnAISetSpeedRate);
		base.BUSEventCollection.Evt_ResetSpeedCtrlInfo += new Del_Void(OnResetSpeedCtrl);
		base.BUSEventCollection.Evt_UpdateSpeedCtrlInfoByResID += new Del_Void_IntInt(OnSetSpeedCtrlByResID);
		base.BUSEventCollection.Evt_UpdateSpeedCtrlInfoBySpdInfo += new Del_Void_FloatFloatFloat(OnSetSpeedCtrlBySpeedParam);
		base.BUSEventCollection.Evt_UpdateSpeedCtrlInfoBaseBySpdInfo += new Del_Void_FloatFloatFloat(OnSetSpeedCtrlBaseBySpeedParam);
		base.BUSEventCollection.Evt_SetMoveSpeedAddValue += new Del_Void_Float(OnSetMoveSpeedAddValue);
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		OnResetSpeedCtrl();
		InitData();
	}

	public override void OnBeginPlay()
	{
		InitMaxSpeed();
	}

	private void InitData()
	{
		SpeedCtrlData.MaxAcceleration = ChrComp.OwnerMovement.MaxAcceleration;
		SpeedCtrlData.MoveSpeedAddValue = 0f;
	}

	private void InitMaxSpeed()
	{
		if (!(ChrComp.OwnerMovement == null))
		{
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxCustomMovementSpeed, ChrComp.OwnerMovement.MaxCustomMovementSpeed);
			SpeedCtrlData.MaxCustomMovementSpeedHandleID = PropMgrData.GetLastHandleID();
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxFlySpeed, ChrComp.OwnerMovement.MaxFlySpeed);
			SpeedCtrlData.MaxFlySpeedHandleID = PropMgrData.GetLastHandleID();
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxSwimSpeed, ChrComp.OwnerMovement.MaxSwimSpeed);
			SpeedCtrlData.MaxSwimSpeedHandleID = PropMgrData.GetLastHandleID();
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxWalkSpeedCrouched, ChrComp.OwnerMovement.MaxWalkSpeedCrouched);
			SpeedCtrlData.MaxWalkSpeedCrouchedHandleID = PropMgrData.GetLastHandleID();
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxWalkSpeed, ChrComp.OwnerMovement.MaxWalkSpeed);
			SpeedCtrlData.MaxWalkSpeedHandleID = PropMgrData.GetLastHandleID();
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (TickRateData.TROHelper_CanTickThisFrame)
		{
			UpdateMaxSpeed();
		}
	}

	private void UpdateMaxSpeed()
	{
		int actorResID = GetActorResID();
		bool num = BasicData.ActorType == BGU_ActorType.CharacterAI;
		float num2 = 1f;
		if (num)
		{
			if (HardMoveData.IsHardMoving())
			{
				FUStUnitSpecialMoveDesc unitSpecialMoveDesc = BGW_GameDB.GetUnitSpecialMoveDesc(actorResID);
				if (unitSpecialMoveDesc != null)
				{
					if (UnitStateData.HasState(EBGUUnitState.Sprinting))
					{
						SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, unitSpecialMoveDesc.HardMoveSpeedFast / SpeedCtrlData.GetMoveSpeedFast());
					}
					else
					{
						SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, unitSpecialMoveDesc.HardMoveSpeedNormal / SpeedCtrlData.GetMoveSpeedFast());
					}
				}
			}
		}
		else if (UnitStateData.HasState(EBGUUnitState.JumpMoving))
		{
			OnSetJumpSpeedRateImpl();
		}
		else if (UnitStateData.HasState(EBGUUnitState.GlideMoving))
		{
			float num3 = MathLib.DegAcos(FVector.DotProduct(SurfaceCheckData.SurfaceNormal_Normalized, FVector.UpVector));
			float mappedRangeValueClamped = FMath.GetMappedRangeValueClamped(new FVector2D(GlideMoveData.MinSpeedAngle, GlideMoveData.MaxSpeedAngle), new FVector2D(GlideMoveData.MinGlideSpeed, GlideMoveData.MaxGlideSpeed), num3);
			FVector a = ChrComp.OwnerCharacter.GetLastMovementInputVector() - GlideMoveData.GlideDirection * GlideMoveData.GlideDirectionInputScale;
			float num4 = (GlideMoveData.GlideDirection.IsZero() ? 0f : (a.ProjectOnTo(GlideMoveData.GlideDirection).Size() / GlideMoveData.GlideSpeedInputScale));
			num4 = ((FVector.DotProduct(a, GlideMoveData.GlideDirection) > 0f) ? num4 : (0f - num4));
			float num5 = mappedRangeValueClamped + GlideMoveData.MoveControlAddMaxSpeed * num4;
			SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, num5 / SpeedCtrlData.GetMoveSpeedFast());
		}
		else if (HardMoveData.IsHardMoving())
		{
			FUStUnitSpecialMoveDesc unitSpecialMoveDesc2 = BGW_GameDB.GetUnitSpecialMoveDesc(actorResID);
			if (unitSpecialMoveDesc2 != null)
			{
				if (UnitStateData.HasState(EBGUUnitState.Sprinting))
				{
					SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, unitSpecialMoveDesc2.HardMoveSpeedFast / SpeedCtrlData.GetMoveSpeedFast());
				}
				else
				{
					SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, unitSpecialMoveDesc2.HardMoveSpeedNormal / SpeedCtrlData.GetMoveSpeedFast());
				}
			}
		}
		else if (ManualSplineMoveData.IsManuaslSplineMovingWithSpecialAnimation() && ManualSplineMoveData.SplineMoveMaxSpeed > 0f)
		{
			SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, ManualSplineMoveData.SplineMoveMaxSpeed / SpeedCtrlData.GetMoveSpeedFast());
		}
		else
		{
			if (UnitStateData.HasState(EBGUUnitState.Sprinting))
			{
				SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, 1f);
			}
			else if (UnitStateData.HasState(EBGUUnitState.Walking))
			{
				SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, SpeedCtrlData.GetMoveSpeedSlow() / SpeedCtrlData.GetMoveSpeedFast());
			}
			else
			{
				SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, SpeedCtrlData.GetMoveSpeedNormal() / SpeedCtrlData.GetMoveSpeedFast());
			}
			bool flag = false;
			UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
			if (targetInfo != null && targetInfo.LockTargetActor != null && targetInfo.LockTargetWayType == ELockTargetWayType.Manual)
			{
				flag = true;
			}
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.MoveSlowly) || (SimpleStateData.HasSimpleState(EBGUSimpleState.LockStateWalking) && flag))
			{
				SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, SpeedCtrlData.GetMoveSpeedSlow() / SpeedCtrlData.GetMoveSpeedFast());
			}
			if (!UnitStateData.HasState(EBGUUnitState.Sprinting))
			{
				FVector lastInputVector = ChrComp.OwnerMovement.GetLastInputVector();
				FVector actorForwardVector = ChrComp.OwnerCharacter.GetActorForwardVector();
				lastInputVector.Normalize();
				actorForwardVector.Normalize();
				float num6 = FVector.DotProduct(lastInputVector, actorForwardVector);
				if (num6 < 0f)
				{
					num2 = 1f + (1f - SpeedCtrlData.GetMoveBackSpeedRate()) * num6;
				}
			}
		}
		float num7 = SpeedCtrlData.GetMoveSpeedFast() * SpeedCtrlData.GetFinalSpeedCtrlRate() * num2;
		num7 += SpeedCtrlData.MoveSpeedAddValue;
		if (num7 < 0f)
		{
			num7 = 0f;
		}
		if (DebugConfig.EnableMoveSpeedInfoDebug)
		{
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("EnableMoveSpeedInfoDebug", $"当前移动速度：{num7}", 1);
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("EnableMoveSpeedInfoDebug", $"当前移动速率：{SpeedCtrlData.GetFinalSpeedCtrlRate()}", 2);
		}
		UBGUCharacterMovementComponent ownerMovement = ChrComp.OwnerMovement;
		switch (ChrComp.OwnerMovement.MovementMode)
		{
		case EMovementMode.MOVE_None:
			break;
		case EMovementMode.MOVE_Walking:
		case EMovementMode.MOVE_NavWalking:
			if (ownerMovement.IsCrouching())
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxWalkSpeedCrouched, num7, SpeedCtrlData.MaxCustomMovementSpeedHandleID);
			}
			else
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxWalkSpeed, num7, SpeedCtrlData.MaxWalkSpeedHandleID);
			}
			break;
		case EMovementMode.MOVE_Falling:
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxWalkSpeed, num7, SpeedCtrlData.MaxWalkSpeedHandleID);
			break;
		case EMovementMode.MOVE_Swimming:
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxSwimSpeed, num7, SpeedCtrlData.MaxSwimSpeedHandleID);
			break;
		case EMovementMode.MOVE_Flying:
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxFlySpeed, num7, SpeedCtrlData.MaxFlySpeedHandleID);
			break;
		case EMovementMode.MOVE_Custom:
			base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxCustomMovementSpeed, num7, SpeedCtrlData.MaxCustomMovementSpeedHandleID);
			break;
		}
	}

	private void OnSetJumpSpeedRate()
	{
		UpdateMaxSpeed();
	}

	private void OnSetJumpSpeedRateImpl()
	{
		IBUC_JumpData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_JumpData, b1.BUC_JumpData>(ChrComp.OwnerCharacter);
		if (readOnlyData == null)
		{
			return;
		}
		if (readOnlyData.JumpType == EJumpType.StrideJump)
		{
			if (UnitStateData.HasState(EBGUUnitState.Sprinting))
			{
				float speedRate = ((ParkourMoveData.SprintStrideSpeedRate == 0f) ? 1f : ParkourMoveData.SprintStrideSpeedRate);
				SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, speedRate);
			}
			else
			{
				float num = ((ParkourMoveData.RunStrideSpeedRate == 0f) ? 1f : ParkourMoveData.RunStrideSpeedRate);
				SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, SpeedCtrlData.GetMoveSpeedNormal() * num / SpeedCtrlData.GetMoveSpeedFast());
			}
		}
		else if (readOnlyData.CurStartJumpSpdState == EStartJumpSpdState.StartJumpSpdState_Fast)
		{
			SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, SpeedCtrlData.GetJumpSpeedFast() / SpeedCtrlData.GetMoveSpeedFast());
		}
		else if (readOnlyData.CurStartJumpSpdState == EStartJumpSpdState.StartJumpSpdState_Normal)
		{
			SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, SpeedCtrlData.GetJumpSpeedNormal() / SpeedCtrlData.GetMoveSpeedFast());
		}
		else
		{
			SpeedCtrlData.SetSpeedRateCtrl(SpeedCtrlID, 0f);
		}
	}

	private void OnAISetSpeedRate(float SpeedRate, EBGUSpeedCtrlID SpeedCtrlID = EBGUSpeedCtrlID.Custom)
	{
		SpeedCtrlData.SetSpeedRateCtrl((int)SpeedCtrlID, SpeedRate);
	}

	private void OnResetSpeedCtrl()
	{
		SpeedCtrlData.SetSpeedInfo(GetActorResID(), GetFinalBattleInfoExtendID(), GetOwner());
	}

	private void OnSetSpeedCtrlByResID(int ResID, int OverrideID)
	{
		SpeedCtrlData.SetSpeedInfo(ResID, OverrideID, GetOwner());
	}

	private void OnSetSpeedCtrlBySpeedParam(float FastSpdRatio, float NormalSpdRatio, float SlowSpdRatio)
	{
		SpeedCtrlData.SetSpeedInfo(FastSpdRatio, NormalSpdRatio, SlowSpdRatio);
	}

	private void OnSetSpeedCtrlBaseBySpeedParam(float FastSpdBase, float NormalSpdBase, float SlowSpdBase)
	{
		SpeedCtrlData.SetSpeedInfoBase(FastSpdBase, NormalSpdBase, SlowSpdBase);
	}

	private void OnSetMoveSpeedAddValue(float AddValue)
	{
		SpeedCtrlData.MoveSpeedAddValue = AddValue;
	}
}
