namespace b1;

public class FSMCondition_GI_Loading_IsInBattleLevel : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_IsInBattleLevel(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_IsInBattleLevel_Result GetEResult()
	{
		if (!BGUFuncLibMap.IsBattleMap(Context.GameInst))
		{
			return EGI_Loading_IsInBattleLevel_Result.False;
		}
		return EGI_Loading_IsInBattleLevel_Result.True;
	}
}
