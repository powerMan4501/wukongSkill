namespace b1;

public class FSMCondition_GI_Loading_HasArchive : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_HasArchive(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_HasArchive_Result GetEResult()
	{
		if (DebugConfig.DebugStartWithOutArchive)
		{
			return EGI_Loading_HasArchive_Result.True;
		}
		if (!BGW_GameArchiveMgr.Get(Context.GameInst).HasArchiveFile())
		{
			return EGI_Loading_HasArchive_Result.False;
		}
		return EGI_Loading_HasArchive_Result.True;
	}
}
