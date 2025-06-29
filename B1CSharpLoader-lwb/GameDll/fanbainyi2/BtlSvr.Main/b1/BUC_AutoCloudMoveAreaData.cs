using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

internal class BUC_AutoCloudMoveAreaData : b1.IBUC_BGMAreaData
{
	public float AcceptRadius;

	public float MaxHeightDistance;

	public List<AActor> PlayerActors = new List<AActor>();

	public List<IBUC_CloudMoveData> PlayerCloudMoveDatas = new List<IBUC_CloudMoveData>();
}
