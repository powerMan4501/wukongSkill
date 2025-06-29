namespace b1.UI.Comm;

public struct DamageNumShowParam
{
	public DamageTypeEnum DamageType;

	public int DamageNum;

	public DamageNumShowParam(DamageTypeEnum InDamageType, int InDamageNum)
	{
		if (InDamageNum != 0)
		{
			DamageType = InDamageType;
			DamageNum = InDamageNum;
		}
		else
		{
			DamageType = DamageTypeEnum.NONE;
			DamageNum = 0;
		}
	}
}
