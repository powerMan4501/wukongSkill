namespace b1;

public class FSMCondition_GI_Loading_IsInPIEClient : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_IsInPIEClient(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_IsInPIEClient_Result GetEResult()
	{
		if (Context.GameInst.StartType != EStartGameInstanceTypeForCS.StartCS_PIE_Client)
		{
			return EGI_Loading_IsInPIEClient_Result.False;
		}
		return EGI_Loading_IsInPIEClient_Result.True;
	}
}
