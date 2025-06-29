using System.Collections.Generic;
using System.Linq;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace b1;

public class AIFilterProcess
{
	private AIDataPkg MainInput;

	private FUStAIFeatureDesc FeatureDesc;

	private AActor Own;

	private IBGC_TeamRelationData TeamRelationData;

	public AIFilterProcess(AActor Own)
	{
		this.Own = Own;
		TeamRelationData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_TeamRelationData, BGC_TeamRelationData>(Own);
	}

	public AIFilterResult ExecuteFilter(AIFeatureElem FeatureElem)
	{
		FeatureDesc = BGW_GameDB.GetAIFeatureDesc(FeatureElem.FeatureID);
		if (FeatureElem.State == AIFeatureState.InputInvalid)
		{
			return AIFilterResult.Failed;
		}
		if (FeatureDesc.MainInputID == 0)
		{
			return AIFilterResult.NoNeedFilter;
		}
		MainInput = FeatureElem.InputDataList[0];
		Dictionary<AIDataBase, float> dictionary = new Dictionary<AIDataBase, float>();
		foreach (AIDataBase data in MainInput.DataList)
		{
			dictionary.Add(data, 0f);
		}
		Dictionary<AIDataBase, float> dictionary2 = dictionary;
		Dictionary<AIDataBase, float> dictionary3 = dictionary2;
		foreach (FUStAIFeatureFilter aIFeatureFilter in BGW_GameDB.GetAIFeatureFilters(FeatureElem.FeatureID))
		{
			List<AIDataPkg> inputDataListByFilterDesc = AIGOAPFuncLibCS.GetInputDataListByFilterDesc(aIFeatureFilter, FeatureElem);
			switch (aIFeatureFilter.FilterType)
			{
			case EFilterType.Distance:
				dictionary3 = DistanceFilter(dictionary2, inputDataListByFilterDesc, aIFeatureFilter);
				break;
			case EFilterType.Team:
				dictionary3 = TeamFilter(dictionary2, inputDataListByFilterDesc, aIFeatureFilter);
				break;
			case EFilterType.SkillCastRange:
				dictionary3 = SkillCastRangeFilter(dictionary2, inputDataListByFilterDesc, aIFeatureFilter);
				break;
			case EFilterType.SkillArea:
				dictionary3 = SkillAreaFilter(dictionary2, inputDataListByFilterDesc, aIFeatureFilter);
				break;
			case EFilterType.Score:
				dictionary3 = ScoreFilter(dictionary2, inputDataListByFilterDesc, aIFeatureFilter);
				break;
			case EFilterType.PointsGen:
				dictionary3 = PointsGenFilter(dictionary2, inputDataListByFilterDesc, aIFeatureFilter);
				break;
			case EFilterType.UnitState:
				dictionary3 = UnitStateFilter(dictionary2, inputDataListByFilterDesc, aIFeatureFilter);
				break;
			case EFilterType.NavPathExist:
				dictionary3 = NavPathExistFilter(dictionary2, inputDataListByFilterDesc, aIFeatureFilter);
				break;
			case EFilterType.FixedDistance:
				dictionary3 = FixedDistanceFilter(dictionary2, inputDataListByFilterDesc, aIFeatureFilter);
				break;
			case EFilterType.Hppercent:
				dictionary3 = HPPercentFilter(dictionary2, inputDataListByFilterDesc, aIFeatureFilter);
				break;
			case EFilterType.InNavMesh:
				dictionary3 = InNavMeshFilter(dictionary2, inputDataListByFilterDesc, aIFeatureFilter);
				break;
			case EFilterType.ValidSkill:
				dictionary3 = ValidSkillFilter(dictionary2, inputDataListByFilterDesc, aIFeatureFilter);
				break;
			case EFilterType.UnitResId:
				dictionary3 = UnitResIDFilter(dictionary2, inputDataListByFilterDesc, aIFeatureFilter);
				break;
			}
			if (aIFeatureFilter.Inverse == EGSYesNo.No)
			{
				dictionary2 = dictionary3;
				continue;
			}
			int num = 0;
			while (num < dictionary2.Count)
			{
				if (dictionary3.Contains(dictionary2.ElementAt(num)))
				{
					dictionary2.Remove(dictionary2.ElementAt(num).Key);
				}
				else
				{
					num++;
				}
			}
			dictionary3 = dictionary2;
		}
		AIDataPkg aIDataPkg = new AIDataPkg();
		foreach (KeyValuePair<AIDataBase, float> item in dictionary3)
		{
			aIDataPkg.AddData(item.Key);
		}
		if (!aIDataPkg.IsPkgValid())
		{
			return AIFilterResult.Failed;
		}
		FeatureElem.OutputData = aIDataPkg;
		return AIFilterResult.Success;
	}

