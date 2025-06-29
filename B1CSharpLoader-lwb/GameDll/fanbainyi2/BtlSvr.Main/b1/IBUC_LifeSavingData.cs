using GUR.Runtime;

namespace b1;

[NeedToUI]
internal interface IBUC_LifeSavingData
{
	int SpellID { get; }

	float DefaultCD { get; }

	float CoolDownRemainTimer { get; }

	bool CanUseLifeSavingHair(IBUC_UnitStateData UnitStateData, IBUC_SimpleStateData SimpleStateData);

	float GetCDTimePercent();
}
