namespace b1;

public class FSMCondition_GI_Loading_IsStandAlone : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_IsStandAlone(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_IsStandAlone_Result GetEResult()
	{
		if (BGWGameInstanceCS.TickingGameInstNetMode(Context.GameInst) != EGameInstNetMode.StandAlone)
		{
			return EGI_Loading_IsStandAlone_Result.False;
		}
		return EGI_Loading_IsStandAlone_Result.True;
	}
}
