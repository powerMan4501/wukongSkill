using b1.ECS;

namespace b1;

public class BUC_StateLibData : IBUC_StateLibData, IPersistentECSData
{
	private StateLibData StateLibBase;

	private StateLibData StateLibMod;

	public string StateLibBaseDebugString { get; set; }

	public string StateLibModDebugString { get; set; }

	public BUC_StateLibData()
	{
		StateLibBaseDebugString = "None";
		StateLibModDebugString = "None";
	}

	public StateLibData UpdateMod(BGWDataAsset_StateLib DA, int TypesToApply)
	{
		StateLibMod.bIsValid = true;
		StateLibMod.StateLibDA = DA;
		StateLibMod.TypesToApply = TypesToApply;
		StateLibModDebugString = $"{DA.PathName} ({TypesToApply})";
		return StateLibMod;
	}

	public void ClearMod()
	{
		StateLibMod.bIsValid = false;
		StateLibModDebugString = "None";
	}

	public StateLibData UpdateBase(BGWDataAsset_StateLib DA, int TypesToApply)
	{
		StateLibBase.bIsValid = true;
		StateLibBase.StateLibDA = DA;
		StateLibBase.TypesToApply = TypesToApply;
		StateLibBaseDebugString = $"{DA.PathName} ({TypesToApply})";
		return StateLibBase;
	}

	public StateLibData GetBase()
	{
		return StateLibBase;
	}
}
