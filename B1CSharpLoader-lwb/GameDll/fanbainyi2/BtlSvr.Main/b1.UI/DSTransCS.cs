using BtlShare;

namespace b1.UI;

public class DSTransCS : UIBindData
{
	public readonly DSHpProgBar HpProgBar;

	public readonly DSAttrProgBar EnergyProg;

	public int TransResId;

	public DSTransCS(BUI_Widget InBindWidget, bool InUseAbnormalFx = false, bool InIsZeroHide = false)
		: base(InBindWidget)
	{
		HpProgBar = new DSHpProgBar(InBindWidget, InUseAbnormalFx, InIsZeroHide);
		HpProgBar.Init(B1ActorTag.CurPlayerActor);
		EnergyProg = new DSAttrProgBar(InBindWidget, EBGUAttrFloat.CurEnergy, EBGUAttrFloat.TransEnergyMax);
		EnergyProg.Init(B1ActorTag.CurPlayerActor);
		TransResId = 0;
	}
}
