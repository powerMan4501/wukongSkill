using System.Collections.Generic;
using System.Text;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_AINodeComp : UActorCompBaseCS
{
	private abstract class ActionBase
	{
		protected BGUCharacterCS OwnerChr;

		protected b1.BUS_AINodeComp ParentComp;

		public abstract EAINodeActionType ActionType { get; }

		public void Init(BGUCharacterCS _OwnerChr, b1.BUS_AINodeComp _ParentComp)
		{
			OwnerChr = _OwnerChr;
			ParentComp = _ParentComp;
		}

		public void Release()
		{
			OwnerChr = null;
			ParentComp = null;
		}

		public abstract void InitAction(IAINodeActionInfo ActionInfo);

		public abstract void BeginAction();

		public abstract void TickAction(float DeltaTime);

		public virtual void EndAction(bool bSuccess = true)
		{
			if (ParentComp.AINodeData.CanFinishAINode == AINodeFinishState.Process)
			{
				ParentComp.AINodeData.CanFinishAINode = (bSuccess ? AINodeFinishState.Success : AINodeFinishState.Failed);
			}
		}

		public virtual void OnEQSFinish(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
		{
		}
	}

	private class ComboAction : ActionBase
	{
		private AINodeAction_ComboParamInfo ComboParamInfo;

		private static string AINodeName = "[ComboAction]";

		private int MoveReqIdx;

		private bool IsMoving;

		private bool IsRotating;

		private bool IsMovingBySkill;

		private bool HasTriggerRotateSkill;

		private bool bIsPursuitFailed;

		private int ComboSkillStage;

		private int ComboSkillLength;

		private int CurSkillIdx;

		private int CurSkillID;

		private bool TargetOutOfRange;

		private float PursuitAcceptableRadius;

		private bool FirstCastSkill;

		private bool TriggerEndAction;

		private string EndActionReasonStr;

		private bool IsFinishOwnerChrCombo;

		private float Timer = 2f;

		private float TIMER_DURATION = 2f;

		private IBUC_ArmorData ArmorData;

		private bool OnlyTryCastFirstSkill;

		private bool AlreadyCheckComboWindow;

		private static string InValidDataStr = "找不到Data，退出节点！";

		private static string InATKStateWhenBeginNodeStr = "进入节点时处于Atk状态中，退出节点！";

		private static string InAbortedStatesStr = "处于打断状态中，退出节点！";

		private static string ComboInterruptedByHRCounterattackStatesStr = "连招被反击技中断，退出节点！";

		private static string BTAbortedStr = "行为树中断，退出节点！";

		private static string BTAbortedStr_AbortWindow = "行为树中断，退出节点！（AttackState中，遇到AbortWindow）";

		private static string BTAbortedStr_ForceAbort = "行为树中断，退出节点！（Combo配置了强制打断）";

		private static string SkillArrayIsNoneStr = "连招池为空，退出节点！";

		private static string InValidComboLengthStr = "初始化后，不合理的连招长度，退出节点！";

		private static string CurrentStageSkillsInCDStr = "当前连招阶段全部技能都在CD（预制CD）中，连招套数-1，退出节点！";

		private static string LoseTargetStr = "失去目标，退出节点！";

		private static string InValidTargetStr = "目标非法，退出节点！";

		private static string FirstSkillCastFailedAndPursuitFailedStr = "触发Combo第一招失败，且追逐失败，退出节点！";

		private static string AllComboSkillCastFinishStr = "全部连招释放完毕，退出节点！";

		private static string PursuitFinishAndCastFailed = "追逐完成（或者失败）且释放技能失败，退出节点！";

		public override EAINodeActionType ActionType => EAINodeActionType.Combo;

		public override void InitAction(IAINodeActionInfo ActionInfo)
		{
			ComboParamInfo = ActionInfo as AINodeAction_ComboParamInfo;
			IsFinishOwnerChrCombo = false;
			TriggerEndAction = false;
			ArmorData = BGU_DataUtil.GetReadOnlyData<IBUC_ArmorData, BUC_ArmorData>(OwnerChr);
		}

		public override void BeginAction()
		{
			AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "==========================Combo节点流程开始==========================", EBattleInfoType.AINode_Combo);
			if (ComboParamInfo == null || ParentComp.UnitStateData == null || ParentComp.ChargeSkillData == null || ParentComp.AIData == null || ParentComp.ActionRequestData == null)
			{
				MarkEndActionParam(InValidDataStr, _IsFinishOwnerChrCombo: true);
			}
			else if (ParentComp.UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				MarkEndActionParam(InATKStateWhenBeginNodeStr);
			}
			else if (ParentComp.ShouldAbort())
			{
				MarkEndActionParam(InAbortedStatesStr);
			}
			else if (ComboParamInfo.bCanBeInterruptedByHRCounterattack && ArmorData.IsInPreHRCounterattacking())
			{
				MarkEndActionParam(ComboInterruptedByHRCounterattackStatesStr);
			}
			else
			{
				Init();
				if (ComboParamInfo.SkillSourceType == EZatoichiSkillSourceType.UseWithSurpriseSkilll)
				{
					OnlyTryCastFirstSkill = true;
				}
				if (ComboParamInfo.SkillArray.Count == 0)
				{
					MarkEndActionParam(SkillArrayIsNoneStr, _IsFinishOwnerChrCombo: true);
				}
				else if (ComboSkillStage >= ComboSkillLength)
				{
					MarkEndActionParam(InValidComboLengthStr, _IsFinishOwnerChrCombo: true);
				}
				else if (CheckIfAllSkillInCD())
				{
					MarkEndActionParam(CurrentStageSkillsInCDStr, _IsFinishOwnerChrCombo: true);
				}
				else
				{
					UnitLockTargetInfo nowUseTargetData = GetNowUseTargetData();
					if (nowUseTargetData == null)
					{
						MarkEndActionParam(LoseTargetStr, _IsFinishOwnerChrCombo: true);
					}
					else if (!TryCastBestComboSkill(nowUseTargetData, CastFakeComboSkill: false))
					{
						if (OnlyTryCastFirstSkill)
						{
							TriggerEndAction = true;
							AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "释放【见面礼技能】失败，不追逐直接退出Combo", EBattleInfoType.AINode_Combo);
						}
						else if (!TryCloseToTarget(nowUseTargetData))
						{
							MarkEndActionParam(FirstSkillCastFailedAndPursuitFailedStr, _IsFinishOwnerChrCombo: true);
						}
					}
				}
			}
			if (TriggerEndAction)
			{
				ExitComboNode();
			}
		}

		public override void TickAction(float DeltaTime)
		{
			if (ParentComp.AINodeData.IsBTAborted)
			{
				TickForJudgeIsAbort();
				if (TriggerEndAction)
				{
					ExitComboNode();
				}
				return;
			}
			if (ParentComp.ShouldAbort())
			{
				MarkEndActionParam(InAbortedStatesStr);
				ExitComboNode();
				return;
			}
			if (ComboParamInfo.bCanBeInterruptedByHRCounterattack && ArmorData.IsInPreHRCounterattacking())
			{
				MarkEndActionParam(ComboInterruptedByHRCounterattackStatesStr);
				ExitComboNode();
				return;
			}
			if (!TriggerEndAction)
			{
				UnitLockTargetInfo nowUseTargetData = GetNowUseTargetData();
				if (nowUseTargetData == null || nowUseTargetData.LockTargetActor == null)
				{
					MarkEndActionParam(LoseTargetStr, _IsFinishOwnerChrCombo: true);
				}
				else if (ComboSkillStage >= ComboSkillLength)
				{
					if (!ParentComp.UnitStateData.HasState(EBGUUnitState.Attacking))
					{
						MarkEndActionParam(AllComboSkillCastFinishStr, _IsFinishOwnerChrCombo: true);
					}
				}
				else if (ParentComp.UnitStateData.HasState(EBGUUnitState.Attacking))
				{
					if (!IsMoving && !IsRotating)
					{
						TryCastSkillInAtkState(nowUseTargetData);
					}
				}
				else if (CheckIfAllSkillInCD())
				{
					MarkEndActionParam(CurrentStageSkillsInCDStr, _IsFinishOwnerChrCombo: true);
				}
				else
				{
					if (ComboParamInfo.CanUpdateComboTargetWhenPursuit && ComboParamInfo.ComboTargetType == EComboTargetType.CurrentAITarget)
					{
						AActor lockTargetActor = ParentComp.TargetInfoData.GetTargetInfo().LockTargetActor;
						if (lockTargetActor != null)
						{
							AActor nowUseTarget = GetNowUseTarget();
							if (lockTargetActor != nowUseTarget)
							{
								ParentComp.BUSEventCollection.Evt_SetComboTarget.Invoke(lockTargetActor, ETargetSourceType.Combo_Update);
								nowUseTargetData = GetNowUseTargetData();
							}
						}
					}
					if (BGUFuncLibAICS.JudgeActorCanBeAITarget(ParentComp.Owner, nowUseTargetData.LockTargetActor, ParentComp.TeamRelationData, ParentComp.UnitHatredCacheData))
					{
						TickWhenNoAtkState(nowUseTargetData, DeltaTime);
					}
					else
					{
						MarkEndActionParam(InValidTargetStr, _IsFinishOwnerChrCombo: true);
					}
				}
			}
			if (TriggerEndAction && !ParentComp.UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				ExitComboNode();
			}
		}

		public override void EndAction(bool bSuccess = true)
		{
			base.EndAction(bSuccess);
			ParentComp.BUSEventCollection.Evt_ClearComboTarget.Invoke();
			if (BGUFunctionLibraryCS.BGUIsMoveActive(OwnerChr, MoveReqIdx))
			{
				BGUFuncLibForMove.CancelMove(OwnerChr);
			}
		}

		private void ExitComboNode()
		{
			AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, EndActionReasonStr, EBattleInfoType.AINode_Combo);
			ReduceComboNum();
			EndAction();
			AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "==========================Combo节点流程结束==========================", EBattleInfoType.AINode_Combo);
		}

		private void MarkEndActionParam(string _EndActionReasonStr, bool _IsFinishOwnerChrCombo = false)
		{
			TriggerEndAction = true;
			EndActionReasonStr = _EndActionReasonStr;
			IsFinishOwnerChrCombo = _IsFinishOwnerChrCombo;
		}

		private void Init()
		{
			MoveReqIdx = -1;
			IsMoving = false;
			IsMovingBySkill = false;
			IsRotating = false;
			HasTriggerRotateSkill = false;
			bIsPursuitFailed = false;
			CurSkillIdx = 0;
			CurSkillID = -1;
			ComboSkillStage = 0;
			PursuitAcceptableRadius = 0f;
			FirstCastSkill = true;
			OnlyTryCastFirstSkill = false;
			AlreadyCheckComboWindow = false;
			switch (ComboParamInfo.SkillSourceType)
			{
			case EZatoichiSkillSourceType.UseWithGroupAI:
				ComboSkillLength = 1;
				ComboParamInfo.SkillArray.Clear();
				if (ParentComp.AIData != null)
				{
					FComboSkill item2 = new FComboSkill
					{
						SkillID = ParentComp.AIData.GetGroupAISkillList()
					};
					if (item2.SkillID == null || item2.SkillID.Count == 0)
					{
						AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "群体AI技能为空！", EBattleInfoType.AINode_Combo);
					}
					else
					{
						ComboParamInfo.SkillArray.Add(item2);
					}
				}
				break;
			case EZatoichiSkillSourceType.UseWithSurpriseSkilll:
				ComboSkillLength = 1;
				ComboParamInfo.SkillArray.Clear();
				if (ParentComp.WakeUpData != null)
				{
					FComboSkill item3 = new FComboSkill
					{
						SkillID = ParentComp.WakeUpData.SurpriseSkillID
					};
					if (item3.SkillID == null || item3.SkillID.Count == 0)
					{
						AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "见面礼技能为空！", EBattleInfoType.AINode_Combo);
					}
					else
					{
						ComboParamInfo.SkillArray.Add(item3);
					}
				}
				break;
			case EZatoichiSkillSourceType.UseWithAvoidObstacle:
			{
				ComboSkillLength = 1;
				ComboParamInfo.SkillArray.Clear();
				if (ParentComp.AIData == null)
				{
					break;
				}
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "开始选择墙角脱困技能", EBattleInfoType.AINode_Combo);
				HashSet<int> hashSet = new HashSet<int>();
				switch (ComboParamInfo.SkillConfigMode)
				{
				case EEscapeSkillConfigMode.Single:
					hashSet.UnionWith(ComboParamInfo.SingleDirectionSkills);
					break;
				case EEscapeSkillConfigMode.Multiple:
					hashSet.UnionWith(FilterMultipleDirectionSkills());
					break;
				case EEscapeSkillConfigMode.FromSceneItem:
					if (ParentComp.SceneItemData != null)
					{
						BUC_SceneItemCommData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(ParentComp.SceneItemData.SceneItemCatch);
						if (readOnlyData != null)
						{
							hashSet.Add(readOnlyData.SkillID);
						}
					}
					break;
				default:
					AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, $"SkillConfigMode = {ComboParamInfo.SkillConfigMode} 时没有被处理！", EBattleInfoType.AINode_Combo);
					break;
				case EEscapeSkillConfigMode.None:
					break;
				}
				if (hashSet.Count == 0)
				{
					AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "未找到可用的墙角脱困技能！", EBattleInfoType.AINode_Combo);
				}
				FComboSkill item4 = new FComboSkill
				{
					SkillID = new List<int>(hashSet)
				};
				if (item4.SkillID.Count == 0)
				{
					AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "墙角脱困技能为空！", EBattleInfoType.AINode_Combo);
				}
				else
				{
					ComboParamInfo.SkillArray.Add(item4);
				}
				break;
			}
			case EZatoichiSkillSourceType.UseWithStalemateSkill:
			{
				ComboSkillLength = 1;
				ComboParamInfo.SkillArray.Clear();
				if (ParentComp.ConfigInfoData == null || ParentComp.BuffData == null)
				{
					break;
				}
				List<int> skillID = new List<int>();
				if (ParentComp.ConfigInfoData.StalemateInfoMap.Count > 0)
				{
					bool flag = false;
					foreach (KeyValuePair<int, FStalemateInfo> item5 in ParentComp.ConfigInfoData.StalemateInfoMap)
					{
						if (ParentComp.BuffData.HasBuff(item5.Key))
						{
							flag = true;
							skillID = item5.Value.StalemateSkillID;
							break;
						}
					}
					if (!flag && ParentComp.ConfigInfoData.StalemateInfoMap.TryGetValue(0, out var value))
					{
						skillID = value.StalemateSkillID;
					}
				}
				FComboSkill item = new FComboSkill
				{
					SkillID = skillID
				};
				if (item.SkillID == null || item.SkillID.Count == 0)
				{
					AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "僵持技能为空！", EBattleInfoType.AINode_Combo);
				}
				else
				{
					ComboParamInfo.SkillArray.Add(item);
				}
				break;
			}
			default:
				ComboSkillLength = CalcComboSkillLength();
				break;
			}
			if (ComboSkillLength > ComboParamInfo.SkillArray.Count)
			{
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, $"随机连招长度大于连招池长度！！！！ 当前随机长度 = {ComboSkillLength} 连招池长度 = {ComboParamInfo.SkillArray.Count}", EBattleInfoType.AINode_Combo);
				ComboSkillLength = ComboParamInfo.SkillArray.Count;
			}
			AActor comboTarget = BGUFunctionLibraryCS.BGUGetTarget(OwnerChr);
			if (ComboParamInfo.ComboTargetType == EComboTargetType.Player)
			{
				AActor nearestPlayerActor = BGU_UnrealWorldUtil.GetNearestPlayerActor(OwnerChr, BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr));
				if (nearestPlayerActor != null)
				{
					comboTarget = nearestPlayerActor;
				}
			}
			ParentComp.BUSEventCollection.Evt_SetComboTarget.Invoke(comboTarget, ETargetSourceType.Combo_NormalUse);
		}

		private void TickForJudgeIsAbort()
		{
			if (!ParentComp.UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				MarkEndActionParam(BTAbortedStr);
			}
			else if (ParentComp.UnitStateData.HasState(EBGUUnitState.InAbortWindow))
			{
				ParentComp.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("AbortWindow里Combo打断");
				MarkEndActionParam(BTAbortedStr_AbortWindow);
			}
			else if (ComboParamInfo.bCanBeForceAbort)
			{
				ParentComp.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("强制Combo打断");
				MarkEndActionParam(BTAbortedStr_ForceAbort);
			}
		}

		private void TickWhenNoAtkState(UnitLockTargetInfo TargetData, float DeltaTime)
		{
			AlreadyCheckComboWindow = false;
			if (IsMoving || IsRotating)
			{
				bool flag = false;
				if (HasTriggerRotateSkill && IsRotating)
				{
					flag = true;
				}
				else if (IsMovingBySkill && IsMoving)
				{
					flag = true;
				}
				else if (!BGUFunctionLibraryCS.BGUIsMoveActive(OwnerChr, MoveReqIdx))
				{
					flag = true;
				}
				else
				{
					Timer -= DeltaTime;
					if (Timer <= 0f)
					{
						Timer = TIMER_DURATION;
						flag = true;
					}
				}
				if ((flag || (bIsPursuitFailed && ComboParamInfo.ForceCastSkillAfterPursuitFailed)) && !TryCastBestComboSkill(TargetData, CastFakeComboSkill: true) && !TryCloseToTarget(TargetData))
				{
					MarkEndActionParam(PursuitFinishAndCastFailed, _IsFinishOwnerChrCombo: true);
				}
				return;
			}
			string arg = "尝试释放假连招失败！";
			bool flag2 = true;
			if (TryCastBestComboSkill(TargetData, CastFakeComboSkill: true))
			{
				flag2 = false;
			}
			else if (!TriggerEndAction && ComboParamInfo.PursuitInAllSkill)
			{
				IsMovingBySkill = false;
				HasTriggerRotateSkill = false;
				if (!TryCloseToTarget(TargetData))
				{
					arg = "移动失败且尝试释放假连招失败！";
					if (bIsPursuitFailed && ComboParamInfo.ForceCastSkillAfterPursuitFailed && TryCastBestComboSkill(TargetData, CastFakeComboSkill: true))
					{
						AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "位移失败，尝试强制释放假连招", EBattleInfoType.AINode_Combo);
						flag2 = false;
					}
				}
				else
				{
					flag2 = false;
				}
			}
			if (flag2)
			{
				MarkEndActionParam($"AttackingState结束！还剩下 {ComboSkillLength - ComboSkillStage} 招技能需要放！{arg}现在中断Combo，退出！");
			}
		}

		private void TryCastSkillInAtkState(UnitLockTargetInfo TargetData)
		{
			if ((!ParentComp.ChargeSkillData.IsCastingChargeSkill || ParentComp.ChargeSkillData.ChargeSkillStage == EChargeSkillStage.End) && ParentComp.UnitStateData.HasState(EBGUUnitState.InComboWindow) && (!AlreadyCheckComboWindow || ComboParamInfo.CanCheckCastSkillDuringWholeComboWindow))
			{
				if (!TryCastBestComboSkill(TargetData, CastFakeComboSkill: false))
				{
					AlreadyCheckComboWindow = true;
					AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "进入ComboWindow，但释放技能失败！", EBattleInfoType.AINode_Combo);
				}
				else
				{
					AlreadyCheckComboWindow = false;
				}
			}
		}

		private void ReduceComboNum()
		{
			if (IsFinishOwnerChrCombo || ComboParamInfo.EnableInterruptReduceCBNum || ComboParamInfo.SkillSourceType == EZatoichiSkillSourceType.UseWithSurpriseSkilll)
			{
				int num = ParentComp.AIData.GetMaxComboNum() - 1;
				num = FMath.Clamp(num, 0, num);
				ParentComp.BUSEventCollection.Evt_SetMaxComboNum.Invoke(num);
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, $"连招套数还剩：{num}", EBattleInfoType.AINode_Combo);
			}
		}

		private int CalcComboSkillLength()
		{
			if (ComboParamInfo.IsGetAdvanceComboLength)
			{
				if (ParentComp.AIData == null)
				{
					return 0;
				}
				int curComboLength = ParentComp.AIData.GetCurComboLength();
				if (curComboLength != 0)
				{
					AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, $"当前获取出的连招长度为 : {curComboLength}", EBattleInfoType.AINode_Combo);
				}
				else
				{
					AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "当前获取出的连招长度为0, 请检查相关配置项！", EBattleInfoType.AINode_Combo);
				}
				return curComboLength;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < ComboParamInfo.ComboSkillNumInfo.Count; i++)
			{
				num += ComboParamInfo.ComboSkillNumInfo[i].ComboPercenRatio;
			}
			if (num != 10000)
			{
				float num4 = (float)num / 10000f;
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, $"连招概率填错错误，当前全体概率为 = {num4}", EBattleInfoType.AINode_Combo);
			}
			int randomNumberInt = UB1Util.GetRandomNumberInt(1, num);
			for (int j = 0; j < ComboParamInfo.ComboSkillNumInfo.Count; j++)
			{
				num3 += ComboParamInfo.ComboSkillNumInfo[j].ComboPercenRatio;
				if (num3 >= randomNumberInt)
				{
					num2 = ComboParamInfo.ComboSkillNumInfo[j].ComboNum;
					break;
				}
			}
			AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, $"当前Combo节点随机出的连招长度为 : {num2}", EBattleInfoType.AINode_Combo);
			return num2;
		}

		private List<int> FilterMultipleDirectionSkills()
		{
			HashSet<int> hashSet = new HashSet<int>();
			if (ParentComp.SceneItemData != null)
			{
				BGUSceneItemBase sceneItemCatch = ParentComp.SceneItemData.SceneItemCatch;
				FVector inVector = OwnerChr.GetActorForwardVector();
				FVector inVector2 = OwnerChr.GetActorRightVector();
				if (ComboParamInfo.UseSocketDirection && OwnerChr.Mesh != null)
				{
					FVector socketLocation = OwnerChr.Mesh.GetSocketLocation(ComboParamInfo.DirectionBaseSocket);
					FVector socketLocation2 = OwnerChr.Mesh.GetSocketLocation(ComboParamInfo.ForwardSocket);
					FVector socketLocation3 = OwnerChr.Mesh.GetSocketLocation(ComboParamInfo.RightSocket);
					if (OwnerChr.Mesh.DoesSocketExist(ComboParamInfo.DirectionBaseSocket))
					{
						if (OwnerChr.Mesh.DoesSocketExist(ComboParamInfo.ForwardSocket))
						{
							inVector = (socketLocation2 - socketLocation).ProjectVectorOnToPlane(FVector.UpVector).GetSafeNormal();
						}
						if (OwnerChr.Mesh.DoesSocketExist(ComboParamInfo.RightSocket))
						{
							inVector2 = (socketLocation3 - socketLocation).ProjectVectorOnToPlane(FVector.UpVector).GetSafeNormal();
						}
					}
				}
				inVector.Normalize();
				inVector2.Normalize();
				FVector2D safeNormal = (BGUFuncLibActorTransformCS.BGUGetActorLocation(sceneItemCatch) - BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr)).Conv_VectorToVector2D().GetSafeNormal();
				float num = MathLib.DotProduct2D(inVector.Conv_VectorToVector2D(), safeNormal);
				float num2 = ((!(MathLib.DotProduct2D(inVector2.Conv_VectorToVector2D(), safeNormal) >= 0f)) ? ((float)UMathLibrary.ClampAngle(UMathLibrary.RadiansToDegrees(UMathLibrary.Acos(0f - num)) + 180.0, 180.0, 360.0)) : FMath.ClampAngle(FMath.RadiansToDegrees(FMath.Acos(num)), 0f, 180f));
				num2 = UMathLibrary.ClampAxis(num2 - ComboParamInfo.SectionsStartAngle);
				FAvoidObstacleSection fAvoidObstacleSection = ComboParamInfo.AvoidObstacleSections[(int)(num2 / ComboParamInfo.IntervalAngle)];
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, $"将{fAvoidObstacleSection.StartAngle}~{fAvoidObstacleSection.EndAngle}区域技能加入技能列表", EBattleInfoType.AINode_Combo);
				List<int> skillList = fAvoidObstacleSection.SkillList;
				if (skillList != null)
				{
					hashSet.UnionWith(skillList);
				}
			}
			return new List<int>(hashSet);
		}

		private bool CheckIfAllSkillInCD()
		{
			return BGUFuncLibAICS.BGUAICheckIsAllSkillsInCD(OwnerChr, ComboParamInfo.SkillArray[ComboSkillStage].SkillID);
		}

		private bool IsTraceSuccess(UnitLockTargetInfo TargetData)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append($"释放技能前进行射线检测, 检测距离为: {ComboParamInfo.TraceDistance}");
			FVector fVector = BGUFuncLibAICS.BGUAIGetTargetInfoRealLockPoint(TargetData);
			FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr);
			FVector safeNormal = (fVector - fVector2).GetSafeNormal();
			FVector endTrace = fVector2 + safeNormal * ComboParamInfo.TraceDistance;
			bool result = false;
			if (UBGUSelectUtil.LineTraceSimple(OwnerChr, fVector2, endTrace, ComboParamInfo.TraceTypeQuery, DebugConfig.AINodeDebug, out var HitResult, null) > 0)
			{
				stringBuilder.Append(", 检测到物件了");
				BGUCharacterCS bGUCharacterCS = HitResult.HitActor as BGUCharacterCS;
				if (bGUCharacterCS != null)
				{
					stringBuilder.Append(", 射线检测击中目标: " + bGUCharacterCS.GetName());
					if (TargetData.LockTargetActor != null && bGUCharacterCS == TargetData.LockTargetActor)
					{
						result = true;
						stringBuilder.Append(", 是可被击中单位!");
					}
					else
					{
						stringBuilder.Append(", 不是可被击中单位, 当前Combo节点中断, 并且减少连招套数!");
					}
				}
				else
				{
					stringBuilder.Append(", 不是单位, 当前Combo节点中断，并且减少连招套数！");
				}
			}
			else
			{
				stringBuilder.Append(", 什么都没检测到, 当前Combo节点中断，并且减少连招套数！");
			}
			AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, stringBuilder.ToString(), EBattleInfoType.AINode_Combo);
			return result;
		}

		private void SetGlobalLastAttackInfo(UnitLockTargetInfo TargetData)
		{
			if (OwnerChr != null)
			{
				float timeSeconds = UGameplayStatics.GetTimeSeconds(OwnerChr);
				ParentComp.BUSEventCollection.Evt_SetLastAttackTime.Invoke(timeSeconds);
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(TargetData.LockTargetActor);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_SetBeHitTime.Invoke(timeSeconds);
					bUS_GSEventCollection.Evt_SetLastAttackerID.Invoke(TargetData.LockTargetActor);
				}
			}
		}

		private bool TryCastBestComboSkill(UnitLockTargetInfo TargetData, bool CastFakeComboSkill)
		{
			AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "======尝试释放最佳Combo技能开始======", EBattleInfoType.AINode_Combo);
			AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, (!CastFakeComboSkill) ? "本次尝试是真连招/第一招" : "本次尝试是假连招（非AttackState内）", EBattleInfoType.AINode_Combo);
			bool flag = false;
			if (!ComboParamInfo.NeedTraceHitTargetBefore || IsTraceSuccess(TargetData))
			{
				TargetOutOfRange = ParentComp.AIData.GetIsMoveInValidByNav();
				bool flag2 = false;
				flag2 = ((!ComboParamInfo.ForceCastSkillAfterPursuitFailed) ? (ComboParamInfo.PursuitAnyWhere && TargetOutOfRange) : (bIsPursuitFailed || (ComboParamInfo.PursuitAnyWhere && TargetOutOfRange)));
				List<int> skillID = ComboParamInfo.SkillArray[ComboSkillStage].SkillID;
				CurSkillIdx = BGUFuncLibAICS.BGURequestAIUseBestComboSkill(OwnerChr, TargetData, skillID ?? new List<int>(), FirstCastSkill, ComboSkillLength, ComboSkillStage, ComboParamInfo.IsGetTopRandomSkill, ComboParamInfo.TopRandomSkillPercent, ComboParamInfo.EnableForceComboRelation, ComboParamInfo.EnableComboCondition, flag2, NeedCheckSkillCanCast: true, CastFakeComboSkill, CurSkillID);
				StringBuilder stringBuilder = new StringBuilder();
				if (CurSkillIdx > 0)
				{
					CurSkillID = ParentComp.ActionRequestData.GetLastSkillID();
					ComboSkillStage++;
					stringBuilder.Append(FirstCastSkill ? "释放第一招技能成功，当前技能ID为：" : (CastFakeComboSkill ? "释放技能成功，是假连招，当前技能ID为：" : "释放技能成功，且是真连招，当前技能ID为："));
					stringBuilder.Append($"{CurSkillID} 还剩下 {ComboSkillLength - ComboSkillStage}  招没有放");
					SetGlobalLastAttackInfo(TargetData);
					flag = true;
					FirstCastSkill = false;
				}
				else
				{
					if (!FirstCastSkill)
					{
						if (ComboParamInfo.EnableForceComboRelation)
						{
							switch (BGUFuncLibAICS.BGUAIGetComboSkillTypeBySkillID(OwnerChr, CurSkillID))
							{
							case EComboSkillType.RealComboSkillMiddle:
							case EComboSkillType.RealComboSkillEnd:
							case EComboSkillType.RealComboSkillBegin:
								MarkEndActionParam($"技能释放失败，且设置了强制连招关系（真连招关系），应当退出，正在释放的技能是：{CurSkillID}", _IsFinishOwnerChrCombo: true);
								break;
							case EComboSkillType.FakeComboSkill:
								if (CastFakeComboSkill)
								{
									MarkEndActionParam($"技能释放失败，且设置了强制连招关系（假连招关系），应当退出，正在释放的技能是：{CurSkillID}", _IsFinishOwnerChrCombo: true);
								}
								else
								{
									stringBuilder.Append($"开启了强制连招关系（假连招关系），正在释放的技能是：{CurSkillID}，当前处于ComboWindow中，应该等到AttackState结束再尝试释放技能");
								}
								break;
							}
						}
						else
						{
							stringBuilder.Append($"没有开启强制连招关系，正在释放的技能是：{CurSkillID}，当前处于ComboWindow中，应该等到AttackState结束再尝试释放技能");
						}
					}
					else
					{
						stringBuilder.Append("释放第一招失败，尝试移动到目标附近");
					}
					stringBuilder.Append($"还剩下 {ComboSkillLength - ComboSkillStage} 招没有放");
				}
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, stringBuilder.ToString(), EBattleInfoType.AINode_Combo);
			}
			else
			{
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "射线检测失败，尝试释放技能失败！！", EBattleInfoType.AINode_Combo);
			}
			if (flag)
			{
				ResetMoveFlag();
			}
			AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "======尝试释放最佳Combo技能结束======", EBattleInfoType.AINode_Combo);
			return flag;
		}

		private void GetAcceptableRadiusType(out bool IncludeSelfRadius, out bool IncludeTargetRadius)
		{
			IncludeSelfRadius = false;
			IncludeTargetRadius = false;
			switch (ComboParamInfo.MoveAcceptableRadiusType)
			{
			case EBGUMoveAcceptableRadiusType.IncludeSelf:
				IncludeSelfRadius = true;
				break;
			case EBGUMoveAcceptableRadiusType.IncludeTarget:
				IncludeTargetRadius = true;
				break;
			case EBGUMoveAcceptableRadiusType.BothIncludeSelfAndTarget:
				IncludeSelfRadius = true;
				IncludeTargetRadius = true;
				break;
			case EBGUMoveAcceptableRadiusType.NoInclude:
				break;
			}
		}

		private float CalcDisInSkillRange(float RangeMin, float RangeMax)
		{
			float result = 0f;
			if (RangeMin <= RangeMax)
			{
				result = (RangeMax - RangeMin) * ComboParamInfo.PursuitRangePos + RangeMin;
			}
			return result;
		}

		private float CalcPursuitDis(UnitLockTargetInfo TargetData, bool IncludeSelfRadius, bool IncludeTargetRadius)
		{
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			if (OwnerChr != null && TargetData != null && TargetData.LockTargetActor != null)
			{
				BGUCharacterCS bGUCharacterCS = TargetData.LockTargetActor as BGUCharacterCS;
				if (IncludeSelfRadius)
				{
					num = OwnerChr.CapsuleComponent.GetScaledCapsuleRadius();
				}
				if (IncludeTargetRadius && bGUCharacterCS.CapsuleComponent != null)
				{
					num2 = bGUCharacterCS.CapsuleComponent.GetScaledCapsuleRadius();
				}
				FVector v = BGUFuncLibAICS.BGUAIGetTargetInfoRealLockPoint(TargetData);
				float num4 = FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr), v) - (num + num2);
				num3 = ((num4 > 0f) ? num4 : 0f);
				foreach (int item in ComboParamInfo.SkillArray[ComboSkillStage].SkillID)
				{
					FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(item);
					if (skillAIDesc != null)
					{
						float num5 = CalcDisInSkillRange(skillAIDesc.PreferRangeMin, skillAIDesc.PreferRangeMax);
						if (num4 > num5 && (num3 < num5 || num3 == num4))
						{
							num3 = num5;
						}
					}
				}
			}
			return num3;
		}

		private bool TryCloseToTarget(UnitLockTargetInfo TargetData)
		{
			if (HasTriggerRotateSkill)
			{
				PursuitToTarget(TargetData);
			}
			else if (!RotateToTarget(TargetData))
			{
				PursuitToTarget(TargetData);
			}
			if (!IsMoving)
			{
				return IsRotating;
			}
			return true;
		}

		private void PursuitToTarget(UnitLockTargetInfo TargetData)
		{
			IsRotating = false;
			IsMoving = false;
			MoveReqIdx = -1;
			if (TargetData != null && TargetData.LockTargetActor != null && TargetData.LockTargetActor as ACharacter != null)
			{
				if (ComboParamInfo.IsUseSkillForMove)
				{
					FVector fVector = BGUFuncLibAICS.BGUAIGetTargetInfoRealLockPoint(TargetData);
					if ((BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr) - fVector).Size2D() > ComboParamInfo.BeginMoveDistanceWhenUseSkill)
					{
						AIFuncLibForCS.GetTurnAngle(OwnerChr, fVector, out var AbsDegValue, out var IsClockwise);
						int moveSkillIDByAngle = AIFuncLibForCS.GetMoveSkillIDByAngle(OwnerChr, AbsDegValue, IsClockwise);
						IsMoving = (IsMovingBySkill = BGUFuncLibAICS.BGURequestAIUseSkillWithSkillID_CSharp(OwnerChr, moveSkillIDByAngle, ECastSkillSourceType.AI_Combo) > 0);
					}
				}
				else
				{
					ParentComp.BUSEventCollection.Evt_ChangeMotionMatchingState.Invoke(ComboParamInfo.MotionMatchingMoveMode);
					GetAcceptableRadiusType(out var IncludeSelfRadius, out var IncludeTargetRadius);
					PursuitAcceptableRadius = CalcPursuitDis(TargetData, IncludeSelfRadius, IncludeTargetRadius);
					IsMoving = BGUFuncLibForMove.BeginMoveToTarget(OwnerChr, TargetData, PursuitAcceptableRadius, ComboParamInfo.SpeedRateType, ComboParamInfo.MoveAIType, IncludeSelfRadius, IncludeTargetRadius, out MoveReqIdx);
				}
			}
			if (IsMoving)
			{
				IsRotating = false;
			}
			bIsPursuitFailed = !IsMoving;
		}

		private bool RotateToTarget(UnitLockTargetInfo TargetData)
		{
			IsRotating = false;
			MoveReqIdx = -1;
			if (TargetData != null && TargetData.LockTargetActor != null && !HasTriggerRotateSkill)
			{
				FVector targetPos = BGUFuncLibAICS.BGUAIGetTargetInfoRealLockPoint(TargetData);
				AIFuncLibForCS.GetTurnAngle(OwnerChr, targetPos, out var AbsDegValue, out var IsClockwise);
				if (AbsDegValue > ComboParamInfo.BeginRotateAngle)
				{
					if (ComboParamInfo.IsUseSkillForTurn)
					{
						int turnSkillIDByAngle = AIFuncLibForCS.GetTurnSkillIDByAngle(OwnerChr, AbsDegValue, IsClockwise);
						IsRotating = (HasTriggerRotateSkill = BGUFuncLibAICS.BGURequestAIUseSkillWithSkillID_CSharp(OwnerChr, turnSkillIDByAngle, ECastSkillSourceType.AI_Combo) > 0);
					}
					else
					{
						float turnSpeed = AIFuncLibForCS.GetTurnSpeed(OwnerChr, AbsDegValue);
						targetPos.Z = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr).Z;
						IsRotating = BGUFuncLibForMove.BeginRotateToTargetPos(OwnerChr, targetPos, turnSpeed, out MoveReqIdx);
					}
				}
			}
			if (IsRotating)
			{
				IsMoving = false;
			}
			bIsPursuitFailed = !IsMoving;
			return IsRotating;
		}

		private void ResetMoveFlag()
		{
			IsRotating = false;
			IsMoving = false;
			HasTriggerRotateSkill = false;
			IsMovingBySkill = false;
		}

		private AActor GetNowUseTarget()
		{
			AActor result = null;
			if (ParentComp.TargetInfoData != null)
			{
				UnitLockTargetInfo comboTarget = ParentComp.TargetInfoData.GetComboTarget();
				if (comboTarget != null && comboTarget.LockTargetWayType == ELockTargetWayType.Combo)
				{
					result = comboTarget.LockTargetActor;
				}
			}
			return result;
		}

		private UnitLockTargetInfo GetNowUseTargetData()
		{
			UnitLockTargetInfo result = null;
			if (ParentComp.TargetInfoData != null)
			{
				UnitLockTargetInfo comboTarget = ParentComp.TargetInfoData.GetComboTarget();
				if (comboTarget != null && comboTarget.LockTargetWayType == ELockTargetWayType.Combo)
				{
					result = comboTarget;
				}
			}
			return result;
		}
	}

	private class EQSRunAction : ActionBase
	{
		private AINodeAction_EQSRunParamInfo EQSRunParamInfo;

		private int MoveReqIdx;

		private bool EQSDone;

		private List<FGSLeisureWithWeight> LeisureList_C;

		private List<FGSLeisureWithWeight> CanPlayLeisureList;

		private bool bInLeisure;

		private float InLeisureTimer;

		private float LastLeisureTime;

		private FName LastLeisureName;

		private bool bCastingTurnSkill;

		private float FinalRadius;

		private FVector TargetLocation;

		private float UpdatePathTimer;

		private int TotalWeight = -1;

		private static string AINodeName = "[EQSRunAction]";

		public override EAINodeActionType ActionType => EAINodeActionType.EQSRun;

		public override void InitAction(IAINodeActionInfo ActionInfo)
		{
			EQSRunParamInfo = ActionInfo as AINodeAction_EQSRunParamInfo;
		}

		public override void BeginAction()
		{
			MoveReqIdx = -1;
			InLeisureTimer = -1f;
			if (OwnerChr != null)
			{
				if (ParentComp.ShouldAbort() || ParentComp.UnitStateData.HasState(EBGUUnitState.Attacking))
				{
					EndAction();
					return;
				}
				LastLeisureName = FName.None;
				EQSDone = false;
				BGS_EventCollectionCS.Get(OwnerChr).Evt_BGS_EQSObjRun.Invoke(EQSRunParamInfo.EQSTemplate, OwnerChr, EBGURunEQSObjReason.None, default(FGSEQSExParam), OnEQSFinish);
				if (!EQSRunParamInfo.EnableLeisure)
				{
					return;
				}
				LeisureList_C = new List<FGSLeisureWithWeight>();
				for (int i = 0; i < EQSRunParamInfo.LeisureList.Count; i++)
				{
					if (EQSRunParamInfo.LeisureList[i].LeisureReference != null)
					{
						LeisureList_C.Add(EQSRunParamInfo.LeisureList[i]);
					}
				}
			}
			else
			{
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, OwnerChr is null!");
				EndAction();
			}
		}

		public override void TickAction(float DeltaTime)
		{
			if (ParentComp.AINodeData.IsBTAborted || ParentComp.AIData.GetIsMoveInValidByNav())
			{
				EndAction();
				return;
			}
			if (EQSRunParamInfo.EnableLeisure)
			{
				LeisureMontageTimerTick(DeltaTime);
				if (CheckIntervalTime(DeltaTime))
				{
					UAnimMontage randomLeisureFromList = GetRandomLeisureFromList();
					if (randomLeisureFromList != null)
					{
						InLeisureTimer = randomLeisureFromList.SequenceLength;
						LastLeisureName = randomLeisureFromList.GetFName();
						BGUFuncLibAnim.BGUActorTryPlayMontage(OwnerChr, randomLeisureFromList, FName.None);
					}
				}
			}
			if (EQSRunParamInfo.TurnSkillConfig != null && bCastingTurnSkill && !BGUFunctionLibraryCS.BGUHasUnitState(OwnerChr, EBGUUnitState.Attacking))
			{
				OwnerChr.StopAnimMontage(null);
				bCastingTurnSkill = false;
			}
			if (EQSRunParamInfo.EnableDrawLineDebug && EQSDone)
			{
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr);
				USystemLibrary.DrawDebugLine(OwnerChr, fVector, TargetLocation, FLinearColor.Green, 0f, 10f);
				USystemLibrary.DrawDebugSphere(OwnerChr, fVector, 30f, 20, FLinearColor.Red, 0f, 10f);
				USystemLibrary.DrawDebugSphere(OwnerChr, TargetLocation, 30f, 20, FLinearColor.Yellow, 0f, 10f);
			}
			if (EQSRunParamInfo.bEnableContinuousPathFinding)
			{
				FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr);
				float num = FinalRadius + EQSRunParamInfo.ContinuousPathFindingRadiusThreshold;
				if ((fVector2 - TargetLocation).SizeSquared() <= (double)(num * num))
				{
					EndAction();
					return;
				}
			}
			if (ParentComp.ShouldAbort() || (EQSDone && !BGUFunctionLibraryCS.BGUIsMoveActive(OwnerChr, MoveReqIdx) && !bInLeisure))
			{
				EndAction();
				return;
			}
			if (EQSDone)
			{
				ParentComp.UpdateMoveSpeedRateByCurve(EQSRunParamInfo.SpeedRateDistanceCurve, TargetLocation);
				if ((BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr) - TargetLocation).Size() <= FinalRadius)
				{
					EndAction();
					return;
				}
			}
			if (EQSRunParamInfo.AutoUpdatePathTime > 0f)
			{
				UpdatePathTimer += DeltaTime;
				if (UpdatePathTimer >= EQSRunParamInfo.AutoUpdatePathTime)
				{
					BGUFuncLibForMove.BeginMoveToPos(OwnerChr, TargetLocation, 0f, EQSRunParamInfo.SpeedRateType, EQSRunParamInfo.MoveAIType, IncludeSelfRadius: false, IncludeTargetRadius: false, out MoveReqIdx);
					UpdatePathTimer = 0f;
				}
			}
		}

		public override void EndAction(bool bSuccess = true)
		{
			base.EndAction(bSuccess);
			ParentComp.ResetSpeedRateForCurve(EQSRunParamInfo.SpeedRateDistanceCurve, EQSRunParamInfo.SpeedRateType);
			if (BGUFunctionLibraryCS.BGUIsMoveActive(OwnerChr, MoveReqIdx) && !ParentComp.ShouldAbort() && !EQSRunParamInfo.bEnableContinuousPathFinding)
			{
				BGUFuncLibForMove.CancelMove(OwnerChr);
			}
		}

		private UAnimMontage GetRandomLeisureFromList()
		{
			if (LeisureList_C.Count == 0)
			{
				return null;
			}
			CanPlayLeisureList = new List<FGSLeisureWithWeight>();
			for (int i = 0; i < LeisureList_C.Count; i++)
			{
				if (LeisureList_C[i].LeisureReference == null)
				{
					return null;
				}
				if (HasTimeToPlay(LeisureList_C[i].LeisureReference) && LastLeisureName != LeisureList_C[i].LeisureReference.GetFName())
				{
					FGSLeisureWithWeight item = LeisureList_C[i];
					CanPlayLeisureList.Add(item);
				}
			}
			if (CanPlayLeisureList.Count > 0)
			{
				int randomIndexByWeight = GetRandomIndexByWeight(CanPlayLeisureList);
				if (randomIndexByWeight > -1)
				{
					return CanPlayLeisureList[randomIndexByWeight].LeisureReference;
				}
			}
			return null;
		}

		private bool CheckIntervalTime(float DeltaTime)
		{
			if (InLeisureTimer > 0f)
			{
				return false;
			}
			LastLeisureTime += DeltaTime;
			if (LastLeisureTime > EQSRunParamInfo.IntervalTime)
			{
				LastLeisureTime = 0f;
				return true;
			}
			return false;
		}

		private int GetRandomIndexByWeight(List<FGSLeisureWithWeight> LeisureList)
		{
			if (TotalWeight == -1)
			{
				TotalWeight = 0;
				foreach (FGSLeisureWithWeight Leisure in LeisureList)
				{
					TotalWeight += Leisure.Weight;
				}
			}
			int num = FMath.RandRange(0, TotalWeight);
			for (int i = 0; i < LeisureList.Count; i++)
			{
				if (num <= LeisureList[i].Weight)
				{
					return i;
				}
				num -= LeisureList[i].Weight;
			}
			return -1;
		}

		private void LeisureMontageTimerTick(float DeltaTime)
		{
			if (InLeisureTimer > 0f)
			{
				InLeisureTimer -= DeltaTime;
			}
			bInLeisure = InLeisureTimer >= 0f;
		}

		private bool HasTimeToPlay(UAnimMontage AnimMontage)
		{
			if (AnimMontage == null)
			{
				return false;
			}
			if (ParentComp.AIData == null)
			{
				return false;
			}
			return ParentComp.AIData.GetWatchTime() >= AnimMontage.SequenceLength;
		}

		public override void OnEQSFinish(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
		{
			if (OwnerChr != null)
			{
				EQSDone = true;
				if (Result.Count > 0)
				{
					FinalRadius = EQSRunParamInfo.AcceptableRadius;
					if (EQSRunParamInfo.EnableRangeAcceptableRadius)
					{
						FinalRadius = MathLib.RandomFloatInRange(EQSRunParamInfo.MinAcceptableRadius, EQSRunParamInfo.MaxAcceptableRadius);
					}
					if (EQSRunParamInfo.IncludeSelfRadius)
					{
						UNavMovementComponent movementComponent = OwnerChr.GetMovementComponent();
						if (movementComponent != null)
						{
							FinalRadius += movementComponent.NavAgentProps.AgentRadius * 2f;
						}
					}
					TargetLocation = Result[0];
					bCastingTurnSkill = BGUFunctionLibraryCS.CheckNeedCastTurnSkill(OwnerChr, EQSRunParamInfo.TurnSkillConfig, TargetLocation);
					if (BGUFuncLibForMove.BeginMoveToPos(OwnerChr, TargetLocation, FinalRadius, EQSRunParamInfo.SpeedRateType, EQSRunParamInfo.MoveAIType, IncludeSelfRadius: false, IncludeTargetRadius: false, out MoveReqIdx))
					{
						if (DebugConfig.AINodeDebug)
						{
							USystemLibrary.DrawDebugPoint(OwnerChr, Result[0], 50f, FLinearColor.Red, 10f);
						}
					}
					else
					{
						AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, BeginMoveToPos Failed!");
						EndAction();
					}
				}
				else
				{
					AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, No EQS Point!");
					EndAction(bSuccess: false);
				}
			}
			else
			{
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, OwnerCharacter is null!");
			}
		}
	}

	private class MoveToAction : ActionBase
	{
		private AINodeAction_MoveToParamInfo MoveToParamInfo;

		private static string AINodeName = "[MoveToAction]";

		private int MoveReqIdx;

		private AActor MoveToTarget;

		private UnitLockTargetInfo MoveToTargetInfo;

		private float MaxMoveTimer;

		private float FinalRadius;

		private float DCParam_TickTimer;

		public override EAINodeActionType ActionType => EAINodeActionType.MoveTo;

		public override void InitAction(IAINodeActionInfo ActionInfo)
		{
			MoveToParamInfo = ActionInfo as AINodeAction_MoveToParamInfo;
		}

		public override void BeginAction()
		{
			MoveReqIdx = -1;
			MaxMoveTimer = MoveToParamInfo.MaxMoveTime;
			if (OwnerChr != null)
			{
				if (ParentComp.ShouldAbort())
				{
					EndAction();
					return;
				}
				DCParam_TickTimer = 0f;
				if (MoveToParamInfo.DCParam_Switch2MoveToDistance < MoveToParamInfo.DCParam_Switch2KFTDistance)
				{
					MoveToParamInfo.DCParam_Switch2MoveToDistance = MoveToParamInfo.DCParam_Switch2KFTDistance;
				}
				FinalRadius = MoveToParamInfo.AcceptableRadius;
				if (MoveToParamInfo.EnableRangeAcceptableRadius)
				{
					FinalRadius = MathLib.RandomFloatInRange(MoveToParamInfo.MinAcceptableRadius, MoveToParamInfo.MaxAcceptableRadius);
				}
				MoveToTarget = null;
				MoveToTargetInfo = null;
				switch (MoveToParamInfo.BTTargetType)
				{
				case EBTTargetType.Target:
					MoveToTarget = BGUFunctionLibraryCS.BGUGetTarget(OwnerChr);
					MoveToTargetInfo = BGUFunctionLibraryCS.BGUGetTargetInfo(OwnerChr);
					break;
				case EBTTargetType.Player:
					MoveToTarget = UGSE_EngineFuncLib.GetFirstLocalPlayerController(OwnerChr).GetControlledPawn();
					break;
				case EBTTargetType.SceneItem:
					if (ParentComp.SceneItemData != null)
					{
						MoveToTarget = ParentComp.SceneItemData.SceneItemCatch;
					}
					break;
				case EBTTargetType.Location:
					MoveToTarget = null;
					MoveToTargetInfo = null;
					break;
				}
				if (MoveToTarget == null && MoveToParamInfo.BTTargetType != EBTTargetType.Location)
				{
					AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, MoveToTarget is null!");
					EndAction();
				}
				else if (MoveToParamInfo.BTTargetType == EBTTargetType.Location)
				{
					if (!BGUFuncLibForMove.BeginMoveToPos(OwnerChr, MoveToParamInfo.TargetLocation, FinalRadius, MoveToParamInfo.SpeedRateType, MoveToParamInfo.MoveAIType, MoveToParamInfo.IncludeSelfRadius, MoveToParamInfo.IncludeTargetRadius, out MoveReqIdx))
					{
						AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, BeginMoveToPos didn't success!");
						EndAction();
					}
				}
				else if (MoveToTargetInfo != null)
				{
					if (!BGUFuncLibForMove.BeginMoveToTarget(OwnerChr, MoveToTargetInfo, FinalRadius, MoveToParamInfo.SpeedRateType, MoveToParamInfo.MoveAIType, MoveToParamInfo.IncludeSelfRadius, MoveToParamInfo.IncludeTargetRadius, out MoveReqIdx))
					{
						AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, BeginMoveToTarget didn't success!");
						EndAction();
					}
				}
				else if (!BGUFuncLibForMove.BeginMoveToTarget(OwnerChr, MoveToTarget, FinalRadius, MoveToParamInfo.SpeedRateType, MoveToParamInfo.MoveAIType, MoveToParamInfo.IncludeSelfRadius, MoveToParamInfo.IncludeTargetRadius, out MoveReqIdx))
				{
					AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, BeginMoveToTarget didn't success!");
					EndAction();
				}
			}
			else
			{
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, OwnerCharacter is null!");
				EndAction();
			}
		}

		public override void TickAction(float DeltaTime)
		{
			if (ParentComp.AINodeData.IsBTAborted)
			{
				EndAction();
				return;
			}
			if (ParentComp.ShouldAbort() || !BGUFunctionLibraryCS.BGUIsMoveActive(OwnerChr, MoveReqIdx))
			{
				EndAction();
				return;
			}
			ParentComp.UpdateMoveSpeedRateByCurve(MoveToParamInfo.SpeedRateDistanceCurve, BGUFuncLibActorTransformCS.BGUGetActorLocation(MoveToTarget));
			if (MoveToParamInfo.DynamicChangeMoveTypeAndSpeedType)
			{
				DCParam_TickTimer -= DeltaTime;
				if (DCParam_TickTimer <= 0f)
				{
					DCParam_TickTimer = UB1Util.GetRandomNumberFloat(1f, 2f);
					EBGUMoveAIType moveAIType = EBGUMoveAIType.None;
					EAIMoveSpeedType eAIMoveSpeedType = EAIMoveSpeedType.SPRINT;
					FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(ParentComp.TargetInfoData.GetTargetInfo().LockTargetActor);
					bool flag = false;
					if (ActorFuncLib.CheckActorWasRecentlyRendered(OwnerChr.Address))
					{
						if (ParentComp.MovementData.MoveAIType != EBGUMoveAIType.KeepFacingTarget)
						{
							flag = true;
							moveAIType = EBGUMoveAIType.KeepFacingTarget;
							eAIMoveSpeedType = EAIMoveSpeedType.RUN;
						}
					}
					else if (ParentComp.MovementData.MoveAIType != EBGUMoveAIType.KeepFacingTarget)
					{
						if (FVector.Dist2D(v, BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr)) <= (float)MoveToParamInfo.DCParam_Switch2KFTDistance)
						{
							flag = true;
							moveAIType = EBGUMoveAIType.KeepFacingTarget;
							eAIMoveSpeedType = EAIMoveSpeedType.RUN;
						}
					}
					else if (FVector.Dist2D(v, BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr)) > (float)MoveToParamInfo.DCParam_Switch2MoveToDistance)
					{
						flag = true;
						moveAIType = EBGUMoveAIType.None;
						eAIMoveSpeedType = EAIMoveSpeedType.SPRINT;
					}
					if (flag)
					{
						ParentComp.BUSEventCollection.Evt_SwitchMoveAIType.Invoke(moveAIType);
						float unitSpeedRateByMoveSpeedType = AIFuncLibForCS.GetUnitSpeedRateByMoveSpeedType(OwnerChr, eAIMoveSpeedType);
						unitSpeedRateByMoveSpeedType = ((unitSpeedRateByMoveSpeedType > 0f) ? unitSpeedRateByMoveSpeedType : 1f);
						ParentComp.BUSEventCollection.Evt_AISetSpeedRate.Invoke(unitSpeedRateByMoveSpeedType, EBGUSpeedCtrlID.MoveSpeedRate);
						EBUStateTrigger triggerID = EBUStateTrigger.AIInputSprint;
						switch (eAIMoveSpeedType)
						{
						case EAIMoveSpeedType.RUN:
							triggerID = EBUStateTrigger.AIInputRun;
							break;
						case EAIMoveSpeedType.SPRINT:
							triggerID = EBUStateTrigger.AIInputSprint;
							break;
						}
						ParentComp.BUSEventCollection.Evt_UnitStateTrigger.Invoke(triggerID, -1f);
					}
				}
			}
			if (MaxMoveTimer > 0f)
			{
				MaxMoveTimer -= DeltaTime;
				if (MaxMoveTimer <= 0f)
				{
					EndAction();
				}
			}
		}

		public override void EndAction(bool bSuccess = true)
		{
			base.EndAction(bSuccess);
			ParentComp.ResetSpeedRateForCurve(MoveToParamInfo.SpeedRateDistanceCurve, MoveToParamInfo.SpeedRateType);
			if (BGUFunctionLibraryCS.BGUIsMoveActive(OwnerChr, MoveReqIdx))
			{
				BGUFuncLibForMove.CancelMove(OwnerChr);
			}
		}
	}

	private class SpiderMoveToAction : ActionBase
	{
		private AINodeAction_SpiderMoveToParamInfo SpiderMoveToParamInfo;

		private IBUC_MovementData MovementData;

		private IBGC_SpiderNavigationData SpiderNavigationData;

		private static string AINodeName = "[SpiderMoveToAction]";

		private AActor MoveToTarget;

		private UnitLockTargetInfo MoveToTargetInfo;

		private float MaxMoveTimer;

		private float FinalRadius;

		private List<ESpiderNavPositionType> PendingMoveActions;

		public override EAINodeActionType ActionType => EAINodeActionType.SpiderMoveTo;

		public override void InitAction(IAINodeActionInfo ActionInfo)
		{
			SpiderMoveToParamInfo = ActionInfo as AINodeAction_SpiderMoveToParamInfo;
			PendingMoveActions = new List<ESpiderNavPositionType>();
			MovementData = BGU_DataUtil.GetReadOnlyData<IBUC_MovementData, BUC_MovementData>(OwnerChr);
			SpiderNavigationData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_SpiderNavigationData, BGC_SpiderNavigationData>(OwnerChr);
		}

		public override void BeginAction()
		{
			PendingMoveActions.Clear();
			MaxMoveTimer = SpiderMoveToParamInfo.MaxMoveTime;
			if (OwnerChr != null)
			{
				FVector TargetPos3;
				FVector TargetNormal3;
				if (ParentComp.ShouldAbort())
				{
					EndAction();
				}
				else if (!MovementData.IsMoveModeActive(EBGUMoveMode.AISpiderMove))
				{
					FVector TargetPos;
					FVector TargetNormal;
					if (SpiderMoveToParamInfo.TargetPositionType == ESpiderNavPositionType.Ground)
					{
						BeginNavMoveTo(SpiderMoveToParamInfo.BTTargetType, SpiderMoveToParamInfo.TargetLocation);
						PendingMoveActions.Add(ESpiderNavPositionType.Ground);
					}
					else if (GetTargetPos(out TargetPos, out TargetNormal))
					{
						List<FSpiderNavPointInfo> list = SpiderNavigationData.TryFindPath(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr), ESpiderNavPositionType.Ground, TargetPos, TargetNormal, ESpiderNavPositionType.Wall);
						if (list.Count == 0)
						{
							EndAction();
							return;
						}
						BeginNavMoveTo(EBTTargetType.Location, list[0].PointLocation);
						PendingMoveActions.Add(ESpiderNavPositionType.Ground);
						PendingMoveActions.Add(ESpiderNavPositionType.Wall);
					}
					else
					{
						EndAction();
					}
				}
				else if (SpiderMoveToParamInfo.TargetPositionType == ESpiderNavPositionType.Ground)
				{
					if (GetTargetPos(out var TargetPos2, out var TargetNormal2))
					{
						List<FSpiderNavPointInfo> list2 = SpiderNavigationData.TryFindPath(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr), ESpiderNavPositionType.Wall, TargetPos2, TargetNormal2, ESpiderNavPositionType.Ground);
						if (list2.Count == 0)
						{
							EndAction();
							return;
						}
						if (list2.Count >= 2)
						{
							BGUFuncLibForMove.BGUAISpiderMoveTo(OwnerChr, list2[list2.Count - 2].PointLocation, list2[list2.Count - 2].PointNormal, ESpiderNavPositionType.Wall, SpiderMoveToParamInfo.AcceptableRadius, SpiderMoveToParamInfo.SpeedRateType);
						}
						PendingMoveActions.Add(ESpiderNavPositionType.Wall);
						PendingMoveActions.Add(ESpiderNavPositionType.Ground);
					}
					else
					{
						EndAction();
					}
				}
				else if (GetTargetPos(out TargetPos3, out TargetNormal3))
				{
					if (SpiderNavigationData.TryFindPath(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr), ESpiderNavPositionType.Wall, TargetPos3, TargetNormal3, ESpiderNavPositionType.Wall).Count == 0)
					{
						EndAction();
						return;
					}
					BGUFuncLibForMove.BGUAISpiderMoveTo(OwnerChr, TargetPos3, TargetNormal3, ESpiderNavPositionType.Wall, SpiderMoveToParamInfo.AcceptableRadius, SpiderMoveToParamInfo.SpeedRateType);
					PendingMoveActions.Add(ESpiderNavPositionType.Wall);
				}
				else
				{
					EndAction();
				}
			}
			else
			{
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, OwnerCharacter is null!");
				EndAction();
			}
		}

		public override void TickAction(float DeltaTime)
		{
			if (ParentComp.AINodeData.IsBTAborted)
			{
				EndAction();
				return;
			}
			if (ParentComp.ShouldAbort() || PendingMoveActions.Count == 0)
			{
				EndAction();
				return;
			}
			if ((!BGUFuncLibForMove.IsMoveActive(OwnerChr) && PendingMoveActions[0] == ESpiderNavPositionType.Ground) || (!BGUFuncLibForMove.IsSpiderNavMoveActive(OwnerChr) && PendingMoveActions[0] == ESpiderNavPositionType.Wall))
			{
				PendingMoveActions.RemoveAt(0);
				if (PendingMoveActions.Count > 0)
				{
					switch (PendingMoveActions[0])
					{
					case ESpiderNavPositionType.Ground:
						BeginNavMoveTo(SpiderMoveToParamInfo.BTTargetType, SpiderMoveToParamInfo.TargetLocation);
						ParentComp.BUSEventCollection.Evt_SetMoveModeActive.Invoke(EBGUMoveMode.AISpiderMove, SetActive: false);
						break;
					case ESpiderNavPositionType.Wall:
					{
						if (GetTargetPos(out var TargetPos, out var TargetNormal))
						{
							if (SpiderNavigationData.TryFindPath(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr), ESpiderNavPositionType.Wall, TargetPos, TargetNormal, ESpiderNavPositionType.Wall).Count == 0)
							{
								EndAction();
								return;
							}
							BGUFuncLibForMove.BGUAISpiderMoveTo(OwnerChr, TargetPos, TargetNormal, SpiderMoveToParamInfo.TargetPositionType, SpiderMoveToParamInfo.AcceptableRadius, SpiderMoveToParamInfo.SpeedRateType);
						}
						break;
					}
					}
				}
			}
			if (MaxMoveTimer > 0f)
			{
				MaxMoveTimer -= DeltaTime;
				if (MaxMoveTimer <= 0f)
				{
					EndAction();
				}
			}
		}

		public override void EndAction(bool bSuccess = true)
		{
			base.EndAction(bSuccess);
			if (BGUFuncLibForMove.IsMoveActive(OwnerChr))
			{
				BGUFuncLibForMove.CancelMove(OwnerChr);
			}
		}

		private bool GetTargetPos(out FVector TargetPos, out FVector TargetNormal)
		{
			TargetPos = FVector.ZeroVector;
			TargetNormal = FVector.ZeroVector;
			switch (SpiderMoveToParamInfo.BTTargetType)
			{
			case EBTTargetType.Target:
				MoveToTarget = BGUFunctionLibraryCS.BGUGetTarget(OwnerChr);
				break;
			case EBTTargetType.Player:
				MoveToTarget = UGSE_EngineFuncLib.GetFirstLocalPlayerController(OwnerChr).GetControlledPawn();
				break;
			case EBTTargetType.SceneItem:
				if (ParentComp.SceneItemData != null)
				{
					MoveToTarget = ParentComp.SceneItemData.SceneItemCatch;
				}
				break;
			case EBTTargetType.Location:
				MoveToTarget = null;
				break;
			}
			if (SpiderMoveToParamInfo.BTTargetType != EBTTargetType.Location)
			{
				if (MoveToTarget == null)
				{
					return false;
				}
				FTransform fTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(MoveToTarget);
				TargetPos = fTransform.Translation;
				TargetNormal = fTransform.Rotation.GetForwardVector();
			}
			else
			{
				TargetPos = SpiderMoveToParamInfo.TargetLocation;
				TargetNormal = SpiderMoveToParamInfo.TargetNormal;
			}
			return true;
		}

		private void BeginNavMoveTo(EBTTargetType TargetType, FVector TargetPos)
		{
			FinalRadius = SpiderMoveToParamInfo.AcceptableRadius;
			MoveToTarget = null;
			MoveToTargetInfo = null;
			switch (TargetType)
			{
			case EBTTargetType.Target:
				MoveToTarget = BGUFunctionLibraryCS.BGUGetTarget(OwnerChr);
				MoveToTargetInfo = BGUFunctionLibraryCS.BGUGetTargetInfo(OwnerChr);
				break;
			case EBTTargetType.Player:
				MoveToTarget = UGSE_EngineFuncLib.GetFirstLocalPlayerController(OwnerChr).GetControlledPawn();
				break;
			case EBTTargetType.SceneItem:
				if (ParentComp.SceneItemData != null)
				{
					MoveToTarget = ParentComp.SceneItemData.SceneItemCatch;
				}
				break;
			case EBTTargetType.Location:
				MoveToTarget = null;
				MoveToTargetInfo = null;
				break;
			}
			int RequestIdx3;
			if (MoveToTarget == null && TargetType != EBTTargetType.Location)
			{
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, MoveToTarget is null!");
				EndAction();
			}
			else if (TargetType == EBTTargetType.Location)
			{
				if (!BGUFuncLibForMove.BeginMoveToPos(OwnerChr, TargetPos, FinalRadius, SpiderMoveToParamInfo.SpeedRateType, EBGUMoveAIType.None, SpiderMoveToParamInfo.IncludeSelfRadius, SpiderMoveToParamInfo.IncludeTargetRadius, out var _))
				{
					AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, BeginMoveToPos didn't success!");
					EndAction();
				}
			}
			else if (MoveToTargetInfo != null)
			{
				if (!BGUFuncLibForMove.BeginMoveToTarget(OwnerChr, MoveToTargetInfo, FinalRadius, SpiderMoveToParamInfo.SpeedRateType, EBGUMoveAIType.None, SpiderMoveToParamInfo.IncludeSelfRadius, SpiderMoveToParamInfo.IncludeTargetRadius, out var _))
				{
					AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, BeginMoveToTarget didn't success!");
					EndAction();
				}
			}
			else if (!BGUFuncLibForMove.BeginMoveToTarget(OwnerChr, MoveToTarget, FinalRadius, SpiderMoveToParamInfo.SpeedRateType, EBGUMoveAIType.None, SpiderMoveToParamInfo.IncludeSelfRadius, SpiderMoveToParamInfo.IncludeTargetRadius, out RequestIdx3))
			{
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, BeginMoveToTarget didn't success!");
				EndAction();
			}
		}
	}

	private class AdjustTransformBySplineAction : ActionBase
	{
		public override EAINodeActionType ActionType => EAINodeActionType.AdjustTransformBySpline;

		private AINodeAction_AdjustTransformBySplineParamInfo ParamInfo { get; set; }

		private TWeakObject<BGUSplineActor> SplineActorRef { get; set; }

		private float RemainTime { get; set; }

		private FTransform TargetTransform { get; set; }

		public override void InitAction(IAINodeActionInfo ActionInfo)
		{
			ParamInfo = ActionInfo as AINodeAction_AdjustTransformBySplineParamInfo;
		}

		public override void BeginAction()
		{
			if (OwnerChr == null)
			{
				EndAction();
				return;
			}
			if (ParentComp.ShouldAbort())
			{
				EndAction();
				return;
			}
			if (BGU_DataUtil.GetActorByGuid(OwnerChr, ParamInfo.SplineGuid) as BGUSplineActor == null)
			{
				EndAction();
				return;
			}
			RemainTime = ParamInfo.AdjustTime;
			if (ParentComp.TargetInfoData.GetTargetInfo().LockTargetActor == null)
			{
				EndAction();
			}
		}

		public override void TickAction(float DeltaTime)
		{
			RemainTime -= DeltaTime;
			if (RemainTime <= 0f)
			{
				EndAction();
			}
		}

		public override void EndAction(bool bSuccess = true)
		{
			base.EndAction(bSuccess);
			RemainTime = 0f;
		}
	}

	private class GroupAIMove2HotZonePointAction : ActionBase
	{
		private static string AINodeName = "[GroupAIMove2HotZonePointAction]";

		private int MoveReqIdx;

		private UnitLockTargetInfo MoveToTargetInfo;

		private float MaxMoveTimer;

		private float FinalRadius;

		private float DCParam_TickTimer;

		private FVector NowGoalPos;

		private float UpdateGoalPosTimer;

		public override EAINodeActionType ActionType => EAINodeActionType.GroupAIMove2HotZonePoint;

		private AINodeAction_GroupAIMove2HotZonePointParamInfo ParamInfo { get; set; }

		public override void InitAction(IAINodeActionInfo ActionInfo)
		{
			ParamInfo = ActionInfo as AINodeAction_GroupAIMove2HotZonePointParamInfo;
		}

		public override void BeginAction()
		{
			MoveReqIdx = -1;
			MaxMoveTimer = ParamInfo.MaxMoveTime;
			if (OwnerChr != null)
			{
				if (ParentComp.ShouldAbort())
				{
					EndAction();
					return;
				}
				DCParam_TickTimer = 0f;
				if (ParamInfo.DCParam_Switch2MoveToDistance < ParamInfo.DCParam_Switch2KFTDistance)
				{
					ParamInfo.DCParam_Switch2MoveToDistance = ParamInfo.DCParam_Switch2KFTDistance;
				}
				FinalRadius = ParamInfo.AcceptableRadius;
				if (ParamInfo.EnableRangeAcceptableRadius)
				{
					FinalRadius = MathLib.RandomFloatInRange(ParamInfo.MinAcceptableRadius, ParamInfo.MaxAcceptableRadius);
				}
				if (ParentComp.GroupAIData.GetGroupAIHotZonePointInfo(out var HPI))
				{
					NowGoalPos = UpdateGoalPos(in HPI);
					UpdateGoalPosTimer = FMath.RandRange(2, 3);
					if (!BGUFuncLibForMove.BeginMoveToPos(OwnerChr, NowGoalPos, FinalRadius, ParamInfo.SpeedRateType, ParamInfo.MoveAIType, ParamInfo.IncludeSelfRadius, ParamInfo.IncludeTargetRadius, out MoveReqIdx))
					{
						AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, BeginMoveToPos didn't success!");
						EndAction();
					}
				}
				else
				{
					AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, No HotZonePoint!");
					EndAction();
				}
			}
			else
			{
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, OwnerCharacter is null!");
				EndAction();
			}
		}

		public override void TickAction(float DeltaTime)
		{
			if (ParentComp.AINodeData.IsBTAborted)
			{
				EndAction();
				return;
			}
			if (ParentComp.ShouldAbort() || !BGUFunctionLibraryCS.BGUIsMoveActive(OwnerChr, MoveReqIdx))
			{
				EndAction();
				return;
			}
			if (MaxMoveTimer > 0f)
			{
				MaxMoveTimer -= DeltaTime;
				if (MaxMoveTimer <= 0f)
				{
					EndAction();
					return;
				}
			}
			UpdateGoalPosTimer -= DeltaTime;
			if (UpdateGoalPosTimer <= 0f && ParentComp.GroupAIData.GetGroupAIHotZonePointInfo(out var HPI))
			{
				UpdateGoalPosTimer = FMath.RandRange(2, 3);
				NowGoalPos = UpdateGoalPos(in HPI);
			}
			ParentComp.UpdateMoveSpeedRateByCurve(ParamInfo.SpeedRateDistanceCurve, NowGoalPos);
			if (!ParamInfo.DynamicChangeMoveTypeAndSpeedType)
			{
				return;
			}
			DCParam_TickTimer -= DeltaTime;
			if (!(DCParam_TickTimer <= 0f))
			{
				return;
			}
			DCParam_TickTimer = UB1Util.GetRandomNumberFloat(1f, 2f);
			EBGUMoveAIType moveAIType = EBGUMoveAIType.None;
			EAIMoveSpeedType eAIMoveSpeedType = EAIMoveSpeedType.SPRINT;
			FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(ParentComp.TargetInfoData.GetTargetInfo().LockTargetActor);
			bool flag = false;
			if (ActorFuncLib.CheckActorWasRecentlyRendered(OwnerChr.Address))
			{
				if (ParentComp.MovementData.MoveAIType != EBGUMoveAIType.KeepFacingTarget)
				{
					flag = true;
					moveAIType = EBGUMoveAIType.KeepFacingTarget;
					eAIMoveSpeedType = EAIMoveSpeedType.RUN;
				}
			}
			else if (ParentComp.MovementData.MoveAIType != EBGUMoveAIType.KeepFacingTarget)
			{
				if (FVector.Dist2D(v, BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr)) <= (float)ParamInfo.DCParam_Switch2KFTDistance)
				{
					flag = true;
					moveAIType = EBGUMoveAIType.KeepFacingTarget;
					eAIMoveSpeedType = EAIMoveSpeedType.RUN;
				}
			}
			else if (FVector.Dist2D(v, BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr)) > (float)ParamInfo.DCParam_Switch2MoveToDistance)
			{
				flag = true;
				moveAIType = EBGUMoveAIType.None;
				eAIMoveSpeedType = EAIMoveSpeedType.SPRINT;
			}
			if (flag)
			{
				ParentComp.BUSEventCollection.Evt_SwitchMoveAIType.Invoke(moveAIType);
				float unitSpeedRateByMoveSpeedType = AIFuncLibForCS.GetUnitSpeedRateByMoveSpeedType(OwnerChr, eAIMoveSpeedType);
				unitSpeedRateByMoveSpeedType = ((unitSpeedRateByMoveSpeedType > 0f) ? unitSpeedRateByMoveSpeedType : 1f);
				ParentComp.BUSEventCollection.Evt_AISetSpeedRate.Invoke(unitSpeedRateByMoveSpeedType, EBGUSpeedCtrlID.MoveSpeedRate);
				EBUStateTrigger triggerID = EBUStateTrigger.AIInputSprint;
				switch (eAIMoveSpeedType)
				{
				case EAIMoveSpeedType.RUN:
					triggerID = EBUStateTrigger.AIInputRun;
					break;
				case EAIMoveSpeedType.SPRINT:
					triggerID = EBUStateTrigger.AIInputSprint;
					break;
				}
				ParentComp.BUSEventCollection.Evt_UnitStateTrigger.Invoke(triggerID, -1f);
			}
		}

		public override void EndAction(bool bSuccess = true)
		{
			base.EndAction(bSuccess);
			ParentComp.ResetSpeedRateForCurve(ParamInfo.SpeedRateDistanceCurve, ParamInfo.SpeedRateType);
			if (BGUFunctionLibraryCS.BGUIsMoveActive(OwnerChr, MoveReqIdx))
			{
				BGUFuncLibForMove.CancelMove(OwnerChr);
			}
		}

		private FVector UpdateGoalPos(in HotZonePointInfo HPI)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr);
			FVector cachedLocalPlayerLocation = ParentComp.LocalPlayerSharedData.CachedLocalPlayerLocation;
			FRotator cachedLocalPlayerRotation = ParentComp.LocalPlayerSharedData.CachedLocalPlayerRotation;
			FRotator cachedLocalPlayerCameraRotation = ParentComp.LocalPlayerSharedData.CachedLocalPlayerCameraRotation;
			FVector result;
			FVector safeNormal2D = ((result = BGUFuncLibAICS.BGUGetHotZonePointWorldLocation(cachedLocalPlayerLocation, cachedLocalPlayerRotation, cachedLocalPlayerCameraRotation, HPI.RelativePos)) - fVector).GetSafeNormal2D();
			FVector safeNormal2D2 = (cachedLocalPlayerLocation - fVector).GetSafeNormal2D();
			if (safeNormal2D.Size2D() > safeNormal2D2.Size2D())
			{
				FVector2D v = new FVector2D(safeNormal2D);
				FVector2D v2 = new FVector2D(safeNormal2D2);
				if (MathLib.DegAcos(MathLib.DotProduct2D(v, v2)) <= 30f && ParentComp.GroupAIMgrData.HotZoneWayPointInfoDict.TryGetValue(HPI.HotZoneIdx, out var value))
				{
					float num = float.MinValue;
					foreach (HotZonePointInfo item in value)
					{
						FVector fVector2 = BGUFuncLibAICS.BGUGetHotZonePointWorldLocation(cachedLocalPlayerLocation, cachedLocalPlayerRotation, cachedLocalPlayerCameraRotation, item.RelativePos);
						float num2 = FVector.Dist2D(fVector2, fVector);
						if (num < 0f || num > num2)
						{
							num = num2;
							result = fVector2;
						}
					}
				}
			}
			return result;
		}
	}

	private class GroupAIMove2EnterBattlePosAction : ActionBase
	{
		private static string AINodeName = "[GroupAIMove2EnterBattlePos]";

		private int MoveReqIdx;

		private UnitLockTargetInfo MoveToTargetInfo;

		private float MaxMoveTimer;

		private float FinalRadius;

		private float DCParam_TickTimer;

		private FVector NowGoalPos;

		public override EAINodeActionType ActionType => EAINodeActionType.GroupAIMove2EnterBattlePos;

		private AINodeAction_GroupAIMove2EnterBattlePos ParamInfo { get; set; }

		public override void InitAction(IAINodeActionInfo ActionInfo)
		{
			ParamInfo = ActionInfo as AINodeAction_GroupAIMove2EnterBattlePos;
		}

		public override void BeginAction()
		{
			MoveReqIdx = -1;
			MaxMoveTimer = ParamInfo.MaxMoveTime;
			if (OwnerChr != null)
			{
				if (ParentComp.ShouldAbort())
				{
					EndAction();
					return;
				}
				DCParam_TickTimer = 0f;
				if (ParamInfo.DCParam_Switch2MoveToDistance < ParamInfo.DCParam_Switch2KFTDistance)
				{
					ParamInfo.DCParam_Switch2MoveToDistance = ParamInfo.DCParam_Switch2KFTDistance;
				}
				FinalRadius = ParamInfo.AcceptableRadius;
				if (ParamInfo.EnableRangeAcceptableRadius)
				{
					FinalRadius = MathLib.RandomFloatInRange(ParamInfo.MinAcceptableRadius, ParamInfo.MaxAcceptableRadius);
				}
				NowGoalPos = ParentComp.AIData.GetEnterBattlePosition();
				if (!BGUFuncLibForMove.BeginMoveToPos(OwnerChr, NowGoalPos, FinalRadius, ParamInfo.SpeedRateType, ParamInfo.MoveAIType, ParamInfo.IncludeSelfRadius, ParamInfo.IncludeTargetRadius, out MoveReqIdx))
				{
					AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, BeginMoveToPos didn't success!");
					EndAction();
				}
			}
			else
			{
				AIFuncLibForCS.PrintDebugMessage(OwnerChr, AINodeName, "Failed, OwnerCharacter is null!");
				EndAction();
			}
		}

		public override void TickAction(float DeltaTime)
		{
			if (ParentComp.AINodeData.IsBTAborted)
			{
				EndAction();
			}
			else if (ParentComp.ShouldAbort() || !BGUFunctionLibraryCS.BGUIsMoveActive(OwnerChr, MoveReqIdx))
			{
				EndAction();
			}
			else if (MaxMoveTimer > 0f)
			{
				MaxMoveTimer -= DeltaTime;
				if (MaxMoveTimer <= 0f)
				{
					EndAction();
				}
			}
		}

		public override void EndAction(bool bSuccess = true)
		{
			base.EndAction(bSuccess);
			ParentComp.ResetSpeedRateForCurve(ParamInfo.SpeedRateDistanceCurve, ParamInfo.SpeedRateType);
			if (BGUFunctionLibraryCS.BGUIsMoveActive(OwnerChr, MoveReqIdx))
			{
				BGUFuncLibForMove.CancelMove(OwnerChr);
			}
		}

		private FVector UpdateGoalPos(in HotZonePointInfo HPI)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerChr);
			FVector cachedLocalPlayerLocation = ParentComp.LocalPlayerSharedData.CachedLocalPlayerLocation;
			FRotator cachedLocalPlayerRotation = ParentComp.LocalPlayerSharedData.CachedLocalPlayerRotation;
			FRotator cachedLocalPlayerCameraRotation = ParentComp.LocalPlayerSharedData.CachedLocalPlayerCameraRotation;
			FVector result;
			FVector safeNormal2D = ((result = BGUFuncLibAICS.BGUGetHotZonePointWorldLocation(cachedLocalPlayerLocation, cachedLocalPlayerRotation, cachedLocalPlayerCameraRotation, HPI.RelativePos)) - fVector).GetSafeNormal2D();
			FVector safeNormal2D2 = (cachedLocalPlayerLocation - fVector).GetSafeNormal2D();
			if (safeNormal2D.Size2D() > safeNormal2D2.Size2D())
			{
				FVector2D v = new FVector2D(safeNormal2D);
				FVector2D v2 = new FVector2D(safeNormal2D2);
				if (MathLib.DegAcos(MathLib.DotProduct2D(v, v2)) <= 30f && ParentComp.GroupAIMgrData.HotZoneWayPointInfoDict.TryGetValue(HPI.HotZoneIdx, out var value))
				{
					float num = float.MinValue;
					foreach (HotZonePointInfo item in value)
					{
						FVector fVector2 = BGUFuncLibAICS.BGUGetHotZonePointWorldLocation(cachedLocalPlayerLocation, cachedLocalPlayerRotation, cachedLocalPlayerCameraRotation, item.RelativePos);
						float num2 = FVector.Dist2D(fVector2, fVector);
						if (num < 0f || num > num2)
						{
							num = num2;
							result = fVector2;
						}
					}
				}
			}
			return result;
		}
	}

	private BUC_AINodeData AINodeData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_AIData AIData;

	private IBUC_BuffData BuffData;

	private IBUC_ConfigInfoData ConfigInfoData;

	private IBUC_SceneItemData SceneItemData;

	private IBUC_WakeUpData WakeUpData;

	private IBUC_ActionRequestData ActionRequestData;

	private IBUC_ChargeSkillData ChargeSkillData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_MovementData MovementData;

	private IBUC_GroupAIData GroupAIData;

	private IBUC_UnitHatredCacheData UnitHatredCacheData;

	private IBGC_GroupAIMgrData GroupAIMgrData;

	private IBGC_LocalPlayerSharedData LocalPlayerSharedData;

	private IBGC_TeamRelationData TeamRelationData;

	private ActionBase CurrentAction;

	private ComboAction ComboActionTemplate;

	private EQSRunAction EQSRunActionTemplate;

	private MoveToAction MoveToActionTemplate;

	private SpiderMoveToAction SpiderMoveToActionTemplate;

	private AdjustTransformBySplineAction AdjustTransformBySplineActionTemplate;

	private GroupAIMove2HotZonePointAction GroupAIMove2HotZonePointActionTemplate;

	private GroupAIMove2EnterBattlePosAction GroupAIMove2EnterBattlePosActionTemplate;

	private bool bIsPause;

	public override void OnAttach()
	{
		AINodeData = RequireWritableData<BUC_AINodeData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		AIData = RequireReadOnlyData<IBUC_AIData, BUC_AIData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		ConfigInfoData = RequireReadOnlyData<IBUC_ConfigInfoData, BUC_ConfigInfoData>();
		SceneItemData = RequireReadOnlyData<IBUC_SceneItemData, BUC_SceneItemData>();
		WakeUpData = RequireReadOnlyData<IBUC_WakeUpData, BUC_WakeUpData>();
		ActionRequestData = RequireReadOnlyData<IBUC_ActionRequestData, BUC_ActionRequestData>();
		ChargeSkillData = RequireReadOnlyData<IBUC_ChargeSkillData, BUC_ChargeSkillData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		GroupAIData = RequireReadOnlyData<IBUC_GroupAIData, BUC_GroupAIData>();
		UnitHatredCacheData = RequireReadOnlyData<IBUC_UnitHatredCacheData, BUC_UnitHatredCacheData>();
		GroupAIMgrData = RequireReadOnlyGameStateData<IBGC_GroupAIMgrData, BGC_GroupAIMgrData>();
		LocalPlayerSharedData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		TeamRelationData = RequireReadOnlyGameStateData<IBGC_TeamRelationData, BGC_TeamRelationData>();
		base.BUSEventCollection.Evt_SetAIBTAborted += new Del_Void(OnSetAIBTAborted);
		base.BUSEventCollection.Evt_InitiateAINodeAction += new Del_InitiateAINodeAction(OnInitiateAINodeAction);
		base.BUSEventCollection.Evt_SetAINodeActionPause += new Del_Void_Bool(OnSetAINodeActionPause);
		base.BUSEventCollection.Evt_SetAINodeActionStop += new Del_Void(OnSetAINodeActionStop);
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
	}

	public override void PreBeginPlay()
	{
		CurrentAction = null;
		AINodeData.ActionType = EAINodeActionType.None;
		ComboActionTemplate = new ComboAction();
		EQSRunActionTemplate = new EQSRunAction();
		MoveToActionTemplate = new MoveToAction();
		SpiderMoveToActionTemplate = new SpiderMoveToAction();
		AdjustTransformBySplineActionTemplate = new AdjustTransformBySplineAction();
		GroupAIMove2HotZonePointActionTemplate = new GroupAIMove2HotZonePointAction();
		GroupAIMove2EnterBattlePosActionTemplate = new GroupAIMove2EnterBattlePosAction();
		ComboActionTemplate.Init(OwnerAsCharacterCS, this);
		EQSRunActionTemplate.Init(OwnerAsCharacterCS, this);
		MoveToActionTemplate.Init(OwnerAsCharacterCS, this);
		SpiderMoveToActionTemplate.Init(OwnerAsCharacterCS, this);
		AdjustTransformBySplineActionTemplate.Init(OwnerAsCharacterCS, this);
		GroupAIMove2HotZonePointActionTemplate.Init(OwnerAsCharacterCS, this);
		GroupAIMove2EnterBattlePosActionTemplate.Init(OwnerAsCharacterCS, this);
		bIsPause = false;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		OnSetAINodeActionStop();
		ComboActionTemplate?.Release();
		EQSRunActionTemplate?.Release();
		MoveToActionTemplate?.Release();
		SpiderMoveToActionTemplate?.Release();
		AdjustTransformBySplineActionTemplate?.Release();
		GroupAIMove2HotZonePointActionTemplate?.Release();
		GroupAIMove2EnterBattlePosActionTemplate?.Release();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!bIsPause && CurrentAction != null)
		{
			if (AINodeData.CanFinishAINode == AINodeFinishState.Process)
			{
				CurrentAction.TickAction(DeltaTime);
			}
			if (AINodeData.CanFinishAINode != AINodeFinishState.Process)
			{
				NotifyAIActionFinish(CurrentAction);
				CurrentAction = null;
				AINodeData.ActionType = EAINodeActionType.None;
			}
		}
	}

	private void NotifyAIActionFinish(ActionBase FinishAction)
	{
		if (!AIData.IsAI)
		{
			BGP_PlayerControllerCS bGP_PlayerControllerCS = (Owner as BGUCharacterCS)?.GetController() as BGP_PlayerControllerCS;
			if (bGP_PlayerControllerCS != null)
			{
				(bGP_PlayerControllerCS.PlayerState as BGP_PlayerStateCS)?.PlayerEventCollection.Evt_BPS_ActionNodeFinish.Invoke(FinishAction.ActionType);
			}
		}
		base.BUSEventCollection.EVt_NotifyAIActionFinish.Invoke(FinishAction.ActionType);
	}

	private bool ShouldAbort()
	{
		if (UnitStateData != null)
		{
			if (UnitStateData.HasState(EBGUUnitState.Dead))
			{
				return true;
			}
			if (UnitStateData.HasState(EBGUUnitState.Beatback) && !UnitStateData.HasState(EBGUUnitState.InComboWindow))
			{
				return true;
			}
			if (UnitStateData.HasState(EBGUUnitState.HRCounterattacking) || UnitStateData.HasState(EBGUUnitState.BlockBeatBack) || UnitStateData.HasState(EBGUUnitState.PerfectBlockBeatBack) || UnitStateData.HasState(EBGUUnitState.BlockBounced))
			{
				return true;
			}
			return false;
		}
		return true;
	}

	private void UpdateMoveSpeedRateByCurve(UCurveFloat SpeedRateDistanceCurve, FVector TargetLocation)
	{
		if (SpeedRateDistanceCurve == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			float inTime = FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS), TargetLocation);
			float floatValue = SpeedRateDistanceCurve.GetFloatValue(inTime);
			floatValue = ((floatValue > 0f) ? floatValue : 1f);
			if (DebugConfig.EnableMoveSpeedInfoDebug)
			{
				base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("EnableMoveSpeedInfoDebug", "更新曲线：" + SpeedRateDistanceCurve.GetName(), 3);
				base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("EnableMoveSpeedInfoDebug", $"更新曲线速率：{floatValue}", 4);
			}
			BGUFunctionLibraryCS.BGUAIChangeToTargetSpeedRate(bGUCharacterCS, floatValue);
		}
	}

	private void ResetSpeedRateForCurve(UCurveFloat SpeedRateDistanceCurve, EAIMoveSpeedType SpeedRateType)
	{
		if (!(SpeedRateDistanceCurve == null))
		{
			BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
			if (!(bGUCharacterCS == null))
			{
				float unitSpeedRateByMoveSpeedType = AIFuncLibForCS.GetUnitSpeedRateByMoveSpeedType(bGUCharacterCS, SpeedRateType);
				unitSpeedRateByMoveSpeedType = ((unitSpeedRateByMoveSpeedType > 0f) ? unitSpeedRateByMoveSpeedType : 1f);
				BGUFunctionLibraryCS.BGUAIChangeToTargetSpeedRate(bGUCharacterCS, unitSpeedRateByMoveSpeedType);
			}
		}
	}

	private void OnSetAIBTAborted()
	{
		AINodeData.IsBTAborted = true;
	}

	private void OnInitiateAINodeAction(EAINodeActionType ActionType, IAINodeActionInfo AINodeActionInfo)
	{
		OnSetAINodeActionStop();
		AINodeData.CanFinishAINode = AINodeFinishState.Process;
		AINodeData.IsBTAborted = false;
		switch (ActionType)
		{
		case EAINodeActionType.Combo:
			CurrentAction = ComboActionTemplate;
			break;
		case EAINodeActionType.EQSRun:
			CurrentAction = EQSRunActionTemplate;
			break;
		case EAINodeActionType.MoveTo:
			CurrentAction = MoveToActionTemplate;
			break;
		case EAINodeActionType.SpiderMoveTo:
			CurrentAction = SpiderMoveToActionTemplate;
			break;
		case EAINodeActionType.AdjustTransformBySpline:
			CurrentAction = AdjustTransformBySplineActionTemplate;
			break;
		case EAINodeActionType.GroupAIMove2HotZonePoint:
			CurrentAction = GroupAIMove2HotZonePointActionTemplate;
			break;
		case EAINodeActionType.GroupAIMove2EnterBattlePos:
			CurrentAction = GroupAIMove2EnterBattlePosActionTemplate;
			break;
		}
		if (CurrentAction != null)
		{
			CurrentAction.InitAction(AINodeActionInfo);
			CurrentAction.BeginAction();
			AINodeData.ActionType = CurrentAction.ActionType;
		}
	}

	private void OnSetAINodeActionPause(bool _bIsPause)
	{
		bIsPause = _bIsPause;
	}

	private void OnSetAINodeActionStop()
	{
		if (CurrentAction != null)
		{
			if (AINodeData.CanFinishAINode == AINodeFinishState.Process)
			{
				CurrentAction.EndAction();
			}
			NotifyAIActionFinish(CurrentAction);
			CurrentAction = null;
			AINodeData.ActionType = EAINodeActionType.None;
		}
	}

	private void OnResetActorStatusAfterAll(EResetActorReason ResetReason)
	{
		OnSetAINodeActionStop();
		if (GetActorResID() == 1999)
		{
			UBGUFunctionLibraryForCS.BGURestartBT(OwnerAsCharacterCS.GetController() as ABGUAIController);
		}
	}
}
