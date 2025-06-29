using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BUC_PropMgrData : IBUC_PropMgrData, IPersistentECSData
{
	public Dictionary<uint, Dictionary<EPropType, uint>> MapNotifyHandleID = new Dictionary<uint, Dictionary<EPropType, uint>>();

	public uint HandleID { get; set; }

	public Dictionary<uint, uint> MapHandleIDChild2Main { get; set; } = new Dictionary<uint, uint>();

	public Dictionary<EPropType, BGU_PropMgrTypeBase> MapPropType { get; set; } = new Dictionary<EPropType, BGU_PropMgrTypeBase>();

	public Dictionary<EPropCalcRule, BUPropCalcTemplate> MapPropCalcTemplate { get; set; } = new Dictionary<EPropCalcRule, BUPropCalcTemplate>();

	public Dictionary<uint, EPropType> MapHandleID2PropType { get; set; } = new Dictionary<uint, EPropType>();

	public Dictionary<EPropType, List<uint>> MapPropType2HandleID { get; set; } = new Dictionary<EPropType, List<uint>>();

	public Dictionary<uint, BGU_PropMgrRequestBase> MapPropRequest { get; set; } = new Dictionary<uint, BGU_PropMgrRequestBase>();

	public uint GetLastHandleID()
	{
		if (MapHandleIDChild2Main.TryGetValue(HandleID, out var value))
		{
			return value;
		}
		return HandleID;
	}

	public uint GenHandleID()
	{
		return ++HandleID;
	}
}
