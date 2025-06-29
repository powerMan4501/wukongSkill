using System.Collections.Generic;

namespace b1;

public class BIC_TeleportStateData
{
	public int TargetRebirthPointID;

	public FTeleportInfo targetPoint;

	public int BlockingRequestLevelNum;

	public int GlobalRequestID;

	public ETeleportReason TeleportReason;

	public ETeleportType TeleportType;

	public Dictionary<int, StreamingLevelRequest> Requests = new Dictionary<int, StreamingLevelRequest>();

	public List<string> UnloadLevelNames = new List<string>();

	public bool bRebirthTeleportWaitOpenLevelFinish { get; set; }

	public void Reset()
	{
		GlobalRequestID = 0;
		Requests = new Dictionary<int, StreamingLevelRequest>();
		UnloadLevelNames = new List<string>();
	}
}
