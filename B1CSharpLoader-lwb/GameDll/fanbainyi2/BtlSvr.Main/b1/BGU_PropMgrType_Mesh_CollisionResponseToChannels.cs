using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Mesh_CollisionResponseToChannels : BGU_PropMgrType_Mesh
{
	public BGU_PropMgrType_Mesh_CollisionResponseToChannels(USkeletalMeshComponent InMeshComp)
		: base(InMeshComp)
	{
		base.PropType = EPropType.Mesh_CollisionResponseToChannels;
		base.CalcRule = EPropCalcRule.Merge;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_CollisionResponsePropRequest bGU_CollisionResponsePropRequest)
		{
			UBGUFunctionLibCollisionChannel.BGUSetCollisionResponseToChannels(base.MeshComp, bGU_CollisionResponsePropRequest.Value);
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		UBGUFunctionLibCollisionChannel.BGUGetCollisionResponseToChannels(base.MeshComp, out var OutResponseToChannels);
		EvtCollection.Evt_SetCollisionResponseProperty.Invoke(base.PropType, OutResponseToChannels, 0u, 0u, bSetDefaultProperty: true);
	}
}
