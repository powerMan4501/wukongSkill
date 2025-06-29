namespace b1;

public abstract class FSMConditionBase
{
	public abstract string GetResult();

	public virtual object GetNextNodeInputParam()
	{
		return null;
	}
}
