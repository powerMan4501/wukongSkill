using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_LifeSavingComp : UActorCompBaseCS
{
	private const int BUFFID_PROTECT = 218;

	private BUC_LifeSavingData LifeSavingData { get; set; }

	private IBUC_UnitStateData UnitStateData { get; set; }

	private IBUC_PlayerSpellConfData PlayerSpellConfData { get; set; }

	public override void OnAttach()
	{
		LifeSavingData = RequireWritableData<BUC_LifeSavingData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		PlayerSpellConfData = RequireReadOnlyData<IBUC_PlayerSpellConfData, BUC_PlayerSpellConfData>();
		base.BUSEventCollection.Evt_TriggerSwitchMagicConfInfo += new Del_SwitchMagicConfInfo(OnTriggerSwitchMagicConfInfo);
		base.BUSEventCollection.Evt_LifeSavingHair_PendingStart += new Del_Void(LifeSavingHair_PendingStart);
		base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);
		base.BUSEventCollection.Evt_RecoverLifeSavingHairCoolDown += new Del_Void_Float(RecoverLifeSavingHairCoolDown);
		base.BUSEventCollection.Evt_DecreaseLifeSavingHairCoolDown += new Del_Void_Float(DecreaseLifeSavingHairCoolDown);
		base.BUSEventCollection.Evt_OnFakeDeadAMStart += new Del_Void_Float(OnFakeDeadAMStart);
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		base.BUSEventCollection.Evt_AfterUnitRebirth += new Del_UnitRebirth(OnPlayerRebirth);
		base.BUSEventCollection.Evt_Active_ExtLifeSaving += new Del_Void_Bool(Active_ExtLifeSaving);
	}

	public override void LateBeginPlay()
	{
		if (PlayerSpellConfData == null)
		{
			return;
		}
		FUStLifeSavingHairConfigDesc lifeSavingHairConfigDesc = BGW_GameDB.GetLifeSavingHairConfigDesc(GetActorResID(), Owner);
		if (lifeSavingHairConfigDesc == null)
		{
			return;
		}
		LifeSavingData.SpellID = lifeSavingHairConfigDesc.SpellID;
		LifeSavingData.DefaultCD = (float)lifeSavingHairConfigDesc.DefaultCD / 1000f;
		foreach (FUStMagicConfInfo item in PlayerSpellConfData.MagicConfInfo)
		{
			if (item.Type == SpellType.HaoMao && item.SpellID == LifeSavingData.SpellID)
			{
				Enable();
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
		if (LifeSavingData.CoolDownRemainTimer > 0f)
		{
			LifeSavingData.CoolDownRemainTimer -= DeltaTime;
		}
		if (LifeSavingData.bRebirthPrepare)
		{
			LifeSavingData.RebirthRemainTimer -= DeltaTime;
			if (LifeSavingData.RebirthRemainTimer <= 0f)
			{
				LifeSavingData.bRebirthPrepare = false;
				TriggerLifeSavingHair();
			}
		}
	}

	private void LifeSavingHair_PendingStart()
	{
		base.BUSEventCollection.Evt_BuffAdd.Invoke(218, Owner, Owner, -1f, EBuffSourceType.LifeSaving);
		base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Enter_LifeSavingHair_FakeDead, -1f);
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.ImmueAnimationSyncing);
		FUStLifeSavingHairConfigDesc lifeSavingHairConfigDesc = BGW_GameDB.GetLifeSavingHairConfigDesc(GetActorResID(), Owner);
		if (lifeSavingHairConfigDesc != null)
		{
			foreach (int item in lifeSavingHairConfigDesc.BuffIDListDurLifeSaving)
			{
				LifeSavingData.BuffIDList_DurLifeSaving.Add(item);
				base.BUSEventCollection.Evt_BuffAdd.Invoke(item, Owner, Owner, -1f, EBuffSourceType.LifeSaving);
			}
		}
		base.BGSEventCollection?.Evt_BGS_ClearAttachedProjectiles_OnUnit.Invoke(Owner);
	}

	private void EndLifeSavingHair()
	{
		if (!LifeSavingData.bAlreadyCast)
		{
			return;
		}
		LifeSavingData.bRebirthPrepare = false;
		LifeSavingData.bAlreadyCast = false;
		base.BUSEventCollection.Evt_BuffRemove.Invoke(218, EBuffEffectTriggerType.None, 1);
		base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Exit_LifeSavingHair, -1f);
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.ImmueAnimationSyncing, IsRemove: true);
		foreach (int item in LifeSavingData.BuffIDList_DurLifeSaving)
		{
			base.BUSEventCollection.Evt_BuffRemove.Invoke(item, EBuffEffectTriggerType.None, 1);
		}
		LifeSavingData.BuffIDList_DurLifeSaving.Clear();
	}

	private void OnTriggerSwitchMagicConfInfo(SpellType SpellType, int NewSpellId, int OldSpellId)
	{
		if (SpellType == SpellType.HaoMao)
		{
			if (NewSpellId == LifeSavingData.SpellID)
			{
				Enable();
			}
			else
			{
				Disable();
			}
		}
	}

	private void Enable()
	{
		LifeSavingData.bEnable = true;
	}

	private void Disable()
	{
		LifeSavingData.bEnable = false;
	}

	private void TriggerLifeSavingHair()
	{
		if (!UnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) || LifeSavingData.bAlreadyCast)
		{
			return;
		}
		LifeSavingData.bAlreadyCast = true;
		FUStLifeSavingHairConfigDesc lifeSavingHairConfigDesc = BGW_GameDB.GetLifeSavingHairConfigDesc(GetActorResID(), Owner);
		if (lifeSavingHairConfigDesc.EffectIDList.Count > 0)
		{
			FEffectInstReq effectInstReq = new FEffectInstReq(GetOwner());
			foreach (int effectID in lifeSavingHairConfigDesc.EffectIDList)
			{
				base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(effectID, effectInstReq);
			}
		}
		if (lifeSavingHairConfigDesc.BuffIDList.Count > 0)
		{
			foreach (int buffID in lifeSavingHairConfigDesc.BuffIDList)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(buffID, Owner, Owner, 0f, EBuffSourceType.LifeSaving);
			}
		}
		if (LifeSavingData.bActive_ExtLifeSaving)
		{
			LifeSavingData.bActive_ExtLifeSaving = false;
		}
		else
		{
			float num = (float)lifeSavingHairConfigDesc.DefaultCD / 1000f;
			LifeSavingData.DefaultCD = num;
			LifeSavingData.CoolDownRemainTimer = num;
		}
		bool flag = false;
		string aMPath = lifeSavingHairConfigDesc.AMPath;
		if (!string.IsNullOrEmpty(aMPath))
		{
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UAnimMontage>(aMPath, ELoadResourceType.SyncLoadAndCache, EAssetPriority.High);
			if (uAnimMontage != null)
			{
				ACharacter aCharacter = Owner as ACharacter;
				if (aCharacter != null)
				{
					aCharacter.StopAnimMontage(null);
					EMontageBindReason reason = EMontageBindReason.LifeSavingHair;
					BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, uAnimMontage, FName.None, reason);
					base.BUSEventCollection.Evt_SetTriggerMontage.Invoke(P1: true);
					base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Enter_LifeSavingHair_Rebirth, -1f);
					flag = true;
				}
			}
		}
		if (!flag)
		{
			EndLifeSavingHair();
		}
		base.BUSEventCollection?.Evt_OnCastLifeSavingSuccess.Invoke();
	}

	private void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (Reason == EMontageBindReason.LifeSavingHair && (State == EMontageCallbackState.OnCompleted || State == EMontageCallbackState.OnBlendOut || State == EMontageCallbackState.OnInterrupted))
		{
			EndLifeSavingHair();
		}
	}

	private void RecoverLifeSavingHairCoolDown(float CoolDown)
	{
		LifeSavingData.CoolDownRemainTimer = CoolDown;
	}

	private void DecreaseLifeSavingHairCoolDown(float Value)
	{
		LifeSavingData.CoolDownRemainTimer = FMath.Clamp(LifeSavingData.CoolDownRemainTimer - Value, 0f, LifeSavingData.CoolDownRemainTimer);
	}

	private void OnFakeDeadAMStart(float AMLength)
	{
		LifeSavingData.bRebirthPrepare = true;
		LifeSavingData.RebirthRemainTimer = AMLength;
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		InterruptLifeSaving();
	}

	private void OnPlayerRebirth(ERebirthType RebirthType = ERebirthType.RebirthPoint)
	{
		LifeSavingData.CoolDownRemainTimer = 0f;
	}

	private void InterruptLifeSaving()
	{
		if (UnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) || UnitStateData.HasState(EBGUUnitState.LifeSavingHair_Rebirth))
		{
			LifeSavingData.bRebirthPrepare = false;
			EndLifeSavingHair();
		}
	}

	private void Active_ExtLifeSaving(bool Active)
	{
		LifeSavingData.bActive_ExtLifeSaving = Active;
	}
}
