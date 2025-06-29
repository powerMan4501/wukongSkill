namespace b1;

public class FSMCondition_GI_Loading_TravelUrlIsListen : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_TravelUrlIsListen(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_TravelUrlIsListen_Result GetEResult()
	{
		if (!Context.GameInst.TravelURLHasOption("listen"))
		{
			return EGI_Loading_TravelUrlIsListen_Result.False;
		}
		return EGI_Loading_TravelUrlIsListen_Result.True;
	}
}
