using UnrealEngine.Engine;

namespace b1;

public interface IBGC_SceneInactiveObjectMgrData
{
	bool CheckIsBGUActorActive(AActor InActor, EGSSceneActorActivationType ActivationType, out bool IsActive);
}
