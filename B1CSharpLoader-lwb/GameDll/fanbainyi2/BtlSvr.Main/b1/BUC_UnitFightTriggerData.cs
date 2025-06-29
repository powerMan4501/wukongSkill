namespace b1;

public class BUC_UnitFightTriggerData : b1.IBUC_UnitFightTriggerData
{
	public bool bCanUnitEnterFight { get; set; }

	public BUC_UnitFightTriggerData()
	{
		bCanUnitEnterFight = true;
	}
}
