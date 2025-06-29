using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_TransSystemServer : PlayerControllerSystemBase
{
	private IBPC_PlayerTagData PlayerTagData;

	private IBIC_LevelData LevelData;

	private IBPC_PlayerAttrData PlayerAttrData;

	private IBPC_RebirthPointData RebirthPointData;

	private BPS_GSEventCollection EventCollection;

	private BPC_TransData TransData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		TransData = RequireWritablePlayerStateData<BPC_TransData>();
		PlayerTagData = RequireReadOnlyPlayerStateData<IBPC_PlayerTagData, BPC_PlayerTagData>();
		LevelData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(Owner);
		PlayerAttrData = RequireReadOnlyPlayerStateData<IBPC_PlayerAttrData, BPC_PlayerAttrData>();
		RebirthPointData = BGU_DataUtil.GetReadOnlyData<IBPC_RebirthPointData, BPC_RebirthPointData>(Owner);
		GetPlayerEventCollection()?.Evt_BPS_PlayerTagTrigger.Invoke(EBGPTagTrigger.PauseEneryEnd, -1f);
		EventCollection = GetPlayerEventCollection();
		if (EventCollection != null)
		{
			EventCollection.Evt_TriggerPlayerTransBegin += new Del_PlayerTransBegin(OnPlayerTransBegin);
			EventCollection.Evt_TriggerPlayerTransEnd += new Del_PlayerTransEnd(OnPlayerTransEnd);
		}
	}

	private void OnPlayerTransBegin(EPlayerTransBeginType UnitTransType, PlayerTransParam PlayerTransParam)
	{
		_ = DebugConfig.DebugPlayerTransLog;
		if (CheckCanTrans(UnitTransType))
		{
			DoTransLogic(UnitTransType, PlayerTransParam);
		}
	}

	private bool CheckCanTrans(EPlayerTransBeginType UnitTransBeginType)
	{
		if (PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			return false;
		}
		switch (UnitTransBeginType)
		{
		case EPlayerTransBeginType.Plot:
		case EPlayerTransBeginType.RebirthPoint:
			return true;
		case EPlayerTransBeginType.Sequence:
			return true;
		default:
		{
			if (PlayerTagData.HasTag(EBGPPlayerTag.DisableTransforming))
			{
				return false;
			}
			BUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(GetControlledPlayerCharacter());
			if (readOnlyData.HasSimpleState(EBGUSimpleState.CantTrans) || readOnlyData.HasSimpleState(EBGUSimpleState.CantTransInSeq))
			{
				return false;
			}
			_ = 4;
			return true;
		}
		}
	}

	private void DoTransLogic(EPlayerTransBeginType UnitTransBeginType, PlayerTransParam PlayerTransParam)
	{
		BGUPlayerCharacterCS controlledPlayerCharacter = GetControlledPlayerCharacter();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(controlledPlayerCharacter);
		if (!(bUS_GSEventCollection == null))
		{
			BUC_PlayerSpellConfData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_PlayerSpellConfData>(controlledPlayerCharacter);
			TransData.CurEnterTransReason = UnitTransBeginType;
			switch (UnitTransBeginType)
			{
			case EPlayerTransBeginType.CastSpell:
				bUS_GSEventCollection.Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(GetTranSkillIdBySpellType(readOnlyData, SpellType.BianShen), ECastSkillSourceType.Trans));
				break;
			case EPlayerTransBeginType.Ride:
				bUS_GSEventCollection.Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(GetTranSkillIdBySpellType(readOnlyData, SpellType.Ride), ECastSkillSourceType.Trans));
				break;
			case EPlayerTransBeginType.BianChan:
				bUS_GSEventCollection.Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(10511, ECastSkillSourceType.Trans));
				break;
			default:
				TransBeginSpawnNewPawn(PlayerTransParam, UnitTransBeginType);
				break;
			}
		}
	}

	private void OnPlayerTransEnd(EPlayerTransEndType UnitTransType, PlayerTransParam PlayerTransParam)
	{
		_ = DebugConfig.DebugPlayerTransLog;
		if (CheckCanTransBack(UnitTransType, PlayerTransParam))
		{
			DoTransBackLogic(UnitTransType, PlayerTransParam);
		}
	}

	private bool IsPlotTransEndType(EPlayerTransEndType UnitTransEndType)
	{
		if (UnitTransEndType == EPlayerTransEndType.Plot || UnitTransEndType == EPlayerTransEndType.SettingransBack || UnitTransEndType == EPlayerTransEndType.CantTrans || UnitTransEndType == EPlayerTransEndType.CPGTransBack || UnitTransEndType == EPlayerTransEndType.CMGTransBack || UnitTransEndType == EPlayerTransEndType.RebirthTransBack)
		{
			return true;
		}
		return false;
	}

	private bool CheckCanTransBack(EPlayerTransEndType UnitTransEndType, PlayerTransParam PlayerTransParam)
	{
		if (!PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			return false;
		}
		int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.DashenDefaultResid);
		if (TransData.GetCurActorResId() == commLogicCfgValue)
		{
			return false;
		}
		if (TransData.GetCurEnterTransReason() == EPlayerTransBeginType.Plot && !IsPlotTransEndType(UnitTransEndType))
		{
			return false;
		}
		if (TransData.GetCurEnterTransReason() == EPlayerTransBeginType.RebirthPoint)
		{
			bool flag = false;
			if (RebirthPointData != null)
			{
				FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(RebirthPointData.GetCurrentRebirthPointID(GetOwner()));
				if (rebirthPointDesc != null && rebirthPointDesc.AllowTransBackMaunl > 0)
				{
					flag = true;
					ABGPPlayerController aBGPPlayerController = GetOwner() as ABGPPlayerController;
					if (aBGPPlayerController != null)
					{
						BUS_EventCollectionCS.Get(aBGPPlayerController.GetControlledPawn())?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.IgnoreUnitTransSkill, IsRemove: true);
					}
				}
			}
			if (!flag && !IsPlotTransEndType(UnitTransEndType))
			{
				return false;
			}
		}
		BGUPlayerCharacterCS controlledPlayerCharacter = GetControlledPlayerCharacter();
		if (controlledPlayerCharacter.IsNullOrDestroyed())
		{
			return false;
		}
		switch (UnitTransEndType)
		{
		case EPlayerTransEndType.EnergyEmpty:
		{
			BUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(controlledPlayerCharacter);
			if (readOnlyData2 != null && readOnlyData2.HasSimpleState(EBGUSimpleState.CantTransBack))
			{
				return false;
			}
			break;
		}
		case EPlayerTransEndType.BeatBack:
		{
			FUStPlayerTransUnitConfDesc fUStPlayerTransUnitConfDesc = BGW_GameDB.GetFUStPlayerTransUnitConfDesc(controlledPlayerCharacter.GetResID());
			if (fUStPlayerTransUnitConfDesc != null && fUStPlayerTransUnitConfDesc.TransBackBeHit > 0)
			{
				return true;
			}
			return false;
		}
		case EPlayerTransEndType.CantRide:
			if (TransData.TransType != EPlayerTransType.Ride)
			{
				return false;
			}
			break;
		case EPlayerTransEndType.TriggerBoxForceTransBack:
			if (TransData.TransType == EPlayerTransType.Ride)
			{
				return false;
			}
			break;
		case EPlayerTransEndType.CastSpell:
		{
			BUC_SkillInstsData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SkillInstsData>(controlledPlayerCharacter);
			int num = ((PlayerTransParam.TransSkillId != 0) ? PlayerTransParam.TransSkillId : GetTranBackSkillIdByTransType(controlledPlayerCharacter, UnitTransEndType));
			if (readOnlyData.CurrentCastingSkillID == num)
			{
				return false;
			}
			if (BGU_CommonUtil.CheckSkillCanCast(controlledPlayerCharacter, num, num) != ECanCastSkillResult.CCSR_OK)
			{
				return false;
			}
			break;
		}
		}
		return true;
	}

	private void DoTransBackLogic(EPlayerTransEndType UnitTransEndType, PlayerTransParam PlayerTransParam)
	{
		BGUPlayerCharacterCS controlledPlayerCharacter = GetControlledPlayerCharacter();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(controlledPlayerCharacter);
		if (!(bUS_GSEventCollection == null))
		{
			int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.PlayerDefaultResid);
			FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(commLogicCfgValue, Owner);
			switch (UnitTransEndType)
			{
			case EPlayerTransEndType.RebirthTransBack:
				bUS_GSEventCollection.Evt_TransBackSpawnNewOne.Invoke(commLogicCfgValue, playerCommDesc.RebirthSkillID, EnableBlendViewTarget: false, UnitTransEndType);
				break;
			case EPlayerTransEndType.Buff:
				TransBackSpawnNewPawn(PlayerTransParam, UnitTransEndType);
				break;
			case EPlayerTransEndType.CMGTransBack:
				PlayerTransParam.TargetResId = commLogicCfgValue;
				TransBackSpawnNewPawn(PlayerTransParam, UnitTransEndType);
				break;
			case EPlayerTransEndType.SettingransBack:
				bUS_GSEventCollection.Evt_TransBackSpawnNewOne.Invoke(commLogicCfgValue, 0, EnableBlendViewTarget: false, UnitTransEndType);
				break;
			default:
				TransBackByCastSkill(controlledPlayerCharacter, bUS_GSEventCollection, UnitTransEndType, PlayerTransParam.TransSkillId);
				break;
			}
			bUS_GSEventCollection.Evt_TransBack_PreUnitTrans.Invoke(UnitTransEndType);
			TransData.CurEnterTransReason = EPlayerTransBeginType.None;
		}
	}

	private void TransBackByCastSkill(BGUPlayerCharacterCS CurPlayer, BUS_GSEventCollection BE, EPlayerTransEndType TransType, int SkillId)
	{
		BUC_SkillInstsData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SkillInstsData>(CurPlayer);
		int num = SkillId;
		if (num == 0)
		{
			num = GetTranBackSkillIdByTransType(CurPlayer, TransType);
		}
		if (readOnlyData.CurrentCastingSkillID != num)
		{
			BE.Evt_UnitTryBreakSkill.Invoke("退出变身");
			BE.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Rebirth, -1f);
			BE.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.ImmueStiff);
			if (TransData.CurEnterTransReason == EPlayerTransBeginType.Ride)
			{
				BE.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.RidingExitingStatus);
			}
			BE.Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(num, ECastSkillSourceType.Trans)
			{
				NeedCheckSkillCanCast = false
			});
		}
	}

	private int GetTranBackSkillIdByTransType(BGUPlayerCharacterCS CurPlayer, EPlayerTransEndType TransType)
	{
		int result = 0;
		BUC_PlayerSpellConfData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_PlayerSpellConfData>(CurPlayer);
		BGU_DataUtil.GetReadOnlyData<BUC_SkillInstsData>(CurPlayer);
		switch (TransType)
		{
		case EPlayerTransEndType.CastSpell:
			result = GetTranSkillIdBySpellType(readOnlyData, SpellType.BianShen);
			break;
		case EPlayerTransEndType.ManualEndRide:
			result = GetTranSkillIdBySpellType(readOnlyData, SpellType.Ride);
			break;
		case EPlayerTransEndType.CPGTransBack:
		{
			BUC_PlayerTransData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_PlayerTransData>(CurPlayer);
			if (readOnlyData2 != null)
			{
				result = readOnlyData2.TransBackSkillID;
			}
			break;
		}
		default:
		{
			FUStPlayerTransUnitConfDesc fUStPlayerTransUnitConfDesc = BGW_GameDB.GetFUStPlayerTransUnitConfDesc(CurPlayer.GetResID());
			if (fUStPlayerTransUnitConfDesc != null)
			{
				result = fUStPlayerTransUnitConfDesc.TransBackSkillId;
			}
			break;
		}
		}
		return result;
	}

	private void TransBeginSpawnNewPawn(PlayerTransParam PlayerTransParam, EPlayerTransBeginType UnitTransBeginType)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(GetControlledPlayerCharacter());
		if (!(bUS_GSEventCollection == null))
		{
			bUS_GSEventCollection.Evt_TransBeginSpawnNewOne.Invoke(PlayerTransParam.TargetResId, PlayerTransParam.SpawnSkillId, PlayerTransParam.NeedBlend, UnitTransBeginType);
		}
	}

	private void TransBackSpawnNewPawn(PlayerTransParam PlayerTransParam, EPlayerTransEndType UnitTransEndType)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(GetControlledPlayerCharacter());
		if (!(bUS_GSEventCollection == null))
		{
			bUS_GSEventCollection.Evt_TransBackSpawnNewOne.Invoke(PlayerTransParam.TargetResId, PlayerTransParam.SpawnSkillId, PlayerTransParam.NeedBlend, UnitTransEndType);
		}
	}

	private int GetTranSkillIdBySpellType(BUC_PlayerSpellConfData PlayerSpellConfData, SpellType SpellType)
	{
		if (PlayerSpellConfData == null)
		{
			return 0;
		}
		for (int i = 0; i < PlayerSpellConfData.MagicConfInfo.Count; i++)
		{
			if (PlayerSpellConfData.MagicConfInfo[i].Type == SpellType)
			{
				SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(PlayerSpellConfData.MagicConfInfo[i].SpellID);
				if (spellDesc != null)
				{
					return spellDesc.SkillId;
				}
			}
		}
		return 0;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (EventCollection != null)
		{
			EventCollection.Evt_TriggerPlayerTransBegin -= new Del_PlayerTransBegin(OnPlayerTransBegin);
			EventCollection.Evt_TriggerPlayerTransEnd -= new Del_PlayerTransEnd(OnPlayerTransEnd);
		}
	}
}