	public Dictionary<AIDataBase, float> DistanceFilter(Dictionary<AIDataBase, float> InputDic, List<AIDataPkg> ExtraInputs, FUStAIFeatureFilter FilterDesc)
	{
		Dictionary<AIDataBase, float> dictionary = new Dictionary<AIDataBase, float>();
		FVector TargetLoc = ExtraInputs[0].DataList[0].GetLocation();
		if (!AIGOAPFuncLibCS.IsVectorValid(TargetLoc))
		{
			return null;
		}
		List<KeyValuePair<AIDataBase, float>> list = InputDic.OrderBy(delegate(KeyValuePair<AIDataBase, float> Item)
		{
			KeyValuePair<AIDataBase, float> keyValuePair = Item;
			return FVector.Dist2D(keyValuePair.Key.GetLocation(), TargetLoc);
		}).ToList();
		int num = (int)MathLib.Clamp((float)list.Count * ((float)FilterDesc.FilterParams[0] / 10000f), 0f, list.Count - 1);
		float num2 = list.Count - 1 - num;
		float num3 = num;
		for (int num4 = 0; num4 < list.Count; num4++)
		{
			float num5 = 0f;
			num5 = ((num4 <= num) ? ((num4 >= num) ? 1f : ((float)num4 / num3)) : ((float)(list.Count - 1 - num4) / num2));
			dictionary.Add(list[num4].Key, list[num4].Value + num5);
		}
		return dictionary;
	}

	public Dictionary<AIDataBase, float> TeamFilter(Dictionary<AIDataBase, float> InputDic, List<AIDataPkg> ExtraInputs, FUStAIFeatureFilter FilterDesc)
	{
		Dictionary<AIDataBase, float> dictionary = new Dictionary<AIDataBase, float>();
		int teamIDInCS = (ExtraInputs[0].DataList[0].GetCharacter() as BGUCharacterCS).GetTeamIDInCS();
		foreach (KeyValuePair<AIDataBase, float> item in InputDic)
		{
			int teamIDInCS2 = ((item.Key as AICharacterData).Character as BGUCharacterCS).GetTeamIDInCS();
			if (FilterDesc.FilterParams[0] == 0 && !TeamRelationData.IsEnemyTeam(teamIDInCS2, teamIDInCS))
			{
				dictionary.Add(item.Key, item.Value);
			}
			if (FilterDesc.FilterParams[0] == 1 && TeamRelationData.IsEnemyTeam(teamIDInCS2, teamIDInCS))
			{
				dictionary.Add(item.Key, item.Value);
			}
		}
		return dictionary;
	}

	public Dictionary<AIDataBase, float> SkillCastRangeFilter(Dictionary<AIDataBase, float> InputDic, List<AIDataPkg> ExtraInputs, FUStAIFeatureFilter FilterDesc)
	{
		Dictionary<AIDataBase, float> dictionary = new Dictionary<AIDataBase, float>();
		ACharacter character = ExtraInputs[1].DataList[0].GetCharacter();
		FVector location = ExtraInputs[0].DataList[0].GetLocation();
		List<AISkillInfo> validSkillInfoList = BGU_DataUtil.GetReadOnlyData<IBUC_GOAPData, BUC_GOAPData>(character).GetValidSkillInfoList();
		List<AISkillInfo> list = new List<AISkillInfo>();
		foreach (AISkillInfo item in validSkillInfoList)
		{
			foreach (EActionTagType tag in item.Tags)
			{
				if (FilterDesc.FilterParams.Contains((int)tag))
				{
					list.Add(item);
					break;
				}
			}
		}
		foreach (KeyValuePair<AIDataBase, float> item2 in InputDic)
		{
			float num = FVector.Dist2D(item2.Key.GetLocation(), location);
			foreach (AISkillInfo item3 in list)
			{
				if (num < item3.MaxRange && num > item3.MinRange)
				{
					dictionary.Add(item2.Key, item2.Value);
					break;
				}
			}
		}
		return dictionary;
	}

