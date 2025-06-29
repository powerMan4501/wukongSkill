namespace b1;

public abstract class FSMState_GI_Global_SubG_GI_Global_Base : FSMState_GI_GlobalBase
{
	protected FSMContext_GI_Global SubGraphContext;

	protected string SubGraphResPath;

	public FSMRuntimeInstance_GI_Global SubGraphRuntimeInstance { get; protected set; }

	private void StartSubGraphWithContext()
	{
		SubGraphRuntimeInstance = BGW_EventCollection.Get(base.OwningInstance.OwnerUObj).Evt_BGW_CFSMGStart(SubGraphResPath, SubGraphContext, base.OwningInstance.OwnerUObj, base.OwningInstance, OnSubGraphFinish, OnSubGraphException, GenSubGraphFirstNodeInputParam(), IsStart: false) as FSMRuntimeInstance_GI_Global;
		SubGraphRuntimeInstance.Start(GenSubGraphFirstNodeInputParam(), SubGraphContext);
	}

	public virtual object GenSubGraphFirstNodeInputParam()
	{
		return null;
	}

	public sealed override void OnEnter()
	{
		SubGraphContext = GenSubGraphContext();
		OnSubGraphEnter();
		StartSubGraphWithContext();
	}

	public sealed override int OnTick(float Delta)
	{
		return 0;
	}

	public sealed override void OnExit()
	{
	}

	protected void AbortSubInstance()
	{
		BGW_EventCollection.Get(base.OwningInstance.OwnerUObj).Evt_BGW_AbortFSMInstance(SubGraphRuntimeInstance);
	}

	public abstract void OnSubGraphEnter();

	public abstract void OnSubGraphFinish();

	public abstract void OnSubGraphException(FSMException FSMException);

	protected abstract FSMContext_GI_Global GenSubGraphContext();
}
