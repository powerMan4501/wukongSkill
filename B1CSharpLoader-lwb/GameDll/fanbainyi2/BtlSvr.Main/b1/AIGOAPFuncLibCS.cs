using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class AIGOAPFuncLibCS
{
	public static readonly Dictionary<int, EFeatureInputType> OriFeatureInputDic = new Dictionary<int, EFeatureInputType>
	{
		{
			10001,
			EFeatureInputType.AllCharacters
		},
		{
			10002,
			EFeatureInputType.OwnCharacter
		},
		{
			10003,
			EFeatureInputType.CenterCharacter
		}
	};

	public static AIDataPkg GetFeatureInputDataByID(int ID, AIFeatureElem FeatureElem)
	{
		int num = 0;
		foreach (AIElement childElem in FeatureElem.ChildElems)
		{
			if (childElem is AIFeatureElem aIFeatureElem)
			{
				if (aIFeatureElem.FeatureID == ID)
				{
					return FeatureElem.InputDataList[num];
				}
				num++;
			}
		}
		return null;
	}

	public static List<int> GetInputIDListByFeatureDesc(FUStAIFeatureDesc FeatureDesc)
	{
		List<int> list = new List<int>();
		list.Add(FeatureDesc.MainInputID);
		foreach (FUStAIFeatureFilter aIFeatureFilter in BGW_GameDB.GetAIFeatureFilters(FeatureDesc.ID))
		{
			foreach (int filterInput in aIFeatureFilter.FilterInputs)
			{
				if (!list.Contains(filterInput))
				{
					list.Add(filterInput);
				}
			}
		}
		return list;
	}

	public static List<AIDataPkg> GetInputDataListByFilterDesc(FUStAIFeatureFilter FilterDesc, AIFeatureElem FeatureElem)
	{
		List<AIDataPkg> list = new List<AIDataPkg>();
		foreach (int filterInput in FilterDesc.FilterInputs)
		{
			AIDataPkg featureInputDataByID = GetFeatureInputDataByID(filterInput, FeatureElem);
			list.Add(featureInputDataByID);
		}
		return list;
	}

	public static bool IsVectorValid(FVector Vector)
	{
		if (Vector.NotEqual_VectorVector(new FVector(-1.0, -1.0, -1.0)))
		{
			return true;
		}
		return false;
	}

	public static AIElement CreateAIElem(int ElemID, EAIElemType ElemType)
	{
		AIElement result = null;
		switch (ElemType)
		{
		case EAIElemType.Action:
			result = new AIActionElem(ElemID);
			break;
		case EAIElemType.Feature:
			result = new AIFeatureElem(ElemID);
			break;
		case EAIElemType.Think:
			result = new AIThinkElem(ElemID);
			break;
		}
		return result;
	}

	public static bool CheckElemInTree(AIElement Elem)
	{
		AIElement aIElement = Elem;
		while (aIElement.ParentElem != null)
		{
			if (aIElement.ParentElem is AIThinkElem aIThinkElem && aIThinkElem.CurElem != aIElement)
			{
				return false;
			}
			aIElement = aIElement.ParentElem;
		}
		return true;
	}
}
