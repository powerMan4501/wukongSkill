using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Mesh_CollisionObjectType : BGU_PropMgrType_Mesh
{
	public BGU_PropMgrType_Mesh_CollisionObjectType(USkeletalMeshComponent InMeshComp)
		: base(InMeshComp)
	{
		base.PropType = EPropType.Mesh_CollisionObjectType;
		base.CalcRule = EPropCalcRule.Stack;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_EnumPropRequest bGU_EnumPropRequest && (int)base.MeshComp.GetCollisionObjectType() != bGU_EnumPropRequest.Value)
		{
			base.MeshComp.SetCollisionObjectType((ECollisionChannel)bGU_EnumPropRequest.Value);
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetEnumProperty.Invoke(base.PropType, (int)base.MeshComp.GetCollisionObjectType(), 0u, 0u, bSetDefaultProperty: true);
	}
}
