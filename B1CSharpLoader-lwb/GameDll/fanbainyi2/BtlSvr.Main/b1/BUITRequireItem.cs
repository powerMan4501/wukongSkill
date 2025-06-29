namespace b1;

internal class BUITRequireItem : BUInteractTypeTemplate
{
	public BUITRequireItem()
	{
		PreCheckBehaviorArr = new EPreCheckBehavior[2]
		{
			EPreCheckBehavior.HasRequireItem,
			EPreCheckBehavior.NotInTransforming
		};
	}
}
