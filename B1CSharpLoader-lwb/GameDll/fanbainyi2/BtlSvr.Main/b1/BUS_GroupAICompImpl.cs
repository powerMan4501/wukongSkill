using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Diana.Common;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

internal class BUS_GroupAICompImpl : UActorCompBaseCS
{
	private enum EGroupAIMoveGoal
	{
		None,
		Close2HotZone,
		Move2HotZonePoint,
		Move2EnterBattlePos,
		RangeEQSRun,
		Attack
	}

	private enum EGroupPriorityActionState
	{
		WaitForBegin,
		Inprogress,
		WaiteForEnd
	}

	private class GroupActionTemplate
	{
		public EGroupPriorityActionState ActionState;

		public int ReqID;

		protected b1.BUS_GroupAICompImpl GroupAIComp { get; set; }

		public virtual bool CanEndActionWhenNoActionEffectiveTime { get; } = true;

		public virtual void Init(b1.BUS_GroupAICompImpl _GroupAIComp)
		{
			GroupAIComp = _GroupAIComp;
		}

		public virtual void BeginAction(int _ReqID, IGroupAIActionInfo GAAI)
		{
			ReqID = _ReqID;
			GroupAIComp.BUSEventCollection.Evt_AIPauseBT.Invoke(P1: true);
			ActionState = EGroupPriorityActionState.Inprogress;
		}

		public virtual void TickAction(float DeltaTime)
		{
		}

		public virtual void EndAction()
		{
			ReqID = 0;
			GroupAIComp.BUSEventCollection.Evt_AIPauseBT.Invoke(P1: false);
			GroupAIComp.BUSEventCollection.Evt_SwitchBehaviourTree.Invoke(P1: false, "");
		}
	}

	private class ToggleActivateGroupAIAction : GroupActionTemplate
	{
		private bool bNeedExitGroupAI;

		public override void BeginAction(int _ReqID, IGroupAIActionInfo GAAI)
		{
			ReqID = _ReqID;
			bNeedExitGroupAI = false;
			if (GAAI is GAAI_EnableGroupAI { IsEnable: var isEnable })
			{
				if (isEnable)
				{
					base.GroupAIComp.GroupAIData.IsCtrlByGroupAI = true;
					base.GroupAIComp.GroupAIData.IsFirstTimeReceiveATKToken = true;
					base.GroupAIComp.GroupAIData.IsFirstTimeReceiveToken = true;
					base.GroupAIComp.GroupAIData.IsFirstTimeLostToken = true;
					base.GroupAIComp.BUSEventCollection.Evt_SetBT.Invoke(null);
					base.GroupAIComp.BUSEventCollection.Evt_AIPauseFsmInstance.Invoke(P1: true);
					base.GroupAIComp.BUSEventCollection.Evt_SwitchFsmSolver.Invoke(EFsmSolverType.GroupAi);
				}
				else
				{
					bNeedExitGroupAI = true;
				}
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					string text = (isEnable ? ", 接受群体AI操控" : ", 群体AI操控结束");
					BGUFunctionLibraryCS.LogBattleInfo(base.GroupAIComp.Owner, EBattleInfoType.GroupAI, "<character>【GroupAIComp】" + base.GroupAIComp.Owner.GetName() + "</><action>" + text + "</>");
				}
			}
			ActionState = EGroupPriorityActionState.WaiteForEnd;
		}

