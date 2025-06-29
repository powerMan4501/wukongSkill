namespace b1;

public class FSMState_GI_Loading_ReleaseSaveArchiveByTravelLevel : FSMState_GI_LoadingBase
{
	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		foreach (int lockArchiveHandle in Context.TravelLevelTemplate.LockArchiveHandleList)
		{
			BGW_GameArchiveMgr.Get(Context.GameInst).ReleaseSaveLock(lockArchiveHandle);
		}
		base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
	}

	public override int OnTick(float Delta)
	{
		return 100;
	}

	public override void OnExit()
	{
	}
}
