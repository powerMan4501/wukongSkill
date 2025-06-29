using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Mesh_PauseAnims : BGU_PropMgrType_Mesh
{
	public BGU_PropMgrType_Mesh_PauseAnims(USkeletalMeshComponent InMeshComp)
		: base(InMeshComp)
	{
		base.PropType = EPropType.Mesh_PauseAnims;
		base.CalcRule = EPropCalcRule.Stack;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_BoolPropRequest bGU_BoolPropRequest)
		{
			base.MeshComp.PauseAnims = bGU_BoolPropRequest.Value;
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetBoolProperty.Invoke(base.PropType, base.MeshComp.PauseAnims, 0u, 0u, bSetDefaultProperty: true);
	}
}
