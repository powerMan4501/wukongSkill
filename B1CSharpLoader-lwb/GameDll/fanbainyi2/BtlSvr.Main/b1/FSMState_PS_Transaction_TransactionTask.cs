using Google.Protobuf;
using GUR.Runtime;
using GurCalliopeFsm;

namespace b1;

public class FSMState_PS_Transaction_TransactionTask : FSMState_PS_TransactionBase
{
	[EditableFSMParam(ParamType = FSMParamType.Enum, DisplayName = "事务子任务类型")]
	private ETransactionTaskType TransactionTaskType { get; set; }

	public override void Init(FSMRuntimeInstance_PS_Transaction RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		PS_Transaction_TransactionTask pS_Transaction_TransactionTask = new PS_Transaction_TransactionTask();
		pS_Transaction_TransactionTask.MergeFrom(Node.NodeData);
		TransactionTaskType = (ETransactionTaskType)pS_Transaction_TransactionTask.TransactionTaskType;
	}

	public override void OnEnter()
	{
		Context.PlayerTransaction.EnterNewActiveTask(TransactionTaskType);
		Context.PlayerTransaction.ActiveTask.OnTaskStateChg += OnTaskStateChg;
	}

	protected void OnTaskStateChg(ETransactionTaskState OldState, ETransactionTaskState NewState)
	{
		switch (NewState)
		{
		case ETransactionTaskState.Finished:
			base.OwningInstance.TriggerEvent(EPS_Transaction.TaskFinish);
			break;
		case ETransactionTaskState.Aborted:
			base.OwningInstance.TriggerEvent(EPS_Transaction.TaskAbort);
			break;
		}
	}

	public override int OnTick(float Delta)
	{
		return 100;
	}

	public override void OnExit()
	{
		Context.PlayerTransaction.ActiveTask.OnTaskStateChg -= OnTaskStateChg;
	}
}
