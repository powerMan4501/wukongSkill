using b1.BGW;
using BtlB1;
using UnrealEngine.Engine;

namespace b1;

internal class BUIAEnterSplineMove : BUInteractActionTemplate
{
	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		if (Action.ParamsString.Count != 1)
		{
			return false;
		}
		BGWDataAsset_ManualSplineMoveAnimConfig bGWDataAsset_ManualSplineMoveAnimConfig = BGW_PreloadAssetMgr.Get(User).TryGetCachedResourceObj<BGWDataAsset_ManualSplineMoveAnimConfig>(Action.ParamsString[0], ELoadResourceType.SyncLoadAndCache);
		USplineComponent componentByClass = InteractiveActor.GetComponentByClass<USplineComponent>();
		if (componentByClass != null && bGWDataAsset_ManualSplineMoveAnimConfig != null)
		{
			BUS_EventCollectionCS.Get(User).Evt_BeginManualSplineMoveWithSpecialAnimation.Invoke(componentByClass, bGWDataAsset_ManualSplineMoveAnimConfig);
		}
		return true;
	}
}
