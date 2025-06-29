namespace b1;

public class FSMCondition_GI_Global_IsIgnoreWXLogin : FSMConditionBase
{
	private FSMContext_GI_Global Context;

	public FSMCondition_GI_Global_IsIgnoreWXLogin(FSMContext_GI_Global Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Global_IsIgnoreWXLogin_Result GetEResult()
	{
		if (!(DebugConfig.GSSdkLoginChannel != "gamesci"))
		{
			return EGI_Global_IsIgnoreWXLogin_Result.False;
		}
		return EGI_Global_IsIgnoreWXLogin_Result.True;
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
