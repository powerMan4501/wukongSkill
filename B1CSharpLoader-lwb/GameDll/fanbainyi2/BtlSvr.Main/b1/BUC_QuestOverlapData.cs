using b1.ECS;
using b1.EventDelDefine;

namespace b1;

public class BUC_QuestOverlapData : IPersistentECSData
{
	public bool bAutoEnableOverlap { get; set; }

	public bool bOverlapEnabled { get; set; }

	public bool bFirstTick { get; set; }

	public Del_CollisionBeginOverlap BeginOverlapAction { get; set; }

	public Del_CollisionEndOverlap EndOverlapAction { get; set; }

	public int BirthPointID { get; set; }
}
