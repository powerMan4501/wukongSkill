namespace b1;

public abstract class FSMState_GI_LoadingBase : FSMStateBase
{
	protected FSMContext_GI_Loading Context;

	public FSMRuntimeInstance_GI_Loading OwningInstance { get; protected set; }

	public virtual void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		OwningInstance = RuntimeInstance;
		Context = RuntimeInstance.Context;
	}
}
