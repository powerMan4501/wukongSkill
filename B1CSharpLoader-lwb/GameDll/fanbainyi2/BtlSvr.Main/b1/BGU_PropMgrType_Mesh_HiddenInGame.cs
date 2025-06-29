using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Mesh_HiddenInGame : BGU_PropMgrType_Mesh
{
	public BGU_PropMgrType_Mesh_HiddenInGame(USkeletalMeshComponent InMeshComp)
		: base(InMeshComp)
	{
		base.PropType = EPropType.Mesh_HiddenInGame;
		base.CalcRule = EPropCalcRule.Stack;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_BoolPropRequest bGU_BoolPropRequest && base.MeshComp.HiddenInGame != bGU_BoolPropRequest.Value)
		{
			base.MeshComp.SetHiddenInGame(bGU_BoolPropRequest.Value);
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		EvtCollection.Evt_SetBoolProperty.Invoke(base.PropType, base.MeshComp.HiddenInGame, 0u, 0u, bSetDefaultProperty: true);
	}
}
