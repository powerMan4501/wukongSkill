namespace b1;

public class FSMCondition_GI_Loading_IsNeedResetGameInstanceData : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_IsNeedResetGameInstanceData(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_IsNeedResetGameInstanceData_Result GetEResult()
	{
		if (!Context.TravelLevelTemplate.IsNeedResetGameInstanceData())
		{
			return EGI_Loading_IsNeedResetGameInstanceData_Result.False;
		}
		return EGI_Loading_IsNeedResetGameInstanceData_Result.True;
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
