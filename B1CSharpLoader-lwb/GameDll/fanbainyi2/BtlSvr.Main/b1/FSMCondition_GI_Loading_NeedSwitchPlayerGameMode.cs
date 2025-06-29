namespace b1;

public class FSMCondition_GI_Loading_NeedSwitchPlayerGameMode : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_NeedSwitchPlayerGameMode(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_NeedSwitchPlayerGameMode_Result GetEResult()
	{
		int curLevelId = BGUFuncLibMap.GetCurLevelId(Context.GameInst);
		int targetLevelId = Context.TeleportTemplate.GetTargetLevelId();
		if (UGSE_EngineFuncLib.IsListenServer(Context.GameInst.GetWorldForCS()))
		{
			return EGI_Loading_NeedSwitchPlayerGameMode_Result.True;
		}
		if (BGUFuncLibMap.IsPartyLevel(curLevelId, Context.GameInst) || BGUFuncLibMap.IsPartyLevel(targetLevelId, Context.GameInst))
		{
			return EGI_Loading_NeedSwitchPlayerGameMode_Result.True;
		}
		return EGI_Loading_NeedSwitchPlayerGameMode_Result.False;
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
