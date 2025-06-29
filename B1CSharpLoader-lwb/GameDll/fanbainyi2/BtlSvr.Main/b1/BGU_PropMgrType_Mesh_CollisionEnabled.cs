using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Mesh_CollisionEnabled : BGU_PropMgrType_Mesh
{
	public BGU_PropMgrType_Mesh_CollisionEnabled(USkeletalMeshComponent InMeshComp)
		: base(InMeshComp)
	{
		base.PropType = EPropType.Mesh_CollisionEnabled;
		base.CalcRule = EPropCalcRule.Stack;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_EnumPropRequest bGU_EnumPropRequest && (int)base.MeshComp.GetCollisionEnabled() != bGU_EnumPropRequest.Value)
		{
			base.MeshComp.SetCollisionEnabled((ECollisionEnabled)bGU_EnumPropRequest.Value);
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetEnumProperty.Invoke(base.PropType, (int)base.MeshComp.GetCollisionEnabled(), 0u, 0u, bSetDefaultProperty: true);
	}
}
