using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_TransPlayerDataBindComp : UActorCompBaseCS
{
	public static readonly Dictionary<int, int> PlayerAttrDict = new Dictionary<int, int>
	{
		{ 151, 1 },
		{ 152, 2 },
		{ 186, 36 },
		{ 188, 11 },
		{ 191, 39 },
		{ 201, 16 },
		{ 202, 17 }
	};

	private IBPC_PlayerTagData PlayerTagData;

	private IBUC_AttrContainer AttrContron;

	private BPC_PlayerAttrData PlayerAttrData;

	public override void OnAttach()
	{
		PlayerAttrData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerAttrData>((GetOwner() as APawn).PlayerState);
		PlayerTagData = RequireReadOnlyControledPlayerStateData<IBPC_PlayerTagData, BPC_PlayerTagData>();
		AttrContron = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		base.BUSEventCollection.Evt_PostTransBindData += new Del_Void_Actor(OnPostTransBindData);
		base.BUSEventCollection.Evt_PostLoginBindData += new Del_Void(OnPostLoginBindData);
		base.BUSEventCollection.Evt_UpdatePlayerBindData += new Del_Void(OnUpdatePlayerBindData);
	}

	private void OnPostLoginBindData()
	{
		if ((GetOwner() as ABGUCharacter).GetController() != null)
		{
			BindListPlayerPersistentAttr playerPersistentAttr = PlayerAttrData.PlayerPersistentAttr;
			foreach (KeyValuePair<int, int> item in PlayerAttrDict)
			{
				bool flag = false;
				foreach (PlayerPersistentAttr item2 in playerPersistentAttr)
				{
					if (item2.AttrId == item.Key)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					PlayerPersistentAttr playerPersistentAttr2 = new PlayerPersistentAttr();
					playerPersistentAttr2.AttrId = item.Key;
					playerPersistentAttr2.AttrMaxId = item.Value;
					playerPersistentAttr2.AttrValue = GetValueAndType(item.Key, AttrContron.GetFloatValue((EBGUAttrFloat)item.Key), AttrContron.GetFloatValue((EBGUAttrFloat)item.Value), out var _);
					playerPersistentAttr.Add(playerPersistentAttr2);
				}
			}
		}
		OnPostBindData();
	}

	private void OnUpdatePlayerBindData()
	{
		if (!PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			OnUpdateSkillCD(GetOwner());
		}
	}

	private void OnUpdateSkillCD(AActor OldActor)
	{
		PlayerAttrData.PlayerMagicSkillCd.Clear();
		BUC_PlayerSpellConfData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_PlayerSpellConfData>(OldActor);
		IBUC_SkillInstsData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(OldActor);
		if (readOnlyData != null && readOnlyData.MagicConfInfo != null)
		{
			foreach (FUStMagicConfInfo item in readOnlyData.MagicConfInfo)
			{
				SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(item.SpellID);
				if (spellDesc != null)
				{
					int skillId = spellDesc.SkillId;
					if (!readOnlyData2.GetSkillCooldownTime(skillId, out var RemainingCooldownTime, out var _))
					{
						PlayerAttrData.PlayerMagicSkillCd.Add(new PlayerMagicSkillCd
						{
							SkillId = skillId,
							CoolDown = RemainingCooldownTime
						});
					}
				}
			}
		}
		if (BGU_DataUtil.GetActorResID(OldActor) == 10)
		{
			b1.IBUC_LifeSavingData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<b1.IBUC_LifeSavingData, BUC_LifeSavingData>(OldActor);
			if (readOnlyData3 != null)
			{
				PlayerAttrData.PlayerLifeSavingCoolDownRemainTime = readOnlyData3.CoolDownRemainTimer;
			}
		}
	}

	private float GetValueAndType(int AttrId, float CurValue, float ValueMax, out EPlayerAttrRecoverType AttrRecoverType)
	{
		AttrRecoverType = EPlayerAttrRecoverType.Percentage;
		switch (AttrId)
		{
		case 188:
		{
			if (!PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
			{
				break;
			}
			float num2 = AttrContron.GetFloatValue(EBGUAttrFloat.TransEnergyMax) - AttrContron.GetFloatValue(EBGUAttrFloat.EnergyMinConsume);
			if (AttrContron.GetFloatValue(EBGUAttrFloat.CurEnergy) > num2)
			{
				if (!(ValueMax > 0f))
				{
					return 0f;
				}
				return num2 / ValueMax;
			}
			break;
		}
		case 191:
		{
			FUStPlayerTransAttrDesc playerTransAttrDesc = BGW_GameDB.GetPlayerTransAttrDesc((GetOwner() as BGUCharacterCS).GetResID());
			if (playerTransAttrDesc == null)
			{
				break;
			}
			float num = (float)playerTransAttrDesc.TransBackPELevelMul * 0.0001f;
			if (playerTransAttrDesc.PELevelInheritedType == EPELevelInheritedType.MulInherited)
			{
				if (!(ValueMax > 0f))
				{
					return 0f;
				}
				return num * CurValue / ValueMax;
			}
			if (playerTransAttrDesc.PELevelInheritedType == EPELevelInheritedType.BaseInherited)
			{
				AttrRecoverType = EPlayerAttrRecoverType.AbsValue;
				return num * CurValue;
			}
			break;
		}
		}
		if (!(ValueMax > 0f))
		{
			return 0f;
		}
		return CurValue / ValueMax;
	}

	private void OnPostTransBindData(AActor OldActor)
	{
		PostTransBindDataInit(OldActor);
		OnPostBindData();
	}

	private void PostTransBindDataInit(AActor OldActor)
	{
		if (!PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			return;
		}
		foreach (PlayerPersistentAttr item in PlayerAttrData.PlayerPersistentAttr)
		{
			EBGUAttrFloat eBGUAttrFloat = (EBGUAttrFloat)item.AttrId;
			if (CheckCanAttrChange(eBGUAttrFloat))
			{
				item.AttrValue = GetValueAndType(item.AttrId, AttrContron.GetFloatValue(eBGUAttrFloat), AttrContron.GetFloatValue((EBGUAttrFloat)item.AttrMaxId), out var AttrRecoverType);
				item.AttrValueType = AttrRecoverType;
			}
		}
		OnUpdateSkillCD(OldActor);
	}

	private void OnPostBindData()
	{
		BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(GetOwner())?.FloatAttrs.BindOnSetIdxValue(OnBindOnSetIdxValue);
	}

	public bool IsSpecialTrans()
	{
		int resID = (GetOwner() as BGUCharacterCS).GetResID();
		bool result = false;
		FUStPlayerTransUnitConfDesc fUStPlayerTransUnitConfDesc = BGW_GameDB.GetFUStPlayerTransUnitConfDesc(resID);
		if (fUStPlayerTransUnitConfDesc != null && fUStPlayerTransUnitConfDesc.ReSetTransId > 0)
		{
			result = true;
		}
		return result;
	}

	public void OnBindOnSetIdxValue(int AttrId, float OldValue, float NewValue)
	{
		foreach (PlayerPersistentAttr item in PlayerAttrData.PlayerPersistentAttr)
		{
			if (AttrId == item.AttrId)
			{
				OnAttrChange((EBGUAttrFloat)item.AttrId, OldValue, NewValue);
			}
		}
	}

	public void OnAttrChange(EBGUAttrFloat BindAttrId, float OldValue, float NewValue)
	{
		if (!CheckCanAttrChange(BindAttrId))
		{
			return;
		}
		foreach (PlayerPersistentAttr item in PlayerAttrData.PlayerPersistentAttr)
		{
			if (item.AttrId == (int)BindAttrId)
			{
				item.AttrValue = GetValueAndType(item.AttrId, NewValue, AttrContron.GetFloatValue((EBGUAttrFloat)item.AttrMaxId), out var AttrRecoverType);
				item.AttrValueType = AttrRecoverType;
			}
		}
	}

	private bool CheckCanAttrChange(EBGUAttrFloat BindAttrId)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null && PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			if (BindAttrId != EBGUAttrFloat.Hp && BindAttrId != EBGUAttrFloat.CurEnergy && BindAttrId != EBGUAttrFloat.Pevalue)
			{
				return false;
			}
			FUStPlayerTransAttrDesc playerTransAttrDesc = BGW_GameDB.GetPlayerTransAttrDesc(bGUCharacterCS.GetResID());
			if (playerTransAttrDesc != null)
			{
				if (playerTransAttrDesc.InheritCurHp == EGSYesNo.No && BindAttrId == EBGUAttrFloat.Hp)
				{
					return false;
				}
				if (BindAttrId == EBGUAttrFloat.Pevalue && playerTransAttrDesc.PELevelInheritedType == EPELevelInheritedType.None)
				{
					return false;
				}
				if (BindAttrId == EBGUAttrFloat.CurEnergy && IsSpecialTrans())
				{
					return false;
				}
			}
		}
		return true;
	}
}
