namespace BlackMythWukong_Game_Helper;

public class SystemBase
{
	public bool IsRun;

	public virtual void OnAttach()
	{
	}

	public virtual void OnBeginPlay()
	{
	}

	public virtual void OnTick(float DeltaTime, int TickGroup)
	{
	}

	public void SetRun(bool isRun)
	{
		IsRun = isRun;
	}

	public void Init(GameStateSystemMgr SystemMgr)
	{
	}
}
