using System;

namespace b1;

public class FSMCondition_PS_Transaction_TaskCondition : FSMConditionBase
{
	private FSMContext_PS_Transaction Context;

	public FSMCondition_PS_Transaction_TaskCondition(FSMContext_PS_Transaction Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EPS_Transaction_TaskCondition_Result GetEResult()
	{
		throw new NotImplementedException();
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