	public Dictionary<AIDataBase, float> SkillAreaFilter(Dictionary<AIDataBase, float> InputDic, List<AIDataPkg> ExtraInputs, FUStAIFeatureFilter FilterDesc)
	{
		Dictionary<AIDataBase, float> dictionary = new Dictionary<AIDataBase, float>();
		BGUCharacterCS character = ExtraInputs[0].DataList[0].GetCharacter() as BGUCharacterCS;
		bool isEnemy = FilterDesc.FilterParams[0] == 1;
		foreach (KeyValuePair<AIDataBase, float> item in InputDic)
		{
			if (AIFuncLibForCS.CheckPointInSkillArea(item.Key.GetLocation(), character, isEnemy))
			{
				dictionary.Add(item.Key, item.Value);
			}
		}
		return dictionary;
	}

	public Dictionary<AIDataBase, float> ScoreFilter(Dictionary<AIDataBase, float> InputDic, List<AIDataPkg> ExtraInputs, FUStAIFeatureFilter FilterDesc)
	{
		Dictionary<AIDataBase, float> dictionary = new Dictionary<AIDataBase, float>();
		List<KeyValuePair<AIDataBase, float>> list = InputDic.OrderByDescending(delegate(KeyValuePair<AIDataBase, float> Item)
		{
			KeyValuePair<AIDataBase, float> keyValuePair = Item;
			return keyValuePair.Value;
		}).ToList();
		int num = (int)MathLib.Clamp((float)FilterDesc.FilterParams[0] / 10000f * (float)list.Count, 0f, list.Count - 1);
		for (int num2 = 0; num2 <= num; num2++)
		{
			dictionary.Add(list[num2].Key, list[num2].Value);
		}
		return dictionary;
	}

	public Dictionary<AIDataBase, float> PointsGenFilter(Dictionary<AIDataBase, float> InputDic, List<AIDataPkg> ExtraInputs, FUStAIFeatureFilter FilterDesc)
	{
		Dictionary<AIDataBase, float> dictionary = new Dictionary<AIDataBase, float>();
		foreach (KeyValuePair<AIDataBase, float> item in InputDic)
		{
			FVector location = item.Key.GetLocation();
			foreach (AIDataBase item2 in Gen2DPoints(location, FilterDesc.FilterParams[0], FilterDesc.FilterParams[1]))
			{
				dictionary.Add(item2, 0f);
			}
		}
		return dictionary;
	}

	public Dictionary<AIDataBase, float> UnitStateFilter(Dictionary<AIDataBase, float> InputDic, List<AIDataPkg> ExtraInputs, FUStAIFeatureFilter FilterDesc)
	{
		Dictionary<AIDataBase, float> dictionary = new Dictionary<AIDataBase, float>();
		foreach (KeyValuePair<AIDataBase, float> item in InputDic)
		{
			bool flag = true;
			ACharacter character = item.Key.GetCharacter();
			foreach (int filterParam in FilterDesc.FilterParams)
			{
				if (!BGUFunctionLibraryCS.BGUHasUnitState(character, (EBGUUnitState)filterParam))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				dictionary.Add(item.Key, item.Value);
			}
		}
		return dictionary;
	}

