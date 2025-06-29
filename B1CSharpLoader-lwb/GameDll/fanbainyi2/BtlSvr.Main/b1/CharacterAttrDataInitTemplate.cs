using b1.ECS;
using BtlB1;
using BtlShare;
using CommB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class CharacterAttrDataInitTemplate : ECSDataInitTemplate
{
	protected bool IsOnline()
	{
		int actorNetRole = BGUFuncLibReplication.GetActorNetRole(Owner);
		if ((actorNetRole & 4) > 0)
		{
			return true;
		}
		if ((actorNetRole & 8) > 0)
		{
			return true;
		}
		return false;
	}

	protected CharacterAttrDataInitTemplate(Entity InitEntity, int AActorNetRole)
		: base(InitEntity, AActorNetRole)
	{
	}

	public override void InitDataPreBeginPlay()
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUC_AttrContainer data = GetData<BUC_AttrContainer>();
			if (!DebugConfig.CricketBattleMode)
			{
				data.SetHPFixedDM(bGUCharacterCS.GetFinalBattleInfoExtendID());
			}
			InitAttrsBySvr();
		}
	}

	public override void InitDataLateBeginPlay()
	{
	}

	public bool IsSpecialTrans(int ResId)
	{
		bool result = false;
		FUStPlayerTransUnitConfDesc fUStPlayerTransUnitConfDesc = BGW_GameDB.GetFUStPlayerTransUnitConfDesc(ResId);
		if (fUStPlayerTransUnitConfDesc != null && fUStPlayerTransUnitConfDesc.ReSetTransId > 0)
		{
			result = true;
		}
		return result;
	}

	protected void InitAttrsBySvr()
	{
		EffectAttrList baseAttrList = GetBaseAttrList();
		BUC_AttrContainer data = GetData<BUC_AttrContainer>();
		if (baseAttrList.Attrs.Count == 0)
		{
			return;
		}
		foreach (EffectAttrFloat attr in baseAttrList.Attrs)
		{
			data.SetFloatValue(attr.Type, attr.Value);
		}
		if (DebugConfig.CricketBattleMode)
		{
			BGWCricketMgrLogic.ReClcCricketBattleUnitAttr(data, Owner);
		}
		InitAttrByMaxAttr();
	}

	private EffectAttrList GetBaseAttrList()
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		EffectAttrList result = new EffectAttrList();
		if (bGUCharacterCS != null)
		{
			int resID = bGUCharacterCS.GetResID();
			if (bGUCharacterCS.IsPlayerControlled())
			{
				APlayerController aPlayerController = bGUCharacterCS.GetController() as APlayerController;
				if (aPlayerController != null)
				{
					IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(aPlayerController);
					if (readOnlyData != null && readOnlyData.AttrFloatList != null)
					{
						result = readOnlyData.AttrFloatList;
					}
				}
			}
			else
			{
				int newGamePlusCount = 0;
				int finalBattleInfoExtendID = BGU_DataUtil.GetFinalBattleInfoExtendID(Owner);
				FUStUnitBattleInfoExtendDesc fUStUnitBattleInfoExtendDesc = GameDBRuntime.GetFUStUnitBattleInfoExtendDesc(finalBattleInfoExtendID);
				bool flag = true;
				if (fUStUnitBattleInfoExtendDesc != null)
				{
					flag = fUStUnitBattleInfoExtendDesc.GameCountNotUpdateAttr == EGSYesNo.No;
				}
				if (!IsOnline() && flag)
				{
					newGamePlusCount = BGW_GamePlayCountUtil.GetCurGamePlayCount(Owner);
				}
				if (DebugConfig.DebugGameCount > 0 && flag)
				{
					newGamePlusCount = DebugConfig.DebugGameCount;
				}
				result = EffectAttrApi.GetUnitBaseAttrList(resID, finalBattleInfoExtendID, newGamePlusCount, bGUCharacterCS);
			}
		}
		return result;
	}

	private void InitAttrByMaxAttr()
	{
		BUC_AttrContainer data = GetData<BUC_AttrContainer>();
		data.SetFloatValue(EBGUAttrFloat.Hp, data.GetFloatValue(EBGUAttrFloat.HpMax));
		data.SetFloatValue(EBGUAttrFloat.Mp, data.GetFloatValue(EBGUAttrFloat.MpMax));
		data.SetFloatValue(EBGUAttrFloat.B1Stun, data.GetFloatValue(EBGUAttrFloat.B1StunMax));
		data.SetFloatValue(EBGUAttrFloat.SkillSuperArmor, data.GetFloatValue(EBGUAttrFloat.SkillSuperArmorMax));
		data.SetFloatValue(EBGUAttrFloat.BlindSlot, data.GetFloatValue(EBGUAttrFloat.BlindSlotMax));
		data.SetFloatValue(EBGUAttrFloat.BlockCollapseArmor, data.GetFloatValue(EBGUAttrFloat.BlockCollapseArmorMax));
		data.SetFloatValue(EBGUAttrFloat.Stamina, data.GetFloatValue(EBGUAttrFloat.StaminaMax));
		data.SetFloatValue(EBGUAttrFloat.BloodBottomNum, data.GetFloatValMax(EBGUAttrFloat.BloodBottomNumMax));
	}

	protected void InitEnergy()
	{
		APawn aPawn = Owner as APawn;
		BUC_AttrContainer data = GetData<BUC_AttrContainer>();
		int num = 0;
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(aPawn.GetController());
		if (readOnlyData == null || readOnlyData.RoleData == null)
		{
			return;
		}
		foreach (ReadOnlySpellItem spell in readOnlyData.RoleData.RoleCs.Actor.Wear.SpellList)
		{
			if (spell.Type == SpellType.BianShen)
			{
				num = spell.SpellId;
				break;
			}
		}
		BGUCharacterCS bGUCharacterCS = aPawn as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			FUStPlayerTransUnitConfDesc fUStPlayerTransUnitConfDesc = BGW_GameDB.GetFUStPlayerTransUnitConfDesc(bGUCharacterCS.GetResID());
			if (fUStPlayerTransUnitConfDesc != null && fUStPlayerTransUnitConfDesc.ReSetTransId > 0)
			{
				num = fUStPlayerTransUnitConfDesc.ReSetTransId;
			}
		}
		SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(num);
		if (spellDesc == null)
		{
			return;
		}
		if (spellDesc.Type != SpellType.BianShen)
		{
			if (FGlobals.IsEditor)
			{
				_ = $"存在错误的法术类型：{num}的法术类型不是变身";
			}
		}
		else
		{
			data.SetFloatValue(EBGUAttrFloat.TransEnergyMaxBase, (spellDesc.FloatParam.Count > 0) ? spellDesc.FloatParam[0] : 0f);
			data.SetFloatValue(EBGUAttrFloat.EnergyMinConsumeBase, (spellDesc.FloatParam.Count > 1) ? spellDesc.FloatParam[1] : 0f);
			data.SetFloatValue(EBGUAttrFloat.EnergyConsumeSpeedBase, (spellDesc.FloatParam.Count > 2) ? spellDesc.FloatParam[2] : 0f);
			data.SetFloatValue(EBGUAttrFloat.EnergyIncreaseSpeedBase, (spellDesc.FloatParam.Count > 3) ? spellDesc.FloatParam[3] : 0f);
		}
	}

	public override void InitDataOnNew()
	{
	}
}
