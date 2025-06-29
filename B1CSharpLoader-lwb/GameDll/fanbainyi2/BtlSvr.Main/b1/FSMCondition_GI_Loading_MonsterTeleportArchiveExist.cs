using ResB1;

namespace b1;

public class FSMCondition_GI_Loading_MonsterTeleportArchiveExist : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_MonsterTeleportArchiveExist(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_MonsterTeleportArchiveExist_Result GetEResult()
	{
		GMMonsterTeleportDesc gMMonsterTeleportDesc = GameDBRuntime.GetGMMonsterTeleportDesc(Context.GMTravelParams.MonsterTeleportId);
		if (gMMonsterTeleportDesc == null)
		{
			return EGI_Loading_MonsterTeleportArchiveExist_Result.False;
		}
		if (string.IsNullOrEmpty(gMMonsterTeleportDesc.ArchiveName))
		{
			return EGI_Loading_MonsterTeleportArchiveExist_Result.False;
		}
		return EGI_Loading_MonsterTeleportArchiveExist_Result.True;
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
