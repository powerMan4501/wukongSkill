using b1.BGU.BUAnim;
using UnrealEngine.Engine;

namespace b1;

public class BGU_PropMgrType_Mesh_EnableFootIK : BGU_PropMgrType_Mesh
{
	public BGU_PropMgrType_Mesh_EnableFootIK(USkeletalMeshComponent InMeshComp)
		: base(InMeshComp)
	{
		base.PropType = EPropType.Mesh_EnableFootIK;
		base.CalcRule = EPropCalcRule.And;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (Request is BGU_BoolBoolPropRequest bGU_BoolBoolPropRequest)
		{
			EvtCollection.Evt_SetEnableIK.Invoke(bGU_BoolBoolPropRequest.Value1, bGU_BoolBoolPropRequest.Value2);
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
		bool value = false;
		bool value2 = false;
		if (base.MeshComp.GetAnimInstance() is BUAnimInstanceBase { ABPSettingData: not null } bUAnimInstanceBase)
		{
			bool bEnableQuadrupedIK = bUAnimInstanceBase.ABPSettingData.FootIKSetting.bEnableQuadrupedIK;
			value = bUAnimInstanceBase.ABPSettingData.FootIKSetting.bEnableIK || bEnableQuadrupedIK;
			value2 = bUAnimInstanceBase.ABPSettingData.FootIKSetting.bEnableForefootIK || bEnableQuadrupedIK;
		}
		EvtCollection.Evt_SetBoolBoolProperty.Invoke(base.PropType, value, value2, 0u, 0u, bSetDefaultProperty: true);
	}
}
