using System.Collections.Generic;

namespace b1;

public class AIFeatureElem : AIElement
{
	public int FeatureID;

	public AIFeatureState State;

	public List<AIDataPkg> InputDataList;

	public AIDataPkg OutputData;

	public float Score;

	public AIFeatureElem(int ID)
	{
		FeatureID = ID;
		State = AIFeatureState.NotVertify;
		InputDataList = new List<AIDataPkg>();
		Score = 0f;
	}

	public void ClearData()
	{
		State = AIFeatureState.NotVertify;
		InputDataList.Clear();
		OutputData = null;
	}
}
