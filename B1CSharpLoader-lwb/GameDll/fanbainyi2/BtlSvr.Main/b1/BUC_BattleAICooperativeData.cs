using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BUC_BattleAICooperativeData : IBUC_BattleAICooperativeData, IPersistentECSData
{
	public List<EBattleCoopReason> SpecificEventListen;

	public string BattleSC_GUID { get; set; }

	public BUC_BattleAICooperativeData()
	{
		SpecificEventListen = new List<EBattleCoopReason>();
	}
}
