namespace b1;

public class FSMStateBase
{
	public virtual void OnEnter()
	{
	}

	public virtual int OnTick(float Delta)
	{
		return 0;
	}

	public virtual void OnExit()
	{
	}

	public virtual void OnAbort()
	{
	}
}
