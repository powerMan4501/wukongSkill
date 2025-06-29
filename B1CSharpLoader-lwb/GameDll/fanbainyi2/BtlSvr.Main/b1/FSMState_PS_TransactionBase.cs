namespace b1;

public abstract class FSMState_PS_TransactionBase : FSMStateBase
{
	protected FSMContext_PS_Transaction Context;

	public FSMRuntimeInstance_PS_Transaction OwningInstance { get; protected set; }

	public virtual void Init(FSMRuntimeInstance_PS_Transaction RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		OwningInstance = RuntimeInstance;
		Context = RuntimeInstance.Context;
	}
}
