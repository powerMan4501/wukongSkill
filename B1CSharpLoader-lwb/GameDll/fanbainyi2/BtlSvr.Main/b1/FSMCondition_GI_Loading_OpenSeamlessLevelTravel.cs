namespace b1;

public class FSMCondition_GI_Loading_OpenSeamlessLevelTravel : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_OpenSeamlessLevelTravel(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_OpenSeamlessLevelTravel_Result GetEResult()
	{
		if (!Context.LevelTravalUseSeamless())
		{
			return EGI_Loading_OpenSeamlessLevelTravel_Result.False;
		}
		return EGI_Loading_OpenSeamlessLevelTravel_Result.True;
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
