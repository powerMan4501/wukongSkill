using UnrealEngine.Engine;

namespace b1;

public class FCompActivationInfo
{
	public EGSSceneActorActivationType SceneActorActivationType;

	public float ActivateDistance;

	public UPrimitiveComponent ActivateComp;

	public bool bIsEnabled;

	public FCompActivationInfo(EGSSceneActorActivationType ActivationType, float Distance, UPrimitiveComponent Comp)
	{
		SceneActorActivationType = ActivationType;
		ActivateDistance = Distance;
		ActivateComp = Comp;
	}
}
