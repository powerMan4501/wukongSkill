using System.Collections.Generic;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_UnitBarInfoData
{
	GSBindProp<bool> BossBarAcived { get; }

	GSBindProp<bool> EliteBarActived { get; }

	bool BloodBarActived { get; }

	float BloodBarPercent { get; }

	bool ShieldBarActived { get; }

	bool BossShieldBarActived { get; }

	float ShieldBarPercent { get; }

	List<string> ObserveBoss { get; }

	List<int> BuffIconList { get; }

	bool IsLocked { get; }

	float GetIconDuration(int IconID);

	int GetIconNum(int IconID);
}
