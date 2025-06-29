using System.Collections.Generic;

namespace b1;

public class AIActionElem : AIElement
{
	public int ActionID;

	public AIActionState State;

	public List<AIDataPkg> InputDataList;

	public ActionProcessBase Process;

	public ActionPreExeCache PreExeCache;

	public AIActionElem(int ID)
	{
		ActionID = ID;
		State = AIActionState.NotVertify;
		InputDataList = new List<AIDataPkg>();
		PreExeCache = new ActionPreExeCache();
		Process = null;
		PreExeCache.Clear();
	}

	public void ClearData()
	{
		if (State != AIActionState.Executing && State != AIActionState.ExeInputInvalid)
		{
			State = AIActionState.NotVertify;
		}
		InputDataList.Clear();
	}
}
