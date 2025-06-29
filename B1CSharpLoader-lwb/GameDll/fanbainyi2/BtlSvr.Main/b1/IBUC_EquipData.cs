using System.Collections.Generic;
using BtlB1;

namespace b1;

public interface IBUC_EquipData
{
	Dictionary<EquipPosition, int> MapEquip { get; }

	Dictionary<EquipPosition, int> SelfEquipMap { get; }

	Dictionary<EquipPosition, string> EquipIllusionList { get; }

	bool bHidenHeadEquip { get; }

	bool bInPhotoMode { get; }

	bool CanShowHeadEquip();
}
