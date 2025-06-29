namespace b1;

public abstract class FSMState_GI_GlobalBase : FSMStateBase
{
	protected FSMContext_GI_Global Context;

	public FSMRuntimeInstance_GI_Global OwningInstance { get; protected set; }

	public virtual void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		OwningInstance = RuntimeInstance;
		Context = RuntimeInstance.Context;
	}
}
