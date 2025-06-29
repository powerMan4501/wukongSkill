using System.Collections.Generic;
using b1.Plugins.Calliope;

namespace b1;

public class FSMRuntimeInstance_PS_Transaction : FSMRuntimeInstanceBase
{
	public delegate FSMState_PS_TransactionBase Del_StateCreate(FSMRuntimeInstance_PS_Transaction RuntimeInstance, FCalliopeNode Node, object InputParams);

	public delegate FSMConditionBase Del_ConditionCreate(FSMRuntimeInstance_PS_Transaction RuntimeInstance, FCalliopeNode Node, object InputParams);

	private static Dictionary<string, Del_StateCreate> sStateCreateFuncs = new Dictionary<string, Del_StateCreate>();

	private static Dictionary<string, Del_ConditionCreate> sConditionCreateFuncs = new Dictionary<string, Del_ConditionCreate>();

	private static Dictionary<string, SPS_Transaction> sEStateNameMap = new Dictionary<string, SPS_Transaction> { 
	{
		"FSM.BED_FSMNode_PS_Transaction_TransactionTask",
		SPS_Transaction.TransactionTask
	} };

	public FSMState_PS_TransactionBase ActiveState { get; private set; }

	public SPS_Transaction ActiveEState => sEStateNameMap[ActiveNode.NodeClass];

	public FSMContext_PS_Transaction Context { get; private set; }

	public static void RegisterStates(int EntityMgrIdx, string NodeClassName, Del_StateCreate CreateFunc)
	{
		sStateCreateFuncs[NodeClassName] = CreateFunc;
	}

	public static void RegisterConditions(int EntityMgrIdx, string NodeClassName, Del_ConditionCreate CreateFunc)
	{
		sConditionCreateFuncs[NodeClassName] = CreateFunc;
	}

	public FSMRuntimeInstance_PS_Transaction(FCalliopeGraph CalliopeGraph, FSMContext_PS_Transaction InContext, UCalliopeAsset CalliopeAsset)
		: base(CalliopeGraph, InContext, CalliopeAsset)
	{
		Context = InContext;
	}

	public override void Start(object InputParams, FSMContextBase Context)
	{
		base.Start(InputParams, Context);
		FreshActiveState(InputParams, FromAnyState: false);
	}

	public void ForceShutDown()
	{
		ActiveState = null;
		Finish();
	}

	protected void FreshActiveState(object InputParams, bool FromAnyState)
	{
		try
		{
			ActiveState?.OnExit();
			if (FromAnyState)
			{
				ActiveState?.OnAbort();
			}
			if (ActiveNode.NodeClass == "FSM.BED_FSMNode_End")
			{
				ActiveState = null;
				Finish();
			}
			else if (ActiveNode.NodeClass.StartsWith("FSM.BED_FSMNode_Condition_"))
			{
				FSMConditionBase fSMConditionBase = sConditionCreateFuncs[ActiveNode.NodeClass](this, ActiveNode, InputParams);
				if (TriggerEventByString(fSMConditionBase.GetResult(), Context, out var FromAnyState2))
				{
					FreshActiveState(fSMConditionBase.GetNextNodeInputParam(), FromAnyState2);
				}
			}
			else
			{
				ActiveState = sStateCreateFuncs[ActiveNode.NodeClass](this, ActiveNode, InputParams);
				ActiveState?.OnEnter();
			}
		}
		catch (FSMException exception)
		{
			OnExceptionInvoke(exception);
		}
	}

	public override int OnTick(float Delta)
	{
		try
		{
			return ActiveState.OnTick(Delta);
		}
		catch (FSMException exception)
		{
			OnExceptionInvoke(exception);
		}
		return 0;
	}

	public void TriggerEvent(EPS_Transaction Event, object InputParams = null)
	{
		TriggerEvent(Event.ToString(), InputParams);
	}

	public void TriggerEvent(string EventName, object InputParams = null)
	{
		if (TriggerEventByString(EventName, Context, out var FromAnyState))
		{
			FreshActiveState(InputParams, FromAnyState);
		}
	}

	public void TriggerSubGraphEvent(string EventName, object InputParams = null)
	{
		if (TriggerEventByString(EventName, Context, out var FromAnyState))
		{
			FreshActiveState(InputParams, FromAnyState);
		}
	}
}
