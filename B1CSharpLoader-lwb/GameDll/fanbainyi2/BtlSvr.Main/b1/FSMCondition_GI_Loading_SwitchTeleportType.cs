namespace b1;

public class FSMCondition_GI_Loading_SwitchTeleportType : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_SwitchTeleportType(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_SwitchTeleportType_Result GetEResult()
	{
		int curLevelId = BGUFuncLibMap.GetCurLevelId(Context.GameInst);
		int targetLevelId = Context.TeleportTemplate.GetTargetLevelId();
		if (!BGUFuncLibMap.IsValidLevelId(targetLevelId))
		{
			if (targetLevelId > 0)
			{
				BGW_LogUtil.LogError($"TargetLevelId {targetLevelId} is not contained by LevelDesc!");
			}
			return EGI_Loading_SwitchTeleportType_Result.TeleportToSameLevel;
		}
		if (curLevelId == targetLevelId)
		{
			return EGI_Loading_SwitchTeleportType_Result.TeleportToSameLevel;
		}
		if (UGSE_EngineFuncLib.IsListenServer(Context.GameInst.GetWorldForCS()))
		{
			if (BGUFuncLibMap.IsPartyLevel(targetLevelId, Context.GameInst))
			{
				return EGI_Loading_SwitchTeleportType_Result.TravelLevelToParty;
			}
			return EGI_Loading_SwitchTeleportType_Result.TravelLevelToConsole;
		}
		if (BGUFuncLibMap.IsPartyLevel(curLevelId, Context.GameInst))
		{
			return EGI_Loading_SwitchTeleportType_Result.TravelLevelToConsole;
		}
		if (BGUFuncLibMap.IsPartyLevel(targetLevelId, Context.GameInst))
		{
			return EGI_Loading_SwitchTeleportType_Result.TravelLevelToParty;
		}
		return EGI_Loading_SwitchTeleportType_Result.TravelLevelToSamePlayerGameMode;
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
