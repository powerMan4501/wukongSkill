using System;

namespace b1;

public class FSMCondition_GI_Loading_HasArchiveIdInContext : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_HasArchiveIdInContext(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_HasArchiveIdInContext_Result GetEResult()
	{
		throw new NotImplementedException();
	}
}
