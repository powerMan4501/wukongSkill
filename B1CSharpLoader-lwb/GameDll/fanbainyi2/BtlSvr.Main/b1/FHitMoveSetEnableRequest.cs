using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class FHitMoveSetEnableRequest
{
	public ulong RequestID;

	public List<UShapeComponent> TargetCollisions = new List<UShapeComponent>();

	public List<bool> RoolbackCollisionEnabled = new List<bool>();

	public FHitMoveSetEnableRequest()
	{
	}

	public FHitMoveSetEnableRequest(ulong requestID, List<UShapeComponent> targetCollisions, List<bool> roolbackCollisionEnabled)
	{
		RequestID = requestID;
		TargetCollisions = targetCollisions;
		RoolbackCollisionEnabled = roolbackCollisionEnabled;
	}
}
