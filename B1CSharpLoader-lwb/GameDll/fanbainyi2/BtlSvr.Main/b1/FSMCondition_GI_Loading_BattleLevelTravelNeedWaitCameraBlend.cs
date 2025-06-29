namespace b1;

public class FSMCondition_GI_Loading_BattleLevelTravelNeedWaitCameraBlend : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_BattleLevelTravelNeedWaitCameraBlend(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_BattleLevelTravelNeedWaitCameraBlend_Result GetEResult()
	{
		if (!Context.BattleLevelTravelNeedWaitCameraBlend)
		{
			return EGI_Loading_BattleLevelTravelNeedWaitCameraBlend_Result.False;
		}
		return EGI_Loading_BattleLevelTravelNeedWaitCameraBlend_Result.True;
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
