using b1.ECS;
using BtlB1;
using BtlShare;
using CsB1;
using UnrealEngine.Engine;

namespace b1;

public class PlayerTransAttrDataInit : CharacterAttrDataInitTemplate, IPlayerDataInitTemplate
{
	public PlayerTransAttrDataInit(Entity InitEntity, int AActorNetRole)
		: base(InitEntity, AActorNetRole)
	{
	}

	public override void InitDataPreBeginPlay()
	{
		InitEnergy();
		base.InitDataPreBeginPlay();
		ClcTransAttr();
	}

	public override void InitDataLateBeginPlay()
	{
	}

	private void ClcTransAttr()
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS.IsPlayerControlled())
		{
			ReClcPlayerBaseAttrList(bGUCharacterCS.GetResID());
		}
		CSMsgAttrRefreshReq attrRefresh = new CSMsgAttrRefreshReq();
		BTF_EventCollectionCS.Get(bGUCharacterCS.PlayerState)?.Evt_AttrRefreshReq(attrRefresh, null);
	}

	private void ReClcPlayerBaseAttrList(int ResId)
	{
		ABGUCharacter aBGUCharacter = Owner as ABGUCharacter;
		if (!(aBGUCharacter == null) && aBGUCharacter.IsPlayerControlled())
		{
			FUStPlayerTransAttrDesc playerTransAttrDesc = BGW_GameDB.GetPlayerTransAttrDesc(ResId);
			if (playerTransAttrDesc != null)
			{
				InitAttrsBySvr();
				BUC_AttrContainer data = GetData<BUC_AttrContainer>();
				float num = 0.0001f;
				data.SetFloatValue(EBGUAttrFloat.HpMaxBase, data.GetFloatValue(EBGUAttrFloat.HpMax) * (float)playerTransAttrDesc.HpMul * num + (float)playerTransAttrDesc.HpBase);
				data.SetFloatValue(EBGUAttrFloat.AtkBase, data.GetFloatValue(EBGUAttrFloat.Atk) * (float)playerTransAttrDesc.AtkMul * num + (float)playerTransAttrDesc.AtkBase);
				data.SetFloatValue(EBGUAttrFloat.DefBase, data.GetFloatValue(EBGUAttrFloat.Def) * (float)playerTransAttrDesc.DefMul * num + (float)playerTransAttrDesc.DefBase);
				data.SetFloatValue(EBGUAttrFloat.CritRateBase, data.GetFloatValue(EBGUAttrFloat.CritRate) * (float)playerTransAttrDesc.CritRateMul * num + (float)playerTransAttrDesc.CritRateBase);
				data.SetFloatValue(EBGUAttrFloat.CritMultiplierBase, data.GetFloatValue(EBGUAttrFloat.CritMultiplier) * (float)playerTransAttrDesc.CritMultiplierMul * num + (float)playerTransAttrDesc.CritMultiplierBase);
				data.SetFloatValue(EBGUAttrFloat.CritRateDefBase, data.GetFloatValue(EBGUAttrFloat.CritRateDef) * (float)playerTransAttrDesc.CritRateDefMul * num + (float)playerTransAttrDesc.CritRateDefBase);
				data.SetFloatValue(EBGUAttrFloat.CritDmgMulDefBase, data.GetFloatValue(EBGUAttrFloat.CritDmgMulDef) * (float)playerTransAttrDesc.CritDmgMulDefMul * num + (float)playerTransAttrDesc.CritDmgMulDefBase);
				data.SetFloatValue(EBGUAttrFloat.DmgAdditionBase, data.GetFloatValue(EBGUAttrFloat.DmgAddition) * (float)playerTransAttrDesc.DmgAdditionMul * num + (float)playerTransAttrDesc.DmgAdditionBase);
				data.SetFloatValue(EBGUAttrFloat.DmgDefBase, data.GetFloatValue(EBGUAttrFloat.DmgDef) * (float)playerTransAttrDesc.DmgDefMul * num + (float)playerTransAttrDesc.DmgDefBase);
				data.SetFloatValue(EBGUAttrFloat.FreezeAtkBase, data.GetFloatValue(EBGUAttrFloat.FreezeAtk) * (float)playerTransAttrDesc.FreezeAtkMul * num + (float)playerTransAttrDesc.FreezeAtkBase);
				data.SetFloatValue(EBGUAttrFloat.BurnAtkBase, data.GetFloatValue(EBGUAttrFloat.BurnAtk) * (float)playerTransAttrDesc.BurnAtkMul * num + (float)playerTransAttrDesc.BurnAtkBase);
				data.SetFloatValue(EBGUAttrFloat.PoisonAtkBase, data.GetFloatValue(EBGUAttrFloat.PoisonAtk) * (float)playerTransAttrDesc.PoisonAtkMul * num + (float)playerTransAttrDesc.PoisonAtkBase);
				data.SetFloatValue(EBGUAttrFloat.ThunderAtkBase, data.GetFloatValue(EBGUAttrFloat.ThunderAtk) * (float)playerTransAttrDesc.ThunderAtkMul * num + (float)playerTransAttrDesc.ThunderAtkBase);
				data.SetFloatValue(EBGUAttrFloat.FreezeDefBase, data.GetFloatValue(EBGUAttrFloat.FreezeDef) * (float)playerTransAttrDesc.FreezeDefMul * num + (float)playerTransAttrDesc.FreezeDefBase);
				data.SetFloatValue(EBGUAttrFloat.BurnDefBase, data.GetFloatValue(EBGUAttrFloat.BurnDef) * (float)playerTransAttrDesc.BurnDefMul * num + (float)playerTransAttrDesc.BurnDefBase);
				data.SetFloatValue(EBGUAttrFloat.PoisonDefBase, data.GetFloatValue(EBGUAttrFloat.PoisonDef) * (float)playerTransAttrDesc.PoisonDefMul * num + (float)playerTransAttrDesc.PoisonDefBase);
				data.SetFloatValue(EBGUAttrFloat.ThunderDefBase, data.GetFloatValue(EBGUAttrFloat.ThunderDef) * (float)playerTransAttrDesc.ThunderDefMul * num + (float)playerTransAttrDesc.ThunderDefBase);
				data.SetFloatValue(EBGUAttrFloat.BlindSlotMax, data.GetFloatValue(EBGUAttrFloat.BlindSlotMax) * (float)playerTransAttrDesc.BlindSlotMul * num);
				data.SetFloatValue(EBGUAttrFloat.EarPlugBase, data.GetFloatValue(EBGUAttrFloat.EarPlug) * (float)playerTransAttrDesc.EarPlugMul * num);
				data.SetFloatValue(EBGUAttrFloat.TenacityBase, data.GetFloatValue(EBGUAttrFloat.Tenacity) * (float)playerTransAttrDesc.TenacityMul * num + (float)playerTransAttrDesc.TenacityBase);
				data.SetFloatValue(EBGUAttrFloat.SpecialEnergyMax, playerTransAttrDesc.SpecialEnergyBase);
				data.SetFloatValue(EBGUAttrFloat.HpMaxMul, 0f);
				data.SetFloatValue(EBGUAttrFloat.AtkMul, 0f);
				data.SetFloatValue(EBGUAttrFloat.DefMul, 0f);
				data.SetFloatValue(EBGUAttrFloat.Hp, data.GetFloatValue(EBGUAttrFloat.HpMax));
				data.SetFloatValue(EBGUAttrFloat.BlindSlot, data.GetFloatValue(EBGUAttrFloat.BlindSlotMax));
			}
		}
	}

	public void PostTrans(AActor OldActor)
	{
		APawn aPawn = Owner as APawn;
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		FUStPlayerTransAttrDesc playerTransAttrDesc = BGW_GameDB.GetPlayerTransAttrDesc(bGUCharacterCS.GetResID());
		BUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(OldActor);
		BUC_AttrContainer readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(aPawn);
		if (playerTransAttrDesc != null)
		{
			BGU_DataUtil.GetReadOnlyData<IBPC_TransData, BPC_TransData>(aPawn.PlayerState);
			float num = 0f;
			if (playerTransAttrDesc.PELevelInheritedType == EPELevelInheritedType.MulInherited)
			{
				num = readOnlyData2.GetFloatValue(EBGUAttrFloat.PevalueMax) * (float)playerTransAttrDesc.PELevelMul * 0.0001f * readOnlyData.GetFloatValue(EBGUAttrFloat.Pevalue) / readOnlyData.GetFloatValue(EBGUAttrFloat.PevalueMax);
			}
			if (playerTransAttrDesc.PELevelInheritedType == EPELevelInheritedType.BaseInherited)
			{
				num = (float)playerTransAttrDesc.PELevelMul * 0.0001f * readOnlyData.GetFloatValue(EBGUAttrFloat.Pevalue);
			}
			BUS_EventCollectionCS.Get(aPawn).Evt_IncreasePEValue.Invoke(readOnlyData2.GetFloatValue(EBGUAttrFloat.Pevalue) + num, EPotentialEnergyIncreaseReason.Normal);
			if (playerTransAttrDesc.InheritCurHp == EGSYesNo.Yes)
			{
				foreach (PlayerPersistentAttr item in BGU_DataUtil.GetReadOnlyData<IBPC_PlayerAttrData, BPC_PlayerAttrData>((Owner as APawn).PlayerState).PlayerPersistentAttr)
				{
					if (item.AttrId == 151)
					{
						readOnlyData2.SetFloatValue((EBGUAttrFloat)item.AttrId, item.AttrValue * readOnlyData2.GetFloatValue((EBGUAttrFloat)item.AttrMaxId));
					}
				}
			}
		}
		BGUCharacterCS bGUCharacterCS2 = aPawn as BGUCharacterCS;
		if (bGUCharacterCS2 != null)
		{
			if (IsSpecialTrans(bGUCharacterCS2.GetResID()))
			{
				readOnlyData2.SetFloatValue(EBGUAttrFloat.CurEnergy, readOnlyData2.GetFloatValue(EBGUAttrFloat.TransEnergyMax));
			}
			else
			{
				readOnlyData2.SetFloatValue(EBGUAttrFloat.CurEnergy, readOnlyData.GetFloatValue(EBGUAttrFloat.CurEnergy));
			}
		}
	}
}
