using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using CommB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_CricketMgrComp : UActorCompBaseCS
{
	private enum ECricketBehaviorStateTag
	{
		None,
		Enter,
		Jump,
		MatchingPos,
		Idle
	}

	private class CricketBehaviorStateMachine
	{
		public delegate void Del_OnExit();

		private Dictionary<ECricketBehaviorStateTag, CricketBehaviorStateBase> States;

		private BGUCricketMgrActor Manager;

		private Del_OnExit ExitCallback;

		private CricketBehaviorStateBase CurrentState;

		private bool bPaused;

		private bool bCanTriggerNext;

		private b1.IBUC_CricketMgrData CricketMgrData;

		private IBIC_GlobalActorData GlobalActorData;

		public ECricketBehaviorStateTag CurStateTag { get; private set; }

		public CricketBehaviorStateMachine(in BGUCricketMgrActor InManager, Del_OnExit InExitCallback)
		{
			bPaused = false;
			bCanTriggerNext = true;
			Manager = InManager;
			ExitCallback = InExitCallback;
			CricketMgrData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_CricketMgrData, b1.BUC_CricketMgrData>(Manager);
			GlobalActorData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(Manager);
			States = new Dictionary<ECricketBehaviorStateTag, CricketBehaviorStateBase>();
			States.Add(ECricketBehaviorStateTag.Enter, CreateState<CricketBehaviorState_Enter>());
			States.Add(ECricketBehaviorStateTag.Jump, CreateState<CricketBehaviorState_Jump>());
			States.Add(ECricketBehaviorStateTag.MatchingPos, CreateState<CricketBehaviorState_MatchingPos>());
			States.Add(ECricketBehaviorStateTag.Idle, CreateState<CricketBehaviorState_Idle>());
		}

		private CricketBehaviorStateBase CreateState<T>() where T : CricketBehaviorStateBase, new()
		{
			T val = new T();
			val.Init(in Manager, in CricketMgrData, in this);
			return val;
		}

		public void Start()
		{
			bPaused = false;
			bCanTriggerNext = true;
			CurStateTag = ECricketBehaviorStateTag.Enter;
			CurrentState = States[CurStateTag];
			CurrentState.OnEnter();
		}

		public void End()
		{
			bPaused = false;
			bCanTriggerNext = true;
			CurrentState?.OnExit();
			CurrentState = null;
			CurStateTag = ECricketBehaviorStateTag.None;
		}

		public void OnTick(float DeltaTime)
		{
			if (!bPaused)
			{
				if (CurrentState != null && !GlobalActorData.GetActorEntity(CricketMgrData.CricketGuid, out var _))
				{
					End();
				}
				else
				{
					CurrentState?.OnTick(DeltaTime);
				}
			}
		}

		public void TriggerNext()
		{
			if (bCanTriggerNext)
			{
				if (!States.TryGetValue(CurrentState.NextStateTag, out var value))
				{
					End();
					return;
				}
				CurrentState?.OnExit();
				CurStateTag = CurrentState.NextStateTag;
				CurrentState = value;
				CurrentState.OnEnter();
			}
		}

		public void TriggerExit()
		{
			End();
			ExitCallback();
		}

		public void ForceJumpToState(ECricketBehaviorStateTag StateTag)
		{
			if (States.TryGetValue(StateTag, out var value))
			{
				CurrentState?.OnExit();
				CurStateTag = StateTag;
				CurrentState = value;
				CurrentState.OnEnter();
			}
		}

		public void Pause()
		{
			bPaused = true;
		}

		public void Resume()
		{
			bPaused = false;
		}

		public void SetCanTriggerNext(bool bValue)
		{
			bCanTriggerNext = bValue;
		}
	}

	private abstract class CricketBehaviorStateBase
	{
		private CricketBehaviorStateMachine StateMachine;

		public abstract ECricketBehaviorStateTag NextStateTag { get; }

		protected BGUCricketMgrActor Manager { get; private set; }

		protected b1.IBUC_CricketMgrData CricketMgrData { get; private set; }

		public void Init(in BGUCricketMgrActor InManager, in b1.IBUC_CricketMgrData InCricketMgrData, in CricketBehaviorStateMachine InStateMachine)
		{
			Manager = InManager;
			CricketMgrData = InCricketMgrData;
			StateMachine = InStateMachine;
		}

		public virtual void OnEnter()
		{
		}

		public virtual void OnTick(float DeltaTime)
		{
		}

		public virtual void OnExit()
		{
		}

		protected void Next()
		{
			StateMachine?.TriggerNext();
		}

		protected void Exit()
		{
			StateMachine?.TriggerExit();
		}
	}

	private class CricketBehaviorState_Enter : CricketBehaviorStateBase
	{
		public override ECricketBehaviorStateTag NextStateTag => ECricketBehaviorStateTag.Jump;

		public override void OnEnter()
		{
			base.OnEnter();
			Next();
		}
	}

	private class CricketBehaviorState_Jump : CricketBehaviorStateBase
	{
		private IBUC_UnitStateData UnitStateData;

		public override ECricketBehaviorStateTag NextStateTag => ECricketBehaviorStateTag.MatchingPos;

		public override void OnEnter()
		{
			base.OnEnter();
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Manager, base.CricketMgrData.CricketGuid);
			if (!actorByGuid.IsNullOrDestroyed())
			{
				UnitStateData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(actorByGuid);
				int curPointIndex = base.CricketMgrData.CurPointIndex;
				if (curPointIndex < base.CricketMgrData.MovePointConfig.Count)
				{
					UAnimMontage jumpAnim = base.CricketMgrData.MovePointConfig[curPointIndex].JumpAnim;
					BGUFuncLibAnim.BGUActorTryPlayMontage(actorByGuid, jumpAnim, FName.None);
					BUS_EventCollectionCS.Get(base.Manager).Evt_CricketEnterJumpState.Invoke();
				}
			}
		}

		public override void OnTick(float DeltaTime)
		{
			base.OnTick(DeltaTime);
			if (UnitStateData == null || !UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				if (base.CricketMgrData.CurPointIndex == base.CricketMgrData.MovePointConfig.Count - 1)
				{
					Exit();
				}
				else
				{
					Next();
				}
			}
		}

		public override void OnExit()
		{
			base.OnExit();
			if (!BGU_DataUtil.GetActorByGuid(base.Manager, base.CricketMgrData.CricketGuid).IsNullOrDestroyed())
			{
				BUS_EventCollectionCS.Get(base.Manager).Evt_CricketMoveToNextPoint.Invoke();
			}
		}
	}

	private class CricketBehaviorState_MatchingPos : CricketBehaviorStateBase
	{
		private FTransform PointTrans;

		private float DefaultLerpTime = 0.25f;

		private float LerpAlpha;

		private float LerpTime;

		public override ECricketBehaviorStateTag NextStateTag => ECricketBehaviorStateTag.Idle;

		public override void OnEnter()
		{
			base.OnEnter();
			int curPointIndex = base.CricketMgrData.CurPointIndex;
			if (curPointIndex >= base.CricketMgrData.MovePointConfig.Count)
			{
				return;
			}
			PointTrans = base.CricketMgrData.MovePointConfig[curPointIndex].PointTrans;
			LerpTime = DefaultLerpTime;
			LerpAlpha = 0f;
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Manager, base.CricketMgrData.CricketGuid);
			if (!actorByGuid.IsNullOrDestroyed() && actorByGuid is ACharacter aCharacter)
			{
				int currentActiveMontageInstanceID = UGSE_AnimFuncLib.GetCurrentActiveMontageInstanceID(aCharacter);
				if (currentActiveMontageInstanceID > 0)
				{
					UGSE_AnimFuncLib.DisableMontageRootMotionByInstanceID(aCharacter, currentActiveMontageInstanceID);
					float animCurrentTime = UGSE_AnimFuncLib.GetAnimCurrentTime(aCharacter.Mesh?.GetAnimInstance(), currentActiveMontageInstanceID);
					float playLength = aCharacter.GetCurrentMontage().GetPlayLength();
					LerpTime = playLength - animCurrentTime;
				}
			}
		}

		public override void OnTick(float DeltaTime)
		{
			base.OnTick(DeltaTime);
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Manager, base.CricketMgrData.CricketGuid);
			if (actorByGuid.IsNullOrDestroyed())
			{
				return;
			}
			if (LerpAlpha >= 1f)
			{
				Next();
				return;
			}
			LerpAlpha += DeltaTime / LerpTime;
			if (LerpAlpha >= 1f)
			{
				LerpAlpha = 1f;
			}
			FTransform fTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(actorByGuid);
			FVector translation = FMath.Lerp(fTransform.GetLocation(), PointTrans.GetLocation(), LerpAlpha);
			FQuat rotation = FMath.Lerp(fTransform.GetRotation(), PointTrans.GetRotation(), LerpAlpha);
			BGUFuncLibActorTransformCS.BGUSetActorTransform(actorByGuid, new FTransform(rotation, translation), bSweep: false, bTeleport: true);
		}

		public override void OnExit()
		{
			base.OnExit();
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Manager, base.CricketMgrData.CricketGuid);
			if (!actorByGuid.IsNullOrDestroyed() && actorByGuid is ACharacter aCharacter)
			{
				aCharacter.CharacterMovement.StopMovementImmediately();
			}
		}
	}

	private class CricketBehaviorState_Idle : CricketBehaviorStateBase
	{
		private float IdleTime;

		private float Timer;

		private int WeaknessPointBuffID = 471101;

		public override ECricketBehaviorStateTag NextStateTag => ECricketBehaviorStateTag.Jump;

		public override void OnEnter()
		{
			base.OnEnter();
			int curPointIndex = base.CricketMgrData.CurPointIndex;
			if (curPointIndex >= base.CricketMgrData.MovePointConfig.Count)
			{
				return;
			}
			b1.CricketMovePointConfig cricketMovePointConfig = base.CricketMgrData.MovePointConfig[curPointIndex];
			if (base.CricketMgrData.InteractJumpCount == 0)
			{
				IdleTime = cricketMovePointConfig.IdleTime;
			}
			else if (base.CricketMgrData.InteractJumpCount == base.CricketMgrData.InteractMaxJumpCount)
			{
				IdleTime = base.CricketMgrData.WeakDuration;
				BUS_EventCollectionCS.Get(base.Manager).Evt_CricketStartWeakIdle.Invoke();
			}
			else
			{
				IdleTime = 0f;
			}
			Timer = 0f;
			if (IdleTime == 0f)
			{
				Next();
				return;
			}
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Manager, base.CricketMgrData.CricketGuid);
			if (!actorByGuid.IsNullOrDestroyed())
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_BuffAdd.Invoke(WeaknessPointBuffID, actorByGuid, actorByGuid, 0f);
					bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CricketIdle);
				}
			}
		}

		public override void OnTick(float DeltaTime)
		{
			base.OnTick(DeltaTime);
			Timer += DeltaTime;
			if (Timer >= IdleTime)
			{
				Next();
			}
		}

		public override void OnExit()
		{
			base.OnExit();
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Manager, base.CricketMgrData.CricketGuid);
			if (!actorByGuid.IsNullOrDestroyed())
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_BuffRemove.Invoke(WeaknessPointBuffID, EBuffEffectTriggerType.None, 1);
					bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CricketIdle, IsRemove: true);
				}
			}
		}
	}

	private CricketBehaviorStateMachine StateMachine;

	private IBUC_TargetInfoData CachedCricketTargetInfoData;

	private IBUC_InteractData CachedCricketInteractData;

	private static readonly int CricketTaskStageID = 9806001;

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	private b1.BUC_CricketMgrData CricketMgrData { get; set; }

	public override void OnAttach()
	{
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		CricketMgrData = RequireWritableData<b1.BUC_CricketMgrData>();
		base.BUSEventCollection.Evt_CricketMoveToNextPoint += new Del_Void(OnCricketMoveToNextPoint);
		base.BUSEventCollection.Evt_CricketEnterJumpState += new Del_Void(OnCricketEnterJumpState);
		base.BUSEventCollection.Evt_CricketStartWeakIdle += new Del_Void(OnCricketStartWeakIdle);
		base.BGSEventCollection.Evt_BGS_ResetActorDestroy += new Del_Void_String(OnResetActorDestroy);
		base.BGSEventCollection.Evt_NotifyTamerSpawnUnit += new Del_Void_String(OnTamerSpawnUnit);
		base.BGSEventCollection.Evt_PlayerEnterInteractWindow += new Del_Void(OnCricketEnterInteractWindow);
	}

	public override void PreBeginPlay()
	{
		Init();
	}

	public override void OnBeginPlay()
	{
		CricketMgrData.TrySpawnTimer = 1f;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BGSEventCollection.Evt_BGS_ResetActorDestroy -= new Del_Void_String(OnResetActorDestroy);
		base.BGSEventCollection.Evt_NotifyTamerSpawnUnit -= new Del_Void_String(OnTamerSpawnUnit);
		base.BGSEventCollection.Evt_PlayerEnterInteractWindow -= new Del_Void(OnCricketEnterInteractWindow);
	}

	private void UpdateAliveState()
	{
		if (CricketMgrData.AliveState == b1.ECricketAliveState.Dead)
		{
			return;
		}
		ReadOnlyQuestStageOneList readOnlyQuestStageOneList = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(UBGUFunctionLibrary.GetPlayerCharacter(Owner)?.GetController())?.RoleData?.RoleCs?.Task?.QuestList;
		if (readOnlyQuestStageOneList == null)
		{
			return;
		}
		foreach (ReadOnlyQuestStageOne item in readOnlyQuestStageOneList)
		{
			if (item.Id == CricketTaskStageID)
			{
				if (item.Stage == QuestStage.Finished)
				{
					CricketMgrData.AliveState = b1.ECricketAliveState.Dead;
				}
				else
				{
					CricketMgrData.AliveState = b1.ECricketAliveState.Alive;
				}
				break;
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		CheckForDestroy();
		StateMachine.OnTick(DeltaTime);
		TickTrySpawn(DeltaTime);
		TickDelaySpawn(DeltaTime);
		TickLeaveFight(DeltaTime);
	}

	private void TickLeaveFight(float DeltaTime)
	{
		if (CricketMgrData.CricketGuid.Length == 0)
		{
			CricketMgrData.LeaveFightTimer = 0f;
			return;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, CricketMgrData.CricketGuid);
		if (actorByGuid.IsNullOrDestroyed())
		{
			CricketMgrData.LeaveFightTimer = 0f;
			return;
		}
		AActor lockTargetActor = CachedCricketTargetInfoData.GetTargetInfo().LockTargetActor;
		if (lockTargetActor.IsNullOrDestroyed())
		{
			CricketMgrData.LeaveFightTimer = 0f;
		}
		else if (FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(actorByGuid), BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor)) > CricketMgrData.LeaveFightDistance)
		{
			if (CricketMgrData.LeaveFightTimer > 0f)
			{
				CricketMgrData.LeaveFightTimer -= DeltaTime;
				if (CricketMgrData.LeaveFightTimer <= 0f)
				{
					CricketMgrData.LeaveFightTimer = 0f;
					BUS_EventCollectionCS.Get(actorByGuid).Evt_OnLeaveFight.Invoke();
				}
			}
			else
			{
				CricketMgrData.LeaveFightTimer = CricketMgrData.LeaveFightDelayTime;
			}
		}
		else
		{
			CricketMgrData.LeaveFightTimer = 0f;
		}
	}

	private void OnResetActorDestroy(string UnitGuid)
	{
		if (UnitGuid.Equals(CricketMgrData.CricketGuid))
		{
			StateMachine.End();
			Reset();
			CricketMgrData.TrySpawnTimer = CricketMgrData.ReSpawnDelayTime;
		}
	}

	private void OnTamerSpawnUnit(string UnitGuid)
	{
		if (!UnitGuid.Equals(CricketMgrData.RequestSpawnCricketGuid))
		{
			return;
		}
		CricketMgrData.CricketGuid = UnitGuid;
		CricketMgrData.RequestSpawnCricketGuid = "";
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, CricketMgrData.CricketGuid);
		if (!actorByGuid.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			bUS_GSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, 0u, 0u, bSetDefaultProperty: false, "BUS_CricketMgrComp");
			bUS_GSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Capsule_CollisionEnabled, 0);
			bUS_GSEventCollection.Evt_AIPauseBT.Invoke(P1: true);
			bUS_GSEventCollection.Evt_AIPauseFsm.Invoke(P1: true);
			bUS_GSEventCollection.Evt_SetUnitWakeUpEnabled.Invoke(P1: false);
			bUS_GSEventCollection.Evt_CricketTriggerInteract += new Del_Void_String(OnCricketTriggerInteract);
			bUS_GSEventCollection.Evt_CricketBreakInteract += new Del_Void_String(OnCricketBreakInteract);
			bUS_GSEventCollection.Evt_CricketFinishInteract += new Del_Void_String(OnCricketFinishInteract);
			bUS_GSEventCollection.Evt_CricketJumpUp += new Del_Void_Bool(OnCricketJumpUp);
			bUS_GSEventCollection.Evt_FinishInteractCricketDisplay += new Del_Void(OnFinishInteractCricketDisplay);
			bUS_GSEventCollection.Evt_OnInteractActorDead += new Del_Void(OnInteractActorDead);
			bUS_GSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnCricketPlayMontageCallback);
			if (actorByGuid is ACharacter aCharacter)
			{
				b1.BUAnimSimple bUAnimSimple = aCharacter.Mesh?.GetAnimInstance() as b1.BUAnimSimple;
				if (bUAnimSimple != null)
				{
					CricketMgrData.DefaultAnimIdleList.Clear();
					foreach (UAnimSequence animIdle in bUAnimSimple.AnimIdleList)
					{
						CricketMgrData.DefaultAnimIdleList.Add(new TStrongObjectPtr<UAnimSequence>(animIdle));
					}
				}
			}
			CachedCricketTargetInfoData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(actorByGuid);
			CachedCricketInteractData = BGU_DataUtil.GetReadOnlyData<IBUC_InteractData, BUC_InteractData>(actorByGuid);
			if (CachedCricketTargetInfoData != null)
			{
				RecordRealDefaultInteractiveGroupID(CachedCricketInteractData.InteractiveUnitID);
			}
		}
		StateMachine.Start();
	}

	private void Init()
	{
		CricketMgrData.CurPointIndex = 0;
		CricketMgrData.TrySpawnCount = 0;
		CricketMgrData.TrySpawnTimer = 0f;
		CricketMgrData.SpawnDelayTimer = 0f;
		CricketMgrData.LeaveFightTimer = 0f;
		CricketMgrData.CricketGuid = "";
		CricketMgrData.RequestSpawnCricketGuid = "";
		CricketMgrData.bJumpUp = false;
		CricketMgrData.bKeepInteracting = false;
		CricketMgrData.bWeak = false;
		CricketMgrData.InteractActorGuid = "";
		CricketMgrData.InteractJumpCount = 0;
		CricketMgrData.DefaultAnimIdleList = new List<TStrongObjectPtr<UAnimSequence>>();
		CricketMgrData.bCricketPrepareInteract = false;
		CricketMgrData.AliveState = b1.ECricketAliveState.None;
		StateMachine = new CricketBehaviorStateMachine(Owner as BGUCricketMgrActor, OnStateMachineExit);
	}

	private void Reset()
	{
		if (GlobalActorData.GetActorEntity(CricketMgrData.CricketGuid, out var Entity))
		{
			AActor aActor = ECSExtension.ToActor(Entity);
			if (!aActor.IsNullOrDestroyed())
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
				bUS_GSEventCollection.Evt_CricketTriggerInteract -= new Del_Void_String(OnCricketTriggerInteract);
				bUS_GSEventCollection.Evt_CricketBreakInteract -= new Del_Void_String(OnCricketBreakInteract);
				bUS_GSEventCollection.Evt_CricketFinishInteract -= new Del_Void_String(OnCricketFinishInteract);
				bUS_GSEventCollection.Evt_CricketJumpUp -= new Del_Void_Bool(OnCricketJumpUp);
				bUS_GSEventCollection.Evt_FinishInteractCricketDisplay -= new Del_Void(OnFinishInteractCricketDisplay);
				bUS_GSEventCollection.Evt_OnInteractActorDead -= new Del_Void(OnInteractActorDead);
				bUS_GSEventCollection.Evt_PlayMontageCallback -= new Del_PlayMontageCallback(OnCricketPlayMontageCallback);
			}
		}
		CachedCricketTargetInfoData = null;
		CachedCricketInteractData = null;
		CricketMgrData.CurPointIndex = 0;
		CricketMgrData.TrySpawnTimer = 0f;
		CricketMgrData.SpawnDelayTimer = 0f;
		CricketMgrData.LeaveFightTimer = 0f;
		CricketMgrData.CricketGuid = "";
		CricketMgrData.RequestSpawnCricketGuid = "";
		CricketMgrData.bJumpUp = false;
		CricketMgrData.bKeepInteracting = false;
		CricketMgrData.bWeak = false;
		CricketMgrData.InteractActorGuid = "";
		CricketMgrData.InteractJumpCount = 0;
	}

	private void CheckForDestroy()
	{
		if (CricketMgrData.AliveState != b1.ECricketAliveState.Dead && !CricketMgrData.CricketGuid.Equals("") && !GlobalActorData.GetActorEntity(CricketMgrData.CricketGuid, out var _))
		{
			StateMachine.End();
			Reset();
			CricketMgrData.TrySpawnTimer = CricketMgrData.ReSpawnDelayTime;
		}
	}

	private void TickTrySpawn(float DeltaTime)
	{
		if (CricketMgrData.AliveState == b1.ECricketAliveState.Dead || !(CricketMgrData.TrySpawnTimer > 0f))
		{
			return;
		}
		CricketMgrData.TrySpawnTimer -= DeltaTime;
		if (!(CricketMgrData.TrySpawnTimer <= 0f))
		{
			return;
		}
		CricketMgrData.TrySpawnTimer = 0f;
		UpdateAliveState();
		switch (CricketMgrData.AliveState)
		{
		case b1.ECricketAliveState.Alive:
			if (!TrySpawn() && (CricketMgrData.TrySpawnMaxCount == 0 || CricketMgrData.TrySpawnCount < CricketMgrData.TrySpawnMaxCount))
			{
				CricketMgrData.TrySpawnTimer = CricketMgrData.ReSpawnDelayTime;
			}
			break;
		case b1.ECricketAliveState.Dead:
			Reset();
			break;
		case b1.ECricketAliveState.None:
			break;
		}
	}

	private void TickDelaySpawn(float DeltaTime)
	{
		if (CricketMgrData.AliveState != b1.ECricketAliveState.Dead && CricketMgrData.SpawnDelayTimer > 0f)
		{
			CricketMgrData.SpawnDelayTimer -= DeltaTime;
			if (CricketMgrData.SpawnDelayTimer <= 0f)
			{
				CricketMgrData.SpawnDelayTimer = 0f;
				TriggerSpawn();
			}
		}
	}

	private void TriggerSpawn()
	{
		if (CricketMgrData.AliveState != b1.ECricketAliveState.Dead && CricketMgrData.MovePointConfig.Count != 0 && CricketMgrData.CricketGuid.Equals("") && CricketMgrData.RequestSpawnCricketGuid.Equals(""))
		{
			CricketMgrData.RequestSpawnCricketGuid = BGU_UnrealWorldUtil.RequestSpawnUnit(Owner.World, CricketMgrData.CricketTamer, CricketMgrData.MovePointConfig[0].PointTrans, Owner);
		}
	}

	private bool TrySpawn()
	{
		if (ShouldSpawn())
		{
			CricketMgrData.SpawnDelayTimer = FMath.FRandRange(CricketMgrData.SpawnDelayTimeRange.X, CricketMgrData.SpawnDelayTimeRange.Y);
			return true;
		}
		return false;
	}

	private void OnStateMachineExit()
	{
		BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(Owner, CricketMgrData.CricketGuid))?.Evt_UnitDead.Invoke(null, EDeadReason.OnlyDestroyUnit);
		Reset();
		CricketMgrData.TrySpawnTimer = CricketMgrData.ReSpawnDelayTime;
	}

	private bool ShouldSpawn()
	{
		if (CricketMgrData.AliveState == b1.ECricketAliveState.Dead)
		{
			return false;
		}
		if (CricketMgrData.TrySpawnMaxCount > 0 && CricketMgrData.TrySpawnCount++ >= CricketMgrData.TrySpawnMaxCount)
		{
			return false;
		}
		if (CricketMgrData.SpawnProbability.Equals(0f))
		{
			return false;
		}
		if (CricketMgrData.SpawnProbability.Equals(1f))
		{
			return true;
		}
		if (FMath.FRand() <= CricketMgrData.SpawnProbability)
		{
			return true;
		}
		return false;
	}

	private void OnCricketMoveToNextPoint()
	{
		CricketMgrData.CurPointIndex++;
	}

	private void OnCricketEnterJumpState()
	{
		ACharacter aCharacter = BGU_DataUtil.GetActorByGuid(Owner, CricketMgrData.CricketGuid) as ACharacter;
		if (aCharacter.IsNullOrDestroyed())
		{
			return;
		}
		if ((CricketMgrData.InteractMaxJumpCount == 0 || CricketMgrData.InteractJumpCount != CricketMgrData.InteractMaxJumpCount) && CricketMgrData.CurPointIndex + 1 < CricketMgrData.MovePointConfig.Count)
		{
			List<TStrongObjectPtr<UAnimSequence>> animIdleList = CricketMgrData.MovePointConfig[CricketMgrData.CurPointIndex + 1].AnimIdleList;
			b1.BUAnimSimple bUAnimSimple = aCharacter.Mesh?.GetAnimInstance() as b1.BUAnimSimple;
			if (bUAnimSimple != null)
			{
				bUAnimSimple.AnimIdleList.Clear();
				foreach (TStrongObjectPtr<UAnimSequence> item in (animIdleList.Count > 0) ? animIdleList : CricketMgrData.DefaultAnimIdleList)
				{
					if (item != null && item.IsValid())
					{
						bUAnimSimple.AnimIdleList.Add(item.Get());
					}
				}
			}
		}
		TriggerInteractActorJumpAnim();
		if (!CricketMgrData.bKeepInteracting)
		{
			CricketMgrData.InteractJumpCount = 0;
			CricketMgrData.bWeak = false;
			if (CachedCricketInteractData.ActionGroupID != CricketMgrData.RealDefaultInteractiveGroupID)
			{
				base.BGWEventCollection?.Evt_SendUpdateInteractGroup?.Invoke(CricketMgrData.CricketGuid, CricketMgrData.RealDefaultInteractiveGroupID);
			}
			SwitchQTEInteractState(IsShow: false);
		}
		else if (CricketMgrData.InteractJumpCount == CricketMgrData.InteractMaxJumpCount)
		{
			b1.BUAnimSimple bUAnimSimple2 = aCharacter.Mesh?.GetAnimInstance() as b1.BUAnimSimple;
			if (bUAnimSimple2 != null)
			{
				bUAnimSimple2.AnimIdleList.Clear();
				bUAnimSimple2.AnimIdleList.Add(CricketMgrData.ASWeakIdle);
			}
		}
	}

	private void OnCricketTriggerInteract(string InteractActorGuid)
	{
		if (CachedCricketInteractData.InteractinputTime == 0f)
		{
			return;
		}
		CricketMgrData.InteractActorGuid = InteractActorGuid;
		if (!GlobalActorData.GetActorEntity(InteractActorGuid, out var Entity))
		{
			return;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, CricketMgrData.CricketGuid);
		AActor aActor = ECSExtension.ToActor(Entity);
		if (aActor.IsNullOrDestroyed())
		{
			return;
		}
		CricketMgrData.bKeepInteracting = true;
		CricketMgrData.InteractJumpCount = 0;
		BUS_EventCollectionCS.Get(aActor)?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.SkillBreak, 0f);
		if (CricketMgrData.bWeak)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(actorByGuid, CricketMgrData.InteractConfig.AMCricketPrepareInteractLoop, FName.None);
				bUS_GSEventCollection.Evt_UpdateDummyMeshInSyncAnimation.Invoke(new FName(CricketMgrData.InteractConfig.CricketSocketName), new FName(CricketMgrData.InteractConfig.DummyMeshSocketName), CricketMgrData.InteractConfig.AnimDummyMeshPrepareInteractLoop);
			}
			BGUFuncLibAnim.BGUActorTryPlayMontage(aActor, CricketMgrData.InteractConfig.AMPlayerPrepareInteractLoop, FName.None);
		}
		else
		{
			StateMachine.Resume();
			StateMachine.ForceJumpToState(ECricketBehaviorStateTag.Jump);
		}
	}

	private void OnCricketBreakInteract(string InteractActorGuid)
	{
		if (CachedCricketInteractData.InteractinputTime == 0f || !GlobalActorData.GetActorEntity(InteractActorGuid, out var Entity))
		{
			return;
		}
		AActor aActor = ECSExtension.ToActor(Entity);
		if (aActor.IsNullOrDestroyed())
		{
			return;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, CricketMgrData.CricketGuid);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
		if (bUS_GSEventCollection != null)
		{
			if (CricketMgrData.bJumpUp)
			{
				bUS_GSEventCollection.Evt_StopSkillSequenceWithBlendOutTime.Invoke(CricketMgrData.InteractConfig.FallDownCameraBlendOutTime);
			}
			else
			{
				bUS_GSEventCollection.Evt_StopSkillSequence.Invoke();
			}
		}
		if (CricketMgrData.bWeak)
		{
			StateMachine.SetCanTriggerNext(bValue: true);
			CricketMgrData.InteractActorGuid = "";
			CricketMgrData.InteractJumpCount = 0;
			if (bUS_GSEventCollection != null)
			{
				base.BGWEventCollection?.Evt_SendUpdateInteractGroup?.Invoke(CricketMgrData.CricketGuid, CricketMgrData.RealDefaultInteractiveGroupID);
				bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.SkillBreak, 0f);
				base.BGSEventCollection.Evt_BGS_EndInteractSyncAnimation.Invoke(actorByGuid, P1: true);
				BGUFuncLibAnim.BGUActorTryPlayMontage(actorByGuid, CricketMgrData.InteractConfig.AMCricketPrepareInteractBreak, FName.None);
			}
			BUS_GSEventCollection bUS_GSEventCollection2 = BUS_EventCollectionCS.Get(aActor);
			if (bUS_GSEventCollection2 != null)
			{
				bUS_GSEventCollection2.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.SkillBreak, 0f);
			}
			BGUFuncLibAnim.BGUActorTryPlayMontage(aActor, CricketMgrData.InteractConfig.AMPlayerPrepareInteractBreak, FName.None);
		}
		else if (CricketMgrData.bJumpUp)
		{
			TriggerInteractActorFallDown(aActor);
			CricketMgrData.InteractActorGuid = "";
			CricketMgrData.InteractJumpCount = 0;
			if (CachedCricketInteractData.ActionGroupID != CricketMgrData.RealDefaultInteractiveGroupID)
			{
				base.BGWEventCollection?.Evt_SendUpdateInteractGroup?.Invoke(CricketMgrData.CricketGuid, CricketMgrData.RealDefaultInteractiveGroupID);
			}
		}
		CricketMgrData.bKeepInteracting = false;
	}

	private void TriggerInteractActorFallDown(AActor InteractActor)
	{
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, CricketMgrData.CricketGuid);
		base.BGSEventCollection.Evt_BGS_EndInteractSyncAnimation.Invoke(actorByGuid, P1: true);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(InteractActor);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.SkillBreak, 0f);
		}
		BGUFuncLibAnim.BGUActorTryPlayMontage(InteractActor, CricketMgrData.InteractConfig.AMPlayerFallDown, FName.None);
	}

	private void OnCricketFinishInteract(string InteractActorGuid)
	{
		if (!GlobalActorData.GetActorEntity(InteractActorGuid, out var Entity))
		{
			return;
		}
		AActor aActor = ECSExtension.ToActor(Entity);
		if (aActor.IsNullOrDestroyed())
		{
			return;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, CricketMgrData.CricketGuid);
		if (CachedCricketInteractData.InteractinputTime > 0f)
		{
			if (CricketMgrData.bWeak)
			{
				OnInteractCricketSuccess();
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
				if (bUS_GSEventCollection != null)
				{
					base.BGSEventCollection.Evt_BGS_EndInteractSyncAnimation.Invoke(actorByGuid, P1: true);
					bUS_GSEventCollection.Evt_StopSkillSequence.Invoke();
				}
				BUS_EventCollectionCS.Get(aActor)?.Evt_OnInteractCricketSuccess.Invoke();
			}
			else
			{
				CricketMgrData.bKeepInteracting = false;
			}
			return;
		}
		CricketMgrData.InteractActorGuid = InteractActorGuid;
		CricketMgrData.InteractJumpCount = 0;
		if (!CricketMgrData.bWeak)
		{
			StateMachine.Pause();
		}
		else
		{
			StateMachine.SetCanTriggerNext(bValue: false);
		}
		BUS_GSEventCollection bUS_GSEventCollection2 = BUS_EventCollectionCS.Get(actorByGuid);
		if (bUS_GSEventCollection2 != null)
		{
			bUS_GSEventCollection2.Evt_SwitchNoInteraction.Invoke(P1: false);
			CricketMgrData.bCricketPrepareInteract = true;
			BGUFuncLibAnim.BGUActorTryPlayMontage(actorByGuid, CricketMgrData.InteractConfig.AMCricketPrepareInteract, FName.None, EMontageBindReason.InteractCricket);
			BGS_EventCollectionCS.Get(actorByGuid).Evt_BGS_BeginInteractSyncAnimation.Invoke(actorByGuid, aActor, new FName(CricketMgrData.InteractConfig.CricketSocketName), new FName(CricketMgrData.InteractConfig.DummyMeshSocketName), CricketMgrData.InteractConfig.AnimDummyMeshPrepareInteract);
			FSkillSequencePlaySettings playSettings = new FSkillSequencePlaySettings
			{
				SequenceList = new List<ULevelSequence>(),
				SequenceCameraTransforms = new List<FTransform>(),
				bAttachToUnit = true,
				DummyMeshAttachSocketName = new FName(CricketMgrData.InteractConfig.CameraAttachSocketName1),
				AttachedCameraFOV = 46f,
				InCameraBlendFactor = 1.5f,
				InCameraBlendTime = CricketMgrData.InteractConfig.CameraBlendInTime,
				OutCameraBlendFactor = 1.5f,
				OutCameraBlendTime = CricketMgrData.InteractConfig.CameraBlendOutTime,
				bEnableCameraAutoBlendOut = true,
				bStopWhenMontageInterrupted = false
			};
			bUS_GSEventCollection2.Evt_PlaySkillSequence.Invoke(playSettings);
		}
		BUS_EventCollectionCS.Get(aActor)?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, -1f);
		BUS_EventCollectionCS.Get(aActor)?.Evt_BreakInteract.Invoke();
		BGUFuncLibAnim.BGUActorTryPlayMontage(aActor, CricketMgrData.InteractConfig.AMPlayerPrepareInteract, FName.None);
	}

	private void OnInteractCricketSuccess()
	{
	}

	private void OnCricketStartWeakIdle()
	{
		if (!GlobalActorData.GetActorEntity(CricketMgrData.InteractActorGuid, out var Entity))
		{
			return;
		}
		AActor aActor = ECSExtension.ToActor(Entity);
		if (!aActor.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(Owner, CricketMgrData.CricketGuid));
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UpdateDummyMeshInSyncAnimation.Invoke(new FName(CricketMgrData.InteractConfig.CricketSocketName), new FName(CricketMgrData.InteractConfig.DummyMeshSocketName), CricketMgrData.InteractConfig.AnimDummyMeshFinishInteract);
				base.BGWEventCollection?.Evt_SendUpdateInteractGroup?.Invoke(CricketMgrData.CricketGuid, CricketMgrData.RealDefaultInteractiveGroupID);
			}
			BUS_EventCollectionCS.Get(aActor)?.Evt_OnCricketStartWeakIdle.Invoke(CricketMgrData.InteractConfig.AMPlayerFinishInteract);
			CricketMgrData.bKeepInteracting = false;
			CricketMgrData.InteractActorGuid = "";
			CricketMgrData.bWeak = true;
		}
	}

	private void OnCricketEnterInteractWindow()
	{
		if (CricketMgrData.bCricketPrepareInteract)
		{
			BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(Owner, CricketMgrData.CricketGuid));
			int p = (CricketMgrData.bWeak ? CricketMgrData.WeakLongPressInteractGroupID : CricketMgrData.NormalLongPressInteractGroupID);
			base.BGWEventCollection.Evt_SendUpdateInteractGroup(CricketMgrData.CricketGuid, p);
			SwitchQTEInteractState(IsShow: true);
		}
	}

	private void OnCricketJumpUp(bool bJumpUpStart)
	{
		CricketMgrData.bJumpUp = bJumpUpStart;
		if (CricketMgrData.InteractActorGuid.Equals("") || !GlobalActorData.GetActorEntity(CricketMgrData.InteractActorGuid, out var Entity))
		{
			return;
		}
		AActor aActor = ECSExtension.ToActor(Entity);
		if (aActor.IsNullOrDestroyed())
		{
			return;
		}
		if (!bJumpUpStart)
		{
			if (CricketMgrData.bKeepInteracting && CricketMgrData.InteractJumpCount == 1)
			{
				BUS_EventCollectionCS.Get(aActor)?.Evt_SyncCameraSwitchSyncPoint.Invoke(new FName(CricketMgrData.InteractConfig.CameraAttachSocketName2), 0.2f);
			}
		}
		else if (!CricketMgrData.bKeepInteracting)
		{
			TriggerInteractActorFallDown(aActor);
			CricketMgrData.InteractActorGuid = "";
		}
		else if (CricketMgrData.CurPointIndex == CricketMgrData.MovePointConfig.Count - 1)
		{
			BPS_EventCollectionCS.Get(aActor.GetInstigatorController() as APlayerController)?.Evt_BPS_BreakInteract.Invoke();
		}
	}

	private void TriggerInteractActorJumpAnim()
	{
		if (CricketMgrData.InteractActorGuid.Equals("") || !GlobalActorData.GetActorEntity(CricketMgrData.InteractActorGuid, out var Entity))
		{
			return;
		}
		AActor aActor = ECSExtension.ToActor(Entity);
		if (!aActor.IsNullOrDestroyed())
		{
			b1.BUC_CricketMgrData cricketMgrData = CricketMgrData;
			int interactJumpCount = cricketMgrData.InteractJumpCount + 1;
			cricketMgrData.InteractJumpCount = interactJumpCount;
			UAnimMontage montage = null;
			UAnimationAsset dummyMeshAnimation = null;
			if (CricketMgrData.InteractJumpCount <= CricketMgrData.InteractMaxJumpCount)
			{
				FCricketJumpPlayerAnimConfig fCricketJumpPlayerAnimConfig = CricketMgrData.InteractConfig.JumpAnimConfig[CricketMgrData.InteractJumpCount - 1];
				montage = fCricketJumpPlayerAnimConfig.AMPlayerJump;
				dummyMeshAnimation = fCricketJumpPlayerAnimConfig.AnimDummyMeshJump;
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(Owner, CricketMgrData.CricketGuid));
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UpdateDummyMeshInSyncAnimation.Invoke(new FName(CricketMgrData.InteractConfig.CricketSocketName), new FName(CricketMgrData.InteractConfig.DummyMeshSocketName), dummyMeshAnimation);
			}
			BGUFuncLibAnim.BGUActorTryPlayMontage(aActor, montage, FName.None);
		}
	}

	private void OnFinishInteractCricketDisplay()
	{
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, CricketMgrData.CricketGuid);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
		if (bUS_GSEventCollection != null)
		{
			base.BGSEventCollection.Evt_BGS_EndInteractSyncAnimation.Invoke(actorByGuid, P1: true);
			bUS_GSEventCollection.Evt_StopSkillSequence.Invoke();
		}
	}

	private void OnCricketPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (Reason == EMontageBindReason.InteractCricket && (State == EMontageCallbackState.OnBlendOut || State == EMontageCallbackState.OnInterrupted) && Montage == CricketMgrData.InteractConfig.AMCricketPrepareInteract)
		{
			OnCricketPrepareInputFinish();
		}
	}

	private void OnCricketPrepareInputFinish()
	{
		if (!CricketMgrData.bCricketPrepareInteract)
		{
			return;
		}
		CricketMgrData.bCricketPrepareInteract = false;
		if (CricketMgrData.bKeepInteracting || !GlobalActorData.GetActorEntity(CricketMgrData.InteractActorGuid, out var Entity))
		{
			return;
		}
		AActor aActor = ECSExtension.ToActor(Entity);
		if (aActor.IsNullOrDestroyed())
		{
			return;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, CricketMgrData.CricketGuid);
		if (CricketMgrData.bWeak)
		{
			StateMachine.SetCanTriggerNext(bValue: true);
			CricketMgrData.InteractActorGuid = "";
			CricketMgrData.InteractJumpCount = 0;
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null)
			{
				base.BGWEventCollection?.Evt_SendUpdateInteractGroup?.Invoke(CricketMgrData.CricketGuid, CricketMgrData.RealDefaultInteractiveGroupID);
				base.BGSEventCollection.Evt_BGS_EndInteractSyncAnimation.Invoke(actorByGuid, P1: true);
				bUS_GSEventCollection.Evt_StopSkillSequence.Invoke();
				BGUFuncLibAnim.BGUActorTryPlayMontage(actorByGuid, CricketMgrData.InteractConfig.AMCricketPrepareInteractBreak, FName.None);
			}
			BUS_EventCollectionCS.Get(aActor)?.Evt_OnCricketPrepareInteractFinish.Invoke(CricketMgrData.InteractConfig.AMPlayerPrepareInteractBreak);
			SwitchQTEInteractState(IsShow: false);
		}
		else
		{
			if (StateMachine.CurStateTag != ECricketBehaviorStateTag.Jump)
			{
				StateMachine.Resume();
				StateMachine.ForceJumpToState(ECricketBehaviorStateTag.Jump);
			}
			BUS_EventCollectionCS.Get(actorByGuid)?.Evt_StopSkillSequence.Invoke();
			BUS_EventCollectionCS.Get(aActor)?.Evt_OnCricketPrepareInteractFinish.Invoke(null);
		}
	}

	private void OnInteractActorDead()
	{
		if (CricketMgrData.bKeepInteracting && CricketMgrData.bWeak)
		{
			StateMachine.Pause();
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, CricketMgrData.CricketGuid);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(actorByGuid, CricketMgrData.InteractConfig.AMCricketInteractFail, FName.None);
				bUS_GSEventCollection.Evt_StopSkillSequence.Invoke();
				base.BGWEventCollection?.Evt_SendUpdateInteractGroup?.Invoke(CricketMgrData.CricketGuid, CricketMgrData.RealDefaultInteractiveGroupID);
				bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.SkillBreak, 0f);
				base.BGSEventCollection.Evt_BGS_EndInteractSyncAnimation.Invoke(actorByGuid, P1: true);
			}
			CricketMgrData.bKeepInteracting = false;
			CricketMgrData.bWeak = false;
			if (CricketMgrData.InteractConfig.InteractFailCameraSequenceID > 0)
			{
				FMovieSceneSequencePlaybackSettings playbackSettings = new FMovieSceneSequencePlaybackSettings
				{
					AutoPlay = false,
					PlayRate = 1f,
					StartTime = 0f,
					RandomStartTime = false,
					RestoreState = false,
					DisableMovementInput = true,
					DisableLookAtInput = true,
					HidePlayer = false,
					HideHud = true,
					DisableCameraCuts = false,
					PauseAtEnd = false
				};
				FLevelSequenceCameraSettings cameraSettings = new FLevelSequenceCameraSettings
				{
					AspectRatioAxisConstraint = EAspectRatioAxisConstraint.AspectRatio_MaintainXFOV,
					OverrideAspectRatioAxisConstraint = false
				};
				FMovieGraphPlaySettings inPlaySettings = new FMovieGraphPlaySettings
				{
					PlaybackSettings = playbackSettings,
					CameraSettings = cameraSettings,
					bUsePlayerCamera = false
				};
				BGS_EventCollectionCS.Get(Owner).Evt_PlayMovieInstance.Invoke(CricketMgrData.InteractConfig.InteractFailCameraSequenceID, MovieInstance.Create(Owner, CricketMgrData.InteractConfig.InteractFailCameraSequenceID, inPlaySettings));
			}
		}
	}

	private void SwitchQTEInteractState(bool IsShow)
	{
		if (IsShow)
		{
			if (CricketMgrData.bWeak)
			{
				BGW_EventCollection.Get(Owner)?.Evt_ActiveQTEInteractUI?.Invoke(P1: true, 1);
			}
			else
			{
				BGW_EventCollection.Get(Owner)?.Evt_ActiveQTEInteractUI?.Invoke(P1: true, 3);
			}
		}
		else
		{
			BGW_EventCollection.Get(Owner)?.Evt_ActiveQTEInteractUI?.Invoke(P1: false, 0);
		}
	}

	private void RecordRealDefaultInteractiveGroupID(int InteractiveUnitID)
	{
		if (CricketMgrData == null)
		{
			BGW_LogUtil.LogError("[BUS_CricketMgrComp] RecordRealDefaultInteractiveGroupID CricketMgrData == null!");
			return;
		}
		CricketMgrData.RealDefaultInteractiveGroupID = -1;
		if (InteractiveUnitID <= 0)
		{
			BGW_LogUtil.LogError("[BUS_CricketMgrComp] RecordRealDefaultInteractiveGroupID InteractiveUnitID <= 0!");
			return;
		}
		FUStInteractiveUnitCommDesc interactiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(InteractiveUnitID);
		if (interactiveUnitCommDesc == null)
		{
			BGW_LogUtil.LogError($"[BUS_CricketMgrComp] RecordRealDefaultInteractiveGroupID InteractiveUnitID:{InteractiveUnitID} Desc == null!");
		}
		else
		{
			CricketMgrData.RealDefaultInteractiveGroupID = interactiveUnitCommDesc.DefaultTask;
		}
	}
}
