using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using BtlShare;
using CommB1;
using CsB1;
using Google.Protobuf;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BGS_DropItemSystem : GameStateSystemBase
{
	public override void OnAttach()
	{
		BGS_GSEventCollection bGS_GSEventCollection = BGS_GSEventCollection.Get(this);
		bGS_GSEventCollection.Evt_BGS_UnitDeadDropItem += new Del_UnitDeadDropItem(OnUnitDeadTriggerDrop);
		bGS_GSEventCollection.Evt_BGS_PlayerCollected += new Del_PlayerCollected(OnPlayerCollected);
		bGS_GSEventCollection.Evt_BGS_DestructionDropItem += new Del_DestructionDropItem(OnDestructionTriggerDrop);
		bGS_GSEventCollection.Evt_BGS_ChallengeSuccessDropItem += new Del_ChallengeSuccessDropItem(OnChallengeSuccess);
	}

	public override void OnBeginPlay()
	{
	}

	private void OnUnitDeadTriggerDrop(AActor Victim, AActor Attacker, EDeadReason DeadReason)
	{
		int actorResID = BGU_DataUtil.GetActorResID(Victim);
		int finalBattleInfoExtendID = BGU_DataUtil.GetFinalBattleInfoExtendID(Victim);
		if (actorResID <= 0 || DeadReason == EDeadReason.OnlyDestroyUnit || DeadReason == EDeadReason.PlayerTrans)
		{
			return;
		}
		if (UGSE_EngineFuncLib.IsStandAlone(Owner.World))
		{
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
			if (!firstLocalPlayerController.IsNullOrDestroyed())
			{
				BPS_GSEventCollection bPS_GSEventCollection = BPS_EventCollectionCS.Get(firstLocalPlayerController);
				APlayerState playerState = firstLocalPlayerController.PlayerState;
				if (!(bPS_GSEventCollection == null) && !(playerState == null))
				{
					DropItemByPlayerState(playerState, bPS_GSEventCollection, actorResID, finalBattleInfoExtendID, Victim);
				}
			}
			return;
		}
		List<APlayerController> allPlayerControllers = BGU_UnrealWorldUtil.GetAllPlayerControllers(Owner.World);
		if (allPlayerControllers == null)
		{
			return;
		}
		int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.OnelineDropDistance);
		foreach (APlayerController item in allPlayerControllers)
		{
			if (item.GetControlledPawn() != null && FVector.Distance(Victim.GetActorLocation(), item.GetControlledPawn().GetActorLocation()) < (float)commLogicCfgValue)
			{
				BPS_GSEventCollection bPSEvent = BPS_EventCollectionCS.Get(item);
				DropItemByPlayerState(item.PlayerState, bPSEvent, actorResID, finalBattleInfoExtendID, Victim);
			}
		}
	}

	private void DropItemByPlayerState(APlayerState TargetPlayerState, BPS_GSEventCollection BPSEvent, int ResID, int BattleInfoExtendID, AActor Victim)
	{
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(TargetPlayerState);
		if (bTF_EventCollectionCS == null || !(TargetPlayerState != null))
		{
			return;
		}
		CSMsgBagDropUnitAwardReq cSMsgBagDropUnitAwardReq = new CSMsgBagDropUnitAwardReq();
		cSMsgBagDropUnitAwardReq.UnitId = ResID;
		cSMsgBagDropUnitAwardReq.Override = BattleInfoExtendID;
		cSMsgBagDropUnitAwardReq.CanDropVigour = BGU_DataUtil.GetReadOnlyData<IBUC_VigourDropperData, BUC_VigourDropperData>(Victim)?.CanDropVigourItem ?? false;
		bTF_EventCollectionCS.Evt_BagDropUnitAwardReq(cSMsgBagDropUnitAwardReq, delegate(MsgErrCode ErrCode, CSMsgBagDropUnitAwardReq Req, CSMsgBagDropUnitAwardRes Res)
		{
			if (ErrCode == MsgErrCode.ErrSuccess)
			{
				AwardList awardList = Res.AwardList;
				if (awardList.Awards.Count > 0 && BPSEvent != null)
				{
					List<byte> awardsBytes = awardList.ToByteArray().ToList();
					BPSEvent.Evt_OnTriggerDropItem.Invoke(Victim, awardsBytes, DropReason.UnitDead);
				}
			}
		}, TargetPlayerState, AllPlayer: false);
	}

	private void OnDestructionTriggerDrop(AActor Destruction, int DropGroupId, int DropDistanceLimit)
	{
		float num = DropDistanceLimit;
		BPS_GSEventCollection BPSEvent = null;
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(Destruction, UClass.GetClass<BGP_PlayerControllerCS>());
		APlayerController aPlayerController = null;
		float num2 = -1f;
		AActor[] array = allActorsOfClass;
		foreach (AActor aActor in array)
		{
			if (!(aActor != null))
			{
				continue;
			}
			APlayerController aPlayerController2 = aActor as APlayerController;
			if (aPlayerController2 != null && aPlayerController2.GetControlledPawn() != null)
			{
				float num3 = FVector.Dist(aPlayerController2.GetControlledPawn().GetActorLocation(), Destruction.GetActorLocation());
				if (num2 < 0f || num3 < num2)
				{
					aPlayerController = aPlayerController2;
					num2 = num3;
				}
			}
		}
		APlayerState playerState = null;
		if (num <= 0f || num2 <= num)
		{
			BPSEvent = BPS_EventCollectionCS.Get(aPlayerController);
			playerState = aPlayerController?.PlayerState;
		}
		if (!(BPSEvent != null))
		{
			return;
		}
		CSMsgBagCommDropReq cSMsgBagCommDropReq = new CSMsgBagCommDropReq();
		cSMsgBagCommDropReq.DropId = DropGroupId;
		cSMsgBagCommDropReq.ManualPickup = YesNoType.Yes;
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(playerState);
		if (bTF_EventCollectionCS == null)
		{
			BGW_LogUtil.LogError("[BUS_DestructionDropComp] OnDestructionTriggerDrop BTFG == null");
			return;
		}
		bTF_EventCollectionCS.Evt_BagCommDropReq(cSMsgBagCommDropReq, delegate(MsgErrCode ErrCode, CSMsgBagCommDropReq Req, CSMsgBagCommDropRes Res)
		{
			if (ErrCode == MsgErrCode.ErrSuccess)
			{
				AwardList awardList = Res.AwardList;
				if (awardList.Awards.Count > 0 && BPSEvent != null)
				{
					List<byte> awardsBytes = awardList.ToByteArray().ToList();
					BPSEvent.Evt_OnTriggerDropItem.Invoke(Destruction, awardsBytes, DropReason.Destruction);
				}
			}
			else
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Destruction);
				if (bUS_GSEventCollection != null && bUS_GSEventCollection.Evt_BGS_DestructionDropFail != null)
				{
					bUS_GSEventCollection.Evt_BGS_DestructionDropFail.Invoke();
				}
			}
		}, playerState, AllPlayer: false);
	}

	public void OnPlayerCollected(AActor Player, int DropId, int DropLevel, AActor CollectedActor, OverrideDropTempleteInfoClass OverrideDropTempleteInfo = null)
	{
		ABGUCharacter PlayerCharacter = Player as ABGUCharacter;
		if (PlayerCharacter == null || !PlayerCharacter.IsPlayerControlled())
		{
			return;
		}
		BTF_EventCollectionCS.Get(PlayerCharacter?.PlayerState)?.Evt_BagDropCollectionAwardReq(new CSMsgBagDropCollectionAwardReq
		{
			CollectionId = DropId,
			DropLevel = DropLevel
		}, delegate(MsgErrCode ErrCode, CSMsgBagDropCollectionAwardReq Req, CSMsgBagDropCollectionAwardRes Res)
		{
			if (ErrCode == MsgErrCode.ErrSuccess)
			{
				BPS_GSEventCollection bPS_GSEventCollection = BPS_EventCollectionCS.Get(PlayerCharacter.PlayerState);
				AwardList awardList = Res.AwardList;
				if (awardList.Awards.Count > 0 && bPS_GSEventCollection != null)
				{
					List<byte> awardsBytes = awardList.ToByteArray().ToList();
					bPS_GSEventCollection.Evt_OnTriggerDropItem.Invoke(CollectedActor, awardsBytes, DropReason.Collection, OverrideDropTempleteInfo);
				}
			}
		});
	}

	public void OnChallengeSuccess(AActor Player, int DropId)
	{
		ABGUCharacter aBGUCharacter = Player as ABGUCharacter;
		if (!(aBGUCharacter == null) && aBGUCharacter.IsPlayerControlled())
		{
			CSMsgBagCommDropReq cSMsgBagCommDropReq = new CSMsgBagCommDropReq();
			cSMsgBagCommDropReq.DropId = DropId;
			BTF_EventCollectionCS.Get(aBGUCharacter.PlayerState).Evt_BagCommDropReq(cSMsgBagCommDropReq, null, aBGUCharacter.PlayerState, AllPlayer: false);
		}
	}
}
