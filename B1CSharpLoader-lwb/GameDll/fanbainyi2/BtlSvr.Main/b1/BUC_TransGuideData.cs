using System.Collections.Generic;
using b1.ECS;
using ResB1;

namespace b1;

public class BUC_TransGuideData : IBUC_TransGuideData, IPersistentECSData
{
	public bool IsPEFull;

	public bool HavePe;

	public bool HaveDetonate;

	public int ResId { get; set; }

	public Dictionary<int, TransInputUITipsDesc> TransGuideDict { get; set; }

	public List<TransInputUITipsDesc> CheckTransInputUITipsDescList { get; set; }

	public GSBindProp<bool> CanShowUI { get; set; } = new GSBindProp<bool>();

	public int GetResId()
	{
		return ResId;
	}
}
