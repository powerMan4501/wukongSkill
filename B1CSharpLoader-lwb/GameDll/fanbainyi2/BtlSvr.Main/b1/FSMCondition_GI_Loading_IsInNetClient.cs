namespace b1;

public class FSMCondition_GI_Loading_IsInNetClient : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_IsInNetClient(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_IsInNetClient_Result GetEResult()
	{
		if (BGWGameInstanceCS.TickingGameInstNetMode(Context.GameInst) != EGameInstNetMode.Client)
		{
			return EGI_Loading_IsInNetClient_Result.False;
		}
		return EGI_Loading_IsInNetClient_Result.True;
	}
}
