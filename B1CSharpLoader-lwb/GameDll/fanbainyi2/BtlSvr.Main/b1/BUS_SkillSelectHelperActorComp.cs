namespace b1;

public class BUS_SkillSelectHelperActorComp : UActorCompBaseCS
{
	private float LifeTime = 30f;

	private float Timer;

	public override void OnAttach()
	{
		Timer = 0f;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		Timer += DeltaTime;
		if (Timer != -1f && Timer > LifeTime)
		{
			BGU_UnrealWorldUtil.DestroyActor(GetOwner());
			Timer = -1f;
		}
	}
}
