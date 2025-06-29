using System.Collections.Generic;
using b1.ECS;

namespace b1.GameState.Data;

public class BGC_WeaponManagerData : b1.GameState.Data.IBGC_WeaponManagerData, IPersistentECSData
{
	public Dictionary<string, List<string>> WeaponInfoDict = new Dictionary<string, List<string>>();

	public bool GetWeaponMasterGUID(string WeaponGUID, out string WeaponMasterGUID)
	{
		WeaponMasterGUID = "";
		foreach (KeyValuePair<string, List<string>> item in WeaponInfoDict)
		{
			if (item.Value.Contains(WeaponGUID))
			{
				WeaponMasterGUID = item.Key;
				return true;
			}
		}
		return false;
	}
}
