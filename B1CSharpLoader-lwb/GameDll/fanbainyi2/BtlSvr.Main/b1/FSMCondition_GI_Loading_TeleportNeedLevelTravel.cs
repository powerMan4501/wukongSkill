namespace b1;

public class FSMCondition_GI_Loading_TeleportNeedLevelTravel : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_TeleportNeedLevelTravel(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_TeleportNeedLevelTravel_Result GetEResult()
	{
		BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(Context.GameInst);
		int levelIdByLevelName = UBGWFunctionLibraryCS.GetLevelIdByLevelName(Context.GameInst.GetWorldForCS().PathName.Split('.')[1]);
		if (Context.TeleportTemplate.GetTargetLevelId() <= 0 || Context.TeleportTemplate.GetTargetLevelId() == levelIdByLevelName)
		{
			return EGI_Loading_TeleportNeedLevelTravel_Result.False;
		}
		return EGI_Loading_TeleportNeedLevelTravel_Result.True;
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
