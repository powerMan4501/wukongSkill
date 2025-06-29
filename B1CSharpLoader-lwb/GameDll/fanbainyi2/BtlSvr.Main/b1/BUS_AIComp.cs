using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using AOT;
using b1.BGW;
using b1.ECS;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Diana.Common;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AIComp")]
public class BUS_AIComp : UActorCompBaseUObj
{
	private static class BAID_Base_NativeCallback
	{
		[MonoNativeFunctionWrapper]
		private delegate bool Del_NativeBTDecoratorCheckCondition(IntPtr DecoratorBase, IntPtr Owner);

		[MonoNativeFunctionWrapper]
		private delegate bool Del_OnNativeBTDecoratorCheckCondition(IntPtr DecoratorBase, IntPtr Owner);

		[MonoNativeFunctionWrapper]
		private delegate void Del_NativeBTTaskExecute(IntPtr TaskBase, IntPtr Owner);

		[MonoNativeFunctionWrapper]
		private delegate void Del_NativeBTTaskTick(IntPtr TaskBase, IntPtr Owner, float DeltaTime);

		[MonoNativeFunctionWrapper]
		private delegate void Del_NativeBTTaskAbort(IntPtr TaskBase, IntPtr Owner);

		[MonoNativeFunctionWrapper]
		private delegate void Del_OnNativeBTTaskExecute(IntPtr TaskBase, IntPtr Owner);

		[MonoNativeFunctionWrapper]
		private delegate void Del_OnNativeBTTaskTick(IntPtr TaskBase, IntPtr Owner, float DeltaTime);

		[MonoNativeFunctionWrapper]
		private delegate void Del_OnNativeBTTaskAbort(IntPtr TaskBase, IntPtr Owner);

		[MonoNativeFunctionWrapper]
		private delegate void Del_NativeBTServiceTick(IntPtr ServiceBase, IntPtr Owner, float DeltaTime);

		[MonoNativeFunctionWrapper]
		private delegate void Del_NativeBTServiceActivation(IntPtr ServiceBase, IntPtr Owner);

		[MonoNativeFunctionWrapper]
		private delegate void Del_NativeBTServiceDeactivation(IntPtr ServiceBase, IntPtr Owner);

		[MonoNativeFunctionWrapper]
		private delegate void Del_NativeBTServiceSearchStart(IntPtr ServiceBase, IntPtr Owner);

		[MonoNativeFunctionWrapper]
		private delegate void Del_OnNativeBTServiceTick(IntPtr ServiceBase, IntPtr Owner, float DeltaTime);

		[MonoNativeFunctionWrapper]
		private delegate void Del_OnNativeBTServiceActivation(IntPtr ServiceBase, IntPtr Owner);

		[MonoNativeFunctionWrapper]
		private delegate void Del_OnNativeBTServiceDeactivation(IntPtr ServiceBase, IntPtr Owner);

		[MonoNativeFunctionWrapper]
		private delegate void Del_OnNativeBTServiceSearchStart(IntPtr ServiceBase, IntPtr Owner);

		public static int Ref;

		private static Del_NativeBTDecoratorCheckCondition NativeBTDecoratorCheckCondition;

		private static Del_NativeBTTaskExecute NativeBTTaskExecute;

		private static Del_NativeBTTaskTick NativeBTTaskTick;

		private static Del_NativeBTTaskAbort NativeBTTaskAbort;

		private static Del_NativeBTServiceTick NativeBTServiceTick;

		private static Del_NativeBTServiceActivation NativeBTServiceActivation;

		private static Del_NativeBTServiceDeactivation NativeBTServiceDeactivation;

		private static Del_NativeBTServiceSearchStart NativeBTServiceSearchStart;

		[MonoPInvokeCallback(typeof(Del_OnNativeBTDecoratorCheckCondition))]
		private static bool OnNativeBTDecoratorCheckCondition(IntPtr DecoratorBase, IntPtr Owner)
		{
			try
			{
				BAID_Base bAID_Base = GCHelper.Find<BAID_Base>(DecoratorBase);
				if (bAID_Base == null)
				{
					return false;
				}
				AActor aActor = GCHelper.Find<AActor>(Owner);
				if (aActor == null)
				{
					return false;
				}
				return bAID_Base.PerformConditionCheck(aActor);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
				return false;
			}
		}

		[MonoPInvokeCallback(typeof(Del_OnNativeBTTaskExecute))]
		private static void OnNativeBTTaskExecute(IntPtr TaskBase, IntPtr Owner)
		{
			try
			{
				BAIT_Base bAIT_Base = GCHelper.Find<BAIT_Base>(TaskBase);
				if (!(bAIT_Base == null))
				{
					AActor aActor = GCHelper.Find<AActor>(Owner);
					if (!(aActor == null))
					{
						bAIT_Base.ReceiveExecute(aActor);
					}
				}
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}

		[MonoPInvokeCallback(typeof(Del_OnNativeBTTaskTick))]
		private static void OnNativeBTTaskTick(IntPtr TaskBase, IntPtr Owner, float DeltaTime)
		{
			try
			{
				BAIT_Base bAIT_Base = GCHelper.Find<BAIT_Base>(TaskBase);
				if (!(bAIT_Base == null))
				{
					AActor aActor = GCHelper.Find<AActor>(Owner);
					if (!(aActor == null))
					{
						bAIT_Base.ReceiveTick(aActor, DeltaTime);
					}
				}
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}

		[MonoPInvokeCallback(typeof(Del_OnNativeBTTaskAbort))]
		private static void OnNativeBTTaskAbort(IntPtr TaskBase, IntPtr Owner)
		{
			try
			{
				BAIT_Base bAIT_Base = GCHelper.Find<BAIT_Base>(TaskBase);
				if (!(bAIT_Base == null))
				{
					AActor aActor = GCHelper.Find<AActor>(Owner);
					if (!(aActor == null))
					{
						bAIT_Base.ReceiveAbort(aActor);
					}
				}
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}

		[MonoPInvokeCallback(typeof(Del_OnNativeBTServiceTick))]
		private static void OnNativeBTServiceTick(IntPtr ServiceBase, IntPtr Owner, float DeltaTime)
		{
			try
			{
				BAIS_Base bAIS_Base = GCHelper.Find<BAIS_Base>(ServiceBase);
				if (!(bAIS_Base == null))
				{
					AActor aActor = GCHelper.Find<AActor>(Owner);
					if (!(aActor == null))
					{
						bAIS_Base.ReceiveTick(aActor, DeltaTime);
					}
				}
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}

		[MonoPInvokeCallback(typeof(Del_OnNativeBTServiceActivation))]
		private static void OnNativeBTServiceActivation(IntPtr ServiceBase, IntPtr Owner)
		{
			try
			{
				BAIS_Base bAIS_Base = GCHelper.Find<BAIS_Base>(ServiceBase);
				if (!(bAIS_Base == null))
				{
					AActor aActor = GCHelper.Find<AActor>(Owner);
					if (!(aActor == null))
					{
						bAIS_Base.ReceiveActivation(aActor);
					}
				}
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}

		[MonoPInvokeCallback(typeof(Del_OnNativeBTServiceDeactivation))]
		private static void OnNativeBTServiceDeactivation(IntPtr ServiceBase, IntPtr Owner)
		{
			try
			{
				BAIS_Base bAIS_Base = GCHelper.Find<BAIS_Base>(ServiceBase);
				if (!(bAIS_Base == null))
				{
					AActor aActor = GCHelper.Find<AActor>(Owner);
					if (!(aActor == null))
					{
						bAIS_Base.ReceiveDeactivation(aActor);
					}
				}
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}

		[MonoPInvokeCallback(typeof(Del_OnNativeBTServiceSearchStart))]
		private static void OnNativeBTServiceSearchStart(IntPtr ServiceBase, IntPtr Owner)
		{
			try
			{
				BAIS_Base bAIS_Base = GCHelper.Find<BAIS_Base>(ServiceBase);
				if (!(bAIS_Base == null))
				{
					AActor aActor = GCHelper.Find<AActor>(Owner);
					if (!(aActor == null))
					{
						bAIS_Base.ReceiveSearchStart(aActor);
					}
				}
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}

		static BAID_Base_NativeCallback()
		{
			Ref = 0;
			NativeBTDecoratorCheckCondition = OnNativeBTDecoratorCheckCondition;
			NativeBTTaskExecute = OnNativeBTTaskExecute;
			NativeBTTaskTick = OnNativeBTTaskTick;
			NativeBTTaskAbort = OnNativeBTTaskAbort;
			NativeBTServiceTick = OnNativeBTServiceTick;
			NativeBTServiceActivation = OnNativeBTServiceActivation;
			NativeBTServiceDeactivation = OnNativeBTServiceDeactivation;
			NativeBTServiceSearchStart = OnNativeBTServiceSearchStart;
			UBGUFuncLibCSDelegateRegister.Register_BTDecoratorCheckCondition(FIntPtrHelper.IntPtr2FIntPtr(Marshal.GetFunctionPointerForDelegate(NativeBTDecoratorCheckCondition)));
			UBGUFuncLibCSDelegateRegister.Register_BTTaskExecute(FIntPtrHelper.IntPtr2FIntPtr(Marshal.GetFunctionPointerForDelegate(NativeBTTaskExecute)));
			UBGUFuncLibCSDelegateRegister.Register_BTTaskTick(FIntPtrHelper.IntPtr2FIntPtr(Marshal.GetFunctionPointerForDelegate(NativeBTTaskTick)));
			UBGUFuncLibCSDelegateRegister.Register_BTTaskAbort(FIntPtrHelper.IntPtr2FIntPtr(Marshal.GetFunctionPointerForDelegate(NativeBTTaskAbort)));
			UBGUFuncLibCSDelegateRegister.Register_BTServiceTick(FIntPtrHelper.IntPtr2FIntPtr(Marshal.GetFunctionPointerForDelegate(NativeBTServiceTick)));
			UBGUFuncLibCSDelegateRegister.Register_BTServiceActivation(FIntPtrHelper.IntPtr2FIntPtr(Marshal.GetFunctionPointerForDelegate(NativeBTServiceActivation)));
			UBGUFuncLibCSDelegateRegister.Register_BTServiceDeactivation(FIntPtrHelper.IntPtr2FIntPtr(Marshal.GetFunctionPointerForDelegate(NativeBTServiceDeactivation)));
			UBGUFuncLibCSDelegateRegister.Register_BTServiceSearchStart(FIntPtrHelper.IntPtr2FIntPtr(Marshal.GetFunctionPointerForDelegate(NativeBTServiceSearchStart)));
		}
	}

	public abstract class FsmSolverBase
	{
		public abstract EFsmSolverType FsmSolverType { get; }

		public BUS_AIComp OwningComp { get; private set; }

		public BGUCharacterCS OwningChr { get; private set; }

		public BUS_GSEventCollection OwningBE { get; private set; }

		public BGS_GSEventCollection OwningBGE { get; private set; }

		public virtual void Init(BUS_AIComp AIComp, BGUCharacterCS BGUChr, BUS_GSEventCollection BE, BGS_GSEventCollection BGE)
		{
			OwningComp = AIComp;
			OwningChr = BGUChr;
			OwningBE = BE;
			OwningBGE = BGE;
			AIComp.AIData.CurrentFsmSolverType = FsmSolverType;
		}

		public virtual void Destory()
		{
			OwningComp = null;
			OwningChr = null;
			OwningBE = null;
			OwningBGE = null;
		}

		public virtual void BindEventCollection()
		{
			OwningBE.Evt_OnFSMStateEnter += new Del_Void_FGameplayTag(OnFsmStateEnter);
			OwningBE.Evt_OnFSMStateExit += new Del_Void_FGameplayTag(OnFsmStateExit);
		}

		public virtual void UnBindEventCollection()
		{
			OwningBE.Evt_OnFSMStateEnter -= new Del_Void_FGameplayTag(OnFsmStateEnter);
			OwningBE.Evt_OnFSMStateExit -= new Del_Void_FGameplayTag(OnFsmStateExit);
		}

		public bool CheckIsValid()
		{
			if (OwningComp != null && OwningChr != null && OwningBE != null)
			{
				return OwningBGE != null;
			}
			return false;
		}

		protected virtual void OnFsmStateEnter(FGameplayTag EnterStateTag)
		{
		}

		protected virtual void OnFsmStateExit(FGameplayTag ExitStateTag)
		{
		}

		public abstract void UpdateForAIFsm(float DeltaTime);

		protected AActor SearchTargetFromHostile2Master(IBUC_BattleStateData MasterBattleData, IBUC_TargetInfoData MasterTargetData, out ETargetSourceType SourceType)
		{
			AActor result = null;
			SourceType = ETargetSourceType.None;
			if (MasterBattleData != null && MasterBattleData.IsUnitInBattle() && MasterTargetData != null)
			{
				UnitLockTargetInfo targetInfo = MasterTargetData.GetTargetInfo();
				if (targetInfo != null)
				{
					AActor lockTargetActor = targetInfo.LockTargetActor;
					if (lockTargetActor != null && BGUFuncLibAICS.JudgeActorCanBeAITarget(OwningChr, lockTargetActor, OwningComp.TeamRelationData, OwningComp.UnitHatredCacheData))
					{
						result = lockTargetActor;
						SourceType = ETargetSourceType.Target_FindByMasterLock;
					}
				}
			}
			return result;
		}

		protected AActor SearchTargetFromHostile2LocalPlayer(out ETargetSourceType SourceType, float MaxDistance = -1f)
		{
			AActor aActor = null;
			SourceType = ETargetSourceType.None;
			AActor firstLocalPlayerPawn = OwningComp.LocalPlayerSharedData.FirstLocalPlayerPawn;
			if (firstLocalPlayerPawn != null)
			{
				IBUC_BattleStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(firstLocalPlayerPawn);
				if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.IsUnitInBattle())
				{
					IBUC_TargetInfoData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(firstLocalPlayerPawn);
					if (unPersistentReadOnlyData2 != null)
					{
						UnitLockTargetInfo targetInfo = unPersistentReadOnlyData2.GetTargetInfo();
						if (targetInfo != null)
						{
							AActor lockTargetActor = targetInfo.LockTargetActor;
							if (lockTargetActor != null && BGUFuncLibAICS.JudgeActorCanBeAITarget(OwningChr, lockTargetActor, OwningComp.TeamRelationData, OwningComp.UnitHatredCacheData))
							{
								aActor = lockTargetActor;
								SourceType = ETargetSourceType.Target_FindByPlayerLockTarget;
							}
						}
					}
					if (aActor == null)
					{
						int ChooseLevel = int.MinValue;
						AActor HostileActor = null;
						GetHighLevelHostileFromList(OwningChr, firstLocalPlayerPawn, unPersistentReadOnlyData.AlreadySetOwnerAsTargetUnitList, MaxDistance, ref ChooseLevel, ref HostileActor, (Dictionary<int, int>)null);
						if (HostileActor == null)
						{
							GetHighLevelHostileFromList(OwningChr, firstLocalPlayerPawn, unPersistentReadOnlyData.CanSetOwnerAsTargetUnitList, MaxDistance, ref ChooseLevel, ref HostileActor, (Dictionary<int, int>)null);
						}
						if (HostileActor != null)
						{
							aActor = HostileActor;
							SourceType = ETargetSourceType.Target_FindByHostileToPlayer;
						}
					}
				}
			}
			return aActor;
		}

		private void GetHighLevelHostileFromList(BGUCharacterCS OwningChr, AActor PlayerActor, List<Entity> CheckList, float MaxDistance, ref int ChooseLevel, ref AActor HostileActor, in Dictionary<int, int> HighLevelUnitInfoDic)
		{
			if (CheckList == null || CheckList.Count <= 0)
			{
				return;
			}
			if (HighLevelUnitInfoDic != null && HighLevelUnitInfoDic.Count > 0)
			{
				foreach (Entity Check in CheckList)
				{
					AActor aActor = ECSExtension.ToActor(Check);
					if (HighLevelUnitInfoDic.TryGetValue(BGU_DataUtil.GetActorResID(aActor), out var value) && value > ChooseLevel && BGUFuncLibAICS.JudgeActorCanBeAITarget(OwningChr, aActor, OwningComp.TeamRelationData, OwningComp.UnitHatredCacheData) && (!(MaxDistance > 0f) || !(FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(PlayerActor), BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor)) > MaxDistance)))
					{
						ChooseLevel = value;
						HostileActor = aActor;
					}
				}
				return;
			}
			float num = float.MaxValue;
			foreach (Entity Check2 in CheckList)
			{
				AActor aActor2 = ECSExtension.ToActor(Check2);
				float num2 = FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(PlayerActor), BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor2));
				if (num > num2 && BGUFuncLibAICS.JudgeActorCanBeAITarget(OwningChr, aActor2, OwningComp.TeamRelationData, OwningComp.UnitHatredCacheData) && (!(MaxDistance > 0f) || !(num2 > MaxDistance)))
				{
					num = num2;
					HostileActor = aActor2;
				}
			}
		}
	}

	private abstract class NeutralAnimalAIFsmSolverBase : FsmSolverBase
	{
		protected abstract EBGUFSMStateName ActiveFSMState { get; }

		protected override void OnFsmStateEnter(FGameplayTag EnterStateTag)
		{
			if (GameplayTagExtension.EqualTo(BGW_FlowUtils.NeutralAnimalAIFsmStateTag.Patrol, EnterStateTag))
			{
				base.OwningBE.Evt_StartPatrolAndLeisure.Invoke();
			}
		}

		protected override void OnFsmStateExit(FGameplayTag ExitStateTag)
		{
			if (GameplayTagExtension.EqualTo(BGW_FlowUtils.NeutralAnimalAIFsmStateTag.Patrol, ExitStateTag) && base.OwningComp.PatrolData != null && base.OwningComp.PatrolData.bIsPatroling)
			{
				base.OwningBE.Evt_StopPatrolAndLeisure.Invoke();
				base.OwningBE.Evt_MovementForceStop.Invoke();
			}
		}

		public override void UpdateForAIFsm(float DeltaTime)
		{
			if (!base.OwningComp.FsmData.IsInFsmState(ActiveFSMState))
			{
				return;
			}
			bool flag = false;
			AActor aActor = null;
			UnitLockTargetInfo targetInfo = base.OwningComp.TargetInfoData.GetTargetInfo();
			if (targetInfo != null)
			{
				aActor = targetInfo.LockTargetActor;
				if (aActor != null)
				{
					flag = true;
					if (!BGUFuncLibAICS.JudgeActorCanBeAITarget(base.OwningChr, aActor, base.OwningComp.TeamRelationData, base.OwningComp.UnitHatredCacheData))
					{
						flag = false;
						base.OwningBE.Evt_ClearTargetInfo.Invoke();
					}
				}
			}
			bool flag2 = false;
			if (!flag)
			{
				base.OwningBE.Evt_RefreshHatredInfo.Invoke();
				targetInfo = base.OwningComp.TargetInfoData.GetTargetInfo();
				aActor = targetInfo.LockTargetActor;
				if (aActor == null)
				{
					flag2 = true;
				}
			}
			if (base.OwningChr.GetDistanceTo(aActor) > base.OwningComp.ConfigInfoData.NeutralAnimalBackToPatrolRange)
			{
				flag2 = true;
			}
			if (flag2)
			{
				base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NeutralAnimalEscapeAIFsmEventTag.BackToPatrol);
				base.OwningBE.Evt_ClearTargetInfo.Invoke();
				base.OwningBE.Evt_StartPatrolAndLeisure.Invoke();
			}
		}
	}

	private class NeutralAnimalBattleAIFsmSolver : NeutralAnimalAIFsmSolverBase
	{
		public override EFsmSolverType FsmSolverType => EFsmSolverType.NeutralAnimalBattle;

		protected override EBGUFSMStateName ActiveFSMState => EBGUFSMStateName.FSM_STATE_NEUTRALANIMAL_BATTLE;

