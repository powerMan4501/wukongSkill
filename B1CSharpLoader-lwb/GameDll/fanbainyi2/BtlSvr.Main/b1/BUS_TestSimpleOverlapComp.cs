using UnrealEngine.Runtime;

namespace b1;

public class BUS_TestSimpleOverlapComp : UActorCompBaseCS
{
	private b1.IBGC_SimpleOverlapMgrData BGSimpleOverlapMgrData;

	public override void OnAttach()
	{
		BGSimpleOverlapMgrData = RequireReadOnlyGameStateData<b1.IBGC_SimpleOverlapMgrData, BGC_SimpleOverlapMgrData>();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		BGSimpleOverlapMgrData.GetSimpleOverlapActorsByMask(Owner, BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerAsCharacterCS), 1, 10000f, 0f, 0f, default(FVector2D), IsSphere: true, out var _);
	}
}
