using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Mesh_Visibility : BGU_PropMgrType_Mesh
{
	public BGU_PropMgrType_Mesh_Visibility(USkeletalMeshComponent InMeshComp)
		: base(InMeshComp)
	{
		base.PropType = EPropType.Mesh_Visibility;
		base.CalcRule = EPropCalcRule.And;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_BoolPropRequest bGU_BoolPropRequest && base.MeshComp.IsVisible() != bGU_BoolPropRequest.Value)
		{
			base.MeshComp.SetVisibility(bGU_BoolPropRequest.Value);
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetBoolProperty.Invoke(base.PropType, base.MeshComp.IsVisible(), 0u, 0u, bSetDefaultProperty: true);
	}
}
