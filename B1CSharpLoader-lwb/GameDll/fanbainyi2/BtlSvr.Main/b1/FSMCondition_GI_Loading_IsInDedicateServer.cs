namespace b1;

public class FSMCondition_GI_Loading_IsInDedicateServer : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_IsInDedicateServer(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_IsInDedicateServer_Result GetEResult()
	{
		if (BGWGameInstanceCS.TickingGameInstNetMode(Context.GameInst) != EGameInstNetMode.DedicateServer)
		{
			return EGI_Loading_IsInDedicateServer_Result.False;
		}
		return EGI_Loading_IsInDedicateServer_Result.True;
	}
}
