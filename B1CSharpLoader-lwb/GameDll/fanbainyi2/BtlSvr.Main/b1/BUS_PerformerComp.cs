using System.Text;
using b1.EventDelDefine;
using BtlShare;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_PerformerComp : BUS_StateMachineCompBase
{
	public class WaitingState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.PerformerTag.State_Waiting;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.PerformerTag.Event_PreShow, BGW_FlowUtils.PerformerTag.State_PreShowing);
			base.EventTransitDictionary.Add(BGW_FlowUtils.PerformerTag.Event_Show, BGW_FlowUtils.PerformerTag.State_Showing);
			base.EventTransitDictionary.Add(BGW_FlowUtils.PerformerTag.Event_AfterShowing, BGW_FlowUtils.PerformerTag.State_Completed);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_PerformerComp bUS_PerformerComp)
			{
				bUS_PerformerComp.OnEnterWaitingState();
			}
		}
	}

	public class PreShowState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.PerformerTag.State_PreShowing;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.PerformerTag.Event_Show, BGW_FlowUtils.PerformerTag.State_Showing);
			base.EventTransitDictionary.Add(BGW_FlowUtils.PerformerTag.Event_AfterShowing, BGW_FlowUtils.PerformerTag.State_Completed);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_PerformerComp bUS_PerformerComp)
			{
				bUS_PerformerComp.OnEnterPreShowingState();
			}
		}
	}

	public class ShowingState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.PerformerTag.State_Showing;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.PerformerTag.Event_AfterShowing, BGW_FlowUtils.PerformerTag.State_Bowing);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_PerformerComp bUS_PerformerComp)
			{
				bUS_PerformerComp.OnEnterShowingState();
			}
		}

		public override void OnExitAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_PerformerComp bUS_PerformerComp)
			{
				BUS_DispLibEventCollection.Get(bUS_PerformerComp.GetOwner())?.Evt_StopCheckSourceActorHiddenStateSyncDBCEvent();
			}
		}
	}

	public class BowingState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.PerformerTag.State_Bowing;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.PerformerTag.Event_FinishBow, BGW_FlowUtils.PerformerTag.State_Completed);
			base.EventTransitDictionary.Add(BGW_FlowUtils.PerformerTag.Event_Show, BGW_FlowUtils.PerformerTag.State_Showing);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_PerformerComp bUS_PerformerComp)
			{
				bUS_PerformerComp.OnEnterBowingState();
			}
		}

		public override void OnExitAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_PerformerComp bUS_PerformerComp)
			{
				bUS_PerformerComp.OnExitBowingState();
			}
		}

		public override void OnTickAction(BUS_StateMachineCompBase InOwner, float DeltaTime)
		{
			if (InOwner is BUS_PerformerComp bUS_PerformerComp)
			{
				bUS_PerformerComp.OnTickBowingState(DeltaTime);
			}
		}
	}

	public class CompletedState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.PerformerTag.State_Completed;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.PerformerTag.Event_Show, BGW_FlowUtils.PerformerTag.State_Showing);
			base.EventTransitDictionary.Add(BGW_FlowUtils.PerformerTag.Event_Wait, BGW_FlowUtils.PerformerTag.State_Waiting);
			base.EventTransitDictionary.Add(BGW_FlowUtils.PerformerTag.Event_PreShow, BGW_FlowUtils.PerformerTag.State_PreShowing);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_PerformerComp bUS_PerformerComp)
			{
				bUS_PerformerComp.OnEnterCompletedState();
			}
		}
	}

	private const float BowTime = 0f;

	private GSStateBase State_Waiting { get; set; }

	private GSStateBase State_PreShowing { get; set; }

	private GSStateBase State_Showing { get; set; }

	private GSStateBase State_Completed { get; set; }

	private GSStateBase State_Bowing { get; set; }

	private BUC_PerformerData PerformerData { get; set; }

	private IBUC_BuffData BuffData { get; set; }

	private IBUC_PropMgrData PropMgrData { get; set; }

	private IBUC_CharacterModularData CharacterModularData { get; set; }

	private IBGC_LevelActorData LevelActorData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		PerformerData = RequireWritableData<BUC_PerformerData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		CharacterModularData = RequireReadOnlyData<IBUC_CharacterModularData, BUC_CharacterModularData>();
		LevelActorData = RequireReadOnlyGameStateData<IBGC_LevelActorData, BGC_LevelActorData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.Performer;
		State_Waiting = AddState(typeof(WaitingState), 0);
		State_Showing = AddState(typeof(ShowingState), 1);
		State_Completed = AddState(typeof(CompletedState), 2);
		State_PreShowing = AddState(typeof(PreShowState), 3);
		State_Bowing = AddState(typeof(BowingState), 4);
		base.InitialState = (PerformerData.bWaitingPerformer ? State_Waiting : State_Completed);
		PerformerData.CompletedLocation = base.Owner.GetActorLocation();
		PerformerData.CompletedRotation = base.Owner.GetActorRotation();
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
	}

	private void OnResetActorStatusAfterAll(EResetActorReason Resetreason)
	{
		if (PerformerData.bWaitingWhenReturnHome && Resetreason == EResetActorReason.ReturnHome)
		{
			OnForceJumpToState(State_Waiting.StateTag);
		}
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		PerformerData.OwnerEntity = ECSExtension.ToEntity(GetOwner());
		PerformerData.CapsuleHalfHeight = OwnerAsCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight();
		PerformerData.CapsuleRadius = OwnerAsCharacterCS.CapsuleComponent.GetScaledCapsuleRadius();
	}

	public override void OnBeginPlay()
	{
		PerformerData.bHasEquip = false;
		if (CharacterModularData != null)
		{
			PerformerData.bHasEquip = CharacterModularData.MapEquipSMC.Count > 0;
		}
		base.OnBeginPlay();
	}

	private void UpdateCurrentPerformState()
	{
		PerformerStateConfigData actualStateConfigData = PerformerData.ActualStateConfigData;
		actualStateConfigData.bPauseAI = BuffData.HasBuff(PerformerData.PauseAIBuffID);
		actualStateConfigData.bDisableCapsuleCollision = BuffData.HasBuff(PerformerData.DisableCapsuleCollisionBuffID);
		actualStateConfigData.bDisableMeshCollision = BuffData.HasBuff(PerformerData.DisableMeshCollisionBuffID);
		actualStateConfigData.bDisableGravity = BuffData.HasBuff(PerformerData.DisableGravityBuffID);
		actualStateConfigData.bCannotSelected = BuffData.HasBuff(PerformerData.CannotSelectedBuffID);
		actualStateConfigData.bInvisible = BuffData.HasBuff(PerformerData.InvisibleBuffID);
		actualStateConfigData.bInvincible = BuffData.HasBuff(PerformerData.InvincibleBuffID);
	}

	private void ApplyPerformState(PerformerStateConfigData TargetPerformState)
	{
		PerformerStateConfigData actualStateConfigData = PerformerData.ActualStateConfigData;
		StringBuilder stringBuilder = new StringBuilder();
		BUC_PerformerData performerData = PerformerData;
		bool bPerforming = (actualStateConfigData.bPerforming = TargetPerformState.bPerforming);
		performerData.bPerforming = bPerforming;
		if (actualStateConfigData.bPauseAI != TargetPerformState.bPauseAI)
		{
			if (TargetPerformState.bPauseAI)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(PerformerData.PauseAIBuffID, ECSExtension.ToActor(PerformerData.OwnerEntity), ECSExtension.ToActor(PerformerData.OwnerEntity), -1f, EBuffSourceType.Performer);
				stringBuilder.Append($"---演员添加 暂停AI Buff：{PerformerData.PauseAIBuffID}");
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(PerformerData.PauseAIBuffID, EBuffEffectTriggerType.None);
				stringBuilder.Append($"---演员 移除 暂停AI Buff：{PerformerData.PauseAIBuffID}");
			}
		}
		if (actualStateConfigData.bDisableCapsuleCollision != TargetPerformState.bDisableCapsuleCollision)
		{
			if (TargetPerformState.bDisableCapsuleCollision)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(PerformerData.DisableCapsuleCollisionBuffID, ECSExtension.ToActor(PerformerData.OwnerEntity), ECSExtension.ToActor(PerformerData.OwnerEntity), -1f, EBuffSourceType.Performer);
				stringBuilder.Append($"---演员添加 关闭胶囊体碰撞 Buff：{PerformerData.DisableCapsuleCollisionBuffID}");
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(PerformerData.DisableCapsuleCollisionBuffID, EBuffEffectTriggerType.None);
				stringBuilder.Append($"---演员 移除 关闭胶囊体碰撞 Buff：{PerformerData.DisableCapsuleCollisionBuffID}");
			}
		}
		if (actualStateConfigData.bDisableMeshCollision != TargetPerformState.bDisableMeshCollision)
		{
			if (TargetPerformState.bDisableMeshCollision)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(PerformerData.DisableMeshCollisionBuffID, ECSExtension.ToActor(PerformerData.OwnerEntity), ECSExtension.ToActor(PerformerData.OwnerEntity), -1f, EBuffSourceType.Performer);
				stringBuilder.Append($"---演员添加 关闭Mesh碰撞 Buff：{PerformerData.DisableMeshCollisionBuffID}");
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(PerformerData.DisableMeshCollisionBuffID, EBuffEffectTriggerType.None);
				stringBuilder.Append($"---演员 移除 关闭Mesh碰撞 Buff：{PerformerData.DisableMeshCollisionBuffID}");
			}
		}
		if (actualStateConfigData.bDisableGravity != TargetPerformState.bDisableGravity)
		{
			if (TargetPerformState.bDisableGravity)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(PerformerData.DisableGravityBuffID, ECSExtension.ToActor(PerformerData.OwnerEntity), ECSExtension.ToActor(PerformerData.OwnerEntity), -1f, EBuffSourceType.Performer);
				stringBuilder.Append($"---演员添加 关闭重力 Buff：{PerformerData.DisableGravityBuffID}");
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(PerformerData.DisableGravityBuffID, EBuffEffectTriggerType.None);
				stringBuilder.Append($"---演员 移除 关闭重力 Buff：{PerformerData.DisableGravityBuffID}");
			}
		}
		if (actualStateConfigData.bCannotSelected != TargetPerformState.bCannotSelected)
		{
			if (TargetPerformState.bCannotSelected)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(PerformerData.CannotSelectedBuffID, ECSExtension.ToActor(PerformerData.OwnerEntity), ECSExtension.ToActor(PerformerData.OwnerEntity), -1f, EBuffSourceType.Performer);
				stringBuilder.Append($"---演员添加 不可选中 Buff：{PerformerData.CannotSelectedBuffID}");
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(PerformerData.CannotSelectedBuffID, EBuffEffectTriggerType.None);
				stringBuilder.Append($"---演员 移除 不可选中 Buff：{PerformerData.CannotSelectedBuffID}");
			}
		}
		if (actualStateConfigData.bInvisible != TargetPerformState.bInvisible)
		{
			if (TargetPerformState.bInvisible)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(PerformerData.InvisibleBuffID, ECSExtension.ToActor(PerformerData.OwnerEntity), ECSExtension.ToActor(PerformerData.OwnerEntity), -1f, EBuffSourceType.Performer);
				stringBuilder.Append($"---演员添加 隐身 Buff：{PerformerData.InvisibleBuffID}");
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(PerformerData.InvisibleBuffID, EBuffEffectTriggerType.None);
				stringBuilder.Append($"---演员 移除 隐身 Buff：{PerformerData.InvisibleBuffID}");
			}
		}
		if (actualStateConfigData.bInvincible != TargetPerformState.bInvincible)
		{
			if (TargetPerformState.bInvincible)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(PerformerData.InvincibleBuffID, ECSExtension.ToActor(PerformerData.OwnerEntity), ECSExtension.ToActor(PerformerData.OwnerEntity), -1f, EBuffSourceType.Performer);
				stringBuilder.Append($"---演员添加 无敌 Buff：{PerformerData.InvincibleBuffID}");
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(PerformerData.InvincibleBuffID, EBuffEffectTriggerType.None);
				stringBuilder.Append($"---演员 移除 无敌 Buff：{PerformerData.InvincibleBuffID}");
			}
		}
	}

	private void StopLastPlayedMontage()
	{
		if (PerformerData.bPlayingWaitingAnim)
		{
			ACharacter aCharacter = GetOwner() as ACharacter;
			if (aCharacter != null && PerformerData.WaitingAnim.IsValid())
			{
				aCharacter.StopAnimMontage(PerformerData.WaitingAnim.Value);
				PerformerData.bPlayingWaitingAnim = false;
			}
		}
	}

	private void OnEnterWaitingState()
	{
		UpdateCurrentPerformState();
		ApplyPerformState(PerformerData.WaitingStateConfigData);
		if (!PerformerData.bStandingWaiting)
		{
			FVector newLocation;
			FRotator newRotation;
			if (PerformerData.bUseSceneItemPosition)
			{
				LevelActorData.GetSceneItemsByTag(PerformerData.WaitingLocationItemTag, out var OutSceneItems);
				if (OutSceneItems.Count > 0)
				{
					AActor aActor = OutSceneItems[0];
					newLocation = aActor.GetActorLocation();
					newRotation = aActor.GetActorRotation();
				}
				else
				{
					newLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(base.Owner);
					newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(base.Owner);
				}
			}
			else
			{
				newLocation = PerformerData.WaitingLocation;
				newRotation = PerformerData.WaitingRotation;
			}
			BGUFuncLibActorTransformCS.BGUSetActorLocation(base.Owner, newLocation, bSweep: false, bTeleport: false);
			BGUFuncLibActorTransformCS.BGUSetActorRotation(base.Owner, newRotation, bTeleportPhysics: false);
		}
		if (PerformerData.WaitingAnim.IsValid())
		{
			BGUFuncLibAnim.BGUActorTryPlayMontage(base.Owner, PerformerData.WaitingAnim.Value, FName.None);
			PerformerData.bPlayingWaitingAnim = true;
		}
		base.BUSEventCollection.Evt_TriggerPerformerStateChange.Invoke(IsShow: false);
	}

	private void OnEnterPreShowingState()
	{
		UpdateCurrentPerformState();
		ApplyPerformState(PerformerData.PreShowStateConfigData);
		base.BUSEventCollection.Evt_TriggerPerformerStateChange.Invoke(IsShow: true);
		BUS_DispLibEventCollection.Get(base.Owner)?.Evt_StartCheckSourceActorHiddenStateSyncDBCEvent();
	}

	private void OnEnterShowingState()
	{
		StopLastPlayedMontage();
		UpdateCurrentPerformState();
		ApplyPerformState(PerformerData.ShowingStateConfigData);
		base.BUSEventCollection.Evt_TriggerPerformerStateChange.Invoke(IsShow: true);
		BUS_DispLibEventCollection.Get(base.Owner)?.Evt_StartCheckSourceActorHiddenStateSyncDBCEvent();
	}

	private void OnEnterCompletedState()
	{
		StopLastPlayedMontage();
		UpdateCurrentPerformState();
		ApplyPerformState(PerformerData.CompletedStateConfigData);
		base.BUSEventCollection.Evt_TriggerPerformerStateChange.Invoke(IsShow: true);
		if (PerformerData.HandleID != 0)
		{
			base.BUSEventCollection.Evt_ResetProperty.Invoke(PerformerData.HandleID);
			PerformerData.HandleID = 0u;
			if (OwnerAsCharacterCS.CharacterMovement.IsFalling())
			{
				OwnerAsCharacterCS.CharacterMovement.SetMovementMode(OwnerAsCharacterCS.CharacterMovement.DefaultLandMovementMode, 0);
			}
			UBGUCharacterMovementComponent uBGUCharacterMovementComponent = OwnerAsCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
			if (uBGUCharacterMovementComponent != null && !OwnerAsCharacterCS.IsLocallyControlled())
			{
				uBGUCharacterMovementComponent.SetSwitchToNavWalkCumulateTime(2f);
			}
		}
		base.BUSEventCollection.Evt_CheckUnmovable.Invoke();
		if (GSGameplayCVar.CVar_DrawPerformerBowDebug.GetValueInGameThread() == 1)
		{
			USystemLibrary.DrawDebugCapsule(base.Owner, base.Owner.GetActorLocation(), PerformerData.CapsuleHalfHeight, PerformerData.CapsuleRadius, FRotator.ZeroRotator, FLinearColor.Violet, 10f, 1f);
		}
	}

	private void OnEnterBowingState()
	{
		StopLastPlayedMontage();
		if (PerformerData.bBowWhenAfterShow)
		{
			UpdateCurrentPerformState();
			PerformerStateConfigData actualStateConfigData = PerformerData.ActualStateConfigData;
			PerformerData.TargetBowTime = 0f;
			if (actualStateConfigData.bDisableCapsuleCollision || actualStateConfigData.bDisableMeshCollision)
			{
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(base.Owner);
				FVector start = fVector;
				FVector end = fVector - FVector.UpVector * PerformerData.CapsuleHalfHeight * 2.0;
				if (UGSE_TraceFuncLib.CharacterCapsuleTraceSingleByProfile(base.Owner, start, end, PerformerData.CapsuleRadius, PerformerData.CapsuleHalfHeight, B1GlobalFNames.Pawn, bTraceComplex: false, base.Owner, out var OutHitLocation))
				{
					if (GSGameplayCVar.CVar_DrawPerformerBowDebug.GetValueInGameThread() == 1)
					{
						USystemLibrary.DrawDebugCapsule(base.Owner, OutHitLocation, PerformerData.CapsuleHalfHeight, PerformerData.CapsuleRadius, FRotator.ZeroRotator, FLinearColor.Red, 10f, 1f);
						USystemLibrary.DrawDebugCapsule(base.Owner, fVector, PerformerData.CapsuleHalfHeight, PerformerData.CapsuleRadius, FRotator.ZeroRotator, FLinearColor.Red, 10f, 1f);
					}
					PerformerData.bFinishBow = false;
					PerformerData.TotalBowTime = 0f;
					PerformerData.TargetBowTime = 0f;
					float num = 2.4f;
					PerformerData.TargetBowLocation = OutHitLocation + FVector.UpVector * num;
					PerformerData.OriginBowLocation = fVector;
					if (PerformerData.HandleID != 0)
					{
						base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 6, PerformerData.HandleID, 0u, bSetDefaultProperty: false, "PerformerComp");
					}
					else
					{
						base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 6, 0u, 0u, bSetDefaultProperty: false, "PerformerComp");
						PerformerData.HandleID = PropMgrData.GetLastHandleID();
					}
					PerformerData.LastFrameBowLocation = fVector;
					base.BUSEventCollection.Evt_SetFootIKManualUpdateMode.Invoke(P1: true);
					return;
				}
			}
		}
		OnEvent(BGW_FlowUtils.PerformerTag.Event_FinishBow);
	}

	private void OnTickBowingState(float DeltaTime)
	{
		if (PerformerData.CurrentBowLocation.HasValue)
		{
			BGUFuncLibActorTransformCS.BGUSetActorLocation(base.Owner, PerformerData.CurrentBowLocation.Value, bSweep: false, bTeleport: true);
			if (PerformerData.bFinishBow)
			{
				PerformerData.CurrentBowLocation = null;
				return;
			}
		}
		if (PerformerData.bFinishBow)
		{
			PerformerData.bFinishBow = false;
			PerformerData.CurrentBowLocation = null;
			OnEvent(BGW_FlowUtils.PerformerTag.Event_FinishBow);
			return;
		}
		FVector fVector = PerformerData.TargetBowLocation;
		if (PerformerData.TotalBowTime >= PerformerData.TargetBowTime)
		{
			UpdateFootIK(fVector);
			PerformerData.bFinishBow = true;
			if (GSGameplayCVar.CVar_DrawPerformerBowDebug.GetValueInGameThread() == 1)
			{
				USystemLibrary.DrawDebugCapsule(base.Owner, fVector, PerformerData.CapsuleHalfHeight, PerformerData.CapsuleRadius, FRotator.ZeroRotator, FLinearColor.Green, 10f, 1f);
			}
		}
		else
		{
			fVector = MathLib.VInterpTo(PerformerData.OriginBowLocation, PerformerData.TargetBowLocation, PerformerData.TotalBowTime, float.PositiveInfinity);
			UpdateFootIK(fVector);
			if (GSGameplayCVar.CVar_DrawPerformerBowDebug.GetValueInGameThread() == 1)
			{
				USystemLibrary.DrawDebugCapsule(base.Owner, fVector, PerformerData.CapsuleHalfHeight, PerformerData.CapsuleRadius, FRotator.ZeroRotator, FLinearColor.Blue, DeltaTime, 3f);
			}
		}
		PerformerData.CurrentBowLocation = fVector;
		PerformerData.TotalBowTime += DeltaTime;
	}

	private void UpdateFootIK(FVector Location)
	{
		FVector vec = Location - PerformerData.LastFrameBowLocation;
		vec.X = 0f;
		vec.Y = 0f;
		PerformerData.LastFrameBowLocation = Location;
		base.BUSEventCollection.Evt_ManualUpdateFootIKByZOffset.Invoke(vec);
	}

	private void OnExitBowingState()
	{
		PerformerData.CurrentBowLocation = null;
		base.BUSEventCollection.Evt_SetFootIKManualUpdateMode.Invoke(P1: false);
	}
}
