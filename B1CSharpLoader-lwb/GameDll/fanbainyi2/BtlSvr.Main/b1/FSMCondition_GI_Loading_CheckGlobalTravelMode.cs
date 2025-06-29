namespace b1;

public class FSMCondition_GI_Loading_CheckGlobalTravelMode : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_CheckGlobalTravelMode(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_CheckGlobalTravelMode_Result GetEResult()
	{
		return Context.TravelLevelTemplate.TargetLevelNetType switch
		{
			ETargetLevelNetType.MainMenu => EGI_Loading_CheckGlobalTravelMode_Result.MainMenu, 
			ETargetLevelNetType.StandAlone => EGI_Loading_CheckGlobalTravelMode_Result.StandAlone, 
			ETargetLevelNetType.ListenServer => EGI_Loading_CheckGlobalTravelMode_Result.ListenServer, 
			ETargetLevelNetType.Client => EGI_Loading_CheckGlobalTravelMode_Result.Client, 
			_ => EGI_Loading_CheckGlobalTravelMode_Result.MainMenu, 
		};
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
