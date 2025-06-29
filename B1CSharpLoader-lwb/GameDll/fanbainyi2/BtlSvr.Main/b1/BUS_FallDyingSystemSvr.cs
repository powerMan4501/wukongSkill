using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_FallDyingSystemSvr : UActorCompBaseCS
{
	private BTF_EventCollectionCS BTFEventCollection;

	private BUC_FallDyingData FallDyingData;

	private IBGC_OnlineChallengeData OnlineChallengeData;

	private IBUC_AttrContainer AttrCon;

	public override void OnAttach()
	{
		base.OnAttach();
		base.BUSEventCollection.Evt_TriggerFallDying += new Del_Void_Actor(OnTriggerFallDying);
		base.BUSEventCollection.Evt_FinishRescueInteract += new Del_Actor(FinishRescueInteract);
		base.BUSEventCollection.Evt_FinishRescue += new Del_Actor(FinishRescue);
		base.BUSEventCollection.Evt_CheckFallDyingState += new Del_Void(CheckFallDyingState);
		FallDyingData = RequireWritableData<BUC_FallDyingData>();
		OnlineChallengeData = RequireReadOnlyGameStateData<IBGC_OnlineChallengeData, BGC_OnlineChallengeData>();
		AttrCon = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		ABGUCharacter aBGUCharacter = Owner as ABGUCharacter;
		BTFEventCollection = BTF_EventCollectionCS.Get(aBGUCharacter.PlayerState);
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		FallDyingData.TestEntityMgrIdx = ECSExtension.ToEntity(Owner).EntityMgrIdx;
	}

	private void CheckFallDyingState()
	{
		if (AttrCon.GetFloatValue(EBGUAttrFloat.Hp) <= 0f)
		{
			base.BUSEventCollection?.Evt_UnitDead.Invoke(Owner, EDeadReason.Suicide);
		}
	}

	public override void LateBeginPlay()
	{
		base.LateBeginPlay();
		base.BUSEventCollection.Evt_SwitchNoInteraction.Invoke(P1: false);
	}

	private void SwitchFallDyingState(EFallDyingState NextFallDyingState)
	{
		if (NextFallDyingState != FallDyingData.UnitFallDyingState)
		{
			switch (NextFallDyingState)
			{
			case EFallDyingState.Alive:
				base.BUSEventCollection.Evt_SwitchNoInteraction.Invoke(P1: false);
				break;
			case EFallDyingState.FallDyingWaiting:
				base.BUSEventCollection.Evt_SwitchNoInteraction.Invoke(P1: true);
				break;
			case EFallDyingState.RealDead:
				base.BUSEventCollection.Evt_FinishRescue.Invoke(Owner);
				base.BUSEventCollection.Evt_UnitRebirth.Invoke(ERebirthType.RebirthPoint);
				break;
			}
			FallDyingData.UnitFallDyingState = NextFallDyingState;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("OnlineAttr", $"濒死状态: {FallDyingData.UnitFallDyingState}");
		if (FallDyingData.UnitFallDyingState == EFallDyingState.Alive)
		{
			return;
		}
		FallDyingData.FallDyingTime += DeltaTime;
		if (FallDyingData.SaveSelfWaitTime > 0f)
		{
			FallDyingData.SaveSelfWaitTime -= DeltaTime;
			if (FallDyingData.SaveSelfWaitTime <= 0f)
			{
				SwitchFallDyingState(EFallDyingState.FallDyingWaitSelfSave);
			}
		}
		else if (FallDyingData.UnitFallDyingState == EFallDyingState.FallDyingWaitSelfSave)
		{
			SwitchFallDyingState(EFallDyingState.FallDyingSelfSaving);
		}
		if (FallDyingData.FallDyingTime > (float)BGW_PreloadAssetMgr.Get(this).FallDyingConfigDataAsset.SaveTeammateWaitTime && FallDyingData.UnitFallDyingState == EFallDyingState.FallDyingBegin)
		{
			SwitchFallDyingState(EFallDyingState.FallDyingWaiting);
			bool flag = false;
			List<BGUCharacterCS> allPlayerActors = BGU_UnrealWorldUtil.GetAllPlayerActors(Owner);
			foreach (BGUCharacterCS item in allPlayerActors)
			{
				IBUC_FallDyingData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_FallDyingData, BUC_FallDyingData>(item);
				if (readOnlyData != null && readOnlyData.GetFallDyingState() == EFallDyingState.Alive)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				BGS_EventCollectionCS.Get(Owner).Evt_TriggerAssistEvent.Invoke(EAssistEvent.TeamWipeOut);
				{
					foreach (BGUCharacterCS item2 in allPlayerActors)
					{
						BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(item2);
						if (bUS_GSEventCollection != null)
						{
							bUS_GSEventCollection.Evt_FinishRescue.Invoke(item2);
							bUS_GSEventCollection.Evt_UnitRebirth.Invoke(ERebirthType.RebirthPoint);
						}
					}
					return;
				}
			}
			SwitchFallDyingState(EFallDyingState.FallDyingWaiting);
		}
		if (FallDyingData.UnitFallDyingState == EFallDyingState.FallDyingSelfSaving)
		{
			FallDyingData.SavingSelfTime += DeltaTime;
			if (FallDyingData.SavingSelfTime >= (float)BGW_PreloadAssetMgr.Get(this).FallDyingConfigDataAsset.SaveSelfNeedTime)
			{
				SaveOneSelf();
			}
		}
	}

	private void OnTriggerFallDying(AActor Attacker)
	{
		if (FallDyingData == null || FallDyingData.UnitFallDyingState != EFallDyingState.Alive)
		{
			return;
		}
		ABGUCharacter aBGUCharacter = Owner as ABGUCharacter;
		if (aBGUCharacter != null)
		{
			BPC_RoleBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_RoleBaseData>(aBGUCharacter.PlayerState);
			if (readOnlyData != null)
			{
				base.BGSEventCollection?.Evt_BGS_PlayerDeadScreenMsg.Invoke(readOnlyData.RoleName);
			}
		}
		FallDyingData.FallDyingTime = 0f;
		FallDyingData.SaveSelfWaitTime = BGW_PreloadAssetMgr.Get(this).FallDyingConfigDataAsset.SaveSelfWaitTime;
		if (OnlineChallengeData.PlayerInChallenge(aBGUCharacter?.GetController() as APlayerController, out var _))
		{
			FallDyingData.SaveSelfWaitTime = BGW_PreloadAssetMgr.Get(this).FallDyingConfigDataAsset.ChallengeRebirthTime;
		}
		SwitchFallDyingState(EFallDyingState.FallDyingBegin);
		BGUFunctionLibraryCS.BGUSetUnitSimpleState(Owner, EBGUSimpleState.CantBeBaseTarget, IsRemove: false);
		BPS_EventCollectionCS.Get((Owner as APawn)?.PlayerState)?.Evt_BPS_UnitTriggerFallDying.Invoke();
	}

	private void SaveOneSelf()
	{
		if (FallDyingData.UnitFallDyingState != EFallDyingState.FallDyingSelfSaving)
		{
			return;
		}
		base.BUSEventCollection.Evt_FinishRescue.Invoke(Owner);
		APlayerController playerController = (Owner as ABGUCharacter)?.GetController() as APlayerController;
		if (OnlineChallengeData != null && OnlineChallengeData.CheckPlayerInChallengeAndRemove(playerController, out var ChallengeId))
		{
			FUStChallengeDesc challengeDesc = BGW_GameDB.GetChallengeDesc(ChallengeId);
			if (challengeDesc != null)
			{
				ABGUCharacter aBGUCharacter = Owner as ABGUCharacter;
				base.BUSEventCollection.Evt_ChallenegeRebirthTeleport.Invoke(challengeDesc.TeleportName);
				BGS_GSEventCollection.Get(Owner).Evt_BGS_OnlineOnePlayerFaildying.Invoke(aBGUCharacter?.GetController() as APlayerController);
			}
		}
		base.BUSEventCollection.Evt_UnitRebirth.Invoke(ERebirthType.SelfRescue);
	}

	private void FinishRescueInteract(AActor Target)
	{
		BUS_EventCollectionCS.Get(Target).Evt_FinishRescue.Invoke(Target);
		BUS_EventCollectionCS.Get(Target).Evt_UnitRebirth.Invoke(ERebirthType.Quick);
	}

	private void FinishRescue(AActor Saver)
	{
		BGUFunctionLibraryCS.BGURemoveBuffImmediately(Owner, 302, EBuffEffectTriggerType.None);
		if (!(Owner as ABGUCharacter == null))
		{
			base.BUSEventCollection.Evt_TriggerPlayerRest.Invoke();
			SwitchFallDyingState(EFallDyingState.Alive);
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(Owner, EBGUSimpleState.CantBeBaseTarget, IsRemove: true);
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.DeadUseFixCamera, IsRemove: true);
			FallDyingData.ReSetFallDyingState();
		}
	}
}
