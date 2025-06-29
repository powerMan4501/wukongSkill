using Google.Protobuf;
using GUR.Runtime;
using GurCalliopeFsm;

namespace b1;

public class FSMCondition_GI_Loading_IsInMap : FSMConditionBase
{
	private FSMContext_GI_Loading Context;

	[EditableFSMParam]
	private string LevelName { get; set; }

	public FSMCondition_GI_Loading_IsInMap(FSMContext_GI_Loading Context, FCalliopeNode Node, object InputParams)
	{
		this.Context = Context;
		GI_Loading_IsInMap gI_Loading_IsInMap = new GI_Loading_IsInMap();
		gI_Loading_IsInMap.MergeFrom(Node.NodeData);
		LevelName = gI_Loading_IsInMap.LevelName;
	}

	public override string GetResult()
	{
		return GetEResult().ToString();
	}

	public EGI_Loading_IsInMap_Result GetEResult()
	{
		IBIC_LevelData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(Context.GameInst);
		if (gameInstanceReadonlyData != null && gameInstanceReadonlyData.CurrentLevelName.ToString().Equals(LevelName))
		{
			return EGI_Loading_IsInMap_Result.True;
		}
		return EGI_Loading_IsInMap_Result.False;
	}

	public override object GetNextNodeInputParam()
	{
		return null;
	}
}
