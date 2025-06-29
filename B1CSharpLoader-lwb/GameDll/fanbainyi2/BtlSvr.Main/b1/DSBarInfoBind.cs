using b1.UI;

namespace b1;

public struct DSBarInfoBind
{
	public DS_IBUC_UnitBarInfoData UnitBarInfoData;

	public int BloodBarActivedBindIdx;

	public int BindBloodBarPercentIdx;

	public int ShieldActivedBindIdx;

	public int BindShieldBarPercentIdx;

	public UnitTopBarOneBind UnitTopBarOneBind;

	public void ReInit()
	{
		if (UnitTopBarOneBind != null && UnitBarInfoData != null)
		{
			UnitTopBarOneBind.InitBloodPercent(UnitBarInfoData.BloodBarPercent);
			UnitTopBarOneBind.InitShieldPercent(UnitBarInfoData.ShieldBarPercent);
		}
	}
}
