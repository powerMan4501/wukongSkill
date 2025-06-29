using System.Collections.Generic;
using b1.ECS;
using BtlB1;

namespace b1;

public class BUC_EquipData : IBUC_EquipData, IPersistentECSData
{
	public Dictionary<EquipPosition, int> MapEquip { get; set; }

	public Dictionary<EquipPosition, string> EquipIllusionList { get; set; }

	public Dictionary<EquipPosition, int> SelfEquipMap { get; set; }

	public Dictionary<EquipPosition, string> MapEquipAttachSocket { get; set; }

	public Dictionary<EquipPosition, string> MapEquipAttachMontage { get; set; }

	public Dictionary<EquipPosition, int> MapDefaultEquip { get; set; }

	public bool bHidenHeadEquip { get; set; }

	public bool bHidenHeadEquipInPhotoMode { get; set; } = true;

	public bool bInPhotoMode { get; set; }

	public int CurShowHeadEquipID { get; set; }

	public bool CanShowHeadEquip()
	{
		if (!bInPhotoMode)
		{
			return !bHidenHeadEquip;
		}
		return !bHidenHeadEquipInPhotoMode;
	}

	public BUC_EquipData()
	{
		MapEquip = new Dictionary<EquipPosition, int>();
		SelfEquipMap = new Dictionary<EquipPosition, int>();
		MapEquipAttachSocket = new Dictionary<EquipPosition, string>();
		MapEquipAttachMontage = new Dictionary<EquipPosition, string>();
		MapDefaultEquip = new Dictionary<EquipPosition, int>();
		EquipIllusionList = new Dictionary<EquipPosition, string>();
	}
}
