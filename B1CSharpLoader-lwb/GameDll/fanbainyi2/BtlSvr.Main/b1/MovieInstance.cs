using System;
using System.Collections.Generic;
using System.Globalization;
using ArchiveB1;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using b1.Plugins.Calliope;
using b1.Plugins.ConsoleVariableManager;
using BtlB1;
using BtlShare;
using GUR.Runtime;
using ResB1;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Plugins.SequencerScripting;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieInstance")]
public sealed class MovieInstance : UObject
{
	public enum EMoviePlayEvent
	{
		None,
		Next,
		Back2Previous,
		Back2Parent,
		StartGraph,
		WarmingUp,
		Exception,
		PlayStart,
		PlayCut,
		PlayPreRoll,
		Skip,
		Pause,
		Stop,
		Resume,
		Shutdown,
		Match2PointA,
		Orientate2PointA,
		StartPrePlay,
		StartPreRoll,
		StartPlayProcess,
		PointAStop
	}

	[InstanceFactory]
	public abstract class MovieStateBase
	{
		[FactoryKey]
		public abstract EMoviePlayState StateTag { get; }

		private Dictionary<EMoviePlayEvent, EMoviePlayState> TransitionMap { get; } = new Dictionary<EMoviePlayEvent, EMoviePlayState>();

		private HashSet<int> MovieEnterRecord { get; } = new HashSet<int>();

		private Dictionary<int, EMoviePlayState> PreviousStateMap { get; } = new Dictionary<int, EMoviePlayState>();

		private Dictionary<EMoviePlayEvent, EMoviePlayEvent> EventConvertMap { get; } = new Dictionary<EMoviePlayEvent, EMoviePlayEvent>();

		private EMoviePlayState ParentState { get; set; }

		private static List<EMoviePlayState> MainNextSequence { get; }

		public void NotifyShutdown(MovieInstance InInstance)
		{
			Shutdown(InInstance);
		}

		public void TransitionByEvent(MovieInstance InInstance, EMoviePlayEvent InEvent, bool bFinished)
		{
			EMoviePlayEvent eMoviePlayEvent = InEvent;
			if (EventConvertMap.TryGetValue(InEvent, out var value))
			{
				eMoviePlayEvent = value;
			}
			EMoviePlayState value3;
			if (eMoviePlayEvent == EMoviePlayEvent.Back2Previous && PreviousStateMap.TryGetValue(InInstance.MovieId, out var value2))
			{
				GotoState(InInstance, value2, bFinished);
			}
			else if (eMoviePlayEvent == EMoviePlayEvent.Back2Parent && ParentState != EMoviePlayState.None)
			{
				GotoState(InInstance, ParentState, bFinished);
			}
			else if (TransitionMap.TryGetValue(eMoviePlayEvent, out value3))
			{
				GotoState(InInstance, value3, bFinished);
			}
		}

		public virtual void OnSequencePlayFinished(MovieInstance InInstance)
		{
		}

		public virtual void OnProcessFinished(MovieInstance InInstance)
		{
		}

		public virtual void Jump2MarkedFrame(MovieInstance InInstance, string InMarkedFrameLabel)
		{
		}

		public virtual void OnBlendPositionFinished(MovieInstance InInstance, bool Success)
		{
		}

		public virtual void OnBlendCameraComplete(MovieInstance InInstance)
		{
		}

		protected void RegisterEventTransition(EMoviePlayEvent InEvent, EMoviePlayState InTransitionState)
		{
			TransitionMap[InEvent] = InTransitionState;
		}

		protected void RegisterParentState(EMoviePlayState InParentState)
		{
			ParentState = InParentState;
		}

		protected void RegisterEventConvert(EMoviePlayEvent InEvent, EMoviePlayEvent OutEvent)
		{
			EventConvertMap[InEvent] = OutEvent;
		}

		public bool CanBeSkip(MovieInstance InInstance)
		{
			if (TransitionMap.ContainsKey(EMoviePlayEvent.Skip) && InInstance.bCanSkip && InInstance.IsLoadFinished())
			{
				return GSGameplayCVar.CVar_CanSkipSeq.GetValueInGameThread() > 0;
			}
			return false;
		}

		public bool IsPlaying(MovieInstance InInstance)
		{
			if (StateTag != EMoviePlayState.PlayingProcess)
			{
				return StateTag == EMoviePlayState.WarmingUpPlaying;
			}
			return true;
		}

		protected virtual void Next(MovieInstance InInstance)
		{
			TransitionByEvent(InInstance, EMoviePlayEvent.Next, bFinished: true);
		}

		protected void Back2Previous(MovieInstance InInstance)
		{
			TransitionByEvent(InInstance, EMoviePlayEvent.Back2Previous, bFinished: true);
		}

		protected void Back2Parent(MovieInstance InInstance)
		{
			TransitionByEvent(InInstance, EMoviePlayEvent.Back2Parent, bFinished: true);
		}

		protected virtual void Init()
		{
		}

		protected virtual void Enter(MovieInstance InInstance)
		{
			Next(InInstance);
		}

		protected virtual void Exit(MovieInstance InInstance)
		{
		}

		protected virtual void Tick(MovieInstance InInstance, float InDeltaTime)
		{
		}

		protected virtual void ReEnter(MovieInstance InInstance, EMoviePlayState InPreviousState)
		{
		}

		protected virtual void Finish(MovieInstance InInstance)
		{
		}

		protected virtual void Shutdown(MovieInstance InInstance)
		{
			TransitionByEvent(InInstance, EMoviePlayEvent.Shutdown, bFinished: true);
		}

		private void NotifyInit()
		{
			Init();
		}

		private void NotifyEnter(MovieInstance InInstance, EMoviePlayState PreviousState)
		{
			MovieEnterRecord.Add(InInstance.MovieId);
			PreviousStateMap[InInstance.MovieId] = PreviousState;
			InInstance.CurrentState = this;
			Enter(InInstance);
		}

		private void NotifyExit(MovieInstance InInstance)
		{
			Exit(InInstance);
		}

		public void NotifyTick(MovieInstance InInstance, float InDeltaTime)
		{
			Tick(InInstance, InDeltaTime);
		}

		private void NotifyReEnter(MovieInstance InInstance, EMoviePlayState PreviousState)
		{
			InInstance.CurrentState = this;
			ReEnter(InInstance, PreviousState);
		}

		private void NotifyFinish(MovieInstance InInstance)
		{
			Finish(InInstance);
			MovieEnterRecord.Remove(InInstance.MovieId);
			PreviousStateMap.Remove(InInstance.MovieId);
		}

		private void GotoState(MovieInstance InInstance, EMoviePlayState InStateTag, bool bFinished)
		{
			if (TryGetState(InStateTag, out var OutState))
			{
				NotifyExit(InInstance);
				if (OutState.MovieEnterRecord.Contains(InInstance.MovieId))
				{
					OutState.NotifyReEnter(InInstance, StateTag);
				}
				else
				{
					OutState.NotifyEnter(InInstance, StateTag);
				}
				if (bFinished)
				{
					NotifyFinish(InInstance);
				}
			}
		}

		public static MovieStateBase Get(EMoviePlayState InStateTag)
		{
			return FMovieStateFactory.GetInstance(InStateTag);
		}

		private static bool TryGetState(EMoviePlayState InStateTag, out MovieStateBase OutState)
		{
			OutState = Get(InStateTag);
			return OutState != null;
		}

		static MovieStateBase()
		{
			MainNextSequence = new List<EMoviePlayState>
			{
				EMoviePlayState.PlayingProcess,
				EMoviePlayState.Stopping,
				EMoviePlayState.PostPlayProcess,
				EMoviePlayState.Finished
			};
			FMovieStateFactory.GetAllInstances(out var OutAllInstances);
			foreach (KeyValuePair<EMoviePlayState, MovieStateBase> item in OutAllInstances)
			{
				MovieStateBase value = item.Value;
				if (value.StateTag != EMoviePlayState.Finished)
				{
					value.RegisterEventTransition(EMoviePlayEvent.Shutdown, EMoviePlayState.Finished);
				}
				value.NotifyInit();
			}
			for (int i = 0; i < MainNextSequence.Count - 1; i++)
			{
				Get(MainNextSequence[i])?.RegisterEventTransition(EMoviePlayEvent.Next, MainNextSequence[i + 1]);
			}
		}
	}

	public class MovieState_Idle : MovieStateBase
	{
		public override EMoviePlayState StateTag => EMoviePlayState.Idle;

		protected override void Init()
		{
			RegisterEventConvert(EMoviePlayEvent.StartGraph, EMoviePlayEvent.Next);
			RegisterEventTransition(EMoviePlayEvent.Next, EMoviePlayState.PoseTurnBack);
		}

		public void NotifyEnterForIdle(MovieInstance InInstance)
		{
			Enter(InInstance);
		}

		protected override void Enter(MovieInstance InInstance)
		{
			InInstance.BGSEventCollection.Evt_NotifyMovieBegin.Invoke(InInstance.SequenceId, InInstance.MovieId);
			InInstance.TemplateAsset.StartInstance();
		}
	}

	public class MovieState_PoseTurnBack : MovieStateBase
	{
		private enum EPlayerPoseType
		{
			None,
			Idle,
			Walking,
			Running,
			Jumping,
			Sprinting,
			Charging,
			BeAttacked,
			Attacking,
			Exception
		}

		public override EMoviePlayState StateTag => EMoviePlayState.PoseTurnBack;

		protected override void Init()
		{
			RegisterEventTransition(EMoviePlayEvent.Exception, EMoviePlayState.ExceptionProcess);
			RegisterEventTransition(EMoviePlayEvent.StartPrePlay, EMoviePlayState.PrePlayProcess);
			RegisterEventTransition(EMoviePlayEvent.Match2PointA, EMoviePlayState.Matching2PointA);
			RegisterEventTransition(EMoviePlayEvent.Orientate2PointA, EMoviePlayState.Orientating2PointA);
		}

		protected override void Next(MovieInstance InInstance)
		{
			if (!string.IsNullOrEmpty(InInstance.OverlapGuid))
			{
				switch (InInstance.MatchingPosType)
				{
				case ESequenceBlendInMatchPositionType.OnePoint:
				case ESequenceBlendInMatchPositionType.TwoPoint:
					TransitionByEvent(InInstance, EMoviePlayEvent.Match2PointA, bFinished: true);
					return;
				case ESequenceBlendInMatchPositionType.Ori2PointA:
					TransitionByEvent(InInstance, EMoviePlayEvent.Orientate2PointA, bFinished: true);
					return;
				}
			}
			TransitionByEvent(InInstance, EMoviePlayEvent.StartPrePlay, bFinished: true);
		}

