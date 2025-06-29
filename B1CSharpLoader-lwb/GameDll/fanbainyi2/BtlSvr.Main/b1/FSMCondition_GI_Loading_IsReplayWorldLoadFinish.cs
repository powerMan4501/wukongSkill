namespace b1;

public class FSMCondition_GI_Loading_IsReplayWorldLoadFinish : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_IsReplayWorldLoadFinish(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_IsReplayWorldLoadFinish_Result GetEResult()
	{
		if (BGW_EventCollection.Get(Context.GameInst).Evt_ReplayBattleWorldLoadFinish())
		{
			return EGI_Loading_IsReplayWorldLoadFinish_Result.True;
		}
		return EGI_Loading_IsReplayWorldLoadFinish_Result.False;
	}
}
