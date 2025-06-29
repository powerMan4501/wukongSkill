using BtlShare;

namespace b1.UI;

public class DSPlayerBar : UIBindData
{
	public readonly DSHpProgBar HpProgBar;

	public readonly DSAttrProgBar MpProgBar;

	public readonly DSAttrProgBar StProgBar;

	public DSPlayerBar(BUI_Widget InBindWidget, bool InUseAbnormalFx = false, bool InIsZeroHide = false)
		: base(InBindWidget)
	{
		B1ActorTag inBindTag = B1ActorTag.CurPlayerActor;
		HpProgBar = new DSHpProgBar(InBindWidget, InUseAbnormalFx, InIsZeroHide);
		HpProgBar.Init(inBindTag);
		MpProgBar = new DSAttrProgBar(InBindWidget, EBGUAttrFloat.Mp, EBGUAttrFloat.MpMax);
		MpProgBar.Init(inBindTag);
		StProgBar = new DSAttrProgBar(InBindWidget, EBGUAttrFloat.Stamina, EBGUAttrFloat.StaminaMax);
		StProgBar.Init(inBindTag);
	}
}
