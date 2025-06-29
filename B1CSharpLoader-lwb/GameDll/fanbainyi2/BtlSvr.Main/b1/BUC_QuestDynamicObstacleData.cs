using b1.ECS;
using b1.EventDelDefine;

namespace b1;

public class BUC_QuestDynamicObstacleData : IPersistentECSData, b1.IBUC_QuestDynamicObstacleData
{
	public Del_Void Evt_EnableDynamicObstacle = delegate
	{
	};

	public Del_Void Evt_DisableDynamicObstacle = delegate
	{
	};

	public bool bAutoEnable { get; set; }

	public bool bEnable { get; set; }

	public bool bEnableDebug { get; set; }

	public int PerformID { get; set; }
}