	public Dictionary<AIDataBase, float> NavPathExistFilter(Dictionary<AIDataBase, float> InputDic, List<AIDataPkg> ExtraInputs, FUStAIFeatureFilter FilterDesc)
	{
		Dictionary<AIDataBase, float> dictionary = new Dictionary<AIDataBase, float>();
		ACharacter character = ExtraInputs[0].DataList[0].GetCharacter();
		foreach (KeyValuePair<AIDataBase, float> item in InputDic)
		{
			List<EObjectTypeQuery> objectTypes = new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery17 };
			UBGUSelectUtil.LineTraceForObjectsTypeSimple(Own, BGUFuncLibActorTransformCS.BGUGetActorLocation(character), item.Key.GetLocation(), objectTypes, bDebug: false, out var HitResult);
			if (!HitResult.IsBlockingHit)
			{
				dictionary.Add(item.Key, item.Value);
			}
		}
		return dictionary;
	}

	public Dictionary<AIDataBase, float> FixedDistanceFilter(Dictionary<AIDataBase, float> InputDic, List<AIDataPkg> ExtraInputs, FUStAIFeatureFilter FilterDesc)
	{
		Dictionary<AIDataBase, float> dictionary = new Dictionary<AIDataBase, float>();
		FVector location = ExtraInputs[0].DataList[0].GetLocation();
		foreach (KeyValuePair<AIDataBase, float> item in InputDic)
		{
			if (!(FVector.Dist2D(location, item.Key.GetLocation()) > (float)FilterDesc.FilterParams[0]))
			{
				dictionary.Add(item.Key, item.Value);
			}
		}
		return dictionary;
	}

	public Dictionary<AIDataBase, float> HPPercentFilter(Dictionary<AIDataBase, float> InputDic, List<AIDataPkg> ExtraInputs, FUStAIFeatureFilter FilterDesc)
	{
		Dictionary<AIDataBase, float> dictionary = new Dictionary<AIDataBase, float>();
		foreach (KeyValuePair<AIDataBase, float> item in InputDic)
		{
			ACharacter character = item.Key.GetCharacter();
			float num = BGUFunctionLibraryCS.BGUGetFloatAttr(character, EBGUAttrFloat.Hp);
			float num2 = BGUFunctionLibraryCS.BGUGetFloatAttr(character, EBGUAttrFloat.HpMax);
			if (num / num2 * 10000f < (float)FilterDesc.FilterParams[0])
			{
				dictionary.Add(item.Key, item.Value);
			}
		}
		return dictionary;
	}

	public Dictionary<AIDataBase, float> InNavMeshFilter(Dictionary<AIDataBase, float> InputDic, List<AIDataPkg> ExtraInputs, FUStAIFeatureFilter FilterDesc)
	{
		Dictionary<AIDataBase, float> dictionary = new Dictionary<AIDataBase, float>();
		foreach (KeyValuePair<AIDataBase, float> item in InputDic)
		{
			UNavigationSystemV1.ProjectPointToNavigation(Own, item.Key.GetLocation(), out var ProjectedLocation, null, null, new FVector(0.0, 0.0, 0.0));
			if (!(FVector.Dist2D(ProjectedLocation, item.Key.GetLocation()) > 0.1f))
			{
				dictionary.Add(item.Key, item.Value);
			}
		}
		return dictionary;
	}

	public Dictionary<AIDataBase, float> ValidSkillFilter(Dictionary<AIDataBase, float> InputDic, List<AIDataPkg> ExtraInputs, FUStAIFeatureFilter FilterDesc)
	{
		Dictionary<AIDataBase, float> dictionary = new Dictionary<AIDataBase, float>();
		foreach (KeyValuePair<AIDataBase, float> item in InputDic)
		{
			bool flag = false;
			foreach (AISkillInfo validSkillInfo in BGU_DataUtil.GetReadOnlyData<IBUC_GOAPData, BUC_GOAPData>(item.Key.GetCharacter()).GetValidSkillInfoList())
			{
				foreach (int filterParam in FilterDesc.FilterParams)
				{
					if (validSkillInfo.Tags.Contains((EActionTagType)filterParam))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					break;
				}
			}
			if (flag)
			{
				dictionary.Add(item.Key, item.Value);
			}
		}
		return dictionary;
	}

	public Dictionary<AIDataBase, float> UnitResIDFilter(Dictionary<AIDataBase, float> InputDic, List<AIDataPkg> ExtraInputs, FUStAIFeatureFilter FilterDesc)
	{
		Dictionary<AIDataBase, float> dictionary = new Dictionary<AIDataBase, float>();
		foreach (KeyValuePair<AIDataBase, float> item in InputDic)
		{
			if ((item.Key.GetCharacter() as BGUCharacterCS).GetResID() == FilterDesc.FilterParams[0])
			{
				dictionary.Add(item.Key, item.Value);
			}
		}
		return dictionary;
	}

	public List<AIDataBase> Gen2DPoints(FVector CenterLoc, float Len, float Interval)
	{
		List<AIDataBase> list = new List<AIDataBase>();
		Interval = MathLib.Clamp(Interval, 1f, Len);
		_ = CenterLoc.Z;
		FVector fVector = CenterLoc - new FVector(Len / 2f, Len / 2f, 0.0);
		for (float num = 0f; num <= Len; num += Interval)
		{
			for (float num2 = 0f; num2 <= Len; num2 += Interval)
			{
				AIPointData item = new AIPointData(fVector + new FVector(num, num2, 0.0));
				list.Add(item);
			}
		}
		return list;
	}
}
