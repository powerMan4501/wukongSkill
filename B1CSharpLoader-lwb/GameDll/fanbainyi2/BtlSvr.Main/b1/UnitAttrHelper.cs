using BtlB1;
using BtlShare;
using ResB1;

namespace b1;

public static class UnitAttrHelper
{
	private const float RATIO = 10000f;

	public static void FillUnitCommDescAttrList(EffectAttrDict AttrDict, FUStUnitCommDesc UnitCommDesc, FUStUnitBattleInfoExtendDesc UnitBattleInfoExtendDesc)
	{
		float attrValue = 0f;
		if (UnitCommDesc != null)
		{
			AttrDict.AddAttrValue(EBGUAttrFloat.KptturnSpeedBase, UnitCommDesc.KPTTrunSpeed);
			AttrDict.AddAttrValue(EBGUAttrFloat.B1StunMaxBase, UnitCommDesc.Stun);
			AttrDict.AddAttrValue(EBGUAttrFloat.SkillSuperArmorMax, UnitCommDesc.MaxSkillSuperArmorValue);
			AttrDict.AddAttrValue(EBGUAttrFloat.BlindSlotMax, UnitCommDesc.MaxBlindSlotValue);
			AttrDict.AddAttrValue(EBGUAttrFloat.TenacityBase, UnitCommDesc.DefaultTenacity);
			AttrDict.AddAttrValue(EBGUAttrFloat.EarPlugBase, UnitCommDesc.DefaultEarPlug);
		}
		if (UnitBattleInfoExtendDesc != null)
		{
			AttrDict.AddAttrValue(EBGUAttrFloat.FreezeDefBase, UnitBattleInfoExtendDesc.DefaultFreezeDefValue);
			AttrDict.AddAttrValue(EBGUAttrFloat.BurnDefBase, UnitBattleInfoExtendDesc.DefaultBurnDefValue);
			AttrDict.AddAttrValue(EBGUAttrFloat.PoisonDefBase, UnitBattleInfoExtendDesc.DefaultPoisonDefValue);
			AttrDict.AddAttrValue(EBGUAttrFloat.ThunderDefBase, UnitBattleInfoExtendDesc.DefaultThunderDefValue);
			attrValue = UnitBattleInfoExtendDesc.MaxBlockCollapseArmorValue;
		}
		AttrDict.AddAttrValue(EBGUAttrFloat.BlockCollapseArmorMax, attrValue);
	}

	public static void FillUnitLevelUpDescAttrList(EffectAttrDict AttrDict, FUStUnitLevelUpDesc LevelUpDesc)
	{
		AttrDict.AddAttrValue(EBGUAttrFloat.AtkBase, LevelUpDesc.AtkBase);
		AttrDict.AddAttrValue(EBGUAttrFloat.DefBase, LevelUpDesc.DefBase);
		AttrDict.AddAttrValue(EBGUAttrFloat.CritRateBase, LevelUpDesc.CritRateBase);
		AttrDict.AddAttrValue(EBGUAttrFloat.CritMultiplierBase, LevelUpDesc.CritMultiplierBase);
		AttrDict.AddAttrValue(EBGUAttrFloat.HpMaxBase, LevelUpDesc.HpBase);
		AttrDict.AddAttrValue(EBGUAttrFloat.MpMaxBase, LevelUpDesc.MpBase);
		AttrDict.AddAttrValue(EBGUAttrFloat.CritRateDefBase, LevelUpDesc.CritRateDef);
		AttrDict.AddAttrValue(EBGUAttrFloat.CritDmgMulDefBase, LevelUpDesc.CritDmgMulDef);
		AttrDict.AddAttrValue(EBGUAttrFloat.DmgAdditionBase, LevelUpDesc.DmgAddition);
		AttrDict.AddAttrValue(EBGUAttrFloat.DmgDefBase, LevelUpDesc.DmgDef);
	}

	public static void FillPlayerCommDescAttrList(EffectAttrDict AttrDict, FUStPlayerCommDesc PlayerCommDesc)
	{
		AttrDict.AddAttrValue(EBGUAttrFloat.StaminaMaxBase, PlayerCommDesc.StaminaMaxBase);
		AttrDict.AddAttrValue(EBGUAttrFloat.StaminaRecoverBase, PlayerCommDesc.StaminaRecoverBase);
		AttrDict.AddAttrValue(EBGUAttrFloat.StaminaDepletedLimitBase, PlayerCommDesc.StaminaDepletedLimitBase);
		AttrDict.AddAttrValue(EBGUAttrFloat.BloodBottomNumMaxBase, PlayerCommDesc.BloodBottomNum);
		AttrDict.AddAttrValue(EBGUAttrFloat.ShieldMaxBase, PlayerCommDesc.MaxShield);
	}

	public static void FillNewGamePlusAttrList(EffectAttrDict AttrDict, NewGamePlusDesc newGamePlusDesc)
	{
		AttrDict.AddAttrValue(EBGUAttrFloat.HpMaxBase, newGamePlusDesc.HpMaxBase);
		AttrDict.AddAttrValue(EBGUAttrFloat.AtkMul, newGamePlusDesc.AtkMul);
		AttrDict.AddAttrValue(EBGUAttrFloat.DefMul, newGamePlusDesc.DefMul);
	}
}
