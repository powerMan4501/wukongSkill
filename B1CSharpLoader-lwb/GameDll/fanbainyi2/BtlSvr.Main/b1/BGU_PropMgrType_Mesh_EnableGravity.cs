using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Mesh_EnableGravity : BGU_PropMgrType_Mesh
{
	public BGU_PropMgrType_Mesh_EnableGravity(USkeletalMeshComponent InMeshComp)
		: base(InMeshComp)
	{
		base.PropType = EPropType.Mesh_EnableGravity;
		base.CalcRule = EPropCalcRule.Stack;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_BoolPropRequest bGU_BoolPropRequest && base.MeshComp.IsGravityEnabled() != bGU_BoolPropRequest.Value)
		{
			base.MeshComp.SetEnableGravity(bGU_BoolPropRequest.Value);
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetBoolProperty.Invoke(base.PropType, base.MeshComp.IsGravityEnabled(), 0u, 0u, bSetDefaultProperty: true);
	}
}