		public override void EndAction()
		{
			ReqID = 0;
			if (bNeedExitGroupAI)
			{
				base.GroupAIComp.ExitGroupAI(ERecoverTokenReason.ExitGroupAI, bNeedStopCurrentAction: false);
			}
		}
	}

	private class AttackAction : GroupActionTemplate
	{
		private GAAI_FSM_2_Attack FSM_2_AttackInfo;

		private bool CanMove;

		private FVector WorldPos;

		private float MaxMoveTime;

		private bool HasTriggerCombo;

		public override bool CanEndActionWhenNoActionEffectiveTime => !base.GroupAIComp.UnitStateData.HasState(EBGUUnitState.Attacking);

		public override void BeginAction(int _ReqID, IGroupAIActionInfo GAAI)
		{
			if (base.GroupAIComp.AnimationSyncData.IsAnyUnitInAnimationSyncing())
			{
				if (!base.GroupAIComp.UnitStateData.HasState(EBGUUnitState.Attacking))
				{
					ActionState = EGroupPriorityActionState.WaiteForEnd;
				}
				return;
			}
			ReqID = _ReqID;
			CanMove = true;
			HasTriggerCombo = false;
			base.GroupAIComp.SetCrowdParamByMoveGoal(EGroupAIMoveGoal.Attack);
			FSM_2_AttackInfo = GAAI as GAAI_FSM_2_Attack;
			if (FSM_2_AttackInfo != null)
			{
				CanMove = !FSM_2_AttackInfo.IsNoMoveAtk;
				if (base.GroupAIComp.GroupAIData.OnlyTriggerOnceAddBuffWhenReceiveToken || base.GroupAIComp.GroupAIData.IsFirstTimeReceiveToken)
				{
					foreach (int item in base.GroupAIComp.GroupAIData.BuffListWhenReceiveToken)
					{
						base.GroupAIComp.BUSEventCollection.Evt_BuffAdd.Invoke(item, base.GroupAIComp.Owner, base.GroupAIComp.Owner, 0f, EBuffSourceType.GroupAI);
					}
				}
				bool flag = false;
				if (base.GroupAIComp.GroupAIData.GroupAIOnFightSkillList != null && base.GroupAIComp.GroupAIData.GroupAIOnFightSkillList.Count > 0)
				{
					if (base.GroupAIComp.GroupAIData.OnlyUseOnceOnFightSkill && !base.GroupAIComp.GroupAIData.IsFirstTimeReceiveATKToken)
					{
						if (FSM_2_AttackInfo.GetActionAIAttackBias() == EGroupAIAttackBias.RangeAttack)
						{
							base.GroupAIComp.BUSEventCollection.Evt_SetGroupAISkill.Invoke(base.GroupAIComp.GroupAIData.GroupAISkillListForRangeAttack);
						}
						else
						{
							base.GroupAIComp.BUSEventCollection.Evt_SetGroupAISkill.Invoke(base.GroupAIComp.GroupAIData.GroupAISkillListForMeleeAttack);
						}
					}
					else
					{
						flag = true;
						base.GroupAIComp.BUSEventCollection.Evt_SetGroupAISkill.Invoke(base.GroupAIComp.GroupAIData.GroupAIOnFightSkillList);
					}
				}
				else if (FSM_2_AttackInfo.GetActionAIAttackBias() == EGroupAIAttackBias.RangeAttack)
				{
					base.GroupAIComp.BUSEventCollection.Evt_SetGroupAISkill.Invoke(base.GroupAIComp.GroupAIData.GroupAISkillListForRangeAttack);
				}
				else
				{
					base.GroupAIComp.BUSEventCollection.Evt_SetGroupAISkill.Invoke(base.GroupAIComp.GroupAIData.GroupAISkillListForMeleeAttack);
				}
				if (!flag && !FSM_2_AttackInfo.IsNoMoveAtk)
				{
					FVector cachedLocalPlayerLocation = base.GroupAIComp.LocalPlayerSharedData.CachedLocalPlayerLocation;
					float num = FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(base.GroupAIComp.Owner), cachedLocalPlayerLocation);
					float num2 = 50f;
					UCapsuleComponent uCapsuleComponent = base.GroupAIComp.LocalPlayerSharedData.FirstLocalPlayerPawn.GetRootComponent() as UCapsuleComponent;
					if (uCapsuleComponent != null)
					{
						num2 = uCapsuleComponent.GetScaledCapsuleHalfHeight();
					}
					WorldPos.Z -= num2;
					BGWGroupAIBattleHotZoneConfigDataAsset groupAIBattleHotZoneConfigDataAsset = base.GroupAIComp.GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset;
					if (groupAIBattleHotZoneConfigDataAsset != null)
					{
						float num3 = 0f;
						switch (FSM_2_AttackInfo.GetActionAIAttackBias())
						{
						case EGroupAIAttackBias.MeleeAttack:
							num3 = groupAIBattleHotZoneConfigDataAsset.ShortBattleCircleRadius;
							break;
						case EGroupAIAttackBias.RangeAttack:
							num3 = groupAIBattleHotZoneConfigDataAsset.MiddleBattleCircleRadius;
							break;
						}
						if (num > num3)
						{
							WorldPos = cachedLocalPlayerLocation;
							base.GroupAIComp.BUSEventCollection.Evt_ChangeMotionMatchingState.Invoke(EState_MM.Free);
							if (BGUFuncLibForMove.BeginMoveToTarget(base.GroupAIComp.Owner, base.GroupAIComp.LocalPlayerSharedData.FirstLocalPlayerPawn, num3, EAIMoveSpeedType.SPRINT, EBGUMoveAIType.None, IncludeSelfRadius: true, IncludeTargetRadius: true, out var _))
							{
								CanMove = true;
							}
						}
					}
				}
				if (CanMove)
				{
					BGWGroupAIMgrConfigDataAsset groupAIMgrConfigDataAsset = base.GroupAIComp.GroupAIMgrData.GroupAIMgrConfigDataAsset;
					if (groupAIMgrConfigDataAsset != null)
					{
						MaxMoveTime = groupAIMgrConfigDataAsset.MaxAtkMoveTime;
					}
				}
			}
			if (base.GroupAIComp.OwnerAsCharacterCS.CharacterMovement is UBGUCharacterMovementComponent uBGUCharacterMovementComponent)
			{
				uBGUCharacterMovementComponent.EnableSimplePhysWalkCollision = true;
			}
			base.GroupAIComp.GroupAIData.IsFirstTimeReceiveATKToken = false;
			base.GroupAIComp.GroupAIData.IsFirstTimeReceiveToken = false;
			ActionState = EGroupPriorityActionState.Inprogress;
		}

		public override void TickAction(float DeltaTime)
		{
			if (base.GroupAIComp.AnimationSyncData.IsAnyUnitInAnimationSyncing())
			{
				if (!base.GroupAIComp.UnitStateData.HasState(EBGUUnitState.Attacking))
				{
					ActionState = EGroupPriorityActionState.WaiteForEnd;
				}
			}
			else if (CanMove)
			{
				if (BGUFuncLibForMove.IsMoveActive(base.GroupAIComp.Owner))
				{
					if (MaxMoveTime > 0f)
					{
						MaxMoveTime -= DeltaTime;
						if (MaxMoveTime <= 0f)
						{
							CanMove = false;
						}
					}
				}
				else
				{
					CanMove = false;
				}
			}
			else if (!HasTriggerCombo)
			{
				HasTriggerCombo = true;
				base.GroupAIComp.BUSEventCollection.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.Combo, new AINodeAction_ComboParamInfo
				{
					ComboTargetType = EComboTargetType.CurrentAITarget,
					SkillSourceType = EZatoichiSkillSourceType.UseWithGroupAI,
					PursuitInAllSkill = false,
					PursuitAnyWhere = false,
					ForceCastSkillAfterPursuitFailed = false,
					PursuitRangePos = 1f,
					SpeedRateType = EAIMoveSpeedType.SPRINT,
					MotionMatchingMoveMode = EState_MM.Free,
					MoveAIType = EBGUMoveAIType.None,
					MoveAcceptableRadiusType = EBGUMoveAcceptableRadiusType.IncludeTarget,
					BeginRotateAngle = 30f,
					IsUseSkillForTurn = true,
					IsUseSkillForMove = false,
					IsGetTopRandomSkill = true,
					TopRandomSkillPercent = 10000
				});
				base.GroupAIComp.GroupAIData.IsAIActionFinishDict[EAINodeActionType.Combo] = false;
			}
			else if (base.GroupAIComp.GroupAIData.IsAIActionFinishDict[EAINodeActionType.Combo])
			{
				ActionState = EGroupPriorityActionState.WaiteForEnd;
			}
		}

		public override void EndAction()
		{
			bool flag = false;
			if (base.GroupAIComp.GroupAIData.OnlyTriggerOnceAddBuffWhenLostToken)
			{
				if (base.GroupAIComp.GroupAIData.IsFirstTimeLostToken)
				{
					flag = true;
				}
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				foreach (int item in base.GroupAIComp.GroupAIData.BuffListWhenLostToken)
				{
					base.GroupAIComp.BUSEventCollection.Evt_BuffAdd.Invoke(item, base.GroupAIComp.Owner, base.GroupAIComp.Owner, 0f, EBuffSourceType.GroupAI);
				}
			}
			base.GroupAIComp.BGSEventCollection.Evt_BGS_RecoverAttackToken.Invoke(base.GroupAIComp.GetOwnerEntity(), ERecoverTokenReason.FinishAttack);
			base.GroupAIComp.BUSEventCollection.Evt_SetAINodeActionStop.Invoke();
			base.GroupAIComp.BUSEventCollection.Evt_AIResetCrowdParam.Invoke();
			if (BGUFuncLibForMove.IsMoveActive(base.GroupAIComp.Owner))
			{
				BGUFuncLibForMove.CancelMove(base.GroupAIComp.Owner);
			}
			FSM_2_AttackInfo = null;
			base.GroupAIComp.GroupAIData.IsFirstTimeLostToken = false;
			ReqID = 0;
			if (base.GroupAIComp.OwnerAsCharacterCS.CharacterMovement is UBGUCharacterMovementComponent uBGUCharacterMovementComponent)
			{
				uBGUCharacterMovementComponent.EnableSimplePhysWalkCollision = false;
			}
			if (base.GroupAIComp.GroupAIActionPkgQue.Size() == 0)
			{
				base.GroupAIComp.OnGroupAIRequestTask(-1, 0f, EGroupCMDType.Wander, new GAAI_FSM_2_Wander
				{
					MaxWanderTime = FMath.RandRange(2, 4)
				}, 0f, 0f);
			}
		}
	}

	private class WanderAction : GroupActionTemplate
	{
		private GAAI_FSM_2_Wander FSM_2_WanderInfo;

		private UEnvQuery EQSTemplate;

		private float MaxWanderTimer;

		private bool WaitFinish;

		private float KFTTimer;

		public EGroupAIMoveGoal CurrentGoal;

		private bool HasReach2HotZonePoint;

		public override void BeginAction(int _ReqID, IGroupAIActionInfo GAAI)
		{
			ReqID = _ReqID;
			KFTTimer = 0f;
			WaitFinish = false;
			HasReach2HotZonePoint = false;
			FSM_2_WanderInfo = GAAI as GAAI_FSM_2_Wander;
			if (FSM_2_WanderInfo != null)
			{
				MaxWanderTimer = FSM_2_WanderInfo.MaxWanderTime;
				base.GroupAIComp.BUSEventCollection.Evt_SetGroupAISkill.Invoke(null);
				if (GSGameplayCVar.CVar_GroupAIEnableBattleFormation.GetValueInGameThread() == 1)
				{
					EQSTemplate = BGW_PreloadAssetMgr.Get(base.GroupAIComp.Owner).TryGetCachedResourceObj<UEnvQuery>("EnvQuery'/Game/00Main/Design/AI/GroupAI/EQ_GroupAI_WanderPoint.EQ_GroupAI_WanderPoint'", ELoadResourceType.SyncLoadAndCache);
				}
				else
				{
					EQSTemplate = BGW_PreloadAssetMgr.Get(base.GroupAIComp.Owner).TryGetCachedResourceObj<UEnvQuery>("EnvQuery'/Game/00Main/Design/AI/GroupAI/EQ_GroupAI_EnterBattlePos.EQ_GroupAI_EnterBattlePos'", ELoadResourceType.SyncLoadAndCache);
				}
				if (EQSTemplate != null)
				{
					base.GroupAIComp.GroupAIData.CanBeInterrupted = true;
					ActionState = EGroupPriorityActionState.Inprogress;
				}
				else
				{
					ActionState = EGroupPriorityActionState.WaiteForEnd;
				}
			}
			else
			{
				ActionState = EGroupPriorityActionState.WaiteForEnd;
			}
		}

		public override void TickAction(float DeltaTime)
		{
			if (GSGameplayCVar.CVar_GroupAIEnableBattleFormation.GetValueInGameThread() == 1)
			{
				if (base.GroupAIComp.CheckIsFarAwayFromHotZone())
				{
					TriggerMoveAIAction(EGroupAIMoveGoal.Close2HotZone, EAINodeActionType.MoveTo);
					return;
				}
				if (WaitFinish)
				{
					KFTTimer -= DeltaTime;
					if (KFTTimer <= 0f)
					{
						ActionState = EGroupPriorityActionState.WaiteForEnd;
					}
					return;
				}
				bool flag = false;
				bool flag2 = true;
				if (!HasReach2HotZonePoint && base.GroupAIComp.GroupAIData.GetGroupAIHotZonePointPos(out var HotZonePointPos))
				{
					FVector cachedLocalPlayerLocation = base.GroupAIComp.LocalPlayerSharedData.CachedLocalPlayerLocation;
					FRotator cachedLocalPlayerRotation = base.GroupAIComp.LocalPlayerSharedData.CachedLocalPlayerRotation;
					FRotator cachedLocalPlayerCameraRotation = base.GroupAIComp.LocalPlayerSharedData.CachedLocalPlayerCameraRotation;
					FVector v = BGUFuncLibAICS.BGUGetHotZonePointWorldLocation(cachedLocalPlayerLocation, cachedLocalPlayerRotation, cachedLocalPlayerCameraRotation, HotZonePointPos);
					if (FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(base.GroupAIComp.Owner), v) > 500f)
					{
						flag2 = false;
						TriggerMoveAIAction(EGroupAIMoveGoal.Move2HotZonePoint, EAINodeActionType.GroupAIMove2HotZonePoint);
					}
				}
				if (flag2)
				{
					HasReach2HotZonePoint = true;
					flag = true;
					TriggerMoveAIAction(EGroupAIMoveGoal.RangeEQSRun, EAINodeActionType.EQSRun);
				}
				if (flag)
				{
					MaxWanderTimer -= DeltaTime;
					if (MaxWanderTimer <= 0f)
					{
						KFTTimer = 1f;
						WaitFinish = true;
						base.GroupAIComp.BUSEventCollection.Evt_ActorRotateToTarget.Invoke(base.GroupAIComp.LocalPlayerSharedData.FirstLocalPlayerPawn, 200f);
					}
				}
				return;
			}
			if (WaitFinish)
			{
				KFTTimer -= DeltaTime;
				if (KFTTimer <= 0f)
				{
					ActionState = EGroupPriorityActionState.WaiteForEnd;
				}
				return;
			}
			bool flag3 = false;
			bool flag4 = true;
			if (!HasReach2HotZonePoint)
			{
				FVector enterBattlePosition = base.GroupAIComp.AIData.GetEnterBattlePosition();
				if (FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(base.GroupAIComp.Owner), enterBattlePosition) > 500f)
				{
					flag4 = false;
					TriggerMoveAIAction(EGroupAIMoveGoal.Move2EnterBattlePos, EAINodeActionType.GroupAIMove2EnterBattlePos);
				}
			}
			if (flag4)
			{
				HasReach2HotZonePoint = true;
				flag3 = true;
				TriggerMoveAIAction(EGroupAIMoveGoal.RangeEQSRun, EAINodeActionType.EQSRun);
			}
			if (flag3)
			{
				MaxWanderTimer -= DeltaTime;
				if (MaxWanderTimer <= 0f)
				{
					KFTTimer = 1f;
					WaitFinish = true;
					base.GroupAIComp.BUSEventCollection.Evt_ActorRotateToTarget.Invoke(base.GroupAIComp.LocalPlayerSharedData.FirstLocalPlayerPawn, 200f);
				}
			}
		}

		public override void EndAction()
		{
			base.GroupAIComp.BUSEventCollection.Evt_SetAINodeActionStop.Invoke();
			base.GroupAIComp.BUSEventCollection.Evt_AIResetCrowdParam.Invoke();
			if (BGUFuncLibForMove.IsMoveActive(base.GroupAIComp.Owner))
			{
				BGUFuncLibForMove.CancelMove(base.GroupAIComp.Owner);
			}
			base.GroupAIComp.GroupAIData.CanBeInterrupted = false;
			FSM_2_WanderInfo = null;
			EQSTemplate = null;
			ReqID = 0;
		}

		private void TriggerMoveAIAction(EGroupAIMoveGoal MatchGoal, EAINodeActionType MoveType)
		{
			bool flag = false;
			if (CurrentGoal == MatchGoal)
			{
				if (base.GroupAIComp.GroupAIData.IsAIActionFinishDict.TryGetValue(MoveType, out var value))
				{
					flag = value;
				}
			}
			else
			{
				CurrentGoal = MatchGoal;
				flag = true;
			}
			if (flag)
			{
				if (GetNowNeedMoveParam(MatchGoal, out var MoveParam, out var MMState))
				{
					base.GroupAIComp.BUSEventCollection.Evt_ChangeMotionMatchingState.Invoke(MMState);
					base.GroupAIComp.BUSEventCollection.Evt_InitiateAINodeAction.Invoke(MoveType, MoveParam);
				}
				base.GroupAIComp.GroupAIData.IsAIActionFinishDict[MoveType] = false;
				base.GroupAIComp.SetCrowdParamByMoveGoal(CurrentGoal);
			}
		}

		private bool GetNowNeedMoveParam(EGroupAIMoveGoal MatchGoal, out IAINodeActionInfo MoveParam, out EState_MM MMState)
		{
			MMState = EState_MM.None;
			MoveParam = null;
			EBGUMoveAIType moveAIType;
			EAIMoveSpeedType speedRateType;
			switch (MatchGoal)
			{
			case EGroupAIMoveGoal.Close2HotZone:
				GetMoveAndSpeedRateType(base.GroupAIComp.LocalPlayerSharedData.CachedLocalPlayerLocation, out moveAIType, out speedRateType);
				MMState = ((moveAIType == EBGUMoveAIType.KeepFacingTarget) ? EState_MM.Lock : EState_MM.Free);
				MoveParam = new AINodeAction_MoveToParamInfo
				{
					AcceptableRadius = 250f,
					IncludeSelfRadius = true,
					IncludeTargetRadius = false,
					MoveAIType = moveAIType,
					SpeedRateType = speedRateType,
					BTTargetType = EBTTargetType.Location,
					TargetLocation = base.GroupAIComp.LocalPlayerSharedData.CachedLocalPlayerLocation,
					DynamicChangeMoveTypeAndSpeedType = (base.GroupAIComp.GroupAIMgrData.GroupAIMgrConfigDataAsset.MoveTo_DCParam_Switch2KFTDistance > 0),
					DCParam_Switch2KFTDistance = base.GroupAIComp.GroupAIMgrData.GroupAIMgrConfigDataAsset.MoveTo_DCParam_Switch2KFTDistance,
					DCParam_Switch2MoveToDistance = base.GroupAIComp.GroupAIMgrData.GroupAIMgrConfigDataAsset.MoveTo_DCParam_Switch2MoveToDistance
				};
				return true;
			case EGroupAIMoveGoal.Move2HotZonePoint:
			{
				if (base.GroupAIComp.GroupAIData.GetGroupAIHotZonePointPos(out var HotZonePointPos))
				{
					FVector cachedLocalPlayerLocation = base.GroupAIComp.LocalPlayerSharedData.CachedLocalPlayerLocation;
					FRotator cachedLocalPlayerRotation = base.GroupAIComp.LocalPlayerSharedData.CachedLocalPlayerRotation;
					FRotator cameraRotation = base.GroupAIComp.LocalPlayerSharedData.FirstLocalPlayerCamMgr.GetCameraRotation();
					FVector goalPos = BGUFuncLibAICS.BGUGetHotZonePointWorldLocation(cachedLocalPlayerLocation, cachedLocalPlayerRotation, cameraRotation, HotZonePointPos);
					GetMoveAndSpeedRateType(goalPos, out moveAIType, out speedRateType);
					MMState = ((moveAIType == EBGUMoveAIType.KeepFacingTarget) ? EState_MM.Lock : EState_MM.Free);
					MoveParam = new AINodeAction_GroupAIMove2HotZonePointParamInfo
					{
						AcceptableRadius = 200f,
						IncludeSelfRadius = true,
						IncludeTargetRadius = false,
						MoveAIType = moveAIType,
						SpeedRateType = speedRateType,
						DynamicChangeMoveTypeAndSpeedType = (base.GroupAIComp.GroupAIMgrData.GroupAIMgrConfigDataAsset.MoveTo_DCParam_Switch2KFTDistance > 0),
						DCParam_Switch2KFTDistance = base.GroupAIComp.GroupAIMgrData.GroupAIMgrConfigDataAsset.MoveTo_DCParam_Switch2KFTDistance,
						DCParam_Switch2MoveToDistance = base.GroupAIComp.GroupAIMgrData.GroupAIMgrConfigDataAsset.MoveTo_DCParam_Switch2MoveToDistance
					};
					return true;
				}
				break;
			}
			case EGroupAIMoveGoal.Move2EnterBattlePos:
				moveAIType = EBGUMoveAIType.KeepFacingTarget;
				speedRateType = EAIMoveSpeedType.RUN;
				MMState = EState_MM.Lock;
				MoveParam = new AINodeAction_GroupAIMove2EnterBattlePos
				{
					AcceptableRadius = 200f,
					IncludeSelfRadius = true,
					IncludeTargetRadius = false,
					MoveAIType = moveAIType,
					SpeedRateType = speedRateType,
					DynamicChangeMoveTypeAndSpeedType = (base.GroupAIComp.GroupAIMgrData.GroupAIMgrConfigDataAsset.MoveTo_DCParam_Switch2KFTDistance > 0),
					DCParam_Switch2KFTDistance = base.GroupAIComp.GroupAIMgrData.GroupAIMgrConfigDataAsset.MoveTo_DCParam_Switch2KFTDistance,
					DCParam_Switch2MoveToDistance = base.GroupAIComp.GroupAIMgrData.GroupAIMgrConfigDataAsset.MoveTo_DCParam_Switch2MoveToDistance
				};
				return true;
			case EGroupAIMoveGoal.RangeEQSRun:
				MMState = EState_MM.Lock;
				MoveParam = new AINodeAction_EQSRunParamInfo
				{
					AcceptableRadius = 200f,
					IncludeSelfRadius = true,
					MoveAIType = EBGUMoveAIType.KeepFacingTarget,
					SpeedRateType = EAIMoveSpeedType.RUN,
					EQSTemplate = EQSTemplate
				};
				return true;
			}
			return false;
		}

		private void GetMoveAndSpeedRateType(FVector GoalPos, out EBGUMoveAIType OutMoveAIType, out EAIMoveSpeedType OutAIMoveSpeedType)
		{
			FVector cachedLocalPlayerLocation = base.GroupAIComp.LocalPlayerSharedData.CachedLocalPlayerLocation;
			FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(base.GroupAIComp.Owner);
			BGWGroupAIBattleHotZoneConfigDataAsset groupAIBattleHotZoneConfigDataAsset = base.GroupAIComp.GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset;
			if (FVector.Dist2D(cachedLocalPlayerLocation, v) <= (float)groupAIBattleHotZoneConfigDataAsset.MeleeAttackHotZoneInnerRadius)
			{
				OutMoveAIType = EBGUMoveAIType.KeepFacingTarget;
				OutAIMoveSpeedType = EAIMoveSpeedType.RUN;
			}
			else
			{
				OutMoveAIType = EBGUMoveAIType.None;
				OutAIMoveSpeedType = EAIMoveSpeedType.SPRINT;
			}
		}
	}

	private class MoveToPosAction : GroupActionTemplate
	{
		private FVector GoalPos = FVector.ZeroVector;

		private float WaitTime;

		private EAIMoveSpeedType SpeedType = EAIMoveSpeedType.RUN;

		private EBGUMoveAIType MoveAIType;

		public override void BeginAction(int _ReqID, IGroupAIActionInfo GAAI)
		{
			base.BeginAction(_ReqID, GAAI);
			if (GAAI is GAAI_PRIO_ACT_MoveToPos gAAI_PRIO_ACT_MoveToPos)
			{
				GoalPos = gAAI_PRIO_ACT_MoveToPos.GoalPos;
				WaitTime = gAAI_PRIO_ACT_MoveToPos.WaitTime;
				SpeedType = gAAI_PRIO_ACT_MoveToPos.SpeedType;
				MoveAIType = gAAI_PRIO_ACT_MoveToPos.MoveAIType;
			}
			if (!BGUFuncLibForMove.BeginMoveToPos(base.GroupAIComp.Owner, GoalPos, 0f, SpeedType, MoveAIType, IncludeSelfRadius: true, IncludeTargetRadius: false, out var _))
			{
				ActionState = EGroupPriorityActionState.WaiteForEnd;
			}
		}

		public override void TickAction(float DeltaTime)
		{
			WaitTime -= DeltaTime;
			if (WaitTime <= 0f)
			{
				ActionState = EGroupPriorityActionState.WaiteForEnd;
			}
		}
	}

	private class NormalSkillAction : GroupActionTemplate
	{
		private int SkillID;

		public override void BeginAction(int _ReqID, IGroupAIActionInfo GAAI)
		{
			base.BeginAction(_ReqID, GAAI);
			if (GAAI is GAAI_PRIO_ACT_CastSkill gAAI_PRIO_ACT_CastSkill)
			{
				SkillID = gAAI_PRIO_ACT_CastSkill.SkillID;
			}
			if (BGUFunctionLibraryCS.BGUTryCastSpell(base.GroupAIComp.Owner, SkillID, ECastSkillSourceType.GroupAI) != 0)
			{
				ActionState = EGroupPriorityActionState.WaiteForEnd;
			}
		}

		public override void TickAction(float DeltaTime)
		{
			if (!base.GroupAIComp.UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				ActionState = EGroupPriorityActionState.WaiteForEnd;
			}
		}
	}

	private class AddBuffAction : GroupActionTemplate
	{
		public List<int> BuffIDList = new List<int>();

		public override void BeginAction(int _ReqID, IGroupAIActionInfo GAAI)
		{
			base.BeginAction(_ReqID, GAAI);
			if (GAAI is GAAI_PRIO_ACT_AddBuff gAAI_PRIO_ACT_AddBuff)
			{
				BuffIDList = gAAI_PRIO_ACT_AddBuff.BuffIDList;
				foreach (int buffID in BuffIDList)
				{
					BGUFunctionLibraryCS.BGUAddBuff(base.GroupAIComp.Owner, base.GroupAIComp.Owner, buffID, EBuffSourceType.GroupAI);
				}
			}
			ActionState = EGroupPriorityActionState.WaiteForEnd;
		}
	}

	private class GroupAIActionWrap
	{
		private GroupAIActionPkg AIActionPkg;

		private GroupActionTemplate ActionTemplate;

		private b1.BUS_GroupAICompImpl GroupAIComp;

		public GroupAIActionWrap(b1.BUS_GroupAICompImpl _GroupAIComp)
		{
			ClearPkgAndTemplate();
			GroupAIComp = _GroupAIComp;
		}

		public void UpdateActionTemplate(float DeltaTime, AActor OwnerActor)
		{
			if (IsValid())
			{
				bool flag = true;
				if (AIActionPkg.ActionEffectiveTime > 0f)
				{
					AIActionPkg.ActionEffectiveTime -= DeltaTime;
					if (AIActionPkg.ActionEffectiveTime <= 0f)
					{
						flag = false;
					}
				}
				if (flag)
				{
					string value = $"任务最大时长还剩：{AIActionPkg.ActionEffectiveTime:F2}秒";
					if (ActionTemplate.ActionState == EGroupPriorityActionState.WaitForBegin)
					{
						value = $"任务最大时长还剩：{AIActionPkg.ActionEffectiveTime:F2}秒, 开始扰动时长倒数：{AIActionPkg.ActionBeginNoiseTime:F2}秒";
					}
					AIActionPkg.ActionBeginNoiseTime -= DeltaTime;
					if (AIActionPkg.ActionBeginNoiseTime <= 0f && ActionTemplate.ActionState == EGroupPriorityActionState.WaitForBegin)
					{
						ActionTemplate.BeginAction(AIActionPkg.ReqID, AIActionPkg.IGAAI);
					}
					switch (ActionTemplate.ActionState)
					{
					case EGroupPriorityActionState.Inprogress:
						ActionTemplate.TickAction(DeltaTime);
						if (AIActionPkg.CMDType == EGroupCMDType.Wander)
						{
							value = $"当前处于游走任务中的：{((WanderAction)ActionTemplate).CurrentGoal} 阶段";
						}
						break;
					case EGroupPriorityActionState.WaiteForEnd:
						if (DebugConfig.GroupAI)
						{
							GroupAIComp.BUSEventCollection.Evt_UpdateDebugUILamp.Invoke("GroupAI", new FSlateColor
							{
								SpecifiedColor = FLinearColor.Gray
							});
							switch (AIActionPkg.CMDType)
							{
							case EGroupCMDType.PRIO_ACT_MoveTo:
							case EGroupCMDType.PRIO_ACT_CastSkill:
							case EGroupCMDType.PRIO_ACT_AddBuff:
								GroupAIComp.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("GroupAI", "优先命令任务完成！！！");
								break;
							case EGroupCMDType.ToggleActivateGroupAI:
								GroupAIComp.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("GroupAI", "激活/关闭群体AI任务完成！！！");
								break;
							case EGroupCMDType.Attack:
								GroupAIComp.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("GroupAI", "攻击任务完成！！！");
								break;
							case EGroupCMDType.Wander:
								GroupAIComp.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("GroupAI", "游走任务完成！！！");
								break;
							}
						}
						ActionTemplate.EndAction();
						ClearPkgAndTemplate();
						break;
					}
					if (DebugConfig.GroupAI)
					{
						GroupAIComp.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("GroupAI", value, 1);
					}
				}
				else if (ActionTemplate.CanEndActionWhenNoActionEffectiveTime)
				{
					ActionTemplate.EndAction();
					TryRecoverAttackTokenAndClear(ERecoverTokenReason.Overtime);
				}
				else if (DebugConfig.GroupAI)
				{
					string value2 = "任务已超时！等待结束！";
					GroupAIComp.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("GroupAI", value2, 1);
				}
			}
			else
			{
				TryRecoverAttackTokenAndClear(ERecoverTokenReason.InValid);
			}
		}

		public void FillPkgAndTemplate(GroupAIActionPkg _AIActionPkg)
		{
			AIActionPkg = _AIActionPkg;
			ActionTemplate = GroupAIComp.GetMatchActionTemplate(AIActionPkg.CMDType);
			if (IsValid())
			{
				ActionTemplate.ActionState = EGroupPriorityActionState.WaitForBegin;
				GroupAIComp.GroupAIData.IsInAction = true;
				if (AIActionPkg.CMDType == EGroupCMDType.PRIO_ACT_AddBuff || AIActionPkg.CMDType == EGroupCMDType.PRIO_ACT_CastSkill || AIActionPkg.CMDType == EGroupCMDType.PRIO_ACT_MoveTo)
				{
					GroupAIComp.GroupAIData.IsInPriorityAction = true;
				}
			}
		}

		public bool IsValid()
		{
			if (AIActionPkg != null)
			{
				return ActionTemplate != null;
			}
			return false;
		}

		private void ClearPkgAndTemplate()
		{
			AIActionPkg = null;
			ActionTemplate = null;
			if (GroupAIComp != null && GroupAIComp.GroupAIData != null)
			{
				GroupAIComp.GroupAIData.IsInAction = false;
				GroupAIComp.GroupAIData.IsInPriorityAction = false;
			}
		}

		private void TryRecoverAttackTokenAndClear(ERecoverTokenReason RecoverTokenReason)
		{
			if (AIActionPkg != null && GroupAIComp != null && AIActionPkg.CMDType == EGroupCMDType.Attack)
			{
				GroupAIComp.BGSEventCollection.Evt_BGS_RecoverAttackToken.Invoke(GroupAIComp.GetOwnerEntity(), RecoverTokenReason);
			}
			ClearPkgAndTemplate();
		}

		public void EndCurrentAction(ERecoverTokenReason EndReason)
		{
			if (IsValid())
			{
				ActionTemplate.EndAction();
				TryRecoverAttackTokenAndClear(EndReason);
			}
		}

		public bool GetCurrentActionType(out EGroupCMDType CurrentType)
		{
			CurrentType = EGroupCMDType.ToggleActivateGroupAI;
			if (IsValid())
			{
				CurrentType = AIActionPkg.CMDType;
				return true;
			}
			return false;
		}
	}

	private static Dictionary<EGroupAIMoveGoal, (float, float, float, EUnitAICrowdQualityLevel)> CrowdParamDict = new Dictionary<EGroupAIMoveGoal, (float, float, float, EUnitAICrowdQualityLevel)>
	{
		{
			EGroupAIMoveGoal.None,
			(0f, 0f, 0f, EUnitAICrowdQualityLevel.Medium)
		},
		{
			EGroupAIMoveGoal.Close2HotZone,
			(8f, 2000f, 4500f, EUnitAICrowdQualityLevel.Good)
		},
		{
			EGroupAIMoveGoal.Move2HotZonePoint,
			(8f, 2000f, 4500f, EUnitAICrowdQualityLevel.High)
		},
		{
			EGroupAIMoveGoal.Move2EnterBattlePos,
			(8f, 2000f, 4500f, EUnitAICrowdQualityLevel.High)
		},
		{
			EGroupAIMoveGoal.RangeEQSRun,
			(4f, 1000f, 1000f, EUnitAICrowdQualityLevel.High)
		},
		{
			EGroupAIMoveGoal.Attack,
			(1f, 1000f, 1000f, EUnitAICrowdQualityLevel.Low)
		}
	};

	private MoveToPosAction MoveAction;

	private NormalSkillAction SkillAction;

	private AddBuffAction BuffAction;

	private ToggleActivateGroupAIAction ActiveGroupAIAction;

	private AttackAction FSMAttackAction;

	private WanderAction FSMWanderAction;

	private BUC_GroupAIData GroupAIData;

	private IBUC_TickRateData TickRateData;

	private IBUC_FsmData FsmData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_AIData AIData;

	private IBGC_GroupAIMgrData GroupAIMgrData;

	private IBGC_LocalPlayerSharedData LocalPlayerSharedData;

	private IBGC_AnimationSyncData AnimationSyncData;

	private PriorityQueue<GroupAIActionPkg> GroupAIActionPkgQue = new PriorityQueue<GroupAIActionPkg>();

	private GroupAIActionWrap CurrentUseAIActionWrap;

	private bool IsTianbingPerf;

	private float UpdateHotZonePointTimer;

	private static float UPDATE_HOTZONEPOINT_INTERVAL_MIN = 3f;

	private static float UPDATE_HOTZONEPOINT_INTERVAL_MAX = 5f;

	private static List<EGroupAIHotZoneType> HotZoneTypeLoopQue = new List<EGroupAIHotZoneType> { EGroupAIHotZoneType.MiddleDistanceAtkHotZone };

	private float WanderTriggerTimer;

	private static float WANDER_INTERVAL_MIN = 5f;

	private static float WANDER_INTERVAL_MAX = 7f;

	private T CreateActionTemplate<T>() where T : GroupActionTemplate, new()
	{
		T val = new T();
		val.Init(this);
		return val;
	}

	public override void OnAttach()
	{
		GroupAIData = RequireWritableData<BUC_GroupAIData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		FsmData = RequireReadOnlyData<IBUC_FsmData, BUC_FsmData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		AIData = RequireReadOnlyData<IBUC_AIData, BUC_AIData>();
		GroupAIMgrData = RequireReadOnlyGameStateData<IBGC_GroupAIMgrData, BGC_GroupAIMgrData>();
		LocalPlayerSharedData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		AnimationSyncData = RequireReadOnlyGameStateData<IBGC_AnimationSyncData, BGC_AnimationSyncData>();
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		base.BUSEventCollection.Evt_GroupAIRequestTask += new Del_GroupAIRequestTask(OnGroupAIRequestTask);
		base.BUSEventCollection.EVt_NotifyAIActionFinish += new Del_NotifyAIActionFinish(OnNotifyAIActionFinish);
		base.BUSEventCollection.Evt_SetGroupAIWanderHotZonePoint += new Del_SetGroupAIWanderHotZonePoint(OnSetGroupAIWanderHotZonePoint);
		base.BUSEventCollection.Evt_ClearMeleeAttackGroupAIHotZonePoint += new Del_Void(OnClearMeleeAttackGroupAIHotZonePoint);
		base.BUSEventCollection.Evt_NotifyTargetInfoChanged += new Del_NotifyTargetInfoChanged(OnNotifyTargetInfoChanged);
		base.BUSEventCollection.Evt_TriggerFsmEvent += new Del_Void_GameplayTag(OnTriggerFsmEvent);
		base.BUSEventCollection.Evt_FSMEventTrigger += new Del_Void_FsmEvent(OnFsmEventTrigger);
	}

	public override void PreBeginPlay()
	{
		GroupAIData.Init();
		GroupAIActionPkgQue = new PriorityQueue<GroupAIActionPkg>();
		CurrentUseAIActionWrap = new GroupAIActionWrap(this);
		ActiveGroupAIAction = CreateActionTemplate<ToggleActivateGroupAIAction>();
		FSMAttackAction = CreateActionTemplate<AttackAction>();
		FSMWanderAction = CreateActionTemplate<WanderAction>();
		MoveAction = CreateActionTemplate<MoveToPosAction>();
		SkillAction = CreateActionTemplate<NormalSkillAction>();
		BuffAction = CreateActionTemplate<AddBuffAction>();
		WanderTriggerTimer = 0f;
		UpdateHotZonePointTimer = 0f;
		int actorResID = GetActorResID();
		int num = actorResID * 100 + 1;
		int num2 = actorResID * 100 + 99;
		for (int i = num; i <= num2; i++)
		{
			FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(i);
			FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(i, Owner);
			if (skillAIDesc != null && skillSDesc != null && skillAIDesc.CanUseInGroupAIAttack == EGSYesNo.Yes)
			{
				if (skillAIDesc.AttackBias == EGroupAIAttackBias.RangeAttack)
				{
					GroupAIData.GroupAISkillListForRangeAttack.Add(i);
				}
				else
				{
					GroupAIData.GroupAISkillListForMeleeAttack.Add(i);
				}
			}
		}
		IsTianbingPerf = false;
		BUTamerActor bUTamerActor = (Owner as BGUCharacterCS)?.GetTamerOwner() as BUTamerActor;
		bool value = default(bool);
		if (bUTamerActor != null && bUTamerActor.ConfigInfoComp.FlagConfig.MonsterRejectTags.TryGetValue(EActorCompRejectFlag.TianbingPerf.ToString(), out value) && value)
		{
			IsTianbingPerf = true;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (TickRateData.CanTickFor200msInterval(out var AccumulatedDeltaTime, out var DifferenceTimeToLast100ms, out var DifferenceTimeToLast200ms, out var DifferenceTimeToLast500ms, out var DifferenceTimeToLast1000ms))
		{
			TickForGroupAIActionWrap(AccumulatedDeltaTime);
		}
		if (TickRateData.CanTickFor1000msInterval(out AccumulatedDeltaTime, out DifferenceTimeToLast1000ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast100ms))
		{
			TickForUpdateHotZonePoint(AccumulatedDeltaTime);
		}
		if (TickRateData.CanTickFor100msInterval(out AccumulatedDeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms))
		{
			TickForUpdateTROCullLevel();
		}
		if (GSGameplayCVar.CVar_GroupAIDebugInfoEnableHotZoneDebug.GetValueInGameThread() == 0)
		{
			return;
		}
		if (WanderTriggerTimer >= 0f)
		{
			USystemLibrary.DrawDebugString(Owner, Owner.GetActorLocation(), WanderTriggerTimer.ToString("F2"), null, FLinearColor.White, 0f);
		}
		if (GroupAIData.GetGroupAIHotZonePointPos(out var HotZonePointPos))
		{
			FVector cachedLocalPlayerLocation = LocalPlayerSharedData.CachedLocalPlayerLocation;
			FRotator cachedLocalPlayerRotation = LocalPlayerSharedData.CachedLocalPlayerRotation;
			FRotator cameraRotation = LocalPlayerSharedData.FirstLocalPlayerCamMgr.GetCameraRotation();
			FVector fVector = BGUFuncLibAICS.BGUGetHotZonePointWorldLocation(cachedLocalPlayerLocation, cachedLocalPlayerRotation, cameraRotation, HotZonePointPos);
			USystemLibrary.DrawDebugPoint(Owner, fVector, 10f, FLinearColor.Yellow);
			USystemLibrary.DrawDebugArrow(Owner, BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), fVector, 10f, FLinearColor.Yellow);
		}
		if (CurrentUseAIActionWrap.GetCurrentActionType(out var CurrentType))
		{
			switch (CurrentType)
			{
			case EGroupCMDType.Attack:
			{
				FVector fVector3 = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
				FVector lineEnd2 = fVector3;
				lineEnd2.Z += 500f;
				USystemLibrary.DrawDebugArrow(Owner, fVector3, lineEnd2, 30f, FLinearColor.Orange, 0f, 150f);
				break;
			}
			case EGroupCMDType.Wander:
			{
				FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
				FVector lineEnd = fVector2;
				lineEnd.Z += 500f;
				USystemLibrary.DrawDebugArrow(Owner, fVector2, lineEnd, 30f, FLinearColor.Red, 0f, 150f);
				break;
			}
			}
		}
	}

	private void TickForGroupAIActionWrap(float DeltaTime)
	{
		if (Owner == null || FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_LIFE_RETURNHOME))
		{
			return;
		}
		if (GroupAIActionPkgQue.Size() > 0)
		{
			IList<GroupAIActionPkg> allItems = GroupAIActionPkgQue.GetAllItems();
			if (allItems != null)
			{
				for (int num = allItems.Count - 1; num >= 0; num--)
				{
					GroupAIActionPkg groupAIActionPkg = allItems[num];
					if (groupAIActionPkg != null && groupAIActionPkg.ActionEffectiveTime > 0f)
					{
						groupAIActionPkg.ActionEffectiveTime -= DeltaTime;
						if (groupAIActionPkg.ActionEffectiveTime <= 0f)
						{
							if (groupAIActionPkg.CMDType == EGroupCMDType.Attack)
							{
								base.BGSEventCollection.Evt_BGS_RecoverAttackToken.Invoke(GetOwnerEntity(), ERecoverTokenReason.Overtime);
							}
							GroupAIActionPkgQue.Remove(groupAIActionPkg);
						}
					}
				}
			}
		}
		CurrentUseAIActionWrap.UpdateActionTemplate(DeltaTime, Owner);
		if (GroupAIActionPkgQue.Size() > 0)
		{
			bool flag = false;
			if (!CurrentUseAIActionWrap.IsValid())
			{
				flag = CheckCanGroupActionBegin_State();
			}
			else
			{
				GroupAIActionPkg groupAIActionPkg2 = GroupAIActionPkgQue.PeekFirst();
				if (CurrentUseAIActionWrap.GetCurrentActionType(out var CurrentType) && groupAIActionPkg2.CMDType < CurrentType)
				{
					flag = CheckCanGroupActionBegin_State();
				}
			}
			if (flag)
			{
				if (CurrentUseAIActionWrap.IsValid())
				{
					CurrentUseAIActionWrap.EndCurrentAction(ERecoverTokenReason.Interrupt);
				}
				CurrentUseAIActionWrap.FillPkgAndTemplate(GroupAIActionPkgQue.PopFirst());
			}
		}
		if (GroupAIData.IsCtrlByGroupAI && !CurrentUseAIActionWrap.IsValid() && GroupAIActionPkgQue.Size() == 0)
		{
			WanderTriggerTimer -= DeltaTime;
			if (WanderTriggerTimer < 0f)
			{
				WanderTriggerTimer = FMath.RandRange(1, 2);
				OnGroupAIRequestTask(-1, 0f, EGroupCMDType.Wander, new GAAI_FSM_2_Wander
				{
					MaxWanderTime = FMath.RandRange(3, 5)
				}, 0f, 0f);
			}
		}
	}

	private void TickForUpdateHotZonePoint(float DeltaTime)
	{
		if (!GroupAIData.IsCtrlByGroupAI)
		{
			return;
		}
		UpdateHotZonePointTimer -= DeltaTime;
		if (!(UpdateHotZonePointTimer <= 0f))
		{
			return;
		}
		UpdateHotZonePointTimer = FMath.RandRange(UPDATE_HOTZONEPOINT_INTERVAL_MIN, UPDATE_HOTZONEPOINT_INTERVAL_MAX);
		if (GroupAIData.GetGroupAIHotZonePointInfo(out var HPI) && (HPI.HotZoneIdx == EGroupAIHotZoneType.MeleeAtkHotZone || HPI.HotZoneIdx == EGroupAIHotZoneType.ShortDistanceAtkHotZone || HPI.HotZoneIdx == EGroupAIHotZoneType.RangeAtkHotZone))
		{
			return;
		}
		FVector cachedLocalPlayerLocation = LocalPlayerSharedData.CachedLocalPlayerLocation;
		FRotator cachedLocalPlayerRotation = LocalPlayerSharedData.CachedLocalPlayerRotation;
		FRotator cachedLocalPlayerCameraRotation = LocalPlayerSharedData.CachedLocalPlayerCameraRotation;
		FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		float HotZoneRadius;
		bool flag = !CheckIsInHotZone(HPI.HotZoneIdx, out HotZoneRadius);
		if (!flag)
		{
			FVector v2 = BGUFuncLibAICS.BGUGetHotZonePointWorldLocation(cachedLocalPlayerLocation, cachedLocalPlayerRotation, cachedLocalPlayerCameraRotation, HPI.RelativePos);
			flag = FVector.Dist2D(v, v2) > HotZoneRadius;
		}
		if (!flag)
		{
			return;
		}
		OnSetGroupAIWanderHotZonePoint(HotZonePointInfo.Null);
		bool flag2 = false;
		foreach (EGroupAIHotZoneType item in HotZoneTypeLoopQue)
		{
			if (!GroupAIMgrData.HotZonePointInfoDict.TryGetValue(item, out var value) || value.SelectNum >= value.HotZonePointInfoList.Count || value.HotZonePointInfoList == null)
			{
				continue;
			}
			float num = -1f;
			int index = -1;
			for (int num2 = value.HotZonePointInfoList.Count - 1; num2 >= 0; num2--)
			{
				HotZonePointInfo hotZonePointInfo = value.HotZonePointInfoList[num2];
				if (!hotZonePointInfo.HasAlreadyBeenSelected)
				{
					FVector v3 = BGUFuncLibAICS.BGUGetHotZonePointWorldLocation(cachedLocalPlayerLocation, cachedLocalPlayerRotation, cachedLocalPlayerCameraRotation, hotZonePointInfo.RelativePos);
					float num3 = FVector.Dist2D(v, v3);
					if (num < 0f || num > num3)
					{
						index = num2;
						num = num3;
					}
				}
			}
			if (num > 0f)
			{
				flag2 = true;
				OnSetGroupAIWanderHotZonePoint(value.HotZonePointInfoList[index]);
				break;
			}
		}
		if (!flag2 && GroupAIMgrData.HotZonePointInfoDict.TryGetValue(EGroupAIHotZoneType.LongDistanceAtkHotZone, out var value2) && value2.HotZonePointInfoList != null)
		{
			int index2 = FMath.RandRange(1, value2.HotZonePointInfoList.Count) - 1;
			OnSetGroupAIWanderHotZonePoint(value2.HotZonePointInfoList[index2]);
			WanderTriggerTimer = 0f;
		}
	}

	private void TickForUpdateTROCullLevel()
	{
		GroupAIData.GroupAITROCullType = EGroupAITROCullType.HighPriority;
		if (!GroupAIData.IsCtrlByGroupAI)
		{
			return;
		}
		EGroupAIHotZoneType locateHotZoneType = GetLocateHotZoneType(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), LocalPlayerSharedData.CachedLocalPlayerLocation, LocalPlayerSharedData.CachedLocalPlayerCameraRotation);
		if (CurrentUseAIActionWrap.GetCurrentActionType(out var CurrentType))
		{
			switch (CurrentType)
			{
			case EGroupCMDType.Attack:
				GroupAIData.GroupAITROCullType = EGroupAITROCullType.HighPriority;
				break;
			case EGroupCMDType.Wander:
				switch (locateHotZoneType)
				{
				case EGroupAIHotZoneType.MeleeAtkHotZone:
				case EGroupAIHotZoneType.ShortDistanceAtkHotZone:
					GroupAIData.GroupAITROCullType = EGroupAITROCullType.WanderInShort;
					break;
				case EGroupAIHotZoneType.RangeAtkHotZone:
				case EGroupAIHotZoneType.MiddleDistanceAtkHotZone:
					GroupAIData.GroupAITROCullType = EGroupAITROCullType.WanderInMiddle;
					break;
				case EGroupAIHotZoneType.LongDistanceAtkHotZone:
					GroupAIData.GroupAITROCullType = EGroupAITROCullType.WanderInLong;
					break;
				default:
					GroupAIData.GroupAITROCullType = EGroupAITROCullType.WanderOut;
					break;
				}
				break;
			}
		}
		else
		{
			switch (locateHotZoneType)
			{
			case EGroupAIHotZoneType.MeleeAtkHotZone:
			case EGroupAIHotZoneType.ShortDistanceAtkHotZone:
				GroupAIData.GroupAITROCullType = EGroupAITROCullType.NoActionInShort;
				break;
			case EGroupAIHotZoneType.RangeAtkHotZone:
			case EGroupAIHotZoneType.MiddleDistanceAtkHotZone:
				GroupAIData.GroupAITROCullType = EGroupAITROCullType.NoActionInMiddle;
				break;
			case EGroupAIHotZoneType.LongDistanceAtkHotZone:
				GroupAIData.GroupAITROCullType = EGroupAITROCullType.NoActionInLong;
				break;
			default:
				GroupAIData.GroupAITROCullType = EGroupAITROCullType.NoActionOut;
				break;
			}
		}
		if (IsTianbingPerf)
		{
			if (TickRateData.GetDistanceToPlayer() <= 1500f)
			{
				base.BUSEventCollection.Evt_ResetIsEnableCollisionHitMove.Invoke(ECollisionHitMoveEnableReqType.GroupAIPerf);
			}
			else
			{
				base.BUSEventCollection.Evt_SetIsEnableCollisionHitMove.Invoke(IsEnableCollisionHitMove: false, ECollisionHitMoveEnableReqType.GroupAIPerf);
			}
		}
	}

	private void CalcWanderTimeByHotZone(FVector PerformerActorLocation, out float WanderTriggerTime)
	{
		WanderTriggerTime = FMath.RandRange(WANDER_INTERVAL_MIN, WANDER_INTERVAL_MAX);
		HotZonePointInfo HPI;
		bool groupAIHotZonePointInfo = GroupAIData.GetGroupAIHotZonePointInfo(out HPI);
		switch (GetLocateHotZoneType(PerformerActorLocation, LocalPlayerSharedData.CachedLocalPlayerLocation, LocalPlayerSharedData.CachedLocalPlayerCameraRotation))
		{
		case EGroupAIHotZoneType.MeleeAtkHotZone:
		case EGroupAIHotZoneType.ShortDistanceAtkHotZone:
			WanderTriggerTime = FMath.RandRange(1, 3);
			return;
		case EGroupAIHotZoneType.RangeAtkHotZone:
		case EGroupAIHotZoneType.MiddleDistanceAtkHotZone:
			WanderTriggerTime = FMath.RandRange(4, 7);
			return;
		case EGroupAIHotZoneType.LongDistanceAtkHotZone:
			WanderTriggerTime = FMath.RandRange(8, 15);
			return;
		}
		if (groupAIHotZonePointInfo)
		{
			WanderTriggerTime = FMath.RandRange(1, 3);
		}
		else
		{
			WanderTriggerTime = FMath.RandRange(16, 25);
		}
	}

	private bool CheckCanGroupActionBegin_State()
	{
		if (UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			return false;
		}
		if (UnitStateData.HasState(EBGUUnitState.Beatback))
		{
			return false;
		}
		return true;
	}

	private bool CheckIsInHotZone(EGroupAIHotZoneType GroupAIHotZoneType, out float HotZoneRadius)
	{
		HotZoneRadius = 0f;
		FVector cachedLocalPlayerLocation = LocalPlayerSharedData.CachedLocalPlayerLocation;
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		float num = FVector.Dist2D(fVector, cachedLocalPlayerLocation);
		if (GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset != null)
		{
			switch (GroupAIHotZoneType)
			{
			case EGroupAIHotZoneType.ShortDistanceAtkHotZone:
				HotZoneRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.ShortBattleCircleRadius;
				return num <= HotZoneRadius;
			case EGroupAIHotZoneType.MeleeAtkHotZone:
				HotZoneRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.ShortBattleCircleRadius;
				if (num <= HotZoneRadius)
				{
					FRotator cachedLocalPlayerRotation2 = LocalPlayerSharedData.CachedLocalPlayerRotation;
					if (MathLib.Abs(BGUFuncLibAICS.BGUCalAngleWith2PointAndDir(cachedLocalPlayerLocation, cachedLocalPlayerRotation2, fVector)) <= (float)GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MeleeAttackHotZoneOneSideAngle)
					{
						return true;
					}
				}
				return false;
			case EGroupAIHotZoneType.MiddleDistanceAtkHotZone:
				HotZoneRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MiddleBattleCircleRadius;
				return num <= HotZoneRadius;
			case EGroupAIHotZoneType.RangeAtkHotZone:
				HotZoneRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MiddleBattleCircleRadius;
				if (num <= HotZoneRadius)
				{
					FRotator cachedLocalPlayerRotation = LocalPlayerSharedData.CachedLocalPlayerRotation;
					if (MathLib.Abs(BGUFuncLibAICS.BGUCalAngleWith2PointAndDir(cachedLocalPlayerLocation, cachedLocalPlayerRotation, fVector)) <= (float)GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.RangeAttackHotZoneOneSideAngle)
					{
						return true;
					}
				}
				return false;
			case EGroupAIHotZoneType.LongDistanceAtkHotZone:
				HotZoneRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.LongBattleCircleRadius;
				return num <= HotZoneRadius;
			case EGroupAIHotZoneType.OutsideHotZone:
				HotZoneRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.LongBattleCircleRadius;
				return num > HotZoneRadius;
			}
		}
		return false;
	}

	private EGroupAIHotZoneType GetLocateHotZoneType(FVector PerformerActorLocation, FVector PlayerActorLocation, FRotator PlayerCameraRotation)
	{
		float num = FVector.Dist2D(PerformerActorLocation, PlayerActorLocation);
		float val = BGUFuncLibAICS.BGUCalAngleWith2PointAndDir(PlayerActorLocation, PlayerCameraRotation, PerformerActorLocation);
		int shortBattleCircleRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.ShortBattleCircleRadius;
		int middleBattleCircleRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MiddleBattleCircleRadius;
		int longBattleCircleRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.LongBattleCircleRadius;
		int meleeAttackHotZoneInnerRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MeleeAttackHotZoneInnerRadius;
		int meleeAttackHotZoneOneSideAngle = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MeleeAttackHotZoneOneSideAngle;
		int rangeAttackHotZoneOneSideAngle = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.RangeAttackHotZoneOneSideAngle;
		if (num > (float)longBattleCircleRadius)
		{
			return EGroupAIHotZoneType.OutsideHotZone;
		}
		if (num <= (float)longBattleCircleRadius && num > (float)middleBattleCircleRadius)
		{
			return EGroupAIHotZoneType.LongDistanceAtkHotZone;
		}
		if (num <= (float)middleBattleCircleRadius && num > (float)shortBattleCircleRadius)
		{
			if (MathLib.Abs(val) <= (float)rangeAttackHotZoneOneSideAngle)
			{
				return EGroupAIHotZoneType.RangeAtkHotZone;
			}
			return EGroupAIHotZoneType.MiddleDistanceAtkHotZone;
		}
		if (num <= (float)shortBattleCircleRadius)
		{
			if (MathLib.Abs(val) <= (float)meleeAttackHotZoneOneSideAngle && num > (float)meleeAttackHotZoneInnerRadius)
			{
				return EGroupAIHotZoneType.MeleeAtkHotZone;
			}
			return EGroupAIHotZoneType.ShortDistanceAtkHotZone;
		}
		return EGroupAIHotZoneType.None;
	}

	private GroupActionTemplate GetMatchActionTemplate(EGroupCMDType GroupCMDType)
	{
		return GroupCMDType switch
		{
			EGroupCMDType.PRIO_ACT_MoveTo => MoveAction, 
			EGroupCMDType.PRIO_ACT_CastSkill => SkillAction, 
			EGroupCMDType.PRIO_ACT_AddBuff => BuffAction, 
			EGroupCMDType.ToggleActivateGroupAI => ActiveGroupAIAction, 
			EGroupCMDType.Attack => FSMAttackAction, 
			EGroupCMDType.Wander => FSMWanderAction, 
			_ => null, 
		};
	}

	private bool CheckIsFarAwayFromHotZone()
	{
		BGWGroupAIBattleHotZoneConfigDataAsset groupAIBattleHotZoneConfigDataAsset = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset;
		if (groupAIBattleHotZoneConfigDataAsset != null)
		{
			return (BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner) - LocalPlayerSharedData.CachedLocalPlayerLocation).Size2D() >= (float)groupAIBattleHotZoneConfigDataAsset.LongBattleCircleRadius;
		}
		return false;
	}

	private void OnGroupAIRequestTask(int ReqID, float Score, EGroupCMDType GroupCMDType, IGroupAIActionInfo GroupAIActionInfo, float NormalTaskWaitTime, float BeginNoiseTime)
	{
		if (Owner == null || GroupAIActionPkgQue == null)
		{
			return;
		}
		if (DebugConfig.GroupAI)
		{
			FSlateColor color = new FSlateColor
			{
				SpecifiedColor = FLinearColor.Red
			};
			string value = "异常！！！";
			EGroupAIAttackBias actionAIAttackBias = GroupAIActionInfo.GetActionAIAttackBias();
			if (actionAIAttackBias == EGroupAIAttackBias.MeleeAttack || actionAIAttackBias == EGroupAIAttackBias.RangeAttack)
			{
				color = new FSlateColor
				{
					SpecifiedColor = FLinearColor.Green
				};
				value = $"得分: {(int)Score}, 攻击倾向是：{actionAIAttackBias}，占据Token：{GroupAIActionInfo.GetCostToken()}";
			}
			else
			{
				switch (GroupCMDType)
				{
				case EGroupCMDType.PRIO_ACT_MoveTo:
				case EGroupCMDType.PRIO_ACT_CastSkill:
				case EGroupCMDType.PRIO_ACT_AddBuff:
					color = new FSlateColor
					{
						SpecifiedColor = FLinearColor.Green
					};
					value = "执行优先命令！";
					break;
				case EGroupCMDType.ToggleActivateGroupAI:
					if (GroupAIActionInfo is GAAI_EnableGroupAI gAAI_EnableGroupAI)
					{
						bool isEnable = gAAI_EnableGroupAI.IsEnable;
						color = new FSlateColor
						{
							SpecifiedColor = FLinearColor.Green
						};
						value = (isEnable ? "激活群体AI" : "关闭群体AI");
					}
					break;
				case EGroupCMDType.Wander:
					color = new FSlateColor
					{
						SpecifiedColor = FLinearColor.Yellow
					};
					value = $"进入游走，得分: {(int)Score}";
					break;
				}
			}
			base.BUSEventCollection.Evt_UpdateDebugUILamp.Invoke("GroupAI", color);
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("GroupAI", value);
		}
		float num = FMath.RandRange(0f, BeginNoiseTime);
		GroupAIActionPkgQue.Add(new GroupAIActionPkg(ReqID, GroupCMDType, GroupAIActionInfo, NormalTaskWaitTime + num, num));
	}

	private void OnNotifyAIActionFinish(EAINodeActionType FinishActionType)
	{
		if (GroupAIData.IsAIActionFinishDict.TryGetValue(FinishActionType, out var _))
		{
			GroupAIData.IsAIActionFinishDict[FinishActionType] = true;
		}
	}

	private void OnTriggerFsmEvent(FGameplayTag EventTag)
	{
		if (GroupAIData.IsCtrlByGroupAI && UGameplayTagLibrary.MatchesTag(EventTag, BGW_FlowUtils.NormalAIFsmEventTag.Validation, bExactMatch: false) && UGameplayTagLibrary.MatchesTag(EventTag, BGW_FlowUtils.NormalAIFsmEventTag.LifeTimeGoHome, bExactMatch: true))
		{
			ExitGroupAI(ERecoverTokenReason.IsInReturnHome);
			base.BUSEventCollection.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_GOHOME);
		}
	}

	private void OnFsmEventTrigger(EBGUFSMEventName EventId)
	{
		if (GroupAIData.IsCtrlByGroupAI && EventId == EBGUFSMEventName.FSM_EVENT_LIFE_GOHOME)
		{
			FGameplayTag lifeTimeGoHome = BGW_FlowUtils.NormalAIFsmEventTag.LifeTimeGoHome;
			if (GameplayTagExtension.IsValid(lifeTimeGoHome))
			{
				OnTriggerFsmEvent(lifeTimeGoHome);
			}
		}
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		ExitGroupAI(ERecoverTokenReason.Dead);
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		GroupAIData.Init();
		WanderTriggerTimer = 0f;
		UpdateHotZonePointTimer = 0f;
		ExitGroupAI(ERecoverTokenReason.ResetActorStatus);
		IsTianbingPerf = false;
		BUTamerActor bUTamerActor = (Owner as BGUCharacterCS)?.GetTamerOwner() as BUTamerActor;
		bool value = default(bool);
		if (bUTamerActor != null && bUTamerActor.ConfigInfoComp.FlagConfig.MonsterRejectTags.TryGetValue(EActorCompRejectFlag.TianbingPerf.ToString(), out value) && value)
		{
			IsTianbingPerf = true;
		}
	}

	private void ExitGroupAI(ERecoverTokenReason EndReason, bool bNeedStopCurrentAction = true)
	{
		if (Owner == null)
		{
			return;
		}
		if (CurrentUseAIActionWrap != null && bNeedStopCurrentAction)
		{
			CurrentUseAIActionWrap.EndCurrentAction(EndReason);
		}
		if (!GroupAIData.IsCtrlByGroupAI)
		{
			return;
		}
		GroupAIData.IsCtrlByGroupAI = false;
		if (GroupAIActionPkgQue.Size() > 0)
		{
			IList<GroupAIActionPkg> allItems = GroupAIActionPkgQue.GetAllItems();
			if (allItems != null)
			{
				for (int num = allItems.Count - 1; num >= 0; num--)
				{
					GroupAIActionPkg groupAIActionPkg = allItems[num];
					if (groupAIActionPkg.CMDType == EGroupCMDType.Attack || groupAIActionPkg.CMDType == EGroupCMDType.Wander || groupAIActionPkg.CMDType == EGroupCMDType.ToggleActivateGroupAI)
					{
						GroupAIActionPkgQue.Remove(groupAIActionPkg);
					}
				}
			}
		}
		base.BGSEventCollection.Evt_BGS_RemovePerformerInList.Invoke(GetOwnerEntity(), EndReason);
		OnSetGroupAIWanderHotZonePoint(HotZonePointInfo.Null);
		base.BUSEventCollection.Evt_SwitchBehaviourTree.Invoke(P1: false, "");
		base.BUSEventCollection.Evt_AIPauseFsmInstance.Invoke(P1: false);
		base.BUSEventCollection.Evt_ResetToDefaultFsmSolver.Invoke();
		base.BUSEventCollection.Evt_SetAINodeActionStop.Invoke();
		base.BUSEventCollection.Evt_NotifyUnitTriggerWakeupActivated.Invoke();
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.GroupAI, "<character>【GroupAIComp】" + Owner.GetName() + "</><action>主动脱离群体AI控制，归还全部Token，群体AI操控结束，换回自己的行为树</>");
		}
	}

	private void SetCrowdParamByMoveGoal(EGroupAIMoveGoal MoveGoal)
	{
		if (CrowdParamDict.TryGetValue(MoveGoal, out var value))
		{
			base.BUSEventCollection.Evt_AIChangeCrowdParam.Invoke(value.Item1, value.Item2, value.Item3, value.Item4);
		}
	}

	private void OnSetGroupAIWanderHotZonePoint(HotZonePointInfo HZPI)
	{
		if (GroupAIData.GetGroupAIHotZonePointInfo(out var HPI))
		{
			base.BGSEventCollection.Evt_BGS_ChangeHotZonePointSelectionStatus.Invoke(HPI.HotZoneIdx, HPI, IsSelect: false);
		}
		GroupAIData.CacheHZPI = HZPI;
		if (!HZPI.Equals(HotZonePointInfo.Null))
		{
			base.BGSEventCollection.Evt_BGS_ChangeHotZonePointSelectionStatus.Invoke(HZPI.HotZoneIdx, HZPI, IsSelect: true);
		}
	}

	private void OnClearMeleeAttackGroupAIHotZonePoint()
	{
		if (GroupAIData.GetGroupAIHotZonePointInfo(out var HPI) && (HPI.HotZoneIdx == EGroupAIHotZoneType.ShortDistanceAtkHotZone || HPI.HotZoneIdx == EGroupAIHotZoneType.MeleeAtkHotZone))
		{
			OnSetGroupAIWanderHotZonePoint(HotZonePointInfo.Null);
		}
	}

	private void OnNotifyTargetInfoChanged(UnitLockTargetInfo NewLockTargetInfo)
	{
		FUStGroupAISDesc groupAIDesc = BGW_GameDB.GetGroupAIDesc(GetActorResID());
		if (groupAIDesc == null)
		{
			return;
		}
		bool flag = true;
		if (NewLockTargetInfo.LockTargetActor != null && !GroupAIData.IsForceDisableGroupAI && groupAIDesc.DefaultCanJoinGroupAI == EGSYesNo.Yes)
		{
			IBUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(NewLockTargetInfo.LockTargetActor);
			if (unPersistentReadOnlyData != null && !unPersistentReadOnlyData.IsAI)
			{
				flag = false;
				base.BGSEventCollection.Evt_BGS_AddPerformerInfoToList.Invoke(Owner);
			}
		}
		if (flag)
		{
			ExitGroupAI(ERecoverTokenReason.InValidTarget);
		}
	}
}
