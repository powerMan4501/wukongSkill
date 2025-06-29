using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class FSceneInactiveObjectInfo
{
	public int ForceActivateTicks;

	public AActor Actor { get; private set; }

	public List<FSceneActorActivationInfo> ActivationInfos { get; private set; }

	public FSceneInactiveObjectInfo(AActor Actor, List<FSceneActorActivationInfo> ActivationInfos)
	{
		this.Actor = Actor;
		this.ActivationInfos = ActivationInfos;
		ForceActivateTicks = -1;
	}
}
