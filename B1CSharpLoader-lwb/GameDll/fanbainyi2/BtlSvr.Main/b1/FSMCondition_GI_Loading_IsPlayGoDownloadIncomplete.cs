namespace b1;

public class FSMCondition_GI_Loading_IsPlayGoDownloadIncomplete : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_IsPlayGoDownloadIncomplete(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_IsPlayGoDownloadIncomplete_Result GetEResult()
	{
		if (!BGW_PlayGoMgr.Get(Context.GameInst).IsDownloadIncomplete())
		{
			return EGI_Loading_IsPlayGoDownloadIncomplete_Result.False;
		}
		return EGI_Loading_IsPlayGoDownloadIncomplete_Result.True;
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
