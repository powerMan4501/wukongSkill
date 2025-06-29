namespace b1;

public class FSMCondition_GI_Loading_TravelUrlHasHost : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_TravelUrlHasHost(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_TravelUrlHasHost_Result GetEResult()
	{
		if (!Context.GameInst.TravelURLHasHost())
		{
			return EGI_Loading_TravelUrlHasHost_Result.False;
		}
		return EGI_Loading_TravelUrlHasHost_Result.True;
	}
}
