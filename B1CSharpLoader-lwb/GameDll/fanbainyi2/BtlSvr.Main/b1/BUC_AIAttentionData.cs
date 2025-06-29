using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_AIAttentionData : IBUC_AIAttentionData
{
	public List<TStrongObjectPtr<AttentionFeatureBase>> RunTimeFeatureList = new List<TStrongObjectPtr<AttentionFeatureBase>>();

	public List<TStrongObjectPtr<AFSkillArea>> SkillAreaFeatureList = new List<TStrongObjectPtr<AFSkillArea>>();

	public Dictionary<int, List<BaseActionMsg>> ValidSkillBasicActionDic;

	public FCurThinkInfo CurThinkInfo;

	public Dictionary<int, List<BaseActionMsg>> AllSkillBasicActionDic;

	public Dictionary<int, List<BaseActionMsg>> MappedSkillBasicActionDic;

	public Dictionary<EAIBasicActionType, EAIRequestType> BA2ReqDic;

	public void Init()
	{
		CurThinkInfo = default(FCurThinkInfo);
		CurThinkInfo.CurThinkName = "";
		CurThinkInfo.ActiveThinkName = "";
		AllSkillBasicActionDic = new Dictionary<int, List<BaseActionMsg>>();
		ValidSkillBasicActionDic = new Dictionary<int, List<BaseActionMsg>>();
		MappedSkillBasicActionDic = new Dictionary<int, List<BaseActionMsg>>();
		BA2ReqDic = new Dictionary<EAIBasicActionType, EAIRequestType>();
		BA2ReqDic.Add(EAIBasicActionType.DirectionDamage, EAIRequestType.DirDamage);
		BA2ReqDic.Add(EAIBasicActionType.DirectionMove, EAIRequestType.MoveToLoc);
		BA2ReqDic.Add(EAIBasicActionType.RootMotionMove, EAIRequestType.MoveToLoc);
		BA2ReqDic.Add(EAIBasicActionType.TraceMove, EAIRequestType.MoveToActor);
		BA2ReqDic.Add(EAIBasicActionType.MoveSkill, EAIRequestType.MoveSkill);
	}

	public void AddSkillBAList(int SkillID, List<BaseActionMsg> BAList)
	{
		AllSkillBasicActionDic.Add(SkillID, BAList);
	}

	public AttentionFeatureBase GetFeatureByType(EAIAttentionFeatureType FeatureType)
	{
		foreach (TStrongObjectPtr<AttentionFeatureBase> runTimeFeature in RunTimeFeatureList)
		{
			if (runTimeFeature.Get().FeatureType == FeatureType)
			{
				return runTimeFeature.Get();
			}
		}
		return null;
	}

	public Dictionary<EAIBasicActionType, EAIRequestType> GetBA2ReqDic()
	{
		return BA2ReqDic;
	}

	public Dictionary<int, List<BaseActionMsg>> GetValidSkillBADic()
	{
		return ValidSkillBasicActionDic;
	}

	public List<AFSkillArea> GetSkillAreaFeatureList()
	{
		List<AFSkillArea> list = new List<AFSkillArea>();
		foreach (TStrongObjectPtr<AFSkillArea> skillAreaFeature in SkillAreaFeatureList)
		{
			list.Add(skillAreaFeature.Get());
		}
		return list;
	}

	public FCurThinkInfo GetCurThinkInfo()
	{
		return CurThinkInfo;
	}
}
