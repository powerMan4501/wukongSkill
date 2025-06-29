using System.Linq;

namespace b1;

public class FSMCondition_GI_Loading_IsInContextLevel : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	public FSMCondition_GI_Loading_IsInContextLevel(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_IsInContextLevel_Result GetEResult()
	{
		if (UBGWFunctionLibraryCS.GetLevelIdByLevelName(Context.GameInst.GetWorldForCS().PathName.Split('.').Last()) != Context.TargetLevelId)
		{
			return EGI_Loading_IsInContextLevel_Result.False;
		}
		return EGI_Loading_IsInContextLevel_Result.True;
	}
}
