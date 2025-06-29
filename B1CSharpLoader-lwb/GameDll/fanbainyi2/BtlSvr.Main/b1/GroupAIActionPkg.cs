using System;

namespace b1;

public class GroupAIActionPkg : IComparable<GroupAIActionPkg>, IEquatable<GroupAIActionPkg>
{
	public int ReqID;

	public float ActionEffectiveTime;

	public float ActionBeginNoiseTime;

	public EGroupCMDType CMDType;

	public IGroupAIActionInfo IGAAI;

	public GroupAIActionPkg(int _ReqID, EGroupCMDType _CMDType, IGroupAIActionInfo _IGAAI, float _TaskLifeTime, float _BeginNoiseTime)
	{
		ReqID = _ReqID;
		CMDType = _CMDType;
		IGAAI = _IGAAI;
		ActionEffectiveTime = _TaskLifeTime;
		ActionBeginNoiseTime = _BeginNoiseTime;
	}

	public int CompareTo(GroupAIActionPkg other)
	{
		if (other == null)
		{
			return -1;
		}
		if (other == this)
		{
			return 0;
		}
		if ((CMDType == EGroupCMDType.ToggleActivateGroupAI && other.CMDType == EGroupCMDType.ToggleActivateGroupAI) || (CMDType >= EGroupCMDType.PRIO_ACT_MoveTo && CMDType <= EGroupCMDType.PRIO_ACT_AddBuff && other.CMDType >= EGroupCMDType.PRIO_ACT_MoveTo && other.CMDType <= EGroupCMDType.PRIO_ACT_AddBuff))
		{
			return -1;
		}
		if (CMDType < other.CMDType)
		{
			return -1;
		}
		return 1;
	}

	public bool Equals(GroupAIActionPkg other)
	{
		return other == this;
	}
}