		protected override void OnFsmStateEnter(FGameplayTag EnterStateTag)
		{
			base.OnFsmStateEnter(EnterStateTag);
			if (!GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.AIWakeup, EnterStateTag))
			{
				return;
			}
			int num = 0;
			AActor lockTargetActor = base.OwningComp.TargetInfoData.GetTargetInfo().LockTargetActor;
			if (lockTargetActor != null)
			{
				if (base.OwningComp.WakeUpData.bJustUseOnFightSkillFirstTime && base.OwningComp.WakeUpData.bNotFirstTimeWakeUp)
				{
					num = 0;
				}
				else
				{
					FVector a = lockTargetActor.GetActorLocation() - BGUFuncLibActorTransformCS.BGUGetActorLocation(base.OwningChr);
					FVector b = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(base.OwningChr);
					float z = (b.Z = 0f);
					a.Z = z;
					float num3 = FMath.Acos(a.CosineAngle2D(b)) / (float)Math.PI * 180f;
					if (a.Cross_VectorVector(b).Z > 0f)
					{
						num3 *= -1f;
					}
					num = base.OwningComp.GetDirectionOnFightSkill(num3);
				}
			}
			if (num == 0)
			{
				base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NormalAIFsmEventTag.LifeTimeAwake);
			}
			else if (BGW_GameDB.GetSkillSDesc(num, base.OwningChr) != null)
			{
				base.OwningBE.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(num, ECastSkillSourceType.AI_OnFight)
				{
					Reason = EMontageBindReason.EngageSkill,
					NeedCheckSkillCanCast = false
				});
				if (base.OwningComp.SkillInstsData.GetLastSkillCastResult() != ECastSkillResult.CSR_OK)
				{
					base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NormalAIFsmEventTag.LifeTimeAwake);
				}
				else
				{
					base.OwningBE.Evt_CastOnFightSkillSuccess.Invoke(num);
				}
			}
			else
			{
				base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NormalAIFsmEventTag.LifeTimeAwake);
			}
		}
	}

	private class NeutralAnimalEscapeAIFsmSolver : NeutralAnimalAIFsmSolverBase
	{
		public override EFsmSolverType FsmSolverType => EFsmSolverType.NeutralAnimalEscape;

		protected override EBGUFSMStateName ActiveFSMState => EBGUFSMStateName.FSM_STATE_NEUTRALANIMAL_ESCAPE;
	}

	private class GroupAIFsmSolver : FsmSolverBase
	{
		public override EFsmSolverType FsmSolverType => EFsmSolverType.GroupAi;

		public override void UpdateForAIFsm(float DeltaTime)
		{
			if (base.OwningComp.FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_LIFE_RETURNHOME))
			{
				return;
			}
			bool flag = false;
			AActor aActor = null;
			UnitLockTargetInfo targetInfo = base.OwningComp.TargetInfoData.GetTargetInfo();
			if (targetInfo != null)
			{
				aActor = targetInfo.LockTargetActor;
				if (aActor != null)
				{
					flag = BGUFuncLibAICS.JudgeActorCanBeAITarget(base.OwningChr, aActor, base.OwningComp.TeamRelationData, base.OwningComp.UnitHatredCacheData);
				}
			}
			if (!flag)
			{
				base.OwningBE.Evt_ClearTargetInfo.Invoke();
				if (targetInfo != null)
				{
					aActor = targetInfo.LockTargetActor;
					if (aActor == null)
					{
						base.OwningBE?.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_GOHOME);
					}
				}
			}
			else if (base.OwningComp.AIData.FsmContext.bNeedReturnHome && !base.OwningComp.UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				base.OwningBE.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_GOHOME);
			}
			else if (!base.OwningComp.AIData.IsInPursuitRange(BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor)))
			{
				base.OwningBE.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_GOHOME);
			}
		}
	}

	private class FriendlyBattleNpcAIFsmSolver : FsmSolverBase
	{
		private float FindHostile2PlayerTimer = NONCOMBAT_FIND_HOSTILE_DURATION;

		public override EFsmSolverType FsmSolverType => EFsmSolverType.FriendlyBattleNpc;

		protected override void OnFsmStateEnter(FGameplayTag EnterStateTag)
		{
			if (GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.AINonCombat, EnterStateTag))
			{
				FindHostile2PlayerTimer = NONCOMBAT_FIND_HOSTILE_DURATION;
			}
		}

		protected override void OnFsmStateExit(FGameplayTag ExitStateTag)
		{
			if (!base.OwningComp.UnitStateData.HasState(EBGUUnitState.Dead) && !base.OwningComp.SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) && GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.AIBattle, ExitStateTag))
			{
				base.OwningBE.Evt_OnLeaveFight.Invoke();
				base.OwningBGE.Evt_BGS_FightVanished.Invoke(base.OwningChr);
			}
		}

		public override void UpdateForAIFsm(float DeltaTime)
		{
			if (base.OwningComp.FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_BATTLE))
			{
				bool flag = false;
				AActor aActor = null;
				UnitLockTargetInfo targetInfo = base.OwningComp.TargetInfoData.GetTargetInfo();
				if (targetInfo != null)
				{
					aActor = targetInfo.LockTargetActor;
					if (aActor != null)
					{
						flag = true;
						if (!BGUFuncLibAICS.JudgeActorCanBeAITarget(base.OwningChr, aActor, base.OwningComp.TeamRelationData, base.OwningComp.UnitHatredCacheData))
						{
							flag = false;
							base.OwningBE.Evt_ClearTargetInfo.Invoke();
						}
					}
				}
				if (!flag)
				{
					base.OwningBE.Evt_RefreshHatredInfo.Invoke();
					targetInfo = base.OwningComp.TargetInfoData.GetTargetInfo();
					aActor = targetInfo.LockTargetActor;
					if (aActor == null)
					{
						base.OwningBE.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_STANDBY);
					}
				}
			}
			else
			{
				if (!base.OwningComp.FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_NONCOMBAT))
				{
					return;
				}
				FindHostile2PlayerTimer -= DeltaTime;
				if (!(FindHostile2PlayerTimer > 0f))
				{
					FindHostile2PlayerTimer = NONCOMBAT_FIND_HOSTILE_DURATION;
					ETargetSourceType SourceType;
					AActor aActor2 = SearchTargetFromHostile2LocalPlayer(out SourceType);
					if (aActor2 != null)
					{
						base.OwningComp.OnCatchTarget(aActor2, SourceType, SkipWakeUp: true);
					}
				}
			}
		}
	}

	private class NormalAIFsmSolver : FsmSolverBase
	{
		private List<int> StalemateSkillID = new List<int>();

		public override EFsmSolverType FsmSolverType => EFsmSolverType.Normal;

		protected override void OnFsmStateEnter(FGameplayTag EnterStateTag)
		{
			if (GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.LifeTimeReturnHome, EnterStateTag))
			{
				base.OwningComp.AIData.FsmContext.bCanTriggerReturnHome = true;
				base.OwningComp.AIData.FsmContext.bCanUpdateForReturnHome = false;
				base.OwningComp.AIData.FsmContext.ReturnHomeTimer = 0f;
				base.OwningComp.AIData.FsmContext.ReturnHomeBuffID = 0;
			}
			else if (GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.LifeTimeRevolveAround, EnterStateTag))
			{
				base.OwningComp.AIData.FsmContext.bCanTriggerGazeAndSurround = true;
			}
			else if (GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.LifeTimeStalemate, EnterStateTag))
			{
				base.OwningComp.AIData.SetStalemateMoveTime(0f);
			}
		}

		protected override void OnFsmStateExit(FGameplayTag ExitStateTag)
		{
			if (GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.LifeTimeReturnHome, ExitStateTag))
			{
				if (base.OwningComp.BuffData.HasBuff(RETURNHOME_BUFFID))
				{
					base.OwningBE.Evt_BuffRemoveImmediately.Invoke(RETURNHOME_BUFFID, EBuffEffectTriggerType.None);
				}
				int returnHomeBuffID = base.OwningComp.AIData.FsmContext.ReturnHomeBuffID;
				if (returnHomeBuffID > 0 && base.OwningComp.BuffData.HasBuff(returnHomeBuffID))
				{
					base.OwningBE.Evt_BuffRemoveImmediately.Invoke(returnHomeBuffID, EBuffEffectTriggerType.None);
					base.OwningComp.AIData.FsmContext.ReturnHomeBuffID = 0;
				}
			}
		}

		public override void UpdateForAIFsm(float DeltaTime)
		{
			AActor TargetActor2;
			if (base.OwningComp.FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_LIFE_RETURNHOME))
			{
				if (DebugConfig.CricketBattleMode)
				{
					return;
				}
				if (base.OwningComp.AIData.FsmContext.bCanTriggerReturnHome)
				{
					if (base.OwningComp.UnitStateData.HasState(EBGUUnitState.Attacking))
					{
						return;
					}
					base.OwningComp.AIData.FsmContext.bCanTriggerReturnHome = false;
					base.OwningComp.AIData.FsmContext.bCanUpdateForReturnHome = true;
					BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(RETURNHOME_BUFFID, base.OwningComp.PassiveSkillData);
					if (buffDescRuntime != null)
					{
						base.OwningComp.AIData.FsmContext.ReturnHomeTimer = (float)buffDescRuntime.GetDuration() * 0.001f;
					}
					base.OwningBE.Evt_BuffAdd.Invoke(RETURNHOME_BUFFID, base.OwningChr, base.OwningChr, (base.OwningComp.AIData.FsmContext.ReturnHomeTimer > 0f) ? (-1f) : 0f, EBuffSourceType.AI);
					int num = base.OwningComp.AIData.ReturnHomeSkill;
					int num2 = base.OwningComp.AIData.ReturnHomeBuff;
					if (base.OwningComp.ConfigInfoData.StalemateInfoMap != null && base.OwningComp.ConfigInfoData.StalemateInfoMap.Count > 0)
					{
						if (base.OwningComp.ConfigInfoData.StalemateInfoMap.TryGetValue(0, out var value))
						{
							num = value.ReturnHomeSkillID;
							num2 = value.ReturnHomeBuffID;
						}
						foreach (KeyValuePair<int, FStalemateInfo> item in base.OwningComp.ConfigInfoData.StalemateInfoMap)
						{
							if (base.OwningComp.BuffData.HasBuff(item.Key))
							{
								num = item.Value.ReturnHomeSkillID;
								num2 = item.Value.ReturnHomeBuffID;
							}
						}
					}
					base.OwningBE.Evt_SetAIBTAborted.Invoke();
					if (num > 0)
					{
						BGUFunctionLibraryCS.BGUTryCastSpell(base.OwningChr, num, ECastSkillSourceType.AI_ReturnHome);
					}
					else if (base.OwningComp.AIData.ReturnHomeMoveType == EFsmMoveLogicType.Auto && base.OwningComp.ABPHelperData != null)
					{
						FTransform myPosWhenEnterBattle = base.OwningComp.AIData.Memory.MyPosWhenEnterBattle;
						myPosWhenEnterBattle.Translation.Z -= base.OwningChr.BaseEyeHeight;
						if (base.OwningComp.ABPHelperData.HasValidMoveAnimConfig(EMoveSpeedLevel.Sprint, bLockMove: false))
						{
							base.OwningBE.Evt_ChangeMotionMatchingState.Invoke(EState_MM.Free);
							BGUFuncLibForMove.BeginMoveToPos(base.OwningChr, myPosWhenEnterBattle.GetLocation(), 0f, EAIMoveSpeedType.SPRINT, EBGUMoveAIType.None, IncludeSelfRadius: true, IncludeTargetRadius: false, out var _);
						}
					}
					if (num2 > 0)
					{
						base.OwningBE.Evt_BuffAdd.Invoke(num2, base.OwningChr, base.OwningChr, 0f, EBuffSourceType.AI);
						base.OwningComp.AIData.FsmContext.ReturnHomeBuffID = num2;
					}
				}
				else if (base.OwningComp.AIData.FsmContext.bCanUpdateForReturnHome)
				{
					base.OwningComp.AIData.FsmContext.ReturnHomeTimer -= DeltaTime;
					if (!(base.OwningComp.AIData.FsmContext.ReturnHomeTimer > 0f))
					{
						base.OwningComp.AIData.FsmContext.ReturnHomeTimer = 0f;
						base.OwningComp.AIData.FsmContext.bCanUpdateForReturnHome = false;
						base.OwningComp.BGSEventCollection.Evt_BGS_FightVanished.Invoke(base.OwningChr);
						base.OwningComp.BGWEventCollection.Evt_TriggerResetOneActor(base.OwningComp.GuidData.GetFinalGuid(), EResetActorReason.ReturnHome);
					}
				}
			}
			else if (base.OwningComp.FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_REVOLVEAROUND))
			{
				if (base.OwningComp.HandleNeedReturnHomeCheck())
				{
					return;
				}
				if (base.OwningComp.AIData.FsmContext.bCanTriggerGazeAndSurround)
				{
					base.OwningComp.AIData.FsmContext.bCanTriggerGazeAndSurround = false;
					if (base.OwningComp.AIData.GazeAndSurroundMoveType == EFsmMoveLogicType.Auto)
					{
						UEnvQuery uEnvQuery = BGW_PreloadAssetMgr.Get(base.OwningComp).TryGetCachedResourceObj<UEnvQuery>(base.OwningComp.AIData.GazeAndSurroundEQSPath, ELoadResourceType.SyncLoadAndCache, EAssetPriority.Top);
						if (uEnvQuery != null && base.OwningComp.ABPHelperData != null && base.OwningComp.ABPHelperData.HasValidMoveAnimConfig(EMoveSpeedLevel.Run, bLockMove: true))
						{
							base.OwningBE.Evt_ChangeMotionMatchingState.Invoke(EState_MM.Lock);
							base.OwningBE.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.EQSRun, new AINodeAction_EQSRunParamInfo
							{
								AcceptableRadius = 500f,
								IncludeSelfRadius = true,
								EQSTemplate = uEnvQuery,
								MoveAIType = EBGUMoveAIType.KeepFacingTarget,
								SpeedRateType = EAIMoveSpeedType.RUN,
								SpeedRateDistanceCurve = null,
								EnableRangeAcceptableRadius = true,
								MinAcceptableRadius = 500f,
								MaxAcceptableRadius = 700f,
								AutoUpdatePathTime = 2f,
								EnableLeisure = false,
								IntervalTime = 0f,
								LeisureList = null
							});
						}
					}
				}
				if (base.OwningComp.IsStandAlone)
				{
					APawn firstLocalPlayerPawn = base.OwningComp.LocalPlayerSharedData.FirstLocalPlayerPawn;
					if (firstLocalPlayerPawn != null && !BGUFunctionLibraryCS.BGUHasUnitState(firstLocalPlayerPawn, EBGUUnitState.Dead) && !BGUFunctionLibraryCS.BGUHasUnitState(firstLocalPlayerPawn, EBGUUnitState.LifeSavingHair_FakeDead) && !BGUFunctionLibraryCS.BGUHasUnitState(firstLocalPlayerPawn, EBGUUnitState.LifeSavingHair_Rebirth) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(firstLocalPlayerPawn, EBGUSimpleState.PendingDeathInAnimationSyncing))
					{
						base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NormalAIFsmEventTag.LifeTimeIntoBattle);
					}
				}
			}
			else if (base.OwningComp.FsmData.IsInFsmState(BGW_FlowUtils.NormalAIFsmStateTag.LifeTimeStalemate))
			{
				if (base.OwningComp.HandleNeedReturnHomeCheck() || !ValidTargetUpdate(out var TargetActor))
				{
					return;
				}
				FVector checkPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor);
				if (base.OwningComp.AIData.IsInPursuitRange(checkPos))
				{
					base.OwningComp.AIData.SetStalemateMoveTime(0f);
					base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NormalAIFsmEventTag.LifeTimeIntoBattle);
					return;
				}
				if (base.OwningComp.AINodeData.ActionType != EAINodeActionType.Combo && CheckCanCastStalemateSkill(TargetActor))
				{
					base.OwningComp.AIData.SetStalemateMoveTime(0f);
					base.OwningBE.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.Combo, new AINodeAction_ComboParamInfo
					{
						ComboTargetType = EComboTargetType.CurrentAITarget,
						SkillSourceType = EZatoichiSkillSourceType.UseWithStalemateSkill,
						PursuitInAllSkill = false,
						PursuitAnyWhere = false,
						ForceCastSkillAfterPursuitFailed = false,
						PursuitRangePos = 1f,
						SpeedRateType = EAIMoveSpeedType.SPRINT,
						MotionMatchingMoveMode = EState_MM.Free,
						MoveAIType = EBGUMoveAIType.KeepFacingTarget,
						MoveAcceptableRadiusType = EBGUMoveAcceptableRadiusType.IncludeTarget,
						BeginRotateAngle = 30f,
						IsUseSkillForTurn = true,
						IsUseSkillForMove = false,
						IsGetTopRandomSkill = true,
						TopRandomSkillPercent = 10000
					});
					return;
				}
				base.OwningComp.AIData.SetStalemateMoveTime(base.OwningComp.AIData.GetStalemateMoveTime() + DeltaTime);
				if (base.OwningComp.AIData.GetStalemateMoveTime() > 6f)
				{
					if (base.OwningComp.AIData.ReturnHomeTriggerType == EFsmStateLogicTriggerType.Auto && !base.OwningComp.FsmData.HasOverrideSubMachine(BGW_FlowUtils.NormalAIFsmStateTag.AIBattle))
					{
						base.OwningBE.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_GOHOME);
					}
				}
				else if (base.OwningComp.AIData.StalemateMoveType == EFsmMoveLogicType.Auto && base.OwningComp.AINodeData.ActionType == EAINodeActionType.None && base.OwningComp.ABPHelperData != null && base.OwningComp.ABPHelperData.HasValidMoveAnimConfig(EMoveSpeedLevel.Run, bLockMove: true))
				{
					base.OwningBE.Evt_ChangeMotionMatchingState.Invoke(EState_MM.Lock);
					base.OwningBE.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.MoveTo, new AINodeAction_MoveToParamInfo
					{
						AcceptableRadius = 100f,
						IncludeSelfRadius = true,
						IncludeTargetRadius = false,
						TargetLocation = base.OwningComp.AIData.Memory.MyPosWhenEnterBattle.GetLocation(),
						BTTargetType = EBTTargetType.Location,
						SpeedRateType = EAIMoveSpeedType.RUN,
						MoveAIType = EBGUMoveAIType.KeepFacingTarget,
						SpeedRateDistanceCurve = null,
						EnableRangeAcceptableRadius = false,
						MaxMoveTime = -1f,
						MinAcceptableRadius = -1f,
						MaxAcceptableRadius = -1f
					});
				}
			}
			else if (base.OwningComp.FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_BATTLE) && !base.OwningComp.HandleNeedReturnHomeCheck() && ValidTargetUpdate(out TargetActor2) && base.OwningComp.AIData.StalemateTriggerType == EFsmStateLogicTriggerType.Auto && !base.OwningComp.FsmData.HasOverrideSubMachine(BGW_FlowUtils.NormalAIFsmStateTag.AIBattle))
			{
				FVector checkPos2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor2);
				if (!base.OwningComp.AIData.IsInPursuitRange(checkPos2))
				{
					base.OwningBE.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_BATTLE_STALEMATE);
				}
			}
		}

		public override void BindEventCollection()
		{
			base.BindEventCollection();
			base.OwningBE.EVt_NotifyAIActionFinish += new Del_NotifyAIActionFinish(OnNotifyAIActionFinish);
		}

		public override void UnBindEventCollection()
		{
			base.UnBindEventCollection();
			base.OwningBE.EVt_NotifyAIActionFinish -= new Del_NotifyAIActionFinish(OnNotifyAIActionFinish);
		}

		private void OnNotifyAIActionFinish(EAINodeActionType ActionType)
		{
			if (base.OwningComp.FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_REVOLVEAROUND) && ActionType == EAINodeActionType.EQSRun)
			{
				base.OwningComp.AIData.FsmContext.bCanTriggerGazeAndSurround = true;
			}
		}

		private bool CheckCanCastStalemateSkill(AActor TargetActor)
		{
			if (TargetActor == null)
			{
				return false;
			}
			IBUC_ConfigInfoData configInfoData = base.OwningComp.ConfigInfoData;
			IBUC_BuffData buffData = base.OwningComp.BuffData;
			if (configInfoData == null || buffData == null)
			{
				return false;
			}
			if (StalemateSkillID.Count > 0)
			{
				StalemateSkillID.Clear();
			}
			if (configInfoData.StalemateInfoMap.Count > 0)
			{
				bool flag = false;
				foreach (KeyValuePair<int, FStalemateInfo> item in configInfoData.StalemateInfoMap)
				{
					if (buffData.HasBuff(item.Key))
					{
						flag = true;
						StalemateSkillID = item.Value.StalemateSkillID;
						break;
					}
				}
				if (!flag && configInfoData.StalemateInfoMap.TryGetValue(0, out var value))
				{
					StalemateSkillID = value.StalemateSkillID;
				}
			}
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(base.OwningChr);
			foreach (int item2 in StalemateSkillID)
			{
				int num = BGUFuncLibSkillCS.BGUGetSkillIDByMapping(base.OwningChr, item2);
				FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(num);
				if (skillAIDesc != null)
				{
					float num2 = fVector.Size2D();
					if (!(num2 < skillAIDesc.PreferRangeMin) && !(skillAIDesc.PreferRangeMax < num2) && !(skillAIDesc.PreferHeightDis < fVector.Z) && BGU_CommonUtil.CheckSkillCanCast(base.OwningChr, item2, num) == ECanCastSkillResult.CCSR_OK)
					{
						return true;
					}
				}
			}
			return false;
		}

		private bool ValidTargetUpdate(out AActor TargetActor)
		{
			TargetActor = null;
			bool result = true;
			bool flag = false;
			UnitLockTargetInfo targetInfo = base.OwningComp.TargetInfoData.GetTargetInfo();
			if (targetInfo != null)
			{
				TargetActor = targetInfo.LockTargetActor;
				if (TargetActor != null)
				{
					flag = true;
					if (!BGUFuncLibAICS.JudgeActorCanBeAITarget(base.OwningChr, TargetActor, base.OwningComp.TeamRelationData, base.OwningComp.UnitHatredCacheData))
					{
						flag = false;
						base.OwningBE.Evt_ClearTargetInfo.Invoke();
					}
				}
			}
			if (!flag)
			{
				base.OwningBE.Evt_RefreshHatredInfo.Invoke();
			}
			targetInfo = base.OwningComp.TargetInfoData.GetTargetInfo();
			TargetActor = targetInfo.LockTargetActor;
			if (TargetActor == null)
			{
				result = false;
				if (CheckCanEnterGazeAndSurround())
				{
					base.OwningBE.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_GAZEANDSURROUND);
				}
				else if (base.OwningComp.AIData.ReturnHomeTriggerType == EFsmStateLogicTriggerType.Auto && !base.OwningComp.FsmData.HasOverrideSubMachine(BGW_FlowUtils.NormalAIFsmStateTag.AIBattle))
				{
					base.OwningBE.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_GOHOME);
				}
			}
			else if (TargetActor == base.OwningComp.LocalPlayerSharedData.FirstLocalPlayerPawn && CheckCanEnterGazeAndSurround())
			{
				base.OwningBE.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_GAZEANDSURROUND);
			}
			return result;
		}

		private bool CheckCanEnterGazeAndSurround()
		{
			if (base.OwningComp.IsStandAlone && base.OwningComp.AIData.GazeAndSurroundTriggerType == EFsmStateLogicTriggerType.Auto && !base.OwningComp.FsmData.HasOverrideSubMachine(BGW_FlowUtils.NormalAIFsmStateTag.AIBattle))
			{
				APawn firstLocalPlayerPawn = base.OwningComp.LocalPlayerSharedData.FirstLocalPlayerPawn;
				if (firstLocalPlayerPawn != null)
				{
					IBUC_UnitStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(firstLocalPlayerPawn);
					IBUC_SimpleStateData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(firstLocalPlayerPawn);
					if (unPersistentReadOnlyData != null && unPersistentReadOnlyData2 != null && (unPersistentReadOnlyData.HasState(EBGUUnitState.Dead) || unPersistentReadOnlyData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) || unPersistentReadOnlyData.HasState(EBGUUnitState.LifeSavingHair_Rebirth) || unPersistentReadOnlyData2.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing)))
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	private class SummonAIFsmSolver : FsmSolverBase
	{
		private float FindHostileTimer;

		private IBUC_BattleStateData MasterBattleStateData;

		private IBUC_TargetInfoData MasterTargetInfoData;

		public override EFsmSolverType FsmSolverType => EFsmSolverType.SummonAi;

		public override void Init(BUS_AIComp AIComp, BGUCharacterCS BGUChr, BUS_GSEventCollection BE, BGS_GSEventCollection BGE)
		{
			base.Init(AIComp, BGUChr, BE, BGE);
			AActor masterActor = base.OwningComp.MasterData.GetMasterActor();
			if (masterActor != null)
			{
				MasterBattleStateData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(masterActor);
				MasterTargetInfoData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(masterActor);
			}
		}

		protected override void OnFsmStateEnter(FGameplayTag EnterStateTag)
		{
			if (GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.AINonCombat, EnterStateTag))
			{
				FindHostileTimer = NONCOMBAT_FIND_HOSTILE_DURATION;
			}
		}

		protected override void OnFsmStateExit(FGameplayTag ExitStateTag)
		{
			if (!base.OwningComp.UnitStateData.HasState(EBGUUnitState.Dead) && !base.OwningComp.SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) && GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.AIBattle, ExitStateTag))
			{
				base.OwningBE.Evt_OnLeaveFight.Invoke();
				base.OwningBGE.Evt_BGS_FightVanished.Invoke(base.OwningChr);
			}
		}

		public override void UpdateForAIFsm(float DeltaTime)
		{
			if (base.OwningComp.FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_BATTLE))
			{
				bool flag = false;
				AActor aActor = null;
				UnitLockTargetInfo targetInfo = base.OwningComp.TargetInfoData.GetTargetInfo();
				if (targetInfo != null)
				{
					aActor = targetInfo.LockTargetActor;
					if (aActor != null)
					{
						flag = true;
						if (!BGUFuncLibAICS.JudgeActorCanBeAITarget(base.OwningChr, aActor, base.OwningComp.TeamRelationData, base.OwningComp.UnitHatredCacheData))
						{
							flag = false;
							base.OwningBE.Evt_ClearTargetInfo.Invoke();
						}
					}
				}
				if (!flag)
				{
					base.OwningBE.Evt_RefreshHatredInfo.Invoke();
					targetInfo = base.OwningComp.TargetInfoData.GetTargetInfo();
					aActor = targetInfo.LockTargetActor;
					if (aActor == null)
					{
						base.OwningBE.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_STANDBY);
					}
				}
			}
			else
			{
				if (!base.OwningComp.FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_NONCOMBAT))
				{
					return;
				}
				FindHostileTimer -= DeltaTime;
				if (!(FindHostileTimer > 0f))
				{
					FindHostileTimer = NONCOMBAT_FIND_HOSTILE_DURATION;
					ETargetSourceType SourceType;
					AActor aActor2 = SearchTargetFromHostile2Master(MasterBattleStateData, MasterTargetInfoData, out SourceType);
					if (aActor2 != null)
					{
						base.OwningComp.OnCatchTarget(aActor2, SourceType, SkipWakeUp: true);
					}
				}
			}
		}
	}

	private class AssistantPartnerFsmSolver : FsmSolverBase
	{
		private static readonly string SEQ_FINISH_PLAYBACK_EQS_PATH = "EnvQuery'/Game/00Main/Design/AI/FSM/FollowPartner/EQ_FollowPartner_SeqFinishMove.EQ_FollowPartner_SeqFinishMove'";

		private int InvisibleBuffID = 511;

		private static readonly float INTERACT_JUDGE_DURATION = 0.5f;

		private static readonly float CLOSE_SET_TARGET_BY_HATRED_TIME = 10f;

		private float JudgeValidInteractAreaTimer = INTERACT_JUDGE_DURATION;

		private Entity InteractingEntity = Entity.Null;

		private int CachedMoveIdx = -1;

		private float CloseSetTargetByHatredTimer = -1f;

		public override EFsmSolverType FsmSolverType => EFsmSolverType.AssistantPartner;

		protected override void OnFsmStateEnter(FGameplayTag EnterStateTag)
		{
			if (base.OwningComp.UnitStateData.HasState(EBGUUnitState.Dead) || base.OwningComp.SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
			{
				return;
			}
			if (GameplayTagExtension.EqualTo(BGW_FlowUtils.FollowPartnerAIFsmStateTag.FocusOnPlayer, EnterStateTag))
			{
				base.OwningComp.AIData.StopPerception = true;
				base.OwningBE.Evt_EnableCanUpdateHatred.Invoke(P1: false);
				base.OwningBE.Evt_ClearAllTarget.Invoke();
				base.OwningBE.Evt_ClearHatredList.Invoke();
				ETargetSourceType SourceType;
				AActor aActor = SearchTargetFromHostile2LocalPlayer(out SourceType, 5000f);
				if (aActor != null)
				{
					SetCanSetTargetByHatred(bCanSet: false);
					base.OwningComp.OnCatchTarget(aActor, SourceType, SkipWakeUp: true);
				}
				else
				{
					base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.BackToPlayer);
				}
			}
			else if (GameplayTagExtension.EqualTo(BGW_FlowUtils.FollowPartnerAIFsmStateTag.AroundPlayer, EnterStateTag))
			{
				base.OwningComp.AIData.StopPerception = true;
				base.OwningBE.Evt_EnableCanUpdateHatred.Invoke(P1: false);
				base.OwningBE.Evt_ClearAllTarget.Invoke();
				base.OwningBE.Evt_ClearHatredList.Invoke();
			}
			else if (GameplayTagExtension.EqualTo(BGW_FlowUtils.FollowPartnerAIFsmStateTag.NonCombat, EnterStateTag))
			{
				JudgeValidInteractAreaTimer = INTERACT_JUDGE_DURATION;
				InteractingEntity = Entity.Null;
			}
			else if (GameplayTagExtension.EqualTo(BGW_FlowUtils.FollowPartnerAIFsmStateTag.Waiting, EnterStateTag))
			{
				if (InteractingEntity != Entity.Null)
				{
					AActor aActor2 = ECSExtension.ToActor(InteractingEntity);
					if (aActor2 != null)
					{
						base.OwningBE.Evt_SetAINodeActionStop.Invoke();
						base.OwningBE.Evt_AiComeCloseToInteractActor.Invoke(aActor2);
					}
				}
			}
			else if (GameplayTagExtension.EqualTo(BGW_FlowUtils.FollowPartnerAIFsmStateTag.Interacting, EnterStateTag))
			{
				if (InteractingEntity != Entity.Null)
				{
					AActor aActor3 = ECSExtension.ToActor(InteractingEntity);
					if (aActor3 != null)
					{
						base.OwningBE.Evt_SetAINodeActionStop.Invoke();
						base.OwningBE.Evt_TriggerAiInteract.Invoke(aActor3);
					}
				}
			}
			else if (BGW_FlowUtils.FollowPartnerAIFsmStateTag.Hidden.Equals(EnterStateTag))
			{
				base.OwningBE.Evt_OnLeaveFight.Invoke();
				base.OwningBGE.Evt_BGS_FightVanished.Invoke(base.OwningChr);
				base.OwningComp.AIData.StopPerception = true;
				base.OwningBE.Evt_EnableCanUpdateHatred.Invoke(P1: false);
				base.OwningBE.Evt_ClearAllTarget.Invoke();
				base.OwningBE.Evt_ClearHatredList.Invoke();
				base.OwningBE.Evt_BuffAdd.Invoke(InvisibleBuffID, base.OwningChr, base.OwningChr, -1f, EBuffSourceType.FollowPartner);
			}
			else if (BGW_FlowUtils.FollowPartnerAIFsmStateTag.Playback.Equals(EnterStateTag))
			{
				TriggerSeqFinishPlayback();
			}
		}

		protected override void OnFsmStateExit(FGameplayTag ExitStateTag)
		{
			if (base.OwningComp.UnitStateData.HasState(EBGUUnitState.Dead) || base.OwningComp.SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
			{
				return;
			}
			if (GameplayTagExtension.EqualTo(BGW_FlowUtils.FollowPartnerAIFsmStateTag.Battle, ExitStateTag))
			{
				base.OwningBE.Evt_OnLeaveFight.Invoke();
				base.OwningBGE.Evt_BGS_FightVanished.Invoke(base.OwningChr);
				SetCanSetTargetByHatred(bCanSet: true);
			}
			else if (GameplayTagExtension.EqualTo(BGW_FlowUtils.FollowPartnerAIFsmStateTag.NonCombat, ExitStateTag))
			{
				base.OwningBE.Evt_AiBreakInteract.Invoke(EAiBreakInteractionType.Battle);
			}
			else if (GameplayTagExtension.EqualTo(BGW_FlowUtils.FollowPartnerAIFsmStateTag.Idle, ExitStateTag) || GameplayTagExtension.EqualTo(BGW_FlowUtils.FollowPartnerAIFsmStateTag.LongIdle, ExitStateTag) || GameplayTagExtension.EqualTo(BGW_FlowUtils.FollowPartnerAIFsmStateTag.Dodge, ExitStateTag))
			{
				base.OwningBE.Evt_BreakIdleDisp.Invoke();
			}
			else if (GameplayTagExtension.EqualTo(BGW_FlowUtils.FollowPartnerAIFsmStateTag.FocusOnPlayer, ExitStateTag) || GameplayTagExtension.EqualTo(BGW_FlowUtils.FollowPartnerAIFsmStateTag.AroundPlayer, ExitStateTag) || GameplayTagExtension.EqualTo(BGW_FlowUtils.FollowPartnerAIFsmStateTag.InSeqShowing, ExitStateTag))
			{
				base.OwningComp.AIData.StopPerception = false;
				base.OwningBE.Evt_EnableCanUpdateHatred.Invoke(P1: true);
				if (GameplayTagExtension.EqualTo(BGW_FlowUtils.FollowPartnerAIFsmStateTag.InSeqShowing, ExitStateTag))
				{
					base.OwningBE.Evt_BuffRemoveImmediately.Invoke(InvisibleBuffID, EBuffEffectTriggerType.None);
				}
			}
		}

		public override void UpdateForAIFsm(float DeltaTime)
		{
			if (base.OwningBE == null)
			{
				return;
			}
			if (CloseSetTargetByHatredTimer > 0f)
			{
				CloseSetTargetByHatredTimer -= DeltaTime;
				if (CloseSetTargetByHatredTimer <= 0f)
				{
					SetCanSetTargetByHatred(bCanSet: true);
				}
			}
			if (base.OwningComp.FsmData.IsInFsmState(BGW_FlowUtils.FollowPartnerAIFsmStateTag.Battle))
			{
				if (base.OwningComp.FsmData.IsInFsmState(BGW_FlowUtils.FollowPartnerAIFsmStateTag.FocusOnAttack))
				{
					bool flag = false;
					AActor aActor = null;
					UnitLockTargetInfo targetInfo = base.OwningComp.TargetInfoData.GetTargetInfo();
					if (targetInfo != null)
					{
						aActor = targetInfo.LockTargetActor;
						if (aActor != null)
						{
							flag = true;
							if (!BGUFuncLibAICS.JudgeActorCanBeAITarget(base.OwningChr, aActor, base.OwningComp.TeamRelationData, base.OwningComp.UnitHatredCacheData))
							{
								flag = false;
								base.OwningBE.Evt_ClearTargetInfo.Invoke();
							}
						}
					}
					if (!flag)
					{
						SetCanSetTargetByHatred(bCanSet: true);
						base.OwningBE?.Evt_RefreshHatredInfo.Invoke();
						targetInfo = base.OwningComp.TargetInfoData.GetTargetInfo();
						aActor = targetInfo.LockTargetActor;
						if (aActor == null)
						{
							base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.ApproachPlayer);
						}
					}
				}
				else
				{
					if (!base.OwningComp.FsmData.IsInFsmState(BGW_FlowUtils.FollowPartnerAIFsmStateTag.FocusOnPlayer))
					{
						return;
					}
					bool flag2 = false;
					UnitLockTargetInfo targetInfo2 = base.OwningComp.TargetInfoData.GetTargetInfo();
					if (targetInfo2 != null)
					{
						AActor lockTargetActor = targetInfo2.LockTargetActor;
						if (lockTargetActor != null)
						{
							flag2 = true;
							if (!BGUFuncLibAICS.JudgeActorCanBeAITarget(base.OwningChr, lockTargetActor, base.OwningComp.TeamRelationData, base.OwningComp.UnitHatredCacheData))
							{
								flag2 = false;
								base.OwningBE.Evt_ClearTargetInfo.Invoke();
							}
						}
					}
					if (!flag2)
					{
						ETargetSourceType SourceType;
						AActor aActor2 = SearchTargetFromHostile2LocalPlayer(out SourceType, 5000f);
						if (aActor2 != null)
						{
							flag2 = true;
							SetCanSetTargetByHatred(bCanSet: false);
							base.OwningComp.OnCatchTarget(aActor2, SourceType, SkipWakeUp: true);
						}
					}
					if (!flag2)
					{
						base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.BackToPlayer);
					}
				}
			}
			else
			{
				if (!base.OwningComp.FsmData.IsInFsmState(BGW_FlowUtils.FollowPartnerAIFsmStateTag.NonCombat))
				{
					return;
				}
				ETargetSourceType SourceType2;
				AActor aActor3 = SearchTargetFromHostile2LocalPlayer(out SourceType2, 3000f);
				if (aActor3 != null)
				{
					base.OwningBE.Evt_AiBreakInteract.Invoke(EAiBreakInteractionType.Battle);
					base.OwningComp.OnCatchTarget(aActor3, SourceType2, SkipWakeUp: true);
					return;
				}
				if (base.OwningComp.UnitStateData.HasState(EBGUUnitState.Attacking))
				{
					JudgeValidInteractAreaTimer = INTERACT_JUDGE_DURATION;
					return;
				}
				JudgeValidInteractAreaTimer -= DeltaTime;
				if (JudgeValidInteractAreaTimer > 0f)
				{
					return;
				}
				JudgeValidInteractAreaTimer = INTERACT_JUDGE_DURATION;
				if (base.OwningComp.FsmData.IsInFsmState(BGW_FlowUtils.FollowPartnerAIFsmStateTag.Idle))
				{
					base.OwningComp.FollowPartnerMgrData.GetLastEnterInteractArea(out var InteractEntity, out var Step);
					if (InteractEntity != Entity.Null && ECSExtension.ToActor(InteractEntity) != null)
					{
						InteractingEntity = InteractEntity;
						switch (Step)
						{
						case 1:
							base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.WaitForInteract);
							break;
						case 2:
							base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.EnterInteractArea);
							break;
						}
					}
				}
				else if (base.OwningComp.FsmData.IsInFsmState(BGW_FlowUtils.FollowPartnerAIFsmStateTag.Waiting))
				{
					if (InteractingEntity == Entity.Null)
					{
						base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.FreeTime);
					}
					else if (base.OwningComp.FollowPartnerMgrData.GetInteractAreaStep(InteractingEntity) == -1)
					{
						base.OwningBE.Evt_AiDisengageInteract.Invoke(EAiBreakInteractionType.PlayerLeaveInteractArea);
						base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.FreeTime);
					}
					else if (base.OwningComp.FollowPartnerMgrData.GetInteractAreaStep(InteractingEntity) == 2)
					{
						base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.EnterInteractArea);
					}
				}
				else if (base.OwningComp.FsmData.IsInFsmState(BGW_FlowUtils.FollowPartnerAIFsmStateTag.Interacting))
				{
					if (InteractingEntity == Entity.Null)
					{
						base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.FreeTime);
					}
					else if (base.OwningComp.FollowPartnerMgrData.GetInteractAreaStep(InteractingEntity) == -1)
					{
						base.OwningBE.Evt_AiDisengageInteract.Invoke(EAiBreakInteractionType.PlayerLeaveInteractArea);
						base.OwningBE.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.FreeTime);
					}
				}
			}
		}

		public override void BindEventCollection()
		{
			base.BindEventCollection();
			base.OwningBE.Evt_AiFinishComeCloseToInteractActor += new Del_Actor(OnFinishComeCloseInteractActor);
			base.OwningBE.Evt_AIPathMoveComplete += new Del_AIPathMoveComplete(OnAIPathMoveComplete);
			base.OwningBGE.Evt_BGS_FollowPartnerFinishInteract += new Del_Void_Actor(OnFollowPartnerFinishInteract);
		}

		public override void UnBindEventCollection()
		{
			base.UnBindEventCollection();
			base.OwningBE.Evt_AiFinishComeCloseToInteractActor -= new Del_Actor(OnFinishComeCloseInteractActor);
			base.OwningBE.Evt_AIPathMoveComplete -= new Del_AIPathMoveComplete(OnAIPathMoveComplete);
			base.OwningBGE.Evt_BGS_FollowPartnerFinishInteract -= new Del_Void_Actor(OnFollowPartnerFinishInteract);
		}

		private void OnFollowPartnerFinishInteract(AActor InteractActor)
		{
			if (InteractingEntity != Entity.Null && InteractingEntity == ECSExtension.ToEntity(InteractActor))
			{
				InteractingEntity = Entity.Null;
				JudgeValidInteractAreaTimer = 0f;
			}
		}

		private void OnFinishComeCloseInteractActor(AActor InteractActor)
		{
		}

		private void OnAIPathMoveComplete(int MoveIdx, EPathFollowingResult Result)
		{
			if (CachedMoveIdx == MoveIdx)
			{
				base.OwningComp.BUSEventCollection?.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.PlaybackFinish);
			}
		}

		private void TriggerSeqFinishPlayback()
		{
			UEnvQuery uEnvQuery = BGW_PreloadAssetMgr.Get(base.OwningComp).TryGetCachedResourceObj<UEnvQuery>(SEQ_FINISH_PLAYBACK_EQS_PATH, ELoadResourceType.SyncLoadAndCache, EAssetPriority.Top);
			if (uEnvQuery != null)
			{
				base.OwningComp.BGSEventCollection.Evt_BGS_EQSObjRun.Invoke(uEnvQuery, base.OwningChr, EBGURunEQSObjReason.Teleport, default(FGSEQSExParam), OnEQSFinish);
			}
			else
			{
				base.OwningComp.BUSEventCollection?.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.PlaybackFinish);
			}
		}

		private void OnEQSFinish(List<FVector> Results, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
		{
			bool flag = false;
			if (Results != null && Results.Count > 0)
			{
				base.OwningComp.BUSEventCollection.Evt_TeleportMoveByTrans.Invoke(new FTransform(FQuat.Identity, Results[0]));
				base.OwningBE.Evt_BuffRemoveImmediately.Invoke(InvisibleBuffID, EBuffEffectTriggerType.None);
				base.OwningComp.BUSEventCollection.Evt_ChangeMotionMatchingState.Invoke(EState_MM.Free);
				CachedMoveIdx = BGUFuncLibAICS.BGURequestAIMoveToLocation(base.OwningChr, Results[Results.Count - 1], EAIMoveSpeedType.SPRINT, 200f, EBGUMoveAIType.None, IncludeSelfRadius: true, IncludeTargetRadius: false);
				if (CachedMoveIdx > 0)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				base.OwningComp.BUSEventCollection?.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.PlaybackFinish);
			}
		}

		private void SetCanSetTargetByHatred(bool bCanSet)
		{
			if (bCanSet)
			{
				CloseSetTargetByHatredTimer = -1f;
				base.OwningBE?.Evt_SetCanSetTargetByHatred.Invoke(P1: true);
			}
			else
			{
				CloseSetTargetByHatredTimer = CLOSE_SET_TARGET_BY_HATRED_TIME;
				base.OwningBE?.Evt_SetCanSetTargetByHatred.Invoke(P1: false);
			}
		}
	}

	private static readonly int RETURNHOME_BUFFID;

	private static readonly float NONCOMBAT_FIND_HOSTILE_DURATION;

	private BUC_AIData AIData;

	private BUC_WakeUpData WakeUpData;

	private BUC_BirthData BirthData;

	private UBUC_AIComponent AIComps;

	private IBUC_ActionRequestData ActionReqData;

	private IBUC_ChargeSkillData ChargeSkillData;

	private IBUC_SkillInstsData SkillInstsData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_ABPHelperData AnimHumanoidHelperData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_UnitHatredData UnitHatredData;

	private IBUC_ActorBasicData ActorBasicData;

	private IBUC_BattleStateData BattleStateData;

	private IBUC_GuidData GuidData;

	private IBUC_FsmData FsmData;

	private IBUC_BuffData BuffData;

	private IBUC_ConfigInfoData ConfigInfoData;

	private IBUC_AINodeData AINodeData;

	private IBUC_TickRateData TickRateData;

	private IBUC_MasterData MasterData;

	private IBUC_UnitHatredCacheData UnitHatredCacheData;

	private IBUC_PatrolData PatrolData;

	private IBUC_PassiveSkillData PassiveSkillData;

	private IBUC_BossControlData BossControlData;

	private IBUC_SkillMappingData SkillMappingData;

	private IBUC_NPCAnimData NPCAnimData;

	private IBUC_ABPHelperData ABPHelperData;

	private IBUC_ABPMotionMatchingData MMData;

	private IBUC_FollowPartnerData FollowPartnerData;

	private IBUC_GroupAIData GroupAIData;

	private IBGC_CircusControlData FamilyTreeData;

	private IBGC_FollowPartnerMgrData FollowPartnerMgrData;

	private IBGC_TeamRelationData TeamRelationData;

	private IBGC_LocalPlayerSharedData LocalPlayerSharedData;

	private IBGC_TamerData TamerData;

	private IBGC_GlobalBattleStateData GlobalBattleStateData;

	private IBIC_MovieData MovieData;

	private List<SkillScoreFilterBaseCS> SSFList = new List<SkillScoreFilterBaseCS>();

	private bool IsStandAlone = true;

	private const float SCORE_DISABLE_SKILL = -9999f;

	private List<ECanCastSkillResult> RetCodeList = new List<ECanCastSkillResult>();

	private List<int> SelectBestSkillTempList = new List<int>();

	private int HiddenFrameCounter = -1;

	private static int HIDDEN_FRAME_NUM;

	private bool DoubleCheckFlag;

	private static bool PerceptionComp_IsValid;

	private static int PerceptionComp_Offset;

	private static bool OnTargetPerceptionUpdated_IsValid;

	private static IntPtr OnTargetPerceptionUpdated_FunctionAddress;

	private static int OnTargetPerceptionUpdated_ParamsSize;

	private static bool OnTargetPerceptionUpdated_Target_IsValid;

	private static int OnTargetPerceptionUpdated_Target_Offset;

	private static bool OnTargetPerceptionUpdated_Stimulus_IsValid;

	private static int OnTargetPerceptionUpdated_Stimulus_Offset;

	private static FFieldAddress OnTargetPerceptionUpdated_Stimulus_PropertyAddress;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_AIComp:PerceptionComp")]
	private UAIPerceptionComponent PerceptionComp
	{
		get
		{
			CheckDestroyed();
			if (!PerceptionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AIComp:PerceptionComp");
				return null;
			}
			return UObjectMarshaler<UAIPerceptionComponent>.FromNative(IntPtr.Add(base.Address, PerceptionComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerceptionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AIComp:PerceptionComp");
			}
			else
			{
				UObjectMarshaler<UAIPerceptionComponent>.ToNative(IntPtr.Add(base.Address, PerceptionComp_Offset), value);
			}
		}
	}

	public override void OnAttach()
	{
		BAID_Base_NativeCallback.Ref++;
		AIData = RequireWritableData<BUC_AIData>();
		WakeUpData = RequireWritableData<BUC_WakeUpData>();
		BirthData = RequireWritableData<BUC_BirthData>();
		AIComps = RequireWritableData<UBUC_AIComponent>();
		ActionReqData = RequireReadOnlyData<IBUC_ActionRequestData, BUC_ActionRequestData>();
		ChargeSkillData = RequireReadOnlyData<IBUC_ChargeSkillData, BUC_ChargeSkillData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		AnimHumanoidHelperData = RequireReadOnlyData<IBUC_ABPHelperData, BUC_ABPHelperData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		UnitHatredData = RequireReadOnlyData<IBUC_UnitHatredData, BUC_UnitHatredData>();
		ActorBasicData = RequireReadOnlyData<IBUC_ActorBasicData, BUC_ActorBasicData>();
		BattleStateData = RequireReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		FsmData = RequireReadOnlyData<IBUC_FsmData, BUC_FsmData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		ConfigInfoData = RequireReadOnlyData<IBUC_ConfigInfoData, BUC_ConfigInfoData>();
		AINodeData = RequireReadOnlyData<IBUC_AINodeData, BUC_AINodeData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		UnitHatredCacheData = RequireReadOnlyData<IBUC_UnitHatredCacheData, BUC_UnitHatredCacheData>();
		PatrolData = RequireReadOnlyData<IBUC_PatrolData, BUC_PatrolData>();
		PassiveSkillData = RequireReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>();
		BossControlData = RequireReadOnlyData<IBUC_BossControlData, BUC_BossControlData>();
		SkillMappingData = RequireReadOnlyData<IBUC_SkillMappingData, BUC_SkillMappingData>();
		NPCAnimData = RequireReadOnlyData<IBUC_NPCAnimData, BUC_NPCAnimData>();
		ABPHelperData = RequireReadOnlyData<IBUC_ABPHelperData, BUC_ABPHelperData>();
		MMData = RequireReadOnlyData<IBUC_ABPMotionMatchingData, BUC_ABPMotionMatchingData>();
		FollowPartnerData = RequireReadOnlyData<IBUC_FollowPartnerData, b1.BUC_FollowPartnerData>();
		GroupAIData = RequireReadOnlyData<IBUC_GroupAIData, BUC_GroupAIData>();
		FamilyTreeData = RequireReadOnlyGameStateData<IBGC_CircusControlData, BGC_CircusControlData>();
		FollowPartnerMgrData = RequireReadOnlyGameStateData<IBGC_FollowPartnerMgrData, BGC_FollowPartnerMgrData>();
		TeamRelationData = RequireReadOnlyGameStateData<IBGC_TeamRelationData, BGC_TeamRelationData>();
		LocalPlayerSharedData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		TamerData = RequireReadOnlyGameStateData<IBGC_TamerData, BGC_TamerData>();
		GlobalBattleStateData = RequireReadOnlyGameStateData<IBGC_GlobalBattleStateData, BGC_GlobalBattleStateData>();
		MovieData = RequireReadonlyGameInstanceData<IBIC_MovieData, BIC_MovieData>();
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_AICastSkillWithSkillID += new Del_Void_IntCastSkill(OnAICastSkillWithSkillID);
			base.BUSEventCollection.Evt_AICastBestSkillByScore += new Del_AICastBestSkillByScore(OnAICastBestSkillByScore);
			base.BUSEventCollection.Evt_AICastBestComboSkill += new Del_AICastBestComboSkill(OnAICastBestComboSkill);
			base.BUSEventCollection.Evt_ModifySkillScore += new Del_ModifySkillScore(OnModifySkillScore);
			base.BUSEventCollection.Evt_SetEQSTarget += new Del_SetEQSTarget(OnSetEQSTarget);
			base.BUSEventCollection.Evt_SetMaxComboNum += new Del_Void_Int(OnSetMaxComboNum);
			base.BUSEventCollection.Evt_SetCurComboLength += new Del_Void_Int(OnSetCurComboLength);
			base.BUSEventCollection.Evt_SetWatchTime += new Del_Void_Float(OnSetWatchTime);
			base.BUSEventCollection.Evt_SetLastAttackTime += new Del_Void_Float(OnSetLastAttackTime);
			base.BUSEventCollection.Evt_SetLastHitActor += new Del_Void_Actor(OnSetLastHitActor);
			base.BUSEventCollection.Evt_SetBeHitTime += new Del_Void_Float(OnSetBeHitTime);
			base.BUSEventCollection.Evt_SetLastAttackerID += new Del_Void_Actor(OnSetLastAttackerID);
			base.BUSEventCollection.Evt_SetLastAtkDmgTime += new Del_Void_Float(OnSetLastAtkDmgTime);
			base.BUSEventCollection.Evt_SetGroupAISkill += new Del_SetGroupAISkill(OnSetGroupAISkill);
			base.BUSEventCollection.Evt_SetObstacleCheckResult += new Del_Void_Float(OnSetObstacleCheckResult);
			base.BUSEventCollection.Evt_SetEscapeLocation += new Del_Void_Vector(OnSetEscapeLocation);
			base.BUSEventCollection.Evt_EscapeWayChanged += new Del_Void_EscapeWay(OnEscapeWayChanged);
			base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnSkillCastSuccess);
			base.BUSEventCollection.Evt_MarkLastTargetInfoForAI += new Del_Actor(OnMarkLastTargetInfoForAI);
			base.BUSEventCollection.Evt_SetUnitWakeUpEnabled += new Del_Void_Bool(OnSetUnitWakeUpEnabled);
			base.BUSEventCollection.Evt_SetOnFightSkillID += new Del_Void_Int(OnSetOnFightSkillID);
			base.BUSEventCollection.Evt_NPCReplaceOnFightSkill += new Del_Void_IntIntIntInt(OnNPCReplaceOnFightSkillID);
			base.BUSEventCollection.Evt_SwitchFsmSolver += new Del_SwitchFsmSolver(OnSwitchFsmSolver);
			base.BUSEventCollection.Evt_ResetToDefaultFsmSolver += new b1.EventDelDefine.Del_Void(OnResetToDefaultFsmSolver);
			base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
			base.BUSEventCollection.Evt_ResetAIInfo += new b1.EventDelDefine.Del_Void(OnResetAIInfo);
			base.BUSEventCollection.Evt_OnLeaveFight += new b1.EventDelDefine.Del_Void(OnLeaveFight);
			base.BUSEventCollection.Evt_AICatchTarget += new Del_AICatchTarget(OnCatchTarget);
			base.BUSEventCollection.Evt_AISearchAndCatchTarget += new Del_AISearchAndCatchTarget(OnSearchAndCatchTarget);
			base.BUSEventCollection.Evt_AIPerceptionSetting += new Del_Void_Bool(OnAIPerceptionSetting);
			base.BUSEventCollection.Evt_SetPursuitRange += new Del_SetPursuitRange(OnSetPursuitRange);
			base.BUSEventCollection.Evt_UpdatePerceptionConfig += new b1.EventDelDefine.Del_Void(OnUpdatePerceptionConfig);
			base.BUSEventCollection.Evt_SetAIPerceptionConfig += new Del_AIPerceptionConfig(OnSetAIRangeConfig);
			base.BUSEventCollection.Evt_AIPauseBT += new Del_Void_Bool(OnAIPauseBT);
			base.BUSEventCollection.Evt_SwitchBehaviourTree += new Del_Void_BoolString(OnSwitchBehaviourTree);
			base.BUSEventCollection.Evt_TryRunDefaultBT += new b1.EventDelDefine.Del_Void(OnTryRunDefaultBT);
			base.BUSEventCollection.Evt_SetBT += new Del_SetBT(SetBT);
			base.BUSEventCollection.Evt_EnableCanSetBT += new Del_Void_Bool(OnEnableCanSetBT);
			base.BUSEventCollection.Evt_UpdateFsmSolver += new Del_Void_Float(OnUpdateFsmSolver);
			base.BUSEventCollection.Evt_OnFSMStateEnter += new Del_Void_FGameplayTag(OnFsmStateEnter);
			base.BUSEventCollection.Evt_OnFSMStateExit += new Del_Void_FGameplayTag(OnFsmStateExit);
			base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);
			base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnSurpriseSkill);
			base.BUSEventCollection.Evt_NotifyPlayBornAnim += new Del_Void_Bool(OnNotifyPlayBornAnim);
			base.BUSEventCollection.EVt_NotifyAIActionFinish += new Del_NotifyAIActionFinish(OnNotifyAIActionFinish);
			base.BUSEventCollection.Evt_NotifyUnitReturnHome += new Del_Void_Bool(OnNotifyUnitReturnHome);
			base.BUSEventCollection.Evt_NotifyUnitTriggerWakeupActivated += new b1.EventDelDefine.Del_Void(OnNotifyUnitTriggerWakeupActivated);
		}
	}

	private void OnNotifyUnitReturnHome(bool NeedCheckCanForceLeaveBattle)
	{
		if (NeedCheckCanForceLeaveBattle)
		{
			if (BGUFuncLibAICS.BGUCheckCanTriggerForceReturnHome(GetActorResID(), ((BGUCharacterCS)GetOwner()).GetFinalBattleInfoExtendID(), GuidData.GetFinalGuid(), AIData, in GroupAIData, in FollowPartnerData, in GlobalBattleStateData, in TamerData))
			{
				AIData.FsmContext.bNeedReturnHome = true;
			}
		}
		else
		{
			AIData.FsmContext.bNeedReturnHome = true;
		}
	}

	private void OnNotifyUnitTriggerWakeupActivated()
	{
		AIData.FsmContext.bCanTriggerWakeupActivated = true;
	}

	public override void PreBeginPlay()
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		AIData.IsAI = true;
		if (bGUCharacterCS != null)
		{
			AIData.IsAI = bGUCharacterCS.GetController() is ABGUAIController;
		}
		IsStandAlone = UGSE_EngineFuncLib.IsStandAlone(Owner.World);
		AIData.Init(Owner);
		switch (AIData.OriginFsmSolverType)
		{
		case EFsmSolverType.Normal:
			AIData.CurrentUseSolver = new NormalAIFsmSolver();
			break;
		case EFsmSolverType.AssistantPartner:
			AIData.CurrentUseSolver = new AssistantPartnerFsmSolver();
			break;
		case EFsmSolverType.FriendlyBattleNpc:
			AIData.CurrentUseSolver = new FriendlyBattleNpcAIFsmSolver();
			break;
		case EFsmSolverType.SummonAi:
			AIData.CurrentUseSolver = new SummonAIFsmSolver();
			break;
		default:
			AIData.CurrentUseSolver = new NormalAIFsmSolver();
			break;
		}
		switch (ConfigInfoData.NeutralAnimalType)
		{
		case ENeutralAnimalType.Battle:
			AIData.CurrentUseSolver = new NeutralAnimalBattleAIFsmSolver();
			break;
		case ENeutralAnimalType.Escape:
			AIData.CurrentUseSolver = new NeutralAnimalEscapeAIFsmSolver();
			break;
		}
		AIData.OriginFsmSolverType = AIData.CurrentUseSolver?.FsmSolverType ?? EFsmSolverType.Normal;
		AIData.CurrentUseSolver?.Init(this, bGUCharacterCS, base.BUSEventCollection, base.BGSEventCollection);
		AIData.CurrentUseSolver?.BindEventCollection();
		SSFList.Add(new ComboSSF());
		PerceptionComp = AIComps.PerceptionComp;
		if (PerceptionComp != null)
		{
			OnUpdatePerceptionConfig();
			OnResetAIInfo();
		}
		WakeUpData.bNotFirstTimeWakeUp = false;
		WakeUpData.DisabledWakeUp = false;
		if (WakeUpData.SurpriseSkillID.Count > 0)
		{
			WakeUpData.CanCastSurpriseSkill = true;
		}
		AIData.AlwaysInPursuitRange = GlobalBattleStateData.IsBossRoomMonster(GuidData.GetFinalGuid());
		AIData.FsmContext.bCanTriggerWakeupActivated = false;
	}

	public override void OnBeginPlay()
	{
		base.BUSEventCollection.Evt_SetSummonStateBehaviorTree.Invoke(ESummonBehaviorState.Default, AIData.ConfigBT);
		FUStUnitIntelligenceInfoDesc unitIntelligenceInfoDesc = BGW_GameDB.GetUnitIntelligenceInfoDesc(GetActorResID());
		if (unitIntelligenceInfoDesc != null && unitIntelligenceInfoDesc.IsDefaultRunBT == EGSYesNo.Yes)
		{
			OnTryRunDefaultBT();
		}
		if (PerceptionComp != null)
		{
			PerceptionComp.OnTargetPerceptionUpdated.Bind(this, B1GlobalFNames.OnTargetPerceptionUpdated);
		}
	}

	public override void LateBeginPlay()
	{
		if (BirthData.UnitSpawnInfo != null)
		{
			FUnitSpawnInfo unitSpawnInfo = BirthData.UnitSpawnInfo;
			APawn firstLocalPlayerPawn = LocalPlayerSharedData.FirstLocalPlayerPawn;
			if (unitSpawnInfo.bCatchPlayer)
			{
				OnCatchTarget(firstLocalPlayerPawn, ETargetSourceType.Target_BirthCatchPlayer);
			}
			if (unitSpawnInfo.bFacePlayer)
			{
				FRotator newRotation = MathLib.FindLookAtRotation(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), BGUFuncLibActorTransformCS.BGUGetActorLocation(firstLocalPlayerPawn));
				newRotation.Roll = 0f;
				newRotation.Pitch = 0f;
				BGUFuncLibActorTransformCS.BGUSetActorRotation(Owner, newRotation, bTeleportPhysics: false);
			}
			if (!string.IsNullOrEmpty(unitSpawnInfo.SpawnMasterGuid))
			{
				BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(Owner, unitSpawnInfo.SpawnMasterGuid) as BGUCharacterCS;
				if (bGUCharacterCS != null)
				{
					base.BUSEventCollection.Evt_SetMaster.Invoke(bGUCharacterCS);
					if (unitSpawnInfo.bSyncMasterTarget)
					{
						AActor lockTargetActor = ((IBUC_TargetInfoData)BGU_DataUtil.GetReadOnlyData<BUC_TargetInfoData>(bGUCharacterCS)).GetTargetInfo().LockTargetActor;
						if (lockTargetActor != null)
						{
							OnCatchTarget(lockTargetActor, ETargetSourceType.Target_BirthCatchMasterTarget);
						}
					}
				}
				BGUCollectionBase bGUCollectionBase = BGU_DataUtil.GetActorByGuid(Owner, unitSpawnInfo.SpawnMasterGuid) as BGUCollectionBase;
				if (bGUCollectionBase != null)
				{
					BUS_EventCollectionCS.Get(bGUCollectionBase).Evt_SetCollectionMaster.Invoke(GetOwner());
				}
			}
			foreach (int item in unitSpawnInfo.BirthBuff)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(item, Owner, Owner, 0f, EBuffSourceType.SpawnInfoBirth);
			}
			foreach (FName actorTag in unitSpawnInfo.ActorTags)
			{
				Owner.Tags.Add(actorTag);
			}
			if (BirthData.UnitSpawnInfo.SpawnMontage != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, BirthData.UnitSpawnInfo.SpawnMontage, FName.None, EMontageBindReason.Born);
				OnNotifyPlayBornAnim(HasPlayBornAnim: true);
			}
		}
		if (FamilyTreeData == null)
		{
			return;
		}
		CircusMember circusMember = FamilyTreeData.GetCircusMember(GuidData.GetFinalGuid());
		if (circusMember != null && circusMember.Socket != FName.None && circusMember.Parent != null)
		{
			BGUCharacterCS bGUCharacterCS2 = BGU_DataUtil.GetActorByGuid(Owner, circusMember.Parent.ActorGuid) as BGUCharacterCS;
			if (bGUCharacterCS2 != null)
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS2).Evt_SetHitMoveIgnoreActor.Invoke(GetOwner(), NeedIgnore: true);
				base.BUSEventCollection.Evt_SetHitMoveIgnoreActor.Invoke(bGUCharacterCS2, NeedIgnore: true);
				GetOwner().AttachToComponent(bGUCharacterCS2.Mesh, circusMember.Socket, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantMove);
				base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 6, 0u, 0u, bSetDefaultProperty: false, "AIComp");
			}
		}
	}

	private void OnSetAIRangeConfig(BGWDataAsset_AIPerceptionConfig AIPerceptionConfig)
	{
		if (!(PerceptionComp == null))
		{
			AIFuncLib.SetAISenseConfig(PerceptionComp.Address, AIPerceptionConfig.HearRange, AIPerceptionConfig.SightRange, AIPerceptionConfig.LoseSightRange, AIPerceptionConfig.VisionAngleDegrees, AIPerceptionConfig.ASRangeFromLastSeenLoc, AIPerceptionConfig.IsSightDominantSense, out var _, out var _);
			PerceptionSetEnable(PerceptionComp, bEnable: true);
		}
	}

	private void OnUpdatePerceptionConfig()
	{
		if (!(PerceptionComp == null))
		{
			AIFuncLib.SetAISenseConfig(PerceptionComp.Address, AIData.HearRange, AIData.SightRange, AIData.SightRange * 2f, AIData.VisionAngleDegrees, AIData.SightRange * 2f, IsSightDominantSense: true, out var IsHearingSet, out var IsSightSet);
			if (!IsHearingSet)
			{
				SinglePerceptionSetEnable(PerceptionComp, IsHearing: true, bEnable: false);
			}
			if (!IsSightSet)
			{
				SinglePerceptionSetEnable(PerceptionComp, IsHearing: false, bEnable: false);
			}
			if (AIData.UnitAIAttackType == EUnitAIAttackType.PassiveAttack)
			{
				PerceptionSetEnable(PerceptionComp, bEnable: false);
			}
			if (ActorBasicData.ActorType == BGU_ActorType.CharacterPlayer)
			{
				PerceptionSetEnable(PerceptionComp, bEnable: false);
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		AIData.CurrentUseSolver?.UnBindEventCollection();
		AIData.CurrentUseSolver?.Destory();
		AIData.CurrentUseSolver = null;
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!AIData.IsAI)
		{
			return;
		}
		if (HiddenFrameCounter >= 0)
		{
			if (HiddenFrameCounter <= 0)
			{
				Owner.SetActorHiddenInGame(bNewHidden: false);
				if (!DoubleCheckFlag && FsmData.IsInFsmState(BGW_FlowUtils.NormalAIFsmStateTag.AINonCombatBorn))
				{
					base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NormalAIFsmEventTag.AINonCombatFinishBorn);
				}
			}
			else if (!Owner.Hidden)
			{
				Owner.SetActorHiddenInGame(bNewHidden: true);
			}
			HiddenFrameCounter--;
		}
		if (HiddenFrameCounter <= 0)
		{
			UpdateForIntoBattle();
		}
		UpdateChargeSkillForMove();
		if (BattleStateData.IsUnitInBattle())
		{
			UpdateForSkillModifyScoreInfo();
		}
		UpdateForAIInfoDebug();
		if (AIData.PendingOnFightSkillID != -1)
		{
			if (!AnimHumanoidHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.SkillCastTimeRange, out var OutCurveValue))
			{
				TryCastOnFightSkill(AIData.PendingOnFightSkillID);
				AIData.PendingOnFightSkillID = -1;
			}
			else if (FMath.IsNearlyEqual(OutCurveValue, 1f))
			{
				TryCastOnFightSkill(AIData.PendingOnFightSkillID);
				AIData.PendingOnFightSkillID = -1;
			}
		}
	}

	private void SinglePerceptionSetEnable(UAIPerceptionComponent PerceptionComp, bool IsHearing, bool bEnable)
	{
		AIFuncLib.SinglePerceptionSetEnable(PerceptionComp.Address, IsHearing, bEnable);
	}

	private void PerceptionSetEnable(UAIPerceptionComponent PerceptionComp, bool bEnable)
	{
		SinglePerceptionSetEnable(PerceptionComp, IsHearing: true, bEnable);
		SinglePerceptionSetEnable(PerceptionComp, IsHearing: false, bEnable);
		if (!bEnable)
		{
			AIFuncLib.SetPerceptionForgetAll(PerceptionComp.Address);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_AIComp:OnTargetPerceptionUpdated")]
	private void OnTargetPerceptionUpdated(AActor Target, FAIStimulus Stimulus)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetAIStimulusWasSuccessfullySensed(Stimulus) || GetOwner() == null || AIData.StopPerception || TargetInfoData.GetTargetInfo().LockTargetActor != null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		BGUCharacterCS bGUCharacterCS2 = Target as BGUCharacterCS;
		if (bGUCharacterCS != null && bGUCharacterCS2 != null && !UnitStateData.HasState(EBGUUnitState.Dead) && !SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) && !(bGUCharacterCS2 == bGUCharacterCS) && bGUCharacterCS2.GetTeamIDInCS() != 0 && bGUCharacterCS.GetTeamIDInCS() != 0 && BGUFunctionLibraryCS.BGUIsEnemyTeam(bGUCharacterCS, bGUCharacterCS2))
		{
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing))
			{
				base.BUSEventCollection.Evt_SetPendingCatchTargetInASS.Invoke(Target);
			}
			else
			{
				OnCatchTarget(bGUCharacterCS2, ETargetSourceType.Target_AIPerception);
			}
		}
	}

	private void UpdateChargeSkillForMove()
	{
		AActor owner = GetOwner();
		if (owner == null || owner.IsPendingKill)
		{
			return;
		}
		FUStChargeSkillSDesc chargeSkillSDesc = BGW_GameDB.GetChargeSkillSDesc(ChargeSkillData.CurrentChargeSkillID, owner);
		if (ChargeSkillData.CurrentChargeSkillID <= 0 || chargeSkillSDesc == null)
		{
			return;
		}
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(chargeSkillSDesc.EndSkillID);
		if (chargeSkillSDesc.EndSkillID <= 0 || skillAIDesc == null || !ChargeSkillData.IsCastingChargeSkill || (ChargeSkillData.ChargeSkillStage != EChargeSkillStage.Begin && ChargeSkillData.ChargeSkillStage != EChargeSkillStage.Loop))
		{
			return;
		}
		bool flag = true;
		UnitLockTargetInfo skillBaseTarget = TargetInfoData.GetSkillBaseTarget();
		AActor lockTargetActor = skillBaseTarget.LockTargetActor;
		if ((lockTargetActor != null && !lockTargetActor.IsPendingKill) || skillBaseTarget.LockTargetType == ELockTargetType.Point)
		{
			if (UnitStateData.HasState(EBGUUnitState.Attacking) && UnitStateData.HasState(EBGUUnitState.AttackMoving))
			{
				if (MMData != null && !MMData.bUseLMAnim)
				{
					base.BUSEventCollection.Evt_ChangeMotionMatchingState.Invoke(MMData.DefaultMMState);
				}
				if (!BGUFunctionLibraryCS.BGUIsMoveActive(owner, AIData.ChargeSkillMoveIdx))
				{
					if (lockTargetActor != null)
					{
						AIData.ChargeSkillMoveIdx = BGUFuncLibAICS.BGURequestAIMoveToTarget(owner, skillBaseTarget, (EAIMoveSpeedType)chargeSkillSDesc.ChargeMoveSpeedRate, 0f, EBGUMoveAIType.KeepFacingTarget, IncludeSelfRadius: true, IncludeTargetRadius: false);
					}
					else
					{
						AIData.ChargeSkillMoveIdx = BGUFuncLibAICS.BGURequestAIMoveToLocation(owner, skillBaseTarget.LockPointLocation, (EAIMoveSpeedType)chargeSkillSDesc.ChargeMoveSpeedRate, 0f, EBGUMoveAIType.KeepFacingTarget, IncludeSelfRadius: true, IncludeTargetRadius: false);
					}
				}
			}
			FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
			FVector v2 = BGUFuncLibAICS.BGUAIGetTargetInfoRealLockPoint(skillBaseTarget);
			if (FVector.Dist2D(v, v2) > skillAIDesc.PreferRangeMax)
			{
				flag = false;
			}
		}
		if (flag)
		{
			base.BUSEventCollection.Evt_TriggerNextChargeSkillStage.Invoke(P1: false);
		}
	}

	private void UpdateForSkillModifyScoreInfo()
	{
		if (!(GetOwner() == null) && !UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			ResetModifyScoreInfoDic();
		}
	}

	private void UpdateForIntoBattle()
	{
		if (AIData.CurrentUseSolver == null)
		{
			return;
		}
		bool flag = false;
		if (FsmData.IsInFsmState(BGW_FlowUtils.NormalAIFsmStateTag.AINonCombatIdle))
		{
			flag = true;
		}
		else if (FsmData.IsInFsmState(BGW_FlowUtils.FollowPartnerAIFsmStateTag.NonCombat))
		{
			flag = true;
		}
		else if (FsmData.IsInFsmState(BGW_FlowUtils.NeutralAnimalAIFsmStateTag.Patrol))
		{
			flag = true;
		}
		if (flag)
		{
			AActor lockTargetActor = TargetInfoData.GetTargetInfo().LockTargetActor;
			if (lockTargetActor != null)
			{
				base.BUSEventCollection.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_HASTARGET);
				base.BUSEventCollection.Evt_PerceptionFindTarget.Invoke(lockTargetActor);
			}
		}
	}

	private void UpdateForAIInfoDebug()
	{
		AActor owner = GetOwner();
		if (owner == null || base.BUSEventCollection == null || FsmData == null || TargetInfoData == null)
		{
			return;
		}
		if (DebugConfig.DebugPhaseCSG)
		{
			FsmInstancePhaseComp phaseComp = FsmData.GetPhaseComp();
			if (phaseComp == null)
			{
				base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("DebugPhaseCSG", "未配置转阶段", 1);
			}
			else
			{
				List<string> phaseDebugInfo = FsmData.GetPhaseDebugInfo();
				if (phaseDebugInfo.Any() && !string.IsNullOrEmpty(phaseDebugInfo[0]))
				{
					int num = 0;
					foreach (string item in phaseDebugInfo)
					{
						base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("DebugPhaseCSG", "当前的阶段为 " + item, num++);
						if (num == 2)
						{
							break;
						}
					}
					base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("DebugPhaseCSG", UnitStateData.HasState(EBGUUnitState.PhasePerformance) ? "处于表演阶段" : "未处于表演阶段", num++);
					base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("DebugPhaseCSG", "进入表演状态的原因：" + phaseComp.LastEnterPhasePerformanceReason, num++);
					base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("DebugPhaseCSG", "退出表演状态的原因：" + phaseComp.LastLeavePhasePerformanceReason, num++);
				}
				else
				{
					base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("DebugPhaseCSG", "当前没有转阶段状态", 1);
				}
			}
		}
		if (DebugConfig.AIInfo)
		{
			base.BUSEventCollection.Evt_UpdateDebugUILamp.Invoke("AIInfo", TickRateData.bIsOptimizing ? B1GlobalFSlateColor.Green : B1GlobalFSlateColor.Yellow);
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("AIInfo", "当前URO优化状态", TickRateData.bIsOptimizing.ToString());
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("AIInfo", "当前FsmSolver是", AIData.CurrentUseSolver.FsmSolverType.ToString());
			string text;
			if (FsmData.bFsmInstancePaused)
			{
				text = "FSM状态已暂停更新";
			}
			else
			{
				List<FGameplayTag> currentStates = FsmData.GetCurrentStates();
				text = ((currentStates.Count > 0) ? currentStates[currentStates.Count - 1].ToString() : string.Empty);
				foreach (FGameplayTag item2 in currentStates)
				{
					string text2 = item2.ToString();
					if (text2.Length > text.Length)
					{
						text = text2;
					}
				}
			}
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("AIInfo", "当前Fsm状态是", text);
			string value = ((AINodeData != null) ? AINodeData.ActionType.ToString() : "");
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("AIInfo", "当前执行的AIActionNode是", value);
		}
		if (DebugConfig.TeamInfo && owner is BGUCharacterCS bGUCharacterCS)
		{
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("TeamInfo", $"当前TeamID【C#】：{bGUCharacterCS.GetTeamIDInCS()}");
		}
		if (DebugConfig.TargetInfo)
		{
			string targetName = string.Empty;
			ETargetSourceType sourceType = ETargetSourceType.None;
			UnitLockTargetInfo unitLockTargetInfo = TargetInfoData?.GetTargetInfo();
			if (unitLockTargetInfo != null)
			{
				AActor lockTargetActor = unitLockTargetInfo.LockTargetActor;
				if (lockTargetActor != null)
				{
					sourceType = unitLockTargetInfo.SourceType;
					targetName = lockTargetActor.GetName().ConvertLongGuid2DisplayGuid();
				}
			}
			SetTargetDebugUIInfo("当前的AI目标是：", targetName, sourceType, 0);
			string targetName2 = string.Empty;
			ETargetSourceType sourceType2 = ETargetSourceType.None;
			UnitLockTargetInfo unitLockTargetInfo2 = TargetInfoData?.GetAOTarget();
			if (unitLockTargetInfo2 != null)
			{
				AActor lockTargetActor2 = unitLockTargetInfo2.LockTargetActor;
				if (lockTargetActor2 != null)
				{
					sourceType2 = unitLockTargetInfo2.SourceType;
					targetName2 = lockTargetActor2.GetName().ConvertLongGuid2DisplayGuid();
				}
			}
			SetTargetDebugUIInfo("当前的AO目标是：", targetName2, sourceType2, 1);
			string targetName3 = string.Empty;
			ETargetSourceType sourceType3 = ETargetSourceType.None;
			UnitLockTargetInfo unitLockTargetInfo3 = TargetInfoData?.GetSkillBaseTarget();
			if (unitLockTargetInfo3 != null)
			{
				AActor lockTargetActor3 = unitLockTargetInfo3.LockTargetActor;
				if (lockTargetActor3 != null)
				{
					sourceType3 = unitLockTargetInfo3.SourceType;
					targetName3 = lockTargetActor3.GetName().ConvertLongGuid2DisplayGuid();
				}
			}
			SetTargetDebugUIInfo("当前的SkillBase目标是：", targetName3, sourceType3, 2);
			string targetName4 = string.Empty;
			ETargetSourceType sourceType4 = ETargetSourceType.None;
			UnitLockTargetInfo unitLockTargetInfo4 = TargetInfoData?.GetComboTarget();
			if (unitLockTargetInfo4 != null)
			{
				AActor lockTargetActor4 = unitLockTargetInfo4.LockTargetActor;
				if (lockTargetActor4 != null)
				{
					sourceType4 = unitLockTargetInfo4.SourceType;
					targetName4 = lockTargetActor4.GetName().ConvertLongGuid2DisplayGuid();
				}
			}
			SetTargetDebugUIInfo("当前的Combo目标是：", targetName4, sourceType4, 3);
			string targetName5 = string.Empty;
			ETargetSourceType sourceType5 = ETargetSourceType.None;
			UnitLockTargetInfo unitLockTargetInfo5 = TargetInfoData?.GetMoveToTarget();
			if (unitLockTargetInfo5 != null)
			{
				AActor lockTargetActor5 = unitLockTargetInfo5.LockTargetActor;
				if (lockTargetActor5 != null)
				{
					sourceType5 = unitLockTargetInfo5.SourceType;
					targetName5 = lockTargetActor5.GetName().ConvertLongGuid2DisplayGuid();
				}
			}
			SetTargetDebugUIInfo("当前的MoveTo目标是：", targetName5, sourceType5, 4);
		}
		if (!DebugConfig.HatredInfo)
		{
			return;
		}
		GSBindList<UnitHatredTargetInfo> hatredTargetInfoList = UnitHatredData.GetHatredTargetInfoList();
		int count = hatredTargetInfoList.Count;
		int count2 = UnitHatredData.GetPlayerHatredEntityList().Count;
		base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("HatredInfo", $"当前有：{count} 个仇恨单位，其中玩家有：{count2} 个");
		for (int i = 1; i <= 4; i++)
		{
			if (i <= count)
			{
				UnitHatredTargetInfo unitHatredTargetInfo = hatredTargetInfoList[i - 1];
				if (unitHatredTargetInfo != null)
				{
					base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("HatredInfo", $"列表第{i}个，当前仇恨分：{unitHatredTargetInfo.HatredValueFinal}，是：{unitHatredTargetInfo.HatredTargetActor.GetName().ConvertLongGuid2DisplayGuid()}", i);
					continue;
				}
			}
			base.BUSEventCollection.Evt_HideDebugUIInfo.Invoke("HatredInfo", i);
		}
	}

	private void SetTargetDebugUIInfo(string Title, string TargetName, ETargetSourceType SourceType, int ShowColum)
	{
		if (!TargetName.Equals(string.Empty) && !TargetName.Equals(""))
		{
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("TargetInfo", Title + TargetName + ", 目标来源是：" + ConvertTargetSourTypeEnumToStr(SourceType), ShowColum);
		}
		else
		{
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("TargetInfo", Title + "空", ShowColum);
		}
	}

	private string ConvertTargetSourTypeEnumToStr(ETargetSourceType SourceType)
	{
		return SourceType switch
		{
			ETargetSourceType.SwitchTarget_TransUnit => "切换目标（变身）", 
			ETargetSourceType.SwitchTarget_PhantomRush => "切换目标（聚形散气）【附带嘲讽效果】", 
			ETargetSourceType.Target_AIPerception => "AI感知", 
			ETargetSourceType.Target_ByTaunter => "嘲讽列表第一个", 
			ETargetSourceType.Target_ByHatred => "仇恨列表", 
			ETargetSourceType.AO_AORangeFind => "AimOffset范围搜索", 
			ETargetSourceType.AO_SetByTarget => "当前目标", 
			ETargetSourceType.Combo_NormalUse => "Combo节点设置", 
			ETargetSourceType.SkillBase_NormalUse => "Skill表设置", 
			ETargetSourceType.SkillBase_SetByAI => "通过LockTarget设置", 
			ETargetSourceType.Target_AwakePartner => "伙伴唤醒", 
			ETargetSourceType.Target_SelectByEQS => "通过EQS", 
			ETargetSourceType.Target_CQGAssignTarget => "CQG指定目标", 
			ETargetSourceType.Target_SeqAssignTarget => "Seq指定目标", 
			ETargetSourceType.Target_SwitchTaget => "目标切换", 
			ETargetSourceType.Target_RangeSearch => "范围搜寻", 
			ETargetSourceType.Target_AutoTest => "自动测试", 
			ETargetSourceType.Target_CPGAssignTarget => "CPG指定目标", 
			ETargetSourceType.Target_CMGAssignTarget => "CMG指定目标", 
			ETargetSourceType.Target_BattleTriggerBoxAssignTarget => "战斗盒(BattleTriggerBox)指定目标", 
			ETargetSourceType.Target_ForceFightAssignTarget => "强制战斗盒(ForceFight)指定目标", 
			ETargetSourceType.Target_ActionBoxAssignTarget => "行动盒指定目标", 
			ETargetSourceType.Target_TeamBoxAssignTarget => "队伍盒指定目标", 
			ETargetSourceType.Target_AnimSyncAssignTarget => "动画同步指定目标", 
			ETargetSourceType.Target_AssociaAssignTarget => "协战单位指定目标", 
			ETargetSourceType.Target_BirthCatchPlayer => "出生指定玩家为目标", 
			ETargetSourceType.Target_BirthCatchMasterTarget => "出生以Master目标为目标", 
			ETargetSourceType.Target_BirthCatchSummonerTarget => "出生以召唤者目标为目标", 
			ETargetSourceType.Target_AssignPlayerAsTarget => "直接指定玩家为目标", 
			ETargetSourceType.Target_MonsterTransAssignTarget => "转阶段指定目标", 
			ETargetSourceType.Target_BeAttackedAssignAttackerAsTarget => "受击指定攻击者为目标", 
			ETargetSourceType.Target_SummonAssignMasterTarget => "召唤物指定召唤者目标为目标", 
			ETargetSourceType.Target_FamilyAssignTarget => "Family唤醒", 
			ETargetSourceType.Target_AIStrongPerception => "AI强效感知", 
			ETargetSourceType.AO_SetBySkillBaseTarget => "通过SkillBaseTarget设置", 
			_ => "新增类型：" + SourceType.ToString() + "， 未定义中文描述", 
		};
	}

	private void OnCatchTarget(AActor TargetActor, ETargetSourceType SourceType, bool SkipWakeUp = false)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (!(aCharacter != null) || aCharacter.IsPendingKill || FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_LIFE_DEAD) || FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_LIFE_RETURNHOME) || (BossControlData != null && !BossControlData.CanBossCatchTarget(TargetActor, SourceType)) || BGW_GameDB.GetUnitCommDesc(GetActorResID()) == null)
		{
			return;
		}
		ABGUCharacter targetActor = TargetActor as ABGUCharacter;
		if (!BGUFuncLibAICS.JudgeActorCanBeAITarget(aCharacter, targetActor, TeamRelationData, UnitHatredCacheData))
		{
			return;
		}
		OnTryRunDefaultBT();
		base.BUSEventCollection.Evt_TryRunDefaultCBG.Invoke();
		AActor lockTargetActor = TargetInfoData.GetTargetInfo().LockTargetActor;
		UnitLockTargetInfo unitLockTargetInfo = BGUFuncLibAICS.BGUAIGetAutoLockTargetInfo(targetActor, SourceType);
		if (unitLockTargetInfo != null)
		{
			BGUFunctionLibraryCS.BGUSetTargetInfo(IsOnline(), Owner, unitLockTargetInfo);
			if (lockTargetActor == null)
			{
				AIData.Memory.MyPosWhenEnterBattle = BGUFuncLibActorTransformCS.BGUGetActorTransform(aCharacter);
			}
			if (SkipWakeUp)
			{
				WakeUpData.DisabledWakeUp = true;
			}
		}
	}

	private void OnSearchAndCatchTarget(AActor SearchBaseActor, int Radius, int TargetFilter, int SecondTargetFilter, EAISearchTargetWay AISearchTargetWay)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		List<int> list = new List<int> { Radius };
		FVector baseLoc = BGUFuncLibActorTransformCS.BGUGetActorLocation(SearchBaseActor);
		IList<int> Prams = list;
		BGUFuncLibSelectTargetsCS.BGUSelectTargetsInShape(this, out var OutActors, SearchBaseActor, baseLoc, ERangeType.Circle, -1, TargetFilter, SecondTargetFilter, 0, in Prams);
		if (OutActors == null || OutActors.Count <= 0)
		{
			return;
		}
		AActor aActor = null;
		float num = -1f;
		FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
		int num2 = int.MinValue;
		foreach (AActor item in OutActors)
		{
			if (!BGUFuncLibAICS.JudgeActorCanBeAITarget(owner, item, TeamRelationData, UnitHatredCacheData))
			{
				continue;
			}
			FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(item);
			float num3 = FVector.Distance(v, v2);
			switch (AISearchTargetWay)
			{
			case EAISearchTargetWay.FindTargetNearest:
				if (num == -1f || num3 <= num)
				{
					num = num3;
					aActor = item;
				}
				break;
			case EAISearchTargetWay.FindTargetFurthest:
				if (num == -1f || num3 >= num)
				{
					num = num3;
					aActor = item;
				}
				break;
			case EAISearchTargetWay.FindTargetByHatred:
			{
				int num4 = EvaluateHatredValue(item);
				if (num4 > num2)
				{
					num2 = num4;
					aActor = item;
				}
				break;
			}
			}
		}
		if (!(aActor != null))
		{
			return;
		}
		if (AISearchTargetWay == EAISearchTargetWay.FindTargetByHatred)
		{
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc((aActor as BGUCharacterCS).GetFinalBattleInfoExtendID());
			BGUCharacterCS bGUCharacterCS = TargetInfoData.GetTargetInfo().LockTargetActor as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc2 = BGW_GameDB.GetUnitBattleInfoExtendDesc(bGUCharacterCS.GetFinalBattleInfoExtendID());
				if (unitBattleInfoExtendDesc != null && unitBattleInfoExtendDesc2 != null && unitBattleInfoExtendDesc.QualityType != unitBattleInfoExtendDesc2.QualityType)
				{
					OnCatchTarget(aActor, ETargetSourceType.Target_RangeSearch, SkipWakeUp: true);
				}
			}
			else
			{
				OnCatchTarget(aActor, ETargetSourceType.Target_RangeSearch, SkipWakeUp: true);
			}
		}
		else
		{
			OnCatchTarget(aActor, ETargetSourceType.Target_RangeSearch, SkipWakeUp: true);
		}
	}

	private int EvaluateHatredValue(AActor CurActor)
	{
		BGUCharacterCS bGUCharacterCS = CurActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return -1;
		}
		int result = -1;
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = UnitHatredCacheData.UnitBattleInfoExtendDesc;
		BGWDataAsset_AIHatredConfig aIHatredConfigDataAsset = BGW_PreloadAssetMgr.Get(CurActor).AIHatredConfigDataAsset;
		if (unitBattleInfoExtendDesc != null && aIHatredConfigDataAsset != null)
		{
			result = aIHatredConfigDataAsset.UnitBaseHatreds[(int)unitBattleInfoExtendDesc.QualityType];
			int targetedCount = TargetInfoData.GetTargetedCount();
			if (targetedCount > 0)
			{
				result /= targetedCount + 1;
			}
			float distanceTo = bGUCharacterCS.GetDistanceTo(GetOwner());
			result -= (int)(distanceTo * aIHatredConfigDataAsset.DistanceWeightMultiplier);
		}
		return result;
	}

	private void OnAIPerceptionSetting(bool bEnable)
	{
		if (GetOwner() == null || !(PerceptionComp != null))
		{
			return;
		}
		if (bEnable)
		{
			if (AIData.UnitAIAttackType == EUnitAIAttackType.ActiveAttack)
			{
				PerceptionSetEnable(PerceptionComp, bEnable: true);
			}
		}
		else
		{
			PerceptionSetEnable(PerceptionComp, bEnable: false);
		}
	}

	private void OnResetAIInfo()
	{
		AActor owner = GetOwner();
		if (owner != null && !owner.IsPendingKill)
		{
			if (PerceptionComp != null)
			{
				AIFuncLib.SetPerceptionForgetAll(PerceptionComp.Address);
			}
			AIData.ResetPursuitRange();
			AIData.Timers.Init();
			AIData.ComboInfo.Init(GetActorResID());
			OnSetWatchTime(FMath.FRandRange(AIData.AIWatchTimeMin, AIData.AIWatchTimeMax));
			WakeUpData.HasTriggerWakeUp = false;
		}
	}

	private void OnSkillCastSuccess(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		AIData.ComboInfo.CurComboHasCastSkillList.Add(MappingSkillID);
	}

	private void OnAICastSkillWithSkillID(int SkillID, ECastSkillSourceType InSourceType)
	{
		if (SkillID > 0)
		{
			base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(SkillID, InSourceType));
		}
	}

	private void OnAICastBestSkillByScore(List<FOneCBGCastSkillInfoCS> SkillInfoList, bool IsGetTopRandomSkill, int TopRandomSkillPercent, bool NeedTryCastAllSkillUntilSuccess)
	{
		UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
		if (targetInfo == null || !(targetInfo.LockTargetActor != null))
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(targetInfo.LockTargetActor);
		base.BUSEventCollection.Evt_SetSkillBaseTarget.Invoke(targetInfo.LockTargetActor, fVector, ETargetSourceType.SkillBase_SetByAI, "");
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = Owner.GetName().ConvertLongGuid2DisplayGuid();
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + text + "</><action>==================================尝试算分释放技能开始==================================</>");
			string text2 = "";
			foreach (FOneCBGCastSkillInfoCS SkillInfo in SkillInfoList)
			{
				text2 += $"{SkillInfo.SkillID};";
			}
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + text + "</><action>本次释放技能池里存在技能：</><effect>" + text2 + "</>");
		}
		List<ECanCastSkillResult> canCastComboSkillListForScore = GetCanCastComboSkillListForScore(fVector, UseComboCondition: false, UsePursuitAnyWhere: false, ref SkillInfoList);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text3 = Owner.GetName().ConvertLongGuid2DisplayGuid();
			string text4 = "";
			foreach (ECanCastSkillResult item in canCastComboSkillListForScore)
			{
				text4 += BGUFuncLibAICS.GetAICastComboSkillFailedResultString(item);
				text4 += "; ";
			}
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + text3 + "</><action>筛选完成！！！筛选失败的原因有: </><effect>" + text4 + "</>");
			if (SkillInfoList != null && SkillInfoList.Count > 0)
			{
				string text5 = "";
				foreach (FOneCBGCastSkillInfoCS SkillInfo2 in SkillInfoList)
				{
					text5 += $"{SkillInfo2};";
				}
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + text3 + "</><action>还剩下：</><effect>" + text5 + "</><action>尝试算分释放</>");
			}
			else
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + text3 + "</><action>没有技能顺利通过筛选</>");
			}
		}
		bool flag = false;
		bool flag2 = true;
		while (SkillInfoList != null && !flag && SkillInfoList.Count > 0)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + Owner.GetName().ConvertLongGuid2DisplayGuid() + "</><action>=====本轮算分开始=====</>");
			}
			flag = true;
			int num = -1;
			string text6 = "";
			int num2 = CalcSkillScoreAndReturnIdx(ref SkillInfoList, IsGetTopRandomSkill, TopRandomSkillPercent, UsePursuitAnyWhere: false);
			if (num2 >= 0 && SkillInfoList != null && SkillInfoList.Count > 0 && SkillInfoList.Count > num2)
			{
				FOneCBGCastSkillInfoCS fOneCBGCastSkillInfoCS = SkillInfoList[num2];
				num = fOneCBGCastSkillInfoCS.SkillID;
				text6 = fOneCBGCastSkillInfoCS.MontageStartSectionName;
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					string text7 = Owner.GetName().ConvertLongGuid2DisplayGuid();
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, IsGetTopRandomSkill ? $"<character>{text7}</><action>按照得分排序从高到低范围随机选择技能，随机范围是：前万分之</><effect>{TopRandomSkillPercent}</><action>的技能</>" : ("<character>" + Owner.GetName().ConvertLongGuid2DisplayGuid() + "</><action>直接选择最高分技能</>"));
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, $"<character>{text7}</><action>本轮算分赢家是：</><effect>{num}</><action>，尝试释放</>");
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + text7 + "</><action>=====本轮算分结束=====</>");
				}
				base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(num, ECastSkillSourceType.AI_Score)
				{
					MontageStartSectionName = FNameExtension.ToFName(text6),
					NeedCheckSkillCanCast = !fOneCBGCastSkillInfoCS.DontCheckSkillCanCast,
					HasSetSkillBaseTarget = true
				});
				if (SkillInstsData.GetLastSkillCastResult() != ECastSkillResult.CSR_OK)
				{
					flag2 = false;
					flag = !NeedTryCastAllSkillUntilSuccess;
					SkillInfoList.RemoveAt(num2);
				}
			}
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				string text8 = Owner.GetName().ConvertLongGuid2DisplayGuid();
				string text9 = (flag2 ? "成功" : "失败");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, flag ? $"<character>{text8}</><action>尝试释放，BestSkillIdx = </><effect>{num2}</><action>，BestSkillID = </><effect>{num}</><action>，MontageStartSectionName = </><effect>{text6}</><action>{text9}</>" : $"<character>{text8}</><action>尝试释放，BestSkillIdx = </><effect>{num2}</><action>，BestSkillID = </><effect>{num}</><action>，MontageStartSectionName = </><effect>{text6}</><action>失败，开始新一轮算分</>");
			}
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text10 = Owner.GetName().ConvertLongGuid2DisplayGuid();
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + text10 + "</><action>==================================尝试算分释放技能结束==================================</>");
		}
	}

	private bool GetChargeSkillBeginSkill(int SkillID, out int BeginSkillID)
	{
		if (ChargeSkillData.IsCastingChargeSkill && ChargeSkillData.ChargeSkillStage == EChargeSkillStage.End)
		{
			BeginSkillID = ChargeSkillData.CurrentBeginChargeSkillID;
			return true;
		}
		BeginSkillID = 0;
		return false;
	}

	private bool CheckAIAngleScoreIsZero(in FUStSkillAIDesc SkillAIDesc, FVector OwnerLocation, FRotator OwnerRotation, FVector TargetPosition)
	{
		float num = 0f;
		float num2 = BGUFuncLibAICS.BGUCalAngleWith2PointAndDir(OwnerLocation, OwnerRotation, TargetPosition);
		if (num2 >= 0f && num2 <= 45f)
		{
			num = SkillAIDesc.AngleScoreSector0To45;
		}
		else if (num2 > 45f && num2 <= 90f)
		{
			num = SkillAIDesc.AngleScoreSector45To90;
		}
		else if (num2 > 90f && num2 <= 135f)
		{
			num = SkillAIDesc.AngleScoreSector90To135;
		}
		else if (num2 > 135f && num2 <= 180f)
		{
			num = SkillAIDesc.AngleScoreSector135To180;
		}
		else if (num2 >= -180f && num2 <= -135f)
		{
			num = SkillAIDesc.AngleScoreSector180ToNeg135;
		}
		else if (num2 > -135f && num2 <= -90f)
		{
			num = SkillAIDesc.AngleScoreSectorNeg135ToNeg90;
		}
		else if (num2 > -90f && num2 <= -45f)
		{
			num = SkillAIDesc.AngleScoreSectorNeg90ToNeg45;
		}
		else if (num2 > -45f && num2 <= 0f)
		{
			num = SkillAIDesc.AngleScoreSectorNeg45To0;
		}
		return num == 0f;
	}

	private List<ECanCastSkillResult> GetCanCastComboSkillList(FVector TargetPosition, bool UseComboCondition, bool UsePursuitAnyWhere, List<int> SkillIDList, out List<int> CanCastSkillList)
	{
		RetCodeList.Clear();
		CanCastSkillList = new List<int>();
		if (Owner == null)
		{
			RetCodeList.Add(ECanCastSkillResult.CCSR_INVALID_CASTER);
			return RetCodeList;
		}
		if (SkillIDList.Count == 0)
		{
			RetCodeList.Add(ECanCastSkillResult.CCSR_EMPTY_SKILLIST);
			return RetCodeList;
		}
		if (SkillInstsData == null || AIData == null || SkillMappingData == null)
		{
			RetCodeList.Add(ECanCastSkillResult.CCSR_NULL_DATA);
			return RetCodeList;
		}
		foreach (int SkillID in SkillIDList)
		{
			FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(SkillID);
			FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, Owner);
			if (skillAIDesc != null && skillSDesc != null)
			{
				long skillCanCastResults = BGU_CommonUtil.GetSkillCanCastResults(Owner, SkillID, SkillID, AISkipStateJudge: true, NeedGetComboTarget: true, NeedCheckComboForAI: true, TargetPosition, UsePursuitAnyWhere, UseComboCondition);
				if ((skillCanCastResults & 1) == 1)
				{
					CanCastSkillList.Add(SkillID);
				}
				if (CanCastSkillList.Count > 0)
				{
					continue;
				}
				foreach (ECanCastSkillResult value in Enum.GetValues(typeof(ECanCastSkillResult)))
				{
					if (((ulong)skillCanCastResults & (ulong)value) == (ulong)value && !RetCodeList.Contains(value))
					{
						RetCodeList.Add(value);
					}
				}
			}
			else if (!RetCodeList.Contains(ECanCastSkillResult.CCSR_NOSKILL))
			{
				RetCodeList.Add(ECanCastSkillResult.CCSR_NOSKILL);
			}
		}
		return RetCodeList;
	}

	private List<ECanCastSkillResult> GetCanCastComboSkillListForScore(FVector TargetPosition, bool UseComboCondition, bool UsePursuitAnyWhere, ref List<FOneCBGCastSkillInfoCS> SkillInfoList)
	{
		RetCodeList.Clear();
		if (Owner == null)
		{
			RetCodeList.Add(ECanCastSkillResult.CCSR_INVALID_CASTER);
			return RetCodeList;
		}
		if (SkillInfoList == null || SkillInfoList.Count == 0)
		{
			RetCodeList.Add(ECanCastSkillResult.CCSR_EMPTY_SKILLIST);
			return RetCodeList;
		}
		if (SkillInstsData == null || AIData == null || SkillMappingData == null)
		{
			RetCodeList.Add(ECanCastSkillResult.CCSR_NULL_DATA);
			return RetCodeList;
		}
		bool flag = UnitStateData.HasState(EBGUUnitState.Dead) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing);
		for (int num = SkillInfoList.Count - 1; num >= 0; num--)
		{
			FOneCBGCastSkillInfoCS fOneCBGCastSkillInfoCS = SkillInfoList[num];
			bool flag2 = false;
			if (flag)
			{
				if (fOneCBGCastSkillInfoCS.CanCastWhenDead)
				{
					flag2 = true;
				}
			}
			else
			{
				flag2 = true;
			}
			if (flag2)
			{
				if (!fOneCBGCastSkillInfoCS.DontCheckSkillCanCast)
				{
					int skillID = fOneCBGCastSkillInfoCS.SkillID;
					FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(skillID);
					FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(skillID, Owner);
					if (skillAIDesc != null && skillSDesc != null)
					{
						long skillCanCastResults = BGU_CommonUtil.GetSkillCanCastResults(Owner, skillID, skillID, AISkipStateJudge: true, NeedGetComboTarget: true, NeedCheckComboForAI: true, TargetPosition, UsePursuitAnyWhere, UseComboCondition);
						if ((skillCanCastResults & 1) != 1)
						{
							SkillInfoList.RemoveAt(num);
							foreach (ECanCastSkillResult value in Enum.GetValues(typeof(ECanCastSkillResult)))
							{
								if (((ulong)skillCanCastResults & (ulong)value) == (ulong)value && !RetCodeList.Contains(value))
								{
									RetCodeList.Add(value);
								}
							}
						}
					}
					else
					{
						SkillInfoList.RemoveAt(num);
						if (!RetCodeList.Contains(ECanCastSkillResult.CCSR_OTHER))
						{
							RetCodeList.Add(ECanCastSkillResult.CCSR_NOSKILL);
						}
					}
				}
			}
			else
			{
				SkillInfoList.RemoveAt(num);
				if (!RetCodeList.Contains(ECanCastSkillResult.CCSR_OTHER))
				{
					RetCodeList.Add(ECanCastSkillResult.CCSR_OTHER);
				}
			}
		}
		return RetCodeList;
	}

	private void OnAICastBestComboSkill(UnitLockTargetInfo ComboTargetData, List<int> SkillIDList, bool IsFirstSkill, int CurComboSkillNum, int CurComboStage, bool IsGetTopRange, int TopPercent, bool EnableForceComboRelation, bool UseComboCondition, bool UsePursuitAnyWhere, bool NeedCheckSkillCanCast, bool CastFakeComboSkill, int LastCastSkillID)
	{
		AActor owner = GetOwner();
		AActor needGetInfoActor = owner;
		if (owner == null)
		{
			return;
		}
		FVector targetPosition = BGUFuncLibActorTransformCS.BGUGetActorLocation(needGetInfoActor);
		if (ComboTargetData != null && ComboTargetData.LockTargetActor != null)
		{
			targetPosition = BGUFuncLibAICS.BGUAIGetTargetInfoRealLockPoint(ComboTargetData);
		}
		ResetComboSkillInfo(IsFirstSkill, CurComboSkillNum, CurComboStage);
		if (IsFirstSkill)
		{
			AIData.ComboInfo.CurComboHasCastSkillList.Clear();
		}
		else if (EnableForceComboRelation)
		{
			if (LastCastSkillID != -1)
			{
				int currentCastingSkillID = SkillInstsData.CurrentCastingSkillID;
				if (currentCastingSkillID != -1)
				{
					LastCastSkillID = currentCastingSkillID;
				}
			}
			if (LastCastSkillID > 0)
			{
				BGUFuncLibAICS.BGUAIFilterComboRelationSkill(owner, ref SkillIDList, LastCastSkillID);
			}
		}
		SkillIDList = SkillIDList.Distinct().ToList();
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + owner.GetName().ConvertLongGuid2DisplayGuid() + "</><action>==================================尝试以Combo形式释放技能开始==================================</>");
			string text = "";
			foreach (int SkillID in SkillIDList)
			{
				text += $"{SkillID};";
			}
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + owner.GetName().ConvertLongGuid2DisplayGuid() + "</><action>本次释放技能池里存在技能：</><effect>" + text + "</>");
		}
		List<ECanCastSkillResult> list = new List<ECanCastSkillResult>();
		List<int> CanCastSkillList = SkillIDList;
		if (NeedCheckSkillCanCast)
		{
			list = GetCanCastComboSkillList(targetPosition, UseComboCondition, UsePursuitAnyWhere, SkillIDList, out CanCastSkillList);
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			if (CanCastSkillList.Count > 0)
			{
				string text2 = "";
				foreach (int item in CanCastSkillList)
				{
					text2 += $"{item};";
				}
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + owner.GetName().ConvertLongGuid2DisplayGuid() + "</><action>筛选完成，还剩下：</><effect>" + text2 + "</><action>尝试算分释放</>");
				string text3 = "";
				foreach (ECanCastSkillResult item2 in list)
				{
					text3 += BGUFuncLibAICS.GetAICastComboSkillFailedResultString(item2);
					text3 += "; ";
				}
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + owner.GetName().ConvertLongGuid2DisplayGuid() + "</><action>其他没有满足条件的技能！！！失败原因有: </><effect>" + text3 + "</>");
			}
			else
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + owner.GetName().ConvertLongGuid2DisplayGuid() + "</><action>筛选完成，没有技能顺利通过筛选</>");
				string text4 = "";
				foreach (ECanCastSkillResult item3 in list)
				{
					text4 += BGUFuncLibAICS.GetAICastComboSkillFailedResultString(item3);
					text4 += "; ";
				}
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + owner.GetName().ConvertLongGuid2DisplayGuid() + "</><action>当前没有能满足释放条件的技能，所以释放失败！！！失败原因有: </><effect>" + text4 + "</>");
			}
		}
		bool flag = false;
		int num = 0;
		while (!flag && CanCastSkillList.Count > 0)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + owner.GetName().ConvertLongGuid2DisplayGuid() + "</><action>=====本轮算分开始=====</>");
			}
			flag = true;
			num = CalcSkillScore(CanCastSkillList, IsGetTopRange, TopPercent, UsePursuitAnyWhere);
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, IsGetTopRange ? $"<character>{owner.GetName().ConvertLongGuid2DisplayGuid()}</><action>按照得分排序从高到低范围随机选择技能，随机范围是：前万分之</><effect>{TopPercent}</><action>的技能</>" : ("<character>" + owner.GetName().ConvertLongGuid2DisplayGuid() + "</><action>直接选择最高分技能</>"));
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, $"<character>{owner.GetName().ConvertLongGuid2DisplayGuid()}</><action>本轮算分赢家是：</><effect>{num}</><action>，尝试释放</>");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + owner.GetName().ConvertLongGuid2DisplayGuid() + "</><action>=====本轮算分结束=====</>");
			}
			if (num <= 0)
			{
				continue;
			}
			int num2 = ActionReqData.GetLastSkillID();
			if (GetChargeSkillBeginSkill(num2, out var BeginSkillID))
			{
				num2 = BeginSkillID;
			}
			bool flag2 = IsFirstSkill;
			if (!CastFakeComboSkill)
			{
				FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(num2);
				if (num2 > 0 && skillAIDesc != null && skillAIDesc.NextSkillList.Count > 0 && skillAIDesc.NextSkillList.Contains(num))
				{
					flag2 = true;
				}
			}
			FName montageStartSectionName = ((IsFirstSkill || CastFakeComboSkill) ? FName.None : B1GlobalFNames.ing);
			if (flag2 || CastFakeComboSkill)
			{
				base.BUSEventCollection.Evt_SetSkillBaseTarget.Invoke(ComboTargetData.LockTargetActor, ComboTargetData.LockPointLocation, ETargetSourceType.SkillBase_SetByCombo, "");
				base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(num, ECastSkillSourceType.AI_Combo)
				{
					MontageStartSectionName = montageStartSectionName,
					NeedCheckSkillCanCast = false,
					HasSetSkillBaseTarget = true
				});
				if (SkillInstsData.GetLastSkillCastResult() != ECastSkillResult.CSR_OK)
				{
					CanCastSkillList.Remove(num);
					flag = false;
				}
			}
			if (DebugConfig.IsOpenBattleInfoTool && (flag2 || CastFakeComboSkill))
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, flag ? $"<character>{owner.GetName().ConvertLongGuid2DisplayGuid()}</><action>以</><effect>连招形式</><action>尝试释放</><effect>{num}</><action>成功</>" : $"<character>{owner.GetName().ConvertLongGuid2DisplayGuid()}</><action>以</><effect>连招形式</><action>尝试释放</><effect>{num}</><action>失败，开始新一轮算分</>");
			}
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillCast, "<character>" + owner.GetName().ConvertLongGuid2DisplayGuid() + "</><action>==================================尝试以Combo形式释放技能结束==================================</>");
		}
	}

	private void OnModifySkillScore(List<FHitModifySkillScoreInfo> SuccessInfoList, List<FHitModifySkillScoreInfo> FailedInfoList)
	{
		if (GetOwner() == null || SkillInstsData.CurrentCastingSkillID == -1)
		{
			return;
		}
		List<FHitModifySkillScoreInfo> list = FailedInfoList;
		if (SkillInstsData.IsHitUnitDuringCastingSkill)
		{
			list = SuccessInfoList;
		}
		foreach (FHitModifySkillScoreInfo item in list)
		{
			int skillID = item.SkillID;
			float modifyScore = item.ModifyScore;
			if (AIData.ComboInfo.SkillModifyScoreDic.TryGetValue(skillID, out var _))
			{
				AIData.ComboInfo.SkillModifyScoreDic[skillID] = modifyScore;
			}
			else
			{
				AIData.ComboInfo.SkillModifyScoreDic.Add(skillID, modifyScore);
			}
		}
	}

	private void ResetModifyScoreInfoDic()
	{
		if (!(GetOwner() == null))
		{
			AIData.ComboInfo.SkillModifyScoreDic.Clear();
		}
	}

	private void ResetComboSkillInfo(bool IsFirstSkill, int CurComboSkillNum, int CurComboStage)
	{
		AIData.ComboInfo.ResetComboInfo(IsFirstSkill, CurComboSkillNum, CurComboStage);
	}

	private int CalcSkillScore(List<int> SkillIDListCanCast, bool IsGetTopRange, int TopPercent, bool UsePursuitAnyWhere)
	{
		AIData.ComboInfo.ResetSkillScores();
		for (int i = 0; i < SkillIDListCanCast.Count; i++)
		{
			int num = SkillIDListCanCast[i];
			foreach (SkillScoreFilterBaseCS sSF in SSFList)
			{
				if (AIData.ComboInfo.MapSkillFeatures.TryGetValue(num, out var value))
				{
					float score = value.Score;
					if (score <= -9999f)
					{
						break;
					}
					if (!sSF.CalculateScore(GetOwner(), num, UsePursuitAnyWhere, out var Score))
					{
						score = -9999f;
						value.Score = score;
						break;
					}
					score += Score;
					value.Score = score;
				}
			}
		}
		int result = SelectBestSkillForCombo(IsGetTopRange, TopPercent, SkillIDListCanCast);
		ResetModifyScoreInfoDic();
		AIData.ComboInfo.ResetSkillScores();
		return result;
	}

	private int CalcSkillScoreAndReturnIdx(ref List<FOneCBGCastSkillInfoCS> SkillInfoList, bool IsGetTopRange, int TopPercent, bool UsePursuitAnyWhere)
	{
		int result = -1;
		for (int num = SkillInfoList.Count - 1; num >= 0; num--)
		{
			int skillID = SkillInfoList[num].SkillID;
			foreach (SkillScoreFilterBaseCS sSF in SSFList)
			{
				float score = SkillInfoList[num].Score;
				if (score <= -9999f)
				{
					break;
				}
				if (!sSF.CalculateScore(GetOwner(), skillID, UsePursuitAnyWhere, out var Score))
				{
					SkillInfoList.RemoveAt(num);
					break;
				}
				score += Score;
				SkillInfoList[num].Score = score;
			}
		}
		if (IsGetTopRange)
		{
			if (TopPercent <= 0 || TopPercent > 10000)
			{
				TopPercent = 10000;
			}
			int rightNum = (int)((float)(SkillInfoList.Count * TopPercent) * 0.0001f);
			int x = UB1Util.GetRandomNumberInt(1, rightNum) - 1;
			x = FMath.Clamp(x, 0, SkillInfoList.Count - 1);
			if (SkillInfoList.Count > 0 && SkillInfoList.Count >= x)
			{
				result = x;
			}
		}
		else
		{
			float num2 = -1f;
			for (int num3 = SkillInfoList.Count - 1; num3 >= 0; num3--)
			{
				float score2 = SkillInfoList[num3].Score;
				if (num2 < 0f || num2 < score2)
				{
					num2 = score2;
					result = num3;
				}
			}
		}
		return result;
	}

	private int SelectBestSkillForCombo(bool IsGetTopRange, int TopPercent, List<int> SkillIDListCanCast)
	{
		int result = 0;
		if (SkillIDListCanCast.Count > 0)
		{
			AIData.ComboInfo.SetSkillCantCast(SkillIDListCanCast);
			if (IsGetTopRange)
			{
				SelectBestSkillTempList.Clear();
				foreach (KeyValuePair<int, AISkillDynamicFeature> mapSkillFeature in AIData.ComboInfo.MapSkillFeatures)
				{
					int key = mapSkillFeature.Key;
					AISkillDynamicFeature value = mapSkillFeature.Value;
					if (BGW_GameDB.GetSkillAIDesc(key) != null && !(value.Score <= -9999f))
					{
						SelectBestSkillTempList.Add(key);
					}
				}
				if (TopPercent <= 0 || TopPercent > 10000)
				{
					TopPercent = 10000;
				}
				int rightNum = (int)((float)(SelectBestSkillTempList.Count * TopPercent) * 0.0001f);
				int x = UB1Util.GetRandomNumberInt(1, rightNum) - 1;
				x = FMath.Clamp(x, 0, SelectBestSkillTempList.Count - 1);
				if (SelectBestSkillTempList.Count > 0 && SelectBestSkillTempList.Count >= x)
				{
					result = SelectBestSkillTempList[x];
				}
			}
			else
			{
				foreach (KeyValuePair<int, AISkillDynamicFeature> mapSkillFeature2 in AIData.ComboInfo.MapSkillFeatures)
				{
					int key2 = mapSkillFeature2.Key;
					AISkillDynamicFeature value2 = mapSkillFeature2.Value;
					if (BGW_GameDB.GetSkillAIDesc(key2) != null && !(value2.Score <= -9999f))
					{
						result = key2;
						break;
					}
				}
			}
		}
		return result;
	}

	private void OnAIPauseBT(bool IsPause)
	{
		ABGUAIController aIController = AIComps.AIController;
		if (!aIController.IsNullOrDestroyed() && !aIController.BrainComponent.IsNullOrDestroyed())
		{
			AIFuncLib.SetAIBTPause(aIController.BrainComponent.Address, IsPause);
			base.BUSEventCollection.Evt_SetAINodeActionPause.Invoke(IsPause);
		}
	}

	private void OnSetLastHitActor(AActor LastHitActor)
	{
		base.BUSEventCollection.Evt_AddLastSkillHit.Invoke(LastHitActor);
	}

	private void OnSetEQSTarget(AActor Target)
	{
		AIData.SetCurEQSTarget(Target);
	}

	private void OnSetMaxComboNum(int _MaxComboNum)
	{
		AIData.SetMaxComboNum(_MaxComboNum);
	}

	private void OnSetCurComboLength(int _CurComboLength)
	{
		AIData.SetCurComboLength(_CurComboLength);
	}

	private void OnSetWatchTime(float _WatchTime)
	{
		AIData.SetWatchTime(_WatchTime);
	}

	private void OnSetLastAttackTime(float _LastAttackTime)
	{
		AIData.SetLastAttackTime(_LastAttackTime);
	}

	private void OnSetBeHitTime(float _BeHitTime)
	{
		AIData.SetLastBeHitTime(_BeHitTime);
	}

	private void OnSetLastAttackerID(AActor _LastAttackerID)
	{
		AIData.SetLastAttackerID(_LastAttackerID);
	}

	private void OnSetLastAtkDmgTime(float _LastAtkDmgTime)
	{
		AIData.SetLastAtkDmgTime(_LastAtkDmgTime);
	}

	private void OnSetGroupAISkill(List<int> SkillList)
	{
		AIData.SetGroupAISkill(SkillList);
	}

	private void OnSetObstacleCheckResult(float InScore)
	{
		AIData.Memory.ObstacleCheckScore = InScore;
	}

	private void OnSetEscapeLocation(FVector InLocation)
	{
		AIData.Memory.EscapeLocation = InLocation;
	}

	private void OnEscapeWayChanged(EEscapeWay InEscapeWay)
	{
		AIData.Memory.EscapeWay = InEscapeWay;
	}

	private void OnSetPursuitRange(EPursuitRangeReqType PursuitRangeReqType, float PursuitRange)
	{
		AIData.SetPursuitRange(PursuitRangeReqType, PursuitRange);
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		OnResetAIInfo();
		OnResetToDefaultFsmSolver();
		HiddenFrameCounter = -1;
		DoubleCheckFlag = false;
		WakeUpData.bNotFirstTimeWakeUp = false;
		WakeUpData.DisabledWakeUp = false;
		if (WakeUpData.SurpriseSkillID.Count > 0)
		{
			WakeUpData.CanCastSurpriseSkill = true;
		}
		AIData.FsmContext.bCanTriggerWakeupActivated = false;
	}

	private void OnLeaveFight()
	{
		OnResetAIInfo();
	}

	private void OnMarkLastTargetInfoForAI(AActor LastTargetActor)
	{
		AIData.Memory.TargetPosCache = BGUFuncLibActorTransformCS.BGUGetActorTransform(LastTargetActor);
		AIData.Memory.LastTargetEntity = ECSUtil.ToEntity(LastTargetActor);
	}

	private void OnSwitchBehaviourTree(bool Enable, string BTPath)
	{
		AActor owner = GetOwner();
		if (!(owner == null) && !(owner as BGUCharacterCS == null))
		{
			UBehaviorTree configBT = AIData.ConfigBT;
			UBehaviorTree uBehaviorTree = (Enable ? BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UBehaviorTree>(BTPath, ELoadResourceType.SyncLoadAndCache) : null);
			SetBT((uBehaviorTree != null) ? uBehaviorTree : configBT);
		}
	}

	private void SetBT(UBehaviorTree BT)
	{
		if (AIData.bCanSetBT)
		{
			AIData.bHasRunBT = BT != null;
			AIData.CurrentRunBT = BT;
			AIController aIController = Owner.GetInstigatorController() as AIController;
			if (aIController != null && aIController.BrainComponent is UBehaviorTreeComponent uBehaviorTreeComponent)
			{
				AIFuncLib.SetAIBTStop(uBehaviorTreeComponent.Address);
			}
			base.BUSEventCollection.Evt_SetAINodeActionStop.Invoke();
			if (BT != null)
			{
				AIFuncLib.AISetBT(GetOwner().Address, BT.Address);
			}
		}
	}

	private void OnTryRunDefaultBT()
	{
		if (!AIData.bHasRunBT)
		{
			SetBT(AIData.ConfigBT);
		}
	}

	private void OnEnableCanSetBT(bool bEnable)
	{
		AIData.bCanSetBT = bEnable;
	}

	private void OnSwitchFsmSolver(EFsmSolverType NewSolverType)
	{
		if (AIData.CurrentUseSolver == null || (AIData.CurrentUseSolver != null && AIData.CurrentUseSolver.FsmSolverType != NewSolverType))
		{
			FsmSolverBase fsmSolverBase = null;
			switch (NewSolverType)
			{
			case EFsmSolverType.Normal:
				fsmSolverBase = new NormalAIFsmSolver();
				break;
			case EFsmSolverType.AssistantPartner:
				fsmSolverBase = new AssistantPartnerFsmSolver();
				break;
			case EFsmSolverType.FriendlyBattleNpc:
				fsmSolverBase = new FriendlyBattleNpcAIFsmSolver();
				break;
			case EFsmSolverType.GroupAi:
				fsmSolverBase = new GroupAIFsmSolver();
				break;
			case EFsmSolverType.SummonAi:
				fsmSolverBase = new SummonAIFsmSolver();
				break;
			case EFsmSolverType.NeutralAnimalBattle:
				fsmSolverBase = new NeutralAnimalBattleAIFsmSolver();
				break;
			case EFsmSolverType.NeutralAnimalEscape:
				fsmSolverBase = new NeutralAnimalEscapeAIFsmSolver();
				break;
			}
			if (fsmSolverBase != null)
			{
				BGUCharacterCS bGUChr = Owner as BGUCharacterCS;
				AIData.CurrentUseSolver?.UnBindEventCollection();
				AIData.CurrentUseSolver?.Destory();
				AIData.CurrentUseSolver = null;
				AIData.CurrentUseSolver = fsmSolverBase;
				AIData.CurrentUseSolver?.Init(this, bGUChr, base.BUSEventCollection, base.BGSEventCollection);
				AIData.CurrentUseSolver?.BindEventCollection();
			}
		}
	}

	private void OnResetToDefaultFsmSolver()
	{
		if (AIData.CurrentUseSolver.FsmSolverType != AIData.OriginFsmSolverType)
		{
			AIData.CurrentUseSolver?.UnBindEventCollection();
			AIData.CurrentUseSolver?.Destory();
			AIData.CurrentUseSolver = null;
			BGUCharacterCS bGUChr = Owner as BGUCharacterCS;
			switch (AIData.OriginFsmSolverType)
			{
			case EFsmSolverType.Normal:
				AIData.CurrentUseSolver = new NormalAIFsmSolver();
				break;
			case EFsmSolverType.AssistantPartner:
				AIData.CurrentUseSolver = new AssistantPartnerFsmSolver();
				break;
			case EFsmSolverType.FriendlyBattleNpc:
				AIData.CurrentUseSolver = new FriendlyBattleNpcAIFsmSolver();
				break;
			case EFsmSolverType.GroupAi:
				AIData.CurrentUseSolver = new GroupAIFsmSolver();
				break;
			case EFsmSolverType.SummonAi:
				AIData.CurrentUseSolver = new SummonAIFsmSolver();
				break;
			}
			AIData.CurrentUseSolver?.Init(this, bGUChr, base.BUSEventCollection, base.BGSEventCollection);
			AIData.CurrentUseSolver?.BindEventCollection();
		}
	}

	private void OnUpdateFsmSolver(float DeltaTime)
	{
		if (Owner == null || UnitStateData.HasState(EBGUUnitState.Dead) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) || AIData.CurrentUseSolver == null)
		{
			return;
		}
		if (AIData.CurrentUseSolver.CheckIsValid())
		{
			AIData.CurrentUseSolver?.UpdateForAIFsm(DeltaTime);
			if (AIData.FsmContext.bCanTriggerWakeupActivated)
			{
				AIData.FsmContext.bCanTriggerWakeupActivated = false;
				if (AIData.CurrentUseSolver != null && AIData.CurrentUseSolver.FsmSolverType == EFsmSolverType.Normal && FsmData.IsInFsmState(BGW_FlowUtils.NormalAIFsmStateTag.AIWakeup))
				{
					TriggerWakeupActivated();
				}
			}
		}
		else
		{
			AIData.CurrentUseSolver.Destory();
			AIData.CurrentUseSolver = null;
		}
	}

	private void OnFsmStateEnter(FGameplayTag EnterStateTag)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.CSGDebug, $"<character>{Owner.GetName().ConvertLongGuid2DisplayGuid()}</><effect>【CSGDEBUG】</><action> 进入状态 </><effectnum>{EnterStateTag.TagName}</>");
		}
		if (AIData.CurrentUseSolver == null || AIData.CurrentUseSolver.FsmSolverType == EFsmSolverType.AssistantPartner)
		{
			return;
		}
		if (GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.AINonCombatBorn, EnterStateTag))
		{
			if (!TamerData.GetTamerType(GuidData.GetFinalGuid(), out var OutTamerType))
			{
				return;
			}
			switch (OutTamerType)
			{
			case ETamerType.LevelLoaded:
				base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NormalAIFsmEventTag.AINonCombatFinishBorn);
				break;
			case ETamerType.Spawned:
				if (BirthData.UnitSpawnInfo == null || BirthData.UnitSpawnInfo.SpawnMontage == null)
				{
					base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NormalAIFsmEventTag.AINonCombatFinishBorn);
				}
				break;
			}
		}
		else if (GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.AIWakeup, EnterStateTag))
		{
			float watchTime = FMath.FRandRange(AIData.AIWatchTimeMin, AIData.AIWatchTimeMax);
			OnSetWatchTime(watchTime);
			AActor lockTargetActor = TargetInfoData.GetTargetInfo().LockTargetActor;
			if (WakeUpData.WakeUpLinkEnable)
			{
				WakeUpData.HasTriggerWakeUp = true;
				List<AActor> list = new List<AActor>();
				if (WakeUpData.UseManualSelect)
				{
					foreach (string manualTargetGuid in WakeUpData.ManualTargetGuidList)
					{
						ABGUCharacter aBGUCharacter = BGU_DataUtil.GetActorByGuid(Owner, manualTargetGuid) as ABGUCharacter;
						if (!list.Contains(aBGUCharacter) && aBGUCharacter != null)
						{
							list.Add(aBGUCharacter);
						}
					}
				}
				if (WakeUpData.UseRangeSelect)
				{
					List<ABGUCharacter> list2 = BGUFuncLibSelectTargetsCS.SelectTargetsWithFilter(Owner, WakeUpData);
					if (list2 != null && list2.Count > 0)
					{
						foreach (ABGUCharacter item in list2)
						{
							if (!list.Contains(item))
							{
								list.Add(item);
							}
						}
					}
				}
				foreach (AActor item2 in list)
				{
					IBUC_BattleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(item2);
					if (readOnlyData != null && !readOnlyData.IsUnitInBattle())
					{
						BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(item2);
						if (bUS_GSEventCollection != null)
						{
							bUS_GSEventCollection.Evt_AICatchTarget.Invoke(lockTargetActor, ETargetSourceType.Target_AwakePartner);
						}
					}
				}
			}
			base.BGSEventCollection.Evt_OnTriggerWakeBroadCastToFamily.Invoke(GuidData.GetFinalGuid(), lockTargetActor);
			base.BUSEventCollection.Evt_OnTriggerWakeBroadCastToTeam.Invoke(lockTargetActor);
		}
		else if (GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.AIWakeupEngage, EnterStateTag))
		{
			if (UnitStateData.HasState(EBGUUnitState.Beatback))
			{
				TriggerWakeupActivated();
				return;
			}
			if (WakeUpData.DisabledWakeUp)
			{
				TriggerWakeupActivated();
				return;
			}
			int num = 0;
			AActor lockTargetActor2 = TargetInfoData.GetTargetInfo().LockTargetActor;
			if (lockTargetActor2 != null)
			{
				if (WakeUpData.bJustUseOnFightSkillFirstTime && WakeUpData.bNotFirstTimeWakeUp)
				{
					num = 0;
				}
				else
				{
					FVector a = lockTargetActor2.GetActorLocation() - BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
					FVector b = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(Owner);
					float z = (b.Z = 0f);
					a.Z = z;
					float num3 = FMath.Acos(a.CosineAngle2D(b)) / (float)Math.PI * 180f;
					if (a.Cross_VectorVector(b).Z > 0f)
					{
						num3 *= -1f;
					}
					num = GetDirectionOnFightSkill(num3);
				}
			}
			float OutCurveValue;
			if (num == 0)
			{
				base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NormalAIFsmEventTag.AIWakeupFinishEngage);
			}
			else if (AnimHumanoidHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.SkillCastTimeRange, out OutCurveValue) && OutCurveValue == 0f)
			{
				AIData.PendingOnFightSkillID = num;
			}
			else
			{
				TryCastOnFightSkill(num);
			}
		}
		else if (GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.AIWakeupSurpriseSkill, EnterStateTag))
		{
			if (UnitStateData.HasState(EBGUUnitState.Beatback))
			{
				TriggerWakeupActivated();
				return;
			}
			if (WakeUpData.DisabledWakeUp)
			{
				TriggerWakeupActivated();
				return;
			}
			if (!WakeUpData.CanCastSurpriseSkill)
			{
				TriggerWakeupActivated();
				return;
			}
			base.BUSEventCollection.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.Combo, new AINodeAction_ComboParamInfo
			{
				ComboTargetType = EComboTargetType.CurrentAITarget,
				SkillSourceType = EZatoichiSkillSourceType.UseWithSurpriseSkilll,
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
		}
		else if (GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.AINonCombat, EnterStateTag))
		{
			OnResetAIInfo();
			base.BUSEventCollection.Evt_ResetSkillCD.Invoke();
			base.BUSEventCollection.Evt_MovementForceStop.Invoke();
			base.BUSEventCollection.Evt_StartPatrolAndLeisure.Invoke();
		}
	}

	private void TryCastOnFightSkill(int OnFightSkillID)
	{
		if (BGW_GameDB.GetSkillSDesc(OnFightSkillID, Owner) != null)
		{
			base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(OnFightSkillID, ECastSkillSourceType.AI_OnFight)
			{
				Reason = EMontageBindReason.EngageSkill,
				NeedCheckSkillCanCast = false
			});
			if (SkillInstsData.GetLastSkillCastResult() != ECastSkillResult.CSR_OK)
			{
				base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NormalAIFsmEventTag.AIWakeupFinishEngage);
			}
			else
			{
				base.BUSEventCollection.Evt_CastOnFightSkillSuccess.Invoke(OnFightSkillID);
			}
		}
		else
		{
			base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NormalAIFsmEventTag.AIWakeupFinishEngage);
		}
	}

	private void OnFsmStateExit(FGameplayTag ExitStateTag)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.CSGDebug, $"<character>{Owner.GetName().ConvertLongGuid2DisplayGuid()}</><effect>【CSGDEBUG】</><action> 退出状态 </><effectnum>{ExitStateTag.TagName}</>");
		}
		if (AIData.CurrentUseSolver != null && AIData.CurrentUseSolver.FsmSolverType != EFsmSolverType.AssistantPartner && GameplayTagExtension.EqualTo(BGW_FlowUtils.NormalAIFsmStateTag.AINonCombat, ExitStateTag) && PatrolData != null && PatrolData.bIsPatroling)
		{
			base.BUSEventCollection.Evt_StopPatrolAndLeisure.Invoke();
			base.BUSEventCollection.Evt_MovementForceStop.Invoke();
		}
	}

	private void TriggerWakeupActivated()
	{
		base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NormalAIFsmEventTag.LifeTimeAwake);
		if (AIData.GetWatchTime() <= 0f)
		{
			base.BUSEventCollection.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_BATTLE_ATTACK);
		}
		string finalGuid = GuidData.GetFinalGuid();
		if (IsOnline())
		{
			base.BUSEventCollection.Evt_NotifyGraphClient.Invoke(finalGuid, BGW_FlowUtils.CommonTag.WakeUp);
		}
		else
		{
			base.BGSEventCollection?.Evt_BGS_NotifyGraph.Invoke(finalGuid, BGW_FlowUtils.CommonTag.WakeUp);
			base.BGWEventCollection?.Evt_TaskGraphNotifyGraph(finalGuid, BGW_FlowUtils.CommonTag.WakeUp);
		}
		base.BUSEventCollection.Evt_OnWakeUp.Invoke();
		WakeUpData.bNotFirstTimeWakeUp = true;
	}

	private void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (State == EMontageCallbackState.Default || State == EMontageCallbackState.OnBlendOut || UnitStateData.HasState(EBGUUnitState.Dead) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			return;
		}
		switch (Reason)
		{
		case EMontageBindReason.Born:
			if (State == EMontageCallbackState.OnStarted)
			{
				DoubleCheckFlag = true;
				HiddenFrameCounter = HIDDEN_FRAME_NUM;
				Owner.SetActorHiddenInGame(bNewHidden: true);
			}
			else
			{
				base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NormalAIFsmEventTag.AINonCombatFinishBorn);
			}
			break;
		case EMontageBindReason.EngageSkill:
			if (State != EMontageCallbackState.OnStarted)
			{
				base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.NormalAIFsmEventTag.AIWakeupFinishEngage);
			}
			break;
		}
	}

	private void OnNotifyPlayBornAnim(bool HasPlayBornAnim)
	{
		HiddenFrameCounter = HIDDEN_FRAME_NUM;
		Owner.SetActorHiddenInGame(bNewHidden: true);
	}

	private void OnNotifyAIActionFinish(EAINodeActionType FinishActionType)
	{
		if (FsmData.IsInFsmState(BGW_FlowUtils.NormalAIFsmStateTag.AIWakeupSurpriseSkill) && FinishActionType == EAINodeActionType.Combo)
		{
			TriggerWakeupActivated();
		}
	}

	private void OnSurpriseSkill(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		if (WakeUpData.CanCastSurpriseSkill && WakeUpData.SurpriseSkillID.Contains(MappingSkillID))
		{
			WakeUpData.CanCastSurpriseSkill = false;
		}
	}

	private void OnSetUnitWakeUpEnabled(bool Enabled)
	{
		WakeUpData.DisabledWakeUp = !Enabled;
	}

	private void OnSetOnFightSkillID(int _OnFightSkillID)
	{
		WakeUpData.OnFightSkillID = _OnFightSkillID;
		WakeUpData.OnFightSkillIDBack = _OnFightSkillID;
		WakeUpData.OnFightSkillIDLeft = _OnFightSkillID;
		WakeUpData.OnFightSkillIDRight = _OnFightSkillID;
	}

	private void OnNPCReplaceOnFightSkillID(int OnFightSkillID, int OnFightSkillIDBack, int OnFightSkillIDLeft, int OnFightSkillIDRight)
	{
		WakeUpData.NPCAnimOverrideOnFightSkillID = OnFightSkillID;
		WakeUpData.NPCAnimOverrideOnFightSkillIDBack = OnFightSkillIDBack;
		WakeUpData.NPCAnimOverrideOnFightSkillIDLeft = OnFightSkillIDLeft;
		WakeUpData.NPCAnimOverrideOnFightSkillIDRight = OnFightSkillIDRight;
	}

	private bool HandleNeedReturnHomeCheck()
	{
		if (AIData.ReturnHomeTriggerType == EFsmStateLogicTriggerType.Auto && !FsmData.HasOverrideSubMachine(BGW_FlowUtils.NormalAIFsmStateTag.AIBattle) && AIData.FsmContext.bNeedReturnHome)
		{
			if (!UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				base.BUSEventCollection.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_GOHOME);
				AIData.FsmContext.bNeedReturnHome = false;
			}
			return true;
		}
		return false;
	}

	private int GetDirectionOnFightSkill(float TargetAngle)
	{
		int[] array = new int[4];
		if (NPCAnimData != null && NPCAnimData.IsTriggerReplaceLeisureAnim)
		{
			array[0] = WakeUpData.NPCAnimOverrideOnFightSkillID;
			array[1] = WakeUpData.NPCAnimOverrideOnFightSkillIDRight;
			array[2] = WakeUpData.NPCAnimOverrideOnFightSkillIDBack;
			array[3] = WakeUpData.NPCAnimOverrideOnFightSkillIDLeft;
		}
		else if (PatrolData.HasReplaceLeisureSequenceID() && MovieData.IsSequencePlayed(PatrolData.LeisureConfig.ReplaceLeisureSequenceID))
		{
			array[0] = WakeUpData.AfterSequenceOverrideOnFightSkillID;
			array[1] = WakeUpData.AfterSequenceOverrideOnFightSkillIDRight;
			array[2] = WakeUpData.AfterSequenceOverrideOnFightSkillIDBack;
			array[3] = WakeUpData.AfterSequenceOverrideOnFightSkillIDLeft;
		}
		else
		{
			array[0] = WakeUpData.OnFightSkillID;
			array[1] = WakeUpData.OnFightSkillIDRight;
			array[2] = WakeUpData.OnFightSkillIDBack;
			array[3] = WakeUpData.OnFightSkillIDLeft;
		}
		int num = 0;
		bool flag = false;
		if (TargetAngle >= -45f && TargetAngle < 45f)
		{
			num = 0;
			flag = TargetAngle < 0f;
		}
		else if (TargetAngle >= 45f && TargetAngle < 135f)
		{
			num = 1;
			flag = TargetAngle < 90f;
		}
		else if (TargetAngle >= -135f && TargetAngle < -45f)
		{
			num = 3;
			flag = TargetAngle < -90f;
		}
		else
		{
			num = 2;
			flag = TargetAngle > 0f;
		}
		if (array[num] != 0)
		{
			return array[num];
		}
		if (array[(num + 1) % 4] == 0 && array[(num + 3) % 4] == 0)
		{
			return array[(num + 2) % 4];
		}
		if (array[(num + 1) % 4] == 0)
		{
			return array[(num + 3) % 4];
		}
		if (array[(num + 3) % 4] == 0)
		{
			return array[(num + 1) % 4];
		}
		if (flag)
		{
			return array[(num + 3) % 4];
		}
		return array[(num + 1) % 4];
	}

	static BUS_AIComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_AIComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_AIComp));
		RETURNHOME_BUFFID = 501;
		NONCOMBAT_FIND_HOSTILE_DURATION = 1f;
		HIDDEN_FRAME_NUM = 3;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_AIComp:OnTargetPerceptionUpdated")]
	private static void OnTargetPerceptionUpdated__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_AIComp bUS_AIComp = GCHelper.Find<BUS_AIComp>(obj);
		AActor target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnTargetPerceptionUpdated_Target_Offset));
		FAIStimulus stimulus = FAIStimulus.FromNative(IntPtr.Add(buffer, OnTargetPerceptionUpdated_Stimulus_Offset));
		bUS_AIComp.OnTargetPerceptionUpdated(target, stimulus);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_AIComp");
		PerceptionComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "PerceptionComp");
		PerceptionComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PerceptionComp", Classes.FObjectProperty);
		OnTargetPerceptionUpdated_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTargetPerceptionUpdated");
		OnTargetPerceptionUpdated_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTargetPerceptionUpdated_FunctionAddress);
		OnTargetPerceptionUpdated_Target_Offset = NativeReflection.GetPropertyOffset(OnTargetPerceptionUpdated_FunctionAddress, "Target");
		OnTargetPerceptionUpdated_Target_IsValid = NativeReflection.ValidatePropertyClass(OnTargetPerceptionUpdated_FunctionAddress, "Target", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref OnTargetPerceptionUpdated_Stimulus_PropertyAddress, OnTargetPerceptionUpdated_FunctionAddress, "Stimulus");
		OnTargetPerceptionUpdated_Stimulus_Offset = NativeReflection.GetPropertyOffset(OnTargetPerceptionUpdated_FunctionAddress, "Stimulus");
		OnTargetPerceptionUpdated_Stimulus_IsValid = NativeReflection.ValidatePropertyClass(OnTargetPerceptionUpdated_FunctionAddress, "Stimulus", Classes.FStructProperty);
		OnTargetPerceptionUpdated_IsValid = OnTargetPerceptionUpdated_FunctionAddress != IntPtr.Zero && OnTargetPerceptionUpdated_Target_IsValid && OnTargetPerceptionUpdated_Stimulus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_AIComp:OnTargetPerceptionUpdated", OnTargetPerceptionUpdated_IsValid);
	}
}