		protected override void Enter(MovieInstance InInstance)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(InInstance.PlayerController.GetControlledPawn());
			if (!InInstance.bDisableCameraCut)
			{
				ClearWukongStates(InInstance);
				bUS_GSEventCollection?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantTransInSeq);
				BPS_EventCollectionCS.Get(InInstance.PlayerController)?.Evt_BPS_BeginCinematicIgnoreMode.Invoke(InInstance.PlaySettings.PlaybackSettings.DisableMovementInput, InInstance.PlaySettings.PlaybackSettings.DisableLookAtInput, P3: true);
				if (InInstance.MatchingPosType != ESequenceBlendInMatchPositionType.None)
				{
					bUS_GSEventCollection?.Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.PerformerTag.Event_PreShow);
				}
			}
			if (!InInstance.bNeedPauseAfterPlaying)
			{
				if (string.IsNullOrEmpty(InInstance.OverlapGuid))
				{
					Next(InInstance);
					return;
				}
				bUS_GSEventCollection?.Evt_ClearCameraLock.Invoke();
				JudgePoseTurnBack(InInstance);
			}
		}

		protected override void Tick(MovieInstance InInstance, float InDeltaTime)
		{
			if (!InInstance.bNeedPauseAfterPlaying)
			{
				if (string.IsNullOrEmpty(InInstance.OverlapGuid))
				{
					Next(InInstance);
				}
				else
				{
					JudgePoseTurnBack(InInstance);
				}
			}
		}

		private void JudgePoseTurnBack(MovieInstance InInstance)
		{
			switch (UpdatePlayerPose(InInstance))
			{
			case EPlayerPoseType.Walking:
			case EPlayerPoseType.Running:
			case EPlayerPoseType.Sprinting:
				InInstance.bMatching2AWithMoving = true;
				Next(InInstance);
				break;
			case EPlayerPoseType.Exception:
				TransitionByEvent(InInstance, EMoviePlayEvent.Exception, bFinished: true);
				break;
			case EPlayerPoseType.Idle:
				InInstance.bMatching2AWithMoving = false;
				Next(InInstance);
				break;
			case EPlayerPoseType.Jumping:
			case EPlayerPoseType.Charging:
			case EPlayerPoseType.BeAttacked:
			case EPlayerPoseType.Attacking:
				break;
			}
		}

		private EPlayerPoseType UpdatePlayerPose(MovieInstance InInstance)
		{
			BGUCharacterCS bGUCharacterCS = InInstance.PlayerController?.GetControlledPawn() as BGUCharacterCS;
			if (bGUCharacterCS == null)
			{
				return EPlayerPoseType.Exception;
			}
			IBUC_UnitStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UnitStateData>(bGUCharacterCS);
			IBUC_JumpData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.BUC_JumpData>(bGUCharacterCS);
			IBUC_ChargeSkillData unPersistentReadOnlyData3 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ChargeSkillData>(bGUCharacterCS);
			UBGUCharacterMovementComponent uBGUCharacterMovementComponent = bGUCharacterCS.GetMovementComponent() as UBGUCharacterMovementComponent;
			IBIC_TaskData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(bGUCharacterCS);
			if (unPersistentReadOnlyData == null || unPersistentReadOnlyData2 == null || unPersistentReadOnlyData3 == null || uBGUCharacterMovementComponent == null || gameInstanceReadonlyData == null)
			{
				return EPlayerPoseType.Exception;
			}
			if (gameInstanceReadonlyData.IsPlayerInOverlap(InInstance.OverlapGuid, out var bInnerOverlap) && !bInnerOverlap)
			{
				return EPlayerPoseType.Exception;
			}
			if (unPersistentReadOnlyData.HasState(EBGUUnitState.Dead))
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_UnitRebirth.Invoke(ERebirthType.Quick);
				return EPlayerPoseType.Exception;
			}
			EPlayerPoseType ePlayerPoseType = EPlayerPoseType.None;
			if (unPersistentReadOnlyData.HasState(EBGUUnitState.Walking))
			{
				return EPlayerPoseType.Walking;
			}
			if (unPersistentReadOnlyData.HasState(EBGUUnitState.Sprinting))
			{
				return EPlayerPoseType.Sprinting;
			}
			if (unPersistentReadOnlyData2.IsInJump())
			{
				return EPlayerPoseType.Jumping;
			}
			if (unPersistentReadOnlyData.HasState(EBGUUnitState.Beatback))
			{
				return EPlayerPoseType.BeAttacked;
			}
			if (unPersistentReadOnlyData.HasState(EBGUUnitState.Attacking))
			{
				return EPlayerPoseType.Attacking;
			}
			if (unPersistentReadOnlyData3.IsCastingChargeSkill)
			{
				return EPlayerPoseType.Charging;
			}
			if (uBGUCharacterMovementComponent.GetCurrentAcceleration().Size() > 1E-08f)
			{
				return EPlayerPoseType.Running;
			}
			return EPlayerPoseType.Idle;
		}

		private void ClearWukongStates(MovieInstance InInstance)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(InInstance.PlayerController.GetControlledPawn());
			if (!(bUS_GSEventCollection == null))
			{
				bUS_GSEventCollection.Evt_ClearAllAbnormalState.Invoke();
				bUS_GSEventCollection.Evt_RelievePhantomRush.Invoke();
				bUS_GSEventCollection.Evt_TriggerCancelChargeSkill.Invoke();
				bUS_GSEventCollection.Evt_DestroyAllSummons.Invoke();
				InInstance.BGSEventCollection?.Evt_ReliveAllImmobilized.Invoke();
				UGSE_EngineFuncLib.GetFirstLocalPlayerController(InInstance).StopMovement();
			}
		}
	}

	public class MovieState_MatchingA : MovieStateBase
	{
		public override EMoviePlayState StateTag => EMoviePlayState.Matching2PointA;

		private float TransitionLocomotionMaxDistance { get; set; } = 800f;

		protected override void Init()
		{
			RegisterEventTransition(EMoviePlayEvent.Exception, EMoviePlayState.ExceptionProcess);
			RegisterEventTransition(EMoviePlayEvent.Next, EMoviePlayState.PrePlayProcess);
		}

		protected override void Enter(MovieInstance InInstance)
		{
			if (string.IsNullOrEmpty(InInstance.OverlapGuid) || InInstance.MatchingPosType == ESequenceBlendInMatchPositionType.None)
			{
				Next(InInstance);
				return;
			}
			if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.TransitionLocomotionMaxDistance, out var ConfigInfo))
			{
				TransitionLocomotionMaxDistance = ConfigInfo.FloatValue;
			}
			APawn controlledPawn = InInstance.PlayerController.GetControlledPawn();
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(controlledPawn);
			bUS_GSEventCollection.Evt_SwitchFreeCameraMode.Invoke(EPlayerFreeCameraType.SeqMatch);
			bUS_GSEventCollection.Evt_G4CameraTurnToTarget.Invoke(InInstance.PointAPos);
			if (InInstance.bMatching2AWithMoving)
			{
				InInstance.MatchingTransitionTime = 0.5f;
			}
			else
			{
				InInstance.MatchingTransitionTime = -1f;
				if ((BGUFuncLibActorTransformCS.BGUGetActorLocation(controlledPawn) - InInstance.PointAPos.GetLocation()).Size2D() < TransitionLocomotionMaxDistance)
				{
					InInstance.bCanTransitionLocomotion = true;
					bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.UnitInputWalkPressed, -1f);
					bUS_GSEventCollection.Evt_SetPlayerLocomotionInSequenceTransition.Invoke(IsSelfRescue: true);
				}
			}
			if (!InInstance.Match2Point(InInstance.PointAPos, InInstance.MatchingPosType == ESequenceBlendInMatchPositionType.OnePoint))
			{
				TransitionByEvent(InInstance, EMoviePlayEvent.Exception, bFinished: true);
			}
		}

		protected override void Tick(MovieInstance InInstance, float InDeltaTime)
		{
			APawn controlledPawn = InInstance.PlayerController.GetControlledPawn();
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(InInstance.PlayerController.GetControlledPawn());
			if (InInstance.MatchingTransitionTime > 0f)
			{
				InInstance.MatchingTransitionTime -= InDeltaTime;
				if (InInstance.MatchingTransitionTime <= 1E-08f)
				{
					InInstance.MatchingTransitionTime = -1f;
				}
			}
			if (InInstance.MatchingTransitionTime < 0f && (BGUFuncLibActorTransformCS.BGUGetActorLocation(controlledPawn) - InInstance.PointAPos.GetLocation()).Size2D() < TransitionLocomotionMaxDistance)
			{
				InInstance.bCanTransitionLocomotion = true;
				bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.UnitInputWalkPressed, -1f);
				bUS_GSEventCollection.Evt_SetPlayerLocomotionInSequenceTransition.Invoke(IsSelfRescue: true);
			}
		}

		public override void OnBlendPositionFinished(MovieInstance InInstance, bool Success)
		{
			if (InInstance.MatchingTransitionTime > 0f || !InInstance.bCanTransitionLocomotion)
			{
				TransitionByEvent(InInstance, EMoviePlayEvent.Exception, bFinished: true);
			}
			else
			{
				Next(InInstance);
			}
		}

		protected override void Finish(MovieInstance InInstance)
		{
			InInstance.bCanTransitionLocomotion = false;
		}
	}

	public class MovieState_Orientating2A : MovieStateBase
	{
		public override EMoviePlayState StateTag => EMoviePlayState.Orientating2PointA;

		protected override void Init()
		{
			RegisterEventTransition(EMoviePlayEvent.StartPrePlay, EMoviePlayState.PrePlayProcess);
			RegisterEventTransition(EMoviePlayEvent.PointAStop, EMoviePlayState.OriPointAStop);
		}

		protected override void Enter(MovieInstance InInstance)
		{
			if (!InInstance.bDisableCameraCut && InInstance.bHideHud)
			{
				BGUFunctionLibraryCS.BGUActiveNoSeqUI(InInstance, IsActive: false);
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(InInstance.PlayerController.GetControlledPawn());
			bUS_GSEventCollection.Evt_SwitchFreeCameraMode.Invoke(EPlayerFreeCameraType.SeqMatch);
			bUS_GSEventCollection.Evt_G4CameraTurnToTarget.Invoke(InInstance.PointAPos);
			if (InInstance.bMatching2AWithMoving)
			{
				InInstance.MatchingTransitionTime = 0.5f;
				return;
			}
			InInstance.MatchingTransitionTime = -1f;
			TransitionByEvent(InInstance, EMoviePlayEvent.StartPrePlay, bFinished: true);
		}

		protected override void Tick(MovieInstance InInstance, float InDeltaTime)
		{
			APawn controlledPawn = InInstance.PlayerController.GetControlledPawn();
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(InInstance.PlayerController.GetControlledPawn());
			if (InInstance.MatchingTransitionTime > 0f)
			{
				InInstance.MatchingTransitionTime -= InDeltaTime;
				if (InInstance.MatchingTransitionTime <= 1E-08f)
				{
					InInstance.MatchingTransitionTime = -1f;
				}
				FVector safeNormal = (InInstance.PointAPos.GetLocation() - BGUFuncLibActorTransformCS.BGUGetActorLocation(controlledPawn)).GetSafeNormal();
				bUS_GSEventCollection.Evt_SetMovementInput.Invoke(safeNormal, 1f, BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(controlledPawn));
			}
			if (InInstance.MatchingTransitionTime < 0f)
			{
				TransitionByEvent(InInstance, EMoviePlayEvent.PointAStop, bFinished: true);
			}
		}
	}

	public class MovieState_PointAStop : MovieStateBase
	{
		public override EMoviePlayState StateTag => EMoviePlayState.OriPointAStop;

		protected override void Init()
		{
			RegisterEventTransition(EMoviePlayEvent.Next, EMoviePlayState.PrePlayProcess);
		}

		protected override void Enter(MovieInstance InInstance)
		{
			BUS_EventCollectionCS.Get(InInstance.PlayerController.GetControlledPawn()).Evt_SetPlayerLocomotionInSequenceTransition.Invoke(IsSelfRescue: true);
			InInstance.CurrentOriPointAStopTime = InInstance.OriPointAStopTime;
		}

		protected override void Tick(MovieInstance InInstance, float InDeltaTime)
		{
			if (InInstance.CurrentOriPointAStopTime >= 0f)
			{
				InInstance.CurrentOriPointAStopTime -= InDeltaTime;
				if (InInstance.CurrentOriPointAStopTime <= 1E-08f)
				{
					InInstance.CurrentOriPointAStopTime = -1f;
				}
			}
			if (InInstance.CurrentOriPointAStopTime < 0f)
			{
				Next(InInstance);
			}
		}
	}

	public class MovieState_ExceptionProcess : MovieStateBase
	{
		private const float BlackScreenTime = 2f;

		public override EMoviePlayState StateTag => EMoviePlayState.ExceptionProcess;

		protected override void Init()
		{
			RegisterEventTransition(EMoviePlayEvent.Next, EMoviePlayState.PrePlayProcess);
		}

		protected override void Enter(MovieInstance InInstance)
		{
			InInstance.PlayerCameraManager.StartCameraFade(0f, 1f, 1f, FLinearColor.Black, bShouldFadeAudio: false, bHoldWhenFinished: true);
			InInstance.BlackScreenRemainTime = 2f;
		}

		protected override void Tick(MovieInstance InInstance, float InDeltaTime)
		{
			if (InInstance.BlackScreenRemainTime > 0f)
			{
				InInstance.BlackScreenRemainTime -= InDeltaTime;
				if (!(InInstance.BlackScreenRemainTime <= 1E-08f))
				{
					return;
				}
				InInstance.BlackScreenRemainTime = -1f;
				if (InInstance.MatchingPosType != ESequenceBlendInMatchPositionType.None)
				{
					APawn controlledPawn = InInstance.PlayerController.GetControlledPawn();
					if ((object)controlledPawn != null)
					{
						BGUFuncLibActorTransformCS.BGUSetActorLocationAndRotation(controlledPawn, InInstance.PointBPos.GetLocation(), InInstance.PointAPos.GetRotation().Rotator(), bSweep: false, bTeleport: true);
					}
					InInstance.OverlapGuid = null;
				}
				InInstance.bNeedFinishBlackScreen = true;
			}
			else
			{
				Next(InInstance);
			}
		}
	}

	public class MovieState_PrePlayProcess : MovieStateBase
	{
		public override EMoviePlayState StateTag => EMoviePlayState.PrePlayProcess;

		protected override void Init()
		{
			RegisterEventTransition(EMoviePlayEvent.WarmingUp, EMoviePlayState.WarmingUpPlaying);
			RegisterEventTransition(EMoviePlayEvent.StartPreRoll, EMoviePlayState.PreRoll);
			RegisterEventTransition(EMoviePlayEvent.StartPlayProcess, EMoviePlayState.PlayingProcess);
		}

		protected override void Next(MovieInstance InInstance)
		{
			if (!string.IsNullOrEmpty(InInstance.OverlapGuid) && InInstance.MatchingPosType == ESequenceBlendInMatchPositionType.TwoPoint)
			{
				TransitionByEvent(InInstance, EMoviePlayEvent.StartPreRoll, bFinished: true);
			}
			else
			{
				TransitionByEvent(InInstance, EMoviePlayEvent.StartPlayProcess, bFinished: true);
			}
		}

		protected override void Enter(MovieInstance InInstance)
		{
			FMovieSceneSequencePlaybackSettings playbackSettings = InInstance.PlaySettings.PlaybackSettings;
			InInstance.bHideHud = playbackSettings.HideHud;
			APawn controlledPawn = InInstance.PlayerController.GetControlledPawn();
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(controlledPawn);
			if (!InInstance.bDisableCameraCut)
			{
				InInstance.ExecCmdOnStart();
				if (!B1Global.GIsBenchmarkMode)
				{
					BGW_LevelStreamingManger.Get(InInstance)?.PauseAllLevelDistanceStreaming();
				}
				InInstance.BGSEventCollection.Evt_EnableTamerBack2Load.Invoke(P1: false);
				BPS_EventCollectionCS.Get(InInstance.PlayerController).Evt_BPS_PauseCostEnergy.Invoke();
				if (InInstance.bHideHud)
				{
					BGUFunctionLibraryCS.BGUActiveNoSeqUI(InInstance, IsActive: false);
				}
				if (InInstance.bHideDroppingFX)
				{
					BPS_EventCollectionCS.Get(InInstance.PlayerController)?.Evt_OnTriggerStopSimpleDropping?.Invoke();
				}
				ESeqHiddenHeadType eSeqHiddenHeadType = ((BGW_SettingFuncUtil.GetSettingIntValueByType(controlledPawn, UISettingConfigType.SeqHeadWeaponShow) == 0 || BGW_SettingFuncUtil.GetSettingIntValueByType(controlledPawn, UISettingConfigType.HeadWeaponShow) == 0) ? ESeqHiddenHeadType.Hidden : ESeqHiddenHeadType.NoHidden);
				FUStMovieSequenceDesc movieSequenceDesc = BGW_GameDB.GetMovieSequenceDesc(InInstance.SequenceId);
				if (movieSequenceDesc != null && eSeqHiddenHeadType != ESeqHiddenHeadType.NoHidden)
				{
					eSeqHiddenHeadType = movieSequenceDesc.PlayerLSPHiddenHeadType;
				}
				bGW_EventCollection?.Evt_TriggerSyncEquip(eSeqHiddenHeadType);
			}
			InInstance.BGSEventCollection.Evt_BGS_OnEnterLevelSequenceClearBattleItem.Invoke();
			if (InInstance.PlaySettings.bTriggerMonsterGoHome)
			{
				BGUFuncLibSelectTargetsCS.TriggerMonsterGoHome(InInstance.PlayerController.GetControlledPawn());
			}
			if (InInstance.IsNeedStopBGM)
			{
				InInstance.BGSEventCollection?.Evt_BGS_PauseDefaultBGM.Invoke();
			}
			if (InInstance.IsNeedStopEnvSound)
			{
				UBGUFunctionLibAK.PostAkEventOnDummyActor("EVT_env_bus_volume_mute", null);
			}
			if (InInstance.InterruptAiConversationType != EACInterruptType.None)
			{
				InInstance.BGSEventCollection?.Evt_BGS_StopAllAiConversation.Invoke(InInstance.InterruptAiConversationType, EACInterruptReason.PlaySeq);
			}
			if (InInstance.BeforePlayNodeInstance != null)
			{
				InInstance.BeforePlayNodeInstance.TriggerInput();
			}
		}

		public override void OnProcessFinished(MovieInstance InInstance)
		{
			InInstance.BeforePlayFinishCallBack();
			BGW_EventCollection.Get(InInstance)?.Evt_NotifyMovieInstanceStarted(InInstance.SequenceId);
			Next(InInstance);
		}
	}

	public class MovieState_PreRoll : MovieStateBase
	{
		public override EMoviePlayState StateTag => EMoviePlayState.PreRoll;

		protected override void Init()
		{
			RegisterEventTransition(EMoviePlayEvent.PlayPreRoll, EMoviePlayState.PreRollSequencePlaying);
			RegisterEventTransition(EMoviePlayEvent.Next, EMoviePlayState.PlayingProcess);
		}

		protected override void Enter(MovieInstance InInstance)
		{
			if (string.IsNullOrEmpty(InInstance.OverlapGuid) || InInstance.MatchingPosType != ESequenceBlendInMatchPositionType.TwoPoint)
			{
				Next(InInstance);
				return;
			}
			InInstance.Match2Point(InInstance.PointBPos);
			BUS_EventCollectionCS.Get(InInstance.PlayerController.GetControlledPawn()).Evt_UnitStateTrigger.Invoke(EBUStateTrigger.UnitInputWalkPressed, -1f);
			if (InInstance.PreRollNodeInstance != null)
			{
				InInstance.PreRollNodeInstance.TriggerInput();
			}
		}

		public override void OnProcessFinished(MovieInstance InInstance)
		{
			if (!InInstance.bMatchingPos)
			{
				Next(InInstance);
			}
		}

		public override void OnBlendPositionFinished(MovieInstance InInstance, bool Success)
		{
			Next(InInstance);
		}
	}

	public abstract class MovieState_SequencePlaying : MovieStateBase
	{
		protected override void Init()
		{
			RegisterEventTransition(EMoviePlayEvent.Shutdown, EMoviePlayState.Stopping);
		}

		protected override void ReEnter(MovieInstance InInstance, EMoviePlayState InPreviousState)
		{
			if (InPreviousState == EMoviePlayState.Skipping)
			{
				Back2Parent(InInstance);
			}
		}

		protected override void Finish(MovieInstance InInstance)
		{
			InInstance.SequencePlayer?.OnFinished.Unbind(InInstance, B1GlobalFNames.OnSequencePlayFinished);
			InInstance.SequencePlayer?.OnStop.Unbind(InInstance, B1GlobalFNames.OnSequencePlayStopped);
			InInstance.SequenceActor?.SetAllMeshPropertyInSequence(bEnable: false);
			InInstance.SequenceActor?.SetAllPerformerTickEnabled(bEnable: false, out var _);
			InInstance.SequencePlayer?.Pause();
			InInstance.InternalSequenceFinishedCallBack();
		}

		public override void OnSequencePlayFinished(MovieInstance InInstance)
		{
			Back2Parent(InInstance);
		}

		public override void Jump2MarkedFrame(MovieInstance InInstance, string InMarkedFrameLabel)
		{
			if (InInstance.SequencePlayer != null)
			{
				InInstance.SequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams
				{
					UpdateMethod = EUpdatePositionMethod.Play,
					MarkedFrame = InMarkedFrameLabel,
					PositionType = EMovieScenePositionType.MarkedFrame
				});
			}
		}

		protected void ReplaceActorInSequence(MovieInstance InInstance, bool bPlayerTransition2ShowState = true)
		{
			InInstance.Performers.Clear();
			InInstance.SequenceActor.ResetBindings();
			if (InInstance.SequenceActor.GetBindingTags(out var OutBindingTags) == 0)
			{
				return;
			}
			BGUCharacterCS bGUCharacterCS = InInstance.PlayerController.GetControlledPawn() as BGUCharacterCS;
			foreach (FName item in OutBindingTags)
			{
				if (bGUCharacterCS != null && item.Equals(B1GlobalFNames.Player_Wukong))
				{
					InInstance.bSeqBindPlayer = true;
					InInstance.Performers.Add(B1GlobalFNames.Player_Wukong, bGUCharacterCS);
					continue;
				}
				if (!InInstance.MovieData.TryGetTaggedPerformerGuid(item, out var PerformerGuid))
				{
					PerformerGuid = item.ToString();
				}
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(InInstance, PerformerGuid);
				if (actorByGuid == null)
				{
					InInstance.BGSEventCollection.Evt_MarkTamerBlockingSpawn.Invoke(PerformerGuid);
					InInstance.BlockLoadedTamers.Add(PerformerGuid);
				}
				actorByGuid = BGU_DataUtil.GetActorByGuid(InInstance, PerformerGuid);
				if (actorByGuid != null)
				{
					InInstance.Performers.Add(item, actorByGuid);
					InInstance.BGSEventCollection.Evt_MarkTamerAlwaysSpawn.Invoke(PerformerGuid);
					InInstance.LoadedTamers.Add(PerformerGuid);
				}
			}
			InInstance.SequenceActor.BindActorsByTag(InInstance.Performers);
			foreach (KeyValuePair<FName, AActor> performer in InInstance.Performers)
			{
				if (!InInstance.bInSeqMove || !(performer.Key == B1GlobalFNames.Player_Wukong))
				{
					string actorGuid = BGU_DataUtil.GetActorGuid(performer.Value);
					if (!InInstance.PerformerCache.ContainsKey(actorGuid))
					{
						InInstance.PerformerCache.Add(actorGuid, new TWeakObject<AActor>(performer.Value));
						BUS_EventCollectionCS.Get(performer.Value).Evt_SceneObjTransitByEventNoSaveState.Invoke(BGW_FlowUtils.PerformerTag.Event_Show);
					}
				}
			}
			InInstance.Performers.Clear();
		}

		protected AActor BindCameraObjects(MovieInstance InInstance, FMovieSequencePlaySettings InPlaySettings, int PlayIndex)
		{
			IBGC_MovieData movieData = InInstance.MovieData;
			ACalliopeLevelSequenceActor sequenceActor = InInstance.SequenceActor;
			AActor aActor = null;
			FName fName = new FName(InPlaySettings.CameraTags[PlayIndex]);
			if (fName != FName.None)
			{
				aActor = ((!InPlaySettings.bUseCinematicCamera) ? ((AActor)movieData.GetCameraByTag(fName)) : ((AActor)movieData.GetCineCameraByTag(fName)));
			}
			if (aActor == null)
			{
				if (InPlaySettings.bUseCinematicCamera)
				{
					UGameplayStatics.GetAllActorsOfClassWithTag(InInstance, UClass.GetClass(typeof(ACineCameraActor)), fName, out var OutActors);
					if (OutActors.Count > 0)
					{
						aActor = OutActors[0];
					}
				}
				else
				{
					UGameplayStatics.GetAllActorsOfClassWithTag(InInstance, UClass.GetClass(typeof(ACameraActor)), fName, out var OutActors2);
					if (OutActors2.Count > 0)
					{
						aActor = OutActors2[0];
					}
				}
			}
			if (aActor == null)
			{
				UGameplayStatics.GetAllActorsOfClass(InInstance, UClass.GetClass(typeof(BGUChapterCameraActor)), out var OutActors3);
				if (OutActors3.Count > 0)
				{
					aActor = OutActors3[0];
				}
			}
			AActor aActor2 = null;
			if (InPlaySettings.bUseRail)
			{
				FName fName2 = new FName(InPlaySettings.RailTags[PlayIndex]);
				if (fName2 != FName.None)
				{
					aActor2 = movieData.GetRailByTag(fName2);
				}
				if (aActor2 == null)
				{
					UGameplayStatics.GetAllActorsOfClassWithTag(InInstance, UClass.GetClass(typeof(ACameraRig_Rail)), fName2, out var OutActors4);
					if (OutActors4.Count > 0)
					{
						aActor2 = OutActors4[0];
					}
				}
				if (aActor2 == null)
				{
					aActor2 = movieData.GetCameraRailActor(InInstance);
					sequenceActor.BindActorByName(B1GlobalFNames.BP_CameraRail_ForSeq, aActor2);
				}
			}
			AActor aActor3 = null;
			if (InPlaySettings.bUseCrane)
			{
				FName fName3 = new FName(InPlaySettings.CraneTags[PlayIndex]);
				if (fName3 != FName.None)
				{
					aActor3 = movieData.GetCraneByTag(fName3);
				}
				if (aActor3 == null)
				{
					UGameplayStatics.GetAllActorsOfClassWithTag(InInstance, UClass.GetClass(typeof(ACameraRig_Crane)), fName3, out var OutActors5);
					if (OutActors5.Count > 0)
					{
						aActor3 = OutActors5[0];
					}
				}
				if (aActor3 == null)
				{
					aActor3 = movieData.GetCameraCraneActor(InInstance);
					sequenceActor.BindActorByName(B1GlobalFNames.BP_CameraCrane_ForSeq, aActor3);
				}
			}
			if (aActor2 != null && aActor3 != null)
			{
				BGU_UnrealActorUtil.AttachToActorSimple(aActor, aActor3, EAttachmentTransformRules.SnapToTargetNotIncludingScale);
				BGU_UnrealActorUtil.AttachToActorSimple(aActor3, aActor2, EAttachmentTransformRules.SnapToTargetNotIncludingScale);
			}
			else if (aActor2 != null)
			{
				BGU_UnrealActorUtil.AttachToActorSimple(aActor, aActor2, EAttachmentTransformRules.SnapToTargetNotIncludingScale);
			}
			else if (aActor3 != null)
			{
				BGU_UnrealActorUtil.AttachToActorSimple(aActor, aActor3, EAttachmentTransformRules.SnapToTargetNotIncludingScale);
			}
			return aActor;
		}
	}

	public class MovieState_WarmingUpPlaying : MovieState_SequencePlaying
	{
		public override EMoviePlayState StateTag => EMoviePlayState.WarmingUpPlaying;

		protected override void Init()
		{
			base.Init();
			RegisterParentState(EMoviePlayState.PrePlayProcess);
			RegisterEventTransition(EMoviePlayEvent.Pause, EMoviePlayState.Paused);
		}

		protected override void Enter(MovieInstance InInstance)
		{
			FWarmingUpPlaySettings warmingUpPlaySettings = InInstance.WarmingUpPlaySettings;
			if (warmingUpPlaySettings == null)
			{
				OnSequencePlayFinished(InInstance);
				return;
			}
			FMovieGraphPlaySettings playSettings = InInstance.PlaySettings;
			ACalliopeLevelSequenceActor aCalliopeLevelSequenceActor = InInstance.SequenceActor;
			UCalliopeLevelSequencePlayer uCalliopeLevelSequencePlayer = InInstance.SequencePlayer;
			ABGPPlayerController playerController = InInstance.PlayerController;
			FMovieSequencePlaySettings playSettings2 = warmingUpPlaySettings.PlaySettings;
			if (playSettings2.Sequences.Count != 0)
			{
				int num;
				if (InInstance.bDisableCameraCut)
				{
					num = 0;
				}
				else
				{
					if (InInstance.bUseRelativeTransform)
					{
						FTransform fTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(InInstance.PlayerController.GetControlledPawn());
						for (int i = 0; i < playSettings2.CameraTransforms.Count; i++)
						{
							playSettings2.CameraTransforms[i] *= fTransform;
						}
					}
					float num2 = -1f;
					int num3 = -1;
					for (int j = 0; j < playSettings2.CameraTransforms.Count; j++)
					{
						float num4 = MathLib.DistSquared(playSettings2.CameraTransforms[j].GetLocation(), InInstance.PlayerCameraManager.GetCameraLocation());
						if (num4 <= num2 || num2 < 0f)
						{
							num2 = num4;
							num3 = j;
						}
					}
					num = num3;
				}
				ULevelSequence uLevelSequence = playSettings2.Sequences[num];
				if (uLevelSequence != null)
				{
					uLevelSequence.SetClockSource(InInstance.ClockSource);
					if (aCalliopeLevelSequenceActor == null)
					{
						uCalliopeLevelSequencePlayer = UCalliopeLevelSequencePlayer.CreateCalliopeLevelSequencePlayer(InInstance, uLevelSequence, playSettings.PlaybackSettings, playSettings.CameraSettings, out var OutActor);
						uCalliopeLevelSequencePlayer.MovieInstanceIndex = InInstance.MovieId;
						aCalliopeLevelSequenceActor = OutActor;
						InInstance.SequenceActor = OutActor;
						InInstance.SequencePlayer = uCalliopeLevelSequencePlayer;
					}
					else
					{
						aCalliopeLevelSequenceActor.PlaybackSettings = playSettings.PlaybackSettings;
						aCalliopeLevelSequenceActor.CameraSettings = playSettings.CameraSettings;
						aCalliopeLevelSequenceActor.ReSetSequence(uLevelSequence);
					}
					uCalliopeLevelSequencePlayer.SetDisableCameraCuts(InInstance.bDisableCameraCut);
					FHitResult SweepHitResult;
					if (InInstance.bUseRelativeTransform)
					{
						FTransform newTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(playerController.GetControlledPawn());
						FRotator fRotator = newTransform.Rotation.Rotator();
						fRotator.Pitch = 0f;
						fRotator.Roll = 0f;
						newTransform.SetRotation(fRotator.Quaternion());
						aCalliopeLevelSequenceActor.SetActorTransform(newTransform, bSweep: false, out SweepHitResult, bTeleport: false);
					}
					else
					{
						aCalliopeLevelSequenceActor.SetActorTransform(FTransform.Identity, bSweep: false, out SweepHitResult, bTeleport: false);
					}
					if (!InInstance.bDisableCameraCut)
					{
						AActor aActor = BindCameraObjects(InInstance, playSettings2, num);
						if (aActor != null)
						{
							aActor.SetActorTransform(playSettings2.CameraTransforms[num], bSweep: false, out SweepHitResult, bTeleport: false);
							playerController.SetViewTargetWithBlend(aActor, playSettings2.InCameraBlendTime, playSettings2.InCameraBlendFunction, playSettings2.InCameraBlendFactor);
						}
						BPS_EventCollectionCS.Get(InInstance.PlayerController).Evt_BPS_EnableCameraFoliageFade.Invoke(P1: false);
						BUS_EventCollectionCS.Get(playerController.GetControlledPawn())?.Evt_PauseSafeFallingCheck.Invoke(P1: true);
					}
					aCalliopeLevelSequenceActor.SetAllMeshPropertyInSequence(bEnable: true);
					aCalliopeLevelSequenceActor.SetAllPerformerTickEnabled(bEnable: true, out var OutPerformers);
					ReplaceActorInSequence(InInstance);
					warmingUpPlaySettings.SeqStartFrame = uCalliopeLevelSequencePlayer.GetStartTime().Time.FrameNumber.Value;
					warmingUpPlaySettings.SeqEndFrame = uCalliopeLevelSequencePlayer.GetEndTime().Time.FrameNumber.Value;
					if (warmingUpPlaySettings.bUseMarkFrameLoop && uCalliopeLevelSequencePlayer.TryGetMarkedFrameTime("LoopStart", out var OutFrameTime) && uCalliopeLevelSequencePlayer.TryGetMarkedFrameTime("LoopEnd", out var OutFrameTime2))
					{
						warmingUpPlaySettings.LoopStartFrame = OutFrameTime.FrameNumber.Value;
						warmingUpPlaySettings.LoopEndFrame = OutFrameTime2.FrameNumber.Value;
						InInstance.SequencePlayer.SetFrameRange(warmingUpPlaySettings.SeqStartFrame, warmingUpPlaySettings.LoopEndFrame - warmingUpPlaySettings.SeqStartFrame);
						warmingUpPlaySettings.bPlayingMarkFrameLoop = true;
					}
					uCalliopeLevelSequencePlayer.Play();
					uCalliopeLevelSequencePlayer.OnFinished.Bind(InInstance, B1GlobalFNames.OnSequencePlayFinished);
					foreach (AActor item in OutPerformers)
					{
						BUS_EventCollectionCS.Get(item)?.Evt_TriggerModularMeshTickAnimForCopyPose.Invoke();
					}
					BGUFunctionLibraryCS.BGUToggleGlobalURO(InInstance, bEnable: false);
				}
				foreach (string streamingLevelName in warmingUpPlaySettings.StreamingLevelNames)
				{
					InInstance.RequestLoadLevel(streamingLevelName, bMakeVisibleAfterLoaded: true, bShouldBlockOnLoad: false, "");
				}
				foreach (string needPerformer in warmingUpPlaySettings.NeedPerformers)
				{
					InInstance.RequestLoadTamer(bUseBlockLoad: false, needPerformer);
				}
				warmingUpPlaySettings.bSequenceFinished = false;
			}
			else
			{
				InInstance.bNoSeqMovie = true;
				warmingUpPlaySettings.bSequenceFinished = true;
				foreach (string streamingLevelName2 in warmingUpPlaySettings.StreamingLevelNames)
				{
					InInstance.RequestLoadLevel(streamingLevelName2, bMakeVisibleAfterLoaded: true, warmingUpPlaySettings.bBlockLoad);
				}
				foreach (string needPerformer2 in warmingUpPlaySettings.NeedPerformers)
				{
					InInstance.RequestLoadTamer(warmingUpPlaySettings.bBlockLoad, needPerformer2);
				}
			}
			if (warmingUpPlaySettings.AssociationConfigId > 0)
			{
				BGW_EventCollection.Get(InInstance)?.Evt_BGW_BlockingSpawnAssociationUnit(warmingUpPlaySettings.AssociationConfigId, warmingUpPlaySettings.AssociationSpawnType);
			}
		}

		protected override void Tick(MovieInstance InInstance, float InDeltaTime)
		{
			FWarmingUpPlaySettings warmingUpPlaySettings = InInstance.WarmingUpPlaySettings;
			if (warmingUpPlaySettings == null)
			{
				OnSequencePlayFinished(InInstance);
				return;
			}
			warmingUpPlaySettings.bLoadFinished = InInstance.IsLoadFinishedForWarmmingUp();
			if (!warmingUpPlaySettings.bSequenceFinished)
			{
				return;
			}
			if (warmingUpPlaySettings.bBlockLoad)
			{
				if (warmingUpPlaySettings.bLoadFinished)
				{
					OnSequencePlayFinished(InInstance);
				}
			}
			else
			{
				OnSequencePlayFinished(InInstance);
			}
		}

		public override void OnSequencePlayFinished(MovieInstance InInstance)
		{
			FWarmingUpPlaySettings warmingUpPlaySettings = InInstance.WarmingUpPlaySettings;
			if (warmingUpPlaySettings == null)
			{
				base.OnSequencePlayFinished(InInstance);
				return;
			}
			if (warmingUpPlaySettings.bPlayingMarkFrameLoop)
			{
				if (InInstance.IsLoadFinishedForWarmmingUp())
				{
					warmingUpPlaySettings.bPlayingMarkFrameLoop = false;
					InInstance.SequencePlayer.SetFrameRange(warmingUpPlaySettings.LoopEndFrame, warmingUpPlaySettings.SeqEndFrame - warmingUpPlaySettings.LoopEndFrame);
					InInstance.SequencePlayer.Play();
				}
				else
				{
					InInstance.SequencePlayer.SetFrameRange(warmingUpPlaySettings.LoopStartFrame, warmingUpPlaySettings.LoopEndFrame - warmingUpPlaySettings.LoopStartFrame);
					InInstance.SequencePlayer.Play();
				}
			}
			else
			{
				warmingUpPlaySettings.bSequenceFinished = true;
			}
			base.OnSequencePlayFinished(InInstance);
		}
	}

	public class MovieState_PlayingProcess : MovieStateBase
	{
		public override EMoviePlayState StateTag => EMoviePlayState.PlayingProcess;

		protected override void Init()
		{
			RegisterEventTransition(EMoviePlayEvent.Skip, EMoviePlayState.Skipping);
			RegisterEventTransition(EMoviePlayEvent.Pause, EMoviePlayState.Paused);
			RegisterEventConvert(EMoviePlayEvent.Stop, EMoviePlayEvent.Next);
			RegisterEventTransition(EMoviePlayEvent.PlayStart, EMoviePlayState.StartSequencePlaying);
			RegisterEventTransition(EMoviePlayEvent.PlayCut, EMoviePlayState.CutSequencePlaying);
		}

		protected override void Enter(MovieInstance InInstance)
		{
			if (!InInstance.bInSeqMove && !InInstance.bDisableCameraCut)
			{
				InInstance.DisablePlayerMove();
			}
			InInstance.OnTriggerNodeInput(InInstance.Graph.GetStartNode(), "");
		}
	}

	public class MovieState_StartSequencePlaying : MovieState_SequencePlaying
	{
		public override EMoviePlayState StateTag => EMoviePlayState.StartSequencePlaying;

		protected override void Init()
		{
			base.Init();
			RegisterParentState(EMoviePlayState.PlayingProcess);
			RegisterEventTransition(EMoviePlayEvent.Skip, EMoviePlayState.Skipping);
			RegisterEventTransition(EMoviePlayEvent.Pause, EMoviePlayState.Paused);
		}

		protected override void Enter(MovieInstance InInstance)
		{
			FMovieSequencePlaySettings sequencePlaySettings = InInstance.SequencePlaySettings;
			if (sequencePlaySettings.Sequences.Count == 0)
			{
				InInstance.bNoSeqMovie = true;
				OnSequencePlayFinished(InInstance);
				return;
			}
			APlayerController playerController = InInstance.PlayerController;
			APlayerCameraManager playerCameraManager = InInstance.PlayerCameraManager;
			ACalliopeLevelSequenceActor aCalliopeLevelSequenceActor = InInstance.SequenceActor;
			UCalliopeLevelSequencePlayer uCalliopeLevelSequencePlayer = InInstance.SequencePlayer;
			FMovieGraphPlaySettings playSettings = InInstance.PlaySettings;
			bool bDisableCameraCut = InInstance.bDisableCameraCut;
			int num;
			if (bDisableCameraCut)
			{
				num = 0;
			}
			else
			{
				if (InInstance.bUseRelativeTransform)
				{
					FTransform fTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(playerController.GetControlledPawn());
					for (int i = 0; i < sequencePlaySettings.CameraTransforms.Count; i++)
					{
						sequencePlaySettings.CameraTransforms[i] *= fTransform;
					}
				}
				float num2 = -1f;
				int num3 = -1;
				for (int j = 0; j < sequencePlaySettings.CameraTransforms.Count; j++)
				{
					float num4 = MathLib.DistSquared(sequencePlaySettings.CameraTransforms[j].GetLocation(), playerCameraManager.GetCameraLocation());
					if (num4 <= num2 || num2 < 0f)
					{
						num2 = num4;
						num3 = j;
					}
				}
				num = num3;
			}
			ULevelSequence uLevelSequence = sequencePlaySettings.Sequences[num];
			if (uLevelSequence == null)
			{
				InInstance.bNoSeqMovie = true;
				OnSequencePlayFinished(InInstance);
				return;
			}
			uLevelSequence.SetClockSource(InInstance.ClockSource);
			if (aCalliopeLevelSequenceActor == null)
			{
				uCalliopeLevelSequencePlayer = UCalliopeLevelSequencePlayer.CreateCalliopeLevelSequencePlayer(InInstance, uLevelSequence, playSettings.PlaybackSettings, playSettings.CameraSettings, out var OutActor);
				uCalliopeLevelSequencePlayer.MovieInstanceIndex = InInstance.MovieId;
				aCalliopeLevelSequenceActor = OutActor;
				InInstance.SequencePlayer = uCalliopeLevelSequencePlayer;
				InInstance.SequenceActor = OutActor;
			}
			else
			{
				aCalliopeLevelSequenceActor.PlaybackSettings = playSettings.PlaybackSettings;
				aCalliopeLevelSequenceActor.CameraSettings = playSettings.CameraSettings;
				aCalliopeLevelSequenceActor.ReSetSequence(uLevelSequence);
			}
			uCalliopeLevelSequencePlayer.SetDisableCameraCuts(bDisableCameraCut);
			FHitResult SweepHitResult;
			if (InInstance.bUseRelativeTransform)
			{
				FTransform newTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(playerController.GetControlledPawn());
				FRotator fRotator = newTransform.Rotation.Rotator();
				fRotator.Pitch = 0f;
				fRotator.Roll = 0f;
				newTransform.SetRotation(fRotator.Quaternion());
				aCalliopeLevelSequenceActor.SetActorTransform(newTransform, bSweep: false, out SweepHitResult, bTeleport: false);
			}
			else
			{
				aCalliopeLevelSequenceActor.SetActorTransform(FTransform.Identity, bSweep: false, out SweepHitResult, bTeleport: false);
			}
			if (!bDisableCameraCut)
			{
				AActor aActor = BindCameraObjects(InInstance, sequencePlaySettings, num);
				InInstance.RemainBlendTime = 0f;
				if (aActor != null)
				{
					aActor.SetActorTransform(sequencePlaySettings.CameraTransforms[num], bSweep: false, out SweepHitResult, bTeleport: false);
					playerController.SetViewTargetWithBlend(aActor, sequencePlaySettings.InCameraBlendTime, sequencePlaySettings.InCameraBlendFunction, sequencePlaySettings.InCameraBlendFactor);
					InInstance.RemainBlendTime = sequencePlaySettings.InCameraBlendTime;
				}
				InInstance.FinishBlackScreenIfNeed(aActor);
				BPS_EventCollectionCS.Get(InInstance.PlayerController).Evt_BPS_EnableCameraFoliageFade.Invoke(P1: false);
				BUS_EventCollectionCS.Get(playerController.GetControlledPawn())?.Evt_PauseSafeFallingCheck.Invoke(P1: true);
			}
			aCalliopeLevelSequenceActor.SetAllMeshPropertyInSequence(bEnable: true);
			aCalliopeLevelSequenceActor.SetAllPerformerTickEnabled(bEnable: true, out var OutPerformers);
			ReplaceActorInSequence(InInstance);
			if (InInstance.bTransBacking)
			{
				int value = uCalliopeLevelSequencePlayer.GetStartTime().Time.FrameNumber.Value;
				int value2 = uCalliopeLevelSequencePlayer.GetEndTime().Time.FrameNumber.Value;
				if (uCalliopeLevelSequencePlayer.TryGetMarkedFrameTime("TransBackEnd", out var OutFrameTime))
				{
					InInstance.TransBackEndFrameNumber = OutFrameTime.FrameNumber.Value;
					if (InInstance.TransBackEndFrameNumber >= value || InInstance.TransBackEndFrameNumber <= value2)
					{
						InInstance.EndTransBack();
					}
				}
				else
				{
					InInstance.EndTransBack();
				}
			}
			float time = UGSE_SequencerFuncLib.FQualifiedTimeAsSeconds(uCalliopeLevelSequencePlayer.GetStartTime());
			uCalliopeLevelSequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams
			{
				UpdateMethod = EUpdatePositionMethod.Play,
				Time = time,
				PositionType = EMovieScenePositionType.Time
			});
			if (sequencePlaySettings.bLoopPlay)
			{
				uCalliopeLevelSequencePlayer.PlayLooping();
				InInstance.bIsPlayingLoopMovie = true;
			}
			else
			{
				uCalliopeLevelSequencePlayer.Play();
			}
			foreach (AActor item in OutPerformers)
			{
				BUS_EventCollectionCS.Get(item)?.Evt_TriggerModularMeshTickAnimForCopyPose.Invoke();
			}
			BGUFunctionLibraryCS.BGUToggleGlobalURO(InInstance, bEnable: false);
			uCalliopeLevelSequencePlayer.OnFinished.Bind(InInstance, B1GlobalFNames.OnSequencePlayFinished);
			_ = InInstance.bDisableCameraCut;
		}

		protected override void Tick(MovieInstance InInstance, float InDeltaTime)
		{
			if (InInstance.bTransBacking && InInstance.SequencePlayer.GetCurrentTime().Time.FrameNumber.Value > InInstance.TransBackEndFrameNumber)
			{
				InInstance.EndTransBack();
			}
			if (InInstance.RemainBlendTime > 1E-08f)
			{
				InInstance.RemainBlendTime -= InDeltaTime;
				if (InInstance.RemainBlendTime < 1E-08f)
				{
					InInstance.ResetPlayerFreeCamera();
				}
			}
		}

		protected override void Exit(MovieInstance InInstance)
		{
			if (InInstance.RemainBlendTime > 1E-08f)
			{
				InInstance.RemainBlendTime = 0f;
				InInstance.ResetPlayerFreeCamera();
			}
		}
	}

	public class MovieState_CutSequencePlaying : MovieState_SequencePlaying
	{
		public override EMoviePlayState StateTag => EMoviePlayState.CutSequencePlaying;

		protected override void Init()
		{
			base.Init();
			RegisterParentState(EMoviePlayState.PlayingProcess);
			RegisterEventTransition(EMoviePlayEvent.Skip, EMoviePlayState.Skipping);
			RegisterEventTransition(EMoviePlayEvent.Pause, EMoviePlayState.Paused);
		}

		protected override void Enter(MovieInstance InInstance)
		{
			APlayerController playerController = InInstance.PlayerController;
			ACalliopeLevelSequenceActor sequenceActor = InInstance.SequenceActor;
			UCalliopeLevelSequencePlayer sequencePlayer = InInstance.SequencePlayer;
			bool bDisableCameraCut = InInstance.bDisableCameraCut;
			FMovieSequencePlaySettings sequencePlaySettings = InInstance.SequencePlaySettings;
			if (sequencePlaySettings.Sequences.Count == 0)
			{
				OnSequencePlayFinished(InInstance);
				return;
			}
			sequenceActor.ReSetSequence(sequencePlaySettings.Sequences[0]);
			sequencePlayer.SetDisableCameraCuts(bDisableCameraCut);
			if (!bDisableCameraCut)
			{
				AActor aActor = BindCameraObjects(InInstance, sequencePlaySettings, 0);
				if (aActor != null)
				{
					playerController.SetViewTargetWithBlend(aActor, sequencePlaySettings.InCameraBlendTime, sequencePlaySettings.InCameraBlendFunction, sequencePlaySettings.InCameraBlendFactor);
				}
			}
			sequenceActor.SetAllMeshPropertyInSequence(bEnable: true);
			sequenceActor.SetAllPerformerTickEnabled(bEnable: true, out var OutPerformers);
			ReplaceActorInSequence(InInstance);
			float time = UGSE_SequencerFuncLib.FQualifiedTimeAsSeconds(sequencePlayer.GetStartTime());
			sequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams
			{
				UpdateMethod = EUpdatePositionMethod.Play,
				Time = time,
				PositionType = EMovieScenePositionType.Time
			});
			if (sequencePlaySettings.bLoopPlay)
			{
				sequencePlayer.PlayLooping();
				InInstance.bIsPlayingLoopMovie = true;
			}
			else
			{
				sequencePlayer.Play();
			}
			foreach (AActor item in OutPerformers)
			{
				BUS_EventCollectionCS.Get(item)?.Evt_TriggerModularMeshTickAnimForCopyPose.Invoke();
			}
			sequencePlayer.OnFinished.Bind(InInstance, B1GlobalFNames.OnSequencePlayFinished);
		}
	}

	public class MovieState_PreRollSequencePlaying : MovieState_SequencePlaying
	{
		public override EMoviePlayState StateTag => EMoviePlayState.PreRollSequencePlaying;

		protected override void Init()
		{
			base.Init();
			RegisterParentState(EMoviePlayState.PreRoll);
			RegisterEventTransition(EMoviePlayEvent.Pause, EMoviePlayState.Paused);
		}

		protected override void Enter(MovieInstance InInstance)
		{
			APlayerController playerController = InInstance.PlayerController;
			ACalliopeLevelSequenceActor aCalliopeLevelSequenceActor = InInstance.SequenceActor;
			UCalliopeLevelSequencePlayer uCalliopeLevelSequencePlayer = InInstance.SequencePlayer;
			bool bDisableCameraCut = InInstance.bDisableCameraCut;
			FMovieGraphPlaySettings playSettings = InInstance.PlaySettings;
			FMovieSequencePlaySettings sequencePlaySettings = InInstance.SequencePlaySettings;
			ULevelSequence uLevelSequence = sequencePlaySettings.Sequences[0];
			uLevelSequence.SetClockSource(InInstance.ClockSource);
			if (aCalliopeLevelSequenceActor == null)
			{
				uCalliopeLevelSequencePlayer = UCalliopeLevelSequencePlayer.CreateCalliopeLevelSequencePlayer(InInstance, uLevelSequence, playSettings.PlaybackSettings, playSettings.CameraSettings, out var OutActor);
				uCalliopeLevelSequencePlayer.MovieInstanceIndex = InInstance.MovieId;
				aCalliopeLevelSequenceActor = OutActor;
				InInstance.SequenceActor = OutActor;
				InInstance.SequencePlayer = uCalliopeLevelSequencePlayer;
			}
			else
			{
				aCalliopeLevelSequenceActor.PlaybackSettings = playSettings.PlaybackSettings;
				aCalliopeLevelSequenceActor.CameraSettings = playSettings.CameraSettings;
				aCalliopeLevelSequenceActor.ReSetSequence(uLevelSequence);
			}
			if (sequencePlaySettings.Sequences.Count == 0)
			{
				OnSequencePlayFinished(InInstance);
				return;
			}
			uCalliopeLevelSequencePlayer.SetDisableCameraCuts(bDisableCameraCut);
			if (!bDisableCameraCut)
			{
				AActor aActor = BindCameraObjects(InInstance, sequencePlaySettings, 0);
				if (aActor != null)
				{
					playerController.SetViewTargetWithBlend(aActor, sequencePlaySettings.InCameraBlendTime, sequencePlaySettings.InCameraBlendFunction, sequencePlaySettings.InCameraBlendFactor);
				}
			}
			aCalliopeLevelSequenceActor.SetAllMeshPropertyInSequence(bEnable: true);
			aCalliopeLevelSequenceActor.SetAllPerformerTickEnabled(bEnable: true, out var OutPerformers);
			ReplaceActorInSequence(InInstance, bPlayerTransition2ShowState: false);
			float time = UGSE_SequencerFuncLib.FQualifiedTimeAsSeconds(uCalliopeLevelSequencePlayer.GetStartTime());
			uCalliopeLevelSequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams
			{
				UpdateMethod = EUpdatePositionMethod.Play,
				Time = time,
				PositionType = EMovieScenePositionType.Time
			});
			if (sequencePlaySettings.bLoopPlay)
			{
				uCalliopeLevelSequencePlayer.PlayLooping();
				InInstance.bIsPlayingLoopMovie = true;
			}
			else
			{
				uCalliopeLevelSequencePlayer.Play();
			}
			foreach (AActor item in OutPerformers)
			{
				BUS_EventCollectionCS.Get(item)?.Evt_TriggerModularMeshTickAnimForCopyPose.Invoke();
			}
			uCalliopeLevelSequencePlayer.OnFinished.Bind(InInstance, B1GlobalFNames.OnSequencePlayFinished);
			if (InInstance.bStopPreRollWhenBlendFinish)
			{
				uCalliopeLevelSequencePlayer.OnStop.Bind(InInstance, B1GlobalFNames.OnSequencePlayStopped);
			}
		}

		public override void OnBlendPositionFinished(MovieInstance InInstance, bool Success)
		{
			if (InInstance.bStopPreRollWhenBlendFinish)
			{
				InInstance.SequencePlayer.Stop();
			}
		}
	}

	public class MovieState_Paused : MovieStateBase
	{
		public override EMoviePlayState StateTag => EMoviePlayState.Paused;

		protected override void Init()
		{
			RegisterEventConvert(EMoviePlayEvent.Resume, EMoviePlayEvent.Back2Previous);
		}

		protected override void Enter(MovieInstance InInstance)
		{
			if (InInstance.SequencePlayer != null)
			{
				InInstance.SequencePlayer.Pause();
			}
			if (InInstance.PlayerController != null)
			{
				UAkGameplayStatics.PostEvent(null, InInstance.PlayerController, 0, null, bStopWhenAttachedToDestroyed: false, "Pause_SFX");
			}
		}

		protected override void Finish(MovieInstance InInstance)
		{
			if (InInstance.SequencePlayer != null)
			{
				InInstance.SequencePlayer.Play();
			}
			if (InInstance.PlayerController != null)
			{
				UAkGameplayStatics.PostEvent(null, InInstance.PlayerController, 0, null, bStopWhenAttachedToDestroyed: false, "Resume_SFX");
			}
			_ = InInstance.bDisableCameraCut;
		}
	}

	public class MovieState_Skipping : MovieStateBase
	{
		private readonly float FastForwardSkipTimeRate1 = 32f;

		private readonly float FastForwardSkipTimeRate2 = 16f;

		private readonly float FastForwardSkipTimeRate3 = 4f;

		private readonly float TimeRate1RemainTime = 10f;

		private readonly float TimeRate2RemainTime = 4f;

		private readonly float TimeRate3RemainTime = 1f;

		public override EMoviePlayState StateTag => EMoviePlayState.Skipping;

		protected override void Init()
		{
			RegisterEventTransition(EMoviePlayEvent.Pause, EMoviePlayState.Paused);
		}

		protected override void Enter(MovieInstance InInstance)
		{
			if (InInstance.bDisableCameraCut)
			{
				Back2Previous(InInstance);
				return;
			}
			if (!InInstance.IsLoadFinished() || !InInstance.bCanSkip)
			{
				Back2Previous(InInstance);
				return;
			}
			if (InInstance.bTransBacking)
			{
				InInstance.EndTransBack();
			}
			InInstance.OnMarkCanFinishLoopMovie();
			if (!(InInstance.SequencePlayer != null))
			{
				return;
			}
			if (InInstance.SequencePlayer.TryGetMarkedSecond("PassEnd", out var OutTimeSecond))
			{
				InInstance.Skip2Time = OutTimeSecond;
			}
			else
			{
				InInstance.Skip2Time = UGSE_SequencerFuncLib.FQualifiedTimeAsSeconds(InInstance.SequencePlayer.GetEndTime()) - 0.5f;
			}
			switch (InInstance.SkipType)
			{
			case ESkipType.FastForward:
			{
				float num = UGSE_SequencerFuncLib.FQualifiedTimeAsSeconds(InInstance.SequencePlayer.GetCurrentTime());
				if (InInstance.Skip2Time - num > TimeRate3RemainTime + 0.25f)
				{
					BGW_EventCollection.Get(InInstance.PlayerController).Evt_ActiveBlackOut(IsActive: true, delegate
					{
						InInstance.SequencePlayer.Pause();
						UGSE_SequencerFuncLib.SequenceSetClockSource(InInstance.SequencePlayer, EUpdateClockSource.Tick);
						InInstance.SequencePlayer.Play();
						float value = GSGameplayCVar.CVar_SequenceFastForwardSkipTimeRate.GetValueInGameThread();
						InInstance.FastForwardSkipStage = 1u;
						SetTimeDilation(InInstance, value);
					}, -1f, default(FColor), IsPauseWorld: false);
					BGW_PreloadAssetMgr bGW_PreloadAssetMgr2 = BGW_PreloadAssetMgr.Get(InInstance);
					if (bGW_PreloadAssetMgr2 != null && bGW_PreloadAssetMgr2.LevelSequenceConfig != null && bGW_PreloadAssetMgr2.LevelSequenceConfig.MuteEvent_WhenSkipping != null)
					{
						UBGUFunctionLibAK.PostAkEventOnDummyActor(string.Empty, bGW_PreloadAssetMgr2.LevelSequenceConfig.MuteEvent_WhenSkipping);
					}
				}
				break;
			}
			case ESkipType.SetPosition:
			{
				InInstance.SequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams
				{
					UpdateMethod = EUpdatePositionMethod.Play,
					Time = InInstance.Skip2Time,
					PositionType = EMovieScenePositionType.Time
				});
				BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(InInstance);
				if (bGW_PreloadAssetMgr != null && bGW_PreloadAssetMgr.LevelSequenceConfig != null && bGW_PreloadAssetMgr.LevelSequenceConfig.StopEvent_WhenSkipping != null)
				{
					UBGUFunctionLibAK.PostAkEventOnDummyActor(string.Empty, bGW_PreloadAssetMgr.LevelSequenceConfig.StopEvent_WhenSkipping);
				}
				InInstance.OnSkippingNodeInstance?.TriggerInput();
				break;
			}
			}
		}

		public override void OnSequencePlayFinished(MovieInstance InInstance)
		{
			if (InInstance.SkipType == ESkipType.FastForward && InInstance.FastForwardSkipStage != 0)
			{
				if (InInstance.FastForwardSkipStage < 5)
				{
					SetTimeDilation(InInstance, 1f);
					BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(InInstance);
					if (bGW_PreloadAssetMgr != null && bGW_PreloadAssetMgr.LevelSequenceConfig != null && bGW_PreloadAssetMgr.LevelSequenceConfig.StopEvent_WhenSkippingOver != null)
					{
						UBGUFunctionLibAK.PostAkEventOnDummyActor(string.Empty, bGW_PreloadAssetMgr.LevelSequenceConfig.StopEvent_WhenSkippingOver);
					}
				}
				BGW_EventCollection.Get(InInstance.PlayerController).Evt_ActiveBlackOut(IsActive: false);
				InInstance.FastForwardSkipStage = 0u;
			}
			Back2Previous(InInstance);
		}

		protected override void Tick(MovieInstance InInstance, float InDeltaTime)
		{
			if (InInstance.SkipType != ESkipType.FastForward || InInstance.FastForwardSkipStage == 0)
			{
				return;
			}
			float num = UGSE_SequencerFuncLib.FQualifiedTimeAsSeconds(InInstance.SequencePlayer.GetCurrentTime());
			float num2 = InInstance.Skip2Time - num;
			float value = 1f;
			uint fastForwardSkipStage = InInstance.FastForwardSkipStage;
			if (num2 <= TimeRate1RemainTime && InInstance.FastForwardSkipStage == 1)
			{
				value = FastForwardSkipTimeRate2;
				InInstance.FastForwardSkipStage = 2u;
			}
			if (num2 <= TimeRate2RemainTime && InInstance.FastForwardSkipStage == 2)
			{
				value = FastForwardSkipTimeRate3;
				InInstance.FastForwardSkipStage = 3u;
			}
			if (num2 <= TimeRate3RemainTime && InInstance.FastForwardSkipStage == 3)
			{
				value = 1f;
				InInstance.FastForwardSkipStage = 4u;
			}
			if (InInstance.FastForwardSkipStage > fastForwardSkipStage)
			{
				SetTimeDilation(InInstance, value);
			}
			if (num2 <= 0.1f && InInstance.FastForwardSkipStage < 5)
			{
				InInstance.SequencePlayer.SeqJumpError = 0f - num2;
				InInstance.SequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams
				{
					UpdateMethod = EUpdatePositionMethod.Play,
					Time = num,
					PositionType = EMovieScenePositionType.Time,
					HasJumped = true
				});
				BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(InInstance);
				if (bGW_PreloadAssetMgr != null && bGW_PreloadAssetMgr.LevelSequenceConfig != null && bGW_PreloadAssetMgr.LevelSequenceConfig.StopEvent_WhenSkipping != null)
				{
					UBGUFunctionLibAK.PostAkEventOnDummyActor(string.Empty, bGW_PreloadAssetMgr.LevelSequenceConfig.StopEvent_WhenSkipping);
				}
				InInstance.FastForwardSkipStage = 5u;
			}
			if (num2 <= 0f)
			{
				BGW_EventCollection.Get(InInstance.PlayerController).Evt_ActiveBlackOut(IsActive: false);
				InInstance.FastForwardSkipStage = 0u;
			}
		}

		private void SetTimeDilation(MovieInstance InInstance, float Value)
		{
			UGameplayStatics.SetGlobalTimeDilation(InInstance.PlayerController, Value);
		}
	}

	public class MovieState_Stopping : MovieStateBase
	{
		public override EMoviePlayState StateTag => EMoviePlayState.Stopping;

		protected override void Enter(MovieInstance InInstance)
		{
			InInstance.SequencePlayer?.Stop();
			foreach (KeyValuePair<string, TWeakObject<AActor>> item in InInstance.PerformerCache)
			{
				string key = item.Key;
				TWeakObject<AActor> value = item.Value;
				AActor aActor = null;
				aActor = ((!value.IsValid()) ? BGU_DataUtil.GetActorByGuid(InInstance, key) : value.Get());
				if (aActor != null)
				{
					BUS_EventCollectionCS.Get(aActor)?.Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.PerformerTag.Event_AfterShowing);
				}
				else
				{
					BGW_EventCollection.Get(InInstance)?.Evt_SaveSceneObjEvent(item.Key, BGW_FlowUtils.PerformerTag.Event_AfterShowing);
				}
			}
			InInstance.PerformerCache.Clear();
			Next(InInstance);
		}
	}

	public class MovieState_PostPlayProcess : MovieStateBase
	{
		public override EMoviePlayState StateTag => EMoviePlayState.PostPlayProcess;

		protected override void Enter(MovieInstance InInstance)
		{
			InInstance.ClearPlayerCameraLock();
			InInstance?.AfterPlayNodeInstance.TriggerInput();
		}

		public override void OnProcessFinished(MovieInstance InInstance)
		{
			if (!InInstance.bNoSeqMovie)
			{
				InInstance.SequencePlayer?.Stop();
				InInstance.SequenceActor?.ResetBindings();
				InInstance.SequenceActor?.SetSequence(null);
			}
			foreach (string loadedTamer in InInstance.LoadedTamers)
			{
				InInstance.BGSEventCollection.Evt_UnMarkTamerAlwaysSpawn.Invoke(loadedTamer);
			}
			InInstance.LoadedTamers.Clear();
			foreach (string blockLoadedTamer in InInstance.BlockLoadedTamers)
			{
				InInstance.BGSEventCollection.Evt_UnMarkTamerBlockingSpawn.Invoke(blockLoadedTamer);
			}
			InInstance.BlockLoadedTamers.Clear();
			InInstance.TamerLoadCallbackDictionary.Clear();
			InInstance.ActionIDSet.Clear();
			InInstance.ActionIDFinishLoadCallbackDictionary.Clear();
			InInstance.ActionIDFinishLoadEventDictionary.Clear();
			BGUFunctionLibraryCS.BGUToggleGlobalURO(InInstance, bEnable: true);
			if (InInstance.IsNeedStopBGM)
			{
				InInstance.BGSEventCollection?.Evt_BGS_ResumeDefaultBGM.Invoke();
			}
			if (InInstance.IsNeedStopEnvSound)
			{
				UBGUFunctionLibAK.PostAkEventOnDummyActor("EVT_env_bus_volume_unmute", null);
			}
			if (InInstance.bTransBacking)
			{
				InInstance.EndTransBack();
			}
			if (InInstance.bDisableCameraCut)
			{
				Next(InInstance);
			}
			else
			{
				InInstance.CameraBlendOut();
			}
		}

		public override void OnBlendCameraComplete(MovieInstance InInstance)
		{
			if (!InInstance.bDisableCameraCut)
			{
				Next(InInstance);
			}
		}
	}

	public class MovieState_Finished : MovieStateBase
	{
		public override EMoviePlayState StateTag => EMoviePlayState.Finished;

		protected override void Enter(MovieInstance InInstance)
		{
			if (InInstance.SequenceType == ESequenceType.StorySequence)
			{
				BGW_GameArchiveMgr.Get(InInstance)?.MarkSaveArchive(EArchiveSaveSource.SeqPlayFinished, $"Seq ID : {InInstance.SequenceId}");
			}
			InInstance.SequencePlayer?.Stop();
			InInstance.UnrequestAllLevelStateInfo();
			InInstance.OnGraphEnd();
			InInstance.BGSEventCollection?.Evt_MovieInstanceFinish.Invoke(InInstance.MovieId, InInstance.SequenceId);
			foreach (TStrongObjectPtr<MovieNodeInstance> value in InInstance.NodeInstances.Values)
			{
				value.Set(null);
			}
			InInstance.NodeInstances.Clear();
			foreach (TStrongObjectPtr<MovieNodeInstance> value2 in InInstance.AddingNodeInstances.Values)
			{
				value2.Set(null);
			}
			InInstance.AddingNodeInstances.Clear();
			foreach (TStrongObjectPtr<MovieNodeInstance> value3 in InInstance.RemovingNodeInstances.Values)
			{
				value3.Set(null);
			}
			InInstance.RemovingNodeInstances.Clear();
			InInstance.TemplateAsset?.FinishInstance();
			InInstance.TemplateAsset = null;
			if (GSGameplayCVar.CVar_EnableDestroySequenceActor.GetValueInGameThread() == 1)
			{
				InInstance.SequenceActor?.DestroyActor();
			}
			InInstance.MovieFinishCallBack?.Invoke();
			InInstance.BGSEventCollection?.Evt_NotifyMovieEnd.Invoke(InInstance.SequenceId, InInstance.MovieId);
		}
	}

	public class FWarmingUpPlaySettings
	{
		public FMovieSequencePlaySettings PlaySettings { get; set; }

		public bool bBlockLoad { get; set; }

		public bool bUseMarkFrameLoop { get; set; }

		public List<string> StreamingLevelNames { get; } = new List<string>();

		public List<string> NeedPerformers { get; } = new List<string>();

		public int SeqStartFrame { get; set; }

		public int LoopStartFrame { get; set; }

		public int LoopEndFrame { get; set; }

		public int SeqEndFrame { get; set; }

		public bool bLoadFinished { get; set; }

		public bool bSequenceFinished { get; set; }

		public bool bPlayingMarkFrameLoop { get; set; }

		public int AssociationConfigId { get; set; }

		public EAssociationUnitSpawnType AssociationSpawnType { get; set; }
	}

	private TWeakObject<UCalliopeLevelSequencePlayer> SequencePlayerPtr;

	private TWeakObject<ACalliopeLevelSequenceActor> SequenceActorPtr;

	private bool bInSeqMove;

	private static bool OnSequencePlayStopped_IsValid;

	private static IntPtr OnSequencePlayStopped_FunctionAddress;

	private static int OnSequencePlayStopped_ParamsSize;

	private static bool OnSequencePlayFinished_IsValid;

	private static IntPtr OnSequencePlayFinished_FunctionAddress;

	private static int OnSequencePlayFinished_ParamsSize;

	private static bool OnLoadLevelStreamingFinish_IsValid;

	private static IntPtr OnLoadLevelStreamingFinish_FunctionAddress;

	private static int OnLoadLevelStreamingFinish_ParamsSize;

	private static bool OnLoadLevelStreamingFinish_ActionID_IsValid;

	private static int OnLoadLevelStreamingFinish_ActionID_Offset;

	private static bool OnLoadLevelStreamingFinish_Linkage_IsValid;

	private static int OnLoadLevelStreamingFinish_Linkage_Offset;

	private static int MovieIdCounter { get; set; }

	private static UClass PerformerClass { get; }

	private MovieStateBase CurrentState { get; set; }

	private ESequenceType SequenceType { get; set; }

	public int MovieId { get; private set; }

	public int SequenceId { get; private set; }

	public bool bCanRepeatPlay { get; private set; }

	private bool bCanSkip { get; set; }

	private bool bUseRelativeTransform { get; set; }

	public FMovieGraphPlaySettings PlaySettings { get; set; }

	private bool bNoSeqMovie { get; set; }

	private bool bHideHud { get; set; }

	private bool bHideDroppingFX { get; set; }

	private IBGC_MovieData MovieData { get; set; }

	private IBGC_TamerData TamerData { get; set; }

	public FCalliopeAssetReference TemplateAsset { get; set; }

	private FCalliopeGraph Graph { get; set; }

	private float CameraBlendOutTime { get; set; }

	private EViewTargetBlendFunction CameraBlendOutFunction { get; set; }

	private float CameraBlendOutFuncExp { get; set; }

	private EResetSpringArmRotationWay ResetSpringArmRotationWay { get; set; }

	public bool BlendOutBeforeCamera { get; set; }

	private FRotator CustomControllerRotation { get; set; }

	private bool IsNeedStopBGM { get; set; }

	private bool IsNeedStopEnvSound { get; set; }

	public bool bNeedPauseAfterPlaying { get; set; }

	private bool bSeqBindPlayer { get; set; }

	public EACInterruptType InterruptAiConversationType { get; set; }

	private MovieNodeInstance BeforePlayNodeInstance { get; set; }

	private MovieNodeInstance PreRollNodeInstance { get; set; }

	private MovieNodeInstance AfterPlayNodeInstance { get; set; }

	private MovieNodeInstance OnSkippingNodeInstance { get; set; }

	private Dictionary<string, MovieNodeInstance> CustomEventNodeInstances { get; } = new Dictionary<string, MovieNodeInstance>();

	private Dictionary<Guid, TStrongObjectPtr<MovieNodeInstance>> NodeInstances { get; } = new Dictionary<Guid, TStrongObjectPtr<MovieNodeInstance>>();

	private Dictionary<Guid, TStrongObjectPtr<MovieNodeInstance>> AddingNodeInstances { get; } = new Dictionary<Guid, TStrongObjectPtr<MovieNodeInstance>>();

	private Dictionary<Guid, TStrongObjectPtr<MovieNodeInstance>> RemovingNodeInstances { get; } = new Dictionary<Guid, TStrongObjectPtr<MovieNodeInstance>>();

	private UCalliopeLevelSequencePlayer SequencePlayer
	{
		get
		{
			return SequencePlayerPtr.Get();
		}
		set
		{
			SequencePlayerPtr.Set(value);
		}
	}

	private ACalliopeLevelSequenceActor SequenceActor
	{
		get
		{
			return SequenceActorPtr.Get();
		}
		set
		{
			SequenceActorPtr.Set(value);
		}
	}

	private ABGPPlayerController PlayerController { get; set; }

	private APlayerCameraManager PlayerCameraManager { get; set; }

	private BGS_GSEventCollection BGSEventCollection { get; set; }

	public bool bIsPlayingLoopMovie { get; set; }

	private bool bDisableCameraCut { get; set; }

	public bool bStopPreRollWhenBlendFinish { get; set; }

	public bool bLockArchive { get; set; }

	private uint PlayerMovementModeHandleID { get; set; }

	private bool bPlayerMoveModeDisabled { get; set; }

	private bool bCanDisablePlayerMoveMode { get; set; } = true;

	private Dictionary<FName, AActor> Performers { get; } = new Dictionary<FName, AActor>();

	private Dictionary<string, TWeakObject<AActor>> PerformerCache { get; } = new Dictionary<string, TWeakObject<AActor>>();

	private FWarmingUpPlaySettings WarmingUpPlaySettings { get; set; }

	private FMovieSequencePlaySettings SequencePlaySettings { get; set; }

	public Action InternalSequenceFinishedCallBack { get; set; } = delegate
	{
	};

	public Action MovieFinishCallBack { get; set; } = delegate
	{
	};

	public Action BeforePlayFinishCallBack { get; set; } = delegate
	{
	};

	private HashSet<int> ActionIDSet { get; } = new HashSet<int>();

	private Dictionary<int, string> ActionIDFinishLoadEventDictionary { get; } = new Dictionary<int, string>();

	private Dictionary<int, Action> ActionIDFinishLoadCallbackDictionary { get; } = new Dictionary<int, Action>();

	private HashSet<string> LoadedTamers { get; } = new HashSet<string>();

	private HashSet<string> BlockLoadedTamers { get; } = new HashSet<string>();

	private Dictionary<string, Action> TamerLoadCallbackDictionary { get; } = new Dictionary<string, Action>();

	public string OverlapGuid { get; set; }

	public ESequenceBlendInMatchPositionType MatchingPosType { get; set; }

	public FTransform PointAPos { get; set; }

	public FTransform PointBPos { get; set; }

	public float OriPointAStopTime { get; set; } = -1f;

	private bool bMatching2AWithMoving { get; set; }

	private float MatchingTransitionTime { get; set; } = -1f;

	private bool bCanTransitionLocomotion { get; set; }

	private float BlackScreenRemainTime { get; set; } = -1f;

	public bool bNeedFinishBlackScreen { get; set; }

	private float CurrentOriPointAStopTime { get; set; } = -1f;

	private bool bMatchingPos { get; set; }

	private bool bTransBacking { get; set; }

	private int TransBackEndFrameNumber { get; set; }

	public float RemainBlendTime { get; set; }

	public EUpdateClockSource ClockSource { get; set; }

	public ESkipType SkipType { get; private set; }

	public float Skip2Time { get; set; }

	public uint FastForwardSkipStage { get; set; }

	private List<int> ControlledStateLevelID { get; } = new List<int>();

	private List<int> LevelStateRequestingID { get; } = new List<int>();

	public Dictionary<string, float> IntervalCVars { get; } = new Dictionary<string, float>();

	public List<int> CVarHandles { get; } = new List<int>();

	private int LoadedLevelCount { get; set; }

	private int LoadedPerformerCount { get; set; }

	private Dictionary<string, bool> LevelLoadedStateDictionary { get; } = new Dictionary<string, bool>();

	private Dictionary<string, bool> PerformerLoadedStateDictionary { get; } = new Dictionary<string, bool>();

	public static MovieInstance Create(UObject InOwner, int InSequenceId, FMovieGraphPlaySettings InPlaySettings)
	{
		if (InOwner == null)
		{
			return null;
		}
		FUStMovieSequenceDesc movieSequenceDesc = BGW_GameDB.GetMovieSequenceDesc(InSequenceId);
		if (movieSequenceDesc == null)
		{
			return null;
		}
		string movieGraphPath = movieSequenceDesc.MovieGraphPath;
		if (string.IsNullOrEmpty(movieGraphPath))
		{
			return null;
		}
		FCalliopeGraph fCalliopeGraph = GameplayTagExtension.LoadGraph(movieGraphPath);
		if (fCalliopeGraph == null)
		{
			return null;
		}
		MovieInstance movieInstance = UObject.NewObject<MovieInstance>(InOwner);
		if (movieInstance == null)
		{
			return null;
		}
		movieInstance.Graph = fCalliopeGraph;
		movieInstance.TemplateAsset = FCalliopeAssetReference.CreateInstance(movieInstance, ECalliopeAssetType.Movie, movieGraphPath);
		movieInstance.bNoSeqMovie = false;
		movieInstance.MovieId = MovieIdCounter++;
		movieInstance.SequenceId = InSequenceId;
		InPlaySettings.bTriggerMonsterGoHome = movieSequenceDesc.IsTriggerMonsterGoHome == EGSYesNo.Yes;
		movieInstance.PlaySettings = InPlaySettings;
		movieInstance.IsNeedStopBGM = movieSequenceDesc.IsNeedStopBGM == EGSYesNo.Yes;
		movieInstance.IsNeedStopEnvSound = movieSequenceDesc.IsNeedStopEnvSound == EGSYesNo.Yes;
		movieInstance.SequenceType = movieSequenceDesc.SequenceType;
		movieInstance.InterruptAiConversationType = movieSequenceDesc.InterruptAiConversationType;
		movieInstance.OriPointAStopTime = movieSequenceDesc.MatchingPosTime;
		movieInstance.bLockArchive = movieSequenceDesc.CanSaveArchive != EGSYesNo.Yes;
		movieInstance.SkipType = movieSequenceDesc.SkipType;
		switch (movieSequenceDesc.ClockSource)
		{
		case ESeqClockSource.Tick:
			movieInstance.ClockSource = EUpdateClockSource.Tick;
			break;
		case ESeqClockSource.Platform:
			movieInstance.ClockSource = EUpdateClockSource.Platform;
			break;
		default:
			movieInstance.ClockSource = EUpdateClockSource.Tick;
			break;
		}
		if (GSGameplayCVar.CVar_ForceSequenceUseTickClockSource.GetValueInGameThread() == 1)
		{
			movieInstance.ClockSource = EUpdateClockSource.Tick;
		}
		if (movieSequenceDesc.PlayType == EPlayType.Once)
		{
			movieInstance.bCanRepeatPlay = false;
		}
		else
		{
			movieInstance.bCanRepeatPlay = true;
		}
		if (movieSequenceDesc.SequenceType == ESequenceType.InteractorSequence)
		{
			movieInstance.bUseRelativeTransform = true;
		}
		else
		{
			movieInstance.bUseRelativeTransform = false;
		}
		movieInstance.bDisableCameraCut = InPlaySettings.PlaybackSettings.DisableCameraCuts || movieInstance.PlaySettings.bUsePlayerCamera;
		movieInstance.bHideDroppingFX = movieSequenceDesc.IsHideDropFX == EGSYesNo.Yes;
		movieInstance.OnGraphInit();
		return movieInstance;
	}

	public static bool GetMoviePreviewLocation(UObject InOwner, int InSequenceID, out int OutLevelID, out FVector PreviewPosition, out FRotator PreviewRotation)
	{
		OutLevelID = 0;
		PreviewPosition = FVector.ZeroVector;
		PreviewRotation = FRotator.ZeroRotator;
		if (GSGameplayCVar.CVar_MoviePreviewEnable.GetValueInGameThread() == 0)
		{
			return false;
		}
		if (InOwner == null)
		{
			return false;
		}
		FUStMovieSequenceDesc movieSequenceDesc = BGW_GameDB.GetMovieSequenceDesc(InSequenceID);
		if (movieSequenceDesc == null)
		{
			return false;
		}
		if (string.IsNullOrEmpty(movieSequenceDesc.SeqDesc) || InSequenceID < 10)
		{
			return false;
		}
		if (!int.TryParse(InSequenceID.ToString().Substring(0, 2), out OutLevelID))
		{
			return false;
		}
		string movieGraphPath = movieSequenceDesc.MovieGraphPath;
		if (string.IsNullOrEmpty(movieGraphPath))
		{
			return false;
		}
		FCalliopeGraph fCalliopeGraph = GameplayTagExtension.LoadGraph(movieGraphPath);
		if (fCalliopeGraph == null)
		{
			return false;
		}
		if (!FCalliopeGraph.IsValid(fCalliopeGraph))
		{
			return false;
		}
		MovieNodeInstance_Start movieNodeInstance_Start = null;
		foreach (FCalliopeNode node in fCalliopeGraph.Nodes)
		{
			if (node.NodeClass.Equals(B1CalliopeDef.MovieNode.Start))
			{
				movieNodeInstance_Start = MovieNodeInstanceFactory.Create(node, InOwner) as MovieNodeInstance_Start;
				if (movieNodeInstance_Start != null)
				{
					break;
				}
			}
		}
		if ((object)movieNodeInstance_Start != null && movieNodeInstance_Start.StartCameraTransform.Length != 0)
		{
			FTransform fTransform = movieNodeInstance_Start.StartCameraTransform[0];
			PreviewPosition = fTransform.GetLocation();
			PreviewRotation = fTransform.GetRotation().Rotator();
			return true;
		}
		return false;
	}

	public bool IsInState(EMoviePlayState InState)
	{
		return CurrentState.StateTag == InState;
	}

	public string GetCurrentStateStr()
	{
		return CurrentState.StateTag.ToString();
	}

	private void OnGraphInit()
	{
		if (!FCalliopeGraph.IsValid(Graph))
		{
			return;
		}
		foreach (FCalliopeNode node in Graph.Nodes)
		{
			MovieNodeInstance movieNodeInstance = MovieNodeInstanceFactory.Create(node, this);
			if (movieNodeInstance == null || NodeInstances.ContainsKey(movieNodeInstance.Node.NodeGuid))
			{
				continue;
			}
			if (node.NodeClass.Equals(B1CalliopeDef.MovieNode.BeforePlay))
			{
				BeforePlayNodeInstance = movieNodeInstance;
			}
			else if (node.NodeClass.Equals(B1CalliopeDef.MovieNode.AfterPlay))
			{
				AfterPlayNodeInstance = movieNodeInstance;
			}
			else if (node.NodeClass.Equals(B1CalliopeDef.MovieNode.PreRoll))
			{
				PreRollNodeInstance = movieNodeInstance;
			}
			else if (movieNodeInstance is MovieNodeInstance_CustomEvent movieNodeInstance_CustomEvent)
			{
				CustomEventNodeInstances.Add(movieNodeInstance_CustomEvent.EventName, movieNodeInstance_CustomEvent);
			}
			else if (node.NodeClass.Equals(B1CalliopeDef.MovieNode.OnSkipping))
			{
				OnSkippingNodeInstance = movieNodeInstance;
			}
			else if (node.NodeClass.Equals(B1CalliopeDef.MovieNode.PlayEnd))
			{
				MovieNodeInstance_PlayEnd movieNodeInstance_PlayEnd = movieNodeInstance as MovieNodeInstance_PlayEnd;
				if (movieNodeInstance_PlayEnd != null)
				{
					CameraBlendOutTime = movieNodeInstance_PlayEnd.CameraBlendOutTime;
					CameraBlendOutFunction = movieNodeInstance_PlayEnd.CameraBlendOutFunction;
					CameraBlendOutFuncExp = movieNodeInstance_PlayEnd.CameraBlendOutFuncExp;
					ResetSpringArmRotationWay = movieNodeInstance_PlayEnd.ResetSpringArmRotationWay;
					BlendOutBeforeCamera = movieNodeInstance_PlayEnd.BlendOutBeforeCamera;
					CustomControllerRotation = movieNodeInstance_PlayEnd.CustomControllerRotation;
				}
			}
			NodeInstances.Add(movieNodeInstance.Node.NodeGuid, new TStrongObjectPtr<MovieNodeInstance>(movieNodeInstance));
		}
		PlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this) as ABGPPlayerController;
		PlayerCameraManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(this);
		MovieData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(this);
		TamerData = BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(this);
		BGSEventCollection = BGS_EventCollectionCS.Get(this);
		BGSEventCollection.Evt_NotifyTamerSpawnUnit += new Del_Void_String(OnNotifyTamerSpawnUnit);
		BGSEventCollection.Evt_BGS_OnLevelsStateRequestBatchFinished += new Del_BGS_OnLevelsStateRequestBatchFinished(OnLevelsStateRequestBatchFinished);
		MovieState_Idle movieState_Idle = (MovieState_Idle)(CurrentState = (MovieState_Idle)MovieStateBase.Get(EMoviePlayState.Idle));
		movieState_Idle.NotifyEnterForIdle(this);
		bCanSkip = true;
		Skip2Time = 0f;
		FastForwardSkipStage = 0u;
		bIsPlayingLoopMovie = false;
	}

	private void OnGraphEnd()
	{
		if (!FCalliopeGraph.IsValid(Graph))
		{
			return;
		}
		foreach (TStrongObjectPtr<MovieNodeInstance> value in NodeInstances.Values)
		{
			value.Get().Shutdown();
		}
		NodeInstances.Clear();
		AddingNodeInstances.Clear();
		RemovingNodeInstances.Clear();
		ClearLoadCount();
		BGSEventCollection.Evt_NotifyTamerSpawnUnit -= new Del_Void_String(OnNotifyTamerSpawnUnit);
		BGSEventCollection.Evt_BGS_OnLevelsStateRequestBatchFinished -= new Del_BGS_OnLevelsStateRequestBatchFinished(OnLevelsStateRequestBatchFinished);
		TemplateAsset.FinishInstance();
		TemplateAsset = null;
		ResetAllCVars();
	}

	private void ResetAllCVars()
	{
		foreach (int cVarHandle in CVarHandles)
		{
			CVarFuncLib.DestroyHandle(cVarHandle);
		}
		CVarHandles.Clear();
	}

	private bool EnableMovieCVar()
	{
		if (GSGameplayCVar.CVar_Movie_DisableCVarCtrl.GetValueInGameThread() == 0)
		{
			return true;
		}
		return false;
	}

	public void StartGraph()
	{
		if (EnableMovieCVar())
		{
			IntervalCVars.Clear();
			if (IConsoleManager.Get().FindConsoleVariable("sg.ShadingQuality").GetInt() > 2)
			{
				IntervalCVars.Add("r.Streaming.IgnoreMeshStreamOut", 1f);
				IntervalCVars.Add("r.SkeletalMeshLODBias", -10f);
				IntervalCVars.Add("tfx.LODExpMin", 0.02f);
				IntervalCVars.Add("tfx.LODExpMax", 0.02f);
				IntervalCVars.Add("tfx.SimCountMax", 2f);
			}
			else
			{
				IntervalCVars.Add("r.Streaming.IgnoreMeshStreamOut", 1f);
				IntervalCVars.Add("r.SkeletalMeshLODBias", -1f);
				IntervalCVars.Add("tfx.LODExpMin", 0.1f);
				IntervalCVars.Add("tfx.LODExpMax", 0.1f);
				IntervalCVars.Add("r.FreezeShadowFOV", 65f);
			}
			IntervalCVars.Add("tfx.SimScreenSize", 0.01f);
			IntervalCVars.Add("tfx.CullScreenSize", 0.005f);
			IntervalCVars.Add("tfx.SimClipping", 0f);
			IntervalCVars.Add("r.AllowPointLightCubemapShadows", 1f);
			IntervalCVars.Add("p.RigidBodyNode", 0f);
			IntervalCVars.Add("p.Cloth.GSClothingSimWhenRendered", 0f);
			IntervalCVars.Add("r.TressFX.BufferInitUploadThreshold", 1000f);
			IntervalCVars.Add("r.TressFX.AllowTFXResourceMultiFrameInit", 0f);
			IntervalCVars.Add("tfx.LowPolyInitDist", -1f);
			IntervalCVars.Add("r.Streaming.FramesForFullUpdate", 0f);
			IntervalCVars.Add("fx.Niagara.Scalability.VisibilityCulling", 0f);
			IntervalCVars.Add("r.Lumen.RadianceCache.Update.FrameInterval", 0f);
			if (bHideDroppingFX)
			{
				IntervalCVars.Add("b.DropItemSystemHideDroppingFX", 1f);
			}
			IntervalCVars.Add("r.SkinCache.Mode", 0f);
		}
		CurrentState.TransitionByEvent(this, EMoviePlayEvent.StartGraph, bFinished: true);
	}

	public void OnTick(float DeltaTime)
	{
		CurrentState.NotifyTick(this, DeltaTime);
		foreach (KeyValuePair<Guid, TStrongObjectPtr<MovieNodeInstance>> addingNodeInstance in AddingNodeInstances)
		{
			if (RemovingNodeInstances.ContainsKey(addingNodeInstance.Key))
			{
				RemovingNodeInstances.Remove(addingNodeInstance.Key);
			}
			else
			{
				NodeInstances.Add(addingNodeInstance.Key, addingNodeInstance.Value);
			}
		}
		AddingNodeInstances.Clear();
		foreach (KeyValuePair<Guid, TStrongObjectPtr<MovieNodeInstance>> removingNodeInstance in RemovingNodeInstances)
		{
			NodeInstances.Remove(removingNodeInstance.Key);
			removingNodeInstance.Value.Get().Shutdown();
		}
		RemovingNodeInstances.Clear();
		foreach (TStrongObjectPtr<MovieNodeInstance> value in NodeInstances.Values)
		{
			MovieNodeInstance movieNodeInstance = value.Get();
			if (movieNodeInstance.ActivationState == ActivationState.Active)
			{
				movieNodeInstance.Tick(DeltaTime);
			}
		}
	}

	public void OnFlowFinished()
	{
		CurrentState.OnProcessFinished(this);
	}

	private void ExecCmdOnStart()
	{
		if (!EnableMovieCVar())
		{
			return;
		}
		foreach (KeyValuePair<string, float> intervalCVar in IntervalCVars)
		{
			int num = CVarFuncLib.CreateHandle(intervalCVar.Key);
			CVarFuncLib.SetByHandleWithPriority(num, intervalCVar.Value, EConsoleVariablePriority.Vfx, 0);
			CVarHandles.Add(num);
		}
	}

	private void ExecCmdOnFinish()
	{
		ResetAllCVars();
	}

	public void PlayWarmingUpSequence(FWarmingUpPlaySettings InWarmingUpPlaySettings)
	{
		WarmingUpPlaySettings = InWarmingUpPlaySettings;
		CurrentState.TransitionByEvent(this, EMoviePlayEvent.WarmingUp, bFinished: false);
	}

	public void PlayStartSequence(FMovieSequencePlaySettings InSequencePlaySettings)
	{
		SequencePlaySettings = InSequencePlaySettings;
		CurrentState.TransitionByEvent(this, EMoviePlayEvent.PlayStart, bFinished: false);
	}

	public void PlaySequenceCut(FMovieSequencePlaySettings InMoviePlaySettings)
	{
		SequencePlaySettings = InMoviePlaySettings;
		CurrentState.TransitionByEvent(this, EMoviePlayEvent.PlayCut, bFinished: false);
	}

	public void PlayPreRollSequence(FMovieSequencePlaySettings InMoviePlaySettings)
	{
		SequencePlaySettings = InMoviePlaySettings;
		CurrentState.TransitionByEvent(this, EMoviePlayEvent.PlayPreRoll, bFinished: false);
	}

	public bool CanSkipMovie()
	{
		return CurrentState.CanBeSkip(this);
	}

	public void SkipMovie()
	{
		CurrentState.TransitionByEvent(this, EMoviePlayEvent.Skip, bFinished: false);
	}

	public void SkipToMarkedFrame(string InMarkedFrameLabel)
	{
		CurrentState.Jump2MarkedFrame(this, InMarkedFrameLabel);
	}

	private void OnCustomEvent(FGameplayTag EventTag)
	{
		if (CustomEventNodeInstances.TryGetValue(EventTag.TagName.PlainName, out var value))
		{
			value.TriggerInput();
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.MovieInstance:OnSequencePlayFinished")]
	private void OnSequencePlayFinished()
	{
		CurrentState?.OnSequencePlayFinished(this);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.MovieInstance:OnSequencePlayStopped")]
	private void OnSequencePlayStopped()
	{
		CurrentState?.OnSequencePlayFinished(this);
	}

	public void OnMoviePlayEnd()
	{
		CurrentState.TransitionByEvent(this, EMoviePlayEvent.Stop, bFinished: true);
	}

	public void OnTriggerCustomMovieEvent(FGameplayTag EventTag)
	{
		OnCustomEvent(EventTag);
	}

	public void OnPauseCurrentMovie()
	{
		CurrentState.TransitionByEvent(this, EMoviePlayEvent.Pause, bFinished: false);
	}

	public void OnResumeCurrentMovie()
	{
		bNeedPauseAfterPlaying = false;
		CurrentState.TransitionByEvent(this, EMoviePlayEvent.Resume, bFinished: true);
	}

	public void OnMarkCanFinishLoopMovie()
	{
		if (SequencePlayer != null && bIsPlayingLoopMovie)
		{
			SequencePlayer.StopLooping();
			bIsPlayingLoopMovie = false;
		}
	}

	private bool Match2Point(FTransform InTargetPointTransform, bool bInterp = true)
	{
		BGUCharacterCS bGUCharacterCS = PlayerController.GetControlledPawn() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(bGUCharacterCS);
		EAIMoveSpeedType moveSpeedType = ((readOnlyData == null || !readOnlyData.HasState(EBGUUnitState.Walking)) ? EAIMoveSpeedType.RUN : EAIMoveSpeedType.JOG);
		FMatchingPositionMoveParam Param = new FMatchingPositionMoveParam
		{
			MatchingPosType = EMatchingPosType.InterpolationLiner,
			TargetTrans = InTargetPointTransform,
			MoveSpeedType = moveSpeedType,
			bIncludeSelfRadius = false,
			AcceptableRadius = 50f,
			InterpMoveTime = (bInterp ? 0.3f : 0f),
			InterpMoveCallbackFunc = OnBlendPositionFinish
		};
		bMatchingPos = true;
		BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_MatchingPositionMove.Invoke(in Param);
		return true;
	}

	private void OnBlendPositionFinish(bool Success)
	{
		_ = PlayerController.GetControlledPawn() as BGUCharacterCS != null;
		bMatchingPos = false;
		CurrentState.OnBlendPositionFinished(this, Success);
	}

	public void Shutdown()
	{
		CurrentState.NotifyShutdown(this);
	}

	private void OnTriggerNodeInput(FCalliopeNode Node, string InputPin)
	{
		MovieNodeInstance movieNodeInstance = FindOrAddNodeInstance(Node);
		if (movieNodeInstance != null)
		{
			movieNodeInstance.TriggerInput(InputPin);
		}
	}

	public void ExecuteEdge(FCalliopeEdge Edge)
	{
		MovieNodeInstance movieNodeInstance = FindOrAddNodeInstance(Edge.To);
		if (movieNodeInstance != null)
		{
			movieNodeInstance.TriggerInput(Edge.ToPinName);
		}
	}

	private void RegisterNodeInstance(MovieNodeInstance InNodeInstance)
	{
		InNodeInstance.ParentInstance = this;
		if (!AddingNodeInstances.ContainsKey(InNodeInstance.Node.NodeGuid) && !NodeInstances.ContainsKey(InNodeInstance.Node.NodeGuid))
		{
			AddingNodeInstances.Add(InNodeInstance.Node.NodeGuid, new TStrongObjectPtr<MovieNodeInstance>(InNodeInstance));
		}
	}

	public void UnregisterNodeInstance(MovieNodeInstance InNodeInstance)
	{
		Guid nodeGuid = InNodeInstance.Node.NodeGuid;
		if (!RemovingNodeInstances.ContainsKey(nodeGuid) && NodeInstances.ContainsKey(nodeGuid))
		{
			RemovingNodeInstances.Add(nodeGuid, NodeInstances[nodeGuid]);
		}
	}

	private MovieNodeInstance FindOrAddNodeInstance(FCalliopeNode Node)
	{
		Guid nodeGuid = Node.NodeGuid;
		if (NodeInstances.ContainsKey(nodeGuid))
		{
			return NodeInstances[nodeGuid].Get();
		}
		if (AddingNodeInstances.ContainsKey(nodeGuid))
		{
			return AddingNodeInstances[nodeGuid].Get();
		}
		MovieNodeInstance movieNodeInstance = MovieNodeInstanceFactory.Create(Node, this);
		if (movieNodeInstance != null)
		{
			RegisterNodeInstance(movieNodeInstance);
		}
		return movieNodeInstance;
	}

	public void DisableCameraCutWithBlendOut()
	{
		if (!bDisableCameraCut)
		{
			ClearPlayerCameraLock();
			SequencePlayer?.SetDisableCameraCuts(bInDisableCameraCuts: true);
			CameraBlendOut();
			bDisableCameraCut = true;
			if (IsNeedStopBGM)
			{
				BGSEventCollection?.Evt_BGS_ResumeDefaultBGM.Invoke();
			}
			if (IsNeedStopEnvSound)
			{
				UBGUFunctionLibAK.PostAkEventOnDummyActor("EVT_env_bus_volume_unmute", null);
			}
		}
	}

	private void ClearPlayerCameraLock()
	{
		if (!bDisableCameraCut)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(PlayerController.GetControlledPawn() as BGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ClearCameraLock.Invoke();
			}
		}
	}

	private void CameraBlendOut()
	{
		ExecCmdOnFinish();
		BGUCharacterCS bGUCharacterCS = PlayerController.GetControlledPawn() as BGUCharacterCS;
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
		if (bUS_GSEventCollection != null)
		{
			switch (ResetSpringArmRotationWay)
			{
			case EResetSpringArmRotationWay.Reset2PlayerRotation:
				bUS_GSEventCollection.Evt_ResetCameraSpringArmRot.Invoke();
				break;
			case EResetSpringArmRotationWay.Reset2NearestRotation:
				bUS_GSEventCollection.Evt_MoveCameraSpringArmRot2Nearest.Invoke();
				break;
			case EResetSpringArmRotationWay.UseCustomRotation:
				bUS_GSEventCollection.Evt_MoveCameraSpringArm2CustomRotation.Invoke(CustomControllerRotation);
				break;
			}
		}
		BPS_EventCollectionCS.Get(PlayerController)?.Evt_BPS_EnableCameraFoliageFade.Invoke(P1: true);
		if (bHideHud)
		{
			BGUFunctionLibraryCS.BGUActiveNoSeqUI(bGUCharacterCS, IsActive: true);
		}
		BGW_LevelStreamingManger.Get(this)?.ResumeAllLevelDistanceStreaming();
		BPS_EventCollectionCS.Get(PlayerController)?.Evt_BPS_ResumeCostEnergy.Invoke();
		BGSEventCollection.Evt_EnableTamerBack2Load.Invoke(P1: true);
		BUS_GSEventCollection bUS_GSEventCollection2 = BUS_EventCollectionCS.Get(bGUCharacterCS);
		bUS_GSEventCollection2?.Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.PerformerTag.Event_AfterShowing);
		bUS_GSEventCollection2?.Evt_ClearFallingHeight.Invoke();
		bUS_GSEventCollection2?.Evt_PauseSafeFallingCheck.Invoke(P1: false);
		bUS_GSEventCollection2?.Evt_SetPlayerLocomotionInSequenceTransition.Invoke(IsSelfRescue: false);
		ResetPlayerMoveMode();
		bCanDisablePlayerMoveMode = false;
		bUS_GSEventCollection?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.UnitInputWalkRelease, 0f);
		bUS_GSEventCollection?.Evt_SwitchFreeCameraMode.Invoke(EPlayerFreeCameraType.AutoTrail);
		if (BlendOutBeforeCamera)
		{
			bool bLockOutgoing = ResetSpringArmRotationWay != EResetSpringArmRotationWay.UseCustomRotation || SkipType != ESkipType.FastForward;
			PlayerController.SetViewTargetWithBlend(bGUCharacterCS, CameraBlendOutTime, CameraBlendOutFunction, CameraBlendOutFuncExp, bLockOutgoing);
			OnCameraBlendOutComplete();
		}
		else
		{
			OnCameraBlendOutComplete();
		}
	}

	public void GiveBackControlRightForMonster(string MonsterGuid)
	{
		BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(this, MonsterGuid))?.Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.PerformerTag.Event_AfterShowing);
	}

	private void OnCameraBlendOutComplete()
	{
		if (!bDisableCameraCut)
		{
			BUS_EventCollectionCS.Get(PlayerController.GetControlledPawn())?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantTransInSeq, IsRemove: true);
			BPS_EventCollectionCS.Get(PlayerController)?.Evt_BPS_EndCinematicIgnoreMode.Invoke();
			BGW_EventCollection.Get(this)?.Evt_SetAllUnitCannotDead(P1: false);
		}
		CurrentState.OnBlendCameraComplete(this);
	}

	private void DisablePlayerMove()
	{
		if (!bCanDisablePlayerMoveMode || bPlayerMoveModeDisabled)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = PlayerController.GetControlledPawn() as BGUCharacterCS;
		if (!(bGUCharacterCS != null) || bDisableCameraCut)
		{
			return;
		}
		bPlayerMoveModeDisabled = true;
		bGUCharacterCS.CharacterMovement.StopMovementImmediately();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
		bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.UnitInputSprintRelease, 0f);
		bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.UnitInputWalkRelease, 0f);
		bUS_GSEventCollection.Evt_MovementForceStop.Invoke();
		IBUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(bGUCharacterCS);
		if (readOnlyData != null)
		{
			if (PlayerMovementModeHandleID == 0)
			{
				bUS_GSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 6, 0u, 0u, bSetDefaultProperty: false, "MovieInstance");
				PlayerMovementModeHandleID = readOnlyData.GetLastHandleID();
			}
			else
			{
				bUS_GSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 6, PlayerMovementModeHandleID, 0u, bSetDefaultProperty: false, "MovieInstance");
			}
		}
	}

	private void ResetPlayerMoveMode()
	{
		if (bPlayerMoveModeDisabled)
		{
			BUS_EventCollectionCS.Get(PlayerController.GetControlledPawn())?.Evt_ResetProperty.Invoke(PlayerMovementModeHandleID);
			if (PlayerController.GetControlledPawn() is ACharacter aCharacter && aCharacter.CharacterMovement.IsFalling())
			{
				aCharacter.CharacterMovement.SetMovementMode(aCharacter.CharacterMovement.DefaultLandMovementMode, 0);
			}
			PlayerMovementModeHandleID = 0u;
			bPlayerMoveModeDisabled = false;
		}
	}

	public void MarkCanBeSkipped(bool bInCanSkip)
	{
		bCanSkip = bInCanSkip;
	}

	public ULevelSequencePlayer BetaGetSequencePlayer()
	{
		return SequencePlayer;
	}

	public void BeginTransBack()
	{
		IBPC_PlayerTagData playerStateReadonlyData = BGU_DataUtil.GetPlayerStateReadonlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(PlayerController);
		if (playerStateReadonlyData != null && playerStateReadonlyData.HasTag(EBGPPlayerTag.Transforming))
		{
			bTransBacking = true;
			BPS_EventCollectionCS.Get(PlayerController)?.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.CMGTransBack, default(PlayerTransParam));
		}
		IBUC_MagicallyChangeData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_MagicallyChangeData, BUC_MagicallyChangeData>(PlayerController.GetControlledPawn());
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.IsDurMagicallyChange())
		{
			bTransBacking = true;
		}
	}

	private void EndTransBack()
	{
		if (bTransBacking)
		{
			BUS_EventCollectionCS.Get(PlayerController.GetControlledPawn())?.Evt_OnMagicallyChangeBreak.Invoke();
			BGW_EventCollection.Get(this).Evt_DestoryWaitSeqOldTransActor();
			bTransBacking = false;
		}
	}

	private void ResetPlayerFreeCamera()
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(PlayerController.GetControlledPawn());
		bUS_GSEventCollection?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.UnitInputWalkRelease, 0f);
		bUS_GSEventCollection?.Evt_SwitchFreeCameraMode.Invoke(EPlayerFreeCameraType.AutoTrail);
	}

	public void OnEnterSeqMove()
	{
		if (!bInSeqMove)
		{
			bInSeqMove = true;
			APawn controlledPawn = PlayerController.GetControlledPawn();
			if (controlledPawn != null)
			{
				BUS_EventCollectionCS.Get(controlledPawn)?.Evt_SwitchFreeCameraMode.Invoke(EPlayerFreeCameraType.SeqMatch);
			}
		}
	}

	public void OnLeaveSeqMove()
	{
		if (bSeqBindPlayer && bInSeqMove && !bDisableCameraCut)
		{
			APawn controlledPawn = PlayerController.GetControlledPawn();
			if (controlledPawn != null)
			{
				string actorGuid = BGU_DataUtil.GetActorGuid(controlledPawn);
				if (!PerformerCache.ContainsKey(actorGuid))
				{
					PerformerCache.Add(actorGuid, new TWeakObject<AActor>(controlledPawn));
					BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(controlledPawn);
					bUS_GSEventCollection?.Evt_SceneObjTransitByEventNoSaveState.Invoke(BGW_FlowUtils.PerformerTag.Event_Show);
					bUS_GSEventCollection?.Evt_SwitchFreeCameraMode.Invoke(EPlayerFreeCameraType.AutoTrail);
					DisablePlayerMove();
				}
			}
		}
		bInSeqMove = false;
	}

	private void FinishBlackScreenIfNeed(AActor CameraActor)
	{
		if (bNeedFinishBlackScreen)
		{
			if (CameraActor != null)
			{
				PlayerController.SetViewTargetWithBlend(CameraActor);
				RemainBlendTime = 0f;
			}
			PlayerCameraManager.StartCameraFade(1f, 0f, 1f, FLinearColor.Black);
			bNeedFinishBlackScreen = false;
		}
	}

	private bool IsLoadFinished()
	{
		if (LoadedPerformerCount >= PerformerLoadedStateDictionary.Count && LoadedLevelCount >= LevelLoadedStateDictionary.Count)
		{
			return CheckLevelStateRequestFinished();
		}
		return false;
	}

	private bool IsLoadFinishedForWarmmingUp()
	{
		if (LoadedPerformerCount >= PerformerLoadedStateDictionary.Count)
		{
			return LoadedLevelCount >= LevelLoadedStateDictionary.Count;
		}
		return false;
	}

	private void ClearLoadCount()
	{
		LoadedLevelCount = 0;
		LoadedPerformerCount = 0;
		LevelLoadedStateDictionary.Clear();
		PerformerLoadedStateDictionary.Clear();
	}

	private void RequestLoadTamer(bool bUseBlockLoad, string NeedPerformer)
	{
		if (PerformerLoadedStateDictionary.ContainsKey(NeedPerformer))
		{
			return;
		}
		PerformerLoadedStateDictionary.Add(NeedPerformer, value: false);
		RequestLoadPerformerTamers(bUseBlockLoad, NeedPerformer, delegate
		{
			if (!PerformerLoadedStateDictionary[NeedPerformer])
			{
				PerformerLoadedStateDictionary[NeedPerformer] = true;
				int loadedPerformerCount = LoadedPerformerCount;
				LoadedPerformerCount = loadedPerformerCount + 1;
			}
		});
	}

	public void RequestLoadLevel(string StreamingLevel, bool bMakeVisibleAfterLoaded = false, bool bShouldBlockOnLoad = false, string FinishLoadEvent = null)
	{
		if (LevelLoadedStateDictionary.ContainsKey(StreamingLevel))
		{
			return;
		}
		LevelLoadedStateDictionary.Add(StreamingLevel, value: false);
		LoadStreamingLevels(StreamingLevel, bMakeVisibleAfterLoaded, bShouldBlockOnLoad, FinishLoadEvent, delegate
		{
			if (!LevelLoadedStateDictionary[StreamingLevel])
			{
				int loadedLevelCount = LoadedLevelCount;
				LoadedLevelCount = loadedLevelCount + 1;
				LevelLoadedStateDictionary[StreamingLevel] = true;
			}
		});
	}

	private void RequestLoadPerformerTamers(bool bBlockLoad, string TamerGuid, Action FinishLoadCallback)
	{
		if (bBlockLoad)
		{
			BlockLoadPerformerTamer(TamerGuid, FinishLoadCallback);
		}
		else
		{
			LoadPerformerTamers(TamerGuid, FinishLoadCallback);
		}
	}

	private void LoadStreamingLevels(string StreamingLevel, bool bMakeVisibleAfterLoaded = false, bool bShouldBlockOnLoad = false, string FinishLoadEvent = null, Action FinishCallback = null)
	{
		int num = LoadStreamingLevelInternal(StreamingLevel, bMakeVisibleAfterLoaded, bShouldBlockOnLoad);
		if (num != -1)
		{
			if (!string.IsNullOrEmpty(FinishLoadEvent))
			{
				ActionIDFinishLoadEventDictionary.Add(num, FinishLoadEvent);
			}
			if (FinishCallback != null)
			{
				ActionIDFinishLoadCallbackDictionary[num] = FinishCallback;
			}
		}
	}

	private int LoadStreamingLevelInternal(string StreamingLevel, bool bMakeVisibleAfterLoaded, bool bShouldBlockOnLoad)
	{
		for (int i = 0; i < 100; i++)
		{
			if (!ActionIDSet.Contains(i))
			{
				UBGUFunctionLibrary.BGULoadStreamLevel(this, new FName(StreamingLevel), bMakeVisibleAfterLoaded, bShouldBlockOnLoad: false, this, B1GlobalFNames.OnLoadLevelStreamingFinish, i);
				ActionIDSet.Add(i);
				return i;
			}
		}
		return -1;
	}

	public void UnloadStreamingLevel(string StreamingLevel)
	{
		if (LevelLoadedStateDictionary.TryGetValue(StreamingLevel, out var value))
		{
			LevelLoadedStateDictionary.Remove(StreamingLevel);
			if (value)
			{
				LoadedLevelCount--;
			}
		}
		UBGUFunctionLibrary.BGUUnloadStreamLevel(this, new FName(StreamingLevel), bShouldBlockOnUnload: false, null, FName.None);
	}

	public void SetStreamingLevelsVisibility(string StreamingLevelName, bool bVisible)
	{
		ULevelStreaming uLevelStreaming = null;
		foreach (ULevelStreaming item in UBGWFunctionLibrary.BGWGetAllStreamingLevels(this))
		{
			if (item != null && item.GetWorldAssetPackageFName().ToString().EndsWith(StreamingLevelName, ignoreCase: true, CultureInfo.CurrentCulture))
			{
				uLevelStreaming = item;
				break;
			}
		}
		if (uLevelStreaming != null)
		{
			uLevelStreaming.SetShouldBeVisible(bVisible);
			if (bVisible && !uLevelStreaming.IsLevelLoaded())
			{
				uLevelStreaming.SetShouldBeLoaded(bInShouldBeLoaded: true);
				UGameplayStatics.FlushLevelStreaming(this);
			}
			else
			{
				UBGUFunctionLibrary.BGUFlushLevelStreamingOnlyVisibility(this);
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.MovieInstance:OnLoadLevelStreamingFinish")]
	private void OnLoadLevelStreamingFinish(int ActionID, int Linkage)
	{
		if (ActionIDSet.Contains(ActionID))
		{
			ActionIDSet.Remove(ActionID);
			if (ActionIDFinishLoadEventDictionary.TryGetValue(ActionID, out var value))
			{
				ActionIDFinishLoadEventDictionary.Remove(ActionID);
				OnCustomEvent(GameplayTagExtension.MakeGameplayTag(value));
			}
			if (ActionIDFinishLoadCallbackDictionary.TryGetValue(ActionID, out var value2))
			{
				ActionIDFinishLoadCallbackDictionary.Remove(ActionID);
				value2();
			}
		}
	}

	private void BlockLoadPerformerTamer(string TamerGuid, Action FinishLoadCallback)
	{
		BGSEventCollection.Evt_MarkTamerBlockingSpawn.Invoke(TamerGuid);
		BlockLoadedTamers.Add(TamerGuid);
		if (FinishLoadCallback != null)
		{
			if (TamerData.IsUnitSpawnFinished(TamerGuid))
			{
				FinishLoadCallback();
			}
			else
			{
				TamerLoadCallbackDictionary[TamerGuid] = FinishLoadCallback;
			}
		}
	}

	private void LoadPerformerTamers(string TamerGuid, Action FinishLoadCallback)
	{
		BGSEventCollection.Evt_MarkTamerAlwaysSpawn.Invoke(TamerGuid);
		LoadedTamers.Add(TamerGuid);
		if (FinishLoadCallback != null)
		{
			if (TamerData.IsUnitSpawnFinished(TamerGuid))
			{
				FinishLoadCallback();
			}
			else
			{
				TamerLoadCallbackDictionary[TamerGuid] = FinishLoadCallback;
			}
		}
	}

	private void OnNotifyTamerSpawnUnit(string TamerGuid)
	{
		if (TamerLoadCallbackDictionary.TryGetValue(TamerGuid, out var value))
		{
			value();
			TamerLoadCallbackDictionary.Remove(TamerGuid);
		}
	}

	public void RequestSetLevelStateInfo(int LevelID, int ConfigID)
	{
		BGW_LevelStreamingStateMgr bGW_LevelStreamingStateMgr = BGW_LevelStreamingStateMgr.Get(this);
		if (!(bGW_LevelStreamingStateMgr == null))
		{
			int item = bGW_LevelStreamingStateMgr.UpdateLevelState(Graph.GraphName + " : " + GetFullName(), LevelID, ConfigID, EGSLevelStateInfoLayerType.CMG, Graph.GraphName + " : " + GetName());
			if (!ControlledStateLevelID.Contains(LevelID))
			{
				ControlledStateLevelID.Add(LevelID);
			}
			if (!LevelStateRequestingID.Contains(item))
			{
				LevelStateRequestingID.Add(item);
			}
		}
	}

	public bool CheckLevelStateRequestFinished()
	{
		if (LevelStateRequestingID.Count > 0)
		{
			return false;
		}
		return true;
	}

	private void OnLevelsStateRequestBatchFinished(int BatchFirstRequestID, int BatchLastRequestID)
	{
		LevelStateRequestingID.RemoveAll((int r) => r >= BatchFirstRequestID && r <= BatchLastRequestID);
		_ = LevelStateRequestingID.Count;
	}

	public void UnrequestAllLevelStateInfo()
	{
		BGW_LevelStreamingStateMgr bGW_LevelStreamingStateMgr = BGW_LevelStreamingStateMgr.Get(this);
		if (bGW_LevelStreamingStateMgr == null)
		{
			return;
		}
		GetFullGroupName(startWithOuter: true);
		foreach (int item in ControlledStateLevelID)
		{
			bGW_LevelStreamingStateMgr.UpdateLevelState(Graph.GraphName + " : " + GetFullName(), item, -1, EGSLevelStateInfoLayerType.CMG, Graph.GraphName + " : " + GetName());
		}
		ControlledStateLevelID.Clear();
	}

	static MovieInstance()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieInstance));
		PerformerClass = UClass.GetClass<BGUPerformerActorCS>();
	}

	[UFunctionInvoker("/Script/b1-Managed.MovieInstance:OnSequencePlayStopped")]
	private static void OnSequencePlayStopped__Invoker(IntPtr buffer, IntPtr obj)
	{
		MovieInstance movieInstance = GCHelper.Find<MovieInstance>(obj);
		movieInstance.OnSequencePlayStopped();
	}

	[UFunctionInvoker("/Script/b1-Managed.MovieInstance:OnSequencePlayFinished")]
	private static void OnSequencePlayFinished__Invoker(IntPtr buffer, IntPtr obj)
	{
		MovieInstance movieInstance = GCHelper.Find<MovieInstance>(obj);
		movieInstance.OnSequencePlayFinished();
	}

	[UFunctionInvoker("/Script/b1-Managed.MovieInstance:OnLoadLevelStreamingFinish")]
	private static void OnLoadLevelStreamingFinish__Invoker(IntPtr buffer, IntPtr obj)
	{
		MovieInstance movieInstance = GCHelper.Find<MovieInstance>(obj);
		int actionID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnLoadLevelStreamingFinish_ActionID_Offset));
		int linkage = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnLoadLevelStreamingFinish_Linkage_Offset));
		movieInstance.OnLoadLevelStreamingFinish(actionID, linkage);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.MovieInstance");
		OnSequencePlayStopped_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSequencePlayStopped");
		OnSequencePlayStopped_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSequencePlayStopped_FunctionAddress);
		OnSequencePlayStopped_IsValid = OnSequencePlayStopped_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.MovieInstance:OnSequencePlayStopped", OnSequencePlayStopped_IsValid);
		OnSequencePlayFinished_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSequencePlayFinished");
		OnSequencePlayFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSequencePlayFinished_FunctionAddress);
		OnSequencePlayFinished_IsValid = OnSequencePlayFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.MovieInstance:OnSequencePlayFinished", OnSequencePlayFinished_IsValid);
		OnLoadLevelStreamingFinish_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnLoadLevelStreamingFinish");
		OnLoadLevelStreamingFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLoadLevelStreamingFinish_FunctionAddress);
		OnLoadLevelStreamingFinish_ActionID_Offset = NativeReflection.GetPropertyOffset(OnLoadLevelStreamingFinish_FunctionAddress, "ActionID");
		OnLoadLevelStreamingFinish_ActionID_IsValid = NativeReflection.ValidatePropertyClass(OnLoadLevelStreamingFinish_FunctionAddress, "ActionID", Classes.FIntProperty);
		OnLoadLevelStreamingFinish_Linkage_Offset = NativeReflection.GetPropertyOffset(OnLoadLevelStreamingFinish_FunctionAddress, "Linkage");
		OnLoadLevelStreamingFinish_Linkage_IsValid = NativeReflection.ValidatePropertyClass(OnLoadLevelStreamingFinish_FunctionAddress, "Linkage", Classes.FIntProperty);
		OnLoadLevelStreamingFinish_IsValid = OnLoadLevelStreamingFinish_FunctionAddress != IntPtr.Zero && OnLoadLevelStreamingFinish_ActionID_IsValid && OnLoadLevelStreamingFinish_Linkage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.MovieInstance:OnLoadLevelStreamingFinish", OnLoadLevelStreamingFinish_IsValid);
	}
}
