namespace b1;

public class FSMCondition_GI_Loading_IsNeedPreStartGameProcess : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_IsNeedPreStartGameProcess(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_IsNeedPreStartGameProcess_Result GetEResult()
	{
		if (!DebugConfig.IsNeedPreStartGameProcess)
		{
			return EGI_Loading_IsNeedPreStartGameProcess_Result.False;
		}
		return EGI_Loading_IsNeedPreStartGameProcess_Result.True;
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
