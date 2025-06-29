using BtlShare;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_MagicSpellInfoData
{
	bool GetMagicSpellInfo(int SpellID, out bool IsLock, out bool IsDisable, out float CDTimePercent);

	bool GetAllMagicSpellInfo(int SpellID, out bool IsLock, out bool IsDisable, out float CDTimePercent);

	bool GetAllMagicSpellCost(int SpellID, out EAttrCostType AttrCostType1, out float CostValue1, out EAttrCostType AttrCostType2, out float CostValue2);
}
