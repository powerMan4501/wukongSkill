namespace b1;

internal class BUITStandardObj : BUInteractTypeTemplate
{
	public BUITStandardObj()
	{
		PreCheckBehaviorArr = new EPreCheckBehavior[2]
		{
			EPreCheckBehavior.NotInTransforming,
			EPreCheckBehavior.NotInBattle
		};
	}
}
