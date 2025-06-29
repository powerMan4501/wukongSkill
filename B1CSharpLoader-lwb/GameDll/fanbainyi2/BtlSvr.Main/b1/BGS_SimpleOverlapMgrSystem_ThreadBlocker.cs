namespace b1;

public class BGS_SimpleOverlapMgrSystem_ThreadBlocker : GameStateSystemBase
{
	private BGC_SimpleOverlapMgrData BGSimpleOverlapMgrData { get; set; }

	public override void OnAttach()
	{
		BGSimpleOverlapMgrData = RequireWritableData<BGC_SimpleOverlapMgrData>();
	}

	public override int GetTickGroupMask()
	{
		return 64;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (BGS_SimpleOverlapMgrSystem.UseThread && BGS_SimpleOverlapMgrSystem.BlockAndWait)
		{
			BGSimpleOverlapMgrData.ThreadEvent.WaitOne(1);
		}
	}
}
