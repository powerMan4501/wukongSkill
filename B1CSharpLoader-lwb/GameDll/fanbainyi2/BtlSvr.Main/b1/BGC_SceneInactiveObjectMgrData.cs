using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_SceneInactiveObjectMgrData : IBGC_SceneInactiveObjectMgrData, IPersistentECSData
{
	public List<FSceneInactiveObjectInfo> SceneInactiveObjectInfos = new List<FSceneInactiveObjectInfo>();

	public int Index;

	public bool CheckIsBGUActorActive(AActor InActor, EGSSceneActorActivationType ActivationType, out bool IsActive)
	{
		IsActive = false;
		int num = SceneInactiveObjectInfos.FindIndex((FSceneInactiveObjectInfo r) => r.Actor == InActor);
		if (num < 0)
		{
			return false;
		}
		foreach (FSceneActorActivationInfo activationInfo in SceneInactiveObjectInfos[num].ActivationInfos)
		{
			if (activationInfo.SceneActorActivationType == ActivationType)
			{
				APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(InActor)?.GetControlledPawn();
				if (aPawn != null)
				{
					FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aPawn);
					IsActive = (fVector - BGUFuncLibActorTransformCS.BGUGetActorLocation(InActor)).Size() < activationInfo.ActivateDistance;
				}
				return true;
			}
		}
		return false;
	}
}
