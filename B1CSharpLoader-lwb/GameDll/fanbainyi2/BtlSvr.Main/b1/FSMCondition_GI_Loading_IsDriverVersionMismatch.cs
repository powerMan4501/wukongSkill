namespace b1;

public class FSMCondition_GI_Loading_IsDriverVersionMismatch : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_IsDriverVersionMismatch(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_IsDriverVersionMismatch_Result GetEResult()
	{
		if (!UGSE_EngineFuncLib.IsDriverVersionMismatch())
		{
			return EGI_Loading_IsDriverVersionMismatch_Result.False;
		}
		return EGI_Loading_IsDriverVersionMismatch_Result.True;
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
