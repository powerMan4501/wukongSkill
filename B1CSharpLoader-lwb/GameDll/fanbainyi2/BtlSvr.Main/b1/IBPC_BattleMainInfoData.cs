using System.Collections.Generic;
using BtlB1;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBPC_BattleMainInfoData
{
	GSBindList<UnitBarInfo> BossBarInfo { get; }

	GSBindList<UnitBarInfo> EliteBarInfo { get; }

	GSBindProp<bool> CanOpenEquipPage { get; }

	GSBindProp<bool> ForceCloseEquipPage { get; }

	GSBindProp<bool> CanOpenMapPage { get; }

	GSBindProp<bool> ForceCloseMapPage { get; }

	GSBindProp<bool> KillSlowDownState { get; }

	List<int> BuffIconList { get; }

	float PlayerDeathUIDelayTime { get; }

	float VigorSkillCDPercent { get; }

	GSBindProp<bool> State1 { get; }

	GSBindProp<bool> State2 { get; }

	GSBindProp<bool> State3 { get; }

	bool IsInBossBattle();

	bool GetCanOpenEquipPage();

	bool GetForceCloseEquipPage();

	bool GetCanOpenTakePhotoPage();

	bool GetCanOpenMapPage();

	float GetIconDuration(int IconID);

	int GetIconNum(int IconID);

	bool GetMagicSpellCost(int SpellID, out BGUSpellState SpellState);

	int GetExtendIDForDefeatedUI();

	EDefeatUITriggerType GetDefeatUITriggerType();

	bool GetMagicSpellInfo(int SpellID, out FUIMagicSpellInfo MagicSpellInfo);

	bool GetCloudMoveInfo(out FUICloudMoveInfo CloudMoveInfo);

	bool GetSoulSkillInfo(out FUISoulSkillInfo SoulInfo);

	bool GetFaBaoInfo(out FUIFaBaoInfo FaBaoInfo);

	bool GetUseItemInfo(out FUIUseItemInfo UseItemInfo);
}
