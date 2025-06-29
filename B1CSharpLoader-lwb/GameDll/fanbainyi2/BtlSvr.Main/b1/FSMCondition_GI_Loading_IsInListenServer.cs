namespace b1;

public class FSMCondition_GI_Loading_IsInListenServer : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_IsInListenServer(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_IsInListenServer_Result GetEResult()
	{
		if (BGWGameInstanceCS.TickingGameInstNetMode(Context.GameInst) != EGameInstNetMode.ListenServer)
		{
			return EGI_Loading_IsInListenServer_Result.False;
		}
		return EGI_Loading_IsInListenServer_Result.True;
	}
}
