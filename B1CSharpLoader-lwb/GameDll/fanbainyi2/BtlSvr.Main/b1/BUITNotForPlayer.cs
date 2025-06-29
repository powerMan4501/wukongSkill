namespace b1;

internal class BUITNotForPlayer : BUInteractTypeTemplate
{
	public BUITNotForPlayer()
	{
		PreCheckBehaviorArr = new EPreCheckBehavior[1] { EPreCheckBehavior.FocusOn };
	}
}
