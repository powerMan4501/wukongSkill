using b1.EventDelDefine;

namespace b1;

internal class BUS_SpecialBoneMgrComp : UActorCompBaseCS
{
	private BUC_SpecialBoneListData SpecialBoneListData;

	public override void OnAttach()
	{
		SpecialBoneListData = RequireWritableData<BUC_SpecialBoneListData>();
		base.BUSEventCollection.Evt_SetSpecialBoneList += new Del_SetSpecialBoneList(SetSpecialBoneList);
		base.BUSEventCollection.Evt_ResetSpecialBoneList += new Del_Void(ResetSpecialBoneList);
	}

	private void SetSpecialBoneList(BGWDataAsset_SpecialBoneConfig InSpecialBoneConfig)
	{
		SpecialBoneListData.SetSpecialBoneConfig(InSpecialBoneConfig);
	}

	private void ResetSpecialBoneList()
	{
		SpecialBoneListData.SetSpecialBoneConfig(SpecialBoneListData.DefaultSpecialBoneConfig);
	}
}
