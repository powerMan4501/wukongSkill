using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BGC_AssociationUnitData : IBGC_AssociationUnitData, IPersistentECSData
{
	public Dictionary<int, AssoicationUnitInfo> AssociationUnitInfoDic { get; } = new Dictionary<int, AssoicationUnitInfo>();

	public bool GetAssociationUnitConfigIDByGUID(string UnitGUID, out int OutConfigID, out AssoicationUnitInfo OutAUI)
	{
		OutConfigID = -1;
		OutAUI = new AssoicationUnitInfo();
		bool result = false;
		foreach (KeyValuePair<int, AssoicationUnitInfo> item in AssociationUnitInfoDic)
		{
			int key = item.Key;
			AssoicationUnitInfo value = item.Value;
			if (value.AssociationUnitEntityGUID.Equals(UnitGUID))
			{
				result = true;
				OutConfigID = key;
				OutAUI = value;
				break;
			}
		}
		return result;
	}
}
