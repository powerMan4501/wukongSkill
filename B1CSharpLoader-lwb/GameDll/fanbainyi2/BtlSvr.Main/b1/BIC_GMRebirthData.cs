using UnrealEngine.Runtime;

namespace b1;

public class BIC_GMRebirthData : IBIC_GMRebirthData
{
	public FVector GMRebirthPos { get; set; }

	public FRotator GMRebirthRot { get; set; }

	public bool UseGMRebirthTeleport { get; set; }

	public int GMRebirthLevelID { get; set; }

	public void Reset()
	{
		UseGMRebirthTeleport = false;
		GMRebirthLevelID = 0;
	}
}
