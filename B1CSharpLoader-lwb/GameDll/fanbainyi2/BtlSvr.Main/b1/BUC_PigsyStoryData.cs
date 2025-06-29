using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_PigsyStoryData : b1.IBUC_PigsyStoryData, IPersistentECSData
{
	public string OwnerGUID;

	public FVector LastPlayerPos;

	public bool PlayerNeedMove;

	public FVector LastPlayerPos_PlayerNeedMove;

	public bool CheckStoryInCollingOffPeriod()
	{
		if (PlayerNeedMove)
		{
			return true;
		}
		return false;
	}
}
