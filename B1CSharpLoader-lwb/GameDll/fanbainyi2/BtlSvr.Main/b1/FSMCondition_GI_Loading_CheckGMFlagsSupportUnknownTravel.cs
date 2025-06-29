namespace b1;

public class FSMCondition_GI_Loading_CheckGMFlagsSupportUnknownTravel : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_CheckGMFlagsSupportUnknownTravel(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_CheckGMFlagsSupportUnknownTravel_Result GetEResult()
	{
		if (!BGUFunctionLibraryCS.IsCheatGMLevel() && !BGUFunctionLibraryCS.IsDebugGMLevel())
		{
			return EGI_Loading_CheckGMFlagsSupportUnknownTravel_Result.False;
		}
		return EGI_Loading_CheckGMFlagsSupportUnknownTravel_Result.True;
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
